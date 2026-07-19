using System;

internal class Program
{
    private static void Main(string[] args)
    {
        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            Console.Write("Ingresa la cantidad en tu moneda local (Quetzales/Pesos): ");
            double local = Convert.ToDouble(Console.ReadLine());
            
            
            Console.WriteLine($"\n Equivalentes aprox:");
            Console.WriteLine($"1. Dólar (USD): {Math.Round(local / 7.8, 2)}");
            Console.WriteLine($"2. Euro (EUR): {Math.Round(local / 8.5, 2)}");
            Console.WriteLine($"3. Libra (GBP): {Math.Round(local / 9.9, 2)}");
            Console.WriteLine($"4. Yen (JPY): {Math.Round(local * 19.3, 2)}");
            Console.WriteLine($"5. Dólar Canadiense (CAD): {Math.Round(local / 5.7, 2)}");
            
            Console.Write("\n¿Deseas convertir otra cantidad? (s/n): ");
            if (Console.ReadLine().ToLower() != "s") continuar = false;
        }
    }
}
