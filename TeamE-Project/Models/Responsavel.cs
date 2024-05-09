using System.ComponentModel.DataAnnotations;

namespace TeamE_Project.Models
{
    public class Responsavel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public  int Telefone { get; set; }
        public string Email { get; set; }
    }
}
