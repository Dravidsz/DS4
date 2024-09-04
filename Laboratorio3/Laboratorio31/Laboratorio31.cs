using System;

namespace laboratorio31
{
    internal class Laboratorio31
    {
        public static void Main(string[] args)
        {
            int a, b, calcular;

            Console.Write("Ingrese el primer valor  ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo valor  ");
            b = Convert.ToInt32(Console.ReadLine());

            calcular = (a + b) * (a - b);

            Console.WriteLine("El resultado de la operacion (a+b) * (a-b) es: " + calcular);

        }
    }
}