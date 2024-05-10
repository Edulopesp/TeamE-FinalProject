using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamE_Project.Models
{
    public class Nome
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int AreaId { get; set; }

        [Required]
        public string DesignacaoCurso { get; set; }


        public ICollection<Formacao> Formacoes { get; set; }
    }
}
