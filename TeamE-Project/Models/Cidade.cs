using System.ComponentModel.DataAnnotations;

namespace TeamE_Project.Models
{
    public class Cidade
    {
        [Key]

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Distrito { get; set; }

        public string Localidade { get; set; }


    }
}
