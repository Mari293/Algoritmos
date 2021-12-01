using System;

namespace Algoritmo_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int op, opcion;
            string resultado;
            Usuarios person = new Usuarios();
            do
            {
                Console.WriteLine("Realice un programa donde se permitan almacenar nombres de personas, identificar si en la lista ya esta incluido el mismo nombre y no permitir volver a ingresarlo, por el contrario mostrar la posición de este.los nombres deben mostrarse ordenados alfabéticamente(Se pueden usar funciones por defecto), permitir eliminar, editar o agregar datos a esta lista, crear metodos para consultar el tamaño de la lista y para buscar un elemento en la lista, TODO el  sistema debe estar orientado a objetos e implementar POO");

                Console.WriteLine("\n¿Qué desea hacer?" +
                "\n1. Agregar nombre" +
                "\n2. Editar nombre" +
                "\n3. Eliminar nombre" +
                "\n4. Buscar nombre" +
                "\n5. Tamaño de la lista" +
                "\n6. Lista ordenada");



                Console.Write("Ingrese el número de la opción de lo que quiere hacer: ");
                opcion = Convert.ToInt32(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        {
                            resultado = person.addName();
                            Console.WriteLine(resultado);
                            for (int i = 0; i < CGlobal.names.Count; i++)
                            {
                                Console.WriteLine(CGlobal.names[i]);
                            }
                            break;
                        }
                    case 2:
                        {
                            resultado = person.editName();
                            Console.WriteLine(resultado);
                            for (int i = 0; i < CGlobal.names.Count; i++)
                            {
                                Console.WriteLine(CGlobal.names[i]);
                            }
                            break;
                        }
                    case 3:
                        {
                            resultado = person.deleteName();
                            Console.WriteLine(resultado);
                            for (int i = 0; i < CGlobal.names.Count; i++)
                            {
                                Console.WriteLine(CGlobal.names[i]);
                            }
                            break;
                        }
                    case 4:
                        {
                            resultado = person.searchName();
                            Console.WriteLine(resultado);
                            for (int i = 0; i < CGlobal.names.Count; i++)
                            {
                                Console.WriteLine(CGlobal.names[i]);
                            }
                            break;
                        }

                    case 5:
                        {
                            resultado = person.listSize();
                            Console.WriteLine(resultado);
                            break;
                        }

                    case 6:
                        {
                            person.sortedList();
                            break;
                        }
                    default:
                        Console.WriteLine("Número invalido intente de nuevo");
                        break;
                }
                Console.Write("\nPulse 0 para salir del programa. Pulse otro número para continuar: ");
                op = Convert.ToInt32(Console.ReadLine());

            } while (op != 0);
        }
    }
}
