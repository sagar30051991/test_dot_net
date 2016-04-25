using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessAccessLayer.Model.ModProject;
using BusinessAccessLayer.ModProject;
using DensityApplication.Common;
using System.Data;

namespace DensityApplication.ModProject
{
    public partial class FrmCustomer : System.Web.UI.Page
    {
        CustomerInfoManager objCustomerInfoManager = new CustomerInfoManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                CustomerModel objCustomerModel = new CustomerModel();
                int low = 1;
                int high = 1000;
                Random rndNumber = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber));
                int rndno = rndNumber.Next(low, high);

                string cId = Convert.ToString(txtCustomerName.Text);
                string newCustomerId = cId.Substring(0, 3);
                string customerId = rndno + newCustomerId;
                objCustomerModel.CustomerId = customerId;
                objCustomerModel.CustomerName = txtCustomerName.Text;
                objCustomerModel.ContactNo = Convert.ToString(txtContact_No.Text);
                objCustomerModel.Address1 = txtAddress1.Text;
                objCustomerModel.Address2 = txtAddress2.Text;
                objCustomerModel.City = txtCity.Text;
                objCustomerModel.Pincode = txtPincode.Text;
                objCustomerModel.Vat_Tin = txtVAT_Tin.Text;
                objCustomerModel.CST_No = txtCST_No.Text;
                objCustomerModel.Flag = 1;
                objCustomerInfoManager.AddCustomer(objCustomerModel);
                BindGrid();
            }
            catch (Exception ex)
            {
                ErrorLogging.LogError(ex);
            }
             
        }
       
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            CustomerModel objCustomerModel = new CustomerModel();
            string customerId = Convert.ToString(ViewState["CustomerId"]);
            objCustomerModel.CustomerId = customerId;
            objCustomerModel.CustomerName = txtCustomerName.Text;
            objCustomerModel.ContactNo = txtContact_No.Text;
            objCustomerModel.Address1 = txtAddress1.Text;
            objCustomerModel.Address2 = txtAddress2.Text;
            objCustomerModel.City = txtCity.Text;
            objCustomerModel.Pincode = txtPincode.Text;
            objCustomerModel.Vat_Tin = txtVAT_Tin.Text;
            objCustomerModel.CST_No = txtCST_No.Text;
            objCustomerModel.Flag = 2;
            objCustomerInfoManager.UpdateCustomer(objCustomerModel);
            BindGrid();
        }

        public void BindGrid()
        {
            try
            {
                DataTable dtCustomer = new DataTable();
                dtCustomer = objCustomerInfoManager.GetCustomerDetail();
                grdCustomerDetail.DataSource = dtCustomer;
                grdCustomerDetail.DataBind();
            }
            catch (Exception ex)
            {
                ErrorLogging.LogError(ex);
            }
        }

        protected void grdCustomerDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtCustomerDetails = new DataTable();
               
                string id = Convert.ToString(grdCustomerDetail.SelectedValue);
                ViewState["Id"] = id;
                
                dtCustomerDetails = objCustomerInfoManager.GetCustomerDetailsById(id);
                BindControls(dtCustomerDetails);
               
            }
            catch (Exception ex) 
            {
                ErrorLogging.LogError(ex);
            }
        }

        private void BindControls(DataTable dtRo)
        {
            try
            {
                if (dtRo.Rows.Count > 0)
                {
                    ViewState["CustomerId"] = Convert.ToString(dtRo.Rows[0]["CustomerId"]);
                    txtCustomerName.Text = Convert.ToString(dtRo.Rows[0]["CustomerName"]);
                    txtAddress1.Text = Convert.ToString(dtRo.Rows[0]["Address1"]);
                    txtAddress2.Text = Convert.ToString(dtRo.Rows[0]["Address2"]);
                    txtCity.Text = Convert.ToString(dtRo.Rows[0]["City"]);
                    txtPincode.Text = Convert.ToString(dtRo.Rows[0]["Pincode"]);
                    txtVAT_Tin.Text = Convert.ToString(dtRo.Rows[0]["VAT_Tin"]);
                    txtCST_No.Text = Convert.ToString(dtRo.Rows[0]["CST_No"]);
                    txtContact_No.Text = Convert.ToString(dtRo.Rows[0]["ContactNo"]);
                 }

            }
            catch (Exception ex)
            {
                ErrorLogging.LogError(ex);
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerModel objCustomerModel = new CustomerModel();
                string customerId = Convert.ToString(ViewState["CustomerId"]);
                objCustomerModel.CustomerId = customerId;
                objCustomerModel.CustomerName = txtCustomerName.Text;
                objCustomerModel.ContactNo = txtContact_No.Text;
                objCustomerModel.Address1 = txtAddress1.Text;
                objCustomerModel.Address2 = txtAddress2.Text;
                objCustomerModel.City = txtCity.Text;
                objCustomerModel.Pincode = txtPincode.Text;
                objCustomerModel.Vat_Tin = txtVAT_Tin.Text;
                objCustomerModel.CST_No = txtCST_No.Text;
                objCustomerModel.Flag = 3;
                objCustomerInfoManager.DeleteCustomer(objCustomerModel);
                BindGrid();
            }
            catch (Exception ex)
            {
                
                ErrorLogging.LogError(ex);
            }
        }
    }
}