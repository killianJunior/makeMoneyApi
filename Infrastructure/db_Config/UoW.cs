using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.IRepositories;
using Infrastructure.Repositories;

namespace Infrastructure.db_Config
{
    public class UoW : IUoW, IDisposable
    {
        public AppDbContext DbContext { get; set; }

        public UoW()
        {
            CreateDbContext();
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }

        private void CreateDbContext()
        {
            DbContext = new AppDbContext();

            DbContext.Configuration.ProxyCreationEnabled = false;
        }


        public ICommentRepository Comment
        {
            get
            {
                return new CommentRepository(DbContext);
            }
        }

        public IPostRepository Post
        {
            get
            {
                return new PostRepository(DbContext);
            }
        }

        public IUserRepository Users
        {
            get
            {
                return new UsersRepository(DbContext);
            }
        }



        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (DbContext != null)
                {
                    DbContext.Dispose();
                }
            }
        }
    }
}
