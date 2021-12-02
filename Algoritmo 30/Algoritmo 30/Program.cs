using System;

namespace Algoritmo_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Año bisiesto");
            Console.Write("Ingrese un año: ");
            int anio = int.Parse(Console.ReadLine());
            if(anio%4==0 && (anio % 100 != 0  || anio % 400 == 0))
            {
                Console.WriteLine("Bisiesto");
            }
            else
            {
                Console.WriteLine("No es bisiesto");
            }
        }
    }
}
