using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //Ojo los nombres de las clases, evitar espacios y _ (Usaria: ConversionGrados por ejemplo)
    static class conversion_de_grados
    {
        static double celcius(this double gradosfah)
        {
            double c = gradosfah / 2.2; //es 2.12 y podria ser una constante para usar en los 2 lados
            return c;
        }
        static double fahrenheit(this double gradoscel)
        {
            double f = gradoscel * 2.2;
            return f;
        }
    }
}
