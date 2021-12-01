using System;

namespace Algoritmo_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algoritmo que calcula su edad con su fecha de nacimiento");
            int edad;
            Console.Write("Ingrese su fecha de nacimiento con el formato siguiente formato dd-mm-aaaa: ");
            string fechaNac = Console.ReadLine();
            DateTime fnacimiento = DateTime.ParseExact(fechaNac, "dd-MM-yyyy", null);

            string fActual = DateTime.Now.ToString("dd-MM-yyyy");
            DateTime fechaActual = DateTime.ParseExact(fActual, "dd-MM-yyyy", null);

            int annio = fechaActual.Year - fnacimiento.Year;
            int mes = fechaActual.Month - fnacimiento.Month;
            int dia = fechaActual.Day - fnacimiento.Day;

            if ((mes < 0 || mes > 0) && (dia < 0 || dia > 0))
            {
                edad = annio - 1;
                Console.WriteLine("Su edad actual es: " + edad);
            }
            else if (dia < 0 || dia > 0)
            {
                edad = annio - 1;
                Console.WriteLine("Su edad actual es: " + edad);
            }
            else if (mes < 0 || mes > 0)
            {
                edad = annio - 1;
                Console.WriteLine("Su edad actual es: " + edad);
            }
            else
            {
                Console.WriteLine("Su edad actual es: " + annio);
            }
        }
    }
}
