using System;

namespace Algoritmo_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Realizar un programa que pida tres notas de un alumno, calcule el promedio e imprima lo siguiente:" +
                "\nSi el promedio es > 10 mostrar Aprobado." +
                "\nSi el promedio es > 7 y <= 9 mostrar Desaprobado." +
                "\nSi el promedio es < 7 mostrar Reprobado.");

            Console.Write("Ingrese la nota 1: ");
            float n1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Ingrese la nota 2: ");
            float n2 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Ingrese la nota 3: ");
            float n3 = Convert.ToSingle(Console.ReadLine());

            float promedio = (n1 + n2 + n3) / 3;

            if (promedio < 7){
                Console.WriteLine("Reprobado y su promedio es: " + promedio);
            }
            else if (promedio > 7 && promedio <= 9)
            {
                Console.WriteLine("Desaprobado y su promedio es: " + promedio);
            }
            else
            {
                Console.WriteLine("Aprobado y su promedio es: " + promedio);
            }
        }
    }
}
