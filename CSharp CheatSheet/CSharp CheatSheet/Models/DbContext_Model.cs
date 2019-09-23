using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static CheatSheet.Models.DbContext_Model;

namespace CheatSheet.Models
{
     public class DbContext_Model

    {

 

        public class myWebApp_Context : DbContext

        {

            public myWebApp_Context(DbContextOptions<myWebApp_Context> options)

                : base(options)

            { }

 

            public DbSet<YoutubeAPIViewModel> YoutubeAPIViewModels { get; set; }           
            public DbSet<YoutubeResult> YoutubeResults { get; set; }           
            public DbSet<VideoResult> VideoResults { get; set; }           

        }

    }
}
