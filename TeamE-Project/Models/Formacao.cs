using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamE_Project.Models
{
    public class Formacao
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int FormadorId { get; set; }
        public Formador Formador { get; set; }

        [Required]
        public int ResponsavelId { get; set; }
        public Responsavel Responsavel { get; set; }

        [Required]
        public int TipoId { get; set; }
        public Tipo Tipo { get; set; }

        [Required]
        public int ProgramaId { get; set; }
        public Programa Programa { get; set; }

        [Required]
        public int NomeId { get; set; }
        public Nome Nome { get; set; }

        [Required]
        public int RegimeId { get; set; }
        public Regime Regime { get; set; }

        [Required]
        public int DelegacaoId { get; set; }
        public Cidade Delegacao { get; set;  }

        [Required]
        public string LocalId { get; set; }
        public Cidade Local { get; set; }

        [Required]
        public int Horario { get; set; }
        public int Horas { get; set; }

        [Required]
        public DateOnly DataInicio { get; set; }

        [Required]
        public DateOnly DataFPCT { get; set; }

        [Required]
        public DateOnly DataFim { get; set; }

        [Required]
        public string Estado { get; set; }





    }
}
