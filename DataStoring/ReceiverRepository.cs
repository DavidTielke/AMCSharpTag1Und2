namespace DataStoring;

public class ReceiverRepository : IReceiverRepository
{
    public void Load()
    {
        Console.WriteLine("Empfänger aus DB geladen");
    }
}