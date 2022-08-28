using HotelLIsting.API.Data;

namespace HotelLIsting.API.Contracts
{
    public interface ICountriesRepository: IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);

    }
}
