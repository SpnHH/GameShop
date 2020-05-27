using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using GameShop.ApplicationLogic.Services;
using GameShop.ApplicationLogic.Model;
using GameShop.Models.Admins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.IO;
using DocumentFormat.OpenXml.Vml;



namespace GameShop.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly AdminServices adminServices;
        public AdminController(UserManager<IdentityUser> userManager, AdminServices adminServices, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.adminServices = adminServices;
            this.roleManager = roleManager;
        }
        public ActionResult Index()
        {
            try
            {
                var userId = userManager.GetUserId(User);
                if (userId == null)
                {
                    return BadRequest("Null");
                }

                var admin = adminServices.GetAdminByAdminId(userId);

                var GameList = adminServices.GetGameList();

                return View(new AdminGamesViewModel { Admin = admin, Games = GameList });
            }
            catch (Exception)
            {
                return BadRequest("aici se blocheaza");
            }
        }


        [HttpPost]
        public IActionResult AddGame([FromForm]AdminAddGameViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            //string fileName = System.IO.Path.GetFileNameWithoutExtension(model.ImageFile.FileName);
            //string externsion = System.IO.Path.GetExtension(model.ImageFile.FileName);
            //fileName = fileName = DateTime.Now.ToString("yymmssfff") + externsion;
            //var path = "~/GameImage/" +fileName;
            //fileName = System.IO.Path.Combine (System.Web.Hosting.HostingEnvironment.MapPath);
            string image = "";
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            using (var memoryStream = new MemoryStream())
            {
                model.ImageFile.CopyTo(memoryStream);
                image = Convert.ToBase64String(memoryStream.ToArray());
            }

            var userId = userManager.GetUserId(User);
            adminServices.addGame(userId, model.Name, model.Price, model.Description, image);
            return RedirectToAction("Index");
            // return Redirect(Url.Action("AddGame", "Admin"));

        }
        [HttpGet]
        public IActionResult AddGame([FromRoute] Game game)
        {
           // var game = adminServices.GetGamebyId(id).Single();
            var gameVM = new AdminAddGameViewModel { Name = game.Name, Price = game.Price, Description = game.Description };
            return View(gameVM);

        }

        [HttpPost]
        public IActionResult DeleteGame([FromForm]AdminDeleteGameViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var userId = userManager.GetUserId(User);

            adminServices.deleteGame(userId, model.Id);
            return Redirect(Url.Action("Index", "Admin"));
            // return Redirect(Url.Action("AddGame", "Admin"));

        }
        [HttpGet]
        public IActionResult DeleteGame([FromRoute]string id)
        {
            var game = adminServices.GetGamebyId(id).Single();
            var gameVM = new AdminDeleteGameViewModel { Id = game.Id};
            return View(gameVM);

        }

        [HttpPost]
        public IActionResult EditGame([FromForm]AdminEditGameView model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var userId = userManager.GetUserId(User);

            adminServices.editGame(userId, model.Id, model.Name, model.Price, model.Description);
            return RedirectToAction("Index");
            // return Redirect(Url.Action("Index", "Admin"));
        }

        [HttpGet]
        public IActionResult EditGame([FromRoute]string id)
        {
            var game = adminServices.GetGamebyId(id).Single();
            var gameVM = new AdminEditGameView { Id = game.Id, Name = game.Name, Price = game.Price, Description = game.Description };
            return View(gameVM);

        }
        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole { Name = model.roleName };

                IdentityResult result = await roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("index", "home");
                }

            }
      
            return View(model);

        }

    }
    
}

