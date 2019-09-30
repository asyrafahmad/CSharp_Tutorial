using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet.Model
{
    public partial class ResultItems
    {
        public string Id { get; set; }
        public string Kind { get; set; }
        public string Etag { get; set; }
        public string ContentDetailsvideoId { get; set; }

        public ContentDetails ContentDetailsvideo { get; set; }
        public YoutubeResults KindNavigation { get; set; }
    }
}
