using MiniSupermarket.BUS;
using MiniSupermarket.DAO;
using MiniSupermarket.ImageAndFont;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MiniSupermarket.BUS
{
    internal class RoleBUS
    {
        private DataTable role;
        private DataTable roleFunction;

        public RoleBUS() 
        {
            role = getAllRole();
            updateRoleFunction();
        }

        public DataTable getAllRole()
        {
            string storedProcedureName = "SelectAllFromRole";
            return Connection.Execute(storedProcedureName, null);
        }

        public DataTable getAllRoleToDisplay()
        {
            DataTable filteredTable = role.Select("isDeleted = 1").CopyToDataTable();
            filteredTable.Columns.Remove("isDeleted");
            return filteredTable;
        }

        public void updateRoleFunction()
        {
            string storedProcedureName = "SelectAllFunctionAndRoleID";
            roleFunction = Connection.Execute(storedProcedureName, null);
        }

        public bool checkIdExist(string id)
        {
            foreach (DataRow row in role.Rows)
            {
                if (row["RoleID"].ToString() == id)
                {
                    return true;
                }
            }
            return false;
        }

        private string generateNewID()
        {
            int i = 1;
            string id;
            int maxAttempts = 1000;

            while (i <= maxAttempts)
            {
                id = "R" + i.ToString("D4");
                if (!checkIdExist(id))
                {
                    return id;
                }
                ++i;
            }
            throw new Exception("Không thể tạo ID mới sau " + maxAttempts + " lần thử.");
        }

        public bool addRole(string name, string description)
        {
            string id = generateNewID();

            string storedProcedureName = "InsertIntoRole";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@RoleID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@Description", description),
            };

            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);

            // Nếu thêm thành công thì sẽ cập nhật lại danh sách
            if (result)
            {
                role = getAllRole();
            }
            return result;
        }

        public bool deleteRole(string id)
        {
            string storedProcedureName = "DeleteRole";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@RoleID", id)
            };
            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);
            // Nếu xóa thành công thì cập nhật lại danh sách
            if (result)
            {
                role = getAllRole();
            }
            return result;
        }

        public bool editRole(string id, string name, string description)
        {
            string storedProcedureName = "EditRole";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@RoleID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@Description", description),
            };
            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);
            // Nếu cập nhật thành công thì cập nhật lại danh sách
            if (result)
            {
                role = getAllRole();
            }
            return result;
        }

        public List<string> selectFunctionFromRoleID(string roleID)
        {
            List<string> functions = new List<string>();
            DataRow[] selectedRows = roleFunction.Select($"RoleID = '{roleID}'");
            foreach (DataRow row in selectedRows)
            {
                functions.Add(row["Name"].ToString() + string.Empty);
            }
            return functions;
        }

        // Xóa các chức năng của quyền
        public bool deleteFunctionFromRoleID(string id)
        {
            string storedProcedureName = "DeleteFunctionFromRoleID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@RoleID", id)
            };
            // Nếu xóa chức năng từ quyền thành công thì cập nhật lại danh sách
            if (Connection.ExecuteNonQuery(storedProcedureName, parameters))
            {
                updateRoleFunction();
                return true;
            }
            return false;
        }

        // Thêm các chức năng vào quyền
        public bool insertIntoRoleFunction(string id, string function)
        {
            string storedProcedureName = "InsertIntoRoleFunction";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@RoleID", id),
                new SqlParameter("@FunctionID", function)
            };
            // Nếu thêm chức năng từ quyền thành công thì cập nhật lại danh sách
            if (Connection.ExecuteNonQuery(storedProcedureName, parameters))
            {
                updateRoleFunction();
                return true;
            }
            return false;
        }

        // Lấy quyền từ mã nhân viên
        public string SelectRoleIDFromEmployeeID(string employeeId)
        {
            string result = "";
            string storedProcedureName = "SelectRoleIDFromEmployeeID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeID", employeeId)
            };
            DataTable dt = Connection.Execute(storedProcedureName, parameters);
            if (dt != null)
            {
                result = dt.Rows[0][0].ToString() + string.Empty;
            }
            return result;
        }
    }
}

