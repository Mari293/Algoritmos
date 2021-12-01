using System;

namespace Algoritmo_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serie Fibonocci");
            Console.Write("Ingrese cantidad de números que desea ver de la serie Fibonacci: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.Write(" S = ");
            int num1 = 0;
            int num2 = 1;
            int num3 = 0;

            for (int i = 1; i <= limit; i++)
            {
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
                num3 = num1 + num2;
            }
        }
    }
}
