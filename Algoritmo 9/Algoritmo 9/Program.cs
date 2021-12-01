
using System;

namespace Algoritmo_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular el factorial de un número que se pida por teclado.");
            Console.Write("Ingrese número para calcular factorial: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;


            Console.Write("F = ");
            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
                Console.Write("*" + i);

            }
            Console.Write(" = " + factorial);
        }
    }
}
