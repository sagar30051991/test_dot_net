using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccessLayer.ModLogin;

namespace BusinessAccessLayer.ModLogin
{
    public class LoginManager
    {
        /// <summary>
        /// Method for Authentication User
        /// </summary>
        /// <param name="username">string</param>
        /// <param name="password">string</param>
        /// <returns>DataTable</returns>
        public DataTable Authentication(string username, string password)
        {
            LoginDataManager obj = new LoginDataManager();
            try
            {
                return obj.Authentication(username, password);
            }
            catch
            {
                throw;
            }
        }
    }
}
