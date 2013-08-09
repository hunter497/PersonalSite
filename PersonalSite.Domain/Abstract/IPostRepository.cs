using System;
using System.Collections.Generic;
using System.Linq;
using PersonalSite.Domain.Entities;

namespace PersonalSite.Domain.Abstract
{
    public interface IPostRepository
    {
        IQueryable<Post> Posts { get; }
    }
}
