#region Using

using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace YouTubeVideoTest
{
    [TestClass]
    public class YouTubeTests
    {
        [TestMethod]
        public void TestVideoTitleById()
        {
            var youtubeVideo = YouTube.YouTube.GetInfo( "lE3a5-Kep3Y" );
            Assert.AreEqual( youtubeVideo.Title, "Самый смешной футбольный матч в мире!" );
        }

        [TestMethod]
        public void TestVideoTitleByHttp()
        {
            var youtubeVideo = YouTube.YouTube.GetInfo( "http://www.youtube.com/watch?v=lE3a5-Kep3Y" );
            Assert.AreEqual( youtubeVideo.Title, "Самый смешной футбольный матч в мире!" );
        }

        [TestMethod]
        public void TestVideoTitleByHttps()
        {
            var youtubeVideo = YouTube.YouTube.GetInfo( "https://www.youtube.com/watch?v=lE3a5-Kep3Y" );
            Assert.AreEqual( youtubeVideo.Title, "Самый смешной футбольный матч в мире!" );
        }

        [TestMethod]
        public void TestVideoViewCount()
        {
            var youtubeVideo = YouTube.YouTube.GetInfo( "https://www.youtube.com/watch?v=lE3a5-Kep3Y" );
            Assert.IsTrue( youtubeVideo.ViewCount > 4000000 );
        }

        [TestMethod]
        public void TestVideoLikesCount()
        {
            var youtubeVideo = YouTube.YouTube.GetInfo( "https://www.youtube.com/watch?v=lE3a5-Kep3Y" );
            Assert.IsTrue( youtubeVideo.NumLikes > 11000 );
        }

        [TestMethod]
        public void TestVideoDislikesCount()
        {
            var youtubeVideo = YouTube.YouTube.GetInfo( "https://www.youtube.com/watch?v=lE3a5-Kep3Y" );
            Assert.IsTrue( youtubeVideo.NumDislikes > 600 );
        }
    }
}