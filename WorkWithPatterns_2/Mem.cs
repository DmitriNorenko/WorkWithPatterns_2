using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace WorkWithPatterns_2
{
    public class Mem : Commands
    {
        YoutubeClient client;
        public string Url = "https://youtu.be/gqRMSfWnCMc?si=ujtjWn212RCWAKic";
        public Mem(YoutubeClient client)
        {
            this.client = client;
        }
        public void Download()
        {
            Console.WriteLine("Идет скачивание.");
        }
        public void ShowInfo()
        {
            Console.WriteLine("Описание видео.");
            client.Videos.GetAsync(Url);
        }
    }
}
