using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CheatSheet.Models
{

    public class YoutubeAPIViewModel
    {
        [Key]
        public string Id { get; set; }
        public string Title{ get; set; }
        public string Description { get; set; }
        public string Tumbnail { get; set; }
    }
    public class ListVideos
    {
        public List<YoutubeAPIViewModel> lsVideos { get; set; }
    }
}
