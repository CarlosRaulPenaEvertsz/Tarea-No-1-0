using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No_1_0
{
    class clsEjercicioCodificacionII
    {
        public void Ejecuta()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio Codificación II");
            Console.WriteLine("------------------------\n\n");

            double valor1 = 0, valor2 = 0, resultado = 0;
            Console.WriteLine("====> PROGRAMA QUE SUMA DOS NUMEROS <====");
            Console.WriteLine("Ingrese el Primer Valor:");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el Segundo Valor");
            valor2 = double.Parse(Console.ReadLine());
            resultado = valor1 + valor2;
            Console.WriteLine($"El Resultado es {resultado}");
            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();

        }
    }
}
