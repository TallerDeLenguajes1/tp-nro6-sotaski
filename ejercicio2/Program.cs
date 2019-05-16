using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            char operacion;
            char resp='1';
            int num1, num2;
            while (resp=='1') { 
               Console.Write("elija una operacion (+, -, * o /): ");
                operacion = char.Parse(Console.ReadLine());
                Console.Write("Escriba 2 numeros \n");
                Console.Write("numero 1: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("numero 2: ");
                num2 = int.Parse(Console.ReadLine());
                switch (operacion)
                {
                    case '+': Console.Write("La suma es: {0}", (num1 + num2)); break;
                    case '-': Console.Write("La resta es: {0}", (num1 - num2)); break;
                    case '*': Console.Write("La multiplicacion es: {0}", (num1 * num2)); break;
                    case '/': Console.Write("La divicion es: {0,0} \n", ((float)num1 / num2)); break;
                }
                Console.Write("\nDesea realizar otra operacion? 1 si o 0 si no:");
                resp = char.Parse(Console.ReadLine());
            }
        Console.ReadKey();
        }
    }
}
