using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VinylShopWebProject.Models;

namespace VinylShopWebProject.ViewModels
{
    public class TopSalesViewModel
    {
        public Vinyl Vinyl { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}