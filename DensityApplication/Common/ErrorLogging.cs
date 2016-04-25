using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Data.Sql;

namespace DensityApplication.Common
{
    public static class ErrorLogging
    {
        /// <summary>
        /// The log error
        /// </summary>
        /// <param name="ex">The exception</param>
        public static void LogError(Exception ex)
        {
            bool checkLog = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["EnableLog"]);

            if (checkLog)
            {
                HandleException(ex);
            }
        }

        /// <summary>
        /// Handle the exception in database
        /// </summary>
        /// <param name="ex">The exception</param>
        public static void HandleException(Exception ex)
        {
            HttpContext ctxObject = HttpContext.Current;
            string strLogConnString = System.Configuration.ConfigurationManager.ConnectionStrings["Constring"].ToString();
            string logDateTime = DateTime.Now.ToString("g");
            string strReqURL = (ctxObject.Request.Url != null) ? ctxObject.Request.Url.ToString() : string.Empty;
            string strReqQS = (ctxObject.Request.QueryString != null) ? ctxObject.Request.QueryString.ToString() : string.Empty;
            string strServerName = string.Empty;

            if (ctxObject.Request.ServerVariables["HTTP_REFERER"] != null)
            {
                strServerName = ctxObject.Request.ServerVariables["HTTP_REFERER"].ToString();
            }

            string strUserAgent = (ctxObject.Request.UserAgent != null) ? ctxObject.Request.UserAgent : string.Empty;
            string strUserIP = (ctxObject.Request.UserHostAddress != null) ? ctxObject.Request.UserHostAddress : string.Empty;
            string strUserAuthen = (ctxObject.User.Identity.IsAuthenticated.ToString() != null) ? ctxObject.User.Identity.IsAuthenticated.ToString() : string.Empty;
            string strUserName = (ctxObject.User.Identity.Name != null) ? ctxObject.User.Identity.Name : string.Empty;
            string strMessage = string.Empty, strSource = string.Empty, strTargetSite = string.Empty, strStackTrace = string.Empty;

            while (ex != null)
            {
                strMessage = ex.Message;
                strSource = ex.Source;
                strTargetSite = ex.TargetSite.ToString();
                strStackTrace = ex.StackTrace;
                ex = ex.InnerException;
            }

            if (strLogConnString.Length > 0)
            {
                SqlCommand strSqlCmd = new SqlCommand();
                strSqlCmd.CommandType = CommandType.StoredProcedure;
                strSqlCmd.CommandText = "get_LogExceptionToDB";
                SqlConnection sqlConn = new SqlConnection(strLogConnString);
                strSqlCmd.Connection = sqlConn;
                sqlConn.Open();
                try
                {
                    strSqlCmd.Parameters.Add(new SqlParameter("@Source", strSource.Trim()));
                    strSqlCmd.Parameters.Add(new SqlParameter("@LogDateTime", DateTime.Parse(logDateTime.Trim()).ToString("yyyyMMdd HH:mm:ss")));
                    strSqlCmd.Parameters.Add(new SqlParameter("@Message", strMessage.Trim()));
                    strSqlCmd.Parameters.Add(new SqlParameter("@QueryString", strReqQS.Trim()));
                    strSqlCmd.Parameters.Add(new SqlParameter("@TargetSite", strTargetSite.Trim()));
                    strSqlCmd.Parameters.Add(new SqlParameter("@StackTrace", strStackTrace.Trim()));
                    strSqlCmd.Parameters.Add(new SqlParameter("@ServerName", strServerName.Trim()));
                    strSqlCmd.Parameters.Add(new SqlParameter("@RequestURL", strReqURL.Trim()));
                    strSqlCmd.Parameters.Add(new SqlParameter("@UserAgent", strUserAgent.Trim()));
                    strSqlCmd.Parameters.Add(new SqlParameter("@UserIP", strUserIP.Trim()));
                    strSqlCmd.Parameters.Add(new SqlParameter("@UserAuthentication", strUserAuthen.Trim()));
                    strSqlCmd.Parameters.Add(new SqlParameter("@UserName", strUserName.Trim()));
                    SqlParameter outParm = new SqlParameter("@EventId", SqlDbType.Int);
                    outParm.Direction = ParameterDirection.Output;
                    strSqlCmd.Parameters.Add(outParm);
                    strSqlCmd.ExecuteNonQuery();
                }
                catch (Exception exc)
                {
                    EventLog.WriteEntry(exc.Source, "Database Error From Exception Log!", EventLogEntryType.Error, 65535);
                }
                finally
                {
                    strSqlCmd.Dispose();
                    sqlConn.Close();
                }
            }



        }
    }
}