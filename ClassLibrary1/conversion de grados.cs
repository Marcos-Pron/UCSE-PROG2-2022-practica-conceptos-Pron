using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    static class conversion_de_grados
    {
        static double celcius(this double gradosfah)
        {
            double c = gradosfah / 2.2;
            return c;
        }
        static double fahrenheit(this double gradoscel)
        {
            double f = gradoscel * 2.2;
            return f;
        }
    }
}
