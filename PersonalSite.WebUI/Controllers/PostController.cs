using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalSite.Domain.Entities;
using PersonalSite.Domain.Abstract;
using PersonalSite.WebUI.Models;

namespace PersonalSite.WebUI.Controllers
{
    public class PostController : Controller
    {
        private IPostRepository repository;

        public PostController(IPostRepository postRepository)
        {
            this.repository = postRepository;
        }

        public ViewResult BlogList()
        {
            PostListViewModel model = new PostListViewModel
            {
                Posts = repository.Posts
            };
            return View(model);
        }
    }
}
