using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;
using BusinessAccessLayer.ModLogin;
//using ClientUI.Common;
using System.Data.Sql;
using ClientUI.Common;
namespace DensityApplication.ModLogin
{
    public partial class Login : System.Web.UI.Page
    {
        LoginManager loginManager;
        Logger log = new Logger();

        /// <summary>
        /// Page Load 
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Button Login Click Event
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        protected void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                string username = txtUserName.Value;
                string password = txtPassword.Value;
                Authentication(username, password);
            }
            catch (Exception ex)
            {
                log.append(ex.Message, 50);
            }
        }

        /// <summary>
        /// Method for Authentication User
        /// </summary>
        /// <param name="username">string</param>
        /// <param name="password">string</param>
        private void Authentication(string username, string password)
        {
            loginManager = new LoginManager();
            DataTable dt = new DataTable();

            // commonMethod = new CommonMethod();
            try
            {

                dt = loginManager.Authentication(username, password);

                if (dt.Rows.Count > 0)
                {

                    Session["UserName"] = username;

                    Session["Password"] = password;

                   // Session["UserTypeId"] = Convert.ToString(dt.Rows[0]["UserTypeId"].ToString());

                    Session["Id"] = Convert.ToString(dt.Rows[0]["LoginId"].ToString());

                  //  Session["IsAllowedLogin"] = Convert.ToBoolean(dt.Rows[0]["IsAllowedLogin"]);
                    //Session["Photo"] = (byte[])dt.Rows[0]["Photo"];
                    // Response.Redirect("..\\DefaultPage.aspx", false);

                    Response.Redirect("~/ModProject/FrmLandingPage.aspx", false);
                    //string modulePage = string.Empty;
                    //modulePage = "../DefaultPage.aspx";
                    //int height = Convert.ToInt32(hdfHeight.Value);
                    //int width = Convert.ToInt32(hdfWidth.Value);
                    //string attributes = "menubar=0,location=yes,type=fullWindow,fullscreen,scrollbar=no,toolbar=no,resizable=yes,left=0,top=0,width=" + width + ",height=" + height;
                    //ClientScript.RegisterClientScriptBlock(this.GetType(), "OpenWindow", "<script>javascript:openWindow('" + modulePage + "','" + attributes + "');</script>");


                }
                else
                {
                    MessageHelper.ShowCommanMessage(this.Page, "Wrong username or password");
                    // lblmsg.Text = "Login Failed.........";
                }
            }
            catch (Exception ex)
            {
                log.append(ex.Message, 50);
            }
        }
    }
}