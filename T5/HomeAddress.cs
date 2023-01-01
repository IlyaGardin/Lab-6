using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    public class HomeAddress
    {
        public int ID { get; set; }
        public int StreetID { get; set; }
        public string HomeNumber { get; set; }
        public int Apartment { get; set; }

        public HomeAddress(int id, int streetID, string homeNumber, int apartment)
        {
            ID = id;
            StreetID = streetID;
            HomeNumber = homeNumber;
            Apartment = apartment;
        }
    }
}
