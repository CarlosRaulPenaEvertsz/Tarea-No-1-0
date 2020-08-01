using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No_1_0
{
    class clsEjercicioCodificacionV1
    {
        public void Ejecuta()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio Codificación V-1");
            Console.WriteLine("--------------------------\n\n");

            // Prog. Despliega Tabla Multiplicar del 4 usando While

            Console.WriteLine("Tabla de Multiplicación del No. 4\n");
            int i = 1;
            while (i <= 12)
            {
                Console.WriteLine($"4 x {i} = {i * 4}");
                i++;
            }
            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();
        }

    }
}
