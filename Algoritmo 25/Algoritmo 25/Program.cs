using System;

namespace Algoritmo_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algoritmo que genera un numero al azar entre 1 y 1000, si es múltiplo de 3 nos dirá");
            Random ramdoms = new Random();
            int numeroRandom = ramdoms.Next(1,1000);
            if (numeroRandom % 3 == 0)
            {
                Console.WriteLine("El número generado es " + numeroRandom + " y es múltiplo del número 3");
            }
            else
            {
                Console.WriteLine("El número generado es " + numeroRandom + " y no es múltiplo del número 3");
            }
        }
    }
}
