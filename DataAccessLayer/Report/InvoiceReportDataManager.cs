using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Density.UI;

namespace DataAccessLayer.Report
{
    public class InvoiceReportDataManager
    {
        public DataTable GetBillData(string customerId, string billId)
        {
            try
            {
                DataTable dtBillData = DBOperate.GetDataTableWithoutSP("select * from tblBillData where CustomerId='" + customerId + "' and BillId='"+billId+"'");
                return dtBillData;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public DataTable GetBillDescription(string customerId, DateTime purchaseDate)
        {
            try
            {
                DataTable dtBillDescription = DBOperate.GetDataTableWithoutSP("select * from tblDescription where CustomerId='" + customerId + "' and PurchaseOrderDate='"+purchaseDate+"'");
                return dtBillDescription;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
