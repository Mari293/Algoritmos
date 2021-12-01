using System;

namespace Algoritmo_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("S =  + 1/3 + 2/4 + 3/5 + 4/6 + n/n+2");
            Console.Write("Ingrese limite: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("S = ");
            float suma = 0;

            for (int i = 1; i <= n; i++)
            {
                float num = i;
                float deno = i + 2;
                float resultado = num / deno;
                suma += resultado;
                Console.Write(" + " + num + "/" + deno);
            }
            Console.Write(" = " + suma);
        }
    }
}
