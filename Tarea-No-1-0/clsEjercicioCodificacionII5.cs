using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No_1_0
{
    class clsEjercicioCodificacionII5
    {
        public void Ejecuta()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio Codificación II-V");
            Console.WriteLine("------------------------\n\n");

            // Prog.Convierte Centímetros -> Pulgadas

            double dblMedidaEnCentimetros = 0.0;
            double dblMedidaEnPulgadas = 0.0;

            Console.WriteLine("Entre La Medida en Centimetros");
            dblMedidaEnCentimetros = double.Parse(Console.ReadLine());

            dblMedidaEnPulgadas = dblMedidaEnCentimetros / 2.54;

            Console.WriteLine($"{dblMedidaEnCentimetros} centímetros es {dblMedidaEnPulgadas} pulgadas");

            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();
        }
    }
}
