namespace AdmibolsilloN.Models
{
    public class Gastos
    {
        public int IdGasto { get; set; }
        public string NombreGasto { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public int? IdUsuario { get; set; }
        public int Monto { get; set; }
        public string Fecha { get; set; }
        public Usuario Usuario { get; set; }
    }
}
