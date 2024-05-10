using MiniSupermarket.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MiniSupermarket.BUS
{
    internal class LoginBUS
    {
        public int countAccount(string username, string password)
        {
            string storedProcedureName = "CountAccount";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@userName", username),
                new SqlParameter("@Password", password)
            };
            try
            {
                return int.Parse(Connection.Execute(storedProcedureName, parameters).Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public List<string> getFunctionFromAccount(string username, string password)
        {
            string storedProcedureName = "SelectFunctionNameFromAccount";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@userName", username),
                new SqlParameter("@Password", password)
            };
            DataTable funcs = Connection.Execute(storedProcedureName, parameters);
            List<string> functions = new List<string>();
            foreach (DataRow row in funcs.Rows)
            {
                functions.Add(row[0].ToString());
            }
            return functions; 
        }
    }
}
