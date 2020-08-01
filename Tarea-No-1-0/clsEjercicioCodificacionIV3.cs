using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No_1_0
{
    class clsEjercicioCodificacionIV3
    {
        public void Ejecuta()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio Codificación IV-3");
            Console.WriteLine("------------------------\n\n");

            // Programa que Muestra los numeros del 3-20 con su Cubo.

            for (int n = 3; n <= 20; n++)
            {
                Console.WriteLine($"n={n} ; n^3={Math.Pow(n, 3)}");
            }

            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();
        }

    }
}
