using System;
using System.Collections.Generic;
using System.Text;

namespace BraJos.BraJoss
{
    public class nota
    {
        // este es para ingresar el nombre
        
        private String nombre;
        public String Nombre
        {
            get 
            { 
                return nombre; 
            }
            set 
            { 
                nombre = value; 
            }
        }

        //Esta es para ingresar la nota de actuacion del primer parcial

        private float ac1p;
        public float Ac1p
        {
            get { return ac1p; }
            set
            {
                if (value > 10 || value < 0)
                {
                    throw new Exception("Debe ingresar una nota correcta");
                }
                ac1p = value;
            }
        }

        //Esta es para ingresar la nota de practica del primer parcial

        private float pr1p;
        public float Pr1p
        {
            get { return pr1p; }
            set
            {
                if (value > 10 || value < 0)
                {
                    throw new Exception("Debe ingresar una nota correcta");
                }
                pr1p = value;
            }
        }

        //Esta es para ingresar la nota de tarea del primer parcial

        private float ta1p;
        public float Ta1p
        {
            get { return ta1p; }
            set
            {
                if (value > 10 || value < 0)
                {
                    throw new Exception("Debe ingresar una nota correcta");
                }
                ta1p = value;
            }
        }

        //Esta es para ingresar la nota de examen final del primer parcial

        private float ef1p;
        public float Ef1p
        {
            get { return ef1p; }
            set
            {
                if (value > 10 || value < 0)
                {
                    throw new Exception("Debe ingresar una nota correcta");
                }
                ef1p = value;
            }
        }

        //Promedio del primer parcial con el porcentaje respectivo de sus notas

        private float primerparcial;
        public float Primerparcial
        {
            get
            {
                return ((Ac1p * 0.25f) + (Pr1p * 0.25f) + (Ta1p * 0.20f) + (Ef1p * 0.30f));
            }
        }

        //Esta es para ingresar la nota de actuacion del segundo parcial

        private float ac2p;
        public float Ac2p
        {
            get { return ac2p; }
            set
            {
                if (value > 10 || value < 0)
                {
                    throw new Exception("Debe ingresar una nota correcta");
                }
                ac2p = value;
            }
        }

        //Esta es para ingresar la nota de practica del segundo parcial

        private float pr2p;
        public float Pr2p
        {
            get { return pr2p; }
            set
            {
                if (value > 10 || value < 0)
                {
                    throw new Exception("Debe ingresar una nota correcta");
                }
                pr2p = value;
            }
        }

        //Esta es para ingresar la nota de tarea del segundo parcial

        private float ta2p;
        public float Ta2p
        {
            get { return ta1p; }
            set
            {
                if (value > 10 || value < 0)
                {
                    throw new Exception("Debe ingresar una nota correcta");
                }
                ta2p = value;
            }
        }

        //Esta es para ingresar la nota de examen final del segundo parcial

        private float ef2p;
        public float Ef2p
        {
            get { return ef2p; }
            set
            {
                if (value > 10 || value < 0)
                {
                    throw new Exception("Debe ingresar una nota correcta");
                }
                ef2p = value;
            }
        }

        //Este es el promedio del segundo parcial

        private float segundoparcial;
        public float Segundoparcial
        {
            get
            {
                return ((Ac2p * 0.25f) + (Pr2p * 0.25f) + (Ta2p * 0.20f) + (Ef2p * 0.30f));
            }
        }

        //Esta es la suma de los dos parciales 

        private float suma;
        public float Suma
        {
            get
            {
                return Primerparcial + Segundoparcial;
            }
        }

        //Esto es para ingresar la nota de recuperacion si es que hay 

        private float recuperacion;
        public float Recuperacion
        {
            get { return recuperacion; }
            set
            {
                if (value > 10 || value < 0)
                {
                    throw new Exception("Debe ingresar una nota correcta");
                }
                recuperacion = value;
            }
        }

        //Esto es para calcular la nota final inluyendo la nota de recuperacion 

        private float suma2;
        public float Suma2
        {
            get
            {
                if (Suma >= 14)
                {
                    return Suma;
                }
                else
                {
                    return (Suma / 2) + Recuperacion;
                }
            }
        }

        //Esta es la nota final 

        private float final;
        public float Final
        {
            get
            {
                if (Suma2 == Suma)
                {
                    return Suma/2;
                }
                else 
                { 
                return Suma2 / 2;
                }
            }
        }

        //Esto es para que se imprima el estado del estudiante de acuerdo a su nota 

        private string estado;
        public string Estado
        {
            get
            {
                if (Suma >= 14 || Suma2 > 14)
                {
                    return "aprobado";
                }
                else
                {
                    if (Suma2 > 8 || Suma > 8)
                    {
                        if (Suma2 < 14 || Suma < 14)
                        {
                            return "recuperacion";
                        }
                        else
                        {
                            return "Aprobado";
                        }
                    }
                    else
                    {
                        return "reprobado";
                    }

                }
            }

        }
    }
}
