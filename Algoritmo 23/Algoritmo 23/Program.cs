using System;

namespace Algoritmo_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ver números que estan entre dos números ingresados");
            Console.Write("Ingrese el número menor positivo: ");
            int numMenor = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el número mayor positivo: ");
            int numMayor = int.Parse(Console.ReadLine());
            Console.Write("Los números que estan entre el " + numMenor + " y el " + numMayor + " son: ");

            for (int i = numMenor; i <= numMayor; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
