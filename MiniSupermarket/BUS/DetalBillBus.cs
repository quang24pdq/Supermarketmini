using Irony.Parsing;
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

namespace MiniSupermarket.BUS {
    internal class DetalBillBus {

        //public DetalBillBus() {
        //    detalbill = getDetalBill();
        //}
         
        public DataTable getAllDetalBill() {
            string storedProcedureName = "GetAllDetailBills";
            return Connection.Execute(storedProcedureName, null);
        }

        public DataTable getDetalBill(string billID) {
            string storedProcedureName = "GetDetailBill";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@BillID", billID),
            };
            return Connection.Execute(storedProcedureName, parameters);
        }

        public bool checkIdExist(string billID, string productID) {
            // TypeID, Name
            DataTable detailbill = getDetalBill(billID);
            foreach (DataRow row in detailbill.Rows) {
                if (row["ProductID"].ToString() == productID) {
                    return true;
                }
            }
            return false;
        }

        //Sản phẩm bán chạy nhất
        public string GetMostSoldProduct() {
            Dictionary<string, int> productSales = new Dictionary<string, int>();

            DataTable detalBill = getAllDetalBill();

            foreach (DataRow row in detalBill.Rows) {
                string productId = row.Field<string>("ProductID");
                int quantity = row.Field<int>("Quantity");

                if (productSales.ContainsKey(productId)) {
                    productSales[productId] += quantity;
                } else {
                    productSales.Add(productId, quantity);
                }
            }

            if (productSales.Count > 0) {
                string mostSoldProduct = productSales.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
                return mostSoldProduct;
            }

            return "No data available";
        }
        //Sản phẩm bán ít nhất
        public string GetLeastSoldProduct() {
            Dictionary<string, int> productSales = new Dictionary<string, int>();
            DataTable detalBill = getAllDetalBill();

            foreach (DataRow row in detalBill.Rows) {
                string productId = row.Field<string>("ProductID");
                int quantity = row.Field<int>("Quantity");

                if (productSales.ContainsKey(productId)) {
                    productSales[productId] += quantity;
                } else {
                    productSales.Add(productId, quantity);
                }
            }

            if (productSales.Count > 0) {
                string leastSoldProduct = productSales.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;
                return leastSoldProduct;
            }

            return "No data available";
        }
        //Số lượng bán ra của sản phẩm bán chạy
        public int GetMostSoldProductQuantity() {
            Dictionary<string, int> productSales = new Dictionary<string, int>();
            DataTable detalBill = getAllDetalBill();

            foreach (DataRow row in detalBill.Rows) {
                string productId = row.Field<string>("ProductID");
                int quantity = row.Field<int>("Quantity");

                if (productSales.ContainsKey(productId)) {
                    productSales[productId] += quantity;
                } else {
                    productSales.Add(productId, quantity);
                }
            }

            if (productSales.Count > 0) {
                var mostSoldProduct = productSales.Aggregate((x, y) => x.Value > y.Value ? x : y);
                return mostSoldProduct.Value;
            }

            return 0;
        }
        //Số lượng bán ra của sản phẩm bán ít
        public int GetLeastSoldProductQuantity() {
            Dictionary<string, int> productSales = new Dictionary<string, int>();
            DataTable detalBill = getAllDetalBill();

            foreach (DataRow row in detalBill.Rows) {
                string productId = row.Field<string>("ProductID");
                int quantity = row.Field<int>("Quantity");

                if (productSales.ContainsKey(productId)) {
                    productSales[productId] += quantity;
                } else {
                    productSales.Add(productId, quantity);
                }
            }

            if (productSales.Count > 0) {
                var leastSoldProduct = productSales.Aggregate((x, y) => x.Value < y.Value ? x : y);
                return leastSoldProduct.Value;
            }

            return 0;
        }

        public bool AddDetailBill(string billID, string productID, int quantity) {
            string storedProcedureName = "AddDetailBill";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@BillID", billID),
                new SqlParameter("@ProductID", productID),
                new SqlParameter("@Quantity", quantity),
            };

            return Connection.ExecuteNonQuery(storedProcedureName, parameters);
        }

        //public bool UpdateDetailBill(string billID, string productID, int quantity) {
        //    string storedProcedureName = "UpdateDetailBill";
        //    SqlParameter[] parameters = new SqlParameter[]
        //    {
        //        new SqlParameter("@BillID", billID),
        //        new SqlParameter("@ProductID", productID),
        //        new SqlParameter("@NewQuantity", quantity),
        //    };
        //    return Connection.ExecuteNonQuery(storedProcedureName, parameters);

        //}



        public bool DeleteDetailBill(string billID, string productID) {
            string storedProcedureName = "DeleteDetailBill";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@BillID", billID),
                new SqlParameter("@ProductID", productID),
            };
            return Connection.ExecuteNonQuery(storedProcedureName, parameters);
        }

        public bool updateBillPrice(string billID) {
            string storedProcedureName = "UpdateBillPrice";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@BillID", billID),
            };
            return Connection.ExecuteNonQuery(storedProcedureName, parameters);
        }

        public bool payTheBill(string billID) {
            string storedProcedureName = "PayTheBill";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@BillID", billID),
            };
            return Connection.ExecuteNonQuery(storedProcedureName, parameters);
        }
    }
}
