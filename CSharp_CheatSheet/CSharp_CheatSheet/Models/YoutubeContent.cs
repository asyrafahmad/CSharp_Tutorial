using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheatSheet.Models
{
    public class YoutubeContent
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
        public string itemId { get; set; }
        public List<itemDetails> itemDetail { get; set; }
    }

    public class itemDetails
    {
        [Key]
        public string id { get; set; }
        public string kind { get; set; }
        public string etag { get; set; }
        public List<snippets> snippets { get; set; }
    }

    public class snippets
    {
        public DateTime publishedAt { get; set; }
        [Key]
        public string channelID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public localized localized { get; set; }
        public List<thumbnail> thumbnail { get; set; }

    }

    public class localized
    {
        public string title { get; set; }
        public string description { get; set; }

    }

    public class thumbnail
    {
        [Key]
        public string channelTitle { get; set; }
        public thumbnailsDetails defaults { get; set; }
        public thumbnailsDetails medium { get; set; }
        public thumbnailsDetails high { get; set; }
        public thumbnailsDetails standard { get; set; }
    }

    public class thumbnailsDetail
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

}
