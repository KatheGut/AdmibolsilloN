using System.ComponentModel.DataAnnotations;
namespace AdmibolsilloN.Models
{
    public class Gastos
    {
        [Key]
        public int IdGasto { get; set; }
        public string NombreGasto { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public int? IdUsuario { get; set; } 
        public int Monto { get; set; }
        public string Fecha { get; set; } = string.Empty;
        public Usuario Usuario { get; set; } 

    }
   
}
