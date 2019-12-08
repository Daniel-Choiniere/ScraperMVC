﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScraperMVC.Models;
using ScraperMVC.ViewModels;

namespace ScraperMVC.Controllers
{
    public class StocksController : Controller
    {
        public ViewResult Index()
        {
            var stocks = GetStocks();

            return View(stocks);
        }

        private IEnumerable<Stock> GetStocks()
        {
            return new List<Stock>
            {
                new Stock { id = 1, Symbol = "BTC" },
                new Stock { id = 2, Symbol = "ETH" }
            };
        }



//        GET: stocks/random
        public IActionResult Random()
        {
            var stock = new Stock() {Symbol = "BTC"};
            var users = new List<User>
            {
                new User { Name = "Dan" },
                new User { Name = "Bean" },
                new User { Name = "Sean" },
                new User { Name = "Al" },
                new User { Name = "Christian" },
                new User { Name = "Joe" }
            };

            var viewModel = new RandomStockViewModel
            {
                Stock = stock,
                Users = users
            };

            return View(viewModel);
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