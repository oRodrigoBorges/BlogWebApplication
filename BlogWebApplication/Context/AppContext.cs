using BlogWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogWebApplication.Context
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
        }

        public DbSet<Comentario> Comentarios { get; set; }
    }
}
