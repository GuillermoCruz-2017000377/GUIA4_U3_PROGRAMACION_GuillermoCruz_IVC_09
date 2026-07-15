internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: Guillermo Cruz\n" +
            "Grado:IVC - Clae=9\n" + 
            "=======CAÑCULADORA DE CAMBIO=======");
        int pago;
        string producto:
        Console.Write("Digite el nombre del producto: ");
        producto = Console.ReadLine();
            Console.Write("Dame el precio del prodcucto: "):
            int precio = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite el valor del billete");
        pago = Convert.ToInt32(Console.ReadLine());
        int cambio = pago - precio;
        Console.WriteLine("Su cambio es: " + cambio);

    }
}