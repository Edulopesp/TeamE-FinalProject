using System.ComponentModel.DataAnnotations;

namespace TeamE_Project.Models
{
    public class Utilizador
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public int Telefone { get; set; }
    }
}
