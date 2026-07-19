using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] opciones = { "Piedra", "Papel", "Tijeras" };
        Random random = new Random();
        bool jugar = true;

        while (jugar)
        {
            Console.Clear();
            Console.WriteLine("1. Piedra | 2. Papel | 3. Tijeras");
            Console.Write("Elige tu opción (1-3): ");
            int usuario = Convert.ToInt32(Console.ReadLine()) - 1;
            
            int pc = random.Next(0, 3);
            
            Console.WriteLine($"\nTú elegiste: {opciones[usuario]}");
            Console.WriteLine($"La PC eligió: {opciones[pc]}");

            if (usuario == pc)
                Console.WriteLine(" ¡Es un EMPATE!");
            else if ((usuario == 0 && pc == 2) || (usuario == 1 && pc == 0) || (usuario == 2 && pc == 1))
                Console.WriteLine(" ¡GANASTE!");
            else
                Console.WriteLine(" ¡PERDISTE!");

            Console.Write("\n¿Quieres jugar de nuevo? (s/n): ");
            if (Console.ReadLine().ToLower() != "s") jugar = false;
        }
    }
}
