using MiniSupermarket.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace MiniSupermarket.BUS
{
    internal class SupplierBUS
    {
        private DataTable nhaCungCap;
        private DataTable nhaCungCapDetail;
        private DataTable products;
        public SupplierBUS() {
            nhaCungCap = getAllSupplier();
            
        }
        private DataTable getAllSupplier()
        {
            string storedProcedureName = "SelectAllSupplier";
            return Connection.Execute(storedProcedureName, null);
        }
        public DataTable getAllSupplierWithout()
        {
            string storedProcedureName = "SelectAllSupplierWithoutIsDeleted";
            return Connection.Execute(storedProcedureName, null);
        }
        private DataTable getAllSupplierDetail(string id)
        {
            string storedProcedureName = "SelectAllSupplierDetail";
            SqlParameter[] parameters = new SqlParameter[]
           {
                new SqlParameter("@ID",id),
                
       };
            return Connection.Execute(storedProcedureName, parameters);
        }
        private DataTable getSupplierWithID(string id)
        {
            string storedProcedureName = "FindSupplierWithID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID",id)
            };
            return Connection.Execute(storedProcedureName, parameters);
        }
        public DataTable getAllFromSupplier() {
            nhaCungCap=getAllSupplier();
            return nhaCungCap;
        }
        public DataTable getAllFromSupplierDetail(string id)
        {
            return nhaCungCapDetail=getAllSupplierDetail(id);
        }
        public DataTable getSupplierWithIDFromSupplier(string id)
        {
            nhaCungCap = getSupplierWithID(id);
            return nhaCungCap;
        }
        public bool addSupplier(string id, string name, string address, string phoneNumber, string email)
        {
            string storedProcduredName = "AddSupplier";
            SqlParameter[] parameters = new SqlParameter[]
            
            {
                new SqlParameter("@ID",id),
                new SqlParameter("@Name",name),
                new SqlParameter("@Address",address),
                new SqlParameter("@PhoneNumber",phoneNumber),
                new SqlParameter("@Email",email)
                
        };
            bool result = false;
            try
            {
                result = Connection.ExecuteNonQuery(storedProcduredName, parameters);
            } catch (Exception ex)
            {

            }
            
           
            return result;
        }
        public bool delSupplier(string id)
        {
            string storedProcduredName = "DelSupplier";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@ID",id)
            };
            bool result = Connection.ExecuteNonQuery(storedProcduredName, parameters);
            return result;
        }
        public DataTable AllProduct(string supplierID)
        {
            string storedProcduredName = "AllProduct";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@ID",supplierID)
            };
            products = Connection.Execute(storedProcduredName, parameters);
            return products;
        }
        public bool AddDetailSupplier(string SupplierID,string ProductID,string SupplyStartDate)
        {
            string storedProcduredName = "AddDetailSupplier";
            SqlParameter[] parameters = new SqlParameter[]

            {
                new SqlParameter("@SupplierID",SupplierID),
                new SqlParameter("@ProductID",ProductID),
                new SqlParameter("@SupplyStartDate",SupplyStartDate)
                

        };
            bool result=false;

            try
            {
                result = Connection.ExecuteNonQuery(storedProcduredName, parameters);
                
            } catch (SqlException ex) 
            {
                if (ex.Number == 2627)
                {
                    
                    return result;
                    
                }
                
            }

            return result;
        }
        public bool updateSupplier(string id, string name, string address, string phoneNumber, string email)
        {
            string storedProcduredName = "UpdateSupplier";
            SqlParameter[] parameters = new SqlParameter[]

            {
                new SqlParameter("@ID",id),
                new SqlParameter("@Name",name),
                new SqlParameter("@Address",address),
                new SqlParameter("@PhoneNumber",phoneNumber),
                new SqlParameter("@Email",email)

        };
            bool result = false;
            try
            {
                result = Connection.ExecuteNonQuery(storedProcduredName, parameters);
            }
            catch (Exception ex)
            {

            }


            return result;
        }
        public bool updateSupplierDetail(string supplierID,string productID,string supplyStartDate)
        {
            string storedProcduredName = "UpdateSupplierDetail";
            SqlParameter[] parameters = new SqlParameter[]

            {
                new SqlParameter("@SupplierID",supplierID),
                new SqlParameter("@ProductID",productID),
                new SqlParameter("@SupplyStartDate",supplyStartDate)
        };
            bool result = false;
            try
            {
                result = Connection.ExecuteNonQuery(storedProcduredName, parameters);
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public bool delSupplierDetail(string supplierID,string productID)
        {
            string storedProcduredName = "DelSupplierDetail";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@SupplierID",supplierID),
                new SqlParameter("@ProductID",productID)
            };
            bool result = Connection.ExecuteNonQuery(storedProcduredName, parameters);
            return result;
        }
        public DataTable getSupplierWithName(string name)
        {
            string storedProcedureName = "FindSupplierWithName";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name",name)
            };
            return Connection.Execute(storedProcedureName, parameters);
        }
        public DataTable getSupplierWithAddress(string address)
        {
            string storedProcedureName = "FindSupplierWithAddress";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Address",address)
            };
            return Connection.Execute(storedProcedureName, parameters);
        }
        public DataTable getSupplierWithPhoneNumber(string phoneNumber)
        {
            string storedProcedureName = "FindSupplierWithPhoneNumber";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@PhoneNumber",phoneNumber)
            };
            return Connection.Execute(storedProcedureName, parameters);
        }
        public DataTable getSupplierWithEmail(string email)
        {
            string storedProcedureName = "FindSupplierWithEmail";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Email",email)
            };
            return Connection.Execute(storedProcedureName, parameters);
        }
    }
}
