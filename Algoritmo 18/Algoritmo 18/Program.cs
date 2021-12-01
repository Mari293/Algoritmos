using System;

namespace Algoritmo_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números en escalera");
            Console.Write("Ingrese limite: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
