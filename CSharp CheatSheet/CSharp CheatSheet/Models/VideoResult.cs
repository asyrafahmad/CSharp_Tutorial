using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  CheatSheet.Models
{
    public class VideoResult
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public pageInfo pageInfo { get; set; }
        public List<videoItems> items { get; set; }
    }
    public class videoItems
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public string id { get; set; }
        public snippet snippet { get; set; }
    }
    public class snippet
    {
        public DateTime publishedAt { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        //public List<thumbnails> thumbnails { get; set; }
    }
    public class thumbnails
    {
        public thumbnailsDetails defaults { get; set; }
        public thumbnailsDetails medium { get; set; }
        public thumbnailsDetails high { get; set; }
        public thumbnailsDetails standard { get; set; }
    }
    public class thumbnailsDetails
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }
}
