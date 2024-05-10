using MiniSupermarket.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarket.BUS
{
    internal class PurchaseOrderBUS
    {
        private DataTable purchaseOrders;

        public DataTable getPurchaseOrders(string employeeID)
        {
            string storedProcedure = "SelectAllPurchaseOrder";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeID",employeeID)
            };
            purchaseOrders = Connection.Execute(storedProcedure, parameters);

            if (purchaseOrders != null )
            {
                DataTable orderClone = purchaseOrders.Clone();
                orderClone.Columns[5].DataType = typeof(Boolean);

                foreach (DataRow row in purchaseOrders.Rows)
                {
                    orderClone.ImportRow(row);
                }
                purchaseOrders = orderClone;
            }

            return purchaseOrders;
        }


        public DataTable getAllOrders()
        {
            string storedProcedure = "SelectAllOrders";
            DataTable purchaseOrders = Connection.Execute(storedProcedure, null);
            return purchaseOrders;
        }

        public DataTable getSuppliers()
        {
            string sql = "SELECT SupplierID, Name From Supplier Where isDeleted = 1";
            DataTable dt = Connection.Execute(sql);
            return dt;
        }

        public Boolean checkExistedID(string id)
        {
            purchaseOrders = getAllOrders();
            foreach (DataRow row in purchaseOrders.Rows)
            {
                if (id.Equals(row["OrderID"].ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        public string createNewOrderID()
        {
            string id = "";
            int currentID = 1;
            while (true)
            {
                id = "PO" + currentID.ToString("D4");
                if (!checkExistedID(id))
                {
                    break;
                }
                ++currentID;
            }
            return id;
        }

        public Boolean InsertPurchaseOrder( string SupplierID)
        {
            string storedProcedure = "InsertPurchaseOrder";
            string ID = createNewOrderID();
            string EmployeeID = GlobalState.employeeId;
            DateTime currentDate = DateTime.Now;
            string date = String.Format("{0:dd/MM/yyyy}", currentDate);
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID",ID),
                new SqlParameter("@EmployeeID",EmployeeID),
                new SqlParameter("@SupplierID",SupplierID),
                new SqlParameter("@importDate",currentDate),
                new SqlParameter("@TotalPrice",'0')
            };
            return Connection.ExecuteNonQuery(storedProcedure,parameters);
        }

        public Boolean UpdatePurchaseOrder(string OrderID, string SupplierID)
        {
            string storedProcedure = "UpdatePurchaseOrder";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID",OrderID),
                new SqlParameter("@SupplierID",SupplierID)
            };
            return Connection.ExecuteNonQuery(storedProcedure, parameters);
        }

        public Boolean DeletePurchaseOrder( string OrderID )
        {
            string storedProcedure = "DeletePurchaseOrder";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID",OrderID)
            };
            return Connection.ExecuteNonQuery(storedProcedure, parameters);
        }

        public string GetSupplierIDByName(string Name)
        {
            string storedProcedure = "GetSupplierIDByName";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name",Name)
            };
            return Connection.Execute(storedProcedure, parameters).Rows[0].ItemArray[0].ToString();
        }

        public Boolean ClearAllProductInDetailOrder(string OrderID)
        {
            string storedProcedure = "ClearAllProductInDetailOrder";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID",OrderID)
            };
            return Connection.ExecuteNonQuery(storedProcedure, parameters);
        }

        public DataTable getListExportTextFile(string OrderID)
        {
            string storedProcedure = "ExportTextFileOrder";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID",OrderID)
            };
            return Connection.Execute(storedProcedure, parameters);
        }

        public Boolean ExportTextFile(string filename,string OrderID, string EmployeeName, string SupplierName, string DateImport, string TotalPrice)
        {
            FileStream fileStream = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileStream);
            writer.WriteLine("                                   PHIẾU NHẬP                                  ");
            writer.WriteLine();
            writer.WriteLine("Mã phiếu nhập: "+OrderID);
            writer.WriteLine("Đơn vị bán: "+SupplierName);
            writer.WriteLine("Đơn vị mua: "+EmployeeName);
            writer.WriteLine("Ngày nhập: "+DateImport);

            writer.WriteLine();
            writer.WriteLine(String.Format("{0,10}| {1,10}| {2,10}| {3,10}| {4,10}","Mã sản phẩm","Tên sản phẩm","Đơn vị","Số lượng","Giá mua"));

            DataTable dataTable = getListExportTextFile(OrderID);
            foreach (DataRow row in dataTable.Rows)
            {
                writer.WriteLine(String.Format("{0,10}| {1,10}| {2,10}| {3,10}| {4,10}", row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString()));
            }
            writer.WriteLine();
            writer.WriteLine("                                         Tổng giá: "+TotalPrice);
            writer.WriteLine("                                         Thanh toán: "+TotalPrice);
            writer.Close();
            fileStream.Close();
            return true;
        }
    }
}
