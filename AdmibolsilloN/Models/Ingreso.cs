using System.ComponentModel.DataAnnotations;
namespace AdmibolsilloN.Models
{
    public class Ingreso

    {
        [Key]
        public int IdIngreso { get; set; }
        public string NombrIngreso { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public int? IdUsuario { get; set; }
        public int Monto { get; set; }
        public string Fecha { get; set; } = string.Empty;
        public Usuario Usuario { get; set; }
    }
}
