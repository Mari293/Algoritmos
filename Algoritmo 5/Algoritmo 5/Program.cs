using System;

namespace Algoritmo_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que pida el peso, la estatura y muestre el índice de la masa corporal.");
            Console.Write("\nIngrese los datos con una coma si necesita decimales");
            Console.Write("\nIngrese su peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nIngrese su estatura: ");
            double estatura = Convert.ToDouble(Console.ReadLine());
            double masaCorporal = peso / Math.Pow(estatura,2);
            Console.WriteLine("El indice de la masa corporal es: " + Convert.ToString(masaCorporal));
        }
    }
}
