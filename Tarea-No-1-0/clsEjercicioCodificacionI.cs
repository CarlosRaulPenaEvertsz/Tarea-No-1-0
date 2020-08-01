using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No_1_0
{
    class clsEjercicioCodificacionI
    {
        public void Ejecuta()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio Codificación I");
            Console.WriteLine("------------------------\n\n");
      
            Console.WriteLine("***  Información Personal   ***");
            Console.WriteLine("Nombre          : Carlos");
            Console.WriteLine("Apellido        : Peña");
            Console.WriteLine("Apodo           : -");
            Console.WriteLine("Fecha Nacimiento: 15-Feb-1966");
            Console.WriteLine("Teléfono        : 809-689-7698");
            Console.WriteLine("Móvil           : 809-330-8938");
            Console.WriteLine("País            : República Dominicana");
            Console.WriteLine("Ciudad          : Santo Domingo, D.N.");
            Console.WriteLine("Dirección       : N. Ureña M. 131, Los Prados");
            Console.WriteLine("Lugar de Trabajo: Editora Dominicana, SRL");
            Console.WriteLine("Sueldo          : RD$15,000.00");

            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();
        }
    }
}
