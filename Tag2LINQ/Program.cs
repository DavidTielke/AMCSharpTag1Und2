namespace Tag2LINQ;

internal class Person
{
    public Person()
    {
    }

    public Person(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

internal class Program
{
    private static void Main(string[] args)
    {
        var persons = new List<Person>
        {
            new(1, "David", 39),
            new(2, "Lena", 29),
            new(3, "Maximilian", 12),
            new(4, "Lisa", 0),
            new(5, "Teddy", 8),
            new(5, "Teddy2", 8)
        };

        // Alle Personen die Älter als 20 Jahre sind, sortiert nach Name, nur die ID ausgeben
        // Maximale und minimale ALter von Personen
        // Alle Personen, gruppiert nach Länge ihres Vornamens
        // Nur die letzten beiden Personen
    }
}