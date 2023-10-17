using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithPatterns_2
{
    internal class VideoDeterminant
    {
        public Commands video { get; set; }
        public VideoDeterminant(Commands Video)
        {
            video = Video;
        }
        public void Download()
        {
            video.Download();
        }
        public void ShowInfo()
        {
            video.ShowInfo();
        }
    }
}
