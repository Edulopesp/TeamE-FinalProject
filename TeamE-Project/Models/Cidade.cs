using System.ComponentModel.DataAnnotations;

namespace TeamE_Project.Models
{
    public class Cidade
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Distrito { get; set; }

        [Required]
        public string Localidade { get; set; }

        public ICollection<Formacao> Formacoes { get; set; }

    }
}
