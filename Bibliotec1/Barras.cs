using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bibliotec1
{
    public class Barras
    {
        public void Barra()
        {
            // Barra de progreso para iniciar el sistema
            Console.ForegroundColor = ConsoleColor.Green;
            const int total = 100;
            const int anchoBarra = 50;
            for (int i = 0; i <= total; i++)
            {
                // Calcular el porcentaje y el número de bloques para la barra
                double porcentaje = i / (double)total;
                int bloques = (int)(porcentaje * anchoBarra);
                // Crear la barra de progreso con bloques y espacios
                string barra = new string('|', bloques) + new string('─', anchoBarra - bloques);
                Console.Write($"\r    Iniciando Sistema!:   [{barra}] {i,3}%");
                Thread.Sleep(80);
            }
        }
        // Barra de progreso para los sensores (Es mas rapida, muestra un mensaje distinto)
        public void Barra1(string planta, int time)
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
    }
}