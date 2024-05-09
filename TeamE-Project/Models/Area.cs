using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamE_Project.Models
{
    public class Area
    {
        [Key]
        public int Id { get; set; }
        public string CodigoArea {get; set; }
        public string Designacao { get; set; }
    }
}
