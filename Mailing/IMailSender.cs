namespace Mailing;

public interface IMailSender
{
    event EventHandler<MailSentEventArgs> SentComplete;
    void Send();
}