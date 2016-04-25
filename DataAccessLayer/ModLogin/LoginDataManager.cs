using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Density.UI;

namespace DataAccessLayer.ModLogin
{
    public class LoginDataManager
    {
        /// <summary>
        /// Method for Authentication User
        /// </summary>
        /// <param name="username">string</param>
        /// <param name="password">string</param>
        /// <returns>DataTable</returns>
        public DataTable Authentication(string username, string password)
        {
            try
            {
                //string query = "select *  FROM tblUser WHERE UserName='" + username + "' and Password='" + password + "' and IsAllowedLogin=1";

                string query = "select *  FROM tblMstLogin WHERE UserName='" + username + "' and Password='" + password + "'";
                return DBOperate.GetDataTableWithoutSP(query);
            }
            catch
            {

                throw;
            }
        }
    }
}
