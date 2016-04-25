using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccessLayer.ModProject;
using BusinessAccessLayer.Model.ModProject;

namespace BusinessAccessLayer.ModProject
{
    public class BillingDetailsManager
    {
        BillingDetailsDataManager objBillingDetailsDataManager = new BillingDetailsDataManager();

        public DataTable GetCustomer()
        {
            try
            {
                DataTable result = objBillingDetailsDataManager.GetCustomer();
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public int AddBillDescription(BillingModel objBillingModel)
        {
            try
            {
                BillingDetailsDataManager objBillingDetailsDataManager = new BillingDetailsDataManager();
                int result = objBillingDetailsDataManager.AddBillDescription(objBillingModel);
                return result;
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
                BillingDetailsDataManager objBillingDetailsDataManager = new BillingDetailsDataManager();
                int result = objBillingDetailsDataManager.AddBillData(objBillingModel);
                return result;
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
                BillingDetailsDataManager objBillingDetailsDataManager = new BillingDetailsDataManager();
                DataTable result = objBillingDetailsDataManager.GetItems(customerId);
                return result;
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
                BillingDetailsDataManager objBillingDetailsDataManager = new BillingDetailsDataManager();
                DataTable result = objBillingDetailsDataManager.GetBillNo(customerId);
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }

        }        

    }
}
