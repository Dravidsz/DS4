using System.Runtime.InteropServices;

class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    private static void Main(string[] args)
    {
        List<Estudiante> estudiantes = new List<Estudiante>
        {
            new Estudiante {Nombre = "Hector", Edad=12 },
            new Estudiante {Nombre = "Moises", Edad=10 },
            new Estudiante {Nombre = "Rodolfo",Edad= 11 }
        };

        foreach (Estudiante est in estudiantes)
        {
            Console.WriteLine("Nombre: " + est.Nombre +"   " + "Edad: " +est.Edad);   

        }
    }
    
}

