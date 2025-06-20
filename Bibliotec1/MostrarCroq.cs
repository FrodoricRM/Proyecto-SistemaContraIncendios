using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace Bibliotec1
{
    public class MostrarCroq
    {
        public void MostrarCroqui()
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

                // Dibuja las 4 plantas
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
        public void Sensores(Random rnd, ref bool hayAlarma, int planta, int anchoInterior, string icono, string icono_1, int min, int max, int min_1, int humoTemp)
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
                    RegistEvent("ALERTA: Sensor de Humo " + s + " en [Planta " + planta + "] activado ---> Temp: " + alarma + "°C");
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
        public void RegistEvent(string mensaje)
        {
            string rutarchi = "Bitacora_de_eventos.txt";
            string entrada = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - " + mensaje;
            File.AppendAllText(rutarchi, entrada + Environment.NewLine); //escribir texto en un archivo de forma que añade (no sobrescribe) el contenido anterior
        }
    }
}
