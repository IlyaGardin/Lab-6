using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var obj = new LocalMethods();
            obj.DataInput();
            obj.DataExtraction();
            obj.DataOutput();
        }
    }
}