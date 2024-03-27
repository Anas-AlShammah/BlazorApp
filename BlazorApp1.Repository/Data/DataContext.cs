using BlazorApp1.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Repository.Data
{
    public class DataContext : DbContext
    { 
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }
        public DbSet<Game> Games { get; set; }
    }
}
