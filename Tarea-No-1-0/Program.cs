using System;

namespace Tarea_No_1_0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menu Tarea No. 1-0 
            string strSeleccion = " ";
            int intSeleccion = 1;

            while (intSeleccion != 99) {
                Console.Clear();
                Console.WriteLine("Menu Tarea No. 1-0");
                Console.WriteLine("------------------");

                // Menu de ejercicios
                Console.WriteLine("1-Ejercicio Codificacion I.(Prog. Despliega Información Personal )");
                Console.WriteLine("2-Ejercicio Codificacion II.(Prog. que Suma Dos Numeros)");
                Console.WriteLine("3-Ejercicio Codificacion II-I.(Prog. que Saluda por Su Nombre)");
                Console.WriteLine("4-Ejercicio Codificacion II-II.(Prog. que calcula el promedio de cuatro notas)");
                Console.WriteLine("5-Ejercicio Codificacion II-III.(Prog. que calcula ITBIS e Imprime Totales)");
                Console.WriteLine("6-Ejercicio Codificacion II-IV.(Prog. Calcula Sueldo Bruto,Sueldo Neto y Desc.)");
                Console.WriteLine("7-Ejercicio Codificacion II-V.(Prog. Convierte Centímetros -> Pulgadas)");
                Console.WriteLine("8-Ejercicio Codificacion II-VI.(Prog. Calculo Cuota Simple)");
                Console.WriteLine("9-Operadores Lógicos. (Respuestas Ejercicio Pag. 5)");
                Console.WriteLine("10-Ejercicio Codificacion III-I.(Prog.Calcula Sueldo Bruto,Sueldo Neto y Desc.)");
                Console.WriteLine("11-Ejercicio Codificacion III-II.(Prog.Calcula promedio de cuatro notas.)");
                Console.WriteLine("12-Ejercicio Codificacion III-III.(Prog. Edad Según Criterio.)");
                Console.WriteLine("13-Ejercicio Codificacion III-IV.(Prog. Despliega Dia Semana.)");
                Console.WriteLine("14-Ejercicio Codificacion IV-I.(Prog. Despliega Nos. 1-100.)");
                Console.WriteLine("15-Ejercicio Codificacion IV-II.(Prog. Despliega Nos. 100-105.)");
                Console.WriteLine("16-Ejercicio Codificacion IV-III.(Prog. Despliega Nos. 3-20 con su Cubo.)");
                Console.WriteLine("17-Ejercicio Codificacion IV-IV.(Prog.Despliega Tabla Multiplicar del 4.)");
                Console.WriteLine("18-Ejercicio Codificacion IV-V.(Prog.Despliega Tabla Multiplicar 1-12.)");
                Console.WriteLine("19-Ejercicio Codificacion V-I.(Prog.Despliega Tabla Mult.4 Usando While.)");
                Console.WriteLine("20-Ejercicio Codificacion V-II.(Prog.Despliega Menu para Tabla y Promedio)");
                Console.WriteLine("21-Ejercicio Codificacion VI-I.(Prog.Carga un Vector de 5 Codigos validos)");
                Console.WriteLine("22-Ejercicio Codificacion VI-II.(Prog.Calcule e Imprima Sum de un Vector)");
                Console.WriteLine("23-Ejercicio Codificacion VI-III.(Prog. Llene Tabla con Nombres y la Imprima)");
                Console.WriteLine("24-Ejercicio Codificacion VI-IV.(Prog. Sume Dos Matrices)");
                // 
                Console.Write("***Seleccione el Ejercicio a Ejecutar y Presione ENTER. (99-Salir)");

                strSeleccion = Console.ReadLine();

                if (strSeleccion.Length > 0)
                    intSeleccion = int.Parse(strSeleccion);
                else
                    intSeleccion = 0;
                //*********************************************
                // Seleccion de ejercicios
                //********************************************
                switch (intSeleccion)
                {
                    case 1: // Despliega Información Personal 
                        clsEjercicioCodificacionI EjercicioCodificacionI = new clsEjercicioCodificacionI();
                        EjercicioCodificacionI.Ejecuta();
                        break;
                    case 2: // Programa que Suma Dos Numeros
                        clsEjercicioCodificacionII EjercicioCodificacionII = new clsEjercicioCodificacionII();
                        EjercicioCodificacionII.Ejecuta();
                        break;
                    case 3: // Programa que Saluda por Su Nombre
                        clsEjercicioCodificacionII1 EjercicioCodificacionII1 = new clsEjercicioCodificacionII1();
                        EjercicioCodificacionII1.Ejecuta();
                        break;
                    case 4: // Programa que calcula el promedio de cuatro notas
                        clsEjercicioCodificacionII2 EjercicioCodificacionII2 = new clsEjercicioCodificacionII2();
                        EjercicioCodificacionII2.Ejecuta();
                        break;
                    case 5: // Prog. que calcula ITBIS e Imprime Totales
                        clsEjercicioCodificacionII3 EjercicioCodificacionII3 = new clsEjercicioCodificacionII3();
                        EjercicioCodificacionII3.Ejecuta();
                        break;
                    case 6: // Prog. Calcula sueldo bruto (SB), sueldo neto (SN) y descuento (DD).
                        clsEjercicioCodificacionII4 EjercicioCodificacionII4 = new clsEjercicioCodificacionII4();
                        EjercicioCodificacionII4.Ejecuta();
                        break;
                    case 7: // Prog.Convierte Centímetros -> Pulgadas
                        clsEjercicioCodificacionII5 EjercicioCodificacionII5 = new clsEjercicioCodificacionII5();
                        EjercicioCodificacionII5.Ejecuta();
                        break;
                    case 8: // Prog.Calculo Cuota Simple
                        clsEjercicioCodificacionII6 EjercicioCodificacionII6 = new clsEjercicioCodificacionII6();
                        EjercicioCodificacionII6.Ejecuta();
                        break;
                    case 9: // Solucion Ejercicios Pag. 5
                        clsEjercicioCodificacionII7 EjercicioCodificacionII7 = new clsEjercicioCodificacionII7();
                        EjercicioCodificacionII7.Ejecuta();
                        break;
                    case 10: // Prog.Calcula Sueldo Bruto,Sueldo Neto y Desc.
                        clsEjercicioCodificacionIII1 EjercicioCodificacionIII1 = new clsEjercicioCodificacionIII1();
                        EjercicioCodificacionIII1.Ejecuta();
                        break;
                    case 11: // Prog.Calcula promedio de cuatro notas.
                        clsEjercicioCodificacionIII2 EjercicioCodificacionIII2 = new clsEjercicioCodificacionIII2();
                        EjercicioCodificacionIII2.Ejecuta();
                        break;
                    case 12: // Prog.Edad Según Criterio.
                        clsEjercicioCodificacionIII3 EjercicioCodificacionIII3 = new clsEjercicioCodificacionIII3();
                        EjercicioCodificacionIII3.Ejecuta();
                        break;
                    case 13: // Prog.Despliega Dia Semana.
                        clsEjercicioCodificacionIII4 EjercicioCodificacionIII4 = new clsEjercicioCodificacionIII4();
                        EjercicioCodificacionIII4.Ejecuta();
                        break;
                    case 14: // Prog. Despliega Nos. 1-100.
                        clsEjercicioCodificacionIV1 EjercicioCodificacionIV1 = new clsEjercicioCodificacionIV1();
                        EjercicioCodificacionIV1.Ejecuta();
                        break;
                    case 15: // Prog. Despliega Nos. 100-105.
                        clsEjercicioCodificacionIV2 EjercicioCodificacionIV2 = new clsEjercicioCodificacionIV2();
                        EjercicioCodificacionIV2.Ejecuta();
                        break;
                    case 16: // Prog. Despliega Nos. 3-20 con su Cubo.
                        clsEjercicioCodificacionIV3 EjercicioCodificacionIV3 = new clsEjercicioCodificacionIV3();
                        EjercicioCodificacionIV3.Ejecuta();
                        break;
                    case 17: // Prog. Despliega Tabla Multiplicar del 4
                        clsEjercicioCodificacionIV4 EjercicioCodificacionIV4 = new clsEjercicioCodificacionIV4();
                        EjercicioCodificacionIV4.Ejecuta();
                        break;
                    case 18: // Prog. Despliega Tabla Multiplicar del 1 al 12
                        clsEjercicioCodificacionIV5 EjercicioCodificacionIV5 = new clsEjercicioCodificacionIV5();
                        EjercicioCodificacionIV5.Ejecuta();
                        break;
                    case 19: // Prog. Despliega Tabla Multiplicar del 1 al 12
                        clsEjercicioCodificacionV1 EjercicioCodificacionV1 = new clsEjercicioCodificacionV1();
                        EjercicioCodificacionV1.Ejecuta();
                        break;
                    case 20: // Prog.Despliega Menu para Tabla o Promedio
                        clsEjercicioCodificacionV2 EjercicioCodificacionV2 = new clsEjercicioCodificacionV2();
                        EjercicioCodificacionV2.Ejecuta();
                        break;
                    case 21: // Prog.Carga un Vector de 5 Codigos validos
                        clsEjercicioCodificacionVI1 EjercicioCodificacionVI1 = new clsEjercicioCodificacionVI1();
                        EjercicioCodificacionVI1.Ejecuta();
                        break;
                    case 22: // Prog.Calcule e Imprima Sum de un Vector
                        clsEjercicioCodificacionVI2 EjercicioCodificacionVI2 = new clsEjercicioCodificacionVI2();
                        EjercicioCodificacionVI2.Ejecuta();
                        break;
                    case 23: // Prog.Llene Tabla con Nombres y la Imprima
                        clsEjercicioCodificacionVI3 EjercicioCodificacionVI3 = new clsEjercicioCodificacionVI3();
                        EjercicioCodificacionVI3.Ejecuta();
                        break;
                    case 24: // Prog.Sume dos Matrices
                        clsEjercicioCodificacionVI4 EjercicioCodificacionVI4 = new clsEjercicioCodificacionVI4();
                        EjercicioCodificacionVI4.Ejecuta();
                        break;

                    default:
                        Console.WriteLine("Default case");
                        break;
                }

            }
            Console.Clear();
            Console.WriteLine("Bye...");
        }
    }
}
