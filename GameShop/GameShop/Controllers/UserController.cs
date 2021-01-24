using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using GameShop.ApplicationLogic.Services;
using GameShop.ApplicationLogic.Model;
using GameShop.Models.Users;
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
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly UserServices userServices;
        public UserController(UserManager<IdentityUser> userManager, UserServices userServices)
        {
            this.userManager = userManager;
            this.userServices = userServices;
        }

        public IActionResult ViewGame([FromRoute] string id)
        {
            var game = userServices.GetGamebyId(id).Single();
            var rating = userServices.GetAverageRating(game);
            var comments = userServices.GetComments(game);
            var gameVM = new UserMainGameViewModel { Game = game, Comments = comments, Rating = rating };
            return View(gameVM);
        }

        public IActionResult ViewOrders([FromRoute] string id)
        {
            var order = userServices.GetOrderById(id);
            var game = userServices.GetGameList();
            var gameVM = new ViewOrders {Orders = order, Games = game };
            return View(gameVM);
        }

        public IActionResult ViewCart([FromRoute] string id)
        {
            var carts = userServices.GetCartById(id);
            var game = userServices.GetGameList();
            var gameVM = new ViewCart { Orders = carts, Games = game };
            return View(gameVM);
        }

        public IActionResult DeleteOrder([FromRoute] string id)
        {
          
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            userServices.deleteOrder(id);
            return Redirect(Url.Action("Index", "User"));
        }

        public ActionResult Index()
        {
            try
            {        
                    var GameList = userServices.GetGameList();
                    return View(new UserGameViewModel { Games = GameList });

            }
            catch (Exception)
            {
                return BadRequest("aici se blocheaza");
            }
        }
 
        public ActionResult ViewGamesRPG()
        {
            try
            {
                string cat = "RPG";
                    var GameList = userServices.GetGameByCategory(cat);
                    return View(new UserGameViewModel { Games = GameList });  

            }
            catch (Exception)
            {
                return BadRequest("aici se blocheaza");
            }
        }

        public ActionResult ViewGamesAdventure()
        {
            try
            {
                string cat = "Adventure";
                var GameList = userServices.GetGameByCategory(cat);
                return View(new UserGameViewModel { Games = GameList });

            }
            catch (Exception)
            {
                return BadRequest("aici se blocheaza");
            }
        }
        public ActionResult ViewGamesArcade()
        {
            try
            {
                string cat = "Arcade";
                var GameList = userServices.GetGameByCategory(cat);
                return View(new UserGameViewModel { Games = GameList });

            }
            catch (Exception)
            {
                return BadRequest("aici se blocheaza");
            }
        }

        [HttpPost]
        public IActionResult AddComment([FromForm]UserAddCommentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var userId = userManager.GetUserId(User);

            userServices.addComment(userId, model.gameID, model.Comm);
            //var game = userServices.GetGamebyGuid(model.gameID).Single();
            //var rating = userServices.GetAverageRating(game);
            //var comments = userServices.GetComments(game);
            //var gameVM = new UserMainGameViewModel { Game = game, Comments = comments, Rating = rating };
            ViewGame(model.gameID.ToString());
            return RedirectToAction("Index");


        }

        [HttpGet]
        public IActionResult AddComment([FromRoute]string id)
        {
            var game = userServices.GetGamebyId(id).Single();
            var gameVM = new UserAddCommentViewModel { gameID = game.Id};
            return View(gameVM);

        }

        public IActionResult DeleteComment([FromForm] UserAddCommentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var userId = userManager.GetUserId(User);

            userServices.addComment(userId, model.gameID, model.Comm);
            //var game = userServices.GetGamebyGuid(model.gameID).Single();
            //var rating = userServices.GetAverageRating(game);
            //var comments = userServices.GetComments(game);
            //var gameVM = new UserMainGameViewModel { Game = game, Comments = comments, Rating = rating };
            ViewGame(model.gameID.ToString());
            return RedirectToAction("Index");


        }

        [HttpGet]
        public IActionResult DeleteComment([FromRoute] string id)
        {
            var game = userServices.GetGamebyId(id).Single();
            var gameVM = new UserAddCommentViewModel { gameID = game.Id };
            return View(gameVM);

        }


        [HttpPost]
        public IActionResult AddRating([FromForm]UserAddRatingViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var userId = userManager.GetUserId(User);

            userServices.addRating(userId, model.gameID, model.Rate);


           
            return RedirectToAction("Index");
            // return Redirect(Url.Action("Index", "Admin"));
        }

        [HttpGet]
        public IActionResult AddRating([FromRoute]string id)
        {
            var game = userServices.GetGamebyId(id).Single();
            var gameVM = new UserAddRatingViewModel { gameID = game.Id };
            return View(gameVM);

        }

        [HttpPost]
        public IActionResult AddOrder([FromForm]AddOrderModelView model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var userId = userManager.GetUserId(User);
            userServices.addOrder(userId, model.GameId);
            return RedirectToAction("Index");
            // return Redirect(Url.Action("Index", "Admin"));
        }

        [HttpGet]
        public IActionResult AddOrder([FromRoute]string id)
        {
            var game = userServices.GetGamebyId(id).Single();
            var gameVM = new AddOrderModelView {GameId = game.Id};
            return View(gameVM);

        }

        [HttpPost]
        public IActionResult AddCart([FromForm] AddCartModelView model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var userId = userManager.GetUserId(User);
            userServices.addToCart(userId, model.GameId);
            return RedirectToAction("Index");
            // return Redirect(Url.Action("Index", "Admin"));
        }

        [HttpGet]
        public IActionResult AddCart([FromRoute] string id)
        {
            var game = userServices.GetGamebyId(id).Single();
            var gameVM = new AddCartModelView { GameId = game.Id };
            return View(gameVM);
        }

            [HttpPost]
        public IActionResult AddWish([FromForm] AddOrderModelView model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var userId = userManager.GetUserId(User);
            userServices.addWish(userId, model.GameId);
            return RedirectToAction("Index");
            // return Redirect(Url.Action("Index", "Admin"));
        }

        [HttpGet]
        public IActionResult AddWish([FromRoute] string id)
        {
            var game = userServices.GetGamebyId(id).Single();
            var gameVM = new AddWishModelView { GameId = game.Id };
            return View(gameVM);

        }

        [HttpPost]
        public IActionResult AddBill([FromForm] AddBillModelView model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var userId = userManager.GetUserId(User);
            userServices.addBill(userId, model.GameId, model.Address, model.PhoneNumber, model.CardNumber,model.ExpirationDate, model.CVV,model.TotalValue);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddBill([FromRoute] string id)
        {
            var game = userServices.GetGamebyId(id).Single();
            var gameVM = new AddBillModelView { Address = null, CardNumber = null, PhoneNumber = null, CVV = null, ExpirationDate = null, TotalValue = 0, GameId = game.Id };
            return View(gameVM);
        }


        public IActionResult ViewBills([FromRoute] string id)
        {
            var bills = userServices.GetBillsByUserId(id);
            var game = userServices.GetGameList();
            var gameVM = new ViewBills { Bills = bills, Games = game };
            return View(gameVM);
        }

        public IActionResult DeleteCart([FromRoute] string id)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            userServices.deleteCart(id);
            return Redirect(Url.Action("Index", "User"));
        }
    }

}

