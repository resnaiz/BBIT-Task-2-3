using AutoMapper;
using test_code_rest_api.Models;
using test_code_rest_api.ModelsDTO;

namespace test_code_rest_api.Mapper
{
    public class MapperCfg : Profile
    {
        public static IMapper ConfigureMapper(IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<House, HouseDto>();
                config.CreateMap<HouseDto, House>();
                config.CreateMap<Apartment, ApartmentDto>();
                config.CreateMap<ApartmentDto, Apartment>();
                config.CreateMap<Citizen, CitizenDto>();
                config.CreateMap<CitizenDto, Citizen>();
            });

            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            return mapper;
        }
    }
}
