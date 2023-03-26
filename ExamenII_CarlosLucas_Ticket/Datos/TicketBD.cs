

using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Datos
{
    public class TicketBD
    {
        string cadena = "server=localhost;user=root; database=sistema_ticket; password=0801";

        public bool Insertar(Ticket ticket)
        {
            int idFactura;
            bool inserto = false;
            try
            {

                StringBuilder sql = new StringBuilder();
                StringBuilder sql1 = new StringBuilder();
                sql.Append("INSERT INTO ticket VALUES");
                sql.Append("(@Id, @FechaApertura, @IdCliente, @NombreCliente, @IdUsuario,@Estado,@TipoSoporte,@DescripcionSolicitud,@DescripcionRespuesta,@Precio,@Impuesto,@Descuento,@Total,@Pagado ); ");
                sql1.Append(" SELECT MAX(IdTicket) FROM  ticket");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando1 = new MySqlCommand(sql1.ToString(), _conexion))
                    {
                        idFactura = Convert.ToInt32(comando1.ExecuteScalar());
                    }
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Id", MySqlDbType.Int32).Value = idFactura + 1;
                        comando.Parameters.Add("@FechaApertura", MySqlDbType.DateTime).Value = ticket.FechaApertura;
                        comando.Parameters.Add("@IdCliente", MySqlDbType.VarChar, 20).Value = ticket.IdCliente;
                        comando.Parameters.Add("@NombreCliente", MySqlDbType.VarChar, 100).Value = ticket.NombreCliente;
                        comando.Parameters.Add("@IdUsuario", MySqlDbType.VarChar, 20).Value = ticket.IdUsuario;
                        comando.Parameters.Add("@Estado", MySqlDbType.VarChar, 20).Value = ticket.Estado;
                        comando.Parameters.Add("@TipoSoporte", MySqlDbType.VarChar, 100).Value = ticket.TipoSoporte;
                        comando.Parameters.Add("@DescripcionSolicitud", MySqlDbType.VarChar, 300).Value = ticket.DescripcionSolicitud;
                        comando.Parameters.Add("@DescripcionRespuesta", MySqlDbType.VarChar, 300).Value = ticket.DescripcionRespuesta;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = ticket.precio;
                        comando.Parameters.Add("@Impuesto", MySqlDbType.Decimal).Value = ticket.Impuesto;
                        comando.Parameters.Add("@Descuento", MySqlDbType.Decimal).Value = ticket.Descuento;
                        comando.Parameters.Add("@Total", MySqlDbType.Decimal).Value = ticket.Total;
                        comando.Parameters.Add("@Pagado", MySqlDbType.Bit).Value = ticket.Pagado;

                        comando.ExecuteNonQuery();

                        inserto = true;
                    }

                }
            }
            catch
            {

            }
            return inserto;

        }

        public DataTable MostrarTicketsNuevos()
        {
            DataTable datatable = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM ticket WHERE Estado = 'Nuevo' ");


                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        MySqlDataReader dr = comando.ExecuteReader();
                        datatable.Load(dr);

                    }

                }
            }
            catch
            {

            }
            return datatable;
        }

        public bool Actualizar(Ticket ticket)
        {
            int idFactura;
            bool inserto = false;
            try
            {

                StringBuilder sql = new StringBuilder();

                sql.Append(" UPDATE ticket SET ");
                sql.Append(" Estado = @Estado, DescripcionRespuesta = @DescripcionRespuesta, Precio = @Precio");
                sql.Append(" WHERE IdTicket = @IdTicket;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();

                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@IdTicket", MySqlDbType.Int32).Value = ticket.IdTicket;
                        comando.Parameters.Add("@Estado", MySqlDbType.VarChar, 20).Value = ticket.Estado;
                        comando.Parameters.Add("@DescripcionRespuesta", MySqlDbType.VarChar, 300).Value = ticket.DescripcionRespuesta;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = ticket.precio;
                        comando.ExecuteNonQuery();

                        inserto = true;
                    }

                }
            }
            catch
            {

            }
            return inserto;

        }

        public decimal DevolverTickerPorId(int id)
        {
            decimal precio = 0;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM ticket WHERE IdTicket = @IdTicket AND Estado = 'Atendido'");


                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@IdTicket", MySqlDbType.Int32).Value = id;
                        MySqlDataReader dr = comando.ExecuteReader();

                        if (dr.Read())

                            precio = Convert.ToDecimal(dr["Precio"]);

                    }

                }


            }
            catch
            {

            }
            return precio;
        }

        public bool ActualizarCaja(Ticket ticket)
        {
            bool inserto = false;
            try
            {

                StringBuilder sql = new StringBuilder();

                sql.Append(" UPDATE ticket SET ");
                sql.Append(" Descuento = @Descuento, Impuesto = @Impuesto, Total = @Total, Pagado = @Pagado ");
                sql.Append(" WHERE IdTicket = @IdTicket;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();

                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@IdTicket", MySqlDbType.Int32).Value = ticket.IdTicket;
                        comando.Parameters.Add("@Impuesto", MySqlDbType.Decimal).Value = ticket.Impuesto;
                        comando.Parameters.Add("@Descuento", MySqlDbType.Decimal).Value = ticket.Descuento;
                        comando.Parameters.Add("@Total", MySqlDbType.Decimal).Value = ticket.Total;
                        comando.Parameters.Add("@Pagado", MySqlDbType.Bit).Value = ticket.Pagado;
                        comando.ExecuteNonQuery();

                        inserto = true;
                    }

                }
            }
            catch
            {

            }
            return inserto;

        }
    }
}
