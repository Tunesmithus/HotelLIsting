using AutoMapper;
using HotelLIsting.API.Data;
using HotelLIsting.API.Models.Country;
using HotelLIsting.API.Models.Hotel;

namespace HotelLIsting.API.Configurations
{
    public class MapperConfig:Profile
    {

        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();

            CreateMap<Hotel, HotelDto>().ReverseMap();




        }

    }
}
