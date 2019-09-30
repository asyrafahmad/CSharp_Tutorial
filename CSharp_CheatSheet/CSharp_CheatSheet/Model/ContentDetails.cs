using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet.Model
{
    public partial class ContentDetails
    {
        public ContentDetails()
        {
            ResultItems = new HashSet<ResultItems>();
        }

        public string VideoId { get; set; }
        public DateTime VideoPublishedAt { get; set; }

        public ICollection<ResultItems> ResultItems { get; set; }
    }
}
