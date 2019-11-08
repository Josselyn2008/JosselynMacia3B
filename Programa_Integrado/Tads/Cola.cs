using System;
using System.Collections.Generic;
using System.Text;

namespace Programa_Integrado.Tads
{
    class Cola
    {
        private int[] cantidad = new int[10];
        public int[] Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private int extremo = -1;

        public int Extremo
        {
            get { return extremo; }
            set { extremo = value; }
        }
        private int principal = -1;

        public int Principal
        {
            get { return principal; }
            set { principal = value; }
        }

        public void EliminarDato()
        {
            if (Extremo == -1 && Principal == -1)
                throw new Exception("Esta cola esta vacia");
            else
            {
                if (Principal == Extremo)
                {
                    Principal = -1;
                    Extremo = -1;
                }
                else
                {
                    Principal=Principal+1;
                }
            }
        }
        public void Añadirdatos(int numero)
        {
            if (Extremo < (Cantidad.Length - 1))
            {
                Extremo=Extremo+1;
                Cantidad[Extremo] = numero;
            }
        }

    }
}