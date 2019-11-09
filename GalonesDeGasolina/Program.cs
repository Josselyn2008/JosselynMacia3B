using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalonesDeGasolina.Datos;

namespace GalonesDeGasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente datocliente = new Cliente("Macias Pico", "Josselyn Stefany", 1350696397, " Altamira ");
            Gasolina datogasolina = new Gasolina(datocliente , " Extra ", 5, 1.50F );

            Console.WriteLine("----------    INFORMACION DEL CLIENTE     ----------");
            Console.Write("APELLIDOS: ");
            datocliente.Apellidos = Console.ReadLine();
            Console.Write("NOMBRES: ");
            datocliente.Nombre = Console.ReadLine();
            Console.Write("# CEDULA: ");
            datocliente.CeduladeIdentidad = int.Parse(Console.ReadLine());
            Console.Write("DIRECCION: ");
            datocliente.Direccion = Console.ReadLine();

            Console.WriteLine("TIPO DE GASOLINA: ");
            datogasolina.TipoGasolina = Console.ReadLine();
            Console.Write(" \t CANTIDAD DE GALONES: ");
            datogasolina.CantidadGalones = int.Parse(Console.ReadLine());
            Console.Write(" \t PRECIO DE GALONES: ");
            datogasolina.PreciodeVenta = int.Parse(Console.ReadLine());


            Console.WriteLine("*******************INFORMACION DEL CLIENTE******************");
            Console.WriteLine("iNGRESE");

        }
    }
}