namespace AdmibolsilloN.Models
{
    public class Ingreso

    {
        public int IdIngreso { get; set; }
        public string NombrIngreso { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public int? IdUsuario { get; set; }
        public int Monto { get; set; }
        public string Fecha { get; set; }
        public Usuario Usuario { get; set; }
    }
}
