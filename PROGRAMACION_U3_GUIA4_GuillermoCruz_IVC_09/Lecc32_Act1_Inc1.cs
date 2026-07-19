using System;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: Daniel Zea\n" +
            "Grado: IVC - Clave:20\n" +
            "======CONVERSIONES=====");
            double metros, resultado;
        Console.Write("Dame una medida en metros: ");
        metros = double.Parse(Console.ReadLine());

        Console.WriteLine("Menú Principal");
        Console.WriteLine("1. Milimetros\n" +
            "2. Centimetros\n" +
            "3. Decimetros\n" +
            "4. Hectómetro\n" +
            "5. Kilómetros\n" +
            "6. Salir\n" +
            "Seleccione una opción []:");
        int opc=Convert.ToInt32(Console.ReadLine());

        switch (opc)
        {
        case 1:
                Console.Clear();
                Console.WriteLine("Conversiones a milimetros");
                resultado = metros * 1000;
                Console.WriteLine("Los metros"+metros+"en milimetros es "+resultado);
                break;
        case 2:
                Console.Clear();
                Console.WriteLine("Conversiones a centimetros");
                resultado= metros * 100;
                Console.WriteLine("Los metros" + metros + "en centimetros es " + resultado);
                break;
        case 3:
                Console.Clear();
                Console.WriteLine("Conversiones a decimetros");
                resultado=metros*10;
                Console.WriteLine("Los metros" + metros + "en decimetros es " + resultado);
                break;
        case 4:
                Console.Clear();
                Console.WriteLine("Conversiones a hectómetros");
                resultado = metros / 100;
                Console.WriteLine("Los metros : " + metros + "en hectómetros es " + resultado);
                break;
        case 5:
                Console.Clear();
                Console.WriteLine("Conversiones a kilómetros");
                resultado = metros / 1000;
                Console.WriteLine("Los metros" + metros + "en kilómetros es " + resultado);
                break;
        case 6:
                Console.Clear();
                Console.WriteLine("Para salir, presione una tecla");
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("Opción invalida...");
                break;
        }
    }
}
