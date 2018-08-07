using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelhorPrecoSIT
{
    public class Pratos
    {
        public int PratoId { get; set; }

        public string NomeRestaurante { get; set; }

        public string NomePrato { get; set; }

        public string DescricaoPrato { get; set; }

        public decimal ValorPratoDe { get; set; }

        public decimal ValorPratoPara { get; set; }

        public bool Ativo { get; set; }
    }
}
