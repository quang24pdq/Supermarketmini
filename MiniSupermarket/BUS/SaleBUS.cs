using MiniSupermarket.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace MiniSupermarket.BUS {
    internal class SaleBUS {
        // Chứa dữ liệu lấy lên từ database
        private static DataTable bills;
        // Chứa mã khác hàng và tên KH
        private static List<string> customers = new List<string>();

        public SaleBUS() {
            updateData();
        }

        public DataTable getAllBills() {
            // Lấy những bill chưa xóa
            updateBills();
            DataRow[] selectedRows = bills.Select("isDeleted = 1");
            DataTable newTable = selectedRows.CopyToDataTable();

            if (newTable.Columns.Contains("isDeleted")) {
                newTable.Columns.Remove("isDeleted");
            }

            return newTable;
        }

        public List<string> getCustomers() {
            return customers;
        }

        // Cập nhật danh sách bill
        public void updateBills() {
            // Lấy hết tất cả bill kể cả những bill đã xóa
            string procedureName = "SelectAllBills";

            bills = Connection.Execute(procedureName, null);

            // Nếu bills có dữ liệu
            if (bills != null) {
                // Clone DataTable
                DataTable dtCloned = bills.Clone();

                // Thay đổi kiểu dữ liệu của cột
                dtCloned.Columns["Status"].DataType = typeof(bool);

                // Import dữ liệu từ DataTable cũ
                foreach (DataRow row in bills.Rows) {
                    dtCloned.ImportRow(row);
                }

                bills = dtCloned;
            }
        }
        // Cập nhật danh sách khách hàng
        public void updateCustomers() {
            string id, name;
            List<string> result = new List<string>();
            List<Customer> customers = CustomerBus.customerList;
            if (customers != null) {
                foreach (Customer cus in customers) {
                    id = cus.CustomerID;
                    name = cus.Name;
                    result.Add($"[{id}] {name}");
                }
            }

            SaleBUS.customers = result;
        }
        // Cập nhật tất cả dữ liệu cần thiết
        public void updateData() {
            updateBills();
            updateCustomers();
        }

        // Kiểm tra mã bill đã tồn tại trong bill chưa
        private bool checkBillExist(string billId) {
            foreach (DataRow row in bills.Rows) {
                if (row["BillID"].ToString() == billId) { return true; }
            }
            return false;
        }

        // Tạo mã mới cho bill
        private string generateBillID() {
            string id = "";
            int currentBillId = 1;
            while (true) {
                id = "B" + currentBillId.ToString("D4");
                if (!checkBillExist(id)) { break; }
                ++currentBillId;
            }
            return id;
        }

        // Thêm bill mới vào csdl
        public bool InsertIntoBill(string EmployeeId, string CustomerId, string date) {
            DataTable temp = bills;
            string storedProcudure = "InsertIntoBill";
            string billId = generateBillID();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@BillID", billId),
                new SqlParameter("@Date", date),
                new SqlParameter("@EmployeeID", EmployeeId),
                new SqlParameter("@CustomerID", CustomerId),
            };
            return Connection.ExecuteNonQuery(storedProcudure, parameters);
        }

        // Thêm khách hàng mới vào csld
        public bool InsertCustomerSale(string customerId, string name, string phone, string sex) {
            string procedure = "InsertCustomerSale";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CustomerID", customerId),
                new SqlParameter("@Name", name),
                new SqlParameter("@PhoneNumber", phone),
                new SqlParameter("@Sex", sex)
            };
            // Nếu thêm khách hàng thành công thì cập nhật danh sách khách hàng
            if (Connection.ExecuteNonQuery(procedure, parameters)) {
                customers.Add($"[{customerId}] {name}");
                return true;
            }
            return false;
        }

        // Xóa hóa đơn chưa thanh toán
        public bool DeleteBill(string billId) {
            string procedure = "DeleteBill";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@BillID", billId)
            };
            return Connection.ExecuteNonQuery(procedure, parameters);
        }



        //=============================Công Anh thêm====================================
        //Lấy những hóa đơn đã thanh toán
        public DataTable getAllBillsForStatus() {
            // Lấy những bill chưa xóa và có status = 1
            updateBills();
            DataRow[] selectedRows = bills.Select("isDeleted = 1 AND status = 1");
            DataTable newTable = new DataTable();
            if (selectedRows.Length > 0)
            {
                newTable = selectedRows.CopyToDataTable();

                if (newTable.Columns.Contains("isDeleted"))
                {
                    newTable.Columns.Remove("isDeleted");
                }
            }

            return newTable;
        }

        // Lấy các hóa đơn trong khoảng thời gian từ fromDate đến toDate
        public DataTable GetBillsByDateRange(DateTime fromDate, DateTime toDate) {
            string procedureName = "GetBillsByDateRange";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@FromDate", fromDate),
            new SqlParameter("@ToDate", toDate)
            };

            DataTable billsByDateRange = Connection.Execute(procedureName, parameters);
            return billsByDateRange;
        }
        //Tính tổng hóa đơn theo khoảng thời gian
        public decimal CalculateTotalRevenue(DataTable dataTable) {
            decimal totalRevenue = 0;

            if (dataTable != null && dataTable.Rows.Count > 0) {
                foreach (DataRow row in dataTable.Rows) {
                    decimal totalPrice = Convert.ToDecimal(row["TotalPrice"]);
                    totalRevenue += totalPrice;
                }
            }

            return totalRevenue;
        }
        //Tính hóa đơn cao nhất theo khoảng thời gian

        public decimal GetMaxTotalPrice(DataTable dataTable) {
            if (dataTable != null && dataTable.Rows.Count > 0) {
                decimal maxTotalPrice = Convert.ToDecimal(dataTable.Rows[0]["TotalPrice"]);

                foreach (DataRow row in dataTable.Rows) {
                    decimal totalPrice = Convert.ToDecimal(row["TotalPrice"]);
                    if (totalPrice > maxTotalPrice) {
                        maxTotalPrice = totalPrice;
                    }
                }

                return maxTotalPrice;
            }
            return 0;
        }
        //Tính hóa đơn thấp nhất theo khoảng thời gian
        public decimal GetMinTotalPrice(DataTable dataTable) {
            if (dataTable != null && dataTable.Rows.Count > 0) {
                decimal minTotalPrice = Convert.ToDecimal(dataTable.Rows[0]["TotalPrice"]);

                foreach (DataRow row in dataTable.Rows) {
                    decimal totalPrice = Convert.ToDecimal(row["TotalPrice"]);
                    if (totalPrice < minTotalPrice) {
                        minTotalPrice = totalPrice;
                    }
                }

                return minTotalPrice;
            }
            return 0;
        }
        //Tính tổng doanh thu hóa đơn
        public decimal CalculateTotalRevenueForAllBills() {
            decimal totalRevenue = 0;

            DataTable allBills = getAllBills();

            if (allBills != null && allBills.Rows.Count > 0) {
                foreach (DataRow row in allBills.Rows) {
                    decimal totalPrice = Convert.ToDecimal(row["TotalPrice"]);
                    totalRevenue += totalPrice;
                }
            }

            return totalRevenue;
        }
        //Tính hóa đơn cao nhất
        public decimal GetMaxTotalPriceForAllBills() {
            decimal maxTotalPrice = 0;

            DataTable allBills = getAllBills();

            if (allBills != null && allBills.Rows.Count > 0) {
                maxTotalPrice = Convert.ToDecimal(allBills.Rows[0]["TotalPrice"]);

                foreach (DataRow row in allBills.Rows) {
                    decimal totalPrice = Convert.ToDecimal(row["TotalPrice"]);
                    if (totalPrice > maxTotalPrice) {
                        maxTotalPrice = totalPrice;
                    }
                }
            }

            return maxTotalPrice;
        }
        //Tính hóa đơn thấp nhất
        public decimal GetMinTotalPriceForAllBills() {
            decimal minTotalPrice = 0;

            DataTable allBills = getAllBills();

            if (allBills != null && allBills.Rows.Count > 0) {
                minTotalPrice = Convert.ToDecimal(allBills.Rows[0]["TotalPrice"]);

                foreach (DataRow row in allBills.Rows) {
                    decimal totalPrice = Convert.ToDecimal(row["TotalPrice"]);
                    if (totalPrice < minTotalPrice) {
                        minTotalPrice = totalPrice;
                    }
                }
            }

            return minTotalPrice;
        }
        //lấy mã hóa đơn từ tổng tiền
        public string GetIDfromTotalPrice(decimal totalPrice) {
            foreach (DataRow row in bills.Rows) {
                // Nếu TotalPrice khớp với giá trị cần tìm, trả về BillID tương ứng
                if (Convert.ToDecimal(row["TotalPrice"]) == totalPrice) {
                    return row["BillID"].ToString();
                }
            }

            // Trường hợp không tìm thấy
            return "Không tìm thấy"; // hoặc có thể trả về một giá trị mặc định khác
        }

    }
}