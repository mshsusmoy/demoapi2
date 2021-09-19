using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPI3.Model
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) 
        :base(options){
            Database.EnsureCreated();
        }

        public DbSet<Demo> DemoItem { get; set; }
    }
}
