using Oracle.ManagedDataAccess.Client;
using System;

namespace QUANTRICSDL
{
    public static class DatabaseHelper
    {
        //Connection string có thể thay đổi theo máy của đại ca
        private static string connectionString =
            "User Id=C##ADMIN;Password=123;Data Source=localhost:1521/XEPDB1;";


        public static OracleConnection GetConnection()
        {
            OracleConnection conn = new OracleConnection(connectionString);
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception("Kết nối Oracle thất bại: " + ex.Message);
            }
        }

        // Optional: hàm kiểm tra kết nối
        public static bool TestConnection()
        {
            try
            {
                using (var conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
