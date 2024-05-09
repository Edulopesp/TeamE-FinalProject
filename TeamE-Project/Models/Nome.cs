using System.ComponentModel.DataAnnotations;

namespace TeamE_Project.Models
{
    public class Nome
    {
        [Key]

        public int Id { get; set; }
        public string Designacao { get; set; }


    }
}
