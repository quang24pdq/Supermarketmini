using MiniSupermarket.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MiniSupermarket.BUS
{
    internal class UserAccountBUS
    {
        public DataTable getInforFromAccount(string username)
        {
            string procedureName = "SelectInfoFromAccount";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@userName",username)
            };

            return Connection.Execute(procedureName, parameters);
        }

        public bool updateAccountInfor(string employeeID, string address, string phoneNumber, string email)
        {
            string procedureName = "UpdateAccountInfor";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeId", employeeID),
                new SqlParameter("@address", address),
                new SqlParameter("@phone", phoneNumber),
                new SqlParameter("@email", email)
            };

            return Connection.ExecuteNonQuery(procedureName, parameters);
        }

        public bool updateAccountPassword(string employeeID, string password)
        {
            string procedureName = "UpdateAccountPassword";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeId", employeeID),
                new SqlParameter("@Password", password)
            };

            return Connection.ExecuteNonQuery(procedureName, parameters);
        }
    }
}
