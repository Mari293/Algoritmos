using System;

namespace Algoritmo_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular la hipotenusa de un triángulo rectángulo");
            Console.Write("Ingrese el valor de medida de un cateto del triangulo: ");
            double cateto1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de medida del otro cateto del triangulo: ");
            double cateto2 = double.Parse(Console.ReadLine());
            double hipotenusa = Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2);
            Console.WriteLine("El valor d ela hipotenusa del triángulo rectángulo es: " + Math.Sqrt(hipotenusa));

        }
    }
}
