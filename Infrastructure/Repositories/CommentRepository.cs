using Domain;
using Infrastructure.IRepositories;
using Infrastructure.SeedWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(DbContext context)
            :base(context)
        {
                
        }
    }
}
