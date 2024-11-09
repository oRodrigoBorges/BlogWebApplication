using Xunit;
using Microsoft.EntityFrameworkCore;
using BlogWebApplication.Context;
using BlogWebApplication.Models;
using System.Threading.Tasks;

namespace TestsBlogWebApplication.Tests.Tests.IntegrationTests
{
    public class ComentarioIntegrationTests
    {
        private DbContextOptions<BlogAppDbContext> CreateInMemoryDatabaseOptions()
        {
            return new DbContextOptionsBuilder<BlogAppDbContext>()
                .UseInMemoryDatabase(databaseName: "BlogAppDbContext")
                .Options;
        }

        [Fact]
        public async Task AdicionarComentario_DeveSalvarNoBancoDeDados()
        {
            var options = CreateInMemoryDatabaseOptions();
            using var context = new BlogAppDbContext(options);
            var comentario = new Comentario
            {
                NomeUsuario = "NovoUsuarioDaClasseDeTeste",
                TextoComentario = "Texto a ser testado na classe de teste"
            };

            context.Comentarios.Add(comentario);
            await context.SaveChangesAsync();

            var comentarioSalvo = await context.Comentarios.FirstOrDefaultAsync(c => c.NomeUsuario == "NovoUsuarioDaClasseDeTeste");
            Assert.NotNull(comentarioSalvo);
            Assert.Equal("Texto a ser testado na classe de teste", comentarioSalvo.TextoComentario);
        }
    }
}
