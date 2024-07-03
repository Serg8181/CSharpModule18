using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode.Videos;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;


namespace Task18._4._1.Receiver
{
    public class Youtube
    {
        private string Url { get; set; }

        public Youtube(string url)
        {
            Url = url;

        }
        public async Task GetInfo()
        {

            YoutubeClient client = new YoutubeClient();
            var video = await client.Videos.GetAsync(Url);
            Console.WriteLine($"Название: {video.Title}");
            Console.WriteLine($"Продолжительность: {video.Duration}");
            Console.WriteLine($"Автор: {video.Author}");
            Console.WriteLine($"Описание: {video.Description}");
        }

        public async Task DownLoadVideo()
        {

            var client = new YoutubeClient();
            var streamManifest = await client.Videos.Streams.GetManifestAsync(Url);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            await client.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
            Console.WriteLine("Видео загружено.");

        }
    }

}