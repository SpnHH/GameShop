using GameShop.ApplicationLogic.Abstractions;
using GameShop.ApplicationLogic.Model;
using GameShop.EFDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameShop.DataAccess
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(GameShopDBContext dBContext) : base(dBContext)
        {

        }
        public Comment GetCommentById(Guid commentId)
        {
            return dbContext.Comments.Where(a => a.Id == commentId).FirstOrDefault();
        }
    }
}
