internal class Program
{
    private static void Main(string[] args)
    {
        int number;
        Console.Write("Introduce un número del 1 al 3: ");
        number = Convert.ToInt32(Console.ReadLine());

        switch (number)
        {
            case 1:
                Console.WriteLine("Red");
                break;
            case 2:
                Console.WriteLine("Yellow");
                break;
            case 3:
                Console.WriteLine("Green");
                break;
            default:
                Console.WriteLine("Has introducido un valor invalido");
                break;
        }
    }
}