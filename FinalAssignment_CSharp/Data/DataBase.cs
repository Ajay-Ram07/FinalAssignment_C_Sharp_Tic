using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment_CSharp.Data
{
    internal static class DataBase
    {
        private static string connectionString = "Data Source=uniComTic.db;Version=3";
        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }
    }
}
