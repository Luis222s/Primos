using System;

namespace Primo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número:");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 1)
            {
                Console.WriteLine("El número 1 no es primo.");
                return;
            }

            int contador = 2;
            bool primo = true;

            while ((primo) && (contador != numero))
            {
                if (numero % contador == 0)
                    primo = false;
                contador++;
            }

            if (primo)
                Console.WriteLine("El número es primo.");
            else
                Console.WriteLine("El número no es primo.");
        }
    }
}
