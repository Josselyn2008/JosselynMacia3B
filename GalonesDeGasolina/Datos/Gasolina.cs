using System;
using System.Collections.Generic;
using System.Text;

namespace GalonesDeGasolina.Datos
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

        private float precio;

        public Gasolina(Cliente cliente, string tipoGasolina, int cantidadGalones, float preciodeVenta) : this(cliente, tipoGasolina, cantidadGalones)
        {
            PreciodeVenta = preciodeVenta;
        }

        public Gasolina(Cliente cliente, string tipoGasolina, int cantidadGalones)
        {
            Cliente = cliente;
            TipoGasolina = tipoGasolina;
            CantidadGalones = cantidadGalones;
        }

        public float PreciodeVenta 
        {
            get 
            { 
                if(TipoGasolina== " Extra ")
                {
                    precio = 1.5f;
                }
                else
                {
                    if(TipoGasolina== " Super ")
                    {
                        precio = 2f;
                    }
                }
                return precio; 
            }
            set
            {
                precio = value;
            }
           
        }

        public float Subtotal()
        {
            return PreciodeVenta * CantidadGalones;
        }

        public float Iva()
        {
            return Subtotal()*0.12f;
        }

        public float TotalaPagar()
        {
            return Iva() + Subtotal();
        }
    }
}
