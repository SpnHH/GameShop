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

namespace GameShop.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly AdminServices adminServices;
        public AdminController(UserManager<IdentityUser> userManager, AdminServices adminServices)
        {
            this.userManager = userManager;
            this.adminServices = adminServices;
        }
        public ActionResult Index()
        {
            try
            {
                var userId = userManager.GetUserId(User);
                var admin = adminServices.GetAdminByAdminId(userId);
                var GameList = adminServices.GetGameList();

                return View(new AdminGamesViewModel { Admin = admin, Games = GameList });
            }
            catch (Exception)
            {
                return BadRequest("Invalid request received ");
            }
        }



        public IActionResult AddGame([FromForm]AdminAddGameViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var userId = userManager.GetUserId(User);
            adminServices.addGame(userId, model.Name, model.Price, model.Description);
            return View();
            // return Redirect(Url.Action("AddGame", "Admin"));

        }

        public IActionResult DeleteGame([FromForm]AdminDeleteGameViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var userId = userManager.GetUserId(User);
            adminServices.deleteGame(userId, model.gameId);
            return Redirect(Url.Action("Index", "Admin"));
            // return Redirect(Url.Action("AddGame", "Admin"));

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

    }
    
}

