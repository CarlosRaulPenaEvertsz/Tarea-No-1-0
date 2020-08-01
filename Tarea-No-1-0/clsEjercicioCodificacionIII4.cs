using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No_1_0
{
    class clsEjercicioCodificacionIII4
    {

        public void Ejecuta()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio Codificación III-IV");
            Console.WriteLine("------------------------\n\n");

            // Programa Despliega Dia Semana.
            string DiaSeleccionado = "";
            Console.WriteLine("Entre el Numero del Dia de la Semana Deseado(1-7)");
            int intDia = int.Parse(Console.ReadLine());

            switch (intDia)
            {
                case 1:
                    DiaSeleccionado = "Lunes";
                    break;
                case 2:
                    DiaSeleccionado = "Martes";
                    break;
                case 3:
                    DiaSeleccionado = "Miércoles";
                    break;
                case 4:
                    DiaSeleccionado = "Jueves";
                    break;
                case 5:
                    DiaSeleccionado = "Viernes";
                    break;
                case 6:
                    DiaSeleccionado = "Sábado";
                    break;
                case 7:
                    DiaSeleccionado = "Domingo";
                    break;
                default:
                    DiaSeleccionado = "Fuera de Rango";
                    break;
            }
            Console.WriteLine("\nSe Ha Seleccionado el dia '" + DiaSeleccionado + "'");

            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();
        }
    }
}
