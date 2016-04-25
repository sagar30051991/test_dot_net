using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessAccessLayer.ModProject;
using DensityApplication.Client.UI;
using DensityApplication.Common;
using BusinessAccessLayer.Report;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Configuration.Provider;
using System.Configuration;
using DensityApplication.dsBillTableAdapters;
using DensityApplication.dbbilldsTableAdapters;
namespace DensityApplication.Report
{
    public partial class frmInvoice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCustomerDropdown();
            }
           
        }

        public void BindCustomerDropdown()
        {
            DataTable dtCustomer = new DataTable();
            BillingDetailsManager objBillingDetails = new BillingDetailsManager();
            dtCustomer.Dispose();
            try
            {
                dtCustomer = objBillingDetails.GetCustomer();
                DropDownHelper.DropDownListBindWithoutPleaseSelect(dtCustomer, ddlCustomerName, "CustomerName", "CustomerId");
                
                //Response.Redirect("InvoiceReport.aspx");
            }
            catch (Exception ex)
            {
                ErrorLogging.LogError(ex);
            }
        }
        
        
        protected void ddlCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindcust_name();
        }
        public void bindcust_name()
        {
            string customerId = ddlCustomerName.SelectedValue;

            DataTable dtBill = new DataTable();
            BillingDetailsManager objBillingDetails = new BillingDetailsManager();
            dtBill.Dispose();
            try
            {
                dtBill = objBillingDetails.GetBillNo(customerId);
                DropDownHelper.DropDownListBindWithoutPleaseSelect(dtBill, ddlBillNo, "BillId", "Id");
                
            }
            catch (Exception ex)
            {
                ErrorLogging.LogError(ex);
            }
        }
        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            Session["getcust"] = ddlCustomerName.SelectedItem;
            Session["getbill"] = ddlCustomerName.SelectedItem;
            Response.Redirect("~\\Report\\frmInvoiceReport.aspx");
        }

        protected void CrystalReportViewer1_Init(object sender, EventArgs e)
        {
        }
    }
}