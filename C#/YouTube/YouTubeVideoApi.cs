#region Using

using Newtonsoft.Json;

#endregion

namespace YouTube
{
    internal class YouTubeVideoApi
    {
        internal struct YtStatistics
        {
            public int favoriteCount { get; set; }
            public int viewCount { get; set; }
        }

        internal struct YtRating
        {
            public int numDislikes { get; set; }
            public int numLikes { get; set; }
        }

        internal struct Title
        {
            [JsonProperty( PropertyName = "$t" )]
            public string t { get; set; }
        }

        internal struct Entry
        {
            public Title title { get; set; }

            [JsonProperty( PropertyName = "yt$statistics" )]
            public YtStatistics ytstatistics { get; set; }

            [JsonProperty( PropertyName = "yt$rating" )]
            public YtRating ytrating { get; set; }
        }

        public string version { get; set; }
        public string encoding { get; set; }
        public Entry entry { get; set; }
    }
}