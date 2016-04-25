//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Data;
//using BusinessAccessLayer.Common;
//using BusinessAccessLayer.Model.ModProject;

//namespace ControlX_Application.Common
//{
//    public class CommonMethod
//    {
//        CommonMethodManager commonMethodManager;

//        /// <summary>
//        /// Get Module master By RoleId
//       /// </summary>
//        /// <param name="userType">DataTable</param>
//        /// <returns>int</returns>
//        public DataTable GetModuleMasterByRoleIdBAL(int userType)
//        {
//            commonMethodManager = new CommonMethodManager();
//            try
//            {
//                return commonMethodManager.GetModuleMasterByRoleIdBAL(userType);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Get Module master By User
//        /// </summary>
//        /// <param name="userType">DataTable</param>
//        /// <returns>int</returns>
//        public DataTable GetModuleMasterByUser(int userType)
//        {
//            commonMethodManager = new CommonMethodManager();
//            try
//            {
//                return commonMethodManager.GetModuleMasterByUser(userType);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Get Menu State
//        /// </summary>
//        /// <param name="userTypeId">DataTable</param>
//        /// <returns>int</returns>
//        public DataTable GetMenuState(int userTypeId)
//        {
//            commonMethodManager = new CommonMethodManager();
//            try
//            {
//                return commonMethodManager.GetMenuState(userTypeId);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//       /// Method to get User Type
//       /// </summary>
//        /// <returns>DataTable</returns>
//        public DataTable GetUserType()
//        {
//            commonMethodManager = new CommonMethodManager();
//            try
//            {
//                return commonMethodManager.GetUserType();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get User name
//        /// </summary>
//        /// <returns>DataTable</returns>
//        public DataTable GetUserName()
//        {
//            commonMethodManager = new CommonMethodManager();
//            try
//            {
//                return commonMethodManager.GetUserName();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method for Modify Module Access Mapping
//        /// </summary>
//        /// <param name="objUserZoneMappingModel">UserZoneMappingModel</param>
//        public void ModifyModuleAccessMapping(UserZoneMappingModel objUserZoneMappingModel)
//        {
//            commonMethodManager = new CommonMethodManager();
//            try
//            {
//                this.commonMethodManager.ModifyModuleAccessMapping(objUserZoneMappingModel);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method for Modify Zone Mapping
//        /// </summary>
//        /// <param name="objUserZoneMappingModel">UserZoneMappingModel</param>
//        public void ModifyZoneMapping(UserZoneMappingModel lstUserZoneMappingModel)
//        {
//            commonMethodManager = new CommonMethodManager();
//            try
//            {
//                 this.commonMethodManager.ModifyZoneMapping(lstUserZoneMappingModel);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method for Delete Zone Mapping
//        /// </summary>
//        /// <param name="id">int</param>
//        public void DeleteZoneMapping(int id)
//        {
//            commonMethodManager = new CommonMethodManager();
//            try
//            {
//                this.commonMethodManager.DeleteZoneMapping(id);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method for Delete User Mapping
//        /// </summary>
//        /// <param name="id">int</param>
//        public void DeleteUserMapping(int id)
//        {
//            commonMethodManager = new CommonMethodManager();
//            try
//            {
//                this.commonMethodManager.DeleteUserMapping(id);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }
        
