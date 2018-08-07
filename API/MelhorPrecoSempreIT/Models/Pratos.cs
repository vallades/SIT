using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MelhorPrecoSempreIT.Models
{
    [Table("SIT_Pratos")]
    public class Pratos
    {
        [Key]
        public int PratoId { get; set; }

        public string NomeRestaurante { get; set; }

        public string NomePrato { get; set; }

        public string DescricaoPrato { get; set; }

        public decimal ValorPratoDe { get; set; }

        public decimal ValorPratoPara { get; set; }

        public bool Ativo { get; set; }
    }
}