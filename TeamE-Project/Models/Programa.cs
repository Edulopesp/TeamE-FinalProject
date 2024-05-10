using System.ComponentModel.DataAnnotations;

namespace TeamE_Project.Models
{
    public class Programa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CodigoPrograma { get; set; }

        [Required]
        public string Designacao { get; set; }

        public ICollection<Formacao> Formacoes { get; set; }
    }
}
