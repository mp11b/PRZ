using System;
using System.Collections.Generic;
using System.Text;

namespace CountryInfo
{
    public interface RESTCountriesInterface
    {
        public List<Country> GetAll();

        public List<Country> GetByName(string countryName);

        public List<Country> GetByCapital(string cityName);

        public List<Country> GetByLanguage(string language);
    }
}
