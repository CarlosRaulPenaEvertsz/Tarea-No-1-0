using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No_1_0
{
    class clsEjercicioCodificacionII4
    {
        public void Ejecuta()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio Codificación II-IV");
            Console.WriteLine("------------------------\n\n");

            // Prog.Calcula sueldo bruto(SB), sueldo neto(SN) y descuento(DD).

            double dblSueldoBruto = 0.0;
            double dblSueldoNeto = 0.0;
            double dblDescuento = 0.0;
            double dblTarifaPorHora = 0.0;
            double dblHorasTrabajadas = 0.0;
            double dblTasaDescuento = 0.10;

            Console.WriteLine("Entre las Horas Trabajadas");
            dblHorasTrabajadas = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre la Tarifa por Hora");
            dblTarifaPorHora = double.Parse(Console.ReadLine());

            dblSueldoBruto = dblTarifaPorHora * dblHorasTrabajadas;
            dblDescuento = dblSueldoBruto * dblTasaDescuento;
            dblSueldoNeto = dblSueldoBruto - dblDescuento;

            Console.WriteLine($"\nEl Sueldo Bruto es {dblSueldoBruto.ToString("c")}");
            Console.WriteLine($"El Descuento es {dblDescuento.ToString("c")}");
            Console.WriteLine($"El Sueldo Neto es {dblSueldoNeto.ToString("c")}");

            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();
        }
    }

}