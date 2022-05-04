namespace EventsAndDelegates;

public class MailService
{
    public void OnVideoEncoded(object source, EventArgs args)
    {
        Console.WriteLine("Sending mail ...");
    }
}