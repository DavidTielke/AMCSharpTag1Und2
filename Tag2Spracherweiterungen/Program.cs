namespace Tag2Spracherweiterungen;

public partial class A
{
    public void Foo()
    {
    }
}

public partial class A
{
    public void Bar()
    {
    }

    public (string, int) Validate(string para5, string para2)
    {
        if (para5 == null)
        {
            unsafe
            {
                var z0 = 4;
                var zahl1 = &z0;
            }

            throw new ArgumentNullException(nameof(para5), "para1 was null");
        }
    }
}

[AttributeUsage(AttributeTargets.Property)]
public class IdentifierAttribute : Attribute
{
}

public class Bill
{
    [Identifier] public int Number { get; set; }

    public decimal Amount { get; set; }
}

internal class Program
{
    private static void Main(string[] args)
    {
        long Add(int z1, int z2)
        {
            return z1 + (long)z2;
        }

        var person = new
        {
            Id = 1,
            Name = "David",
            Age = 39
        };

        var names = new[] { "Lisa", "Lena", "Maximilian", "David" };

        var foo = names.Select(n => new
        {
            FirstChar = n[0], n.Length
        });

        foreach (var item in foo)
        {
            Console.WriteLine($"Erste Buchstabe {item.FirstChar} mit {item.Length} länmge");
        }
    }
}