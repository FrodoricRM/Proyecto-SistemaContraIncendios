using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bibliotec1
{
    public class ResetSist
    {
        public bool salir = false;
        public void ResetSis(ref bool salir)
        {
            Console.WriteLine("                   *=================================================================*");
            Console.WriteLine("                   | 1. Vaciar el Archivo | 2. Borrar el Archivo | 3. Volver al Menú |");
            Console.WriteLine("                   *=================================================================*");
            int Rsist = int.Parse(Console.ReadLine());
            switch (Rsist)
            {
                case 1:
                    // Determina si el archivo existe, luego reescribe todo por una cadena vacia
                    Console.ForegroundColor = ConsoleColor.Red;
                    File.WriteAllText("Bitacora_de_eventos.txt", string.Empty);
                    Console.Clear();
                    Console.WriteLine("Se ha vaciado todo el contenido del archivo");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("   Presione enter para regresar....");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    // Verifica si el archivo existe y lo elimina
                    if (File.Exists("Bitacora_de_eventos.txt"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        File.Delete("Bitacora_de_eventos.txt");
                        Console.Clear();
                        Console.WriteLine("Se ha borrado todo el archivo");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("   Presione enter para regresar....");
                        Console.ReadKey();
                    }
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("");
                    salir = false;
                    Console.Clear();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Opción incorrecta");
                    Console.WriteLine("   Presione enter para regresar....");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
    }
}