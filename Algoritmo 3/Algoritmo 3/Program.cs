using System;

namespace Algoritmo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultado = "";
            Console.WriteLine("Mostrar los números de 1 hasta el número ingresado por teclado.");
            Console.Write("\nIngrese limite de números: ");
            int limite = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= limite; i++)
            {
                resultado = i + " ";
                Console.Write(resultado);
            }
        }
    }
}
