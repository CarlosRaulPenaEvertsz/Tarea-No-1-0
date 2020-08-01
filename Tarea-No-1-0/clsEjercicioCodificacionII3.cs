using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No_1_0
{
    class clsEjercicioCodificacionII3
    {
        public void Ejecuta()
        {

            Console.Clear();
            Console.WriteLine("Ejercicio Codificación II-III");
            Console.WriteLine("------------------------\n\n");

            // Programa Calculo ITBIS de Producto

            string strNombreProducto = "";
            double dblCantidad = 0;
            double dblPrecioUnitario = 0.00;
            double dblTasaITBIS = 0.18;
            double dblMontoITBIS = 0.00;
            double dblSubTotal = 0.00;
            double dblTotalPagar = 0.00;

            Console.WriteLine("Entre el Nombre del Producto");
            strNombreProducto = Console.ReadLine();
            Console.WriteLine("Entre el Precio Unitario:");
            dblPrecioUnitario = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre la Cantidad:");
            dblCantidad = double.Parse(Console.ReadLine());

            dblSubTotal = dblCantidad * dblPrecioUnitario;
            dblMontoITBIS = dblSubTotal * dblTasaITBIS;
            dblTotalPagar = dblSubTotal + dblMontoITBIS;

            Console.WriteLine($"El Subtotal = {dblSubTotal.ToString("C")}");
            Console.WriteLine($"Monto ITBIS = {dblMontoITBIS.ToString("C")}");
            Console.WriteLine($"Total a Pagar = {dblTotalPagar.ToString("C")}");

            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();

        }

    }
}
