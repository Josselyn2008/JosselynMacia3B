using System;

namespace NumeroMayor
{
  
    class Program {
        static void Main(string[] args){
 // 1. Programa que lea una serie de números por teclado e indique cuál es el mayor
            int C = 0;
            Console.WriteLine("Escriba la cantidad total de numeros a ingresar ");
            int A = int.Parse(Console.ReadLine());
            for (int i = 0; i < A; i++) {
                Console.WriteLine("Ingrese numero");
                int B = int.Parse(Console.ReadLine());
                if (i == 0){
                    C = B;
                }
                else {
                    if (i != 0){
                        if (B > C){
                            C = B;
                        }
                    }
                } 
            }
            Console.WriteLine("El numero mayor es " + C);
            Console.ReadLine();
        }
    }
}