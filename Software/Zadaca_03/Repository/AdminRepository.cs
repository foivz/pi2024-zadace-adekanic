using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadaca_03.Models;

namespace Zadaca_03.Repository
{
    public class AdministratorRepository
    {
        public static Admin GetAdmin(string username)
        {
            Admin admin = null;
            string sql = $"SELECT * FROM Admin WHERE Username = '{username}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                admin = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return admin;
        }

        public static Admin GetAdmin(int id)
        {
            Admin admin = null;
            string sql = $"SELECT * FROM Admin WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                admin = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return admin;
        }

        private static Admin CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string username = reader["Username"].ToString();
            string password = reader["Password"].ToString();

            var admin = new Admin
            {
                Id = id,
                Username = username,
                Password = password
            };
            return admin;
        }
    }
}

