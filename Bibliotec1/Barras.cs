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
