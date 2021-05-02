using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //contador declaration
            int cont=0;

            int[] miVector = new int[16];
            Random r = new Random();
            //Console.WriteLine("Posición");
          

            // Marc's suggestion

            for (int i = 0; i < miVector.Length; i++)
            {
                miVector[i] = r.Next(-10, 21);
                Console.Write(miVector[i] + "   ");
                
                if (miVector[i]%2 == 0 && miVector[i] > 0){
                cont++;
               
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(cont + " números son múltiples de dos y positivos");
            Console.WriteLine();
            // ejercicio C
            int[,] miMatriz = new int[4, 4];
            int indice = 0;

            //para asignar valores a la matriz
            for (int k = 0; k < 4; k++)
            {
                for (int j = 0; j < 4; j++)
                {
                    miMatriz[k, j] = miVector[indice];
                    indice++;
                }
            }


            ////para mostrar la matriz
            for (int k = 0; k < 4; k++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(miMatriz[k, j] + "    ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

                   
                

        }
    }
}


