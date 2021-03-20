using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCMovie_130321.Models;

namespace MVCMovie_130321.Data
{
    public class MVCMovie_130321Context : DbContext
    {
        public MVCMovie_130321Context (DbContextOptions<MVCMovie_130321Context> options)
            : base(options)
        {
        }

        public DbSet<MVCMovie_130321.Models.Movie> Movie { get; set; }
    }
}
