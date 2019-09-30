using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_CheatSheet.Models
{
    public class CheatSheetContext:DbContext
    {
        public CheatSheetContext(DbContextOptions<CheatSheetContext> options)
            : base(options)
        {
        }
        
    }
}
