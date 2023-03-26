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
    public class UsuariosBD
    {
        string cadena = "server=localhost;user=root; database=sistema_ticket; password=0801";

        public bool Insertar(Usuario user)
        {
            bool inserto = false;
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO usuarios VALUES");
                sql.Append("(@IdUsuario, @Nombre, @Contraseña, @Rol, @Activo,@FechaCreacion,@FechaNacimiento)");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@IdUsuario", MySqlDbType.VarChar, 15).Value = user.IdUsuario;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 100).Value = user.Nombre;
                        comando.Parameters.Add("@Contraseña", MySqlDbType.VarChar, 45).Value = user.Contraseña;
                        comando.Parameters.Add("@Rol", MySqlDbType.VarChar, 15).Value = user.Rol;
                        comando.Parameters.Add("@Activo", MySqlDbType.Bit).Value = user.Activo;
                        comando.Parameters.Add("@FechaCreacion", MySqlDbType.DateTime).Value = DateTime.Now;
                        comando.Parameters.Add("@FechaNacimiento", MySqlDbType.DateTime).Value = user.FechaNacimiento;
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

        public Usuario Autenticar(Login login)
        {
            Usuario user = null;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM usuarios WHERE IdUsuario = @IdUsuario AND Contraseña = @Contraseña;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@IdUsuario", MySqlDbType.VarChar, 15).Value = login.CodigoUsuario;
                        comando.Parameters.Add("@Contraseña", MySqlDbType.VarChar, 45).Value = login.Contraseña;

                        MySqlDataReader dr = comando.ExecuteReader();

                        if (dr.Read())
                        {
                            user = new Usuario();

                            user.IdUsuario = dr["IdUsuario"].ToString();
                            user.Nombre = dr["Nombre"].ToString();
                            user.Contraseña = dr["Contraseña"].ToString();
                            user.Activo = Convert.ToBoolean(dr["Activo"]);
                            user.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                            user.Rol = dr["Rol"].ToString();
                        }
                    }

                }

            }
            catch (System.Exception ex)
            {

            }
            return user;
        }

        public DataTable DevolverUsuario()
        {
            DataTable datatable = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM usuarios");


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

        public bool Editar(Usuario user)
        {
            bool edito = false;
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE usuarios SET ");
                sql.Append(" Nombre = @Nombre, Contraseña = @Contraseña, Rol = @Rol,Activo = @Activo,FechaNacimiento = @FechaNacimiento");
                sql.Append(" WHERE IdUsuario = @IdUsuario;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@IdUsuario", MySqlDbType.VarChar, 15).Value = user.IdUsuario;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 100).Value = user.Nombre;
                        comando.Parameters.Add("@Contraseña", MySqlDbType.VarChar, 45).Value = user.Contraseña;
                        comando.Parameters.Add("@Rol", MySqlDbType.VarChar, 15).Value = user.Rol;
                        comando.Parameters.Add("@Activo", MySqlDbType.Bit).Value = user.Activo;
                        comando.Parameters.Add("@FechaNacimiento", MySqlDbType.DateTime).Value = user.FechaNacimiento;

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
                sql.Append(" DELETE FROM usuarios ");
                sql.Append(" WHERE IdUsuario = @IdUsuario ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@IdUsuario", MySqlDbType.VarChar, 50).Value = CodigoUsuario;
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

    }
}
