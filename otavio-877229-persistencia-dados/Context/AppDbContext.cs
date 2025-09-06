using Microsoft.EntityFrameworkCore;
using otavio_877229_persistencia_dados.Models;

namespace otavio_877229_persistencia_dados.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        DbSet<Produto>? Produtos { get; set; }
    }
}
