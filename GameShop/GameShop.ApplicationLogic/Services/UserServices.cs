using GameShop.ApplicationLogic.Abstractions;
using GameShop.ApplicationLogic.Exceptions;
using GameShop.ApplicationLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace GameShop.ApplicationLogic.Services
{
    public class UserServices
    {
        private IUserRepository userRepository;
        private IGameRepository gameRepository;
        private ICommentRepository commentRepository;
        private IOrderRepository orderRepository;
        private IRatingRepository ratingRepository;
        private IWishlistRepository wishlistRepository;
        private ICartRepository cartRepository;
        private IBillRepository billRepository;
        SignInManager<IdentityUser> signInManager;
        UserManager<IdentityUser> userManager;
        

        public UserServices(IUserRepository userRepository, IGameRepository gameRepository, ICommentRepository commentRepository, IOrderRepository orderRepository, IRatingRepository ratingRepository, IWishlistRepository wishlistRepository, ICartRepository cartRepository, IBillRepository billRepository)
        {
            this.userRepository = userRepository;
            this.gameRepository = gameRepository;
            this.commentRepository = commentRepository;
            this.orderRepository = orderRepository;
            this.ratingRepository = ratingRepository;
            this.wishlistRepository = wishlistRepository;
            this.cartRepository = cartRepository;
            this.billRepository = billRepository;
        }

        public IEnumerable<Game> GetGameList()
        {
            return gameRepository.GetAll();
        }

        public IEnumerable<Game> GetGameByCategory( string category)
        {
            return gameRepository.GetGameByCategory(category);
        }

        public IEnumerable<Order> GetOrderById(string orderId)
        {
            Guid orderIdGuid = Guid.Empty;
            if (!Guid.TryParse(orderId, out orderIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            return orderRepository.GetOrderByUserId(orderIdGuid);
        }

        public IEnumerable<ShoppingCart> GetCartById(string orderId)
        {
            Guid orderIdGuid = Guid.Empty;
            if (!Guid.TryParse(orderId, out orderIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            return cartRepository.GetCartByUserId(orderIdGuid);
        }
        public ShoppingCart GetCartId(string orderId)
        {
            Guid orderIdGuid = Guid.Empty;
            if (!Guid.TryParse(orderId, out orderIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            return cartRepository.GetCartByCartId(orderIdGuid);
        }
        public Order GetOrderId(string orderId)
        {
            Guid orderIdGuid = Guid.Empty;
            if (!Guid.TryParse(orderId, out orderIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            return orderRepository.GetOrderByOrdeId(orderIdGuid);
        }

        public IEnumerable<Game> GetGamebyId(string gameId)
        {
            Guid gameIdGuid = Guid.Empty;
            if (!Guid.TryParse(gameId, out gameIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }

            return gameRepository.GetAll()
                            .Where(game => game.Id != null && game.Id == gameIdGuid)
                            .AsEnumerable();

        }
        public IEnumerable<Game> GetGamebyGuid(Guid gameId)
        {
           
            return gameRepository.GetAll()
                            .Where(game => game.Id != null && game.Id == gameId)
                            .AsEnumerable();

        }

        public void addOrder(String userId, Guid gameId)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            var user = userRepository.GetUserById(userIdGuid);
            var game = gameRepository.GetGamebyId(gameId);
            
            orderRepository.Add(new Order()
            {
                Id = Guid.NewGuid(),
                User = user,
                Date = DateTime.Today,
                TotalValue = game.Price,
                GameId = game.Id
            }) ; 

        }

        public void deleteOrder( string orderId)
        {

            var order = GetOrderId(orderId);

            if (order == null)
            {
       
            }
       
            orderRepository.Delete(order);

        }
        public void addToCart(String userId, Guid gameId)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            var user = userRepository.GetUserById(userIdGuid);
            var game = gameRepository.GetGamebyId(gameId);

            cartRepository.Add(new ShoppingCart()
            {
                Id = Guid.NewGuid(),
                UserId = user.Id,
                Quantity = 1,
                GameId = game.Id
            });
        }
        public void addWish(String userId, Guid gameId)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            var user = userRepository.GetUserById(userIdGuid);
            var game = gameRepository.GetGamebyId(gameId);

            wishlistRepository.Add(new Wishlist()
            {
                Id = Guid.NewGuid(),
                UserId = user.Id,
                GameId = game.Id

            });

        }

        public void addComment(String userId, Guid gameId, String comm)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            var user = userRepository.GetUserById(userIdGuid);
           
            
            Guid commId = Guid.NewGuid();

            commentRepository.Add(new Comment()
            {
                Id = commId,
                UserId = user.Id,
                Comm = comm,
                GameId = gameId,
                Username = user.Email
            }); 
            
            

        }

        public void addRating(String userId, Guid gameId, float rate)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            var user = userRepository.GetUserById(userIdGuid);
            Guid RatingId = Guid.NewGuid();
            
            ratingRepository.Add(new Rating()
            {
                Id = RatingId,
                User = user,
                Rate = rate,
                GameId = gameId
            });        
        }

        public IEnumerable<Comment> GetComments(Game game)
        {
            return commentRepository.GetCommentByGameId(game.Id);
        }
        public float GetAverageRating(Game game)
        {
            var ratings = ratingRepository.GetRatingByGameId(game.Id);
            int count = 0;
            float avg = 0;
            foreach( var rate in ratings)
            {
                avg += rate.Rate;
                count++;
            }
            return (avg / count);
        }

        public void addBill(String userId, Guid gameId, String address, String phoneNumber, String cardNumber, String expirationDate, String cvv, int TotalValue)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            var game = gameRepository.GetGamebyId(gameId);
            billRepository.Add(new Bill()
            {
                Id = Guid.NewGuid(),
                UserId = userIdGuid,
                GameId = gameId,
                Address = address,
                PhoneNumber = phoneNumber,
                CardNumber = cardNumber,
                ExpirationDate = expirationDate,
                CVV = cvv,
                TotalValue = (int)game.Price
            }); 

        }

        public IEnumerable<Bill> GetBillsByUserId(string billId)
        {
            Guid billIdGuid = Guid.Empty;
            if (!Guid.TryParse(billId, out billIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            return billRepository.GetBillByUserId(billIdGuid);
        }

        public void deleteCart(string cartId)
        {
            var cart = GetCartId(cartId);
            if (cart == null)
            {

            }
            cartRepository.Delete(cart);
        }

    }

}
