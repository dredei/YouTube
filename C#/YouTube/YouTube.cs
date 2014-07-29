#region Using

using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

#endregion

namespace YouTube
{
    public static class YouTube
    {
        private static string GetJson( string link )
        {
            var webClient = new WebClient();
            webClient.Encoding = System.Text.Encoding.UTF8;
            return webClient.DownloadString( link );
        }

        /// <summary>
        /// Получает информацию о видео
        /// </summary>
        /// <param name="link">Id видео или ссылка на видео</param>
        /// <returns></returns>
        public static YouTubeVideo GetInfo( string link )
        {
            string videoId = link;
            var regex = new Regex( @"watch\?v=([^&]+)(&)?" );
            Match match = regex.Match( link );
            if ( match.Success )
            {
                videoId = match.Groups[ 1 ].ToString();
            }
            string json = GetJson( "http://gdata.youtube.com/feeds/api/videos/" + videoId + "?v=2&alt=json" );
            YouTubeVideoApi res = JsonConvert.DeserializeObject<YouTubeVideoApi>( json );
            return new YouTubeVideo( videoId, res.entry.title.t, res.entry.ytstatistics.viewCount,
                res.entry.ytrating.numDislikes, res.entry.ytrating.numLikes );
        }
    }
}