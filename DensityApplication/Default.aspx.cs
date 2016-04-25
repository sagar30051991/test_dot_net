using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DensityApplication
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportDocument rptdoc=new ReportDocument();
            dsBill ds=new dsBill();
            DataTable dt=new DataTable();
            dt.TableName="Test";
           // dt=getallData();
            ds.Tables[0].Merge(dt);
            rptdoc.Load(Server.MapPath("../BillReport.rpt"));
            rptdoc.SetDataSource(ds);
            CrystalReportViewer1.ReportSource=rptdoc;
        }
        //public DataTable getallData()
        //{

             //string   sqlCon = "DataSource=M2174256/JCISQLDATA;Initial Catalog=DensityDB;Persist Security Info=True;User ID=sa;Password=XMG3-Rel.1";
             //  SqlConnection Con = new SqlConnection(sqlCon);
             //  SqlCommand    cmd = new SqlCommand();
             //  DataSet ds = null;
             //  SqlDataAdapter adapter;
             //  try
             //  {
             //       Con.Open();
             //       //Stored procedure calling. It is already in sample db.
             //       cmd.CommandText = "getAllOrders";
             //       cmd.CommandType = CommandType.StoredProcedure;
             //       cmd.Connection = Con;
             //       ds = new DataSet();
             //       adapter = new SqlDataAdapter(cmd);
             //       adapter.Fill(ds, "Users");
             //   }
             //   catch (Exception ex)
             //   {
             //       throw new Exception(ex.Message);
             //   }
             //   finally
             //   {
             //       cmd.Dispose();
             //       if (Con.State != ConnectionState.Closed)
             //       Con.Close();
             //   }
             //   return ds.Tables[0];

       // }
    }
}