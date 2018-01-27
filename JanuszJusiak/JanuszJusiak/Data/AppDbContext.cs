using JanuszJusiak.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JanuszJusiak.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Page> Pages { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Element> Elements { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<AbstractElement> AbstractElements { get; set; }
    }
}
