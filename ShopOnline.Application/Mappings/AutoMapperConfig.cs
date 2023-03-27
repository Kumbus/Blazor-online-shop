using AutoMapper;
using ShopOnline.Application.DTOs.ProductDTOs;
using ShopOnline.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Application.Mappings
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                
                cfg.CreateMap<Product, ProductDto>().ForMember(dto => dto.CategoryName, opt => opt.MapFrom(p => p.ProductCategory.Name));


            }).CreateMapper();
    }
}
