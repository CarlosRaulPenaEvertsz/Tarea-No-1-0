using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No_1_0
{
    class clsEjercicioCodificacionIV5
    {
        public void Ejecuta()
        {
            // Prog. Despliega Tabla Multiplicar del 1 - 12
            for (int t = 1; t <= 12; t++)
            {
                Console.Clear();
                Console.WriteLine("Ejercicio Codificación IV-5");
                Console.WriteLine("--------------------------\n\n");
                Console.WriteLine($"Tabla de Multiplicación del No.{t}");
                Console.WriteLine("=================================");
                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine($"{t} x {i} = {i * t}");
                }
                if (t < 12)
                {
                    Console.WriteLine($"\n\nPresione Cualquier Tecla para Ver la Tabla Próxima (t={t + 1})");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();
        }

    }
}
