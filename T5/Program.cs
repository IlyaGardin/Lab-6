using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Formats.Asn1;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using T5;



namespace T5
{
    public class Program
    {
        public static void Main(string[] args)
        {

            DateTime date = new DateTime(2022, 01, 01);

            List<Country> countries = LocalClass.FillCountryList();
            List<City> cities = LocalClass.FillCityList();
            List<Street> streets = LocalClass.FillStreetList();
            List<HomeAddress> homeAddresses = LocalClass.FillHomeAddressList();
            List<People> people = LocalClass.FillPeopleList();


            var adults = LocalClass.GetAdults(people, date);

            foreach (var item in adults)
            {
                Console.WriteLine($"{item.FirstName}, {item.LastName}");
            }

            

            var saratovPeople = LocalClass.GetSaratovPeople(people, homeAddresses, streets, cities);

            foreach (var item in saratovPeople)
            {
                Console.WriteLine($"{item.FirstName}, {item.LastName}");
            }

           

            var cityTitles = LocalClass.GetCityTitlesContainsSadovaya(streets, cities);

            foreach (var item in cityTitles)
            {
                Console.WriteLine($"{item}");
            }

           

            var peoples = LocalClass.GetAllPeoplesInfoAsTuple(people, homeAddresses, streets, cities, countries);

            foreach (var item in peoples)
            {
                Console.WriteLine($"{item.Item1}, {item.Item2}, {item.Item3}, {item.Item4}, {item.Item5}, {item.Item6}, {item.Item7}");
            }

           

            var averageAge = LocalClass.GetAverageAgeOfRussiaSaratov2ndSadovskaya17HomeHumber(people, homeAddresses, streets, cities, countries, date);

            Console.WriteLine($"averageAge: {Math.Round(averageAge)}");



        }
    }
}

