using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamE_Project.Models
{
    public class Nome
    {
        [Key]
        public int Id { get; set; }

        public int AreaId { get; set; }
        public string DesignacaoCurso { get; set; }


    }
}
