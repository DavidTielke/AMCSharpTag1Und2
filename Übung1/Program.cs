namespace Übung1;

internal class Program
{
    private static void Main(string[] args)
    {
        var sensor = new Sensor();

        sensor._newMesswert += LogMesswert;
        sensor._newMesswert += GebeMesswertAus;
        sensor._newMesswert -= LogMesswert;


        sensor.Messe();
    }

    private static void LogMesswert(double wert)
    {
        File.WriteAllText("values.txt", wert + "\n");
    }

    private static void GebeMesswertAus(double wert)
    {
        Console.WriteLine($"Neuer Messwert {wert}");
    }
}

public delegate void NewMesswertHandler(double wert);

internal class Sensor
{
    public NewMesswertHandler _newMesswert;

    public void Messe()
    {
        _newMesswert(1.23d);
    }
}