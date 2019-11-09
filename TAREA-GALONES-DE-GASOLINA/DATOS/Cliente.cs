using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA_GALONES_DE_GASOLINA.DATOS
{
    public class Cliente
    {
        private string apellido;

        public Cliente(string apellidos, string nombre, int ceduladeIdentidad, string direccion)
        {
            Apellidos = apellidos;
            Nombre = nombre;
            CeduladeIdentidad = ceduladeIdentidad;
            Direccion = direccion;
        }

        public string Apellidos
        {
            get { return apellido; }
            set { apellido = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int cedula;

        public int CeduladeIdentidad
        {
            get { return cedula; }
            set { cedula = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
    }
}


