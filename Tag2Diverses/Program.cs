namespace Tag2Diverses;

internal class Program
{
    private static void Main(string[] args)
    {
        var persons = new List<Person>
        {
            new(1, "David"),
            new(2, "Lena"),
            new(3, "Maximilian"),
            new(4, "Lisa")
        };

        var names = persons
            .Where(p => p.Name.Length > 4)
            .Select(p => p.Name);
        // var foo = names.Filter(p => p.Name.Length > 4)
    }
}

public static class ArrayExtensions
{
    public static IEnumerable<TProperty> Select<TItem, TProperty>(this IEnumerable<TItem> source,
        Func<TItem, TProperty> selector)
    {
        var list = new List<TProperty>();
        foreach (var item in source)
        {
            list.Add(selector(item));
        }

        return list;
    }

    public static IEnumerable<TItem> Where<TItem>(this IEnumerable<TItem> source, Predicate<TItem> predicate)
    {
        var list = new List<TItem>();
        foreach (var item in source)
        {
            var shouldBeIncluded = predicate(item);
            if (shouldBeIncluded)
            {
                list.Add(item);
            }
        }

        return list;
    }
}

public class PersonValidator
{
    public bool IsValid(Person person)
    {
        return person.Id > 0;
    }
}

// -- -Framework
public class Person
{
    public Person(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; }
}