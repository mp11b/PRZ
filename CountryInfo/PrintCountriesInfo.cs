using System;
using System.Collections.Generic;
using System.Text;

namespace CountryInfo
{
    public class PrintCountriesInfo
    {
        public void PrintInfoCountries(List<Country>? listCountries) {
            if (listCountries is null)
            {
                Console.WriteLine("This country's does not exist. Try again");
            }
            else {
                foreach (Country country in listCountries)
                {
                    Console.WriteLine(country.ToString());
                }
            }
        }

        public void PrintStatisticCountry(Country? country1,Country? country2, CalculateStatistics statistics,string statistic, List<Country>? countries) {
            if (statistic == "population")
            {
                Console.WriteLine(PopulationCountry(country1));
            }
            else if (statistic == "area")
            {
                Console.WriteLine(AreaCountry(country1));
            }
            else if (statistic == "capital")
            {
                Console.WriteLine(CapitalCountry(country1));
            }
            else if (statistic == "density")
            {
                Console.WriteLine(DensityCountries(country1, country2, statistics));
            }
            else if (statistic == "average")
            {
                Console.WriteLine(AverageCountries(statistics, countries));
            }
            else {
                Console.WriteLine("Statistics not supported ");
            }
        }

        //Functions that return the string to print
        public string PopulationCountry(Country country) {
            if (country is null)
            {
                return "This country does not exist. Try again";
            }
            return "Country: " + country.Name + " Population: "+ country.Population.ToString();
        }

        public string AreaCountry(Country country)
        {
            if (country is null)
            {
                return "This country does not exist. Try again";
            }
            return "Country: " + country.Name + " Area: " + country.Area.ToString();
        }

        public string CapitalCountry(Country? country)
        {
            if (country is null)
            {
                return "This country does not exist. Try again";
            }

            return "Country: " + country.Name + " Capital: " + country.Capital.ToString();
        }

        public string DensityCountries(Country? country1, Country? country2, CalculateStatistics statistics)
        {
            if (country1 is null || country2 is null)
            {
                return "This country1 or country2 does not exist. Try again";
            }

            return "The country with the highest density is " + statistics.CompareCountries(country1, country2).ToString();
        }

        public string AverageCountries(CalculateStatistics statistics, List<Country>? countries) {
            if (countries is null)
            {
                return "Invalid countries";
            }
            return "The average population of all countries is " + statistics.AvgPopulationCountries(countries).ToString();
        }

        public void PrintSortingListCountries(List<Country> countries, int option) {
            if (option == 1)
            {
                foreach (Country country in countries)
                {
                    Console.WriteLine("Country: " + country.Name + " Population: " + country.Population);
                }
            }
            else if (option == 2)
            {
                foreach (Country country in countries)
                {
                    Console.WriteLine("Country: " + country.Name + " Area: " + country.Area);
                }
            }
            else if (option == 3)
            {
                foreach (Country country in countries)
                {
                    Console.WriteLine("Country: " + country.Name + " Density: " + country.Population/country.Area);
                }
            }
        }

        public void PrintTotalPopulation(List<Country> countries, CalculateStatistics statistics) {
            Console.WriteLine("Total Population: {0}",statistics.TotalPopulation(countries));
        }
    }
}
