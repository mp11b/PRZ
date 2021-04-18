using System;
using System.Collections.Generic;
using System.Text;

namespace CountryInfo
{
    public class Country
    {
        private string name;
        private string capital;
        public long population;
        public float? area;

 
        public Country(string name, string capital, long population, float? area) {
            this.Name = name;
            this.Capital = capital;
            this.Population = population;
            this.Area = area;
        }

        public string Name { get => name; set => name = value; }
        public string Capital { get => capital; set => capital = value; }
        public long Population { get => population; set => population = value; }
        public float? Area { get => area; set => area = value; }

        override public string ToString()
        {
            return Name + " (capital: " + Capital + ", pop: " + Population + ", area: " + Area + ")";
        }
    }
}
