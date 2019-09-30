using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet.Model
{
    public partial class pageInfo
    {
        public pageInfo()
        {
            VideoResults = new HashSet<VideoResults>();
            YoutubeResults = new HashSet<YoutubeResults>();
        }

        public int totalResults { get; set; }
        public int resultsPerPage { get; set; }

        public ICollection<VideoResults> VideoResults { get; set; }
        public ICollection<YoutubeResults> YoutubeResults { get; set; }
    }
}
