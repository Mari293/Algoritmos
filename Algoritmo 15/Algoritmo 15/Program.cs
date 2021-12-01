using System;

namespace Algoritmo_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saber si es un número perfecto");
            Console.Write("Ingrese un número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            Console.Write("S = ");

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.Write("+" + Convert.ToString(i));
                    suma = suma + i;

                }
            }

            if (suma == num)
            {

                Console.WriteLine("," + num + " es número perfecto");
            }
            else
            {
                Console.WriteLine("," + num + " no es número perfecto");
            }
        }
    }
}
