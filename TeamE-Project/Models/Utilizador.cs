using System.ComponentModel.DataAnnotations;

namespace TeamE_Project.Models
{
    public class Utilizador
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public int Telefone { get; set; }
    }
}
