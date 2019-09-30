using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet.Model
{
    public partial class Snippet
    {
        public Snippet()
        {
            VideoItems = new HashSet<VideoItems>();
        }

        public DateTime PublishedAt { get; set; }
        public string ChannelId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ICollection<VideoItems> VideoItems { get; set; }
    }
}
