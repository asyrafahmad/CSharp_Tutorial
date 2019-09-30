using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet.Model
{
    public partial class videoItems
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public string id { get; set; }
        public string snippettitle { get; set; }

        public VideoResults kindNavigation { get; set; }
        public snippet snippettitleNavigation { get; set; }
    }
}
