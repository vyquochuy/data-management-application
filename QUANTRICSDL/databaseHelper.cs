using Oracle.ManagedDataAccess.Client;
using System.Data;

public static class DatabaseHelper
{
    private static string connectionString = string.Empty;

    public static void SetConnectionString(string username, string password)
    {
        connectionString = $"User Id={username};Password={password};Data Source=localhost:1521/QLCSDL";
    }

    public static OracleConnection GetConnection()
    {
        return new OracleConnection(connectionString);
    }

    public static void ExecuteNonQuery(string sql)
    {
        using (var conn = GetConnection())
        {
            conn.Open();
            using (var cmd = new OracleCommand(sql, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }

    public static DataTable ExecuteQuery(string sql)
    {
        using (var conn = new OracleConnection(connectionString))
        {
            conn.Open();
            using (var cmd = new OracleCommand(sql, conn))
            {
                using (var adapter = new OracleDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }
}