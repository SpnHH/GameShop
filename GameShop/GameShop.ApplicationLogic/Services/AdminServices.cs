using GameShop.ApplicationLogic.Abstractions;
using GameShop.ApplicationLogic.Exceptions;
using GameShop.ApplicationLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameShop.ApplicationLogic.Services
{
    public class AdminServices
    {
        private IAdminRepository adminRepository;
        private IGameRepository gameRepository;
        private IUserRepository userRepository;
        private ICommentRepository commentRepository;
        private IOrderRepository orderRepository;
        private IRatingRepository ratingRepository;
        private IWishlistRepository wishlistRepository;

        public AdminServices(IAdminRepository adminRepository,
                             IGameRepository gameRepository,
                             IUserRepository userRepository,
                             ICommentRepository commentRepository,
                             IOrderRepository orderRepository,
                             IRatingRepository ratingRepository,
                             IWishlistRepository wishlistRepository
                            )
        { 
            this.gameRepository = gameRepository;
            this.adminRepository = adminRepository;
            this.userRepository = userRepository;
            this.commentRepository = commentRepository;
            this.orderRepository = orderRepository;
            this.ratingRepository = ratingRepository;
            this.wishlistRepository = wishlistRepository;
        }
        public Admin GetAdminByAdminId(string userId)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            var admin = adminRepository.GetAdminByAdminId(userIdGuid);

            if (admin == null)
            {
                throw new EntityNotFoundException(userIdGuid);
            }
            return admin;
        }

        public IEnumerable<Game> GetGameList()
        {
            return gameRepository.GetAll();
        }

        public IEnumerable<Game> GetGamebyId( string gameId)
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

        public void addGame(String userId, String gameName, float gamePrice, String gameDescription, String Image, int gameStock, string category)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            var admin = adminRepository.GetAdminByAdminId(userIdGuid);
            if (admin == null)
            {
                throw new EntityNotFoundException(userIdGuid);
            }

            gameRepository.Add(new Game()
            {
                Id = Guid.NewGuid(),
                Admin = admin,
                Name = gameName,
                Price = gamePrice,
                Description = gameDescription,
                ImageFile = Image,
                Stock = gameStock,
                Category = category
            }) ;


        }

        public void deleteGame(String userId, Guid gameId)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            var admin = adminRepository.GetAdminByAdminId(userIdGuid);
            if (admin == null)
            {
                throw new EntityNotFoundException(userIdGuid);
            }


            var game = gameRepository.GetGamebyId(gameId);
            if (game == null)
            {
                throw new EntityNotFoundException(userIdGuid);
            }
            game.Stock = 0;
            gameRepository.Update(game);

            }
        public void editGame(String userId, Guid gameId , String gameName, float Price, String gameDescription, int Stock, string category)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            var admin = adminRepository.GetAdminByAdminId(userIdGuid);
            if (admin == null)
            {
                throw new EntityNotFoundException(userIdGuid);
            }


            var game = gameRepository.GetGamebyId(gameId);
            if (game == null)
            {
                throw new EntityNotFoundException(userIdGuid);
            }

            game.Name = gameName;
            game.Price = Price;
            game.Description = gameDescription;
            game.Stock = Stock;
            game.Category = category;
            gameRepository.Update(game);

        }
        


    }
}