//        /// <summary>
//        /// Method for Add Wing
//        /// </summary>
//        /// <param name="lstWingModel">WingModel</param>
//        public void WingAdd(WingModel lstWingModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.WingAdd(lstWingModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        ///  Method for Add Module Wing
//        /// </summary>
//        /// <param name="lstWingModel">WingModel</param>
//        public void AddModuleWing(WingModel lstWingModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.AddModuleWing(lstWingModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method for Add Access Mapping
//        /// </summary>
//        /// <param name="objUserZoneMappingModel">UserZoneMappingModel</param>
//        public void AddAccessMapWing(UserZoneMappingModel objUserZoneMappingModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.AddAccessMapWing(objUserZoneMappingModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to Add Module Access Mapping
//        /// </summary>
//        /// <param name="objUserModel">UserModel</param>
//        public void AddModuleAccessMapping(UserModel objUserModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.AddModuleAccessMapping(objUserModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method for Update Module Wing
//        /// </summary>
//        /// <param name="lstWingModel">WingModel</param>
//        public void UpdateModuleWing(WingModel lstWingModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.UpdateModuleWing(lstWingModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to update Module Zone
//        /// </summary>
//        /// <param name="lstZoneModel">ZoneModel</param>
//        public void UpdateModuleZone(ZoneModel lstZoneModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.UpdateModuleZone(lstZoneModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to update Wing
//        /// </summary>
//        /// <param name="lstWingModel">WingModel</param>
//        public void WingUpdate(WingModel lstWingModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.WingUpdate(lstWingModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Wing Details
//        /// </summary>
//        /// <returns>DataTable</returns>
//        public DataTable GetWingDetails()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetWingDetails();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        ///  Method to get Wing Details By Id
//        /// </summary>
//        /// <param name="Id">int</param>
//        /// <returns>DataTable</returns>
//        public DataTable GetWingDetailsById(int Id)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetWingDetailsById(Id);
//            }
//            catch
//            {
//                throw;
//            }
//        }
        
//        /// <summary>
//        /// Method to get Wing Id
//        /// </summary>
//        /// <returns>int</returns>
//        public int GetWingId()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetWingId();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Module Id
//        /// </summary>
//        /// <returns>int</returns>
//        public int GetModuleId()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetModuleId();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Zone Id
//        /// </summary>
//        /// <returns>int</returns>
//        public int GetZoneId()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetZoneId();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Parent Id
//        /// </summary>
//        /// <param name="ParentId">string</param>
//        /// <returns>int</returns>
//        public int GetParentId(string ParentId)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetParentId(ParentId);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Device Id
//        /// </summary>
//        /// <returns>int</returns>
//        public int GetDeviceId()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetDeviceId();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Device Count
//        /// </summary>
//        /// <returns>int</returns>
//        public int GetDevicecount()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetDevicecount();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get User Id
//        /// </summary>
//        /// <returns>int</returns>
//        public int GetUserId()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetUserId();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Working Slot Id
//        /// </summary>
//        /// <returns>int</returns>
//        public int GetWorkingSlotId()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetWorkingSlotId();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Valid Slot Name
//        /// </summary>
//        /// <param name="SlotName">string</param>
//        /// <returns>DataTable</returns>
//        public DataTable GetValidSlotname(string SlotName)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetValidSlotname(SlotName);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Valid Email
//        /// </summary>
//        /// <param name="SlotName">string</param>
//        /// <returns>DataTable</returns>
//        public DataTable GetValidEmail(string Email)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetValidEmail(Email);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Valid Updated Email
//        /// </summary>
//        /// <param name="Email">string</param>
//        /// <param name="Id">int</param>
//        /// <returns>DataTable</returns>
//        public DataTable GetValidUpdateEmail(string Email,int Id)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetValidUpdateEmail(Email,Id);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Valid Slot Name for Update
//        /// </summary>
//        /// <param name="Email">string</param>
//        /// <param name="Id">int</param>
//        /// <returns>DataTable</returns>
//        public DataTable GetValidSlotnameForUpdate(string SlotName,int Id)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetValidSlotnameForUpdate(SlotName,Id);
//            }
//            catch
//            {
//                throw;
//            }
//        }
        
//        /// <summary>
//        /// Method to get Holiday Id
//        /// </summary>
//        /// <returns>int</returns>
//        public int GetHolidayId()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetHolidayId();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get All User
//        /// </summary>
//        /// <returns>int</returns>
//        public int GetAllUser()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetAllUser();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Company Id
//        /// </summary>
//        /// <returns>int</returns>
//        public int GetCompanyId()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetCompanyId();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        //public DataTable GetWingType()
//        //{
//        //    commonMethodManager = new CommonMethodManager();
//        //    try
//        //    {
//        //        return commonMethodManager.GetWingType();
//        //    }
//        //    catch
//        //    {
//        //        throw;
//        //    }
//        //}

