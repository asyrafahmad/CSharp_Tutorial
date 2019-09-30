using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet.Model
{
    public partial class VideoResults
    {
        public VideoResults()
        {
            videoItems = new HashSet<videoItems>();
        }

        public string kind { get; set; }
        public string etag { get; set; }
        public int? pageInfototalResults { get; set; }

        public pageInfo pageInfototalResultsNavigation { get; set; }
        public ICollection<videoItems> videoItems { get; set; }
    }
}
