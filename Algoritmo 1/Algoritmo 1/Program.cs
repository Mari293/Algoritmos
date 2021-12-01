using System;

namespace Algoritmo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mostrar los números impares entre el 0 y el 100.");
            Console.Write("Los números impares son: ");
            string resultado = "";
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    resultado = i + " , ";
                    Console.Write(resultado);
                }
            }
        }
    }
}
