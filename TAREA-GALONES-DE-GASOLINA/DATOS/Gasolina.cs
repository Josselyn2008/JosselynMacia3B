using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA_GALONES_DE_GASOLINA.DATOS
{
    public class Gasolina
    {

        private Cliente cliente;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        private string tipo;

        public string TipoGasolina
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }
        private int cantidad;

        public int CantidadGalones
        {
            get
            {
                return cantidad;
            }
            set
            {
                cantidad = value;
            }
        }
        public Gasolina(Cliente cliente, string tipoGasolina, int cantidadGalones)
        {
            Cliente = cliente;
            TipoGasolina = tipoGasolina;
            CantidadGalones = cantidadGalones;
        }

        private float precio;

        public float PreciodeVenta
        {
            get
            {
                if(TipoGasolina=="EXTRA")
                {
                    precio = 1.5f;
                    return precio;
                }
                else
                {
                    if(TipoGasolina=="SUPER")
                    precio = 2f;
                    return precio;
                }
            }
        }
        
        public float Subtotal()
        {
            return PreciodeVenta * CantidadGalones;
        }

        public float Iva()
        {
            return Subtotal() * 0.12f;
        }

        public float TotalaPagar()
        {
            return Iva() + Subtotal();
        }
    }
}
