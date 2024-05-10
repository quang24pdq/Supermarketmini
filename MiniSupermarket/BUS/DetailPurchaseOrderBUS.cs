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
    internal class DetailPurchaseOrderBUS
    {
        private DataTable products, productOrders;

        public DataTable getProducts(string OrderID, string SupplierID)
        {
            string storedProcedure = "SelectProductsToPurchaseOrder";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID",OrderID),
                new SqlParameter("@SupplierID",SupplierID)
            };
            products = Connection.Execute(storedProcedure,parameters);
            return products;
        }

        public DataTable getProductOrders(string OrderID)
        {
            string storedProcedure = "SelectProductsToDetailOrder";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID",OrderID),
            };
            productOrders = Connection.Execute(storedProcedure, parameters);
            return productOrders;
        }

        public Boolean AddProductToDetailOrder(string OrderID, string ProductID, string OrderPrice, string Quantity)
        {
            string storedProcedureOrder = "AddProductToDetailOrder";
            SqlParameter[] parameterOrders = new SqlParameter[]
            {
                new SqlParameter("@Order",OrderID),
                new SqlParameter("@ProductID",ProductID),
                new SqlParameter("@OrderPrice",OrderPrice),
                new SqlParameter("@Quantity",Quantity)
            };
            return Connection.ExecuteNonQuery(storedProcedureOrder, parameterOrders);
        }

        public Boolean DeleteProductFromDetailOrder(string OrderID, string ProductID)
        {
            string storedProcedure = "DeleteProductFromDetailOrder";
            SqlParameter[] parameterOrders = new SqlParameter[]
            {
                new SqlParameter("@OrderID",OrderID),
                new SqlParameter("@ProductID",ProductID)
            };
            return Connection.ExecuteNonQuery(storedProcedure, parameterOrders);
        }

        public Boolean PayPurchaseOrder(string OrderID)
        {
            string storedProcedure = "PayOrder";
            SqlParameter[] parameterOrders = new SqlParameter[]
            {
                new SqlParameter("@OrderID",OrderID)
            };
            DataTable Inventory = getProductOrders(OrderID);
            foreach (DataRow row in Inventory.Rows)
            {
                string storedProcedureInventory = "AddProductsToInventory";
                string ProductID = row.ItemArray[0].ToString();
                string CurrentQuantity = row.ItemArray[2].ToString();
                SqlParameter[] prm = new SqlParameter[]
                {
                    new SqlParameter("@Order",OrderID),
                    new SqlParameter("@ProductID",ProductID),
                    new SqlParameter("@CurrentQuantity",CurrentQuantity)
                };
                Connection.ExecuteNonQuery(storedProcedureInventory, prm);
            }
            string storedTotalPrice = "SetTotalPriceOrder";
            SqlParameter[] parameterTotalPrice = new SqlParameter[]
            {
                new SqlParameter("@OrderID",OrderID)
            };
            Connection.ExecuteNonQuery(storedTotalPrice,parameterTotalPrice);

            string storedTotalQuantity = "SetQuantityProduct";
            Connection.ExecuteNonQuery(storedTotalQuantity, null);

            return Connection.ExecuteNonQuery(storedProcedure, parameterOrders);
        }
    }
}
 