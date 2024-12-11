using System.ComponentModel.DataAnnotations;

namespace AdmibolsilloN.Models
{
    public class TipoUsuario
    {
        [Key]
        public int IdTipoUsuario { get; set; }
        public string Tipo { get; set; } = string.Empty;
    }
}




