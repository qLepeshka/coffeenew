using CoffeeNew.Models.Entities;
using CoffeeNew.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace CoffeeNew.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {

        public NewsRepository _newsRepository;


        public AdminController(NewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public ActionResult Index()
        {
            bool isAdmin = User.IsInRole("Administrator");

            return View();
        }

        public ActionResult Users()
        {
            var listUsers = new List<string>();

            return View(listUsers);
        }

        public async Task<ActionResult> News()
        {
            var listNews = await _newsRepository.GetNewsAsync();

            return View(listNews);

        }

            public ActionResult Details(int id)
        {
            return View();
        }



    }
}
