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
    internal class DetailPromotionBUS
    {
        private DataTable products, productPromotions;

        public DataTable getProducts(string ID)
        {
            string storedProcedure = "SelectProductToPromotion";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@PromotionID",ID)
            };
            products = Connection.Execute(storedProcedure,parameters);
            return products;
        }

        public DataTable getProductPromotions(string ID)
        {
            string storedProcedure = "SelectProductToPromotionApply";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@PromotionID",ID)
            };
            productPromotions = Connection.Execute(storedProcedure, parameters);
            return productPromotions;
        }

        public Boolean DeleteProductFromDetailPromotion(string id)
        {
            string storedProcedure = "DeleteProductFromPromotionProduct";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductID",id)
            };
            return Connection.ExecuteNonQuery(storedProcedure, parameters);
            
        }

        public Boolean AddProductFromDetailPromotion(string id, string PromotionID)
        {
            string storedProcedure = "AddProductToPromotionProduct";
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@ProductID",id),
                new SqlParameter("@PromotionID", PromotionID)
            };
            return Connection.ExecuteNonQuery(storedProcedure,parameters);
        }

        public String getPromotionIDFromProductID(string id)
        {
            string storedProcedure = "GetPromotionIDFromProductID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductID",id)
            };
            string PromotionID = Connection.Execute(storedProcedure, parameters).Rows[0].ItemArray[0].ToString();
            return PromotionID;
        }
    }
}
 