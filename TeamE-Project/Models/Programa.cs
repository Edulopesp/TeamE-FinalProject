using System.ComponentModel.DataAnnotations;

namespace TeamE_Project.Models
{
    public class Programa
    {
        [Key]
        public int Id { get; set; }
        public int CodigoPrograma { get; set; }
        public string Designacao { get; set; }
    }
}
