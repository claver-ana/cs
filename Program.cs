using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_pac4___test_funcion_menu
{
    class Program
    {
        static void Main(string[] args)
        {
         int opcion;

          do
         {
             Console.WriteLine("MENU");
             Console.WriteLine("1. Números aleatorios.");
             Console.WriteLine("2. Orden de cadenas de caracteres.");
             Console.WriteLine("3. Longitud de la concatenación.");
             Console.WriteLine("4. Salir del programa.");
             opcion = int.Parse(Console.ReadLine());
         

            //Si elige opción 1
          if (opcion == 1) {
              // llamada a la función Opcion1
              Opcion1();
              
            }
            //Si elige la opción 2
          else if (opcion == 2)
          {
              string a, b, c;
              Console.WriteLine("Introduce texto: ");
              a = Console.ReadLine();
              Console.WriteLine("Introduce texto: ");
              b = Console.ReadLine();
              // llamada a la función Opcion2
              Opcion2(a, b, out c);
              Console.WriteLine(c);
              
   
          }
            //Si elige la opción 3
          else if (opcion == 3)
          {
              string x;
              int y, z;

              Console.WriteLine("Introduce texto: ");
              x = Console.ReadLine();
              Console.WriteLine("Introduce cantidad: ");
              y = int.Parse(Console.ReadLine());
              // llamada a la función Opcion3
              z = Opcion3(ref x, y);
              Console.WriteLine(x + " " + z);
              
          }

         } while (opcion != 4);

        }
      
        //Estamos fuera del MAIN - Empieza la funcion Opcion1
        static void Opcion1()
        {
            int a, b;
            Random rdn = new Random();
            a = rdn.Next(10, 31);
            b = rdn.Next(10, 31);

            if (a < b)
            {
                do
                {
                    Console.WriteLine(a);
                    a++;
                } while (a <= b);
            }
            else
            {
                do
                {
                    Console.WriteLine(b);
                    b++;
                } while (b <= a);
            }
        }
        // Finaliza la función Opcion3
        // Empieza la funcion Opcion2
        static void Opcion2(string A1, string A2, out string A3)
        {
            A1 = A1.ToLower();
            A2 = A2.ToLower();

            int c = string.Compare(A1, A2);

            if (c == -1)
            {
                A3 = "MENOR";
            }
            else
            {
                A3 = "MAYOR";
            };
        }
        // Finaliza la función Opcion2
        // Empieza la funcion Opcion3
        static int Opcion3(ref string A, int B)
        {
            int resultado = 0;

            A = String.Concat(Enumerable.Repeat(A, B));
            resultado = A.Length;

            return resultado;
        }
        // Finaliza la función Opcion3
    }
}