//        /// <summary>
//        /// Method to get WingType
//        /// </summary>
//        /// <param name="Id">int</param>
//        /// <returns>DataTable</returns>
//        public DataTable GetWingType(int Id)
//        {
//            commonMethodManager = new CommonMethodManager();
//            try
//            {
//                return commonMethodManager.GetWingType(Id);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Zone By User
//        /// </summary>
//        /// <param name="ZoneId">int</param>
//        /// <param name="Id">int</param>
//        /// <returns>DataTable</returns>
//        public DataTable GetZoneByUser(int ZoneId,int Id)
//        {
//            commonMethodManager = new CommonMethodManager();
//            try
//            {
//                return commonMethodManager.GetZoneByUser(ZoneId, Id);
//            }
//            catch
//            {
//                throw;
//            }
//        }
        
//        /// <summary>
//        /// Method to Add Zone
//        /// </summary>
//        /// <param name="lstZoneModel">ZoneModel</param>
//        public void ZoneAdd(ZoneModel lstZoneModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.ZoneAdd(lstZoneModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to Add Zone Module
//        /// </summary>
//        /// <param name="lstZoneModel">ZoneModel</param>
//        public void ModuleZoneAdd(ZoneModel lstZoneModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.ModuleZoneAdd(lstZoneModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to Update Zone 
//        /// </summary>
//        /// <param name="lstZoneModel">ZoneModel</param>
//        public void ZoneUpdate(ZoneModel lstZoneModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.ZoneUpdate(lstZoneModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to Add Device
//        /// </summary>
//        /// <param name="lstDeviceModel">DeviceModel</param>
//        public void DeviceAdd(DeviceModel lstDeviceModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.DeviceAdd(lstDeviceModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to Update Device
//        /// </summary>
//        /// <param name="lstDeviceModel">DeviceModel</param>
//        public void DeviceUpdate(DeviceModel lstDeviceModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.DeviceUpdate(lstDeviceModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get device detail page
//        /// </summary>
//        /// <param name="lstDeviceModel">DeviceModel</param>
//        /// <returns>DataTable</returns>
//        public DataTable GetDeviceDetailsPage(DeviceModel lstDeviceModel)
//        {
//            try
//            {
            
