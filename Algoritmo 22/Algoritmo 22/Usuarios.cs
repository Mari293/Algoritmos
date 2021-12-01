using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_22
{
    class Usuarios
    {
        public string addName()
        {
            string result = "";
            Console.Write("Ingrese un nombre: ");
            string name = Console.ReadLine();
            if (CGlobal.names.Contains(name))
            {
                int index = CGlobal.names.IndexOf(name);
                result = "Este nombre ya esta en la lista en la posición " + Convert.ToString(index);
            }
            else
            {
                CGlobal.names.Add(name);
                result = "Se agrego exitosamente el nombre";
            }
            return result;
        }

        public string editName()
        {
            string result = "";
            Console.Write("Ingrese el nombre que desea editar: ");
            string name = Console.ReadLine();
            for (int i = 0; i < CGlobal.names.Count; i++)
            {
                if (CGlobal.names[i] == name)
                {
                    Console.Write("Ingrese nuevo nombre: ");
                    string newName = Console.ReadLine();
                    CGlobal.names[i] = newName;
                    result = "El cambio fue exitoso";
                }
            }
            return result;
        }

        public string deleteName()
        {
            Console.Write("Ingrese nombre a eliminar: ");
            string name = Console.ReadLine();
            CGlobal.names.Remove(name);
            return "El nombre " + name + " se elimino correctamente";
        }

        public string searchName()
        {
            string result = "";
            if (CGlobal.names.Count == 0)
            {
                result = "La lista esta vacia";
            }
            else
            {
                Console.Write("Ingrese el nombre que desea buscar: ");
                string name = Console.ReadLine();
                if (CGlobal.names.Contains(name))
                {
                    int index = CGlobal.names.IndexOf(name);
                    result = name + " esta en lista en la posición " + Convert.ToString(index);
                }
                else
                {
                    result = name + " no existe en la lista";
                }
            }
            return result;
        }

        public string listSize()
        {
            string result = "";
            int size = CGlobal.names.Count;
            result = "El tamaño de la lista es de: " + size;
            return result;
        }

        public void sortedList()
        {
            CGlobal.names.Sort();
            Console.WriteLine("Los nombres ordenados alfabeticamente son:");
            foreach (string name in CGlobal.names)
            {
                Console.Write(" " + name);
            }
        }
    }
}
