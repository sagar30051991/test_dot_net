using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

//using BusinessAccessLayer.Common;

namespace ClientUI.Common
{
    public class MessageHelper
    {
       // CommonMethodManager objCommonMethodManager = new CommonMethodManager();

       
        public static void ShowCommanMessage(Page page, string errorMessage)
        {
            try
            {
                string validationMessage = " " + errorMessage;

                string message = validationMessage + "','" + "Warning" + "','" + "Ok";

                message = "jAlert('" + message + "')";
              //  ScriptManager.RegisterClientScriptBlock(page, page.GetType(), Guid.NewGuid().ToString(), message, true);
                  ScriptManager.RegisterClientScriptBlock(page, page.GetType(), Guid.NewGuid().ToString(), message, true);
            }
            catch
            {
                throw;
            }
        }

        public static void ShowMessage(Page page, int result, int operation)
        {
            string message = string.Empty;

            switch (operation)
            {
                case 1:

                    message = MessageBuilder(1, result);
                    break;

                case 2:

                    message = MessageBuilder(2, result);
                    break;

                case 3:

                    message = MessageBuilder(3, result);
                    break;

                case 4:

                    message = MessageBuilder(4, result);
                    break;

                case 5:

                    message = MessageBuilder(5, result);
                    break;

                default:
                    break;
            }

            ScriptManager.RegisterClientScriptBlock(page, page.GetType(), Guid.NewGuid().ToString(), message, true);
        }
       
        public static string MessageBuilder(int operation, int result)
        {
            try
            {
                string message = string.Empty;
                switch (operation)
                {
                    case 1:
                        {
                            if (result == 0)
                            {
                                message = "Email Id with the same value already exists.',Warning ,Ok";
                            }

                            if (result == -1)
                            {
                                message = "Slot Name Already Exist',' Warning ', 'Ok";
                            }
                            if (result == 1)
                            {
                                message = "Record Saved Successfully.','Success','Ok";
                               
                            }

                            if (result == 2)
                            {
                                message = "Email Id with the same value already exists.','Warning' ,'Ok";
                            }
                            if (result == -2)
                            {
                                message = "Wing Map to other records','Warning' ,'Ok";
                            }
                            if (result == -3)
                            {
                                message = "Zone Map to other records','Warning' ,'Ok";
                            }
                        }
                        break;
                    case 2:
                        {
                            if (result == 1)
                            {
                                message = "Record has been Updated successfully.','Success' ,'Ok";
                            }

                            if (result == -1)
                            {
                                message = "Email Id with the same value already exists.',' Warning ', 'Ok";
                            }

                            if (result == -2)
                            {
                                message = "Technical error occur.,Warning ,Ok";
                            }
                        }

                        break;
                    case 3:
                        {
                            if (result == 1)
                            {
                                message = "Age below 18 can not applied for Corporate','Warning ','Ok";
                            }

                            if (result == -1)
                            {
                                message = "Record Deleted Successfully','Success ','Ok";
                            }

                            if (result == -2)
                            {
                                message = "Technical error occur. ,Warning ,Ok";
                            }

                            if (result == -3)
                            {
                                message = "Record can not be deleted because it is mapped.','Warning ','Ok";
                            }
                            if (result == 2)
                            {
                                message = "Select Records to Delete.','Warning ','Ok";
                            }
                        }
                        break;
                    case 4:

                        if (result == 1)
                        {
                            message = "Current Password is Wrong.','Warning ','OK";
                        }

                        if (result == 2)
                        {
                            message = "New Password and Confirm Password is Wrong.','Warning ','OK";
                        }
                        if (result == 3)
                        {
                            message = "Either UserName or EmailID is Wrong.','Warning ','OK";
                        }
                        if (result == 4)
                        {
                            message = "Enter UserName and MailID.','Warning ','OK";
                        }
                        if (result == -1)
                        {
                            message = "Your Current Password is same as Entered Password ','Warning','OK";
                        }
                        if (result == -2)
                        {
                            message = "Password Changed Successfully','Success','OK";
                        }
                        if (result == -3)
                        {
                            message = "Your Details Mailed Successfully','Success','OK'";
                        }

                        break;
                    case 5:

                        if (result == 0)
                        {
                            message = "please select Valid Date.','Warning ','OK";
                        }

                        if (result == 1)
                        {
                            message = "please select rate per liter is greater than 0.','Warning ','OK";

                        }
                        if (result == 2)
                        {
                            message = "please atleast one checkbox check.','Warning ','OK";
                        }
                        if (result == 3)
                        {
                            message = "Record has been saved successfully.','Success' ,'Ok";
                        }
                        if (result == -1)
                        {
                            message = "Please Enter Greater Than Zero Value.','Warning','OK";
                        }
                        break;

                    default:
                        break;
                }

                return "jAlert('" + message + "')";

            }
            catch
            {
                throw;
            }
        }
    }
}