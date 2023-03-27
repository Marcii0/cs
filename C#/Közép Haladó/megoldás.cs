namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adjon meg egy szöveget: ");
            string bekert = Console.ReadLine();
            Console.Write("Adjon meg egy karaktert: ");
            char karakter = Console.ReadKey().KeyChar;
            int tartalomszam = 0;
            for (int k = 0; k < bekert.Length; k++)
                if (bekert[k] == karakter)
                    tartalomszam++;
            Console.WriteLine($"{tartalomszam} alkalommal jelent meg a '{karakter}' karakter.");

            tartalomszam = 0;

            for (int k = 0; k < bekert.Length; k++)
                if (bekert[k] == 'a')
                    tartalomszam++;

            Console.WriteLine($"{tartalomszam} alkalommal jelent meg az 'a' karakter.");
        }
    }
}
