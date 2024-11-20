using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Laboratorio9_4;
class Aleatorios
{
    private Random random;

    public Aleatorios()
    {
        random = new Random();
    }

    public int GenerarNumeroEntre(int min, int max)
    {
        return random.Next(min, max + 1); 
    }

    
    public int[] GenerarArregloDeNumeros(int min, int max, int cantidad)
    {
        HashSet<int> numeros = new HashSet<int>();

        while (numeros.Count < cantidad)
        {
            int numeroAleatorio = random.Next(min, max + 1);
            numeros.Add(numeroAleatorio); 
        }

        return new List<int>(numeros).ToArray(); 
    }
}
