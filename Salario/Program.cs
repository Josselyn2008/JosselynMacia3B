using System;

//Crear un programa para calcular el salario semanal de unos empleados a los que se les paga 15 dólares
//por hora si éstas no superan las 35 horas.Cada hora por encima de 35 se considerará extra y se paga a 22 dólares.
//El programa pide las horas del trabajador y devuelve el salario que se le debe pagar.
//Además, el programa debe preguntar si deseamos calcular otro salario, si es así el programa se repite.

namespace Salario
{
    class Program {
        static void Main(string[] args) 
        {   //variables
            int horas, horasextra, Resp;
            double salario, salarioextra, salariototal; //Estas se declaran con double para que pueda ingresar decimales 
            do //Todo esto se volvera a realizar mientras la respuesta sea 1, que significa que quiere  seguir ingresando salarios para calcular 
            {
                Console.WriteLine("Ingrese las horas trabajadas del personal");
                horas = int.Parse(Console.ReadLine());
                //Esto se realizara solo si el salio es menor o igual a 35
                if (horas <= 35)
                {
                    salario = horas * 15;
                } //esto se realizara solo si son las horas mayores a 35 por que alli hay  horas extras 
                else
                {
                    horasextra = horas - 35;
                    salarioextra = horasextra * 22;
                    salariototal = 35 * 15;
                    salario = salarioextra + salariototal;
                }
                Console.WriteLine(" El salario total para su personal es: " + salario);

                Console.WriteLine(" ¿ Desea calcular el salario de otra persona ? Responda 1 si desea o 0 si no desea ");
                Resp = int.Parse(Console.ReadLine());

            } while (Resp == 1);
            Console.WriteLine(" Su(s) salario(s) se ha(n) calculado exitosamente ");
            Console.ReadLine();
        }
    }
}
