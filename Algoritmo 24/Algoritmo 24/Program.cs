using System;

namespace Algoritmo_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Invertir número de dos cifras");
            Console.Write("Ingrese un número de dos cifras:");
            int num = int.Parse(Console.ReadLine());
            int decenas = num / 10;
            int unidades = num % 10;
            int convertir = (unidades * 10) + decenas;
            Console.WriteLine("El número invertido es: " + convertir);
        }
    }
}
