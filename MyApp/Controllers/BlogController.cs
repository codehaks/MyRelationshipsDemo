using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApp.Data;
using MyApp.Models;

namespace MyApp.Controllers
{
    public class BlogController : Controller
    {
        public BlogController(AppDbContext db)
        {
            var newBlog = new Blog();
            newBlog.Name = "Hey";
            newBlog.Posts = new List<Post>();

            newBlog.Posts.Add(new Models.Post
            {
                Title = "Check",
                Content = "This is a new hey post"
            });

            db.Blogs.Add(newBlog);
            db.SaveChanges();
        }

        [Route("api/blog")]
        public IActionResult Index()
        {
            return View();
        }
    }
}