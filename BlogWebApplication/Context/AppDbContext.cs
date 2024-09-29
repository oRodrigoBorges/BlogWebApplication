using BlogWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogWebApplication.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Comentario> Comentarios { get; set; }
    }
}
