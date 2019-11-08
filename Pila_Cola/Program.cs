using System;
using Pila_Cola.TADS;

namespace Pila_Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            PILA pila = new PILA();
            COLA cola = new COLA();

            cola.Añadirdatos(3);
            cola.Añadirdatos(10);
            cola.Añadirdatos(20);
            cola.Añadirdatos(21);
            cola.EliminarDato();
            cola.Añadirdatos(46);
            Console.WriteLine("\nLOS DIGITOS DE COLA SON: ");
            for (int j = cola.Extremo; j > cola.Principal; j--)
            {
                Console.WriteLine(cola.Cantidad[j]);
            }
            pila.Anadir(15);
            pila.Anadir(20);
            pila.Anadir(33);
            pila.Anadir(42);
            pila.EliminarDatos();
            pila.Anadir(1);
            Console.WriteLine("\nLOS DIGITOS DE PILA SON; ");

            for (int j = 4; j > -1; j--)
            {
                Console.WriteLine(pila.Datos[j]);
            }

            Console.ReadLine();
        }
    }
}
