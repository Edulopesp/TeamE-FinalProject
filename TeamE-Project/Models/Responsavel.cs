using System.ComponentModel.DataAnnotations;

namespace TeamE_Project.Models
{
    public class Responsavel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Sobrenome { get; set; }

        [Required]
        public int Telefone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public ICollection<Formacao> Formacoes { get; set; }
    }
}
