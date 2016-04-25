using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Density.UI;
using System.Data.SqlClient;
using BusinessAccessLayer.Model.ModProject;

namespace DataAccessLayer.ModProject
{
    public class BillingDetailsDataManager
    {
        public DataTable GetCustomer()
        {
            try
            {
                DataTable dtCustomer = DBOperate.GetDataTableWithoutSP("select Id,CustomerId,CustomerName from tblCustomerInfo");
                return dtCustomer;
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public int AddBillDescription(BillingModel objBillingModel)
        {
            try
            {
                int res = 0;

                SqlParameter[] parameter = new SqlParameter[]
                {   
                    new SqlParameter("@CustomerId",objBillingModel.CustomerId),
                    new SqlParameter("@Particulars",objBillingModel.Particular),
                    new SqlParameter("@Quantity",objBillingModel.Qty),
                    new SqlParameter("@Rate",objBillingModel.Rate),
                    new SqlParameter("@VAT_12",objBillingModel.Vat12_5),
                    new SqlParameter("@CST_2",objBillingModel.CST2),
                    new SqlParameter("@TotalAmount",objBillingModel.TotalAmount),
                    new SqlParameter("@Flag",objBillingModel.Flag),
                    new SqlParameter("@ReturnVal",SqlDbType.Int)  ,
                    new SqlParameter("@PurchaseOrderDate",DateTime.Now)
                };
                res = DBOperate.ExecuteProcedure("uspmodifyDesc", parameter);

                return res;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public int AddBillData(BillingModel objBillingModel)
        {
            try
            {
                int res = 0;

                SqlParameter[] parameter = new SqlParameter[]
                {   
                    new SqlParameter("@CustomerId",objBillingModel.CustomerId),
                    new SqlParameter("@BillId",objBillingModel.BillId),                    
                    new SqlParameter("@CST_VAT",objBillingModel.CST_VAT),
                    new SqlParameter("@ReturnVal",SqlDbType.Int),
                    new SqlParameter("@PurchaseOrderDate",DateTime.Now)
                };
                res = DBOperate.ExecuteProcedure("uspmodifybilldata", parameter);

                return res;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public DataTable GetItems(string customerId)
        {
            try
            {
                DataTable dtItems = DBOperate.GetDataTableWithoutSP("select * from tblDescription");
                return dtItems;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public DataTable GetBillNo(string customerId)
        {
            try
            {              
                DataTable dtBillNo = DBOperate.GetDataTableWithoutSP("select * from tblBillData where CustomerId='"+customerId+"'");
                return dtBillNo;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        
    }
}
