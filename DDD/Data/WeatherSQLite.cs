using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using DDD.Common;

namespace DDD.Data
{
    public static class WeatherSQLite
    {
        public static DataTable GetLatest(int areaID)
        {
            string sql = CommonConst.sql;
            string ConnectionString = @"Data Source=C:\Users\bigdi\Desktop\STUDY\DDD\DB\DDD1.db";

            DataTable dt = new DataTable();
            using (var connection = new SQLiteConnection(ConnectionString))
            using (var command = new SQLiteCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("AreaID", areaID);
                using (var adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}
