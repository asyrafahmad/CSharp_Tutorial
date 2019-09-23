using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheatSheet.Models
{
    public class YoutubeResult
    {
        [Key]
        public string kind { get; set; }
        public string etag { get; set; }
        public string nextPageToken { get; set; }
        public pageInfo pageInfo { get; set; }
        public List<resultItems> items { get; set; }
    }
    public class pageInfo
    {
        [Key]
        public int totalResults { get; set; }
        public int resultsPerPage { get; set; }
    }
    public class resultItems
    {
        [Key]
        public string id { get; set; }
        public string kind { get; set; }
        public string etag { get; set; }
        public contentDetails contentDetails { get; set; }
    }
    public class contentDetails
    {
        [Key]
        public string videoId { get; set; }
        public DateTime videoPublishedAt { get; set; }
    }
}
