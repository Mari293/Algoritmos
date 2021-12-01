using System;

namespace Algoritmo_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que muestre la tabla de multiplicar del número que se pida por teclado.");
            Console.Write("Ingrese número del que quiere ver la tabla de multiplicar: ");
            int numMultiplicar = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                int resultado = i * numMultiplicar;
                Console.WriteLine(i + " * " + numMultiplicar + " = " + resultado);
            }
        }
    }
}
