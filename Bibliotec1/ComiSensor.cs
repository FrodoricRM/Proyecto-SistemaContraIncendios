using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Bibliotec1
{
    public class ComiSensor
    {
        public void Comisionar(ref bool salir1)
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
                        Barras bar1 = new Barras();
                        bar1.Barra1($"Planta {i}", time1);
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
                        Barras bar1 = new Barras();
                        bar1.Barra1($"Planta {i}", time2);
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
                    ComprobarSen("Planta 1");
                    ComprobarSen("Planta 2");
                    ComprobarSen("Planta 3");
                    ComprobarSen("Planta 4");
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
        public void ComprobarSen(string planta)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"   *___________________________________*");
            Console.WriteLine($"   | Comprobando Sensores {planta}.... |");
            Console.WriteLine($"   *-----------------------------------*");

            MostrarEst("Humo");
            MostrarEst("Temperatura");
        }
        public void MostrarEst(string tipo)
        {
            Random rand = new Random();
            int sensores = 3;
            bool algunaFalla = rand.Next(0, 2) == 0;

            for (int i = 1; i <= sensores; i++)
            {
                bool falla = algunaFalla && rand.NextDouble() < 0.1;
                if (falla)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                string estado;
                if (falla)
                {
                    estado = "Error";
                }
                else
                {
                    estado = "Conectado";
                }
                Console.WriteLine("Sensor de " + tipo + i + ": " + estado);

                if (falla)
                    Console.Beep(800, 2000);

                Thread.Sleep(300);
            }

            Console.ResetColor();
        }
    }
}
