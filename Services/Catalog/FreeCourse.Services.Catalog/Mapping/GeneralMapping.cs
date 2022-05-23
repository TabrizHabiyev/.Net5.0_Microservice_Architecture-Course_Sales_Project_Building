using AutoMapper;
using FreeCourse.Services.Catalog.Dtos;
using FreeCourse.Services.Catalog.Models;

namespace FreeCourse.Services.Catalog.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Course, CourceDto>().ReverseMap();

            CreateMap<Category, CategoryDto>().ReverseMap();

            CreateMap<Feature, FeatureDto>().ReverseMap();

            CreateMap<Cource, CourceCreateDto>().ReverseMap();

            CreateMap<Cource, CourceUpdateDto>().ReverseMap();

        }
    }
}
