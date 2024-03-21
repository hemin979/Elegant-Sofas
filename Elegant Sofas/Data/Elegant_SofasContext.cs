using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Elegant_Sofas.Models;

namespace Elegant_Sofas.Data
{
    public class Elegant_SofasContext : DbContext
    {
        public Elegant_SofasContext (DbContextOptions<Elegant_SofasContext> options)
            : base(options)
        {
        }

        public static object Products { get; internal set; }
        public DbSet<Elegant_Sofas.Models.Sofas> Sofas { get; set; } = default!;
    }
}
