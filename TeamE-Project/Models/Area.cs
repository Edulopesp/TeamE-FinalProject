using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamE_Project.Models
{
    public class Area
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CodigoArea { get; set; }

        [Required]
        public string Designacao { get; set; }
    }
}
