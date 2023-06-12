using DataStoring;
using Mailing;

namespace MailDistribution;

public class MailDistributor
{
    private readonly IMailPoller _poller;
    private readonly IReceiverRepository _receiverRepository;
    private readonly IMailSender _sender;

    public MailDistributor(IMailPoller poller, IMailSender sender, IReceiverRepository receiverRepository)
    {
        _poller = poller;
        _poller.NewMail += NewMailReceived;
        _sender = sender;
        _sender.SentComplete += MailSentCompleted;
        _receiverRepository = receiverRepository;
    }

    private void MailSentCompleted(object? sender, MailSentEventArgs e)
    {
        Console.WriteLine("Verteilung erfolgreich");
    }

    private void NewMailReceived(object? sender, NewMailEventArgs e)
    {
        Console.WriteLine("Email an Verteiler übertragen");
        Distribute();
    }

    public void Start()
    {
        Console.WriteLine("Verteiler gestartet");
        _poller.Start();
    }

    public void Stop()
    {
        Console.WriteLine("VCerteiler gestoppt");
        _poller.Stop();
    }

    public void Distribute()
    {
        Console.WriteLine("Verteilen gestartet");
        _receiverRepository.Load();
        _sender.Send();
    }
}