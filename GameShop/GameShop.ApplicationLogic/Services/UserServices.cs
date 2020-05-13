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

        public void addOrder(String userId, String orderId, String gameId)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            var user = userRepository.GetUserById(userIdGuid);

            Guid gameIdGuid = Guid.Empty;
            if (!Guid.TryParse(gameId, out gameIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            var game = gameRepository.GetGamebyId(gameIdGuid);

            orderRepository.Add(new Order()
            {
                Id = Guid.NewGuid(),
                User = user,
                Game= game,
                Date = DateTime.Today,
                TotalValue = game.Price

            }) ; 


        }

        public void addComment(String userId, String commentId, String gameId, String comm)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            var user = userRepository.GetUserById(userIdGuid);

            //commentRepository.Add(new Comment()
            //{
            //    Id = Guid.NewGuid(),
            //    CommentId = Guid.NewGuid(),
            //    User = user,
            //    Comm = comm

            //}) ;
            

        }

        public void addRaing(String userId, String gameId, float rate)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid Format");
            }
            var user = userRepository.GetUserById(userIdGuid);

            ratingRepository.Add(new Rating()
            {
                Id = Guid.NewGuid(),
                User = user,
                Rate = rate
            });
        }

    }

}
