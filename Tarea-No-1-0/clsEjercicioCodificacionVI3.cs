using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No_1_0
{
    class clsEjercicioCodificacionVI3
    {

        public void Ejecuta()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio Codificación VI-3");
            Console.WriteLine("--------------------------\n\n");

            // Programa Carga una Tabla con Nombres
            string[,] TablaNombres = new string[2,3];

            TablaNombres[0,0] = "Maria";
            TablaNombres[0,1] = "Miriam";
            TablaNombres[0,2] = "Sofia";

            TablaNombres[1,0] = "Carlos";
            TablaNombres[1,1] = "Pedro";
            TablaNombres[1,2] = "Josefo";


            // Listar Tabla

            for(int i=0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"TablaNombre[{i},{j}]={TablaNombres[i,j]}\t");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();
        }

    }
}
