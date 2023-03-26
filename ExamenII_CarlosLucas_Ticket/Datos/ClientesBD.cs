using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClientesBD
    {
        string cadena = "server=localhost;user=root; database=sistema_ticket; password=0801";

        public bool Insertar(Cliente cliente)
        {
            bool inserto = false;
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO clientes VALUES");
                sql.Append("(@IdCliente, @Nombre, @Telefono, @Correo, @Direccion)");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@IdCliente", MySqlDbType.VarChar, 20).Value = cliente.IdCliente;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 100).Value = cliente.Nombre;
                        comando.Parameters.Add("@Telefono", MySqlDbType.VarChar, 25).Value = cliente.Telefono;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = cliente.Correo;
                        comando.Parameters.Add("@Direccion", MySqlDbType.VarChar, 100).Value = cliente.Direccion;
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

        public DataTable DevolverCliente()
        {
            DataTable datatable = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM clientes");


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

        public bool Editar(Cliente cliente)
        {
            bool edito = false;
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE clientes SET ");
                sql.Append(" Nombre = @Nombre, Telefono = @Telefono, Correo = @Correo,Direccion = @Direccion");
                sql.Append(" WHERE IdCliente = @IdCliente;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@IdCliente", MySqlDbType.VarChar, 20).Value = cliente.IdCliente;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 100).Value = cliente.Nombre;
                        comando.Parameters.Add("@Telefono", MySqlDbType.VarChar, 25).Value = cliente.Telefono;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = cliente.Correo;
                        comando.Parameters.Add("@Direccion", MySqlDbType.VarChar, 100).Value = cliente.Direccion;

                        comando.ExecuteNonQuery();
                        edito = true;
                    }

                }
            }
            catch (Exception ex)
            {

            }
            return edito;
        }

        public bool Eliminar(string CodigoUsuario)
        {
            bool elimino = false;
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM clientes ");
                sql.Append(" WHERE IdCliente = @IdCliente ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@IdCliente", MySqlDbType.VarChar, 20).Value = CodigoUsuario;
                        comando.ExecuteNonQuery();
                        elimino = true;
                    }

                }
            }
            catch
            {

            }
            return elimino;
        }

        public string TraerNombreCliente(string CodigoUsuario)
        {
            string nombre = "";
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT Nombre FROM clientes ");
                sql.Append(" WHERE IdCliente = @IdCliente ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@IdCliente", MySqlDbType.VarChar, 20).Value = CodigoUsuario;
                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            nombre = dr["Nombre"].ToString();
                        }
                    }

                }
            }
            catch
            {

            }

            return nombre;
        }

    }
}
