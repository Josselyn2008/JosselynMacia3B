using System;
using System.Collections.Generic;
using System.Text;

namespace Programa_Integrado.Tads
{
    public class Pila
    {
        private int[] dato = new int[10];
        public int[] Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        private int ultimo = -1;

        public int Ultimo
        {
            get { return ultimo; }
            set { ultimo = value; }
        }
        private int primero = -1;

        internal void pila()
        {
            throw new NotImplementedException();
        }

        public int Primero
        {
            get { return primero; }
            set { primero = value; }
        }

        public void EliminarDato()
        {
            if (Ultimo == -1 && Primero == -1)
                throw new Exception("No hay datos en la Pila");
            else
            {
                if (Primero == Ultimo)
                {
                    Primero = -1;
                    Ultimo = -1;
                }
                else
                {
                    Primero++;
                }
            }
        }
        public void Anadirdato(int numero)
        {
            if (Ultimo < (Dato.Length - 1))
            {
                Ultimo++;
                Dato[Ultimo] = numero;
            }
        }

    }
}