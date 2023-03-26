using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public string IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Usuario()
        {
        }

        public Usuario(string idUsuario, string nombre, string contraseña, string rol, bool activo, DateTime fechaCreacion, DateTime fechaNacimiento)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Contraseña = contraseña;
            Rol = rol;
            Activo = activo;
            FechaCreacion = fechaCreacion;
            FechaNacimiento = fechaNacimiento;
        }
    }
}
