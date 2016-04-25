using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccessLayer.Report;

namespace BusinessAccessLayer.Report
{
    public class InvoiceReportManager
    {
        public DataTable GetBillData(string customerId, string billId)
        {
            try
            {
                InvoiceReportDataManager objInvoiceReportDataManager = new InvoiceReportDataManager();
                DataTable result = objInvoiceReportDataManager.GetBillData(customerId, billId);
                return result;
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
                InvoiceReportDataManager objInvoiceReportDataManager = new InvoiceReportDataManager();
                DataTable result = objInvoiceReportDataManager.GetBillDescription(customerId, purchaseDate);
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
