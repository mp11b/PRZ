using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CountryInfo
{
    // REST Countries API docs available at: https://restcountries.eu/
    public class RESTCountries: RESTCountriesInterface
    {
        private const string baseApiUrl = "https://restcountries.eu/rest/v2/";

        public List<Country> GetAll()
        {
            return Get("all");
        }

        public List<Country> GetByName(string countryName)
        {
            return Get("name/" + countryName);
        }

        public List<Country> GetByCapital(string cityName)
        {
            return Get("capital/" + cityName);
        }

        public List<Country> GetByLanguage(string language)
        {
            return Get("lang/" + language);
        }

        public List<Country> GetByCode(string code) {
            return Get("alpha/" + code);
        }

        public List<Country> GetByCurrency(string currency)
        {
            return Get("currency/" + currency);
        }

        public List<Country> GetByRegion(string region)
        {
            return Get("region/" + region);
        }

        private static List<Country> Get(string apiUrl)
        {
            List<Country> result = null;
            using (HttpClient httpClient = new HttpClient())
            {
                string fullUrl = baseApiUrl + apiUrl;
                var task = Task.Run(() => httpClient.GetAsync(new Uri(fullUrl)));
                task.Wait();
                HttpResponseMessage response = task.Result;
                //response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode == true)
                {
                    result = JsonConvert.DeserializeObject<List<Country>>(response.Content.ReadAsStringAsync().Result);
                }
                else {
                    result = null;
                }
            }

            return result;
        }
    }
}
