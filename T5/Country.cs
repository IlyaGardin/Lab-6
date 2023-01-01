using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    public class Country
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public Country(int id, string title)
        {
            ID = id;
            Title = title;
        }
    }
}
