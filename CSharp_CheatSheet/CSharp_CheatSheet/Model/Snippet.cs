using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet.Model
{
    public partial class snippet
    {
        public snippet()
        {
            videoItems = new HashSet<videoItems>();
        }

        public DateTime publishedAt { get; set; }
        public string title { get; set; }
        public string description { get; set; }

        public ICollection<videoItems> videoItems { get; set; }
    }
}
