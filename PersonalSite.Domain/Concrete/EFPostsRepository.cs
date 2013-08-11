using System.Linq;
using PersonalSite.Domain.Entities;
using PersonalSite.Domain.Abstract;

namespace PersonalSite.Domain.Concrete
{
    public class EFPostsRepository : IPostRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<Post> Posts
        {
            get { return context.Posts; }
        }
    }
}
