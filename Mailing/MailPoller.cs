namespace Mailing;

public class MailPoller : IMailPoller
{
    public event EventHandler<NewMailEventArgs> NewMail;

    public void Start()
    {
        Console.WriteLine("Poller gesytartet");
        DownloadNewMail();
    }

    public void Stop()
    {
        Console.WriteLine("Poller gestoppt");
    }

    private void DownloadNewMail()
    {
        Console.WriteLine("Neue Email wird runtergeladen");
        OnNewMail("foo....");
    }

    protected virtual void OnNewMail(string email)
    {
        NewMail?.Invoke(this, new NewMailEventArgs
        {
            Email = email
        });
    }
}