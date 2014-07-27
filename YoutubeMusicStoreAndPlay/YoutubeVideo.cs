using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeMusicStoreAndPlay
{
    class YoutubeVideo
    {

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string videoURL;

        public string VideoURL
        {
            get { return videoURL; }
            set { videoURL = value; }
        }
        
        public YoutubeVideo(string _title, string _videoURL)
        {
            title = _title;
            videoURL = _videoURL;
        }

        public string PrintVideoStorage
        {
            get { return videoURL + title; }
        }

    }
}
