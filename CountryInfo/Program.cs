using System;

namespace CountryInfo
{
    public class Program
    {
        public static void Main()
        {
            RESTCountries apiCountries = new RESTCountries();
            CalculateStatistics calculateStatistics = new CalculateStatistics();
            PrintCountriesInfo printCountries = new PrintCountriesInfo();
            ConsoleUI consoleUI = new ConsoleUI(apiCountries, calculateStatistics, printCountries);
            consoleUI.UI();
        }
    }
}
