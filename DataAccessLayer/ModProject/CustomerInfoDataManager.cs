using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessAccessLayer.Model.ModProject;
using System.Data.SqlClient;
using Density.UI;
using System.Data;

namespace DataAccessLayer.ModProject
{
    public class CustomerInfoDataManager
    {
        public int AddCustomer(CustomerModel objCustomerModel)
        {
            try
            {
                //string UserId = objRegistrationModel.UserId;

                int res = 0;

                SqlParameter[] parameter = new SqlParameter[]
                {   
                    new SqlParameter("@CustomerId",objCustomerModel.CustomerId),
                    new SqlParameter("@CustomerName",objCustomerModel.CustomerName),
                    new SqlParameter("@Address1",objCustomerModel.Address1),
                    new SqlParameter("@Address2",objCustomerModel.Address2),
                    new SqlParameter("@City",objCustomerModel.City),
                    new SqlParameter("@Pincoode",objCustomerModel.Pincode),
                    new SqlParameter("@Vat_Tin",objCustomerModel.Vat_Tin),
                    new SqlParameter("@CST_No",objCustomerModel.CST_No),
                    new SqlParameter("@ContactNo",objCustomerModel.ContactNo),
                    new SqlParameter("@PurchaseOrderDate",DateTime.Now),
                    new SqlParameter("@Flag",objCustomerModel.Flag),
                    new SqlParameter("@ReturnVal",SqlDbType.Int)  
                };
                res = DBOperate.ExecuteProcedure("uspModifyCustomer", parameter);

                return res;
            }
            catch
            {
                throw;
            }
        }

        public int UpdateCustomer(CustomerModel objCustomerModel)
        {
            try
            {
                int res = 0;

                SqlParameter[] parameter = new SqlParameter[]
                {   
                    new SqlParameter("@CustomerId",objCustomerModel.CustomerId),
                    new SqlParameter("@CustomerName",objCustomerModel.CustomerName),
                    new SqlParameter("@Address1",objCustomerModel.Address1),
                    new SqlParameter("@Address2",objCustomerModel.Address2),
                    new SqlParameter("@City",objCustomerModel.City),
                    new SqlParameter("@Pincoode",objCustomerModel.Pincode),
                    new SqlParameter("@Vat_Tin",objCustomerModel.Vat_Tin),
                    new SqlParameter("@CST_No",objCustomerModel.CST_No),
                    new SqlParameter("@ContactNo",objCustomerModel.ContactNo),
                    new SqlParameter("@PurchaseOrderDate",DateTime.Now),
                    new SqlParameter("@Flag",objCustomerModel.Flag),
                    new SqlParameter("@ReturnVal",SqlDbType.Int)  
                };
                res = DBOperate.ExecuteProcedure("uspModifyCustomer", parameter);

                return res;
            }
            catch 
            {
                throw;
            }

        }

        public int DeleteCustomer(CustomerModel objCustomerModel)
        {
            try
            {
                int res = 0;

                SqlParameter[] parameter = new SqlParameter[]
                {   
                    new SqlParameter("@CustomerId",objCustomerModel.CustomerId),
                    new SqlParameter("@CustomerName",objCustomerModel.CustomerName),
                    new SqlParameter("@Address1",objCustomerModel.Address1),
                    new SqlParameter("@Address2",objCustomerModel.Address2),
                    new SqlParameter("@City",objCustomerModel.City),
                    new SqlParameter("@Pincoode",objCustomerModel.Pincode),
                    new SqlParameter("@Vat_Tin",objCustomerModel.Vat_Tin),
                    new SqlParameter("@CST_No",objCustomerModel.CST_No),
                    new SqlParameter("@ContactNo",objCustomerModel.ContactNo),
                    new SqlParameter("@PurchaseOrderDate",DateTime.Now),
                    new SqlParameter("@Flag",objCustomerModel.Flag),
                    new SqlParameter("@ReturnVal",SqlDbType.Int)  
                };
                res = DBOperate.ExecuteProcedure("uspModifyCustomer", parameter);

                return res;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public DataTable GetCustomerDetail()
        {
            try
            {
                return DBOperate.GetDataTable("uspGetCustomerDetail");
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public DataTable GetCustomerDetailsById(string id)
        {
            try
            {
                SqlParameter[] parameter = new SqlParameter[]
                {   
                    new SqlParameter("@Id",id)                   
                };
                return DBOperate.GetDataTable("uspGetCustomerDetailById",parameter);
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
