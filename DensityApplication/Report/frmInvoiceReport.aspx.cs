using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using System.Data;
using BusinessAccessLayer.ModProject;
using DensityApplication.dbbilldsTableAdapters;
using DensityApplication.dsBillTableAdapters;
using DensityApplication.Client.UI;
using DensityApplication.Common;
using System.Data.SqlClient;
namespace DensityApplication.Report
{
    public partial class frmInvoiceReport : System.Web.UI.Page
    {
        DataSet ds;
        SqlDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //BindCustomerDropdown();
            }
        }

        public void show()
        {
            ReportDocument rptDoc = new ReportDocument();
            string getbill = Session["getbill"].ToString();
            if (Session["getcust"] != null)
            {
                if (Session["getbill"] != null)
                {
                    //string getbill = Session["getbill"].ToString();
                }
                string getcust = Session["getcust"].ToString();
                string qurydata = " SELECT tblCustomerInfo.CustomerId,tblCustomerInfo.CustomerName,tblCustomerInfo.Address1,tblCustomerInfo.Address2,tblCustomerInfo.City,tblCustomerInfo.Pincode,tblCustomerInfo.ContactNo,tblDescription.Id,tblDescription.Particulars,tblDescription.Quantity,tblDescription.Rate,tblDescription.TotalAmount,tblDescription.VAT_12,tblDescription.CST_2,tblDescription.PurchaseOrderDate, tblBillDetails.NET_12,tblBillDetails.VAT_12 AS Expr1,tblBillDetails.NET_2,tblBillDetails.CST_2 AS Expr2, tblBillDetails.TotalAmount AS Expr3 FROM tblCustomerInfo INNER JOIN tblDescription ON tblCustomerInfo.Id=tblDescription.Id INNER JOIN tblBillDetails ON tblCustomerInfo.CustomerId = tblBillDetails.CustomerId INNER JOIN tblBillData ON tblCustomerInfo.Id = tblBillData.Id where CustomerId='" + getcust + "'AND BillId='" + getbill + "'";
            
            dsBill  ds = new dsBill(); // .xsd file name
            
            //string getcust = Session["getcust"].ToString();
            DataTable dt = new DataTable();
            NewSelectCommandTableAdapter dt1 = new NewSelectCommandTableAdapter();

            // Just set the name of data table
            dt.TableName = "Crystal Report Example";
            dt = datareport(); //This function is located below this function
            ds.Tables[0].Merge(dt);

            // Your .rpt file path will be below
            rptDoc.Load(Server.MapPath("~\\CrystalReport1.rpt"));

            //set dataset to the report viewer.
            rptDoc.SetDataSource(ds);
            crtInvoice.ReportSource = rptDoc;
            crtInvoice.DataBind();
            crtInvoice.RefreshReport();
            }
            else
{
                Label l1 = new Label();
                l1.Text = "Data Not Avialable";
            }
        }

        protected void crtInvoice_Init(object sender, EventArgs e)
        {
            show();
        }

        public DataTable  datareport()
        {
            string conn = "Data Source=SAGAR-PC;Initial Catalog=DensityDB;Persist Security Info=True;User ID=sa;Password=sagar";
            string getbill = "CIN14";
            string getcust = "534sag";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            //SqlCommand qurydata = new SqlCommand("SELECT tblCustomerInfo.CustomerId,tblCustomerInfo.CustomerName,tblCustomerInfo.Address1,tblCustomerInfo.Address2,tblCustomerInfo.City,tblCustomerInfo.Pincode,tblCustomerInfo.ContactNo,tblDescription.Id,tblDescription.Particulars,tblDescription.Quantity,tblDescription.Rate,tblDescription.TotalAmount,tblDescription.VAT_12,tblDescription.CST_2,tblDescription.PurchaseOrderDate, tblBillDetails.NET_12,tblBillDetails.VAT_12 AS Expr1,tblBillDetails.NET_2,tblBillDetails.CST_2 AS Expr2, tblBillDetails.TotalAmount AS Expr3 FROM tblCustomerInfo INNER JOIN tblDescription ON tblCustomerInfo.Id=tblDescription.Id INNER JOIN tblBillDetails ON tblCustomerInfo.CustomerId = tblBillDetails.CustomerId INNER JOIN tblBillData ON tblCustomerInfo.Id = tblBillData.Id where CustomerId='" + getcust + "'AND BillId='" + getbill + "'",con);
            SqlCommand query = new SqlCommand("select * from tblCustomerInfo as A inner join tblDescription as B on A.CustomerId=B.CustomerId inner join tblBillData as C on B.CustomerId=C.CustomerId where A.CustomerId='" + getcust + "' and C.BillId='" + getbill + "'", con);
            query.ExecuteNonQuery();
            ds = new DataSet();
            da = new SqlDataAdapter(query);
            da.Fill(ds, "Data");
            con.Close();
            return ds.Tables[0];
        }
    }
}