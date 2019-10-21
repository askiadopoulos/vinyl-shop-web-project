using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VinylShopWebProject.Dtos;
using VinylShopWebProject.Models;

namespace VinylShopWebProject.Controllers.api
{
    public class VinylsController : ApiController
    {
        private ApplicationDbContext context;

        public VinylsController()
        {
            context = new ApplicationDbContext();
        }

        //public IEnumerable<VinylDto> GetVinyls(string query = null)
        //{

        //}
    }
}
