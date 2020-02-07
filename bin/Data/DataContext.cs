using JsRank.API.Models;
using Microsoft.EntityFrameworkCore;

namespace JsRank.API.bin.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        
        public DbSet<score> Score { get; set; }
    }
}