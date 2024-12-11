using System.ComponentModel.DataAnnotations;

namespace Admibolsillo.Models.ViewModels
{
    public class RegistroViewModel
    {
        [Key]
        public int? Id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public required string Nombre { get; set; }

        [Display(Name = "Apellido")]
        public string? Apellido { get; set; }

        [Range(0, 120, ErrorMessage = "La edad debe estar entre 0 y 120 años.")]
        [Display(Name = "Edad")]
        public int? Edad { get; set; }

        [Display(Name = "Sexo")]
        public string? Sexo { get; set; }

        [Required]
        [Display(Name = "Correo Electrónico")]
        [EmailAddress(ErrorMessage = "Ingrese un correo válido.")]
        public required string Correo { get; set; }

        [Display(Name = "Celular")]
        [Phone(ErrorMessage = "Ingrese un número de celular válido.")]
        public int? Celular { get; set; }

        [Required]
        [Display(Name = "Documento")]
        public required int Documento { get; set; }

        [Display(Name = "Tipo de Usuario")]
        public string? IdTipoUsuario { get; set; }

        [Required]
        [Display(Name = "Contraseña")]
        [StringLength(20, ErrorMessage = "La contraseña no puede tener más de 20 caracteres.")]
        public required string Contrasena { get; set; }

        [Display(Name = "Foto de Perfil")]
        public string? Foto { get; set; }
    }
}
