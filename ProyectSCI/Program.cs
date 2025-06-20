using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;//nos sirve para importar el espacio de nombres (namespace) System.IO, que contiene clases para trabajar con archivos, etc.

namespace ProyectSCI
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                Console.WriteLine("            *=========================================================*");
                Console.WriteLine("            | 1. Menú | 2. Inicializar Sistema | 3. Reset del Sistema |");
                Console.WriteLine("            *=========================================================*");
                Console.WriteLine("Ingrese la opción que desea...");
                int MP = int.Parse(Console.ReadLine());
                Console.Clear();
                MenuPrincipal(MP);
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
        static void MenuPrincipal(int MP)
        {
            switch (MP)
            {
                case 1:
                    MenuSecundario();
                    break;
                case 2:
                    Barra();
                    MenuSecundario();
                    break;
                case 3:
                    ResetSis();
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
        static void Barra()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            const int total = 100;
            const int anchoBarra = 50;
            for (int i = 0; i <= total; i++)
            {
                double porcentaje = i / (double)total;
                int bloques = (int)(porcentaje * anchoBarra);
                string barra = new string('|', bloques) + new string('─', anchoBarra - bloques);
                Console.Write($"\r    Iniciando Sistema!:   [{barra}] {i,3}%");
                Thread.Sleep(80);
            }
        }
        static void MenuSecundario()
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
                        ComisionarSensores(salir1); break;
                    case 2:
                        Console.Clear();
                        MostrarCroquis();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        BitadeEventos();
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
        static void ComisionarSensores(bool salir1)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("          *============================================================================================*");
            Console.WriteLine("          | 1. Encender Sensores | 2. Apagar Sensores | 3. Ver Estado | 4. Regresar al Menú Secundario |");
            Console.WriteLine("          *============================================================================================*");
            Console.WriteLine("     Ingrese una opción");
            int Ms2 = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (Ms2)
            {
                case 1:
                    int time1 = 80;
                    Console.WriteLine("\n");
                    for (int i = 1; i <= 4; i++)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Barra1($"Planta {i}", time1);
                    }

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(" ¡Sensores Iniciados!");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("   Presione enter para regresar....");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    int time2 = 40;
                    Console.WriteLine("\n");
                    for (int i = 1; i <= 4; i++)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Barra1($"Planta {i}", time2);
                    }

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ¡Sensores Apagados!");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("   Presione enter para regresar....");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    ComprobarSensores("Planta 1");
                    ComprobarSensores("Planta 2");
                    ComprobarSensores("Planta 3");
                    ComprobarSensores("Planta 4");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("   Presione enter para regresar....");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 4:
                    salir1 = false;
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
        static void Barra1(string planta, int time)
        {

            const int total = 100;
            const int ancho = 50;
            for (int k = 0; k <= total; k++)
            {
                double porcentaje = k / (double)total;
                int bloques = (int)(porcentaje * ancho);
                string barra = new string('|', bloques) + new string('─', ancho - bloques);
                Console.Write($"\r    Sensores en la {planta}:   [{barra}] {k,3}%");
                Thread.Sleep(time);
            }
            Console.WriteLine();
        }
        static void ComprobarSensores(string planta)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"   *___________________________________*");
            Console.WriteLine($"   | Comprobando Sensores {planta}.... |");
            Console.WriteLine($"   *-----------------------------------*");

            MostrarEstadoSensores("Humo");
            MostrarEstadoSensores("Temperatura");
        }
        static void MostrarEstadoSensores(string tipo)
        {
            Random rand = new Random();
            int sensores = 3;
            bool algunaFalla = rand.Next(0, 2) == 0;

            for (int i = 1; i <= sensores; i++)
            {
                bool falla = algunaFalla && rand.NextDouble() < 0.1;
                Console.ForegroundColor = falla ? ConsoleColor.Red : ConsoleColor.Green;

                string estado = falla ? "Error" : "Conectado";
                Console.WriteLine($"Sensor de {tipo} {i}: {estado}");

                if (falla)
                    Console.Beep(800, 2000);

                Thread.Sleep(300);
            }

            Console.ResetColor();
        }
        static void MostrarCroquis()
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random rnd = new Random();
            const int anchoInterior = 45;
            while (!Console.KeyAvailable)
            {
                bool hayAlarmaHumo = false;
                bool hayAlarmaTemp = false;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                // Dibujar las 4 plantas
                for (int planta = 1; planta <= 4; planta++)
                {
                    Console.WriteLine("\n");

                    // Línea superior
                    Console.WriteLine("┌" + new string('─', anchoInterior) + "┐");

                    // Título centrado
                    string tituloBase = "Planta " + planta + " - Turbo Generador " + planta;
                    int antes = (anchoInterior - tituloBase.Length) / 2;
                    int despues = anchoInterior - antes - tituloBase.Length;
                    Console.Write("│");
                    Console.Write(new string(' ', antes));
                    Console.Write(tituloBase);
                    Console.Write(new string(' ', despues));
                    Console.WriteLine("│");

                    // Línea separadora
                    Console.WriteLine("├" + new string('─', anchoInterior) + "┤");

                    Sensores(rnd, ref hayAlarmaHumo, planta, anchoInterior, "🔴", "🟢", 57, 126, -40, 1);
                    Sensores(rnd, ref hayAlarmaTemp, planta, anchoInterior, "🟡", "🟢", 450, 601, -200, 0);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("└" + new string('─', anchoInterior) + "┘\n");
                }

                if (hayAlarmaHumo == true || hayAlarmaTemp == true)
                {

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    string hor = (" [" + DateTime.Now.ToString("HH:mm:ss") + "] ");
                    Console.WriteLine("\n Finalizando monitoreo..." + hor);
                    // Mostrar mensaje si hubo alarma
                    if (hayAlarmaHumo == true)
                    {
                        Console.Beep(1000, 500);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡ALERTA, Sensor de Humo Encendido !");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Todos los sensores de Humo están en estado normal.");
                    }
                    if (hayAlarmaTemp == true)
                    {
                        Console.Beep(1000, 500);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("¡ALERTA, Sensor de Temperatura Encendido !");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Todos los sensores de Temperatura están en estado normal.");
                    }
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("   Presione enter para regresar....");
                    break;
                }
                else
                {

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\n Refrescando...... ");
                    Console.WriteLine("Si desea salir presione cualquier tecla...");
                    Thread.Sleep(3000); // Pausa 3 segundo antes de la siguiente actualización
                }
            }
        }
        static void Sensores(Random rnd, ref bool hayAlarma, int planta, int anchoInterior, string icono, string icono_1, int min, int max, int min_1, int humoTemp)
        {
            for (int s = 1; s <= 3; s++)
            {
                string texto = "";
                double alarma;
                if (rnd.NextDouble() < 0.05) // 5% de probabilidad
                {
                    alarma = rnd.Next(min, max);
                }
                else
                {
                    alarma = rnd.Next(min_1, min);
                }

                if (alarma >= min)
                {
                    hayAlarma = true;
                    RegisEvent("ALERTA: Sensor de Humo " + s + " en [Planta " + planta + "] activado ---> Temp: " + alarma + "°C");
                    if (humoTemp == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        texto = "Sensor de Humo " + s + ": " + icono + "|Humo. Actual:" + alarma + "°C";
                        Console.Write("│ ");
                        Console.Write(texto.PadRight(anchoInterior - 1));
                        Console.WriteLine("│");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        texto = "Sensor de Temp " + s + ": " + icono + "|Temp. Actual:" + alarma + "°C";
                        Console.Write("│ ");
                        Console.Write(texto.PadRight(anchoInterior - 1));
                        Console.WriteLine("│");
                    }
                }
                else
                {
                    if (humoTemp == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        texto = "Sensor de Humo " + s + ": " + icono_1 + "|Humo. Actual:" + alarma + "°C";
                        Console.Write("│ ");
                        Console.Write(texto.PadRight(anchoInterior - 1));
                        Console.WriteLine("│");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        texto = "Sensor de Temp " + s + ": " + icono_1 + "|Temp. Actual:" + alarma + "°C";
                        Console.Write("│ ");
                        Console.Write(texto.PadRight(anchoInterior - 1));
                        Console.WriteLine("│");
                    }
                }
            }
        }
        static void RegisEvent(string mensaje)
        {
            string rutarchi = "Bitacora_de_eventos.txt";
            string entrada = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - " + mensaje;
            File.AppendAllText(rutarchi, entrada + Environment.NewLine); //escribir texto en un archivo de forma que añade (no sobrescribe) el contenido anterior
        }
        static bool salir = false;
        static void ResetSis()
        {
            Console.WriteLine("                   *=================================================================*");
            Console.WriteLine("                   | 1. Vaciar el Archivo | 2. Borrar el Archivo | 3. Volver al Menú |");
            Console.WriteLine("                   *=================================================================*");
            int Rsist = int.Parse(Console.ReadLine());
            switch (Rsist)
            {
                case 1:
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
        static void BitadeEventos()
        {
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