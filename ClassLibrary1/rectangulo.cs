using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    static class rectangulo
    {
        static double perimetro(this double lado, double alto)
        { 
           double perim= (lado*2)+(alto*2);
            return perim;
        }
        static double area(this double lado, double alto)
        {
            double area = lado * alto;
            return area;
        }
    }
}
