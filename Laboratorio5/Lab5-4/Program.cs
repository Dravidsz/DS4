internal class Program
{
    private static void Main(string[] args)
    {
        List<int> calificaciones = new List<int> { 86,76,89,90,56};
        int suma = 0;
        foreach (int i in calificaciones)
        {
            suma += i;
        }

        double promedio = suma / (double)calificaciones.Count;
        Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
    }
}