public class VideoLibrary
{
    private List<Video> _videos = new();
    
    public void AddVideo(Video video)
    {
        _videos.Add(video);
    }
      public void GetDisplay()
    {  
        foreach(Video video in _videos)
        { 
            video.GetDisplay();    
        }     
    }
}