using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No_1_0
{
    class clsEjercicioCodificacionII2
    {
        public void Ejecuta()
        {

            Console.Clear();
            Console.WriteLine("Ejercicio Codificación II-II");
            Console.WriteLine("------------------------\n\n");

            // Programa que calcula el promedio de cuatro notas.

            double NotaEnero;
            double NotaFebrero;
            double NotaMarzo;
            double NotaAbril;
            double Promedio;
            Console.WriteLine("Entre la Nota de Enero");
            NotaEnero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre la Nota de Febrero");
            NotaFebrero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre la Nota de Marzo");
            NotaMarzo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre la Nota de Abril");
            NotaAbril = Convert.ToDouble(Console.ReadLine());

            Promedio = (NotaEnero + NotaFebrero + NotaMarzo + NotaAbril) / 4;
            Console.WriteLine($"\n\n=======================\nEl promedio es {Promedio.ToString()}");

            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();

        }

    }
}
