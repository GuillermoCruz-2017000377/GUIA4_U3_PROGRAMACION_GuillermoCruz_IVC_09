using System;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("=== CONVERSOR DECIMAL Y BINARIO ===");
            Console.WriteLine("1. Convertir de Decimal a Binario");
            Console.WriteLine("2. Convertir de Binario a Decimal");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");

            string opcion = Console.ReadLine();

            if (opcion == "0")
            {
                Console.WriteLine("¡Nos vemos, bro!");
                break;
            }
            else if (opcion == "1")
            {
                
                Console.Write("\nIntroduce un número decimal entero: ");
                if (int.TryParse(Console.ReadLine(), out int numeroDecimal))
                {
                    if (numeroDecimal == 0)
                    {
                        Console.WriteLine(" En binario es: 0\n");
                    }
                    else
                    {
                        string resultadoBinario = "";
                        int temp = numeroDecimal;

                        
                        while (temp > 0)
                        {
                            int residuo = temp % 2;
                            resultadoBinario = residuo + resultadoBinario; 
                            temp = temp / 2;
                        }
                        Console.WriteLine($" En binario es: {resultadoBinario}\n");
                    }
                }
                else
                {
                    Console.WriteLine(" Error: Introduce un número válido.\n");
                }
            }
            else if (opcion == "2")
            {
                
                Console.Write("\nIntroduce un número binario (solo 0 y 1): ");
                string binarioInput = Console.ReadLine();

                int decimalResultado = 0;
                int potencia = 1; 
                bool esValido = true;

                
                for (int i = binarioInput.Length - 1; i >= 0; i--)
                {
                    if (binarioInput[i] == '1')
                    {
                        decimalResultado += potencia;
                    }
                    else if (binarioInput[i] != '0')
                    {
                        esValido = false;
                        break;
                    }
                    potencia *= 2; 
                }

                if (esValido)
                {
                    Console.WriteLine($" En decimal es: {decimalResultado}\n");
                }
                else
                {
                    Console.WriteLine(" Error: Un número binario solo puede contener 0 y 1.\n");
                }
            }
            else
            {
                Console.WriteLine(" Opción no válida.\n");
            }
        }
    }
}