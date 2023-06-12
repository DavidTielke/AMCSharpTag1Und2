namespace Mailing;

public class MailSender : IMailSender
{
    public event EventHandler<MailSentEventArgs> SentComplete;

    public void Send()
    {
        Console.WriteLine("Eail wird versendet");
        OnSentCompleted();
    }

    protected virtual void OnSentCompleted()
    {
        SentComplete?.Invoke(this, new MailSentEventArgs());
    }
}