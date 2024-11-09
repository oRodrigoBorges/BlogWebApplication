using BlogWebApplication.Models;
using Xunit;

namespace TestsBlogWebApplication.Tests.Tests.UnitTests
{
    public class ComentarioTests
    {
        [Fact]
        public void CriarComentario_DeveVerificarSeOComentarioEstaDentroDasRegrasDefinidasNaClasse()
        {
            var comentario = new Comentario
            {
                ComentarioId = 1,
                NomeUsuario = "Rodrigo C Borges",
                TextoComentario = "Campos do Jordão é um lugar que desejo visitar em um futuro próximo"
            };

            Assert.Equal(1, comentario.ComentarioId);
            Assert.Equal("Rodrigo C Borges", comentario.NomeUsuario);
            Assert.Equal("Campos do Jordão é um lugar que desejo visitar em um futuro próximo", comentario.TextoComentario);
        }
    }
}
