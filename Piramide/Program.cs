using System;

namespace Piramide
{
    //5. Crear el programa asteriscos4 en el que se introduce un número entero y se crea una pirámide de
    // asteriscos.
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int alt, x, y;
            Console.WriteLine(" Ingrese la altura con la cual quiere realizar su piramide ");
            alt = int.Parse(Console.ReadLine());


            for(x = 0; x <= alt; x++)
            {
                for(y=0; y < alt - x; y++)
                {
                    Console.Write(" ");
                }
                for (y = 0; y < 2 * x - 1; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}
