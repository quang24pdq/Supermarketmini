using MiniSupermarket.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarket.BUS {
    internal class CustomerBus {
        private DataTable customers;
        public static List<Customer> customerList = new List<Customer>();

        public CustomerBus()
        {
            customers = getAllCustomer();
            customerList.Clear();

            foreach (DataRow row in customers.Rows)
            {
                Customer customer = new Customer(row);
                customerList.Add(customer);
            }
        }

        public DataTable getAllCustomer() {
            string storedProcedureName = "SelectAllCustomer";
            return Connection.Execute(storedProcedureName, null);
        }

        public List<Customer> getAllCustomers() {
            return customerList;
        }
        // Nếu tồn tại trả về true, nếu không tồn tại trả về false
        public bool checkIdExist(string id) {
            foreach (Customer customer in customerList) {
                if (customer.CustomerID == id) {
                    return true;
                }
            }
            return false;
        }

        // Hàm tự tạo mã mới
        public string generateNewID() {
            int i = 1;
            string id;

            while (true) {
                // Sử dụng định dạng số có độ dài ít nhất là 4 chữ số
                id = "C" + i.ToString("D4");
                // Nếu ID chưa tồn tại
                if (!checkIdExist(id)) {
                    return id;
                }
                ++i;
            }
        }
        public bool addCustomer(string name, string phoneNumber, string sex, string point, string isDeleted) {
            // Nếu không nhập mã id thì sẽ tự tạo mã mới
            //if (id == "") {
            //    id = generateNewID();
            //}
            string id = generateNewID();

            string storedProcedureName = "InsertCustomer";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CustomerID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@PhoneNumber", phoneNumber),
                new SqlParameter("@Sex", sex),
                new SqlParameter("@Point", point),
                new SqlParameter("@isDeleted",isDeleted)
            };

            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);

            // Nếu thêm thành công thì sẽ cập nhật lại danh sách
            if (result) {
                customerList.Add(new Customer(id, name, phoneNumber, sex, point, isDeleted));
            }
            return result;
        }
        public bool deleteCustomer(string id) {
            string storedProcedureName = "DeleteCustomer";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CustomerID", id)
            };
            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);
            // Nếu xóa thành công thì cập nhật lại danh sách
            if (result) {
                // Tìm khách hàng cần chỉnh sửa
                foreach (Customer customer in customerList) {
                    if (customer.CustomerID == id) {
                        // Chỉnh sửa thuộc tính IsDeleted
                        customer.IsDeleted = "0";
                        break; // Dừng vòng lặp sau khi tìm thấy khách hàng
                    }
                }
            }
            return result;
        }
        public bool updateCustomer(string id, string name, string phoneNumber, string sex, string point, string isDeleted) {
            string storedProcedureName = "UpdateCustomer";
            SqlParameter[] parameters = new SqlParameter[]
            {
                 new SqlParameter("@CustomerID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@PhoneNumber", phoneNumber),
                new SqlParameter("@Sex", sex),
                new SqlParameter("@Point", point),
                new SqlParameter("@isDeleted",isDeleted)
            };
            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);
            // Nếu cập nhật thành công thì cập nhật lại danh sách
            if (result) {
                foreach (var customer in customerList) {
                    if (customer.CustomerID == id) {
                        customer.Name = name;
                        customer.PhoneNumber = phoneNumber;
                        customer.Sex = sex;
                        customer.Point = point;
                        customer.IsDeleted = isDeleted;
                    }
                }
            }
            return result;
        }

        public List<Customer> FindCustomer(string checkType, string input, string sex) {
            List<Customer> foundCustomers = new List<Customer>();

            if (input == "") {
                foundCustomers = customerList; 
            } else {
                input = input.ToLower();
                if (string.IsNullOrEmpty(checkType)) {
                    // Nếu không có checkType, tìm kiếm tất cả các trường có ký tự trùng với input
                    foundCustomers = customerList.FindAll(customer =>
                        customer.CustomerID.ToLower().Contains(input) ||
                        customer.Name.ToLower().Contains(input) ||
                        customer.PhoneNumber.ToLower().Contains(input)
                    );
                } else {
                    switch (checkType) {
                        case "Mã khách hàng":
                            foundCustomers = customerList.FindAll(customer => customer.CustomerID.ToLower().Contains(input));
                            break;
                        case "Tên khách hàng":
                            foundCustomers = customerList.FindAll(customer => customer.Name.ToLower().Contains(input));
                            break;
                        case "Số điện thoại":
                            foundCustomers = customerList.FindAll(customer => customer.PhoneNumber.ToLower().Contains(input));
                            break;
                        default:
                            Console.WriteLine("Không hỗ trợ loại tìm kiếm này.");
                            break;
                    }
                }

            }
            if (!string.IsNullOrEmpty(sex)) {
                // Lọc theo giới tính nếu sex không rỗng
                foundCustomers = foundCustomers.FindAll(customer => customer.Sex.ToLower() == sex.ToLower());
            }
            return foundCustomers;
        }
    }
}
