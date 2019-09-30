using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CheatSheet.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSharp_CheatSheet.Controllers
{
    public class MenuController : Controller
    {
        static HttpClient client = new HttpClient();
        public IActionResult Index()
        {
            var res = GetVidsAsync();
            var lsVids = res.Result;
            return View(lsVids);
        }

        private async Task<ListVideos> GetVidsAsync()
        {
            var res = new ListVideos();         
            var result = new YoutubeContent();
            try
            {                
                res.lsVideos = new List<YoutubeAPIViewModel>();
                var path = "https://www.googleapis.com/youtube/v3/playlistItems?part=contentDetails&maxResults=50&playlistId=PLAC325451207E3105&key=AIzaSyB7cEKc5O5lr9aF10Gr3ODo_AFbIGOjjHM";
                HttpResponseMessage response = await client.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsAsync<YoutubeContent>();
                    foreach (var item in result.items)
                    {
                        var vidRes = new VideoResult();
                        var uri = $"https://www.googleapis.com/youtube/v3/videos?part=snippet%2CcontentDetails%2Cstatistics&id={item.contentDetails.videoId}&key=AIzaSyB7cEKc5O5lr9aF10Gr3ODo_AFbIGOjjHM";
                        HttpResponseMessage resp = await client.GetAsync(uri);
                        if (response.IsSuccessStatusCode)
                        {
                            vidRes = await resp.Content.ReadAsAsync<VideoResult>();
                            var you = new YoutubeAPIViewModel
                            {
                                Id = vidRes.items.FirstOrDefault().id,
                                Title = vidRes.items.FirstOrDefault().snippet.title,
                                Description = vidRes.items.FirstOrDefault().snippet.description,
                                //Tumbnail = vidRes.items.FirstOrDefault().snippet.thumbnails.FirstOrDefault().medium.url
                            };
                            res.lsVideos.Add(you);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return res;
        }

     
    }
}