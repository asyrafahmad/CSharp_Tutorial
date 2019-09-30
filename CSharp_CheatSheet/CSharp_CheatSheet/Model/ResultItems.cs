using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet.Model
{
    public partial class resultItems
    {
        public string id { get; set; }
        public string kind { get; set; }
        public string etag { get; set; }
        public string contentDetailsvideoId { get; set; }

        public contentDetails contentDetailsvideo { get; set; }
        public YoutubeResults kindNavigation { get; set; }
    }
}
