namespace Mailing;

public interface IMailPoller
{
    event EventHandler<NewMailEventArgs> NewMail;
    void Start();
    void Stop();
}