using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogWebApplication.Models
{
    [Table("Comentarios")] // Define a classe comentario como objetos da tabela comentários
    public class Comentario
    {
        [Key] // Número inteiro que servirá como chave primária da tabela
        public int ComentarioId { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho máximo do nome são 100 caracteres")]
        [Display(Name = "Seu nome aqui")]
        public string NomeUsuario { get; set; }

        [StringLength(500, ErrorMessage = "O tamanho máximo do comentário é de 500 caracteres")]
        [Display(Name = "Insira seu comentário")]
        public string TextoComentario { get; set; }
    }
}
