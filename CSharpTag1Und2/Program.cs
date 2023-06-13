namespace DelegatesUndEvents;

public class Person
{
    // ...

    public Person(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; }
}

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
        var names = new[] { "Lisa", "Maximlian", "Lena", "David" };

        // Anonyme Methode
        var del1 = delegate(string name) { return name.Contains("i"); };

        // Lambda Ausdrücke
        Func<string, bool> del2 = name => { return name.Contains("i"); };
        Func<string, bool> del3 = name => { return name.Contains("i"); };
        Func<string, bool> del4 = name => { return name.Contains("i"); };
        Func<string, bool> del5 = name => name.Contains("i");


        var namesWithI = names
            .Where(del5);
        Console.WriteLine(namesWithI.Count());


        var persons = new List<Person>
        {
            new(3, "David"),
            new(2, "Lena"),
            new(4, "Maximilian"),
            new(1, "Lisa")
        };

        var personDict = persons
            .OrderBy(p => p.Id)
            .ToDictionary(p => p.Id, p => p);
    }

    public static bool NameContainsAnI(string name)
    {
        return name.Contains("i");
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