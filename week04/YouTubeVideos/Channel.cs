using System.Collections.Generic;

public class Channel
{
    private string _name;
    private List<Video> _videos = new List<Video>();

    public Channel(string name)
    {
        _name = name;
    }

    public void AddVideo(Video video)
    {
        _videos.Add(video);
    }

    public List<Video> GetVideos()
    {
        return _videos;
    }

    public string GetName()
    {
        return _name;
    }
}