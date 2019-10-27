using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class MyClass
    {
        private int m_x;

        public int X
        {
            get { return m_x; }
            set { m_x = value; }
        }
        public override string ToString()
        {
            return X.ToString();
        }
    }
}
