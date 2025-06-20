using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotec1;
using System.IO;

namespace ProyectSCI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Este es el punto de entrada principal para la aplicación.
            bool salir = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("                                                                    *_______________________________________________*");
                Console.WriteLine("                                                                    | Bienvenidos al SCI (Sistema Contra Incendios) |");
                Console.WriteLine("                                                                    *-----------------------------------------------*");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                                *=================*");
                Console.WriteLine("                                |  MENÚ PRINCIPAL |");
                Console.WriteLine("                                *=================*");
                Console.WriteLine("            *====================================================================*");
                Console.WriteLine("            | 1. Menú | 2. Inicializar Sistema | 3. Reset del Sistema | 4. Salir |");
                Console.WriteLine("            *====================================================================*");
                Console.WriteLine("Ingrese la opción que desea...");
                int MP = int.Parse(Console.ReadLine());
                Console.Clear();
                // Llamada a la clase Menus y al método MenuPrinc, este ejecuta las acciones acorde al numero ingresado
                Menus men = new Menus();
                men.MenuPrinc(MP, ref salir);
            } while (!salir);
            if (!salir)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Gracias por usar SCI V3.0");
            }
        }
    }
}