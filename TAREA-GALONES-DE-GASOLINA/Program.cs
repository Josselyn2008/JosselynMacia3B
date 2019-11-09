using System;
using TAREA_GALONES_DE_GASOLINA.DATOS;

namespace TAREA_GALONES_DE_GASOLINA
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente datocliente = new Cliente("Macias Pico", "Josselyn Stefany", 1350696397, " Altamira ");
            Gasolina datogasolina = new Gasolina(datocliente, " Extra ", 5);

            Console.WriteLine("----------       FACTURA GASOLINA         ----------");
            Console.WriteLine("----------    INFORMACION DEL CLIENTE     ----------");
            Console.Write("APELLIDOS: ");
            datocliente.Apellidos = Console.ReadLine();
            Console.Write("NOMBRES: ");
            datocliente.Nombre = Console.ReadLine();
            Console.Write("# CEDULA: ");
            datocliente.CeduladeIdentidad = int.Parse(Console.ReadLine());
            Console.Write("DIRECCION: ");
            datocliente.Direccion = Console.ReadLine();

            Console.WriteLine("----------    INFORMACION DE LA VENTA     ----------");
            Console.Write("TIPO DE GASOLINA INGRESE SEGUN DESEE:\nEXTRA \nSUPER\n");
            datogasolina.TipoGasolina = Console.ReadLine();
            Console.Write("CANTIDAD DE GALONES: ");
            datogasolina.CantidadGalones = int.Parse(Console.ReadLine());
            Console.WriteLine("PRECIO POR GALON: " + datogasolina.PreciodeVenta);

            Console.WriteLine("--------------------SUBTOTAL: " +datogasolina.Subtotal());
            Console.WriteLine("--------------------     IVA: " +datogasolina.Iva());
            Console.WriteLine("--------------------   TOTAL: " + datogasolina.TotalaPagar());
        }
    }
}
