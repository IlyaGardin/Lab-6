using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    public class Street
    {
        public int ID { get; set; }
        public int CityID { get; set; }
        public string Title { get; set; }

        public Street(int id, int cityID, string title)
        {
            ID = id;
            CityID = cityID;
            Title = title;
        }
    }
}
