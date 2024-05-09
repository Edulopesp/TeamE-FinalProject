using System.ComponentModel.DataAnnotations;

namespace TeamE_Project.Models
{
    public class Formador
    {
        [Key]

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; } 
    }
}
