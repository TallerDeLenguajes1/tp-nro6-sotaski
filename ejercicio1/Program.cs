using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int contador, aux;

            Console.Write("Escriba cualquier numero: ");
            numero = int.Parse(Console.ReadLine());
            contador = 0;
            aux = numero;
            while (numero > 0)
            {
                numero = numero / 10;
                contador++;
            }
            int guardar;
            for (int i = 0; i < contador; i++)
            {
                guardar = aux % 10;
                aux = aux / 10;
                numero = (numero * 10) + guardar;
            }

            Console.Write("El numero de cifras es: ");
            Console.Write(numero);
            Console.ReadKey();
        }
    }
}
