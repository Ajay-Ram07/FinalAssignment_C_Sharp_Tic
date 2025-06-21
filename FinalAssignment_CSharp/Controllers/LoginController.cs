using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalAssignment_CSharp.Models;

namespace FinalAssignment_CSharp.Controllers
{
    public class LoginController
    {
        private SQLiteConnection connection;

        public LoginController(SQLiteConnection conn)
        {
            connection = conn;
        }

        public User Authenticate(string email, string password, string role)
        {
            string query = "SELECT * FROM users WHERE email = @Email AND password = @Password AND role = @Role"; 
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Role", role);

            connection.Open();
            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                var user = new User
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Name = reader["name"].ToString(),
                    Email = reader["email"].ToString(),
                    Password = reader["password"].ToString(),
                    Role = reader["role"].ToString()
                };
                connection.Close();
                return user;
            }

            connection.Close();
            return null;
        }
    }
}
