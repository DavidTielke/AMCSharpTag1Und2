namespace Übung3;

internal class Program
{
    private static void Main(string[] args)
    {
        var sum = Add(int.MaxValue, 1);
        Console.WriteLine($"Ergebnis ist {sum}");
    }

    private static int ReadInt(string caption)
    {
        var isValid = false;
        do
        {
            Console.Write($"Bitte {caption} eingebe: ");
            isValid = int.TryParse(Console.ReadLine(), out var zahl);

            if (isValid)
            {
                return zahl;
            }

            Console.WriteLine("FEHLER: Eingabe war keine gültige Ganzzahhl!");
        } while (true);
    }

    private static long Add(int zahl1, int zahl2)
    {
        return zahl1 + (long)zahl2;
    }
}