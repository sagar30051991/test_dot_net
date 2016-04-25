using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DensityApplication.Client.UI;
using BusinessAccessLayer.ModProject;
using DensityApplication.Common;
using BusinessAccessLayer.Model.ModProject;

namespace DensityApplication.ModProject
{
    public partial class FrmBillingDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCustomerDropdown();
                btnSavedItem.Enabled = false;
                ddlCST_VAT.Enabled = false;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            
            BillingDetailsManager objBillingDetailsManager = new BillingDetailsManager();
            try
            {

                BillingModel objBillingModel = new BillingModel();
                string id = Convert.ToString(ddlCustomerName.SelectedValue);
               // DateTime a = Convert.ToDateTime(dpFromDate.SelectedDate);
              
               // string sDate = a.ToString("yyyyMMdd") + " 00:00:00";
                //DateTime stDate = DateTime.ParseExact(sDate, "yyyyMMdd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
               // objBillingModel.PurchaseOrderDate = sDate;
                objBillingModel.CustomerId = Convert.ToString(ddlCustomerName.SelectedValue);
                objBillingModel.Particular = Convert.ToString(txtParticular.Text);
                objBillingModel.Qty = Convert.ToString(txtQty.Text);
                objBillingModel.Rate=Convert.ToString(txtRate.Text);
                double qtyrate = Convert.ToDouble(txtQty.Text) * Convert.ToDouble(txtRate.Text);
                double cstcal = Convert.ToDouble(qtyrate) *2/100;
                double vatcal = Convert.ToDouble(qtyrate) * 12.5 / 100;
                objBillingModel.Vat12_5 = Convert.ToString(vatcal);
                objBillingModel.CST2 = Convert.ToString(cstcal);
                objBillingModel.TotalAmount = Convert.ToString(qtyrate);
                objBillingModel.Flag = 1;
                objBillingDetailsManager.AddBillDescription(objBillingModel);
                BindGrid(id);
                
            }
            catch (Exception ex)
            {
                ErrorLogging.LogError(ex);
            }
        }

        public void BindGrid(string customerId)
        {
            try
            {
                BillingDetailsManager objBillingDetailsManager = new BillingDetailsManager();
                DataTable dtItems = new DataTable();
                dtItems = objBillingDetailsManager.GetItems(customerId);
                grdItemsDetail.DataSource = dtItems;
                grdItemsDetail.DataBind();
            }
            catch (Exception ex)
            {
                ErrorLogging.LogError(ex);
            }
        }

       
        public void BindCustomerDropdown()
        {           
            DataTable dtCustomer = new DataTable();
            BillingDetailsManager objBillingDetails=new BillingDetailsManager();
            dtCustomer.Dispose();
            try
            {
                dtCustomer = objBillingDetails.GetCustomer();
                DropDownHelper.DropDownListBindWithoutPleaseSelect(dtCustomer, ddlCustomerName, "CustomerName", "CustomerId");

            }
            catch (Exception ex)
            {
                ErrorLogging.LogError(ex);
            }
        }

        protected void btnSavedItem_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(ddlCustomerName.SelectedValue);
            BillingDetailsManager objBillingDetailsManager = new BillingDetailsManager();
            try
            {

                BillingModel objBillingModel = new BillingModel();
                objBillingModel.CustomerId = Convert.ToString(ddlCustomerName.SelectedValue);
                int low = 1;
                int high = 1000;
                Random rndNumber = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber));
                int rndno = rndNumber.Next(low, high);

                string BillId = "CIN" + rndno;
                objBillingModel.BillId = Convert.ToString(BillId);
                DateTime a = Convert.ToDateTime(dpFromDate.SelectedDate);

                string sDate = a.ToString("yyyyMMdd") + " 00:00:00";
                DateTime stDate = DateTime.ParseExact(sDate, "yyyyMMdd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                //objBillingModel.PurchaseOrderDate = Convert.ToDateTime(txtQty.Text);
                int  cst_vat = Convert.ToInt32(ddlCST_VAT.SelectedValue);
                if (cst_vat == 1)
                {
                    objBillingModel.CST_VAT = false;
                }
                else
                {
                    objBillingModel.CST_VAT = true;
                }
                //objBillingModel.Flag = 1;
                objBillingDetailsManager.AddBillData(objBillingModel);

            }
            catch (Exception ex)
            {
                ErrorLogging.LogError(ex);
            }
        }

        protected void ChbSave_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbSave.Checked == true)
            {
                ddlCST_VAT.Enabled = true;
                btnSavedItem.Enabled = true;
                ddlCustomerName.Enabled = false;
                dpFromDate.Enabled = false;
                txtParticular.Enabled = false;
                txtQty.Enabled = false;
                txtRate.Enabled = false;
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;
            }

            if (ChbSave.Checked == false)
            {
                ddlCST_VAT.Enabled = false;
                btnSavedItem.Enabled = false;
                ddlCustomerName.Enabled = true;
                dpFromDate.Enabled = true;
                txtParticular.Enabled = true;
                txtQty.Enabled = true;
                txtRate.Enabled = true;
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnClear.Enabled = true; 
            }
            
        }
    }
}