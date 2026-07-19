using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== CALCULADORA DE IMC ===");
        Console.Write("Ingresa tu peso en kg (ej. 70.5): ");
        double peso = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Ingresa tu altura en metros (ej. 1.75): ");
        double altura = Convert.ToDouble(Console.ReadLine());
        
        double imc = peso / (altura * altura);
        
        Console.WriteLine($"\nTu Índice de Masa Corporal (IMC) es: {Math.Round(imc, 2)}");
    }
}
