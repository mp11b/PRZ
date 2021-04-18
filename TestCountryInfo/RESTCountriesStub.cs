using System;
using System.Collections.Generic;
using System.Text;
using CountryInfo;

namespace TestCountryInfo
{
    class RESTCountriesStub : RESTCountriesInterface
    {
        private List<Country> _countries = new List<Country>()
        {
            new Country("Chile", "Santiago", 18191900, 756102),
            new Country("Argentina", "Buenos Aires", 2780400, 43590400),
            new Country ("Colombia", "Bogotá",48759958,1141748),
            new Country ("Costa Rica","San José",4890379,51100),
            new Country ("Dominican Republic","Santo Domingo",10075045,48671),
            new Country ("Ecuador", "Quito",16545799,276841),
            new Country ( "American Samoa","Pago Pago", 57100, 199),
            new Country ("Anguilla", "The Valley", 13452, 91),
            new Country ("British Indian Ocean Territory","Diego Garcia",3000, 60),
            new Country ("Virgin Islands (British)","Road Town", 28514,  151),
            new Country ("Virgin Islands (U.S.)","Charlotte Amalie",114743,(float)346.36)
        };
        public List<Country> GetAll()
        {
            return _countries;
        }

        public List<Country> GetByCapital(string cityName)
        {
            Country _country = _countries.Find(x => x.Capital == cityName);
            List<Country> countriesGetByCapital = new List<Country>() { _country };
            return countriesGetByCapital;
        }

        public List<Country> GetByLanguage(string language)
        {
            if (language is "es")
            {
                _countries.RemoveRange(6, 5);
                return _countries;
            }
            else if (language is "en")
            {
                return _countries;
            }
            else {
                return null;
            }
        }

        public List<Country> GetByName(string countryName)
        {
            Country _country = _countries.Find(x => x.Name == countryName);
            List<Country> countriesGetByName = new List<Country>() { _country };
            return countriesGetByName;
        }
    }
}
