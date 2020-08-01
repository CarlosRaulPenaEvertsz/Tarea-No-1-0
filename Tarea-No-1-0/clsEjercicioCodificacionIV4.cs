using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No_1_0
{
    class clsEjercicioCodificacionIV4
    {
        public void Ejecuta()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio Codificación IV-4");
            Console.WriteLine("--------------------------\n\n");

            // Prog. Despliega Tabla Multiplicar del 4

            Console.WriteLine("Tabla de Multiplicación del No. 4");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"4 x {i} = {i*4}");
            }

            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();
        }

    }
}
