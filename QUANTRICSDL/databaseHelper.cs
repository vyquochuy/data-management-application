using Oracle.ManagedDataAccess.Client;
using System.Data;

public static class DatabaseHelper
{
    private static string connectionString = string.Empty;

    //Lưu username đang login để dùng ở các form khác
    public static string CurrentUsername { get; private set; } = "";

    public static void SetConnectionString(string username, string password)
    {
        connectionString = $"User Id={username};Password={password};Data Source=localhost:1521/QLCSDL";
        CurrentUsername = username.ToUpper(); // gán username đang dùng
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

    public static DataTable ExecuteQuery(string sql, params OracleParameter[] parameters)
    {
        using (var conn = GetConnection())
        {
            conn.Open();
            using (var cmd = new OracleCommand(sql, conn))
            {
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                using (var adapter = new OracleDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }

    // Thêm hàm ExecuteScalar để truy vấn đơn giản (dùng kiểm tra quyền)
    public static object ExecuteScalar(string sql)
    {
        using (var conn = GetConnection())
        {
            conn.Open();
            using (var cmd = new OracleCommand(sql, conn))
            {
                return cmd.ExecuteScalar();
            }
        }
    }
}
