using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet.Model
{
    public partial class VideoItems
    {
        public string Id { get; set; }
        public string Kind { get; set; }
        public string Etag { get; set; }
        public string Snippettitle { get; set; }

        public VideoResults KindNavigation { get; set; }
        public Snippet SnippettitleNavigation { get; set; }
    }
}
