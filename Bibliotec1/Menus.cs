using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec1
{
    public class Menus
    {
        // Este es el metodo de entrada principal para la aplicación.
        public void MenuPrinc(int MP, ref bool salir)
        {
            switch (MP)
            {
                case 1:
                    MenuSec();
                    break;
                case 2:
                    Barras bar = new Barras();
                    bar.Barra();
                    MenuSec();
                    break;
                case 3:
                    bool salir2 = false;
                    ResetSist reset = new ResetSist();
                    reset.ResetSis(ref salir2);
                    break;
                case 4: salir = true; break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opción incorrecta");
                    Console.WriteLine("   Presione enter para continuar....");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
        //Muestra el menú secundario y permite al usuario seleccionar una opción
        public void MenuSec()
        {
            bool salir1 = false;
            while (!salir1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                                 *===================*");
                Console.WriteLine("                                 |  MENÚ SECUNDARIO  |");
                Console.WriteLine("                                 *===================*");
                Console.WriteLine("                *=========================================================*");
                Console.WriteLine("                | 1. Comisionar Sensores     | 2. Monitoreo en Tiempo Real|");
                Console.WriteLine("                *=========================================================*");
                Console.WriteLine("                | 3. Ver Bitácora de Eventos | 4. Salir al Menú Principal |");
                Console.WriteLine("                *=========================================================*");
                Console.WriteLine("Ingrese una opción");
                int Ms1 = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (Ms1)
                {
                    case 1:
                        ComiSensor sensor = new ComiSensor();
                        sensor.Comisionar(ref salir1);
                        break;
                    case 2:
                        Console.Clear();
                        MostrarCroq most = new MostrarCroq();
                        most.MostrarCroqui();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        BitdeEventos bit = new BitdeEventos();
                        bit.BitadeEventos();
                        break;
                    case 4:
                        Console.WriteLine("");
                        salir1 = true;
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opción incorrecta");
                        Console.WriteLine("   Presione enter para continuar....");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}