﻿internal class Program
{
    private static void Main(string[] args)
    
    {
        Console.WriteLine("Digite el radio del ciculo");
        double radio = double.Parse(Console.ReadLine());

        double area = Math.Pow(radio, 2) * Math.PI;
        Console.WriteLine($"El area del circulo es: {area}");
    }
}