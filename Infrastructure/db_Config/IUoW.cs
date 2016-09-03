using Infrastructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.db_Config
{
    public interface IUoW
    {
        IUserRepository Users { get; }
        IPostRepository Post { get; }
        ICommentRepository Comment { get; }
    }
}
