using System;
namespace TresColumnas
{
    class Program
    {
        //Crear un programa en C# que lea un número entero y positivo y que escriba tres columnas. La primera
        //cuenta desde uno hasta el número escrito contando de uno en uno; la segunda columna cuenta de dos
        //en dos y la tercera de tres.

        static void Main(string[] args)
        {
            int j = 0, k = 0;
            Console.WriteLine(" Ingrese el numero hasta el cual necesita llegar"); 
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)//solo se hace esto mientras el numero sea mayor que cero por lo tanto se positivo 
            {
                for (int i = 1; i <= numero; i++) 
                {
                    //Estos casos de if solo se haran mientras i, j, y k sean menores o iguales al numero dado
                    
                    Console.Write(" " + i + "  ");
                    j = j + 2;
                    if (j <= numero)
                    {
                        Console.Write("  " + j + "  ");
                    }
                    k = k + 3;
                    if (k <= numero)
                    {
                        Console.Write(" " + k + "  ");

                    }
                    Console.WriteLine(" " );
                }
                
            }
            else//Esto solo sucede en caso de que el numero sea negativo
            {
                Console.WriteLine(" El numero ingresado es negativo por lo tanto no es valido  ");
            }
            Console.ReadLine();
        }
    }
}


