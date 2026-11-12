using System.ComponentModel.DataAnnotations;

namespace WebAPIBorrar.Data
{
    public class Usuarios
    {
        [Key]
        public int idUsuario { get; set; }

        public string? usuario { get; set; }

        public string? contrasena { get; set; }

        public string? estatus { get; set; }
    }
}
