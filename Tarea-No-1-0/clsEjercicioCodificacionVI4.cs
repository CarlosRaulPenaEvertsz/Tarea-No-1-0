using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No_1_0
{
    class clsEjercicioCodificacionVI4
    {

        public void Ejecuta()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio Codificación VI-4");
            Console.WriteLine("--------------------------\n\n");

            // Programa Carga dos Matrices
            int[,] MatrizA = new int[2, 2];
            int[,] MatrizB = new int[2, 2];
            int[,] MatrizC = new int[2, 2];

            MatrizA[0, 0] = 70;
            MatrizA[0, 1] = 60;
            MatrizA[1, 0] = 80;
            MatrizA[1, 1] = 70;

            MatrizB[0, 0] = 68;
            MatrizB[0, 1] = 90;
            MatrizB[1, 0] = 80;
            MatrizB[1, 1] = 70;

            // Sumamos las Matrices y creamos la MatrizC con el resultado.
            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    MatrizC[i, j] = MatrizA[i, j] + MatrizB[i, j];
                }
            }


            // Imprimimos todo
            // Matriz A
            Console.WriteLine("Contenido Matriz A");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{MatrizA[i, j]} \t");
                }
                Console.WriteLine();
            }

            // Matriz B
            Console.WriteLine("\n\nContenido Matriz B");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{MatrizB[i, j]} \t");
                }
                Console.WriteLine();
            }

            // Matriz C
            Console.WriteLine("\n\nContenido Matriz C ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{MatrizC[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();
        }


    }
}
