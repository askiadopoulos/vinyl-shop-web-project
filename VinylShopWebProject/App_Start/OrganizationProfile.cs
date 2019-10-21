using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VinylShopWebProject.Dtos;
using VinylShopWebProject.Models;

namespace VinylShopWebProject.App_Start
{
    public class OrganizationProfile : Profile
    {
        public OrganizationProfile()
        {
            CreateMap<Vinyl, VinylDto>();
            CreateMap<VinylDto, Vinyl>();
        }
    }
}