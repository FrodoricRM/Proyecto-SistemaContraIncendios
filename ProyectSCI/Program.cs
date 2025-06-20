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
            while (!salir)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                        *______________________________________________*");
                Console.WriteLine("                        | Bienvenidos al SCI (Sistema Contra Incendios)|");
                Console.WriteLine("                        |         Ingrese la opción que desea          |");
                Console.WriteLine("                        *----------------------------------------------*");
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("                                       *=================*");
                Console.WriteLine("                                       |  MENÚ PRINCIPAL |");
                Console.WriteLine("                                       *=================*");
                Console.WriteLine("                   *=========================================================*");
                Console.WriteLine("                   | 1. Menú | 2. Inicializar Sistema | 3. Reset del Sistema |");
                Console.WriteLine("                   *=========================================================*");
                int x = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (x)
                {
                    case 2:
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

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("                                 *===================*");
                        Console.WriteLine("                                 |  MENÚ SECUNDARIO  |");
                        Console.WriteLine("                                 *===================*");
                        Console.WriteLine("                *=========================================================*");
                        Console.WriteLine("                | 1. Comisionar Sensores     | 2. Monitoreo en Tiempo Real|");
                        Console.WriteLine("                *=========================================================*");
                        Console.WriteLine("                | 3. Ver Bitácora de Eventos |   4. Configurar Umbrales   |");
                        Console.WriteLine("                *=========================================================*");
                        Console.WriteLine("                             | 5. Salir al Menú Principal |");
                        Console.WriteLine("                             *============================*");
                        Console.WriteLine("Ingrese una opción");
                        int x12 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (x12)
                        {
                            case 1:
                                Console.WriteLine("          *===========================================================*");
                                Console.WriteLine("          | 1. Encender Sensores | 2. Apagar Sensores | 3. Ver Estado |");
                                Console.WriteLine("          *===========================================================*");
                                Console.WriteLine("     Ingrese una opción");
                                int x3 = int.Parse(Console.ReadLine());
                                Console.Clear();
                                switch (x3)
                                {
                                    case 1:
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        const int t = 100;
                                        const int a2 = 50;
                                        Console.WriteLine("\n");
                                        for (int k = 0; k <= total; k++)
                                        {
                                            double porcentaje2 = k / (double)t;
                                            int bloques3 = (int)(porcentaje2 * a2);
                                            string b = new string('|', bloques3) + new string('─', a2 - bloques3);
                                            Console.Write($"\r    Sensores en la Planta 1:   [{b}] {k,3}%");
                                            Thread.Sleep(80);
                                        }
                                        for (int k = 0; k <= total; k++)
                                        {
                                            double porcentaje2 = k / (double)t;
                                            int bloques3 = (int)(porcentaje2 * a2);
                                            string b = new string('|', bloques3) + new string('─', a2 - bloques3);
                                            Console.Write($"\r    Sensores en la Planta 2:   [{b}] {k,3}%");
                                            Thread.Sleep(80);
                                        }
                                        for (int k = 0; k <= total; k++)
                                        {
                                            double porcentaje2 = k / (double)t;
                                            int bloques3 = (int)(porcentaje2 * a2);
                                            string b = new string('|', bloques3) + new string('─', a2 - bloques3);
                                            Console.Write($"\r    Sensores en la Planta 3:   [{b}] {k,3}%");
                                            Thread.Sleep(80);
                                        }
                                        for (int k = 0; k <= total; k++)
                                        {
                                            double porcentaje2 = k / (double)t;
                                            int bloques3 = (int)(porcentaje2 * a2);
                                            string b = new string('|', bloques3) + new string('─', a2 - bloques3);
                                            Console.Write($"\r    Sensores en la Planta 4:   [{b}] {k,3}%");
                                            Thread.Sleep(80);
                                        }
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine(" ¡Sensores Iniciados!"); break;
                                    case 2:
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        const int t1 = 100;
                                        const int a3 = 50;
                                        for (int c = 0; c <= total; c++)
                                        {
                                            double porcentaje2 = c / (double)t1;
                                            int bloques3 = (int)(porcentaje2 * a3);
                                            string b = new string('|', bloques3) + new string('─', a3 - bloques3);
                                            Console.Write($"\r    Sensores en la Planta 1:   [{b}] {c,3}%");
                                            Thread.Sleep(40);
                                        }
                                        for (int c = 0; c <= total; c++)
                                        {
                                            double porcentaje2 = c / (double)t1;
                                            int bloques3 = (int)(porcentaje2 * a3);
                                            string b = new string('|', bloques3) + new string('─', a3 - bloques3);
                                            Console.Write($"\r    Sensores en la Planta 2:   [{b}] {c,3}%");
                                            Thread.Sleep(40);
                                        }
                                        for (int c = 0; c <= total; c++)
                                        {
                                            double porcentaje2 = c / (double)t1;
                                            int bloques3 = (int)(porcentaje2 * a3);
                                            string b = new string('|', bloques3) + new string('─', a3 - bloques3);
                                            Console.Write($"\r    Sensores en la Planta 3:   [{b}] {c,3}%");
                                            Thread.Sleep(40);
                                        }
                                        for (int c = 0; c <= total; c++)
                                        {
                                            double porcentaje2 = c / (double)t1;
                                            int bloques3 = (int)(porcentaje2 * a3);
                                            string b = new string('|', bloques3) + new string('─', a3 - bloques3);
                                            Console.Write($"\r    Sensores en la Planta 4:   [{b}] {c,3}%");
                                            Thread.Sleep(40);
                                        }
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine(" ¡Sensores Apagados!"); break;
                                    case 3:
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("   *___________________________________*");
                                        Console.WriteLine("   | Comprobando Sensores Planta 1.... |");
                                        Console.WriteLine("   *-----------------------------------*");
                                        Random ran = new Random();
                                        int sensores = 3;
                                        bool algunafalla = ran.Next(0, 2) == 0;
                                        for (int j = 1; j <= sensores; j++)
                                        {
                                            bool falla = false;
                                            if (algunafalla)
                                            {
                                                falla = ran.NextDouble() < 0.1;
                                            }
                                            if (falla)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                            }
                                            string est;
                                            if (falla)
                                            {
                                                est = "Error";
                                                Console.Beep(800, 2000);
                                            }
                                            else
                                            {
                                                est = "Conectado";
                                            }
                                            Console.WriteLine("Sensor de Humo " + j + ":" + est);
                                            Thread.Sleep(300);
                                        }
                                        Console.ResetColor();
                                        Random ran5 = new Random();
                                        int sensores5 = 3;
                                        bool algunafalla5 = ran.Next(0, 2) == 0;
                                        for (int j4 = 1; j4 <= sensores5; j4++)
                                        {
                                            bool falla5 = false;
                                            if (algunafalla5)
                                            {
                                                falla5 = ran5.NextDouble() < 0.1;
                                            }
                                            if (falla5)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                            }
                                            string est4;
                                            if (falla5)
                                            {
                                                est4 = "Error";
                                                Console.Beep(800, 2000);
                                            }
                                            else
                                            {
                                                est4 = "Conectado";
                                            }
                                            Console.WriteLine("Sensor de Temperatura " + j4 + ":" + est4);
                                            Thread.Sleep(300);
                                        }
                                        Console.ResetColor();
                                        Console.WriteLine("   *___________________________________*");
                                        Console.WriteLine("   | Comprobando Sensores Planta 2.... |");
                                        Console.WriteLine("   *-----------------------------------*");
                                        Random ran1 = new Random();
                                        int sensores1 = 3;
                                        bool algunafalla1 = ran1.Next(0, 2) == 0;
                                        for (int j1 = 1; j1 <= sensores1; j1++)
                                        {
                                            bool falla2 = false;
                                            if (algunafalla1)
                                            {
                                                falla2 = ran1.NextDouble() < 0.1;
                                            }
                                            if (falla2)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                            }
                                            string est1;
                                            if (falla2)
                                            {
                                                est1 = "Error";
                                                Console.Beep(800, 2000);
                                            }
                                            else
                                            {
                                                est1 = "Conectado";
                                            }
                                            Console.WriteLine("Sensor de Humo " + j1 + ":" + est1);
                                            Thread.Sleep(300);
                                        }
                                        Console.ResetColor();
                                        Random ran6 = new Random();
                                        int sensores6 = 3;
                                        bool algunafalla6 = ran.Next(0, 2) == 0;
                                        for (int j5 = 1; j5 <= sensores6; j5++)
                                        {
                                            bool falla6 = false;
                                            if (algunafalla6)
                                            {
                                                falla6 = ran6.NextDouble() < 0.1;
                                            }
                                            if (falla6)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                            }
                                            string est5;
                                            if (falla6)
                                            {
                                                est5 = "Error";
                                                Console.Beep(800, 2000);
                                            }
                                            else
                                            {
                                                est5 = "Conectado";
                                            }
                                            Console.WriteLine("Sensor de Temperatura " + j5 + ":" + est5);
                                            Thread.Sleep(300);
                                        }
                                        Console.ResetColor();
                                        Console.WriteLine("   *___________________________________*");
                                        Console.WriteLine("   | Comprobando Sensores Planta 3.... |");
                                        Console.WriteLine("   *-----------------------------------*");
                                        Random ran2 = new Random();
                                        int sensores2 = 3;
                                        bool algunafalla2 = ran2.Next(0, 2) == 0;
                                        for (int j2 = 1; j2 <= sensores2; j2++)
                                        {
                                            bool falla3 = false;
                                            if (algunafalla2)
                                            {
                                                falla3 = ran2.NextDouble() < 0.1;
                                            }
                                            if (falla3)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                            }
                                            string est2;
                                            if (falla3)
                                            {
                                                est2 = "Error";
                                                Console.Beep(800, 2000);
                                            }
                                            else
                                            {
                                                est2 = "Conectado";
                                            }
                                            Console.WriteLine("Sensor de Humo " + j2 + ":" + est2);
                                            Thread.Sleep(300);
                                        }
                                        Console.ResetColor();
                                        Random ran7 = new Random();
                                        int sensores7 = 3;
                                        bool algunafalla7 = ran7.Next(0, 2) == 0;
                                        for (int j6 = 1; j6 <= sensores7; j6++)
                                        {
                                            bool falla7 = false;
                                            if (algunafalla7)
                                            {
                                                falla7 = ran7.NextDouble() < 0.1;
                                            }
                                            if (falla7)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                            }
                                            string est6;
                                            if (falla7)
                                            {
                                                est6 = "Error";
                                                Console.Beep(800, 2000);
                                            }
                                            else
                                            {
                                                est6 = "Conectado";
                                            }
                                            Console.WriteLine("Sensor de Temperatura " + j6 + ":" + est6);
                                            Thread.Sleep(300);
                                        }
                                        Console.ResetColor();
                                        Console.WriteLine("   *___________________________________*");
                                        Console.WriteLine("   | Comprobando Sensores Planta 4.... |");
                                        Console.WriteLine("   *-----------------------------------*");
                                        Random ran4 = new Random();
                                        int sensores4 = 3;
                                        bool algunafalla4 = ran4.Next(0, 2) == 0;
                                        for (int j3 = 1; j3 <= sensores4; j3++)
                                        {
                                            bool falla4 = false;
                                            if (algunafalla)
                                            {
                                                falla4 = ran4.NextDouble() < 0.1;
                                            }
                                            if (falla4)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                            }
                                            string est3;
                                            if (falla4)
                                            {
                                                est3 = "Error";
                                                Console.Beep(800, 2000);
                                            }
                                            else
                                            {
                                                est3 = "Conectado";
                                            }
                                            Console.WriteLine("Sensor de Humo" + j3 + ":" + est3);
                                            Thread.Sleep(300);
                                        }
                                        Console.ResetColor();
                                        Random ran8 = new Random();
                                        int sensores8 = 3;
                                        bool algunafalla8 = ran8.Next(0, 2) == 0;
                                        for (int j7 = 1; j7 <= sensores8; j7++)
                                        {
                                            bool falla8 = false;
                                            if (algunafalla8)
                                            {
                                                falla8 = ran8.NextDouble() < 0.1;
                                            }
                                            if (falla8)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                            }
                                            string est7;
                                            if (falla8)
                                            {
                                                est7 = "Error";
                                                Console.Beep(800, 2000);
                                            }
                                            else
                                            {
                                                est7 = "Conectado";
                                            }
                                            Console.WriteLine("Sensor de Temperatura " + j7 + ":" + est7);
                                            Thread.Sleep(300);
                                        }
                                        Console.ResetColor(); break;
                                }
                                break;
                            case 2:
                                Console.Clear();
                                MostrarCroquisSensores();
                                break;
                            case 3:
                                if (File.Exists("Bitacora_de_eventos.txt"))
                                {
                                    string contenido = File.ReadAllText("Bitacora_de_eventos.txt");
                                    Console.WriteLine("\n Bienvenido a la Bitácora de Eventos");
                                    Console.WriteLine(contenido);
                                }
                                else
                                {
                                    Console.WriteLine("Aún no se ha creado una Bitácora de Eventos");
                                }
                                break;
                            case 4:
                                break;
                            case 5:
                                Console.WriteLine("");
                                salir = true;
                                break;
                            default:
                                Console.WriteLine("Opción incorrecta"); break;
                        }
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("                                 *===================*");
                        Console.WriteLine("                                 |  MENÚ SECUNDARIO  |");
                        Console.WriteLine("                                 *===================*");
                        Console.WriteLine("                *=========================================================*");
                        Console.WriteLine("                | 1. Comisionar Sensores     | 2. Monitoreo en Tiempo Real|");
                        Console.WriteLine("                *=========================================================*");
                        Console.WriteLine("                | 3. Ver Bitácora de Eventos |   4. Configurar Umbrales   |");
                        Console.WriteLine("                *=========================================================*");
                        Console.WriteLine("                             | 5. Salir al Menú Principal |");
                        Console.WriteLine("                             *============================*");
                        Console.WriteLine("Ingrese una opción");
                        int x14 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (x14)
                        {
                            case 1:
                                Console.WriteLine("          *===========================================================*");
                                Console.WriteLine("          | 1. Encender Sensores | 2. Apagar Sensores | 3. Ver Estado |");
                                Console.WriteLine("          *===========================================================*");
                                Console.WriteLine("     Ingrese una opción");
                                int x3 = int.Parse(Console.ReadLine());
                                Console.Clear();
                                switch (x3)
                                {
                                    case 1:
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        const int t = 100;
                                        const int a2 = 50;
                                        Console.WriteLine("\n");
                                        for (int k = 0; k <= total; k++)
                                        {
                                            double porcentaje2 = k / (double)t;
                                            int bloques3 = (int)(porcentaje2 * a2);
                                            string b = new string('|', bloques3) + new string('─', a2 - bloques3);
                                            Console.Write($"\r    Sensores en la Planta 1:   [{b}] {k,3}%");
                                            Thread.Sleep(80);
                                        }
                                        for (int k = 0; k <= total; k++)
                                        {
                                            double porcentaje2 = k / (double)t;
                                            int bloques3 = (int)(porcentaje2 * a2);
                                            string b = new string('|', bloques3) + new string('─', a2 - bloques3);
                                            Console.Write($"\r    Sensores en la Planta 2:   [{b}] {k,3}%");
                                            Thread.Sleep(80);
                                        }
                                        for (int k = 0; k <= total; k++)
                                        {
                                            double porcentaje2 = k / (double)t;
                                            int bloques3 = (int)(porcentaje2 * a2);
                                            string b = new string('|', bloques3) + new string('─', a2 - bloques3);
                                            Console.Write($"\r    Sensores en la Planta 3:   [{b}] {k,3}%");
                                            Thread.Sleep(80);
                                        }
                                        for (int k = 0; k <= total; k++)
                                        {
                                            double porcentaje2 = k / (double)t;
                                            int bloques3 = (int)(porcentaje2 * a2);
                                            string b = new string('|', bloques3) + new string('─', a2 - bloques3);
                                            Console.Write($"\r    Sensores en la Planta 4:   [{b}] {k,3}%");
                                            Thread.Sleep(80);
                                        }
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine(" ¡Sensores Iniciados!"); break;
                                    case 2:
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        const int t1 = 100;
                                        const int a3 = 50;
                                        for (int c = 0; c <= total; c++)
                                        {
                                            double porcentaje2 = c / (double)t1;
                                            int bloques3 = (int)(porcentaje2 * a3);
                                            string b = new string('|', bloques3) + new string('─', a3 - bloques3);
                                            Console.Write($"\r    Sensores en la Planta 1:   [{b}] {c,3}%");
                                            Thread.Sleep(40);
                                        }
                                        for (int c = 0; c <= total; c++)
                                        {
                                            double porcentaje2 = c / (double)t1;
                                            int bloques3 = (int)(porcentaje2 * a3);
                                            string b = new string('|', bloques3) + new string('─', a3 - bloques3);
                                            Console.Write($"\r    Sensores en la Planta 2:   [{b}] {c,3}%");
                                            Thread.Sleep(40);
                                        }
                                        for (int c = 0; c <= total; c++)
                                        {
                                            double porcentaje2 = c / (double)t1;
                                            int bloques3 = (int)(porcentaje2 * a3);
                                            string b = new string('|', bloques3) + new string('─', a3 - bloques3);
                                            Console.Write($"\r    Sensores en la Planta 3:   [{b}] {c,3}%");
                                            Thread.Sleep(40);
                                        }
                                        for (int c = 0; c <= total; c++)
                                        {
                                            double porcentaje2 = c / (double)t1;
                                            int bloques3 = (int)(porcentaje2 * a3);
                                            string b = new string('|', bloques3) + new string('─', a3 - bloques3);
                                            Console.Write($"\r    Sensores en la Planta 4:   [{b}] {c,3}%");
                                            Thread.Sleep(40);
                                        }
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine(" ¡Sensores Apagados!"); break;
                                    case 3:
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("   *___________________________________*");
                                        Console.WriteLine("   | Comprobando Sensores Planta 1.... |");
                                        Console.WriteLine("   *-----------------------------------*");
                                        Random ran = new Random();
                                        int sensores = 3;
                                        bool algunafalla = ran.Next(0, 2) == 0;
                                        for (int j = 1; j <= sensores; j++)
                                        {
                                            bool falla = false;
                                            if (algunafalla)
                                            {
                                                falla = ran.NextDouble() < 0.1;
                                            }
                                            if (falla)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                            }
                                            string est;
                                            if (falla)
                                            {
                                                est = "Error";
                                                Console.Beep(800, 2000);
                                            }
                                            else
                                            {
                                                est = "Conectado";
                                            }
                                            Console.WriteLine("Sensor de Humo " + j + ":" + est);
                                            Thread.Sleep(300);
                                        }
                                        Console.ResetColor();
                                        Random ran5 = new Random();
                                        int sensores5 = 3;
                                        bool algunafalla5 = ran.Next(0, 2) == 0;
                                        for (int j4 = 1; j4 <= sensores5; j4++)
                                        {
                                            bool falla5 = false;
                                            if (algunafalla5)
                                            {
                                                falla5 = ran5.NextDouble() < 0.1;
                                            }
                                            if (falla5)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                            }
                                            string est4;
                                            if (falla5)
                                            {
                                                est4 = "Error";
                                                Console.Beep(800, 2000);
                                            }
                                            else
                                            {
                                                est4 = "Conectado";
                                            }
                                            Console.WriteLine("Sensor de Temperatura " + j4 + ":" + est4);
                                            Thread.Sleep(300);
                                        }
                                        Console.ResetColor();
                                        Console.WriteLine("   *___________________________________*");
                                        Console.WriteLine("   | Comprobando Sensores Planta 2.... |");
                                        Console.WriteLine("   *-----------------------------------*");
                                        Random ran1 = new Random();
                                        int sensores1 = 3;
                                        bool algunafalla1 = ran1.Next(0, 2) == 0;
                                        for (int j1 = 1; j1 <= sensores1; j1++)
                                        {
                                            bool falla2 = false;
                                            if (algunafalla1)
                                            {
                                                falla2 = ran1.NextDouble() < 0.1;
                                            }
                                            if (falla2)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                            }
                                            string est1;
                                            if (falla2)
                                            {
                                                est1 = "Error";
                                                Console.Beep(800, 2000);
                                            }
                                            else
                                            {
                                                est1 = "Conectado";
                                            }
                                            Console.WriteLine("Sensor de Humo " + j1 + ":" + est1);
                                            Thread.Sleep(300);
                                        }
                                        Console.ResetColor();
                                        Random ran6 = new Random();
                                        int sensores6 = 3;
                                        bool algunafalla6 = ran.Next(0, 2) == 0;
                                        for (int j5 = 1; j5 <= sensores6; j5++)
                                        {
                                            bool falla6 = false;
                                            if (algunafalla6)
                                            {
                                                falla6 = ran6.NextDouble() < 0.1;
                                            }
                                            if (falla6)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                            }
                                            string est5;
                                            if (falla6)
                                            {
                                                est5 = "Error";
                                                Console.Beep(800, 2000);
                                            }
                                            else
                                            {
                                                est5 = "Conectado";
                                            }
                                            Console.WriteLine("Sensor de Temperatura " + j5 + ":" + est5);
                                            Thread.Sleep(300);
                                        }
                                        Console.ResetColor();
                                        Console.WriteLine("   *___________________________________*");
                                        Console.WriteLine("   | Comprobando Sensores Planta 3.... |");
                                        Console.WriteLine("   *-----------------------------------*");
                                        Random ran2 = new Random();
                                        int sensores2 = 3;
                                        bool algunafalla2 = ran2.Next(0, 2) == 0;
                                        for (int j2 = 1; j2 <= sensores2; j2++)
                                        {
                                            bool falla3 = false;
                                            if (algunafalla2)
                                            {
                                                falla3 = ran2.NextDouble() < 0.1;
                                            }
                                            if (falla3)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                            }
                                            string est2;
                                            if (falla3)
                                            {
                                                est2 = "Error";
                                                Console.Beep(800, 2000);
                                            }
                                            else
                                            {
                                                est2 = "Conectado";
                                            }
                                            Console.WriteLine("Sensor de Humo " + j2 + ":" + est2);
                                            Thread.Sleep(300);
                                        }
                                        Console.ResetColor();
                                        Random ran7 = new Random();
                                        int sensores7 = 3;
                                        bool algunafalla7 = ran7.Next(0, 2) == 0;
                                        for (int j6 = 1; j6 <= sensores7; j6++)
                                        {
                                            bool falla7 = false;
                                            if (algunafalla7)
                                            {
                                                falla7 = ran7.NextDouble() < 0.1;
                                            }
                                            if (falla7)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                            }
                                            string est6;
                                            if (falla7)
                                            {
                                                est6 = "Error";
                                                Console.Beep(800, 2000);
                                            }
                                            else
                                            {
                                                est6 = "Conectado";
                                            }
                                            Console.WriteLine("Sensor de Temperatura " + j6 + ":" + est6);
                                            Thread.Sleep(300);
                                        }
                                        Console.ResetColor();
                                        Console.WriteLine("   *___________________________________*");
                                        Console.WriteLine("   | Comprobando Sensores Planta 4.... |");
                                        Console.WriteLine("   *-----------------------------------*");
                                        Random ran4 = new Random();
                                        int sensores4 = 3;
                                        bool algunafalla4 = ran4.Next(0, 2) == 0;
                                        for (int j3 = 1; j3 <= sensores4; j3++)
                                        {
                                            bool falla4 = false;
                                            if (algunafalla)
                                            {
                                                falla4 = ran4.NextDouble() < 0.1;
                                            }
                                            if (falla4)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                            }
                                            string est3;
                                            if (falla4)
                                            {
                                                est3 = "Error";
                                                Console.Beep(800, 2000);
                                            }
                                            else
                                            {
                                                est3 = "Conectado";
                                            }
                                            Console.WriteLine("Sensor de Humo" + j3 + ":" + est3);
                                            Thread.Sleep(300);
                                        }
                                        Console.ResetColor();
                                        Random ran8 = new Random();
                                        int sensores8 = 3;
                                        bool algunafalla8 = ran8.Next(0, 2) == 0;
                                        for (int j7 = 1; j7 <= sensores8; j7++)
                                        {
                                            bool falla8 = false;
                                            if (algunafalla8)
                                            {
                                                falla8 = ran8.NextDouble() < 0.1;
                                            }
                                            if (falla8)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                            }
                                            string est7;
                                            if (falla8)
                                            {
                                                est7 = "Error";
                                                Console.Beep(800, 2000);
                                            }
                                            else
                                            {
                                                est7 = "Conectado";
                                            }
                                            Console.WriteLine("Sensor de Temperatura " + j7 + ":" + est7);
                                            Thread.Sleep(300);
                                        }
                                        Console.ResetColor(); break;
                                }
                                break;
                            case 2:
                                Console.Clear();
                                MostrarCroquisSensores();
                                break;
                            case 3:
                                if (File.Exists("Bitacora_de_eventos.txt"))
                                {
                                    string contenido = File.ReadAllText("Bitacora_de_eventos.txt");
                                    Console.WriteLine("\n Bienvenido a la Bitácora de Eventos");
                                    Console.WriteLine(contenido);
                                }
                                else
                                {
                                    Console.WriteLine("Aún no se ha creado una Bitácora de Eventos");
                                }
                                break;
                            case 4:
                                break;
                            case 5:
                                Console.WriteLine("");
                                salir = false;
                                break;
                            default:
                                Console.WriteLine("Opción incorrecta"); break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("                   *=========================================================================*");
                        Console.WriteLine("                   | 1. Vaciar el Archivo | 2. Borrar el Archivo | 3. Salir al Menú Principal|");
                        Console.WriteLine("                   *=========================================================================*");
                        int x13 = int.Parse(Console.ReadLine());
                        switch (x13)
                        {
                            case 1:
                                File.WriteAllText("Bitacora_de_eventos.txt", string.Empty);
                                break;
                            case 2:
                                if (File.Exists("Bitacora_de_eventos.txt"))
                                {
                                    File.Delete("Bitacora_de_eventos.txt");
                                }
                                break;
                            case 3:
                                Console.WriteLine("");
                                salir = false;
                                break;
                            default: Console.WriteLine("Opción Incorrecta"); break;
                        }
                        break;
                    default: Console.WriteLine("Opción Incorrecta"); break;
                }

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
        static void MostrarCroquisSensores()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random rnd = new Random();
            const int anchoInterior = 45;
            while (!Console.KeyAvailable)
            {
                bool hayAlarma = false;
                bool hayAlarma1 = false;
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

                    // Sensores de humo 
                    for (int s = 1; s <= 3; s++)
                    {
                        double alarmaHumo;
                        if (rnd.NextDouble() < 0.05) // 5% de probabilidad
                        {
                            alarmaHumo = rnd.Next(57, 126);
                        }
                        else
                        {
                            alarmaHumo = rnd.Next(-40, 57);
                        }

                        if (alarmaHumo >= 57)
                        {
                            hayAlarma = true;
                            RegisEvent("ALERTA: Sensor de Humo " + s + " en [Planta " + planta + "] activado ---> Temp: " + alarmaHumo + "°C");
                            Console.ForegroundColor = ConsoleColor.Red;
                            string iconoHumo = "🔴";
                            string textoHumo = "Sensor de Humo " + s + ": " + iconoHumo + "|Temp. Actual:" + alarmaHumo + "°C";
                            Console.Write("│ ");
                            Console.Write(textoHumo.PadRight(anchoInterior - 1));
                            Console.WriteLine("│");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            string iconoHumo = "🟢";
                            string textoHumo = "Sensor de Humo " + s + ": " + iconoHumo + "|Temp. Actual:" + alarmaHumo + "°C";
                            Console.Write("│ ");
                            Console.Write(textoHumo.PadRight(anchoInterior - 1));
                            Console.WriteLine("│");
                        }
                    }

                    // Sensores de temperatura 
                    for (int s = 1; s <= 3; s++)
                    {
                        double alarmaTemp;
                        if (rnd.NextDouble() < 0.05) // 5% de probabilidad
                        {
                            alarmaTemp = rnd.Next(450, 601);
                        }
                        else
                        {
                            alarmaTemp = rnd.Next(-200, 450);
                        }

                        if (alarmaTemp >= 450)
                        {
                            hayAlarma1 = true;
                            RegisEvent("ALERTA: Sensor de Temperatura " + s + " en [Planta " + planta + "] activado ---> Temp: " + alarmaTemp + "°C");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            string iconoTemp = "🟡";
                            string textoTemp = "Sensor de Temp " + s + ": " + iconoTemp + "|Temp. Actual:" + alarmaTemp + "°C";
                            Console.Write("│ ");
                            Console.Write(textoTemp.PadRight(anchoInterior - 1));
                            Console.WriteLine("│");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            string iconoTemp = "🟢";
                            string textoTemp = "Sensor de Temp " + s + ": " + iconoTemp + "|Temp. Actual:" + alarmaTemp + "°C";
                            Console.Write("│ ");
                            Console.Write(textoTemp.PadRight(anchoInterior - 1));
                            Console.WriteLine("│");
                        }
                    }

                    // Línea inferior
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("└" + new string('─', anchoInterior) + "┘\n");
                }

                if (hayAlarma == true || hayAlarma1 == true)
                {

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    string hor = (" [" + DateTime.Now.ToString("HH:mm:ss") + "] ");
                    Console.WriteLine("\n Finalizando monitoreo..." + hor);
                    // Mostrar mensaje si hubo alarma
                    if (hayAlarma == true)
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
                    if (hayAlarma1 == true)
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
        static void RegisEvent(string mensaje)
        {
            string rutarchi = "Bitacora_de_eventos.txt";
            string entrada = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - " + mensaje;
            File.AppendAllText(rutarchi, entrada + Environment.NewLine); //escribir texto en un archivo de forma que añade (no sobrescribe) el contenido anterior
        }
    }
}
