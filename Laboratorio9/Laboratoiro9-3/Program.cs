internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Clasificación de triangulos");
        Console.WriteLine("Clasificacione: Escaleno,Isósceles,Equilátero");
        Console.WriteLine("Ingrese los tres lados para determinar que tipo de trinagulo es");

        double ladoA, ladoB, ladoC;
        Console.WriteLine("Ingrese el lado A");
        ladoA = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el lado B");
        ladoB = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el lado C");
        ladoC = double.Parse(Console.ReadLine());
        string tipoTriangulo = DeterminarTipoTriangulo(ladoA, ladoB, ladoC);
        Console.WriteLine(tipoTriangulo);

        static string DeterminarTipoTriangulo(double a, double b, double c)
        {

            if (a + b > c && a + c > b && b + c > a)
            {

                if (a == b && b == c)
                {
                    return "El triángulo es equilátero.";
                }
                else if (a == b || b == c || a == c)
                {
                    return "El triángulo es isósceles.";
                }
                else
                {
                    return "El triángulo es escaleno.";
                }
            }
            else
            {
                return "Los lados ingresados no forman un triángulo.";
            }
        }
    }
}