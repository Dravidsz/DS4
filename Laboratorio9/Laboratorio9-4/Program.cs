using Laboratorio9_4;

internal class Program
{
    private static void Main(string[] args)
    {
        Aleatorios aleatorios = new Aleatorios();

       
        int min = aleatorios.GenerarNumeroEntre(1, 10);
        int max = aleatorios.GenerarNumeroEntre(11, 20);

        Console.WriteLine($"Rango generado: {min} a {max}");

        
        int[] arregloNoRepetido = aleatorios.GenerarArregloDeNumeros(min, max, 5);

        Console.WriteLine("Arreglo de números aleatorios no repetidos: " + string.Join(", ", arregloNoRepetido));
    }
}