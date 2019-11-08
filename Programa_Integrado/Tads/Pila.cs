using System;
using System.Collections.Generic;
using System.Text;

namespace Programa_Integrado.Tads
{
    public class Pila
    {
        private int[] datos = new int[10];
        public int[] Datos
        {
            get { return datos; }
            set { datos = value; }
        }
        private int arriba = -1;

        public int Arriba
        {
            get { return arriba; }
            set { arriba = value; }
        }
        public void EliminarDatos()
        {
            if (Arriba == -1)
                throw new Exception("Esta pila esta vacia ");
            else
                Arriba=Arriba-1;
        }
        public void Anadir(int numero)
        {
            if (Arriba < (Datos.Length - 1))
            {
                Arriba=Arriba+1;
                Datos[Arriba] = numero;
            }
        }
    }
}