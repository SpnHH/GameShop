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

        public AdminServices(IAdminRepository adminRepository,
                             IGameRepository gameRepository,
                             IUserRepository userRepository,
                             ICommentRepository commentRepository,
                             IOrderRepository orderRepository,
                             IRatingRepository ratingRepository
                            )
        { 
            this.gameRepository = gameRepository;
            this.adminRepository = adminRepository;
            this.userRepository = userRepository;
            this.commentRepository = commentRepository;
            this.orderRepository = orderRepository;
            this.ratingRepository = ratingRepository;

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

        public void addGame(String userId, String gameName, float gamePrice, String gameDescription, String Image)
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
                ImageFile = Image
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
            Guid DummyId = Guid.Empty;


            var comments = commentRepository.GetCommentByGameId(gameId).ToList();
            var orders = orderRepository.GetOrderByGameId(gameId).ToList();
            var ratings = ratingRepository.GetRatingByGameId(gameId).ToList();
            if (comments != null)
            {
                foreach (var comment in comments)
                {
                    commentRepository.Delete(comment);
                }
            }
            if (orders != null)
            {
                foreach (var order in orders)
                {
                    order.GameId = Guid.Empty;
                    orderRepository.Update(order);
                    //orderRepository.Add(new Order()
                    //{                    
                    //    Id = order.Id,
                    //    User = order.User,
                    //    Date = order.Date,
                    //    TotalValue = order.TotalValue,
                    //    GameId = DummyId
                    //});
                }

                if (ratings != null)
                {
                    foreach (var rating in ratings)
                    {
                        ratingRepository.Delete(rating);
                    }
                }

                gameRepository.Delete(game);

            }
        }
        public void editGame(String userId, Guid gameId , String gameName, float Price, String gameDescription)
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

            gameRepository.Update(game);

        }

    }
}
