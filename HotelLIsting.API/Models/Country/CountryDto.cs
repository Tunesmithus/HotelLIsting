using HotelLIsting.API.Models.Hotel;

namespace HotelLIsting.API.Models.Country
{
    public class CountryDto:BaseCountryDto
    {
        public int Id { get; set; }
        
        public List<HotelDto> Hotels { get; set; }


    }
}
