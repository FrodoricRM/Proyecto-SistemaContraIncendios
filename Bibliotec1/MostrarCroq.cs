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
        //Este método muestra un croquis de las plantas con los sensores de humo y temperatura
        public void MostrarCroqui()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random rnd = new Random();
            const int anchoInterior = 45;
            while (!Console.KeyAvailable)//Mientras no se presione una tecla, el monitoreo continuará
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
                //Si existen alertas en cualquiera de ambos tipos de sensores se deja de refrescar y se guarda el evento en la bitácora
                if (hayAlarmaHumo == true || hayAlarmaTemp == true)
                {

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    string hor = (" [" + DateTime.Now.ToString("HH:mm:ss") + "] ");
                    Console.WriteLine("\n Finalizando monitoreo..." + hor);
                    // Mostrar mensaje si hubo alarma
                    if (hayAlarmaHumo == true)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Beep(1500, 150);
                            Console.Beep(800, 150);

                            if (i % 2 == 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                            }
                            Console.Clear();
                        }
                        Console.ResetColor();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡¡¡Sensor de Humo Encendido!!!");
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("  **---------------------------------------------------------------------------------**");
                        Console.WriteLine("  ||          __        **        **______   **_____**   __________      __          ||");
                        Console.WriteLine("  ||         // *       ||        ||         ||     ||       ||         // *         ||");
                        Console.WriteLine("  ||        //   *      ||        ||         ||     ||       ||        //   *        ||");
                        Console.WriteLine("  ||       //     *     ||        ||----     ||=====**       ||       //     *       ||");
                        Console.WriteLine("  ||      //=======*    ||        ||         ||  *           ||      //=======*      ||");
                        Console.WriteLine("  ||     //         *   ||        ||         ||    *         ||     //         *     ||");
                        Console.WriteLine("  ||    //           *  **=====   **======   ||      *       ||    //           *    || ");
                        Console.WriteLine("  **---------------------------------------------------------------------------------**");
                    }
                    if (hayAlarmaTemp == true)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Beep(1500, 150);
                            Console.Beep(800, 150);

                            if (i % 2 == 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                            }
                            Console.Clear();
                        }
                        Console.ResetColor();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("¡¡¡ Sensor de Temperatura Encendido!!!!");
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("  **---------------------------------------------------------------------------------**");
                        Console.WriteLine("  ||          __        **        **______   **_____**   __________      __          ||");
                        Console.WriteLine("  ||         // *       ||        ||         ||     ||       ||         // *         ||");
                        Console.WriteLine("  ||        //   *      ||        ||         ||     ||       ||        //   *        ||");
                        Console.WriteLine("  ||       //     *     ||        ||----     ||=====**       ||       //     *       ||");
                        Console.WriteLine("  ||      //=======*    ||        ||         ||  *           ||      //=======*      ||");
                        Console.WriteLine("  ||     //         *   ||        ||         ||    *         ||     //         *     ||");
                        Console.WriteLine("  ||    //           *  **=====   **======   ||      *       ||    //           *    || ");
                        Console.WriteLine("  **---------------------------------------------------------------------------------**");
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
        // Sensores: Muestra el estado de los sensores de una planta específica
        public void Sensores(Random rnd, ref bool hayAlarma, int planta, int anchoInterior, string icono, string icono_1, int min, int max, int min_1, int humoTemp)
        {
            // Genera un número aleatorio para determinar si hay alarma o no
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
                // Verifica si la alarma supera el umbral mínimo
                if (alarma >= min)
                {
                    // Se activa la alarma y se registra el evento
                    hayAlarma = true;
                    if (humoTemp == 1)
                    {
                        RegistEvent("ALERTA: Sensor de Humo " + s + " en [Planta " + planta + "] activado ---> Humo: " + alarma + "°C");
                    }
                    else
                    {
                        RegistEvent("ALERTA: Sensor de Temperatura " + s + " en [Planta " + planta + "] activado ---> Temp: " + alarma + "°C");
                    }
                    // Se muestra el mensaje de alerta en la consola, dependiendo a si es de humo (humotemp = 1) o temperatura (humotemp = 0)
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
                    // Si no hay alarma, se muestra el estado normal del sensor, y se continua la verificacion
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
        // RegistEvent: Registra eventos en un archivo de texto
        public void RegistEvent(string mensaje)
        {
            string rutarchi = "Bitacora_de_eventos.txt";
            //Obtiene la hora actual, en el formado indicado como parametro
            string entrada = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - " + mensaje;
            // Verifica si el archivo existe, si no, lo crea y escribe lo que se le pase como segundo argumento
            File.AppendAllText(rutarchi, entrada + Environment.NewLine); //escribir texto en un archivo de forma que añade (no sobrescribe) el contenido anterior
        }
    }
}