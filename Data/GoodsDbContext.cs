using Microsoft.EntityFrameworkCore;
using GoodsAPI2.Models;

namespace GoodsAPI2.Data
{
    public class GoodsDbContext : DbContext
    {
        public GoodsDbContext(DbContextOptions<GoodsDbContext> options) : base(options) { }

        public DbSet<HangHoa> Goods { get; set; }
    }
}
