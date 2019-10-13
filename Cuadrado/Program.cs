using System;

namespace Cuadrado
{
    class Program {
        //2. Crear un programa que lea un número entero y a partir de él cree un cuadrado de asteriscos con ese
        //tamaño.Los asteriscos sólo se verán en el borde del cuadrado, no en el interior.


        static void Main(string[] args)
        {
            int a, b, c; //variables
            Console.WriteLine("Ingresar el tamaño con el que desea el cuadrado");
            int n = int.Parse(Console.ReadLine());

            //Parte superior 

            for (a= 0; a < n; a++) 
            {
                Console.Write("* ");
            }
            Console.WriteLine();

            //Parte lateral

            for (a = 0; a < n-2; a++) 
            {
                Console.Write("* ");
                for (b = 0; b < n-2; b++) 
                {
                    Console.Write("  ");
                }
                Console.WriteLine("* ");
            }

            //Parte inferior

            for (c = 0; c < n; c++) 
            {
                Console.Write("* ");
            }
            Console.ReadLine();
        }
    }
}