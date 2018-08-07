using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MelhorPrecoSempreIT.Models
{
    [Table("SIT_Usuarios")]
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }

        [MaxLength(60)]
        public string LoginUsuario { get; set; }

        [MaxLength(32), MinLength(8)]
        public string SenhaUsuario { get; set; }
    }
}