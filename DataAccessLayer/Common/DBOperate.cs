using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using Density.UI;


namespace Density.UI
{
    public class DBOperate
    {

        public static string ConnString = System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ToString();



        public DBOperate()
        {
            //
            // TODO: ÔÚ´Ë´¦Ìí¼Ó¹¹Ôìº¯ÊýÂß¼­
            //
        }

        /// <summary>
        /// Retrieve data table from database
        /// </summary>
        /// <param name="commandText">Command Text</param>
        /// <param name="parameters">Database Parameters</param>
        /// <returns>Returns data table</returns>
        public static DataTable GetDataTable(string commandText, SqlParameter[] parameters)
        {
            DataSet tableDetails = new DataSet();

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(ConnString))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.CommandText = commandText;
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Connection = sqlCon;
                    if (parameters != null)
                    {
                        foreach (SqlParameter sparam in parameters)
                        {
                            sqlCmd.Parameters.Add(sparam);
                        }
                    }

                    SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd);
                    sqlAdapter.Fill(tableDetails);
                }
            }
            catch
            {
                throw;
            }

            return tableDetails.Tables[0];
        }

        public static DataSet GetPageData(string Tables, string PK, string Fields, int PageSize, int PageIndex, ref int RowCount, string StrWhere, string Sort)
        {
            SqlConnection conn = new SqlConnection(ConnString);
            SqlDataAdapter adp = new SqlDataAdapter("Paging_RowCount", conn);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            adp.SelectCommand.Parameters.Add(new SqlParameter("@Tables", SqlDbType.VarChar, 1000));//±íÃû
            adp.SelectCommand.Parameters["@Tables"].Value = Tables;

            adp.SelectCommand.Parameters.Add(new SqlParameter("@PK", SqlDbType.VarChar, 100));//Ö÷¼ü×Ö¶Î
            adp.SelectCommand.Parameters["@PK"].Value = PK;


            adp.SelectCommand.Parameters.Add(new SqlParameter("@Fields", SqlDbType.VarChar, 2500));//ÒªÏÔÊ¾µÄ×Ö¶Î
            adp.SelectCommand.Parameters["@Fields"].Value = Fields;

            adp.SelectCommand.Parameters.Add(new SqlParameter("@PageNumber", SqlDbType.Int, 8));//µ±Ç°Ò³
            adp.SelectCommand.Parameters["@PageNumber"].Value = PageIndex;

            adp.SelectCommand.Parameters.Add(new SqlParameter("@PageSize", SqlDbType.Int, 8));//Ã¿Ò»Ò³µÄÊýÁ¿
            adp.SelectCommand.Parameters["@PageSize"].Value = PageSize;

            adp.SelectCommand.Parameters.Add(new SqlParameter("@Sort", SqlDbType.VarChar, 250));//ÅÅÐò×Ö¶Î
            adp.SelectCommand.Parameters["@Sort"].Value = Sort;


            adp.SelectCommand.Parameters.Add(new SqlParameter("@Group", SqlDbType.VarChar, 1000));//Group By·Ö×é×Ö¶Î
            adp.SelectCommand.Parameters["@Group"].Value = "";

            adp.SelectCommand.Parameters.Add(new SqlParameter("@Filter", SqlDbType.VarChar, 1500));//Ìõ¼þ
            adp.SelectCommand.Parameters["@Filter"].Value = StrWhere;
            DataSet ds = new DataSet();
            adp.Fill(ds, "InfoData");
            try
            {
                RowCount = int.Parse(ds.Tables[1].Rows[0][0].ToString());

            }
            catch
            {
                RowCount = 0;
            }
            conn.Close();

            return ds;

        }

        public static int CheckLogin(string Username, string Password, string IPAddress)
        {
            int levelid = 0;
            SqlConnection conn = new SqlConnection(ConnString);
            try
            {
                SqlCommand cmd = new SqlCommand("CheckLogin", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //add cmd parameter
                cmd.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar, 20));
                cmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 50));
                cmd.Parameters.Add(new SqlParameter("@IPAddress", SqlDbType.VarChar, 20));
                cmd.Parameters.Add(new SqlParameter("@LevelID", SqlDbType.Int));
                //
                cmd.Parameters["@Username"].Value = Username;
                cmd.Parameters["@Password"].Value = Password;
                cmd.Parameters["@IPAddress"].Value = IPAddress;
                cmd.Parameters["@LevelID"].Direction = ParameterDirection.Output;
                conn.Open();
                cmd.ExecuteNonQuery();
                //
                //
                string ggg = cmd.Parameters["@LevelID"].Value.ToString().Trim();
                string bb = ggg;
                levelid = int.Parse(cmd.Parameters["@LevelID"].Value.ToString().Trim());
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                conn.Close();
            }
            //
            return levelid;
        }

        //public static DataTable GetDataTable(string SQL)
        //{
        //    try
        //    {
        //        // HttpContext.Current.Response.Write(SQL);
        //        SqlConnection conn = new SqlConnection(ConnString);
        //        SqlCommand cmd = new SqlCommand(SQL,conn);
        //        cmd.CommandTimeout = 0;                     
        //        SqlDataAdapter dp = new SqlDataAdapter(cmd);
            
        //        DataSet ds = new DataSet();
        //        //Ö´ÐÐ
        //        dp.Fill(ds);
            
        //        return ds.Tables[0];
        //    }
        //    catch (Exception ex)
        //    {
        //        //HttpContext.Current.Response.End();
        //        throw (ex);
        //    }
        //}

        /// <summary>
        /// Retrieve data table from database 
        /// </summary>
        /// <param name="query">query</param>        
        /// <returns>Returns data table</returns>
        public static DataTable GetDataTable(string procedureName)
        {
            DataSet tableDetails = new DataSet();

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(ConnString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand(procedureName);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Connection = sqlCon;
                    SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd);
                    sqlAdapter.Fill(tableDetails);
                }
            }
            catch
            {
                throw;
            }

            return tableDetails.Tables[0];
        }
        //Ö´ÐÐ·ÖÒ³Ê½´æ´¢¹ý³Ì£¬·µ»ØDataTable
        public static DataTable GetDataTableUseProcedure(int PageSize, int PageCurrent, string FdName, string SelectStr, string FromStr, string WhereStr, string OrderByStr, out int CountRows, out int CountPage)
        {
            DataSet ds = new DataSet();
            CountRows = 0;
            CountPage = 0;
            try
            {
                SqlConnection conn = new SqlConnection(ConnString);
                //ÉèÖÃ²ÎÊý
                SqlCommand cmd = new SqlCommand("PageShowOne", conn);
                cmd.CommandType = CommandType.StoredProcedure;
              
                cmd.Parameters.Clear();
                //
                cmd.Parameters.Add(new SqlParameter("@PageSize", SqlDbType.Int, 4));
                cmd.Parameters.Add(new SqlParameter("@PageCurrent", SqlDbType.Int, 4));
                cmd.Parameters.Add(new SqlParameter("@FdName", SqlDbType.VarChar, 100));
                cmd.Parameters.Add(new SqlParameter("@SelectStr", SqlDbType.VarChar, 2000));
                cmd.Parameters.Add(new SqlParameter("@FromStr", SqlDbType.VarChar, 1000));
                cmd.Parameters.Add(new SqlParameter("@WhereStr", SqlDbType.VarChar, 2000));
                cmd.Parameters.Add(new SqlParameter("@OrderByStr", SqlDbType.VarChar, 1000));
                cmd.Parameters.Add(new SqlParameter("@CountRows", SqlDbType.Int, 4));
                cmd.Parameters.Add(new SqlParameter("@CountPage", SqlDbType.Int, 4));
                //
                cmd.Parameters["@PageSize"].Value = PageSize;
                cmd.Parameters["@PageCurrent"].Value = PageCurrent;
                cmd.Parameters["@FdName"].Value = FdName;
                cmd.Parameters["@SelectStr"].Value = SelectStr;
                cmd.Parameters["@FromStr"].Value = FromStr;
                cmd.Parameters["@WhereStr"].Value = WhereStr;
                cmd.Parameters["@OrderByStr"].Value = OrderByStr;
                cmd.Parameters["@CountRows"].Direction = ParameterDirection.Output;
                cmd.Parameters["@CountPage"].Direction = ParameterDirection.Output;
                //ÉèÖÃ²ÎÊý½áÊø
                SqlDataAdapter dp = new SqlDataAdapter();
                dp.SelectCommand = cmd;

                //Ö´ÐÐ
                dp.Fill(ds);
                //¼ÇÂ¼×ÜÊý
                CountRows = int.Parse(cmd.Parameters["@CountRows"].Value.ToString().Trim());
                //×ÜÒ³Êý


                CountPage = int.Parse(cmd.Parameters["@CountPage"].Value.ToString().Trim());
                //
                // return ds.Tables[0];
            }
            catch (Exception ex)
            {
               // ErrorLogging.LogError(ex);
                ds = null;
            }
            if (ds != null)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }

        //ÈÈÐÐSQLÓï¾ä·µ»ØDataRow
        public static DataRow GetDataRow(string SQL)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnString);
                SqlDataAdapter dp = new SqlDataAdapter(SQL, conn);
                DataSet ds = new DataSet();
                //Ö´ÐÐ
                dp.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    return ds.Tables[0].Rows[0];
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                //throw (ex);               
            }
            return null;
        }

        //store Ö´ÐÐSQLÓï¾ä£¬·µ»Ødatarow
        public static DataRow GetDataRowStore(string SQL)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnString);
                SqlCommand cmd = new SqlCommand("ExcuteSQL", conn);
                //set parameter
                cmd.Parameters.Add(new SqlParameter("@SQL", SqlDbType.VarChar, 500));
                cmd.Parameters["@SQL"].Value = SQL;
                //end
                SqlDataAdapter dp = new SqlDataAdapter();
                dp.SelectCommand = cmd;
                DataSet ds = new DataSet();
                //Ö´ÐÐ
                dp.Fill(ds);
                return ds.Tables[0].Rows[0];
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        //Ö´ÐÐSQLÓï¾ä£¬Èç£ºUpdate,InsertÓï¾äµÈ
        public static string ExcuteSql(string SQL)
        {
            //System.Web.HttpContext.Current.Response.Write(SQL);
            //System.Web.HttpContext.Current.Response.End();
            SqlConnection conn = new SqlConnection(ConnString);
            string output;
            try
            {
                SqlCommand cmd = new SqlCommand(SQL, conn);
                conn.Open();
                //Ö´ÐÐ
                output = (string)cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                conn.Close();
            }
            return output;
        }

        //ÅÐ¶ÏÊÇ·ñÓÐÊý¾Ý£¬Èç¹ûÓÐ·µ»ØTRUE
        public static bool IsExist(string SQL)
        {
            SqlConnection conn = new SqlConnection(ConnString);
            bool flag = false;
            try
            {
                //SqlDataAdapter dp = new SqlDataAdapter(SQL, conn);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                //Ö´ÐÐ
                //dp.Fill(ds);
                if (dr.Read())
                {
                    flag = true;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                conn.Close();
            }
            //
            return flag;

        }

       //drldownlist bind
        public static void DropDownListBind(string SQL, DropDownList Drl, string KeyName, string KeyValue)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnString);
                SqlDataAdapter dp = new SqlDataAdapter(SQL, conn);
                DataSet ds = new DataSet();
                //Ö´ÐÐ
                dp.Fill(ds);
                ListItem item;
                //
                Drl.Items.Clear();
                item = new ListItem("Please Select", "");
                Drl.Items.Add(item);
                //for
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i][KeyName].ToString() != "")
                    {
                        item = new ListItem(ds.Tables[0].Rows[i][KeyName].ToString(), ds.Tables[0].Rows[i][KeyValue].ToString());
                        Drl.Items.Add(item);
                    }
                }//for end
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public static void DropDownListBindAll(string SQL, DropDownList Drl, string KeyName, string KeyValue)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnString);
                SqlDataAdapter dp = new SqlDataAdapter(SQL, conn);
                DataSet ds = new DataSet();
                //Ö´ÐÐ
                dp.Fill(ds);
                ListItem item;
                //
                Drl.Items.Clear();
                item = new ListItem("All", "");
                Drl.Items.Add(item);
                //for
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i][KeyName].ToString() != "")
                    {
                        item = new ListItem(ds.Tables[0].Rows[i][KeyName].ToString(), ds.Tables[0].Rows[i][KeyValue].ToString());
                        Drl.Items.Add(item);
                    }
                }//for end
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        //public static void DropDownListBind2(string SQL, DropDownList Drl, string KeyName, string KeyValue)
        //{
        //    try
        //    {
        //        SqlConnection conn = new SqlConnection(ConnString);
        //        SqlDataAdapter dp = new SqlDataAdapter(SQL, conn);
        //        DataSet ds = new DataSet();
        //        //Ö´ÐÐ
        //        dp.Fill(ds);
        //        ListItem item;
        //        //
        //        Drl.Items.Clear();
        //        item = new ListItem("Please Select", "");
        //        item = new ListItem("All Cuisines", "-1");
        //        Drl.Items.Add(item);
        //        //for
        //        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //        {
        //            item = new ListItem(ds.Tables[0].Rows[i][KeyName].ToString(), ds.Tables[0].Rows[i][KeyValue].ToString());
        //            Drl.Items.Add(item);
        //        }//for end
        //    }
        //    catch (Exception ex)
        //    {
        //        throw (ex);
        //    }
        //}

        //ÏÂÀ­¿òÊý¾Ý°ó¶¨, //drldownlist bind
        //public static void DropDownListBind(string SQL, DropDownList Drl, string KeyName, string KeyValue, bool Status)
        //{
        //    try
        //    {
        //        SqlConnection conn = new SqlConnection(ConnString);
        //        SqlDataAdapter dp = new SqlDataAdapter(SQL, conn);
        //        DataSet ds = new DataSet();
        //        //Ö´ÐÐ
        //        dp.Fill(ds);
        //        ListItem item;
        //        //
        //        Drl.Items.Clear();
        //        //for
        //        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //        {
        //            item = new ListItem(ds.Tables[0].Rows[i][KeyName].ToString(), ds.Tables[0].Rows[i][KeyValue].ToString());
        //            Drl.Items.Add(item);
        //        }//for end
        //    }
        //    catch (Exception ex)
        //    {
        //        throw (ex);
        //    }
        //}
        ////ÏÂÀ­¿òÊý¾Ý°ó¶¨, //drldownlist bind
        //public static void DropDownListBind(string SQL, DropDownList Drl, string KeyName, string KeyValue, string SelectStr)
        //{
        //    try
        //    {
        //        SqlConnection conn = new SqlConnection(ConnString);
        //        SqlDataAdapter dp = new SqlDataAdapter(SQL, conn);
        //        DataSet ds = new DataSet();
        //        //Ö´ÐÐ
        //        dp.Fill(ds);
        //        ListItem item;
        //        //
        //        Drl.Items.Clear();
        //        item = new ListItem(SelectStr, "");
        //        Drl.Items.Add(item);
        //        //for
        //        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //        {
        //            item = new ListItem(ds.Tables[0].Rows[i][KeyName].ToString(), ds.Tables[0].Rows[i][KeyValue].ToString());
        //            Drl.Items.Add(item);
        //        }//for end
        //    }
        //    catch (Exception ex)
        //    {
        //        throw (ex);
        //    }
        //}
        ////ÏÂÀ­¿òÊý¾Ý°ó¶¨, //drldownlist bind
        //public static void DropDownListBind(int Count, DropDownList Drl)
        //{
        //    try
        //    {
        //        ListItem item;
        //        //
        //        Drl.Items.Clear();
        //        item = new ListItem("Please Select", "");
        //        Drl.Items.Add(item);
        //        //for
        //        for (int i = 0; i < Count; i++)
        //        {
        //            item = new ListItem(i.ToString(), i.ToString());
        //            Drl.Items.Add(item);
        //        }//for end
        //    }
        //    catch (Exception ex)
        //    {
        //        throw (ex);
        //    }
        //}

        ////ÏÂÀ­¿òÊý¾Ý°ó¶¨, //drldownlist bind
        ////public static void FillControlByEnum(Control c, Type enumtype, bool IsAddAll)

        //public static void DropDownListBind(Type em, DropDownList Drl)
        //{
        //    Drl.Items.Clear();
        //    string[] names = Enum.GetNames(em);
        //    Array values = Enum.GetValues(em);
        //    ListItem[] listItems = new ListItem[names.GetLength(0)];

        //    for (int i = 0; i < names.GetLength(0); i++)
        //    {
        //        int j = (int)values.GetValue(i);
        //        Drl.Items.Add(new ListItem(names[i].ToString(), j.ToString()));
        //        //System.Web.HttpContext.Current.Response.Write(names[i].ToString() + "<br>");
        //    }

        //    //SiteConfig.CustomerLocation[] o = (SiteConfig.CustomerLocation[])Enum.GetValues(typeof(SiteConfig.CustomerLocation));
        //    //for (int x = 0; x < o.Length; x++)
        //    //{
        //    //    SiteConfig.CustomerLocation aax = ((SiteConfig.CustomerLocation)(o[x]));

        //    // Drl.Items.Add
        //    //     (new ListItem(aax.ToString("G"), ((SiteConfig.CustomerLocation)aax).ToString("D")));
        //    //}


        //}


        /////<summary>
        ///// ´«ÈëÊý×Ö£¬µÃµ½ÏÂÀ­¿òÏÂÀ­¿òÊý¾Ý°ó¶¨, //drldownlist bind
        /////</summary>
        //public static void DropDownListBind(int Count, DropDownList Drl, string SelectString)
        //{
        //    try
        //    {
        //        ListItem item;
        //        //
        //        Drl.Items.Clear();
        //        item = new ListItem(SelectString, "");
        //        Drl.Items.Add(item);
        //        //for
        //        for (int i = 0; i < Count; i++)
        //        {
        //            item = new ListItem(i.ToString(), i.ToString());
        //            Drl.Items.Add(item);
        //        }//for end
        //    }
        //    catch (Exception ex)
        //    {
        //        throw (ex);
        //    }
        //}
        //update last logintime

        public static void UpdateLastLogin(DateTime LastLogin, string Username)
        {
            SqlConnection conn = new SqlConnection(ConnString);
            try
            {
                SqlCommand cmd = new SqlCommand("UpdateLastLogin", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //set parameters
                cmd.Parameters.Add(new SqlParameter("@LastLogin", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar, 20));
                //
                cmd.Parameters["@LastLogin"].Value = LastLogin;
                cmd.Parameters["@Username"].Value = Username;
                //end
                conn.Open();
                //Ö´ÐÐ
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Retrieve data table from database
        /// </summary>
        /// <param name="query">Query</param>
        /// <returns>Returns data table</returns>
        public static DataTable GetDataTableWithoutSP(string query)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(ConnString))
                {
                    SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, sqlCon);

                    DataSet tableDetails = new DataSet();
                    sqlAdapter.Fill(tableDetails);

                    return tableDetails.Tables[0];
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Execute the procedure
        /// </summary>
        /// <param name="commandText">Command Text</param>
        /// <param name="parameters">Parameters</param>
        /// <returns>If 1 Successful,-1 Already exist, -2 Server Error</returns>
        public static int ExecuteProcedure(string commandText, SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(ConnString))
                {
                    sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.CommandText = commandText;
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Connection = sqlCon;

                    if (parameters != null)
                    {
                        foreach (SqlParameter sparam in parameters)
                        {
                            sqlCmd.Parameters.Add(sparam);
                        }

                        sqlCmd.Parameters["@ReturnVal"].Direction = ParameterDirection.Output;
                    }

                    sqlCmd.ExecuteNonQuery();

                    return Convert.ToInt32(sqlCmd.Parameters["@ReturnVal"].Value);
                }
            }
            catch
            {
                throw;
            }
        }

        //public static void DropDownListBind(string SQL, ComboBox Drl, string KeyName, string KeyValue)
        //{
        //    try
        //    {
        //        SqlConnection conn = new SqlConnection(ConnString);
        //        SqlDataAdapter dp = new SqlDataAdapter(SQL, conn);
        //        DataSet ds = new DataSet();
        //        //Ö´ÐÐ
        //        dp.Fill(ds);
        //        ListViewItem item;

        //        //
        //        Drl.Items.Clear();
        //        //item = new ListViewItem("Please Select");
        //        //Drl.Items.Add(item);
        //        //for
        //        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //        {
        //            //item = new ListViewItem(ds.Tables[0].Rows[i][KeyName].ToString(),ds.Tables[0].Rows[i][KeyValue].ToString());
        //            Drl.ValueMember=ds.Tables[0].Rows[i][KeyName].ToString();
        //            Drl.Items.Add(ds.Tables[0].Rows[i][KeyValue].ToString());
        //            //Drl.Items.Add(item);
        //            Drl.SelectedIndex = 0;
        //        }//for end
        //    }
        //    catch (Exception ex)
        //    {
        //        throw(ex);
        //        // MessageBox.Show("Cannot connect to the database.");
        //        //throw (ex);
        //    }
        //}
    }
}
