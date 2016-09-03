using Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Post : BaseEntity
    {
        public string Description { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
