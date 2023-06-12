namespace Übung1;

internal class Program
{
    private static void Main(string[] args)
    {
        var sensor = new Sensor
        {
            Name = "Humidity 1"
        };

        sensor.NewMesswert += LogMesswert;
        //sensor.NewMesswert += GebeMesswertAus;
        //sensor.NewMesswert -= LogMesswert;

        sensor.Messe();
    }

    private static void LogMesswert(object sender, NewMesswertEventArgs args)
    {
        File.WriteAllText("values.txt", args.Wert + "\n");
    }

    private static void GebeMesswertAus(object sender, NewMesswertEventArgs args)
    {
        var sensor = sender as Sensor;
        Console.WriteLine($"Neuer Messwert {sensor.Name}: {args.Wert} mit Genuaigkeit {args.Genauigkeit}");
    }
}

public class NewMesswertEventArgs
{
    public double Wert { get; set; }
    public double Genauigkeit { get; set; }
}

public class Sensor
{
    public int Id { get; set; }

    public string Name { get; set; }

    // Auto Property
    public string Position { get; set; }

    // Auto Event
    public event EventHandler<NewMesswertEventArgs> NewMesswert;

    public void Messe()
    {
        OnNewMesswert(1.23d, 3.45d);
    }

    protected void OnNewMesswert(double wert, double genauigkeit)
    {
        NewMesswert?.Invoke(this, new NewMesswertEventArgs
        {
            Wert = wert,
            Genauigkeit = genauigkeit
        });
    }
}

public class LightSensor : Sensor
{
    public void Messe()
    {
        OnNewMesswert(3.45d, 5.67d);
    }
}