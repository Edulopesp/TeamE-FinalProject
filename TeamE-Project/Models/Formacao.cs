using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamE_Project.Models
{
    public class Formacao
    {
        [Key]
        public int Id { get; set; }


        public int FormadorId { get; set; }

        public int ResponsavelId { get; set; }

        public int TipoId { get; set; }

   
        public int ProgramaId { get; set; }

        public int DescricaoId { get; set; }

        public int RegimeId { get; set; }

        public int DelegacaoId { get; set; }
        public int Horario { get; set; }
        public int Horas { get; set; }
        public DateOnly DataInicio { get; set; }
        public DateOnly DataFPCT { get; set; }
        public DateOnly DataFim { get; set; }
        public string Estado { get; set; }





    }
}
