namespace EventsAndDelegates;

public class VideoEncoder
{
    public event VideoEncoderEventHandler VideoEncoded;

    // 1) Define a delegate
    // 2) Define an event base on that delegate
    // 3) Raise the event
    public delegate void VideoEncoderEventHandler(object source, EventArgs args);

    public void Encode(Video video)
    {
        Console.WriteLine("Encoding video ...");
        Thread.Sleep(1500);
    }

    protected virtual void OnVideoEncoded()
    {
        if (VideoEncoded != null)
        {
            VideoEncoded(this, EventArgs.Empty);
        }
    }
}