using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MiniSupermarket.DAO {
    internal static class Connection {
        private static string serverName = "DESKTOP-21211J2";
        private static string databaseName = "MarketMiniManager";

        private static string connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(connectionString);
        public static SqlConnection GetConnection() {
            return connection;
        }

        // Câu lệnh lấy dữ liệu
        public static DataTable Execute(string sql) {
            // Tạo đối tượng DataTable
            DataTable table = new DataTable();
            try {
                // Mở kết nối
                connection.Open();
                // Tạo đối tượng SqlCommand
                using (SqlCommand command = new SqlCommand(sql, connection)) {
                    // Tạo đối tượng SqlDataAdapter
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command)) {
                        // Đổ dữ liệu vào DataTable
                        adapter.Fill(table);
                    }
                }
            } catch (Exception ex) {
                // Xử lý lỗi
                MessageBox.Show(ex.Message);
            } finally {
                // Đảm bảo đóng kết nối
                connection.Close();
            }
            return table;
        }

        // Câu lệnh update, delete, insert
        public static bool ExecuteNonQuery(string sql) {
            bool flag = true;
            try {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connection)) {
                    cmd.ExecuteNonQuery();
                }
            } catch (Exception ex) {
                // Xử lý lỗi
                MessageBox.Show(ex.Message);
                flag = false;
            } finally {
                // Đảm bảo đóng kết nối
                connection.Close();
            }
            return flag;
        }

        // Câu lệnh lấy dữ liệu theo stored procedure
        public static DataTable Execute(string sql, params SqlParameter[] parameters) {
            DataTable table = new DataTable();
            try {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection)) {
                    command.CommandType = CommandType.StoredProcedure;
                    if (parameters != null) {
                        command.Parameters.AddRange(parameters);
                    }
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command)) {
                        adapter.Fill(table);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                connection.Close();
            }
            return table;
        }

        // Câu lệnh update, delete, insert theo stored procedure
        public static bool ExecuteNonQuery(string sql, params SqlParameter[] parameters) {
            bool flag = true;
            try {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connection)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null) {
                        cmd.Parameters.AddRange(parameters);
                    }
                    cmd.ExecuteNonQuery();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                flag = false;
            } finally {
                connection.Close();
            }
            return flag;
        }

        public static object ExecuteScalar(string sql, params SqlParameter[] parameters) {
            object result = null;
            try {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection)) {
                    if (parameters != null) {
                        command.Parameters.AddRange(parameters);
                    }
                    result = command.ExecuteScalar();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                connection.Close();
            }
            return result;
        }
    }
}