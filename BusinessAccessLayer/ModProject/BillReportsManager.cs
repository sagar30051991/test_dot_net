using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer.ModProject;
using BusinessAccessLayer.Model.ModProject;
using System.Data;

namespace BusinessAccessLayer.ModProject
{
    public class BillReportsManager
    {
        BillReportsDataManager objBillReportsDataManager = new BillReportsDataManager();
        public DataTable GetBill()
        {
            try
            {
                DataTable result = objBillReportsDataManager.GetBill();
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
