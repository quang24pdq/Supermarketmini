using MiniSupermarket.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace MiniSupermarket.BUS
{
    internal class EmployeeBUS
    {
        private DataTable employee;
        public EmployeeBUS()
        {
            employee = getAllEmployee();
        }

        public DataTable getAllEmployee()
        {
            string storedProcedureName = "SelectAllFromEmployee";
            return Connection.Execute(storedProcedureName, null);
        }

        public bool checkIdExist(string id)
        {
            string query = "SELECT COUNT(*) FROM dbo.Employee WHERE EmployeeID = @EmployeeID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeID", id)
            };

            int count = (int)Connection.ExecuteScalar(query, parameters);

            return count > 0;
        }

        private string generateNewID()
        {
            int i = 1;
            string id;
            int maxAttempts = 1000;

            while (i <= maxAttempts)
            {
                id = "E" + i.ToString("D4");
                if (!checkIdExist(id))
                {
                    return id;
                }
                ++i;
            }
            throw new Exception("Không thể tạo ID mới sau " + maxAttempts + " lần thử.");
        }

        public static void Reset(Control.ControlCollection infocontrols, DataGridView dataGridView, Control.ControlCollection functionControls)
        {
            foreach (Control control in infocontrols)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = string.Empty;
                }
                else if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                    {
                        comboBox.SelectedIndex = 0; 
                    }
                }
            }

            foreach (Control control in functionControls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = string.Empty;
                }
                else if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                    {
                        comboBox.SelectedIndex = 0; 
                    }
                }
            }

            dataGridView.ClearSelection();
        }



        public bool addEmployee(string id, string username, string name, string address, string pnumber, string email, DateTime birthdate, string password, string sex, string roleid)
        {
            if (string.IsNullOrEmpty(id))
            {
                id = generateNewID();
            }

            string storedProcedureName = "InsertIntoEmployee";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@Address", address),
                new SqlParameter("@PhoneNumber", pnumber),
                new SqlParameter("@Email", email),
                new SqlParameter("@Sex",sex),
                new SqlParameter("@BirthDate", birthdate),
                new SqlParameter("@Password", password),
                new SqlParameter("@UserName", username),
                new SqlParameter("@RoleID", roleid),

            };

            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);

            // Nếu thêm thành công thì sẽ cập nhật lại danh sách
            if (result)
            {
                employee = getAllEmployee();
            }
            return result;
        }

        public bool deleteEmployee(string id)
        {
            string storedProcedureName = "DeleteEmployee";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeID", id)
            };
            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);
            // Nếu xóa thành công thì cập nhật lại danh sách
            if (result)
            {
                employee = getAllEmployee();
            }
            return result;
        }

        public bool editEmployee(string id, string name, string address, string pnumber, string email, string sex, DateTime birthdate, string password, string username, string roleid)
        {
            string storedProcedureName = "EditEmployee";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@Address", address),
                new SqlParameter("@PhoneNumber", pnumber),
                new SqlParameter("@Email", email),
                new SqlParameter("@Sex",sex),
                new SqlParameter("@BirthDate", birthdate),
                new SqlParameter("@Password", password),
                new SqlParameter("@UserName", username),
                new SqlParameter("@RoleID", roleid),
            };
            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);
            // Nếu cập nhật thành công thì cập nhật lại danh sách
            if (result) 
            {
                employee = getAllEmployee();
            }
            return result;
        }

        public DataTable SearchEmployeeByID(string id)
        {
            string storedProcedureName = "SearchEmployeeByID";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@SearchTerm", id)
            };

            return Connection.Execute(storedProcedureName, parameters);
        }

        public DataTable SearchEmployeeByName(string name)
        {
            string storedProcedureName = "SearchEmployeeByName";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@SearchTerm", name)
            };

            return Connection.Execute(storedProcedureName, parameters);
        }

        public DataTable GetRoles()
        {
            string storedProcedureName = "GetRoles";
            SqlParameter[] parameters = new SqlParameter[] { };


            return Connection.Execute(storedProcedureName, parameters);

        }

    }
}
