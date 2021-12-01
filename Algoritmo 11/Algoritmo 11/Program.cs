using System;
using System.Collections.Generic;

namespace Algoritmo_11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listMultiplos = new List<int>();
            Console.WriteLine("Agregar un rango de múltiplos de N número a una lista, sumar los valores agregados y dividirlos por la cantidad de posiciones de esta.");
            Console.Write("Ingrese el inicio del rango: ");
            int inicio = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el fin del rango: ");
            int fin = Convert.ToInt32(Console.ReadLine());
            int suma = 0;

            Console.Write("Ingrese el número del que quiere los multiplos: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = inicio; i <= fin; i++)
            {
                int multiplicacion = i * num;
                if (multiplicacion%num==0)
                {
                    listMultiplos.Add(multiplicacion);
                }
            }
            
            for (int i = 0; i<listMultiplos.Count; i++)
            {
                suma = suma + listMultiplos[i];
                Console.WriteLine(listMultiplos[i]);
            }
            int promedio = suma / listMultiplos.Count;
            Console.WriteLine("La suma de los valores agregados es: " + suma + " y al dividirlos por la cantidad de posiciones de la lista es: " + promedio);

        }
    }
}