using System;
using Programa_Integrado.Tads;

namespace Programa_Integrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila pila = new Pila();
            Cola cola = new Cola();
            int opcion1 = 0;
            int opcion2 = 0;
            int opcion3 = 0;

            static int MenuPrincipal()
            {
                Console.Clear();
                int opcion1;
                Console.WriteLine("                           MENU                              ");
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine(" 1.  Ejercicio Pila");
                Console.WriteLine(" 2.  Ejercicio Cola");
                Console.WriteLine(" 3.  Salir");
                opcion1 = int.Parse(Console.ReadLine());
                return opcion1;
            }
            static int MenuPila()
            {
                Console.Clear();
                int opcion2;
                Console.WriteLine("                           MENU                              ");
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine(" 1.  Añadir dato");
                Console.WriteLine(" 2.  Eliminar dato");
                Console.WriteLine(" 3.  Salir");
                opcion2 = int.Parse(Console.ReadLine());
                return opcion2;
            }
            static int MenuCola()
            {
                Console.Clear();
                int opcion3;
                Console.WriteLine("                           MENU                              ");
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine(" 1.  Añadir dato");
                Console.WriteLine(" 2.  Eliminar dato");
                Console.WriteLine(" 3.  Salir");
                opcion3 = int.Parse(Console.ReadLine());
                return opcion3;
            }

            Console.ReadLine();
            switch (opcion1)
            {
                case '1' :
                    MenuPila();
                    break;
                case '2':
                    MenuCola();
                    break;
                case '3':
                    Console.WriteLine("Ha sido un exito servirle");
                    break;

            }
            switch (opcion2)
            {
                case '1':
                    MenuPila();
                    break;
                case '2':
                    MenuCola();
                    break;
                case '3':
                    Console.WriteLine("Ha sido un exito servirle");
                    break;


            }
            switch (opcion3)
            {
                case '1':
                    MenuPila();
                    break;
                case '2':
                    MenuCola();
                    break;
                case '3':
                    Console.WriteLine("Ha sido un exito servirle");
                    break;


            }


        }
       

    }


}

