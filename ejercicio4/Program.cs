using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string cadena;
             // ingresar cadena y mostrara la primera palabra
             Console.Write("Ingrese una oracion: ");
             cadena = Convert.ToString(Console.ReadLine());
             string [] palabra = cadena.Split(" ");
             Console.Write("\nUna palabra de la orecion es:");
             Console.Write(palabra[0]);

             // mostramos la longuitud de la cadena :D
             Console.Write("\nLa longuitud de la cadena de {0} caracteres", cadena.Length);
             Console.Write("\nIngrese una oracion: ");
             // ingresamos una segunda oracion y lo concatenamos con la primera orecion
             string cadena2 = Convert.ToString(Console.ReadLine());
             string concatenar = cadena +" "+ cadena2;
             Console.Write("concatenar 2 oraciones: ");
             Console.Write(concatenar);
             Console.Write("\n");

             // hacemos una sub cadena que quita 2 palabras de la variable concatenar y los muestra como una oracion
             string[] array = concatenar.Split(" ");
             palabra[0] = array[0] +" "+ array[2];
             Console.Write("sub cadena: ");
             Console.Write(palabra[0]);
             Console.Write("\n");
             Console.ReadKey();*/

            //Usando la calculadora anterior mente creada:
            //RECORRER UNA CADENA DE TEXTO CON FOREACH
            /*
            string cade;
            Console.Write("Ingrese una oracion: ");
            cade = Convert.ToString(Console.ReadLine());
            int cont = 0;
            foreach (int element in cade)
            {
                Console.WriteLine($" {cade[cont]}");
                cont++;
            }
            //Buscar una palabra:
            string buscar;
            Console.Write("Busque una palabra: ");
            buscar = Convert.ToString(Console.ReadLine());
            string[] palabra = cade.Split(" ");
            cont = 0;
            int bus=0;
            foreach(string element in palabra)
            {
                if (palabra[cont] == buscar)
                {
                    Console.Write("\n");
                    Console.Write("La palabra buscada es: ");
                    Console.Write(palabra[cont]);
                    bus = 1;
                }
                cont++;
            }
            if (bus==0)
            {
                Console.Write("\nLa palabra no existe en la oracion");
            }
            //CONVERTIR TODO A MAYUSCULA
            Console.Write("\n");
            Console.Write("Cadena en mayuscula: ");
            Console.WriteLine(cade.ToUpper());
            Console.Write("Cadena en minuscula es: ");
            Console.WriteLine(cade.ToLower());
            Console.ReadKey();
            */
            // COMPARAR 2 CADENAS;
            Console.Write("Ingrese una oracion: ");
            string oracion1 = Convert.ToString(Console.ReadLine());
            Console.Write("\nIngrese la segunda oracion: ");
            string oracion2 = Convert.ToString(Console.ReadLine());
            if (oracion1 == oracion2)
            {
                Console.Write("\nLas oraciones son iguales");
            }
            else
            {
                Console.Write("\nLas oraciones no son iguales");
            }


        }
    }
}
