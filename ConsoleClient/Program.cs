using DataStoring;
using MailDistribution;
using Mailing;

namespace ConsoleClient;

internal class Program
{
    private static void Main(string[] args)
    {
        var repo = new ReceiverRepository();
        var poller = new MailPoller();
        var sender = new MailSender();

        var distributor = new MailDistributor(poller, sender, repo);

        distributor.Start();
        distributor.Stop();
    }
}