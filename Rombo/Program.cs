using System;

namespace Rombo
{
    class Program
    {
       // 6. Crear el programa asteriscos en el que se introduce un número entero y se crea un rombo de
       // asteriscos

        static void Main(string[] args)
        {
            int x, y, tam; //Variables
            Console.WriteLine("Ingrese el tamaño del que quiere su Rombo");
            tam = int.Parse(Console.ReadLine());

            //Parte superior

            for(x=1; x<=tam; x++)
            {
                for(y=1; y <= tam- x; y++)
                {
                    Console.Write(" ");
                }
                for(y=1; y <= 2 * x - 1; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Parte inferior

            for (x = tam-2; x >= 0; x--)
            {
                for (y = 1; y <= tam- x-1; y++)
                {
                    Console.Write(" ");
                }
                for (y = 0; y < 2 * x + 1; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
