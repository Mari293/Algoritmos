using System;

namespace Algoritmo_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que lee 3 números enteros diferentes y los despliega de mayor a menor.");
            Console.Write("Ingrese número 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese número 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese número 3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if(num1==num2 || num1 == num3 || num2==num3)
            {
                Console.WriteLine("Debe ingresar números diferentes");
            }
            else
            {
                if (num1 > num2)
                {
                    if (num2 > num3)
                    {
                        Console.WriteLine("El orden de mayor a menor es: " + num1 + " " + num2 + " " + num3);
                    }
                    else
                    {
                        if (num3 > num1)
                        {
                            Console.WriteLine("El orden de mayor a menor es: " + num3 + " " + num1 + " " + num2);

                        }
                        else
                        {
                            Console.WriteLine("El orden de mayor a menor es: " + num1 + " " + num3 + " " + num2);
                        }

                    }
                }
                else if (num2 > num1)
                {
                    if (num1 > num3)
                    {
                        Console.WriteLine("El orden de mayor a menor es: " + num2 + " " + num1 + " " + num3);
                    }
                    else
                    {
                        if (num3 > num2)
                        {
                            Console.WriteLine("El orden de mayor a menor es: " + num3 + " " + num2 + " " + num1);
                        }
                        else
                        {
                            Console.WriteLine("El orden de mayor a menor es: " + num2 + " " + num3 + " " + num1);
                        }
                    }
                }
                else
                {
                    if (num3 > num1)
                    {
                        if (num1 > num2)
                        {
                            Console.WriteLine("El orden de mayor a menor es: " + num3 + " " + num1 + " " + num2);
                        }
                        else
                        {
                            if (num2 > num3)
                            {
                                Console.WriteLine("El orden de mayor a menor es: " + num2 + " " + num3 + " " + num1);
                            }
                            else
                            {
                                Console.WriteLine("El orden de mayor a menor es :" + num3 + " " + num2 + " " + num1);
                            }
                        }
                    }
                }
            }

        }
    }
}
