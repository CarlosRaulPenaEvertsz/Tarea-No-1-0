using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No_1_0
{
    class clsEjercicioCodificacionV2
    {
        public void Ejecuta()
        {
            // Prog. Despliega Tabla Seleccionada por el usuario y calcula promedio

            String strOpcion = "";
            
            Console.Clear();
            Console.WriteLine("Ejercicio Codificación V-2");
            Console.WriteLine("--------------------------\n\n");
            Console.WriteLine("****************************");
            Console.WriteLine("*     Menú de Opciones     *");
            Console.WriteLine("*--------------------------*");
            Console.WriteLine("* T - Tabla de Multiplicar *");
            Console.WriteLine("*                          *");
            Console.WriteLine("* P - Calcular Promedio    *");
            Console.WriteLine("*                          *");
            Console.WriteLine("* S - Salir                *");
            Console.WriteLine("****************************");

            Console.Write("\n\n Indique la Opción ");

            strOpcion = Console.ReadLine();

            switch (strOpcion)
            {
                case "t":
                case "T":
                    // Tabla Multiplicar
                    Console.Clear();
                    int t=0;
                    Console.WriteLine("Entre el Numero de la Tabla de Multiplicación Deseada");
                    t = int.Parse(Console.ReadLine());
                    
                    Console.Clear();
                    Console.WriteLine($"Tabla Multiplicacion del {t}");
                    Console.WriteLine("----------------------------\n\n");

                    // Prog. Despliega Tabla Multiplicar del Usuario

                    for (int i = 1; i <= 12; i++)
                    {
                        Console.WriteLine($"{t} x {i} = {i * t}");
                    }
                    break;

                case "p":
                case "P":
                    // Programa Promedio
                    double Nota1;
                    double Nota2;
                    double Nota3;
                    double Nota4;
                    double Promedio;
                    string Resultado = "";
                    Console.Clear();
                  
                    Console.WriteLine("Calculo de Promedio\n\n");

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
                    }
                    else if (Promedio < 75)
                    {
                        Resultado = "Aprobado";
                    }
                    else if (Promedio < 85)
                    {
                        Resultado = "Muy Bueno";
                    }
                    else if (Promedio < 90)
                    {
                        Resultado = "Sobresaliente";
                    }
                    else if (Promedio <= 100)
                    {
                        Resultado = "Excelente";
                    }
                    else
                    {
                        Resultado = "Fuera de Rango";
                    }

                    Console.WriteLine($"\n\n=======================\nEl promedio es {Promedio.ToString()}\nLa Calificación es {Resultado}");


                    break;
                default:
                    break;

            }

            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();
        }


    }
}
