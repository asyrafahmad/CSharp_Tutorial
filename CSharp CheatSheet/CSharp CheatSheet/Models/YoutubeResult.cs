using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheatSheet.Models
{
    public class YoutubeResult
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public string nextPageToken { get; set; }
        public pageInfo pageInfo { get; set; }
        public List<resultItems> items { get; set; }
    }
    public class pageInfo
    {
        public int totalResults { get; set; }
        public int resultsPerPage { get; set; }
    }
    public class resultItems
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public string id { get; set; }
        public contentDetails contentDetails { get; set; }
    }
    public class contentDetails
    {
        public string videoId { get; set; }
        public DateTime videoPublishedAt { get; set; }
    }
}
