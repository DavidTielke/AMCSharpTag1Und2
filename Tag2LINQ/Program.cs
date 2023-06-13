namespace Tag2LINQ;

internal class Person
{
    public Person()
    {
    }

    public Person(int id, string name, int alter)
    {
        Id = id;
        Name = name;
        Alter = alter;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int Alter { get; set; }
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
            new(5, "Teddy", 8)
        };

        var aldults = persons
            .Select(p => p.Name)
            .Distinct();
    }
}