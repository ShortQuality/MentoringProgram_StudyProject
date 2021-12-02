using System.Collections.Generic;
using AutoMapper;
using MP_OnlineStore.Application.Data.Models;
using MP_OnlineStore.Core.Entities;

namespace MP_OnlineStore.Application.MappingProfiles
{
    public class DtoMapperProfile : Profile
    {
        public DtoMapperProfile()
        {
            CreateMap<Product, ProductDto>()
                .ReverseMap();

            //CreateMap<IEnumerable<Product>, IEnumerable<ProductDto>>()
            //    .ReverseMap();

            CreateMap<Category, CategoryDto>()
                .ForMember(dest => 
                dest.Products,
                opt => opt.MapFrom(src => src.Products))
                .ReverseMap();

            //CreateMap<IEnumerable<Category>, IEnumerable<CategoryDto>>()
            //    .ReverseMap();
        }
    }
}
