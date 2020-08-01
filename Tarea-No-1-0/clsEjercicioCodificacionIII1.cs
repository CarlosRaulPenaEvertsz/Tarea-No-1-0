using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No_1_0
{
    class clsEjercicioCodificacionIII1
    {
        public void Ejecuta()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio Codificación III-I");
            Console.WriteLine("------------------------\n\n");

            // Prog.Calcula sueldo bruto(SB), sueldo neto(SN) y descuento(DD).

            double dblSueldoBruto = 0.0;
            double dblSueldoNeto = 0.0;
            double dblDescuento = 0.0;
            double dblTarifaPorHora = 0.0;
            double dblHorasTrabajadas = 0.0;
            

            Console.WriteLine("Entre las Horas Trabajadas");
            dblHorasTrabajadas = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre la Tarifa por Hora");
            dblTarifaPorHora = double.Parse(Console.ReadLine());

            dblSueldoBruto = dblTarifaPorHora * dblHorasTrabajadas;
            if (dblSueldoBruto > 5000)
            {
                dblDescuento = dblSueldoBruto * 0.10;
            } else
            {
                dblDescuento = dblSueldoBruto * 0.05;
            }

            dblSueldoNeto = dblSueldoBruto - dblDescuento;

            Console.WriteLine($"\nEl Sueldo Bruto es {dblSueldoBruto.ToString("c")}");
            Console.WriteLine($"El Descuento es {dblDescuento.ToString("c")}");
            Console.WriteLine($"El Sueldo Neto es {dblSueldoNeto.ToString("c")}");

            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();

        }
    }
}
