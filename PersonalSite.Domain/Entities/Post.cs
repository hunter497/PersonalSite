using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalSite.Domain.Entities
{
    public class Post
    {
        public int PostID { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Tags { get; set; }
    }
}
