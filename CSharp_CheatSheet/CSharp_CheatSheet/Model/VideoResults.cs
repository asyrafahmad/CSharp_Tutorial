using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet.Model
{
    public partial class VideoResults
    {
        public VideoResults()
        {
            VideoItems = new HashSet<VideoItems>();
        }

        public string Kind { get; set; }
        public string Etag { get; set; }
        public int? PageInfototalResults { get; set; }

        public PageInfo PageInfototalResultsNavigation { get; set; }
        public ICollection<VideoItems> VideoItems { get; set; }
    }
}
