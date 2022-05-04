namespace EventsAndDelegates;

class Program
{
    public static void Main(string[] args)
    {
        var video = new Video() {Title = "Video 1"};
        var videoEncoder = new VideoEncoder(); // publisher
        var mailService = new MailService();

        videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

        videoEncoder.Encode(video);
    }
}