using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //Usar nombres de metodos entendibles, en formato PascalCase, y con un verbo
    //por ej: ObtenerPromedio o CalcularProductoParesImpares
    public static class MetodosdeExtencion
    {
        
        static int ContarPalabras(this string Valor) //parametros van en minuscula
        {
            return (Valor.Split(' ')).Length;
        }
        static int ContarPalabras(this string Valor, char separador) //parametros van en minuscula
        {
            return (Valor.Split(separador)).Length;
        }
        static decimal diferencia(this DateTime Fecha1,  DateTime Fecha2) //parametros van en minuscula
        {
            decimal fecha3 = Fecha1.Second - Fecha2.Second;
            return fecha3 / 60;
        }
        static double promlist(this List<int> lista)
        {
            int i = 0;
            int suma = 0;
            int cantidad = lista.Count;
            for ( i = 0; i < cantidad; i++)
            {
                suma = suma + lista[i];
            }

            //podrias usar lista.Average()
            return (suma/cantidad);
        }
        static int paresporinpares(this List<int>listaparimpar) 
        {
            int inpar = 0;
            int par = 0;
            int i= 0;
            int cantidad = listaparimpar.Count;
            for (i = 0; i < cantidad; i++)
            {
                if (listaparimpar[i] % 2 == 0)
                {
                    par = par + listaparimpar[i];
                }
                inpar = inpar - listaparimpar[i];
            }
            return (par * inpar);
        }
        static DateTime fechaporstring(this string fecha)
        {
            DateTime fechacovertida = Convert.ToDateTime(fecha);
            return fechacovertida;  
        }
        static string invertir (this string palabra)
        {
            return palabra.Reverse().ToString();
        }
        static string array(this List<string> listaastring)
        {
            string palabra = "";
            for (int i = 0; i < listaastring.Count; i++)
            {
                palabra=palabra + listaastring[i];
                palabra = palabra + "?";
            }
            return palabra;
        }
        static bool expreg(this string expresion)
        {

            bool isMatch = Regex.IsMatch(expresion, @"@gmail\.com");
            return isMatch;
        }
        static bool Cuit(this string cuit)
        {
           bool isMatch= Regex.IsMatch(cuit,"30-");
           return isMatch;
        }
        static int resta(this int numero1, int numero2)
        { return numero1 - numero2; }
        static decimal resta(this decimal numero1, decimal numero2)
        {
            { return numero1 - numero2; }
        }
        static persona personafinal(this persona persona1, persona persona2)
        {
           //Se puede hacer mucho mas optimo.

           persona persona = new persona(); 
            if (persona1.cuit == persona2.cuit)
            {
               persona.cuit = persona2.cuit;
                if (persona1.saldo > persona2.saldo)
                {
                    persona.saldo= persona1.saldo - persona2.saldo;
                }
                persona.saldo=persona2.saldo - persona1.saldo;
                persona.Nombre= persona2.Nombre;
                return persona;
            }
            if (persona1.saldo > persona2.saldo)
            {
                persona.saldo = persona2.saldo;
                persona.cuit=persona2.cuit;
                persona.Nombre = persona2.Nombre;
            }
            persona.saldo = persona1.saldo;
            persona.cuit = persona1.cuit;
            persona.Nombre = persona1.Nombre;
            return (persona);

        }
    }
}
