using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScraperMVC.Models;

namespace ScraperMVC.Controllers
{
    public class StocksController : Controller
    {
//        GET: stocks/random
        public IActionResult Random()
        {
            var stock = new Stock() {Symbol = "BTC"};
            return View();
        }

        public IActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

//        stocks
        public IActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
}