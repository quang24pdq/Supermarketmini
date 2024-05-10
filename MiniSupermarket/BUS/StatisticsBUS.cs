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
    internal class StatisticsBUS
    {
        // Chứa dữ liệu lấy lên từ database
        private DataTable billinfor;
        public StatisticsBUS()
        {
            billinfor = getAllBillInfors();
        }

        private DataTable getAllBillInfors()
        {
            string storedProcedureName = "SelectBillInformation";
            return Connection.Execute(storedProcedureName, null);
        }
        public DataTable getAllBillInfor()
        {
            return getAllBillInfors();
        }
        //lấy tên nhân viên từ mã nhân viên
        public string GetNameFromId(string id)
        {
            foreach (DataRow row in billinfor.Rows)
            {
                // Nếu TypeID khớp với ID cần tìm, trả về Name tương ứng
                if (row["EmployeeID"].ToString().Equals(id, StringComparison.OrdinalIgnoreCase))
                {
                    return row["EmployeeName"].ToString();
                }
            }

            // Trường hợp không tìm thấy
            return "Không tìm thấy"; // hoặc có thể trả về một giá trị mặc định khác
        }
        //Lấy các hóa đơn với nhân viên làm chính khoảng thời gian từ fromDate đến toDate
        public DataTable GetEmployEEsByDateRange(DateTime fromDate, DateTime toDate)
        {
            string procedureName = "GetEmployEEsByDateRange";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@FromDate", fromDate),
            new SqlParameter("@ToDate", toDate)
            };

            DataTable billsByDateRange = Connection.Execute(procedureName, parameters);
            return billsByDateRange;
        }

        //nhân viên có doanh thu cao nhất 
        public string GetEmployeeWithMaxTotalSales()
        {
            DataTable allBills = getAllBillInfor();
            Dictionary<string, decimal> employeeSales = new Dictionary<string, decimal>();

            if (allBills != null && allBills.Rows.Count > 0)
            {
                foreach (DataRow row in allBills.Rows)
                {
                    string employeeID = row["EmployeeID"].ToString();
                    decimal totalPrice = Convert.ToDecimal(row["TotalPrice"]);

                    if (employeeSales.ContainsKey(employeeID))
                    {
                        employeeSales[employeeID] += totalPrice;
                    }
                    else
                    {
                        employeeSales.Add(employeeID, totalPrice);
                    }
                }

                // Tìm nhân viên có tổng doanh thu cao nhất
                string employeeWithMaxSales = employeeSales.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

                return employeeWithMaxSales;
            }

            return null;
        }

        //nhân viên có doanh thu thấp nhất 
        public string GetEmployeeWithMinTotalSales()
        {
            DataTable allBills = getAllBillInfor();
            Dictionary<string, decimal> employeeSales = new Dictionary<string, decimal>();

            if (allBills != null && allBills.Rows.Count > 0)
            {
                foreach (DataRow row in allBills.Rows)
                {
                    string employeeID = row["EmployeeID"].ToString();
                    decimal totalPrice = Convert.ToDecimal(row["TotalPrice"]);

                    if (employeeSales.ContainsKey(employeeID))
                    {
                        employeeSales[employeeID] += totalPrice;
                    }
                    else
                    {
                        employeeSales.Add(employeeID, totalPrice);
                    }
                }

                // Tìm nhân viên có tổng doanh thu thấp nhất
                string employeeWithMinSales = employeeSales.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;

                return employeeWithMinSales;
            }

            return null;
        }
        //nhân viên có doanh thu cao nhất trong khoảng thời gian
        public string GetEmployeeWithMaxTotalSalesTIme(DateTime startDate, DateTime endDate)
        {
            DataTable billsInTimeFrame = GetEmployEEsByDateRange(startDate, endDate);
            Dictionary<string, decimal> employeeSales = new Dictionary<string, decimal>();

            if (billsInTimeFrame != null && billsInTimeFrame.Rows.Count > 0)
            {
                foreach (DataRow row in billsInTimeFrame.Rows)
                {
                    string employeeID = row["EmployeeID"].ToString();
                    decimal totalPrice = Convert.ToDecimal(row["TotalPrice"]);

                    if (employeeSales.ContainsKey(employeeID))
                    {
                        employeeSales[employeeID] += totalPrice;
                    }
                    else
                    {
                        employeeSales.Add(employeeID, totalPrice);
                    }
                }

                // Tìm nhân viên có tổng doanh thu cao nhất trong khoảng thời gian
                string employeeWithMaxSales = employeeSales.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

                return employeeWithMaxSales;
            }

            return null;
        }
        //nhân viên có doanh thu thấp nhất trong khoảng thời gian

        public string GetEmployeeWithMinTotalSalesTime(DateTime startDate, DateTime endDate)
        {
            DataTable billsInTimeFrame = GetEmployEEsByDateRange(startDate, endDate);
            Dictionary<string, decimal> employeeSales = new Dictionary<string, decimal>();

            if (billsInTimeFrame != null && billsInTimeFrame.Rows.Count > 0)
            {
                foreach (DataRow row in billsInTimeFrame.Rows)
                {
                    string employeeID = row["EmployeeID"].ToString();
                    decimal totalPrice = Convert.ToDecimal(row["TotalPrice"]);

                    if (employeeSales.ContainsKey(employeeID))
                    {
                        employeeSales[employeeID] += totalPrice;
                    }
                    else
                    {
                        employeeSales.Add(employeeID, totalPrice);
                    }
                }

                // Tìm nhân viên có tổng doanh thu thấp nhất trong khoảng thời gian
                string employeeWithMinSales = employeeSales.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;

                return employeeWithMinSales;
            }

            return null;
        }
        //Lấy ra doanh thu cao nhất của nhân viên trong khoảng thời gian
        public decimal GetMaxTotalSales(DateTime startDate, DateTime endDate)
        {
            DataTable billsInTimeFrame = GetEmployEEsByDateRange(startDate, endDate);
            Dictionary<string, decimal> employeeSales = new Dictionary<string, decimal>();
            decimal maxTotalSales = 0;

            if (billsInTimeFrame != null && billsInTimeFrame.Rows.Count > 0)
            {
                foreach (DataRow row in billsInTimeFrame.Rows)
                {
                    string employeeID = row["EmployeeID"].ToString();
                    decimal totalPrice = Convert.ToDecimal(row["TotalPrice"]);

                    if (employeeSales.ContainsKey(employeeID))
                    {
                        employeeSales[employeeID] += totalPrice;
                    }
                    else
                    {
                        employeeSales.Add(employeeID, totalPrice);
                    }
                }

                // Tìm tổng doanh thu cao nhất trong khoảng thời gian
                maxTotalSales = employeeSales.Max(kv => kv.Value);
            }

            return maxTotalSales;
        }
        //Lấy ra doanh thu thấp nhất của nhân viên trong khoảng thời gian
        public decimal GetMinTotalSales(DateTime startDate, DateTime endDate)
        {
            DataTable billsInTimeFrame = GetEmployEEsByDateRange(startDate, endDate);
            Dictionary<string, decimal> employeeSales = new Dictionary<string, decimal>();
            decimal minTotalSales = 0;

            if (billsInTimeFrame != null && billsInTimeFrame.Rows.Count > 0)
            {
                foreach (DataRow row in billsInTimeFrame.Rows)
                {
                    string employeeID = row["EmployeeID"].ToString();
                    decimal totalPrice = Convert.ToDecimal(row["TotalPrice"]);

                    if (employeeSales.ContainsKey(employeeID))
                    {
                        employeeSales[employeeID] += totalPrice;
                    }
                    else
                    {
                        employeeSales.Add(employeeID, totalPrice);
                    }
                }

                // Tìm tổng doanh thu thấp nhất trong khoảng thời gian
                minTotalSales = employeeSales.Min(kv => kv.Value);
            }

            return minTotalSales;
        }
        //Lấy ra doanh thu thấp nhất của nhân viên 
        public decimal GetMinTotalSalesAll()
        {
            DataTable allBills = getAllBillInfor();
            Dictionary<string, decimal> employeeSales = new Dictionary<string, decimal>();
            decimal minTotalSales = decimal.MaxValue; // Đặt giá trị mặc định là giá trị lớn nhất của kiểu decimal

            if (allBills != null && allBills.Rows.Count > 0)
            {
                foreach (DataRow row in allBills.Rows)
                {
                    string employeeID = row["EmployeeID"].ToString();
                    decimal totalPrice = Convert.ToDecimal(row["TotalPrice"]);

                    if (employeeSales.ContainsKey(employeeID))
                    {
                        employeeSales[employeeID] += totalPrice;
                    }
                    else
                    {
                        employeeSales.Add(employeeID, totalPrice);
                    }
                }

                // Tìm tổng doanh thu nhỏ nhất của nhân viên
                minTotalSales = employeeSales.Min(kv => kv.Value);
            }

            return minTotalSales;
        }
        //Lấy ra doanh thu cao nhất của nhân viên
        public decimal GetMaxTotalSalesAll()
        {
            DataTable allBills = getAllBillInfor();
            Dictionary<string, decimal> employeeSales = new Dictionary<string, decimal>();
            decimal maxTotalSales = decimal.MinValue; // Đặt giá trị mặc định là giá trị nhỏ nhất của kiểu decimal

            if (allBills != null && allBills.Rows.Count > 0)
            {
                foreach (DataRow row in allBills.Rows)
                {
                    string employeeID = row["EmployeeID"].ToString();
                    decimal totalPrice = Convert.ToDecimal(row["TotalPrice"]);

                    if (employeeSales.ContainsKey(employeeID))
                    {
                        employeeSales[employeeID] += totalPrice;
                    }
                    else
                    {
                        employeeSales.Add(employeeID, totalPrice);
                    }
                }

                // Tìm tổng doanh thu lớn nhất của nhân viên
                maxTotalSales = employeeSales.Max(kv => kv.Value);
            }

            return maxTotalSales;
        }


    }
}
