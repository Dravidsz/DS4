internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> paisesCapitales = new Dictionary<string, string>
        {
            {"Panama","Panama" },
            { "Colombia", "Bogota"},
            {"Francia","Paris" }
        };
        foreach(KeyValuePair<string,string> pasCap in paisesCapitales)
        {
            Console.WriteLine("La capital es " + pasCap.Value + "  " + "y el pais es: " + pasCap.Key); 
        }
    }
}