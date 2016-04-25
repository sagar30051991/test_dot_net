using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessAccessLayer.Model.ModProject;
using DataAccessLayer.ModProject;
using System.Data;

namespace BusinessAccessLayer.ModProject
{
    
    public class CustomerInfoManager
    {
       
        
        public int AddCustomer(CustomerModel objCustomerModel)
        {
            try
            {
                CustomerInfoDataManager objCustomerInfoDataManager = new CustomerInfoDataManager();
                int result=objCustomerInfoDataManager.AddCustomer(objCustomerModel);
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        
        }
        
        public int UpdateCustomer(CustomerModel objCustomerModel)
        {
            try
            {
                CustomerInfoDataManager objCustomerInfoDataManager = new CustomerInfoDataManager();
                int result = objCustomerInfoDataManager.UpdateCustomer(objCustomerModel);
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public int DeleteCustomer(CustomerModel objCustomerModel)
        {
            try
            {
                CustomerInfoDataManager objCustomerInfoDataManager = new CustomerInfoDataManager();
                int result = objCustomerInfoDataManager.DeleteCustomer(objCustomerModel);
                return result;
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
                CustomerInfoDataManager objCustomerInfoDataManager = new CustomerInfoDataManager();
                return objCustomerInfoDataManager.GetCustomerDetail();                
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
                CustomerInfoDataManager objCustomerInfoDataManager = new CustomerInfoDataManager();
                return objCustomerInfoDataManager.GetCustomerDetailsById(id);                
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        
    }
}
