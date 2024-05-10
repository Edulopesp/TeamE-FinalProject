using System.ComponentModel.DataAnnotations;

namespace TeamE_Project.Models
{
    public class Tipo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Designacao{ get; set; }

        public ICollection<Formacao> Formacoes { get; set; }

    }
}
