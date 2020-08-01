using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No_1_0
{
    class clsEjercicioCodificacionIV1
    {
        public void Ejecuta()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio Codificación IV-I");
            Console.WriteLine("------------------------\n\n");

            // Programa que Muestra los numeros del 1-100.

            for (int i = 1;i<=100;i++)
            {
                Console.Write($"{i} \t");
                if ((i % 10)==0)
                {
                    Console.Write($"\n");
                }
            }

            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();
        }
    }
}
