using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet.Model
{
    public partial class YoutubeResults
    {
        public YoutubeResults()
        {
            resultItems = new HashSet<resultItems>();
        }

        public string kind { get; set; }
        public string etag { get; set; }
        public string nextPageToken { get; set; }
        public int? pageInfototalResults { get; set; }

        public pageInfo pageInfototalResultsNavigation { get; set; }
        public ICollection<resultItems> resultItems { get; set; }
    }
}
