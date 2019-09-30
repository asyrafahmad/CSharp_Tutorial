using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet.Model
{
    public partial class YoutubeResults
    {
        public YoutubeResults()
        {
            ResultItems = new HashSet<ResultItems>();
        }

        public string Kind { get; set; }
        public string Etag { get; set; }
        public string NextPageToken { get; set; }
        public int? PageInfototalResults { get; set; }

        public PageInfo PageInfototalResultsNavigation { get; set; }
        public ICollection<ResultItems> ResultItems { get; set; }
    }
}
