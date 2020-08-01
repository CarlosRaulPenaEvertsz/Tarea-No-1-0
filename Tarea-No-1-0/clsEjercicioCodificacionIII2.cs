using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No_1_0
{
    class clsEjercicioCodificacionIII2
    {
        public void Ejecuta()
        {


            Console.Clear();
            Console.WriteLine("Ejercicio Codificación III-II");
            Console.WriteLine("------------------------\n\n");

            // Programa que calcula el promedio de cuatro notas.

            double Nota1;
            double Nota2;
            double Nota3;
            double Nota4;
            double Promedio;
            string Resultado = "";

            Console.WriteLine("Entre la 1ra. Nota");
            Nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre la 2da. Nota");
            Nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre la 3ra. Nota");
            Nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre la 4ta. Nota");
            Nota4 = Convert.ToDouble(Console.ReadLine());

            Promedio = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

            if (Promedio < 65)
            {
                Resultado = "Reprobado";
            } else if (Promedio < 75)
            {
                Resultado = "Aprobado";
            } else if (Promedio < 85)
            {
                Resultado = "Muy Bueno";
            } else if (Promedio < 90)
            {
                Resultado = "Sobresaliente";
            } else if (Promedio <= 100)
            {
                Resultado = "Excelente";
            } else
            {
                Resultado = "Fuera de Rango";
            }

            Console.WriteLine($"\n\n=======================\nEl promedio es {Promedio.ToString()}\nLa Calificación es {Resultado}");

            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();
        }
    }

}