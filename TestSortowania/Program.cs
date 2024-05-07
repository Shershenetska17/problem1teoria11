namespace TestSortowania;
using Sortowanie;
internal class Program
{

    static void Main(string[] args)
    {
        int[] liczby = new int[10];
        Random r = new Random();
        Console.WriteLine("Tablica przed sortowaniem:");
        for (int i = 0; i < liczby.Length; i++)
        {
            liczby[i] = r.Next(0, 1001);
            Console.WriteLine("{0}", liczby[i]);
        }
        Sortowanie.Sortuj(liczby);

        Console.WriteLine("\n\nTablica po sortowaniu:");
        foreach (int i in liczby)
        {
            Console.WriteLine("{0}, ", i);
        }

        Console.ReadKey();
    }
}
