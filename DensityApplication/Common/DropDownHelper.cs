namespace DensityApplication.Client.UI
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Globalization;
    using System.Linq;    
    using Telerik.Web.UI;
    using System.Web.UI.WebControls;

    /// <summary>
    /// Drop down helper class
    /// </summary>
    public static class DropDownHelper
    {
        /// <summary>
        /// Drop down list bind
        /// </summary>
        /// <param name="dropDownTable">The database drop down table</param>
        /// <param name="radComboBox">The drop down control</param>
        /// <param name="displyName">The display name</param>
        /// <param name="value">The value</param>
        public static void DropDownListBind(DataTable dropDownTable, RadComboBox radComboBox, string displyName, string value)
        {
            try
            {
                radComboBox.Items.Clear();
                for (int i = 0; i < dropDownTable.Rows.Count; i++)
                {
                    RadComboBoxItem item = new RadComboBoxItem();                    
                    item.Text = dropDownTable.Rows[i][displyName].ToString();
                    item.Value = dropDownTable.Rows[i][value].ToString();
                    radComboBox.Items.Add(item);
                    item.Dispose();
                }

                //radComboBox.Items.Insert(0, new RadComboBoxItem("PleaseSelect", "0"));
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// drop down list bind with select all item
        /// </summary>
        /// <param name="dropDownTable">DataTable</param>
        /// <param name="radComboBox">RadComboBox</param>
        /// <param name="displyName">string</param>
        /// <param name="value">string</param>
        public static void DropDownListBindWithSelectAll(DataTable dropDownTable, RadComboBox radComboBox, string displyName, string value)
        {
            try
            {
                radComboBox.Items.Clear();
                for (int i = 0; i < dropDownTable.Rows.Count; i++)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = dropDownTable.Rows[i][displyName].ToString();
                    item.Value = dropDownTable.Rows[i][value].ToString();
                    radComboBox.Items.Add(item);
                    item.Dispose();
                }

                radComboBox.Items.Insert(0, new RadComboBoxItem("SelectAll", "0"));
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// drop down list bind without please select item
        /// </summary>
        /// <param name="dropDownTable">DataTable</param>
        /// <param name="radComboBox">RadComboBox</param>
        /// <param name="displyName">string</param>
        /// <param name="value">string</param>
        public static void DropDownListBindWithoutPleaseSelect(DataTable dropDownTable, DropDownList radComboBox, string displyName, string value)
        {
            try
            {
                radComboBox.Items.Clear();
                for (int i = 0; i < dropDownTable.Rows.Count; i++)
                {
                    ListItem item = new ListItem();
                    item.Text = dropDownTable.Rows[i][displyName].ToString();
                    item.Value = dropDownTable.Rows[i][value].ToString();
                    radComboBox.Items.Add(item);
                  //  radComboBox.Items.Add(item);
                    radComboBox.ClearSelection();
                  //  item.Dispose();
                    
                }
                radComboBox.Items.Insert(0,new ListItem("Please Select","-1"));
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Drop down list bind
        /// </summary>
        /// <param name="dropDownTable">The database drop down table</param>
        /// <param name="radComboBox">The drop down control</param>
        /// <param name="displyName">The display name</param>
        /// <param name="value">The value</param>
        public static void DropDownROBind(DataTable dropDownTable, RadComboBox radComboBox, string displyName, string value)
        {
            try
            {
                radComboBox.Items.Clear();
                for (int i = 0; i < dropDownTable.Rows.Count; i++)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    string Ro = dropDownTable.Rows[i][displyName].ToString() + " (" + dropDownTable.Rows[i][value].ToString() + ')';
                    item.Text = Ro;
                    item.Value = dropDownTable.Rows[i][value].ToString();
                    radComboBox.Items.Add(item);
                    item.Dispose();
                }

                //radComboBox.Items.Insert(0, new RadComboBoxItem("PleaseSelect", "0"));
            }
            catch
            {
                throw;
            }
        }
    }
}