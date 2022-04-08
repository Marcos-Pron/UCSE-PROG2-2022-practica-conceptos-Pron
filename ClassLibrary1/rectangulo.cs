using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    static class rectangulo
    {
        static double perimetro(this double lado, double alto) //NO hace falta el this
        { 
           double perim= (lado*2)+(alto*2);
            return perim;
        }
        static double area(this double lado, double alto) //NO hace falta el this
        {
            double area = lado * alto;
            return area;
        }
    }
}
