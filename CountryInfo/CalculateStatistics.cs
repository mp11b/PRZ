using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CountryInfo
{
    public class CalculateStatistics
    {
        private static int POPULATION = 1;
        private static int AREA = 2;
        private static int DENSITY = 3;


        public float AvgPopulationCountries(List<Country>? countries)
        {
            if (countries is null)
            {
                return 0;
            }

            else {
                float sum = 0;
                float totalCountries = countries.Count;

                foreach (Country country in countries)
                {
                    sum += country.Population;
                }

                return sum / totalCountries;
            }
        }

        public long TotalPopulation(List<Country>? countries) {
            long totalPopulation = 0;
            if (countries is null)
            {
                totalPopulation = 0;
            }
            else {
                foreach (Country country in countries)
                {
                    totalPopulation += country.Population;
                }
            }
            return totalPopulation;
        }
        //Compare two countries by their density 
        public string CompareCountries(Country country1, Country country2) {

            float popDensity1 = CalculateDensityCountry(country1);
            float popDensity2 = CalculateDensityCountry(country2);

            if (popDensity1 > popDensity2)
            {
                return country1.Name + " Density: " + popDensity1.ToString();
            }
            else {
                return country2.Name + " Density: " + popDensity2.ToString();
            }

        }

        public float CalculateDensityCountry(Country country) {
            return country.Population / (float)country.Area;
        }

        public List<Country> SortingOfCountries(List<Country>? countries, int option) {
            if (option == POPULATION)
            {
                List<Country> countriesSorted = countries.OrderBy(country => country.Population).ToList();
                return countriesSorted;
            }
            else if (option == AREA)
            {
                List<Country> countriesSorted = countries.OrderBy(country => country.Area).ToList();
                return countriesSorted;
            }
            else if (option == DENSITY)
            {
                List<Country> countriesSorted = countries.OrderBy(country => country.Population/ country.Area).ToList();
                return countriesSorted;
            }
            else {
                return null;
            }

        }


    }
}
