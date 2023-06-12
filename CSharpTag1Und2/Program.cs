namespace DelegatesUndEvents;

public class Program
{
    // Übung 1:
    // - Fuechtigkeitssensor
    // - Methode Messe
    // - Delegaten-Feld NeuerMesswert
    // - Mit eigenem Delegaten
    // Wert in Consolenanwendung ausgeben

    public static void Main()
    {
        var del1 = new Action(MyHandler);
        del1();

        var del2 = new Action<double>(MyHandler);
        del2(1.23);

        var del3 = new Func<int, int, long>(Add);
        var sum = del3(1, 2);

        var del4 = new Func<string, bool>(IsValid);
        var isValid = del4("David");
    }

    public static bool IsValid(string name)
    {
        return name.Length > 2;
    }

    public static long Add(int zahl1, int zahl2)
    {
        return zahl1 + zahl2;
    }

    public static void MyHandler()
    {
        Console.WriteLine("Mein eigener Quellcode");
    }

    public static void MyHandler(double wert)
    {
        Console.WriteLine($"Mein eigener Quellcode: {wert}");
    }
}

public delegate void MyClickHandler();

// MyNewWindowsForms.dll
internal class Button
{
    public MyClickHandler _clickHandler;

    public void Click()
    {
        // ....
        _clickHandler();
        // ....
    }
}