Imports System

Module Program
    Sub Main()
        'Declaraciones de variables
        Dim M As Double
        Dim G As Double
        Dim p As Double

        'Ingresar valores para las variables
        G = 9.8
        Console.Write("Ingrese la masa del objeto:")
        M = Console.ReadLine

        'Realizar Procesos
        p = M * G


        'Mostrar resultados
        Console.WriteLine("Peso del obejto: {0}", p)
        Console.ReadKey()
    End Sub
End Module
