using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micelanea_MOD
{
    public class Menu
    {
        public static void menu()
        {
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Elija una de las siguinetes opciones: \n1. Operadores \n2. Condicionales \n3. Ciclos \n9. Salir ");
        }
        public static void def()
        {
            Console.WriteLine("Dato incorrecto");
            Console.WriteLine("saliendo del programa");
        }
    }
}
