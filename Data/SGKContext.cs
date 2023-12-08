using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SGK.Models;

namespace SGK.Data
{
    public class SGKContext : DbContext
    {
        public SGKContext (DbContextOptions<SGKContext> options)
            : base(options)
        {
        }

        public DbSet<SGK.Models.vtd> vtd { get; set; }
    }
}
