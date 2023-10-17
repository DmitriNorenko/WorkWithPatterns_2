using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Converter;

namespace WorkWithPatterns_2
{
    public class Mem : Commands
    {
        YoutubeClient client;
        public string Url = "https://youtu.be/sc0kNKVmaek?si=Eavnw7QNjOeoVbDH";
        public Mem(YoutubeClient client)
        {
            this.client = client;
        }

        public async void Download()
        {
            Console.WriteLine("Идет скачивание.");
            await client.Videos.DownloadAsync(Url, "//Users//dima//Download");
        }
        public void ShowInfo()
        {
            var item = client.Videos.GetAsync(Url);
            Console.WriteLine(item.Result);
        }
    }
}
