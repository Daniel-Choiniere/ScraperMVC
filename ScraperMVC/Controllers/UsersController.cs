using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScraperMVC.Models;
using ScraperMVC.ViewModels;

namespace ScraperMVC.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            var users = GetUsers();

            return View(users);
        }

        public IActionResult Details(int id)
        {
            var user = GetUsers().SingleOrDefault(c => c.Id == id);

            if (user == null)
                throw new NotImplementedException();

            return View(user);
        }


        private IEnumerable<User> GetUsers()
        {
            return new List<User>
            {
                new User { Id = 1, Name = "Mark Appleyard" },
                new User { Id = 2, Name = "Bam Margera" }
            };
        }
    }
}