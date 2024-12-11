namespace AdmibolsilloN.Models

{

    public class Usuario
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int Edad { get; set; }
        public string? Sexo { get; set; }
        public string? Correo { get; set; }
        public int Celular { get; set; }
        public int Documento { get; set; }
        public string? Contrasena { get; set; }
        public int? IdTipoUsuario { get; set; }
        public string? Foto { get; set; }
        public Usuario()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            Sexo = string.Empty;
            Correo = string.Empty;
         
            Contrasena = string.Empty;
            Foto = string.Empty;
        }
    }

}

