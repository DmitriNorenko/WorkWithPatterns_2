using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace WorkWithPatterns_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YoutubeClient client = new YoutubeClient();
            Mem mem_1 = new Mem(client);
            VideoDeterminant video_1 = new VideoDeterminant(mem_1);
            video_1.ShowInfo();
            video_1.Download();
            Console.ReadKey();
        }
    }
}
