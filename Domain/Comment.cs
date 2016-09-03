using Domain.SeedWork;
using System;

namespace Domain
{
    public class Comment : BaseEntity
    {
        public string Description { get; set; }
        public DateTime CommentTimeAndDate { get; set; }

        //User That made the comment
        public Guid UserId { get; set; }
        public virtual Users User { get; set; }

    }
}