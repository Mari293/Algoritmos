using System;

namespace Algoritmo_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Definir si un número es capicúa");
            Console.Write("Ingrese el número que desea saber si es capicúa: ");
            int num = int.Parse(Console.ReadLine());
            double centena = num/100;
            double decena = (num%10)/10;
            double unidad = (num%10)%10;

            if (centena == unidad)
            {
                Console.WriteLine("El número " + num + " es capicúa");
            }
            else
            {
                Console.WriteLine("El número " + num + " no es capicúa");
            }

        }
    }
}
