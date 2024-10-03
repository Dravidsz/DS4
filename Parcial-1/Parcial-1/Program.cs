class Program
{
    static void Main()
    {
        Console.WriteLine("Parcial 1 Desarrollo Software IV");
        Console.WriteLine("Ingresa un número impar para la matriz N: ");
        int N;


        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out N) && N % 2 != 0)
            {
                break;
            }
            Console.WriteLine("N debe ser impar");
        }

        int[,] matriz = new int[N, N];
        Random rand = new Random();
        int suma = 0; 

        
        for (int i = 0; i < N; i++)
        {
           
            matriz[i, 1] = rand.Next(101, 201);
            matriz[i, N - 2] = rand.Next(101, 201);

           
            suma += matriz[i, 1];
            suma += matriz[i, N - 2];
        }

       
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
                Console.Write(matriz[i, j] + "\t");
            Console.WriteLine();
        }

       
        Console.WriteLine("La suma de la segunda y penultima fila " + suma);
    }
}