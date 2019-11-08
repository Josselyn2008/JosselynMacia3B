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

            cola.Añadirdatos(3);
            cola.Añadirdatos(10);
            cola.Añadirdatos(20);
            cola.Añadirdatos(21);
            cola.EliminarDato();
            cola.Añadirdatos(46);
            Console.WriteLine("\ncola");
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
            
            for (int j = 4; j > -1; j--)
            {
                Console.WriteLine(pila.Datos[j]);
            }
            
            Console.ReadLine();
        }
    }
}