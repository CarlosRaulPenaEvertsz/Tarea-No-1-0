using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No_1_0
{
    class clsEjercicioCodificacionII1
    {
        public void Ejecuta()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio Codificación II-I");
            Console.WriteLine("------------------------\n\n");

            // Programa que pide el nombre del usuario y luego salude llamandolo por su nombre

            string strNombre;
            Console.WriteLine("Cómo Te llamas?");
            strNombre = Console.ReadLine();
            Console.WriteLine($"Hola {strNombre.ToUpper()}");

            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();
        }
    }
}
