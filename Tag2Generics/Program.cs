using System.Collections;

namespace Tag2Generics;

internal class Program
{
    private static void Main(string[] args)
    {
        var list = new MyList<int>();
        list[0] = 1;
        Console.WriteLine(list[0]);
    }
}

internal class Wrapper<TType>
    where TType : class, IDisposable, new()
{
    private TType _item;

    public TType Item
    {
        get
        {
            if (_item == null)
            {
                _item = new TType();
            }

            return _item;
        }
    }
}

internal class PersonManager
{
    private readonly Lazy<DbConnection> _connection = new();

    public PersonManager(int port)
    {
    }

    public void Load()
    {
        // Wird auf Db zugegriffen
        _connection.Value.Connect();
    }

    public void Validate(Person person)
    {
        // Nicht auf DB zugegriffen
    }
}

// 2 sekunden
internal class DbConnection
{
    public void Connect()
    {
    }
}

internal class NullbarerWertetyp<TItem>
{
    private bool _hasValue;
    private TItem _value;

    public TItem Value
    {
        get => _value;
        set
        {
            _value = value;
            _hasValue = true;
        }
    }

    public bool IsNull()
    {
        return !_hasValue;
    }

    public void SetToNull()
    {
        _hasValue = false;
        _value = default;
    }
}

internal interface IStack<TItem>
{
    TItem Pop();
    TItem Peek();
    void Push(TItem item);
}

internal class MyStack<TItem> : IStack<TItem>
{
    private readonly ArrayList _items;
    private int _position;

    public MyStack()
    {
        _items = new ArrayList();
        _position = 0;
    }

    public TItem Pop()
    {
        var item = Peek();
        _items.RemoveAt(_position);
        _position--;
        return item;
    }

    public TItem Peek()
    {
        return (TItem)_items[_position];
    }

    public void Push(TItem item)
    {
        _items.Add(item);
        _position++;
    }
}

internal class MyList<TItem> : IEnumerable
{
    private readonly ArrayList _items;


    public MyList()
    {
        _items = new ArrayList();
    }

    public TItem this[int index]
    {
        get => (TItem)_items[index];

        set => _items[index] = value;
    }

    public IEnumerator GetEnumerator()
    {
        return _items.GetEnumerator();
    }

    public void Add(TItem p)
    {
        _items.Add(p);
    }

    public TItem Get(int index)
    {
        return (TItem)_items[index];
    }
}

internal class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
}