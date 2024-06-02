using DBLayer;
using Zadaca_03.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zadaca_03.Repository
{
    public class BusRepository
    {


        public static Bus GetBus(int id_bus)
        {
            Bus bus = null;
            string sql = $"SELECT * FROM Bus WHERE Id_bus = {id_bus}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                bus = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return bus;
        }

        public static List<Bus> GetBuses()
        {
            List<Bus> busList = new List<Bus>();
            string sql = "SELECT * FROM Bus";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Bus bus = CreateObject(reader);
                busList.Add(bus);

            }
            reader.Close();
            DB.CloseConnection();

            return busList;
        }

        private static Bus CreateObject(SqlDataReader reader)
        {
            int id_bus = int.Parse(reader["Id_bus"].ToString());
            string vozac = reader["Vozac"].ToString();
            string linija = reader["Linija"].ToString();
            string status = reader["Status"].ToString();
            string naziv = reader["Naziv"].ToString();

            var bus = new Bus
            {
                Id_bus = id_bus,
                Vozac = vozac,
                Linija = linija,
                Status = status,
                Naziv = naziv,
            };

            return bus;
        }
        public static void AddBus(Bus bus)
        {
            string sql = $"INSERT INTO Bus (Id_bus, Vozac, Linija, Status, Naziv) VALUES ({bus.Id_bus}, '{bus.Vozac}', '{bus.Linija}', '{bus.Status}', '{bus.Naziv}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void UpdateBus(Bus bus)
        {
            string sql = $"UPDATE Bus SET Vozac = '{bus.Vozac}', Linija = '{bus.Linija}', Status = '{bus.Status}', Naziv = '{bus.Naziv}' WHERE Id_bus = {bus.Id_bus}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void DeleteBus(int id_bus)
        {
            string sql = $"DELETE FROM Bus WHERE Id_bus = {id_bus}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}