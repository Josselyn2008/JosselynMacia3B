using System;
using System.Collections.Generic;
using System.Text;

namespace TareaPoo2P.CLASES
{
    public class PERSVENTA //Esta es la clase originator 
    {
        private string nombre;
        private int telefono;
        private double presupuesto;

        //Estas son las propiedades del estado con metodos set 
        public void setNombre(string nombre)
        {
            Console.WriteLine("Nombre: " + nombre);
            this.nombre = nombre;
        }

        public void setTelefono(int telefono)
        {
            Console.WriteLine("Telefono: " + telefono);
            this.telefono = telefono;

        }
        public void setPresupuesto(double presupuesto)
        {
            Console.WriteLine("Presupuesto " + presupuesto);
            this.presupuesto = presupuesto;
        }
        //Estas son las propiedades con metodos get
        public string getNombre()
        {
            return nombre;
        }
        public int getTelefono()
        {
            return telefono;
        }
        public double getPresupuesto()
        {
            return presupuesto;
        }
         
        //Este metodo guarda los datos 
        public Memento SalvaMemento()
        {

            Console.WriteLine("Salvando estado...." );//Esta parte imprime que su estado se esta guardando  
            Console.WriteLine(" ");
            return new Memento(nombre, telefono, presupuesto); //Esta parte es para crear el memento 
            Console.WriteLine(" ");

        }

        //Esta parte es para que se restaure los datos que guardamos 
        public void RestaurarMemento(Memento memento)
        {
            Console.WriteLine("Restaurando estado....");//Esta parte imprime que su estado se esta Restaurando 
            Console.WriteLine(" ");
            this.setNombre(memento.getNombre());
            this.setTelefono(memento.getTelefono());
            this.setPresupuesto(memento.getPresupuesto());
        }


    }
}
