using NUnit.Framework;
using CountryInfo;
using System.IO;
using System;
using System.Collections.Generic;

namespace TestCountryInfo
{
    public class Tests
    {
        private CalculateStatistics _statistics;
        private PrintCountriesInfo _printCountries;
        private List<Country> countriesTest;

        [SetUp]
        public void Setup()
        {
            _statistics = new CalculateStatistics();
            _printCountries = new PrintCountriesInfo();
            countriesTest = new List<Country>() 
            {   new Country("Chile", "Santiago", 18191900, 756102), 
                new Country("Argentina", "Buenos Aires", 2780400, 43590400),
                new Country ("Colombia", "Bogotá",48759958,1141748),
                new Country ("Costa Rica","San José",4890379,51100),
                new Country ("Dominican Republic","Santo Domingo",10075045,48671),
                new Country ("Ecuador", "Quito",16545799,276841)
            };
        }

        [Test]
        public void CorrectCompareDensityCountries()
        {
            Country country1 = countriesTest[0];
            Country country2 = countriesTest[0];
            string expectedResult = "Chile Density: 24.060114";
            string result = _statistics.CompareCountries(country1, country2);
            Assert.AreEqual(expectedResult,result);
        }

        [Test]
        public void CorrectCalculateTotalPopulation() {
            long expectedResult = 101243481;
            long result = _statistics.TotalPopulation(countriesTest);
            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void CorrectCalculateAveragePoputionCountries() {
            float expectedResult = (float)16873913.5;
            float result = _statistics.AvgPopulationCountries(countriesTest);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void CorrectOutputStatisticAreaCountry() {
            string expectedResult = "Country: "+ countriesTest[0].Name +" Area: " + countriesTest[0].Area;
            string result = _printCountries.AreaCountry(countriesTest[0]);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void CorrectOutputNullListInTotalPopulationCountries() {

            float expectedResult = (float)0;
            float result = _statistics.TotalPopulation(null);
            Assert.AreEqual(expectedResult, result);
        }

    }
}