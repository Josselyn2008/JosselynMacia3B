using System;

namespace Menu
{
  //  10. Crear un programa que muestre un menú como este:
  //  1) Salir
  //  2) Sumatorio
  //  3) Factorial
  //  Tras mostrar el menú, el programa debe leer un número del 1 al tres si se elige 1, el programa acaba.Si se
  //  elige 2 se calcula el sumatorio del número, si se elige 3 se calcula la factorial(en ambos casos el programa
  //  pedirá escribir el número sobre el que se calcula el sumatorio o la factorial). Tras calcular el sumatorio o la
  //  factorial e indicar el resultado, el programa volverá a mostrar el menú y así sucesivamente.

    class Program
    {
        static void Main(string[] args)
        {
            
            int opc = 0;
            do // Este do es para realizar todo el proceso mientras el usuario no ingrese la opcion uno que sea la de salir 
            {
                //Opciones 

                Console.WriteLine("Seleccione una opción: ");
                Console.WriteLine(" 1º) Salir ");
                Console.WriteLine(" 2º) Sumatorio ");
                Console.WriteLine(" 3º) Factorial ");
                opc = Convert.ToInt16(Console.ReadLine());

                //Switch para escoger las opciones de acuerdo a lo que el usuario quiera realizar

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Ud ha escogido la opcion de Salir .."); 
                        Console.WriteLine("  ");
                        Salir(); // En este caso se ah escogido la opcion de salir por lo tanto esta llamando al metodo que realizara lo correspondido
                        Console.WriteLine("  ");
                        break;
                    case 2:
                        Console.WriteLine("Ud ha escogido la opcion de Sumatorio..");
                        Console.WriteLine("  ");
                        Sumatorio();// En este caso se ah escogido la opcion de sumatoria por lo tanto esta llamando al metodo que realizara lo correspondido
                        Console.WriteLine("  ");
                        break;
                    case 3:
                        Console.WriteLine("Ud ha escogido la opcion de Factorial..");
                        Console.WriteLine("  ");
                        Factorial();// En este caso se ah escogido la opcion de factorial por lo tanto esta llamando al metodo que realizara lo correspondido
                        Console.WriteLine("  ");
                        break;
                    default: // esta opcion es por si el usuario ingresa algun dato que no sea los numeros de las opciones 
                        Console.WriteLine(" No se ha seleccionado ninguna opcion ");
                        Console.WriteLine("  ");
                        break;
                }
            } while (opc != 1);
            Console.ReadLine();
        }
        //Metodo de salir 
        static void Salir()
        {
            Console.WriteLine(" Ha sido un exito servirle");
        }
        //metodo de sumatorio
        static void Sumatorio()
        {
            int resp = 0;
            do // este es para que se realice todo esto mientras el usuario quiera seguir sumando
            {
                int Suma = 0;
                Console.WriteLine(" Ingrese el numero que desea sumar ");
                int numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine(" Ingrese el segundo numero que desea sumar ");
                int numero2 = int.Parse(Console.ReadLine());
                Suma = numero1 + numero2;
                Console.WriteLine(" La suma es: " + Suma);
                Console.WriteLine("  ");
                Console.WriteLine(" Desea sumar otro numero si es asi escriba 1 caso contrario digite cero ");
                resp = int.Parse(Console.ReadLine());
            } while (resp == 1);
        }
        //metodo de factorial

        static void Factorial()
        {
            int resp = 0;
            do // este es para que se realice todo esto mientras el usuario quiera seguir sacando el factorial
            {
                int ingresar, factorial = 0;
                Console.WriteLine(" Ingrese el numero del que desea sacar factorial ");
                ingresar = int.Parse(Console.ReadLine());
                factorial = ingresar;
                for (int l = ingresar - 1; l >= 1; l--)
                {
                    factorial = factorial * l;
                }
                Console.WriteLine("El factorial es: " + factorial);
                Console.WriteLine("  ");
                Console.WriteLine(" Desea factorial otro numero si es asi escriba 1 caso contrario digite cero ");
                resp = int.Parse(Console.ReadLine());
            } while (resp == 1);
        }
       
    }

}