//                return commonMethodManager.GetDeviceDetailsPage(lstDeviceModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to delete device
//        /// </summary>
//        /// <param name="lstDeviceModel">DeviceModel</param>
//        public void DeviceDelete(DeviceModel lstDeviceModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.DeviceDelete(lstDeviceModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Zone details
//        /// </summary>
//        /// <param name="Id">int</param>
//        /// <returns>DataTable</returns>
//        public DataTable GetZoneDetails(int Id)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetZoneDetails(Id);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Device details
//        /// </summary>
//        /// <returns>DataTable</returns>
//        public DataTable GetDeviceDetails()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetDeviceDetails();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Zone details by Id
//        /// </summary>
//        /// <param name="Id">int</param>
//        /// <returns>DataTable</returns>
//        public DataTable GetZoneDetailsById(int Id)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetZoneDetailsById(Id);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Device details by Id
//        /// </summary>
//        /// <param name="Id">int</param>
//        /// <returns>DataTable</returns>
//        public DataTable GetDeviceDetailsByID(int Id)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetDeviceDetailsByID(Id);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get User details by Id
//        /// </summary>
//        /// <param name="Id">int</param>
//        /// <returns>DataTable</returns>
//        public DataTable GetUserDetailsById(int Id)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetUserDetailsById(Id);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Working Slot details by Id
//        /// </summary>
//        /// <param name="Id">int</param>
//        /// <returns>DataTable</returns>
//        public DataTable GetWorkingSlotDetailsById(int Id)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetWorkingSlotDetailsById(Id);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Holiday details by Id
//        /// </summary>
//        /// <param name="Id">int</param>
//        /// <returns>DataTable</returns>
//        public DataTable GetHolidayDetailsById(int Id)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetHolidayDetailsById(Id);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to Add User
//        /// </summary>
//        /// <param name="lstUserModel">UserModel</param>
//        public void UserAdd(UserModel lstUserModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.UserAdd(lstUserModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to Update Working Days
//        /// </summary>
//        /// <param name="lstDay">List<int></param>
//        /// <param name="lstheck">List<int></param>
//        /// <param name="objWorkingDaysModel">WorkingDaysModel</param>
//        public void UpdateWorkingDays(List<int> lstDay, List<int> lstheck, WorkingDaysModel objWorkingDaysModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.UpdateWorkingDays(lstDay, lstheck, objWorkingDaysModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to Add Working Hrs
//        /// </summary>
//        /// <param name="lstDay">List<int></param>
//        /// <param name="lstWorkingHrsId">List<int></param>
//        /// <param name="lstSlot">List<int></param>
//        /// <param name="objMapWorkingHourModel">MapWorkingHourModel</param>
//        public void AddMapWorkinhHrs(List<int> lstDay, List<int> lstWorkingHrsId, List<string> lstSlot, MapWorkingHourModel objMapWorkingHourModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.AddMapWorkinhHrs(lstDay, lstWorkingHrsId, lstSlot, objMapWorkingHourModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to Add Working Slot
//        /// </summary>
//        /// <param name="lstWorkingSlotModel">WorkingSlotModel</param>
//        public void WorkingSlotAdd(WorkingSlotModel lstWorkingSlotModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.WorkingSlotAdd(lstWorkingSlotModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to Add Holiday
//        /// </summary>
//        /// <param name="lstHolidayModel">HolidayModel</param>
//        public void HolidayAdd(HolidayModel lstHolidayModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.HolidayAdd(lstHolidayModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to Update Holiday
//        /// </summary>
//        /// <param name="lstHolidayModel">HolidayModel</param>
//        public void HolidayUpdate(HolidayModel lstHolidayModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.HolidayUpdate(lstHolidayModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to Delete Holiday
//        /// </summary>
//        /// <param name="lstHolidayModel">HolidayModel</param>
//        public void HolidayDelete(HolidayModel lstHolidayModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.HolidayDelete(lstHolidayModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to Update Working Slot
//        /// </summary>
//        /// <param name="lstWorkingSlotModel">WorkingSlotModel</param>
//        public void WorkingSlotUpdate(WorkingSlotModel lstWorkingSlotModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.WorkingSlotUpdate(lstWorkingSlotModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }
        
//        /// <summary>
//        /// Method to Add Customer
//        /// </summary>
//        /// <param name="lstCustomerModel">CustomerModel</param>
//        public void CustomerAdd(CustomerModel lstCustomerModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.CustomerAdd(lstCustomerModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to Update Customer
//        /// </summary>
//        /// <param name="lstCustomerModel">CustomerModel</param>
//        public void CustomerUpdate(CustomerModel lstCustomerModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.CustomerUpdate(lstCustomerModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to Delete Customer
//        /// </summary>
//        /// <param name="lstCustomerModel">CustomerModel</param>
//        public void CustomerDelete(CustomerModel lstCustomerModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.CustomerDelete(lstCustomerModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to Update User
//        /// </summary>
//        /// <param name="lstUserModel">UserModel</param>
//        public void UserUpdate(UserModel lstUserModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.UserUpdate(lstUserModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to update Map Working Hour
//        /// </summary>
//        /// <param name="objMapWorkingHourModel">MapWorkingHourModel</param>
//        public void UpdateMapWorkingHour(MapWorkingHourModel objMapWorkingHourModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.UpdateMapWorkingHour(objMapWorkingHourModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to delete User
//        /// </summary>
//        /// <param name="lstUserModel">UserModel</param>
//        public void UserDelete(UserModel lstUserModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.UserDelete(lstUserModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to delete Module Access Mapping
//        /// </summary>
//        /// <param name="lstUserModel">UserModel</param>
//        public void DeleteModuleAccessMapping(UserModel lstUserModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.DeleteModuleAccessMapping(lstUserModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to delete Wing
//        /// </summary>
//        /// <param name="objWingModel">WingModel</param>
//        /// <returns>int</returns>
//        public int WingDelete(WingModel objWingModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.WingDelete(objWingModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to delete Zone
//        /// </summary>
//        /// <param name="objZoneModel">ZoneModel</param>
//        /// <returns>int</returns>
//        public int ZoneDelete(ZoneModel objZoneModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.ZoneDelete(objZoneModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to delete Working Slot
//        /// </summary>
//        /// <param name="lstWorkingSlotModel">WorkingSlotModel</param>
//        public void WorkingSlotDelete(WorkingSlotModel lstWorkingSlotModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                commonMethodManager.WorkingSlotDelete(lstWorkingSlotModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }
        
