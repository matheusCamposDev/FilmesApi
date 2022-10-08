using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "Tamanho máximo de 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 300, ErrorMessage = "Duração de 1 a 300 min")]
        public int Duracao { get; set; }
    }
}
