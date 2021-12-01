using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_14
{
    class Acciones
    {
        public string addUser()
        {
            string result = "";
            Console.Write("Ingrese su nombre: ");
            string user = Console.ReadLine();
            Console.Write("Ingrese su contraseña: ");
            string password = Console.ReadLine();
            if (CGlobal.usuarios.Contains(user))
            {
                result = "No se puede registrar, este usuario ya existe";
            }
            else
            {
                CGlobal.usuarios.Add(user);
                CGlobal.contrasennas.Add(password);
                result = "Se registro correctamente";
            }
            return result;
        }

        public string login()
        {
            string result = "";
            Console.Write("Ingrese su nombre: ");
            string user = Console.ReadLine();
            Console.Write("Ingrese su contraseña: ");
            string password = Console.ReadLine();

            for (int i = 0; i < CGlobal.usuarios.Count; i++)
            {
                if (CGlobal.usuarios[i] == user)
                {
                    if (CGlobal.contrasennas[i] == password)
                    {
                        result ="Bienvenido";
                    }
                    else
                    {
                        result = "Contraseña incorrecta";
                    }
                }
                else
                {
                    result = "El usuario no existe";
                }
            }
            return result;
        }

        public string lista()
        {
            string result = "";

            for (int i = 0; i < CGlobal.usuarios.Count; i++)
            {
                Console.WriteLine(CGlobal.usuarios[i]);
            }
            return result;
        }
    }
}
