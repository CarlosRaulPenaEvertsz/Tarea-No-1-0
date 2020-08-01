using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No_1_0
{
    class clsEjercicioCodificacionVI2
    {
        public void Ejecuta()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio Codificación VI-2");
            Console.WriteLine("--------------------------\n\n");

            // Prog.Carga un Vector y Luego Imprime y calcule la sumatoria
            int intEntrada = 0;
            int[] Vector = new int[5];
            int intSumatoria = 0;
            //Captura de codigos
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    Console.Write($"Entre el Codigo No. {i + 1} ");
                    intEntrada = int.Parse(Console.ReadLine());
                    if (intEntrada < 1)
                    {
                        Console.WriteLine("Código Inválido, vuelva a intentarlo.");
                    }

                } while (intEntrada < 1);
                Vector[i] = intEntrada;
            }

            Console.Clear();
            Console.WriteLine("Ejercicio Codificación VI-1");
            Console.WriteLine("--------------------------\n\n");

            Console.WriteLine("Relación de Códigos en Vector\n");
            for (int i = 0; i < 5; i++)
            {
                intSumatoria += Vector[i];
                Console.WriteLine("Vector[ {0} ] = {1}", i, Vector[i]);
            }
            Console.WriteLine($"La Sumatoria del Vector es = {intSumatoria}");

            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();
        }

    }
}
