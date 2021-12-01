using System;

namespace Algoritmo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pedir 2 números por teclado y sumarlos");
            Console.Write("\nIngrese un número:");
            int num1 =Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIngrese otro número:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int suma = num1 + num2;
            Console.WriteLine("\nLa sumatoria de los números ingresados es igual a " + Convert.ToString(suma));   
        }
    }
}
