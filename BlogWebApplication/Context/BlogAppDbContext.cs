using BlogWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogWebApplication.Context
{
    public class BlogAppDbContext : DbContext
    {
        public BlogAppDbContext(DbContextOptions<BlogAppDbContext> options) : base(options)
        {
        }

        public DbSet<Comentario> Comentarios { get; set; }
    }
}
