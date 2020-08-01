using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No_1_0
{
    class clsEjercicioCodificacionII6
    {
        public void Ejecuta()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio Codificación II-VI");
            Console.WriteLine("------------------------\n\n");

            // Prog.Calculo Cuota Simple

            double dblCuotaPrestamo = 0.0;
            double dblMontoPrestamo = 0.0;
            double dblTasaInteres = 0.0;
            double dblTiempo = 0.0;

            Console.WriteLine("Entre el Monto del Préstamo");
            dblMontoPrestamo = Double.Parse(Console.ReadLine());
            Console.WriteLine("Entre la Tasa de Interes a Aplicar");
            dblTasaInteres = Double.Parse(Console.ReadLine());
            Console.WriteLine("Entre el Tiempo del Préstamo");
            dblTiempo = Double.Parse(Console.ReadLine());

            if (dblTiempo == 0)
            {
                Console.WriteLine("El Tiempo No Puede ser Cero.");
            }
            else
            {
                dblCuotaPrestamo = ((dblMontoPrestamo * dblTasaInteres) / dblTiempo) + (dblMontoPrestamo / dblTiempo);
                Console.WriteLine("El Monto de Cuota es {0}", dblCuotaPrestamo.ToString("c"));
            }

            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();

        }
    }
}
