using AutoMapper;
using CarService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarService.App_Start
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<CarModel, CarModelDTO>();
                cfg.CreateMap<CarModel, CarModelDetailDTO>();
                cfg.CreateMap<CarModelDetailDTO, CarModel>();
                cfg.CreateMap<Merk, MerkDTO>();
            });
        }
    }
}