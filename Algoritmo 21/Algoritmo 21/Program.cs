using System;

namespace Algoritmo_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA");
            int op, opcion;
            do
            {
                Console.WriteLine("1.Suma" + "\n2.Resta" + "\n3.Multiplicación" + "\n4.División");
                Console.Write("Ingrese numero de la opción:");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese un número");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese otro número");
                int num2 = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        {
                            int suma = num1 + num2;
                            Console.WriteLine("La suma de los números " + num1 + " y " + num2 + " es igual a " + suma);
                            break;
                        }
                    case 2:
                        {
                            int resta = num1 - num2;
                            Console.WriteLine("La resta de los números " + num1 + " y " + num2 + " es igual a " + resta);
                            break;
                        }
                    case 3:
                        {
                            int multiplicacion = num1 * num2;
                            Console.WriteLine("La multiplicación de los números " + num1 + " y " + num2 + " es igual a " + multiplicacion);
                            break;
                        }
                    case 4:
                        {
                            int division = num1 / num2;
                            Console.WriteLine("La división de los números " + num1 + " y " + num2 + " es igual a " + division);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Número de opción inválida");
                            break;
                        }
                }
                Console.WriteLine("\nPulse 0 para salir del programa. Pulse otro número para continuar");
                op = Convert.ToInt32(Console.ReadLine());
            } while (op != 0);
        }
    }
}
