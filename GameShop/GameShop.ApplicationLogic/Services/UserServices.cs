using GameShop.ApplicationLogic.Abstractions;
using GameShop.ApplicationLogic.Exceptions;
using GameShop.ApplicationLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameShop.ApplicationLogic.Services
{
    public class UserServices
    {
        private IUserRepository userRepository;
        private IGameRepository gameRepository;
        private ICommentRepository commentRepository;
        private IOrderRepository orderRepository;
        private IRatingRepository ratingRepository;
   

        public UserServices(IUserRepository userRepository, IGameRepository gameRepository, ICommentRepository commentRepository, IOrderRepository orderRepository, IRatingRepository ratingRepository)
        {
            this.userRepository = userRepository;
            this.gameRepository = gameRepository;
            this.commentRepository = commentRepository;
            this.orderRepository = orderRepository;
            this.ratingRepository = ratingRepository;
        }

        public IEnumerable<Game> GetGameList()
        {
            return gameRepository.GetAll();
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
                User = user,
                Comm = comm,
                GameId = gameId
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



    }

}
