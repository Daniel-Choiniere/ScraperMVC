using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScraperMVC.Models;

namespace ScraperMVC.ViewModels
{
    public class RandomStockViewModel
    {
        public Stock Stock { get; set; }
        public List<User> Users { get; set; }
    }
}
