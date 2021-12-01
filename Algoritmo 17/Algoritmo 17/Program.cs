using System;

namespace Algoritmo_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algoritmo para saber si un número es primo o no");
            Console.WriteLine("Ingrese un número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int divisiones = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (num % i == 0)
                {
                    divisiones += 1;
                }
            }
            if (divisiones == 2)
            {
                Console.WriteLine(num + " es un número primo");
            }
            else
            {
                Console.WriteLine(num + " no es un número primo");
            }
        }
    }
}
