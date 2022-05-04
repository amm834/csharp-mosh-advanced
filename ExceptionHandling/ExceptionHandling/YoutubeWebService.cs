namespace ExceptionHandling;

public class YoutubeWebService
{
    public void FetchApi()
    {
        try
        {
            throw new Exception("Low level exception");
        }
        catch (Exception ex)
        {
            throw new YoutubeException("Cannot fetch data from API", ex);
        }
    }
}