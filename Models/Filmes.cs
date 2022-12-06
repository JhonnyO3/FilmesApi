namespace FilmesApi.Models
{

    using System.ComponentModel.DataAnnotations;


    public class Filmes
    {   
        [Required]
        public int Id {get; set;}

        [Required(ErrorMessage = "O titulo é obrigatorio!")]
        [MaxLength(100, ErrorMessage = "Tamanho maximo 100")]
        public string? Titulo { get; set; }
        [MaxLength(100, ErrorMessage = "Tamanho maximo 100")]
        [Required(ErrorMessage = "O Genero é obrigatorio!")]
        public string? Genero { get; set; }
        [Range(10, 300, ErrorMessage = "Tamanho entre 10 e 300!")]
        [Required(ErrorMessage = "A duracao é obrigatorio!")]
        public int Duracao { get; set; }


    }
}