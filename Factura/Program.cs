using System;

namespace Factura
{
    class Program
    {
       // 3. Crear un programa que lea cantidades y precios y al final indique el total de la factura.
       //Primero se pregunta:
       //Introduzca la cantidad vendida tras lo cual el usuario introducirá un número entero positivo.
       //Después se pregunta:
       //Introduzca el precio que será un número decimal positivo.
       //La lectura termina cuando en la cantidad se introduzca un cero.Si es así se escribirá el total.

        static void Main(string[] args)
        {
            double  cant=0;
            double prec = 0, sum = 0, total=0;
            Console.WriteLine(" Recuerde ingresar el cero cuando ya no tenga mas datos ");
            Console.WriteLine("  ");
            //Este do es para que se realice el proceso mientras la respuesta no se igual a 0
            do
            {
                Console.WriteLine(" Ingrese la cantidad total vendida");
                cant = double.Parse(Console.ReadLine());
                //este proceso dentro del if solo se realizara si las cantidades son mayores que cero 
                if (cant > 0)
                {
                    Console.WriteLine("  ");
                    Console.WriteLine(" Ingrese el precio de su producto ");
                    prec = double.Parse(Console.ReadLine());
                    total = cant * prec;
                    sum = sum + total;
                }
                else// Este Else es para que se realice el proceso a continuacion solo  si las cantidades son menores a cero o iguales
                {   // por lo tanto necesitamos otro if que nos permita hacer el proceso solo si es menor que cero 
                    if (cant < 0)
                    {
                        Console.WriteLine(" la cantidad ingresada es negativa por lo tanto no es valida  ");
                    }
                }
            } while (cant != 0);
            Console.Write(" Ha finalizado el ingreso de datos. Por lo tanto su total es: " + sum);
            Console.ReadLine();
        }
    }
}
