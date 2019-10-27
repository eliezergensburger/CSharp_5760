using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Product
    {
        public int ID { get; private set; }
        public String Name { get; set; }

        private static int code = 0;

        public Product(string name)
        {
            Name = name;
            ID = code++;
        }

        public static string getCode()
        {
            return String.Format("the current code is {0} :",code);
        }
    }
}
