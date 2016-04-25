using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Density.UI;
using BusinessAccessLayer.Model.ModProject;
namespace DataAccessLayer.ModProject
{
    public class BillReportsDataManager
    {
        public DataTable GetBill()
        {
            try
            {
                DataTable dtBillNo = DBOperate.GetDataTableWithoutSP("select BillId,Particulars,Quantity,Rate from tblBillDetails join tblDescription on tblBillDetails.CustomerId=tblDescription.CustomerId");
                return dtBillNo;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
