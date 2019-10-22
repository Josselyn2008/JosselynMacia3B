using System;
using BraJos.BraJoss;

namespace BraJos
{
    class Program
    {
        static void Main(string[] args)
        {
            nota J = new nota();
           
            Console.WriteLine(" Ingrese el nombre del estudiante \n ");
            J.Nombre = Console.ReadLine();
            int c = 0;
            do
            {
                if (c <=1)
                {
                    Console.WriteLine(" Nombre incorrecto ingrese de nuevo  \n ");
                    J.Nombre = Console.ReadLine();
                }
                for (int i = 0; i < J.Nombre.Length; i++)
                {
                    if (J.Nombre[i] == ' ')
                    {
                        c++;
                    }
                }
            } while (c != 3 && c<=4);

            Console.WriteLine("\nIngrese la nota de actuacion en clase del primer parcial\n ");
            J.Ac1p = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Ingrese la nota de practica del primer parcial \n ");
            J.Pr1p = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Ingrese la nota de Tarea del primer parcial \n ");
            J.Ta1p = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Ingrese la nota del examen final del primer parcial\n");
            J.Ef1p = int.Parse(Console.ReadLine());
           
            Console.WriteLine("\nIngrese la nota de actuacion en clase del segundo parcial \n");
            J.Ac2p = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Ingrese la nota de practica del segundo parcial\n ");
            J.Pr2p = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Ingrese la nota de tarea del segundo parcial \n");
            J.Ta2p = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Ingrese la nota del examen final del segundo parcial \n");
            J.Ef2p = int.Parse(Console.ReadLine());

            Console.WriteLine("\nLa nota del primer parcial del estudiante es:\n " + J.Primerparcial + "\n");
            Console.WriteLine("\nLa nota del segundo parcial es:\n " + J.Segundoparcial+ "\n");
            Console.WriteLine("\nLa suma entre los parciales es de:\n " + J.Suma+ "\n");
            Console.WriteLine("\nEl estado del estudiante es \n" + J.Estado+ "\n");

            Console.WriteLine("\n Ingrese la nota de recuperacion en caso que no tenga que dar ingrese 0\n");
            J.Recuperacion = int.Parse(Console.ReadLine());
            Console.WriteLine("\nLa nota de los parciales incluyendo la recuperacion es:\n " + J.Suma2+ "\n");
            Console.WriteLine("\nLa nota final de curso es: \n" + J.Final + "\n");
            
            Console.ReadLine();
        }
    }
}
