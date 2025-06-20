using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bibliotec1
{
    public class BitdeEventos
    {
        public void BitadeEventos()
        {
            //Verificar si existe el archivo "Bitacora_de_eventos.txt" y mostrar su contenido
            //Si no existe, solo se muestra un mensaje
            if (File.Exists("Bitacora_de_eventos.txt"))
            {
                Console.ForegroundColor = ConsoleColor.White;
                string contenido = File.ReadAllText("Bitacora_de_eventos.txt");
                Console.WriteLine("          *=======================================================*");
                Console.WriteLine("          |          Bienvenido a la Bitácora de Eventos          |");
                Console.WriteLine("          *=======================================================*");
                Console.WriteLine("\n ");
                Console.WriteLine(contenido);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("   Presione enter para regresar....");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("          *=======================================================*");
                Console.WriteLine("          |      Aún no se ha creado una Bitácora de Eventos      |");
                Console.WriteLine("          *=======================================================*");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("   Presione enter para regresar....");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}