//        /// <summary>
//        /// Method to get User Details
//        /// </summary>
//        /// <returns>DataTable</returns>
//        public DataTable GetUserDetails()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetUserDetails();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Module Access Mapping Detail
//        /// </summary>
//        /// <returns>DataTable</returns>
//        public DataTable GetModuleAccessMappingDetail()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetModuleAccessMappingDetail();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Working Slot Details
//        /// </summary>
//        /// <returns>DataTable</returns>
//        public DataTable GetWorkingSlotDetails()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetWorkingSlotDetails();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Slot Details
//        /// </summary>
//        /// <returns>DataTable</returns>
//        public DataTable GetSlotDetails()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetSlotDetails();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Working Slot Details Sunday
//        /// </summary>
//        /// <returns>DataTable</returns>
//        public DataTable GetSlotDetailsSunday()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetSlotDetailsSunday();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Working Slot Details Monday
//        /// </summary>
//        /// <returns>DataTable</returns>
//        public DataTable GetSlotDetailsMonday()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetSlotDetailsMonday();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Working Slot Details Tuesday
//        /// </summary>
//        /// <returns>DataTable</returns>
//        public DataTable GetSlotDetailsTuesday()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetSlotDetailsTuesday();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Working Slot Details Wednesday
//        /// </summary>
//        /// <returns>DataTable</returns>
//        public DataTable GetSlotDetailsWednesday()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetSlotDetailsWednesday();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Working Slot Details Thursday
//        /// </summary>
//        /// <returns>DataTable</returns>
//        public DataTable GetSlotDetailsThursday()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetSlotDetailsThursday();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Working Slot Details Friday
//        /// </summary>
//        /// <returns>DataTable</returns>
//        public DataTable GetSlotDetailsFriday()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetSlotDetailsFriday();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Working Slot Details Saturday
//        /// </summary>
//        /// <returns>DataTable</returns>
//        public DataTable GetSlotDetailsSaturday()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetSlotDetailsSaturday();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Zone Slot Detail
//        /// </summary>
//        /// <param name="objZoneModel">ZoneModel</param>
//        /// <returns>DataTable</returns>
//        public DataTable GetSlotDetailsZone(ZoneModel objZoneModel)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetSlotDetailsZone(objZoneModel);
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Slot Details Wing
//        /// </summary>
//        /// <returns>DataTable</returns>
//        public DataTable GetSlotDetailsWing()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetSlotDetailsWing();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Holiday Details 
//        /// </summary>
//        /// <returns>DataTable</returns>
//        public DataTable GetHolidayDetails()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetHolidayDetails();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Customer Details 
//        /// </summary>
//        /// <returns>DataTable</returns>
//        public DataTable GetCustomerDetails()
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetCustomerDetails();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        /// <summary>
//        /// Method to get Customer Details By Id
//        /// </summary>
//        /// <param name="Id">int</param>
//        /// <returns>DataTable</returns>
//        public DataTable GetCustomerDetailsById(int Id)
//        {
//            try
//            {
//                commonMethodManager = new CommonMethodManager();
//                return commonMethodManager.GetCustomerDetailsById(Id);
//            }
//            catch
//            {
//                throw;
//            }
//        }
        
//    }
//}