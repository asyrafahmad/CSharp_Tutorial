﻿using CheatSheet.Models;
using CSharp_CheatSheet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CSharp_CheatSheet.Helpers
{
    public class VideoAPI
    {
        static HttpClient client = new HttpClient();

        public VideoAPI()
        {
        }

        public void Initialize()
        {
            try
            {
                using (var db = new myWebAppContext())
                {
                    //TODO: Call video API and add into database
                    var lsVids = Task.Run(() => GetVidsAsync());
                    if (lsVids.Result.lsVideos.Count() > 0)               //should contain video. thus, it will proceed the process
                    {
                        foreach (var item in lsVids.Result.lsVideos)
                        {
                            //TODO: Insert each videos into db
                            var video = new YoutubeApiViewModels()
                            {
                                Id = item.Id,
                                Description = item.Description,
                                Title = item.Title
                            };
                            db.YoutubeApiViewModels.Add(video);
                        }
                        db.SaveChanges();
                    }
                }                    
            }
            catch(Exception ex)
            {
                throw ex;
            }
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
                        var uri = $"https://www.googleapis.com/youtube/v3/playlistItems?part=contentDetails&maxResults=50&playlistId=PLAC325451207E3105&key=AIzaSyB7cEKc5O5lr9aF10Gr3ODo_AFbIGOjjHM";
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
