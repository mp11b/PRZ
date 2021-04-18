using System;
using System.Collections.Generic;
using System.Text;

namespace CountryInfo
{
    static class RequestUserInfo
    {
        public static int OptionSelectedMenu() {
            while (true)
            {
                try
                {
                    int option = int.Parse(Console.ReadLine());
                    return option;
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Insert correct option");
                    continue;
                }
            }
        }

        public static string OptionSelectedLanguage()
        {
            Console.Write("Write a language: ");
            string languaje = Console.ReadLine();
            return languaje;
        }

        public static string OptionSelectedNameCountry()
        {
            Console.Write("Write a name: ");
            string nameCountry = Console.ReadLine();
            return nameCountry;
        }

        public static string OptionSelectedCapital()
        {
            Console.Write("Write a capital: ");
            string capital = Console.ReadLine();
            return capital;
        }

        public static string OptionSelectedCode()
        {
            Console.Write("Write a code: ");
            string code = Console.ReadLine();
            return code;
        }

        public static string OptionSelectedCurrency()
        {
            Console.Write("Write a currency: ");
            string currency = Console.ReadLine();
            return currency;
        }

        public static string OptionSelectedRegion()
        {
            Console.Write("Write a region: ");
            string region = Console.ReadLine();
            return region;
        }

        public static int OptionSelectedListCountries()
        {
            while (true)
            {
                try
                {
                    int option = int.Parse(Console.ReadLine());
                    if (option > 0 && option <= 4)
                    {
                        return option;
                    }
                    else {
                        Console.WriteLine("Insert correct option");
                        continue;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Insert correct option");
                    continue;
                }
            }
        }

        public static int OptionSelectedSearchInfoCountry()
        {
            while (true)
            {
                try
                {
                    int option = int.Parse(Console.ReadLine());
                    if (option > 0 && option <= 3)
                    {
                        return option;
                    }
                    else
                    {
                        Console.WriteLine("Insert correct option");
                        continue;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Insert correct option");
                    continue;
                }
            }
        }
    }
}
