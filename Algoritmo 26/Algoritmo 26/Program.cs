using System;

namespace Algoritmo_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algoritmo para convertir un número entero en binario");
            Console.Write("Ingrese un número para convertir: ");
            int numero = int.Parse(Console.ReadLine());
            string binario = " ";
            if (numero > 0)
            {
                while (numero > 0)
                {
                    int resto = numero % 2;
                    binario = resto + binario;
                    numero = numero / 2;
                }
                    Console.WriteLine("El número " + numero + " y convertido en binario es: " + binario);
            }
            else
            {
                Console.WriteLine("No se puede convertir a binario ya que esta ingresando un número que no es entero");
            }
        }
    }
}
