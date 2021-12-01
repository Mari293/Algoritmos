using System;
using System.Collections.Generic;

namespace Algoritmo_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crear un Login con 2 listas." + "\n1 lista para usuarios" + "\n1 lista para contraseñas");
            int opcion,op;
            string resultado;
            Acciones action = new Acciones();
            do
            {
                Console.WriteLine("LOGIN" + "\n1.Agregar usuario" + "\n2.Iniciar sesión" + "\nMostrar Usuarios");
                Console.WriteLine("Ingrese el número de la opción que desea: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        {
                            resultado = action.addUser();
                            Console.WriteLine(resultado);
                            break;
                        }
                    case 2:
                        {
                            resultado = action.login();
                            Console.WriteLine(resultado);
                            break;
                        }
                    case 3:
                        {
                            resultado = action.lista();
                            Console.WriteLine(resultado);
                            
                            break;
                        }
                    default:
                        Console.WriteLine("Número invalido intente de nuevo");
                        break;
                }
                Console.WriteLine("\nPulse 0 para salir del programa. Pulse otro número para continuar");
                op = Convert.ToInt32(Console.ReadLine());
            } while (op != 0);
        }
    }
}
