using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public string IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }

        public Cliente()
        {
        }

        public Cliente(string idCliente, string nombre, string telefono, string correo, string direccion)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
        }
    }
}
