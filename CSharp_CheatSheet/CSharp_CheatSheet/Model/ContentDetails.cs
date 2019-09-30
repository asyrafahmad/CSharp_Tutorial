using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet.Model
{
    public partial class contentDetails
    {
        public contentDetails()
        {
            resultItems = new HashSet<resultItems>();
        }

        public string videoId { get; set; }
        public DateTime videoPublishedAt { get; set; }

        public ICollection<resultItems> resultItems { get; set; }
    }
}
