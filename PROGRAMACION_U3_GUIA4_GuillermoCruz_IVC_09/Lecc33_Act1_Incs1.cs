using System;

internal class Program
{
    private static void Main(string[] args)
    {
        
        string[] nombres = new string[10];
        string[] telefonos = new string[10];

        Console.WriteLine("=== REGISTRO DE CONTACTOS ===");
        Console.WriteLine("Por favor, introduce los datos de las 10 personas.\n");

        
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"👤 Contacto #{i + 1}:");

            Console.Write("   Nombre: ");
            nombres[i] = Console.ReadLine();

            Console.Write("   Teléfono: ");
            telefonos[i] = Console.ReadLine();

            Console.WriteLine(); 
        }

        Console.Clear(); 
        Console.WriteLine("=== AGENDA TELEFÓNICA INTERACTIVA ===");
        Console.WriteLine("¡Todos los contactos se han guardado con éxito!");
        Console.WriteLine("Puedes consultar las posiciones de la 1 a la 10.");
        Console.WriteLine("Escribe '0' para salir.\n");

        
        while (true)
        {
            Console.Write("Introduce el número de posición a consultar (1-10): ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int posicion))
            {
                if (posicion == 0)
                {
                    Console.WriteLine("¡Hasta luego, bro!");
                    break;
                }

                if (posicion >= 1 && posicion <= 10)
                {
                    int indice = posicion - 1; 

                    Console.WriteLine(new string('-', 40));
                    Console.WriteLine($"📌 Posición {posicion}:");
                    Console.WriteLine($"👤 Nombre:   {nombres[indice]}");
                    Console.WriteLine($"📞 Teléfono: {telefonos[indice]}");
                    Console.WriteLine(new string('-', 40) + "\n");
                }
                else
                {
                    Console.WriteLine("Error: La posición debe estar entre 1 y 10.\n");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Introduce un número entero.\n");
            }
        }
    }
}
