using PokemonReviewApp.Models;

namespace PokemonReviewAPP.Interface
{
    public interface ICountryRepository
    {

        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int ownerId);
        ICollection<Owner> GetOwnersFromCOuntry(int countryId);
        bool CountryExists(int id); 
    }
}
