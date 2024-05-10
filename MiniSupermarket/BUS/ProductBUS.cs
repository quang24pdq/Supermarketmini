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

namespace MiniSupermarket.BUS
{
    internal class ProductBUS
    {
        // Chứa dữ liệu lấy lên từ database
        private DataTable product;
        public ProductBUS()
        {
            product = getAllProduct();
        }

        public DataTable getAllProduct()
        {
            string storedProcedureName = "SelectAllFromProduct";
            return Connection.Execute(storedProcedureName, null);
        }
        public DataTable getAllProducts()
        {
            product = getAllProduct();
            // Chỉ hiển thị những sản phẩm mà is deleted là 1
            DataRow[] selectedRows = product.Select("isDeleted = 1");
            DataTable newTable = selectedRows.CopyToDataTable();

            if (newTable.Columns.Contains("isDeleted"))
            {
                newTable.Columns.Remove("isDeleted");
            }

            return newTable;
        }
        // Nếu tồn tại trả về true, nếu không tồn tại trả về false
        public bool checkIdExist(string id)
        {
            // TypeID, Name
            foreach (DataRow row in product.Rows)
            {
                if (row["ProductID"].ToString() == id)
                {
                    return true;
                }
            }
            return false;
        }
        // Hàm tự tạo mã mới
        private string generateNewID()
        {
            int i = 1;
            string id;
            while (true)
            {
                id = "P" + i.ToString("D4");
                // Nếu ID chưa tồn tại
                if (!checkIdExist(id))
                {
                    return id;
                }
                ++i;
            }
        }
        public bool addProduct(string name, string typeid, string quantity, string price, string des, string unit, string promotionID, string id=null)
        {
            // Nếu không nhập mã id thì sẽ tự tạo mã mới
            if (id == null)
            {
                id = generateNewID();
            }
            
            string storedProcedureName = "InsertIntoProduct";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@TypeID", typeid), 
                new SqlParameter("@Quantity", quantity),
                new SqlParameter("@CurrentPrice", price),
                new SqlParameter("@Description",des),
                new SqlParameter("@Unit", unit),

                new SqlParameter("@PromotionID", promotionID)
            };

            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);

