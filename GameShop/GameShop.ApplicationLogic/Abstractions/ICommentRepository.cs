using GameShop.ApplicationLogic.Model;
using System;
using System.Collections.Generic;
using System.Text;


namespace GameShop.ApplicationLogic.Abstractions
{
    public interface ICommentRepository : IRepository<Comment>
    {
        Comment GetCommentById(Guid commentId);
        IEnumerable<Comment> GetCommentByGameId(Guid gameId);
        IEnumerable<Comment> GetCommentByUserId(Guid userId);

    }
}
