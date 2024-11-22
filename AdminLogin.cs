using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClinicaBD
{
    public class AdminLogin
    {
        private readonly string _connectionString;
        public AdminLogin(string connectionstring)
        {
            _connectionString = connectionstring;
        }

        public bool Login(string User, string Pass)
        {
            string queryString = "SELECT Username FROM AdminClinica WHERE Username = @Username AND Contraseña = HASHBYTES('SHA2_256', @Password)";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(queryString, connection))
                    {
                        //cmd.Parameters.AddWithValue("@Username", User);
                        //cmd.Parameters.AddWithValue("@Contraseña", Pass);
                        //cmd.CommandType = CommandType.Text;

                        cmd.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar) { Value = User });
                        cmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar) { Value = Pass });

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ControlAdmin.Username = reader.GetString(0);
                            }
                            return true;
                        }
                        else
                            return false;
                    }

                }

            }
            catch (Exception ex)
            {

                throw new Exception($"Error al obtener usuario de la base de datos {ex.Message}");
            }

        }
    }
}
