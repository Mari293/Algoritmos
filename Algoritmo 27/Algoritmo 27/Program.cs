
using System;

namespace Algoritmo_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algoritmo que calcula diametro de una circunferencia");
            Console.WriteLine("Se puede calcular con el diametro o su radio" + "\n1.Diametro" + "\n2.Radio");
            Console.Write("Ingrese el número de la opción: ");
            int opcion = int.Parse(Console.ReadLine());
            double pi = 3.14;
            switch (opcion)
            {
                case 1:
                    {
                        Console.Write("Ingrese el valor del diametro: ");
                        double diametro = double.Parse(Console.ReadLine());
                        double perimetro = pi * diametro;
                        Console.WriteLine("El perimetro de la circunferencia es: " + perimetro);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Ingrese el valor del radio: ");
                        double radio = double.Parse(Console.ReadLine());
                        double perimetro = 2 * pi * radio;
                        Console.WriteLine("El perimetro de la circunferencia es: " + perimetro);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("El número de opción es invalida");
                        break;
                    }
            }
        }
    }
}
