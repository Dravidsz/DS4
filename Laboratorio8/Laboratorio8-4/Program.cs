using Laboratorio8_4;

internal class Program
{
    private static void Main(string[] args)
    {
        Empleado empleado = new Empleado();
        empleado.Nombre = "Jonhn Doe";
        Console.WriteLine($"Nombre Del Empleado: {empleado.Nombre}");


        CuentaBancaria cuentaBancaria = new CuentaBancaria();
        cuentaBancaria.Saldo = 100;
        Console.WriteLine($"El saldo del empleado: {cuentaBancaria.Saldo}");

        Cobertura c = new Cobertura(5);
        Console.WriteLine($"Con una cobertura de: {c.Radio} ");
    }
}