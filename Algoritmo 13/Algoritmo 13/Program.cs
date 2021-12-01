using System;

namespace Algoritmo_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desarrolle un algoritmo que permita convertir calificaciones numéricas, según la siguiente tabla: " +
                "\nA = 19 y 20" + "\nB =16, 17 y 18" + "\nC = 13, 14 y 15" + "\nD = 10, 11 y 12" + "\nE = 1");

            Console.Write("Ingrese la calificación: ");
            int calificacion = Convert.ToInt32(Console.ReadLine());

            if (calificacion==19 || calificacion == 20)
            {
                Console.WriteLine("Su calificación es: A");
            }
            else if (calificacion == 16 || calificacion == 17 || calificacion==18)
            {
                Console.WriteLine("Su calificación es: B");
            }
            else if (calificacion == 13 || calificacion == 14 || calificacion == 15)
            {
                Console.WriteLine("Su calificación es: C");
            }
            else if (calificacion == 10 || calificacion == 11 || calificacion == 12)
            {
                Console.WriteLine("Su calificación es: D");
            }
            else if (calificacion == 1)
            {
                Console.WriteLine("Su calificación es: E");
            }
            else
            {
                Console.WriteLine("Su calificación es invalida");
            }
        }
    }
}
