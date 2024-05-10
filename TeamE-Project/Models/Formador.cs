using System.ComponentModel.DataAnnotations;

namespace TeamE_Project.Models
{
    public class Formador
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Sobrenome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public ICollection<Formacao> Formacoes { get; set; }
    }
}