            // Nếu thêm thành công thì sẽ cập nhật lại danh sách
            if (result)
            {
                product = getAllProduct();
            }
            return result;
        }
        public bool deleteProduct(string id)
        {
            string storedProcedureName = "DeleteProduct";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductID", id)
            };
            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);
            // Nếu xóa thành công thì cập nhật lại danh sách
            if (result)
            {
                product = getAllProduct();
            }
            return result;
        }
        public bool updateProduct(string name, string id, string typeid, string quantity, string price, string des, string unit,string promotionID)
        {
            string storedProcedureName = "UpdateProduct";
            
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@TypeID", typeid),
                new SqlParameter("@Quantity", quantity),
                new SqlParameter("@CurrentPrice", price),
                new SqlParameter("@Description",des),
                new SqlParameter("@Unit", unit),
              
                new SqlParameter("@PromotionID", promotionID)
            };
            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);
            // Nếu cập nhật thành công thì cập nhật lại danh sách
            if (result)
            {
                product = getAllProduct();
            }
            return result;
        }

        //Lấy sản phẩm từ mã sản phẩm
        public DataTable getProductByID(string id)
        {
            DataTable result = new DataTable();
            DataRow rowTemp;
            // Thêm tên cột
            result.Columns.Add("ProductID", typeof(string));
            result.Columns.Add("Name", typeof(string));
            result.Columns.Add("ProductTypeName", typeof(string));
            result.Columns.Add("Quantity", typeof(string));
            result.Columns.Add("CurrentPrice", typeof(string));
            result.Columns.Add("Description", typeof(string));
            result.Columns.Add("Unit", typeof(string));
            result.Columns.Add("PromotionName", typeof(string));

            foreach (DataRow row in product.Rows)
            {
                if (row["isDeleted"].ToString() == "1")
                {
                    // Nếu dòng đó chứa ID như ID cần tìm thì thêm dòng đó vào result
                    if (row["ProductID"].ToString().ToLower().Contains(id.ToLower()))
                    {
                        // Thêm dữ liệu
                        rowTemp = result.NewRow();
                        rowTemp["ProductID"] = row["ProductID"].ToString();
                        rowTemp["Name"] = row["Name"].ToString();
                        rowTemp["ProductTypeName"] = row["ProductTypeName"].ToString();
                        rowTemp["Quantity"] = row["Quantity"].ToString();
                        rowTemp["CurrentPrice"] = row["CurrentPrice"].ToString();
                        rowTemp["Description"] = row["Description"].ToString();
                        rowTemp["Unit"] = row["Unit"].ToString();
                        rowTemp["PromotionName"] = row["PromotionName"].ToString();
                        result.Rows.Add(rowTemp);
                    }
                }
            }

            return result;
        }

        //Lấy sản phẩm từ tên sản phẩm
        public DataTable getProductsByProductName(string name)
        {
            DataTable result = new DataTable();
            DataRow rowTemp;
            // Thêm tên cột
            result.Columns.Add("ProductID", typeof(string));
            result.Columns.Add("Name", typeof(string));
            result.Columns.Add("ProductTypeName", typeof(string));
            result.Columns.Add("Quantity", typeof(string));
            result.Columns.Add("CurrentPrice", typeof(string));
            result.Columns.Add("Description", typeof(string));
            result.Columns.Add("Unit", typeof(string));
            result.Columns.Add("PromotionName", typeof(string));

            foreach (DataRow row in product.Rows)
            {
                if (row["isDeleted"].ToString() == "1")
                {
                    // Nếu dòng đó chứa name như name cần tìm thì thêm dòng đó vào result
                    if (row["Name"].ToString().ToLower().Contains(name.ToLower()))
                    {
                        // Thêm dữ liệu
                        rowTemp = result.NewRow();
                        rowTemp["ProductID"] = row["ProductID"].ToString();
                        rowTemp["Name"] = row["Name"].ToString();
                        rowTemp["ProductTypeName"] = row["ProductTypeName"].ToString();
                        rowTemp["Quantity"] = row["Quantity"].ToString();
                        rowTemp["CurrentPrice"] = row["CurrentPrice"].ToString();
                        rowTemp["Description"] = row["Description"].ToString();
                        rowTemp["Unit"] = row["Unit"].ToString();
                        rowTemp["PromotionName"] = row["PromotionName"].ToString();
                        result.Rows.Add(rowTemp);
                    }
                }
            }

            return result;
        }
        //Lấy sản phẩm từ mã loại sản phẩm
        public DataTable getProductsByTypeID(string typeId)
        {
            DataTable result = new DataTable();
            DataRow rowTemp;
            // Thêm tên cột
            result.Columns.Add("ProductID", typeof(string));
            result.Columns.Add("Name", typeof(string));
            result.Columns.Add("ProductTypeName", typeof(string));
            result.Columns.Add("Quantity", typeof(string));
            result.Columns.Add("CurrentPrice", typeof(string));
            result.Columns.Add("Description", typeof(string));
            result.Columns.Add("Unit", typeof(string));
            result.Columns.Add("PromotionName", typeof(string));

            foreach (DataRow row in product.Rows)
            {
                if (row["isDeleted"].ToString() == "1")
                {
                    // Nếu dòng đó chứa TypeID như TypeID cần tìm thì thêm dòng đó vào result
                    if (row["ProductTypeName"].ToString().ToLower().Contains(typeId.ToLower()))
                    {
                        // Thêm dữ liệu
                        rowTemp = result.NewRow();
                        rowTemp["ProductID"] = row["ProductID"].ToString();
                        rowTemp["Name"] = row["Name"].ToString();
                        rowTemp["ProductTypeName"] = row["ProductTypeName"].ToString();
                        rowTemp["Quantity"] = row["Quantity"].ToString();
                        rowTemp["CurrentPrice"] = row["CurrentPrice"].ToString();
                        rowTemp["Description"] = row["Description"].ToString();
                        rowTemp["Unit"] = row["Unit"].ToString();
                        rowTemp["PromotionName"] = row["PromotionName"].ToString();
                        result.Rows.Add(rowTemp);
                    }
                }
            }

            return result;
        }
        //Lấy tên sản phẩm từ mã sản phẩm
        public string GetNameFromId(string id)
        {
            foreach (DataRow row in product.Rows)
            {
                if (row["isDeleted"].ToString() == "1")
                {
                    // Nếu TypeID khớp với ID cần tìm, trả về Name tương ứng
                    if (row["ProductID"].ToString().Equals(id, StringComparison.OrdinalIgnoreCase))
                    {
                        return row["Name"].ToString();
                    }
                }
            }
            // Trường hợp không tìm thấy
            return "Không tìm thấy"; // hoặc có thể trả về một giá trị mặc định khác
        }
    }
}
