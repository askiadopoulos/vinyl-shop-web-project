using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VinylShopWebProject.Models;

namespace VinylShopWebProject.ViewModels
{
    public class VinylTopSalesViewModel
    {
        // Properties

        public IEnumerable<Vinyl> Vinyls { get; set; }
    }
}