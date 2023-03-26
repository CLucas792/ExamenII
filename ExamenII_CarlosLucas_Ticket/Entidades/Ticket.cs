using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ticket
    {
        public int IdTicket { get; set; }
        public DateTime FechaApertura { get; set; }
        public string IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string IdUsuario { get; set; }
        public string Estado { get; set; }
        public string TipoSoporte { get; set; }
        public string DescripcionSolicitud { get; set; }
        public string DescripcionRespuesta { get; set; }
        public decimal precio { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public bool Pagado { get; set; }

        public Ticket()
        {
        }

        public Ticket(int idTicket, DateTime fechaApertura, string idCliente, string nombreCliente, string idUsuario, string estado, string tipoSoporte, string descripcionSolicitud, string descripcionRespuesta, decimal precio, decimal impuesto, decimal descuento, decimal total, bool pagado)
        {
            IdTicket = idTicket;
            FechaApertura = fechaApertura;
            IdCliente = idCliente;
            NombreCliente = nombreCliente;
            IdUsuario = idUsuario;
            Estado = estado;
            TipoSoporte = tipoSoporte;
            DescripcionSolicitud = descripcionSolicitud;
            DescripcionRespuesta = descripcionRespuesta;
            this.precio = precio;
            Impuesto = impuesto;
            Descuento = descuento;
            Total = total;
            Pagado = pagado;
        }
    }

}
