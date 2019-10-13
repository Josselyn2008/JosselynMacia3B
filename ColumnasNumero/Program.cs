using System;

namespace ColumnasNumero
{
    class Program
    {
        //   7. Crear un programa que escriba dos columnas de números, en la primera se colocan los números del 1 al
        //   100, en la segunda los números del 100 al 1 

        static void Main(string[] args)
        {  
            //Variables

            int i, j = 101;

            for (i = 1; i <= 100; i++)
            {
                j = j - 1;
                Console.WriteLine(i + "    " + j);
            }
        }
    }
}
