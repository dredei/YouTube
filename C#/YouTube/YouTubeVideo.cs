namespace YouTube
{
    public class YouTubeVideo
    {
        public string VideoId { get; private set; }
        public string Title { get; private set; }
        public int ViewCount { get; private set; }
        public int NumDislikes { get; private set; }
        public int NumLikes { get; private set; }

        public YouTubeVideo( string videoId, string title, int viewCount, int numDislikes, int numLikes )
        {
            this.VideoId = videoId;
            this.Title = title;
            this.ViewCount = viewCount;
            this.NumDislikes = numDislikes;
            this.NumLikes = numLikes;
        }
    }
}