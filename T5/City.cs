using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    public class City
    {
        public int ID { get; set; }
        public int CountryID { get; set; }
        public string Title { get; set; }

        public City(int id, int countryID, string title)
        {
            ID = id;
            CountryID = countryID;
            Title = title;
        }
    }
}
