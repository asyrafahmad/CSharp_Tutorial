using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet.Model
{
    public partial class PageInfo
    {
        public PageInfo()
        {
            VideoResults = new HashSet<VideoResults>();
            YoutubeResults = new HashSet<YoutubeResults>();
        }

        public int TotalResults { get; set; }
        public int ResultsPerPage { get; set; }

        public ICollection<VideoResults> VideoResults { get; set; }
        public ICollection<YoutubeResults> YoutubeResults { get; set; }
    }
}
