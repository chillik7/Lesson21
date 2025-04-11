using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WatchlistApp.Models;

namespace WatchlistApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<WatchItem> WatchItems { get; set; }
    }
}
