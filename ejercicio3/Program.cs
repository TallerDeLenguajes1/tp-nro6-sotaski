using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float num;
            float num1, num2;
            Console.Write("Ingrese un numero: ");
            num = float.Parse(Console.ReadLine());
            Console.Write("\nEl valor absoluto es: {0}", Math.Abs(num));
            Console.Write("\nEl cuadrado es: {0}", Math.Pow(num,2));
            Console.Write("\nLa raiz cuadrada es: {0}", Math.Sqrt(num));
            Console.Write("\nEl seno es: {0}", Math.Sin(num));
            Console.Write("\nEl coseno es: {0}", Math.Cos(num));
            Console.Write("\nLa parte entera del numero es: {0,0}", Math.Truncate(num));

            Console.Write("\nIngrese dos numeros: ");
            Console.Write("\nNumero1: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("\nNumero2: ");
            num2 = float.Parse(Console.ReadLine());
            Console.Write("\nEl numero mayor entre los dos es: {0}", Math.Max(num1, num2));
            Console.Write("\nEl numero menor entre los dos es: {0}", Math.Min(num1, num2));


            Console.ReadKey();
        }
    }
}
