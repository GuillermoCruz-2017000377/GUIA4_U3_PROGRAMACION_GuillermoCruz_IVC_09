using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingresa el precio del producto: ");
        int precio = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Ingresa la denominación del billete con que paga: ");
        int pago = Convert.ToInt32(Console.ReadLine());
        
        int cambio = pago - precio;
        
        if (cambio < 0) {
            Console.WriteLine("¡Falta dinero!");
        } else {
            Console.WriteLine($"\nEl cambio total es: {cambio}");
            
            int b200 = cambio / 200; cambio %= 200;
            int b100 = cambio / 100; cambio %= 100;
            int b50 = cambio / 50;   cambio %= 50;
            int b20 = cambio / 20;   cambio %= 20;
            
            Console.WriteLine($"Billetes de 200: {b200}");
            Console.WriteLine($"Billetes de 100: {b100}");
            Console.WriteLine($"Billetes de 50: {b50}");
            Console.WriteLine($"Billetes de 20: {b20}");
            Console.WriteLine($"Monedas restantes: {cambio}");
        }
    }
}
