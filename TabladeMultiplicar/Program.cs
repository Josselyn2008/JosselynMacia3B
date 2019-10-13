using System;

namespace TabladeMultiplicar
{
    class Program
    {
        //Crear el programa tablaMultiplicar que escriba la tabla de multiplicar del número 1 al número 15
        static void Main(string[] args)
        {
            int Multiplicacion;
            Console.WriteLine(" Ingrese el numero del cual desea consultar la tabla de multiplicar ");
            int dato = int.Parse(Console.ReadLine());
            Console.WriteLine("\nTabla de multiplicar del {0}", dato);
            Console.WriteLine("------------------------------");
            for (int j = 1; j <= 15; j++)
            {
                Multiplicacion = dato * j;
                Console.WriteLine("{0} x {1} = {2}", dato, j, Multiplicacion);
            }
            Console.ReadLine();
        }
    }
}
