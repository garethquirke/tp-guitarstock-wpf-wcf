using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GuitarSOA
{
    public class GuitarDbContext : DbContext
    {
        public DbSet<Guitar> Guitars { get; set; }
    }
}