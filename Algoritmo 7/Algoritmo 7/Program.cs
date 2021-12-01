
using System;

namespace Algoritmo_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El promedio de prácticas de un curso se calcula con base en cuatro notas calificadas de las cuales se elimina la nota menor y se promedian las tres notas más altas.");
            Console.Write("Ingrese la nota 1: ");
            float n1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Ingrese la nota 2: ");
            float n2 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Ingrese la nota 3: ");
            float n3 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Ingrese la nota 4: ");
            float n4 = Convert.ToSingle(Console.ReadLine());

            if(n1<n2 && n1<n3 && n1<n4)
            {
                float promedio = (n2 + n3 + n4)/ 3; 
                Console.WriteLine("Se elimina la nota: " + n1 + " y su promedio es: " + promedio);
            }
            else
            {
                if (n2 < n1 && n2 < n3 && n2 < n4)
                {
                    float promedio = (n1 + n3 + n4) / 3;
                    Console.WriteLine("Se elimina la nota: " + n2 + " y su promedio es: " + promedio);
                }
                else
                {
                    if (n3 < n1 && n3 < n2 && n3 < n4)
                    {
                        float promedio = (n1 + n2 + n4 )/ 3;
                        Console.WriteLine("Se elimina la nota: " + n3 + " y su promedio es: " + promedio);
                    }
                    else
                    {
                        float promedio = (n1 + n2 + n3) / 3;
                        Console.WriteLine("Se elimina la nota: " + n4 + " y su promedio es: " + promedio);
                    }
                }
            }
        }
    }
}
