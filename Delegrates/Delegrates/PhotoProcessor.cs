using System.ComponentModel.DataAnnotations;

namespace Delegrates;

public class PhotoProcessor
{
    // public delegate void PhotoFilterHandler(Photo photo);

    public void Process(string path, Action<Photo> photoFilterHandler)
    {
        var photo = new Photo(path);

        photoFilterHandler(photo);

        photo.Save();
    }
}