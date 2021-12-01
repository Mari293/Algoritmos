using System;

namespace Algoritmo_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dado un número entre 1 y 7 escriba su correspondiente día de la semana así: " + 
                "\n1-Lunes" + "\n2-Martes" + "\n3-Miércoles" + "\n4-Jueves" + "\n5-Viernes" + "\n6-Sábado" + "\n7-Domingo");

            Console.Write("Ingrese un número entre 1 y 7: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("Lunes");
            }
            else if( opcion == 2)
            {
                Console.WriteLine("Martes");
            }
            else if (opcion == 3)
            {
                Console.WriteLine("Miércoles");
            }
            else if (opcion == 4)
            {
                Console.WriteLine("Jueves");
            }
            else if (opcion == 5)
            {
                Console.WriteLine("Viernes");
            }
            else if (opcion == 6)
            {
                Console.WriteLine("Sábado");
            }
            else if (opcion == 7)
            {
                Console.WriteLine("Domingo");
            }
            else
            {
                Console.WriteLine("Opción inválida");
            }
        }
    }
}
