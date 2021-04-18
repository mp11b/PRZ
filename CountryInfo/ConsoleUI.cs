using System;
using System.Collections.Generic;
using System.Text;

namespace CountryInfo
{
    public class ConsoleUI
    {
        private RESTCountries apiCountries;
        private CalculateStatistics statistics;
        private PrintCountriesInfo printCountries;

        public ConsoleUI(RESTCountries apiCountries, CalculateStatistics statistics, PrintCountriesInfo printCountries)
        {
            this.apiCountries = apiCountries;
            this.statistics = statistics;
            this.printCountries = printCountries;
        }

        public void DisplayMenu() {
            Console.WriteLine("\nHello, select a your option: ");
            Console.WriteLine("[1] Get the population average of all countries");
            Console.WriteLine("[2] Get information and total population from a list of countries");
            Console.WriteLine("[3] Get statistics from one or two countries");
            Console.WriteLine("[4] Get information country");
            Console.WriteLine("[5] Sorting of a list of countries by population, area, and density.");
            Console.Write("Option: ");
        }

        public void DisplayOptionsGetStatisticsCountries() {
            Console.WriteLine("Options -> population/area/capital/density (Two countries are required)");
            Console.Write("Write the statistic you want to know :");
        }

        public void DisplaySelectCountry1() {
            Console.Write("Select country 1: ");
        }

        public void DisplaySelectCountry2()
        {
            Console.Write("Select country 2: ");
        }

        public void DisplayOptionsListCountries()
        {
            Console.WriteLine("Choose a list:");
            Console.WriteLine("[1] Get Countries By Language");
            Console.WriteLine("[2] Get Countries By Currency");
            Console.WriteLine("[3] Get Countries By Region");
            Console.WriteLine("[4] Get All Countries");
        }

        public void DisplayOptionsSortListCountries()
        {
            Console.WriteLine("Choose a list to sort:");
            Console.WriteLine("[1] Get All Countries");
            Console.WriteLine("[2] Get Countries By Language");
            Console.WriteLine("[3] Get Countries By Currency");
            Console.WriteLine("[4] Get Countries By Region");
        }

        public void DisplayOptionsSortingListCountries() {
            Console.WriteLine("Choose an option to sort the countries:");
            Console.WriteLine("[1] Population");
            Console.WriteLine("[2] Area");
            Console.WriteLine("[3] Density");
        }

        public void DisplayOptionsInfoCountry()
        {
            Console.WriteLine("Search the country by:");
            Console.WriteLine("[1] Name");
            Console.WriteLine("[2] Capital");
            Console.WriteLine("[3] Code");
        }

        public void PrintError() {
            Console.WriteLine("Please enter a valid number");
        }



        public void UI() {

            List<Country> prueba = apiCountries.GetByCurrency("cop");
            Console.WriteLine(prueba[0].ToString());

            while (true) {
                DisplayMenu();
                int option = RequestUserInfo.OptionSelectedMenu();
                switch (option) {
                    case 1:
                        List<Country> totalCountries = apiCountries.GetAll();
                        printCountries.PrintStatisticCountry(null,null,statistics,"average",totalCountries);
                        break;
                    case 2:
                        DisplayOptionsListCountries();
                        int optionListSelected = RequestUserInfo.OptionSelectedListCountries();
                        List<Country> _listCountriesInfo = new List<Country>();
                        if (optionListSelected == 1)
                        {
                            string language = RequestUserInfo.OptionSelectedLanguage();
                            _listCountriesInfo = apiCountries.GetByLanguage(language);
                        }
                        else if (optionListSelected == 2)
                        {
                            string currency = RequestUserInfo.OptionSelectedCurrency();
                            _listCountriesInfo = apiCountries.GetByCurrency(currency);
                        }
                        else if (optionListSelected == 3)
                        {
                            string region = RequestUserInfo.OptionSelectedRegion();
                            _listCountriesInfo = apiCountries.GetByRegion(region);
                        }
                        else if (optionListSelected == 4) {
                            _listCountriesInfo = apiCountries.GetAll();
                        }
                        printCountries.PrintInfoCountries(_listCountriesInfo);
                        printCountries.PrintTotalPopulation(_listCountriesInfo,statistics);
                        break;
                    case 3:
                        DisplayOptionsGetStatisticsCountries();
                        string stadistic = Console.ReadLine();
                        DisplaySelectCountry1();
                        string nameCountry1 = RequestUserInfo.OptionSelectedNameCountry();
                        Country? country1 = apiCountries.GetByName(nameCountry1)[0];

                        if (stadistic == "density")
                        {
                            DisplaySelectCountry2();
                            string nameCountry2 = RequestUserInfo.OptionSelectedNameCountry();
                            Country? country2 = apiCountries.GetByName(nameCountry2)[0];
                            printCountries.PrintStatisticCountry(country1, country2, statistics, stadistic,null);
                        }
                        else {
                            printCountries.PrintStatisticCountry(country1,null,statistics, stadistic,null);
                        }
                        break;
                    case 4:
                        DisplayOptionsInfoCountry();
                        int optionSearchInfoCountry = RequestUserInfo.OptionSelectedSearchInfoCountry();
                        List<Country> _country = new List<Country>();
                        if (optionSearchInfoCountry == 1)
                        {
                            string nameCountry = RequestUserInfo.OptionSelectedNameCountry();
                            _country = apiCountries.GetByName(nameCountry);
                        }
                        else if (optionSearchInfoCountry == 2) 
                        {
                            string capital = RequestUserInfo.OptionSelectedCapital();
                            _country = apiCountries.GetByCapital(capital);
                        }
                        else if (optionSearchInfoCountry == 3) 
                        {
                            string code = RequestUserInfo.OptionSelectedCode();
                            _country = apiCountries.GetByCode(code);
                        }
                        printCountries.PrintInfoCountries(_country);
                        break;
                    case 5:
                        DisplayOptionsSortListCountries();
                        int optionListSelectedSort = RequestUserInfo.OptionSelectedListCountries();
                        List<Country> _listCountries = new List<Country>();
                        if (optionListSelectedSort == 1) {
                            _listCountries = apiCountries.GetAll();
                        }
                        else if (optionListSelectedSort == 2)
                        {
                            string languageSelected = RequestUserInfo.OptionSelectedLanguage();
                            _listCountries = apiCountries.GetByLanguage(languageSelected);
                        }
                        else if (optionListSelectedSort == 3)
                        {
                            string currency = RequestUserInfo.OptionSelectedCurrency();
                            _listCountries = apiCountries.GetByCurrency(currency);
                        }
                        else if (optionListSelectedSort == 4)
                        {
                            string region = RequestUserInfo.OptionSelectedRegion();
                            _listCountries = apiCountries.GetByRegion(region);
                        }
                        DisplayOptionsSortingListCountries();
                        int optionSortingList = RequestUserInfo.OptionSelectedListCountries();
                        List<Country> sortList = statistics.SortingOfCountries(_listCountries, optionSortingList);
                        printCountries.PrintSortingListCountries(sortList, optionSortingList);
                        break;
                    default:
                        PrintError();
                        break;
                }
            }
        }
    }
}
