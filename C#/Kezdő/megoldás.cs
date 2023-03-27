namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            do
            {
                Console.Write("Adjon meg egy számot: ");

                a = int.Parse(Console.ReadLine());
                Console.Write("Adjon meg egy második számot: ");

                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Mit szeretne tenni?:\n1) Összeadás\n2) Kivonás\n3) Szorzás\n4) Osztás");

                int valasztas = int.Parse(Console.ReadLine());
                if (valasztas == 1) Console.WriteLine(a + b);
                else if (valasztas == 2) Console.WriteLine(a - b);
                else if (valasztas == 3) Console.WriteLine(a * b);
                else if (valasztas == 4) Console.WriteLine(a / b);
                else Console.WriteLine("Helytelen menüpontot adott meg.");
                Console.WriteLine("Szeretne-e még számolni?");
            } while (Console.ReadLine() == "igen");
        }
    }
}
