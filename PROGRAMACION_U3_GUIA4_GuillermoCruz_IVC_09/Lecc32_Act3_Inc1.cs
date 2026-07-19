internal class Program
{
    static void Main(string[] args)
    {
        char opcion;

        do
        {
            Console.Clear(); 
            Console.WriteLine("=== CLASIFICADOR DE TRIÁNGULOS ===");

            
            Console.Write("Ingresa la medida del lado 1: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la medida del lado 2: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la medida del lado 3: ");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n--------------------------------");

            
            if ((lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1))
            {
                
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("Resultado: Es un triángulo EQUILÁTERO.");
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("Resultado: Es un triángulo ISÓSCELES.");
                }
                else
                {
                    Console.WriteLine("Resultado: Es un triángulo ESCALENO.");
                }
            }
            else
            {
                Console.WriteLine("Error: Las medidas ingresadas no pueden formar un triángulo válido.");
            }

            Console.WriteLine("--------------------------------");

            
            Console.Write("\n¿Deseas hacer otra prueba? Presiona 'R' para reiniciar o cualquier otra tecla para salir: ");

            
            opcion = char.ToUpper(Console.ReadKey().KeyChar);

        } while (opcion == 'R'); 

        Console.WriteLine("\n\n¡Programa finalizado. Hasta luego!");
    }
}
