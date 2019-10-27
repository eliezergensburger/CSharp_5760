using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Stam
    {
        public string stamshem;
        public Stam()
        {
            stamshem = "ze kvar meuchar";
        }
        public override string ToString()
        {
            Point p = new Point();
            p.x = 2;
            p.y = 3;
            return stamshem + " " + p;
        }
    }
}
