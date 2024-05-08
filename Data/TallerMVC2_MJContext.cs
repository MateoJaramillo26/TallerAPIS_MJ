using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TallerMVC3_MJ.Models;

namespace TallerMVC3_MJ.Data
{
    public class TallerMVC2_MJContext : DbContext
    {
        public TallerMVC2_MJContext (DbContextOptions<TallerMVC2_MJContext> options)
            : base(options)
        {
        }

        public DbSet<TallerMVC3_MJ.Models.Burger> Burger { get; set; } = default!;
        public DbSet<TallerMVC3_MJ.Models.Promo> Promo { get; set; } = default!;
    }
}
