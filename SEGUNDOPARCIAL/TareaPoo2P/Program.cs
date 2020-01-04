using System;
using TareaPoo2P.CLASES;


namespace TareaPoo2P
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*En esta parte se va a crear un objeto de perspectiva de venta al  cual
             * le vamos a ingresar las propiedades
            */
            PERSVENTA venta = new PERSVENTA(); //Se crea un objeto de la clase Persventa
            venta.setNombre("Josselyn ");
            venta.setTelefono(1350696397);
            venta.setPresupuesto(60.000);

            /*En esta parte vamos a guardar el estado por eso 
             * llamamos al metodo de Memoria
             */

            MEMORIA_PERSPECTIVA guardar = new MEMORIA_PERSPECTIVA(); //Se crea un objeto de la clase Memoria
            Console.WriteLine(" ");
            guardar.setMemento(venta.SalvaMemento()); //Se llama al metodo para guardar los datos

            //Despues se vuelve a cambiar el originador con nuevos datos 
            venta.setNombre(" Elvis ");
            venta.setTelefono(1316858057);
            venta.setPresupuesto(30.000);

            //Luego se restaura el estado guardado
            Console.WriteLine(" ");
            venta.RestaurarMemento(guardar.getMemento()); //se llama al metodo para restaurar los datos 

            Console.ReadLine();
        }
    }
}
