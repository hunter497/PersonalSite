using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PersonalSite.Domain.Entities;

namespace PersonalSite.WebUI.Models
{
    public class PostListViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
    }
}