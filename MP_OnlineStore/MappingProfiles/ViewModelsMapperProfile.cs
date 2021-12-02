using System.Collections.Generic;
using AutoMapper;
using MP_OnlineStore.Application.Data.Models;
using MP_OnlineStore.WEB.ViewModels;

namespace MP_OnlineStore.WEB.MappingProfiles
{
    public class ViewModelsMapperProfile : Profile
    {
        public ViewModelsMapperProfile()
        {
            CreateMap<ProductDto, ProductViewModel>()
                .ReverseMap();

            //CreateMap<IEnumerable<ProductDto>, IEnumerable<ProductViewModel>>()
            //    .ReverseMap();

            CreateMap<CategoryDto, CategoryViewModel>()
                .ForMember(dest => 
                dest.Products,
                opt => opt.MapFrom(src => src.Products))
                .ReverseMap();

        }
    }
}
