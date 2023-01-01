using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    public class PeopleNames
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
   
    internal static class LocalClass
    {

        
        public static List<Country> FillCountryList()
        {
            List<Country> countries = new List<Country>()
        {
        new Country(1, "Россия"),
        new Country(2, "США"),
        new Country(3, "Франция")            
        };

            return countries;
        }

        public static List<City> FillCityList()
        {
            List<City> cities = new List<City>()
        {
            new City(1, 1,"Саратов" ),
            new City(2, 1, "Москва"),
            new City(3, 2, "Нью Йорк"),
            new City(4, 2, "Вашингтон"),                
            new City(5, 3, "Париж")

        };

            return cities;
        }

        public static List<Street> FillStreetList()
        {
            List<Street> streets = new List<Street>()
        {
            new Street(1, 1, "2 Садовая"),
            new Street(2, 2, "Большая Садовая"),
            new Street(3, 2, "Ленинградская"),
            new Street(4, 3, "Таймс-сквер"),
            new Street(5, 4, "Пенсильвания-авеню"),
            new Street(6, 5, "Елисейские поля")              

        };

            return streets;
        }

        public static List<HomeAddress> FillHomeAddressList()
        {
            List<HomeAddress> homeAddresses = new List<HomeAddress>()
        {
            new HomeAddress(1, 1, "31-35", 1),
            new HomeAddress(2, 1, "17", 11),
            new HomeAddress(3, 2, "21", 2),
            new HomeAddress(4, 3, "31", 3),
            new HomeAddress(5, 4, "41", 4),
            new HomeAddress(6, 5, "51", 5),
            new HomeAddress(7, 6, "61", 6)

        };

            return homeAddresses;
        }

        public static List<People> FillPeopleList()
        {
            List<People> people = new List<People>()
        {
            new People(1, "Илья", "Гардин", new DateTime(1985, 1, 1), 2, 1),
            new People(2, "Ульяна", "Кукушкина", new DateTime(1987, 2, 2), 3, 4),
            new People(3, "Алена", "Байкова", new DateTime(1970, 3, 3), 5, null),
            new People(4, "Михаил", "Павлычев", new DateTime(2000, 1, 5), 7, 1),
            new People(5, "Яна", "Кочергина", new DateTime(2005, 3, 7), 2, 3),
            new People(6, "Анастасия", "Асташева", new DateTime(1998, 4, 4), 3, null),
            new People(7, "Дмитрий", "Гирко", new DateTime(1991, 2, 1), 3, 7),
            new People(8, "Данил", "Макаркин", new DateTime(1978, 3, 5), 4, 2),
            new People(9, "Данил", "Шмелев", new DateTime(1985, 3, 1), 3, 1),
            new People(10, "Ринат", "Хайрулин", new DateTime(2010, 3, 7), 7, 3),
            new People(11, "Руслан", "Акпасов", new DateTime(1999, 3, 5), 2, 3),
            new People(12, "Алексей", "Андреев", new DateTime(1990, 3, 2), 2, 3),
        };

            return people;
        }

        public static List<PeopleNames> GetAdults(List<People> people, DateTime date)
        {
            List<PeopleNames> list = new List<PeopleNames>();
            list = (from p in people
                    where p.Birthday.AddYears(18) < date
                    select new PeopleNames
                    {
                        FirstName = p.FirstName,
                        LastName = p.LastName
                    }).ToList();

            return list;           
        }



        public static List<PeopleNames> GetSaratovPeople(List<People> people, List<HomeAddress> homeAddresses, List<Street> streets, List<City> cities)
        {
            List<PeopleNames> list = new List<PeopleNames>();
            list = (from p in people
                    join h in homeAddresses on p.LiveID equals h.ID
                    join s in streets on h.StreetID equals s.ID
                    join c in cities on s.CityID equals c.ID
                    where c.Title == "Саратов"
                    select new PeopleNames
                    {
                        FirstName = p.FirstName,
                        LastName = p.LastName
                    }).ToList();

            return list;
        }

        public static List<string> GetCityTitlesContainsSadovaya(List<Street> streets, List<City> cities)
        {
            List<string> list = new List<string>();

            list = ((from s in streets
                     join c in cities on s.CityID equals c.ID
                     where s.Title.Contains("Садовая")
                     select c.Title).Distinct()).ToList();

            return list;
        }

        public static List<(string, string, string, string, string, string, int)> GetAllPeoplesInfoAsTuple(List<People> people, List<HomeAddress> homeAddresses, List<Street> streets, List<City> cities, List<Country> countries) 
        {
            List<(string, string, string, string, string, string, int)> list = new List<(string, string, string, string, string, string, int)>();

            list = (from p in people
                    join h in homeAddresses on p.RegistrationID equals h.ID
                    join s in streets on h.StreetID equals s.ID
                    join c in cities on s.CityID equals c.ID
                    join countrie in countries on c.CountryID equals countrie.ID
                    select (p.LastName, p.FirstName, countrie.Title, c.Title, s.Title, h.HomeNumber, h.Apartment)).ToList();

            return list;
        }

        public static double GetAverageAgeOfRussiaSaratov2ndSadovskaya17HomeHumber(List<People> people, List<HomeAddress> homeAddresses, List<Street> streets, List<City> cities, List<Country> countries, DateTime date)
        {
            double averageAge = (from p in people
                                 join h in homeAddresses on p.RegistrationID equals h.ID
                                 join s in streets on h.StreetID equals s.ID
                                 join c in cities on s.CityID equals c.ID
                                 join countrie in countries on c.CountryID equals countrie.ID
                                 where countrie.Title == "Россия" && c.Title == "Саратов" && s.Title == "2 Садовая" && h.HomeNumber == "17"
                                 select date.Year - p.Birthday.Year).Average();

            return averageAge;
        }

        
    }      

    
}
