using System;
using System.Collections.Generic;
using System.Text;

namespace TareaPoo2P.CLASES
{
    public class Memento
    {
        //Estas son las mismas propiedades del objeto a guardar 
        private string nombre;
        private int telefono;
        private double presupuesto;
        //Este es el constructor de la clase 
        public Memento(string nombre, int telefono, double presupuesto)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.presupuesto = presupuesto;
        }
        //Se crean los set de cada atributo 
        public void setNombre (string nombre)
        {
            this.nombre = nombre;
        }
        public void setTelefono(int telefono)
        {
            this.telefono = telefono;
        }
        public void setPresupuesto(double presupuesto)
        {
            this.presupuesto= presupuesto;
        }
        //Se crean los get de cada atributo 
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

    }
}
