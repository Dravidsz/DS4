//Para ver la variables locales 
public void Sumar(int valor1, int valor2)
{
    int variableLocal = valor1 + valor2;
    Console.WriteLine(variableLocal);
}

//El error cuando llamas a la variable local desde afuera de metodo
public void Sumar(int valor1, int valor2)
{
    int variableLocal = valor1 + valor2;
    Console.WriteLine(variableLocal);
}

//Console.WriteLine(VariableLocal);

//EJEMPLO 1
using System;
namespace Laboratorio2
{
    class program
    {
        static void main(string[] args)
        {
            Client client = new Client();
            client.FisrtName = "Hector David";
            client.LastName = "Ortega Quiros";
            client.Age = 15;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());
        }
    }

    public class Client
    {
        //Declarando variable de isntacia de clase
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ushort Age { get; set; }

        public string GetFulName()
        {
            return FirstName + " " + LastName;
        }

        internal class Program
        {
            static void main(string[] args)
            {
                Client client = new Client();
                client.FisrtName = "Hector David";
                client.LastName = "Ortega Quiros";
                client.Age = 15;
                client.Id = 1;

                Console.WriteLine(client.GetFullName());
            }
        }
    }
}

public class MyClass
{
    //Declarando variable estaticas dentro de una clase
    public static void int Valor;
}

using System;

namespace Laboratori21
{
    public class Program
    {
        public static void main()
        {
            //Asignando valor a variable estatica
            MyClass.Valor = 1;
            Console.WriteLine(MyClass.Valor);

        }
    }

    public class MyClass
    {
        public int Valor;
        //Declarando valores
        int valor1 = 28;
        int Valor2 = Valor1;
        Valor2 = 30;

       Console.WriteLine(Valor1);
       Console.WriteLine(Valor2);

       Console.WriteLine(Valor1);
       Console.WriteLine(Valor2);


       //Creando una estancia
       MyClass object1 = new MyClass();
        object1.Nombre = "Maicol";
        object1.Edad28 = 28;
            
    }
}
