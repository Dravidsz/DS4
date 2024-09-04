using System;

namespace Laboratorio3
{
    internal class Program
{
    
    private static void Main(string[] args)
    {
        int primerNumero, segundoNumero, suma;

        Console.Write("Introcduce el primer numero");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce el segundo numero");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        suma = primerNumero + segundoNumero;

        Console.WriteLine("Ls suma  de {0} y {1} es {2}", primerNumero, segundoNumero, suma);
    }
    }
}