using System;

class Program
{
    static void chekAge(int age)
    {
        if (age < 18)
        {
            throw new ArithmeticException("Acceso negado  no cumple con la edad suficiente");
        }
        else
        {
            Console.WriteLine("Acceso corecto");

        }

       
    }
    static void Main(string[] args)
    {
        chekAge(15);
    }
}