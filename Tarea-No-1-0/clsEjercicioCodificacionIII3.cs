using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No_1_0
{
    class clsEjercicioCodificacionIII3
    {
        public void Ejecuta()
        {

            Console.Clear();
            Console.WriteLine("Ejercicio Codificación III-III");
            Console.WriteLine("------------------------\n\n");

            // Prog.Edad Según Criterio.


            double dblEdad;
            string strCondicion;

            Console.WriteLine("Entre su Edad");
            dblEdad = Convert.ToDouble(Console.ReadLine());

            if (dblEdad==0 || dblEdad == 1)
            {
                strCondicion = "Bebé";
            } else if (dblEdad >= 2 && dblEdad <= 12)
            {
                strCondicion = "Niño";
            } else if (dblEdad >= 13 && dblEdad <= 17)
            {
                strCondicion = "Adolescente"; 
            } else if (dblEdad >= 18 && dblEdad <= 64)
            {
                strCondicion = "Adulto";
            } else if (dblEdad >= 65 && dblEdad <= 120)
            {
                strCondicion = "Anciano";
            } else
            {
                strCondicion = "Error";
            }

            Console.WriteLine($"\nLa Persona tiene una condición de {strCondicion} ");
            Console.ReadKey();
        }
    }
}
