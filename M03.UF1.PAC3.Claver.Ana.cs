using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_con_la_pac
{
    class Program
    {
        static void Main(string[] args)
        {
           // Ana Claver Barceló
            int num_clientes, coste_compra, dinero_entregado, resto;
            int contador_cliente = 1;
            int eur2 = 0;
            int eur1 = 0;
            int cts50 = 0;
            int cts20 = 0;
            int cts10 = 0;
            int cts5 = 0;
            int cts2 = 0;
            int cts1 = 0;

            // Empezamos con un bucle de control de errores. El usuario debe introducir que al menos habrá un cliente.
            do
            {
                Console.Write("Entra el número de clientes: ");
                num_clientes = int.Parse(Console.ReadLine());

            } while (num_clientes <= 1);

            // Empieza el bucle que ejecutaremos para cada cliente.
            do
            {
                // Bucle de control de errores inicial: nos aseguramos que el coste de la compra sea al menos de 1 céntimo.
                do
                {
                    Console.Write("Entra el coste de la compra: ");
                    coste_compra = int.Parse(Console.ReadLine());

                } while (coste_compra <= 1);

                // Cuando el usuario introduce el importe del dinero entregado para pagar hay tres opciones: 1. que no dé suficiente dinero, 2. que dé el importe exacto, o 3. que dé demasiado (haga falta cambio) y haga falta ver cuántas monedas de cada tipo habrá que devolverle como cambio.
                Console.Write("Entra el importe del dinero entregado en cts: ");
                dinero_entregado = int.Parse(Console.ReadLine());

                // Opción 1. que no dé suficiente dinero
                if (dinero_entregado < coste_compra)
                {
                    Console.WriteLine("DEBE {0}", coste_compra);
                }
                // Opción 2. que dé el importe exacto
                else if (dinero_entregado == coste_compra)
                {
                    Console.WriteLine("No se debe nada");
                }
                // Opción 3. que dé demasiado (haga falta cambio) y haga falta ver cuántas monedas de cada tipo habrá que devolverle como cambio.
                else
                {
                    // Lo primero será saber cuántos décimos hay que devolverle. Hacemos la resta. (Reusamos variable "dinero_entregado"). 
                    dinero_entregado = dinero_entregado - coste_compra;

                    // Hacemos una división del total de centimos por la cantidad de céntimos de cada moneda. El resto de la división deberá darse en monedas que tengan un valor en céntimos inferior, en este caso monedos de 1 EUR, o sea, 100 cent. (Reusamos variable "dinero_entregado"). 
                    eur2 = dinero_entregado / 200;
                    resto = dinero_entregado % 200;
                    // Cogemos el resto de la división anterior y hacemos la división por la cantidad de la siguiente moneda con mayor valor en céntimos. El resto de la división deberá darse en monedas que tengan un valor en céntimos inferior, en este caso monedos de 50 cent. (Reusamos variable "dinero_entregado").
                    eur1 = resto / 100;
                    resto = resto % 100;
                    // Seguimos las misma operación que las precedentes hasta llegar a la moneda con el menor valor en céntimos, la de 1 céntimo.
                    cts50 = resto / 50;
                    resto = resto % 50;

                    cts20 = resto / 20;
                    resto = resto % 20;

                    cts10 = resto / 10;
                    resto = resto % 10;

                    cts5 = resto / 5;
                    resto = resto % 5;

                    cts2 = resto / 2;
                    resto = resto % 2;
                    
                    cts1 = resto / 1;
                    resto = resto % 1;
                    // Al final escribiremos los valores que hemos ido guardando en las 8 variables (8 tipos de monedas distintos).
                    Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", eur2, eur1, cts50, cts20, cts10, cts5, cts2, cts1);
                }

                // Acaba el bucle que ejecutaremos para cada cliente. No debemos olvidar de sumar 1 al contador de clientes para que el bucle se ejecute tantas veces como clientes tengamos.
                contador_cliente++;

            } while (contador_cliente <= num_clientes);

            Console.ReadLine();
        }
    }
}

