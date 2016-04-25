<%@ Page Title="" Language="C#" MasterPageFile="~/Master/MasterPage.Master" AutoEventWireup="true" CodeBehind="FrmCustomer.aspx.cs" Inherits="DensityApplication.ModProject.FrmCustomer" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<telerik:RadScriptManager ID="RadScriptManager1" runat="server">
    </telerik:RadScriptManager>
<h2 style="color: #09639F">
       Customer
    </h2>
<div class="container-fluid">
         <div class="row">
             <div class="col-lg-4">
                    &nbsp;
                    </div>
                     <div class="col-lg-4">
                          <div >
                             <table width="100%" >

                                 <tr class="form-group">
                                     <td height="70" style="width: 44%">
                                         <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name:" Text-align="left" ></asp:Label>
                                         <asp:TextBox ID="txtCustomerName" runat="server" Width="95%" class="form-control" ></asp:TextBox>
                                     </td>
                                     <td style="width: 25%; text-align: left">
                                         <asp:Label ID="lblContact_No" runat="server" Text="Contact No:" Text-align="left" ></asp:Label>
                                         <br />
                                         <asp:TextBox ID="txtContact_No" runat="server" Width="170%" class="form-control" ></asp:TextBox>
                                     </td>
                                 </tr>

                                 <tr class="form-group">
                                     <td height="70" style="width: 44%">
                                         <asp:Label ID="lblAddress1" runat="server" Text="Address1:" Text-align="left" ></asp:Label>
                                         <asp:TextBox ID="txtAddress1" runat="server" Width="95%" class="form-control" ></asp:TextBox>
                                     </td>
                                     <td style="width: 25%; text-align: left">
                                         <asp:Label ID="lblAddress2" runat="server" Text="Address2:" Text-align="left" ></asp:Label>
                                         <br />
                                         <asp:TextBox ID="txtAddress2" runat="server" Width="170%" class="form-control" ></asp:TextBox>
                                     </td>
                                 </tr>

                                 <tr class="form-group">
                                     <td height="70" style="width: 44%">
                                         <asp:Label ID="lblCity" runat="server" Text="City" Text-align="left" ></asp:Label>
                                         <asp:TextBox ID="txtCity" runat="server" Width="95%" class="form-control" ></asp:TextBox>
                                     </td>
                                     <td style="width: 25%; text-align: left">
                                         <asp:Label ID="lblPincode" runat="server" Text="Pincode:" Text-align="left" ></asp:Label>
                                         <br />
                                         <asp:TextBox ID="txtPincode" runat="server" Width="170%" class="form-control" ></asp:TextBox>
                                     </td>
                                 </tr>

                                 <tr class="form-group">
                                     <td height="70" style="width: 44%">
                                         <asp:Label ID="lblVAT_Tin" runat="server" Text="VAT TIN:" Text-align="left" ></asp:Label>
                                         <asp:TextBox ID="txtVAT_Tin" runat="server" Width="95%" class="form-control" ></asp:TextBox>
                                     </td>
                                     <td style="width: 25%; text-align: left">
                                         <asp:Label ID="lblCST_No" runat="server" Text="CST NO:" Text-align="left" ></asp:Label>
                                         <br />
                                         <asp:TextBox ID="txtCST_No" runat="server" Width="170%" class="form-control" ></asp:TextBox>
                                     </td>
                                 </tr>
                                
                                 
                                  
                                 
                                 
                                 <tr>
                                     <td colspan="2" style="padding-left: 30px;" width="100%">
                                         <asp:Button ID="btnAdd" runat="server" Text="Add" class="btn btn-default" 
                                             ValidationGroup="vgCompany" onclick="btnAdd_Click" />
                                         <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-default" 
                                             ValidationGroup="vgCompany" onclick="btnUpdate_Click" />
                                         <asp:Button ID="btnDelete" runat="server" Text="Delete" class="btn btn-default" 
                                             ValidationGroup="vgCompany" onclick="btnDelete_Click" />
                                         <asp:Button ID="btnClear" runat="server" Text="Clear" class="btn btn-default" />
                                     </td>
                                </tr>

                  <tr>
                <td>
                    &nbsp;
                </td>
                <td style="float: left;">
                    &nbsp;
                </td>
            </tr>
           
               <tr>
                <td>
                    &nbsp;
                </td>
                <td style="float: left;">
                    &nbsp;
                </td>
            </tr>
                             </table>
                                       <asp:RequiredFieldValidator ID="rfvCustomerName" runat="server" ControlToValidate="txtCustomerName"
            Display="None" ErrorMessage="Please select Company Name" 
            ValidationGroup="vgCompany"></asp:RequiredFieldValidator>
                                <asp:RequiredFieldValidator ID="rfvAddress1" runat="server" ControlToValidate="txtAddress1"
            Display="None" ErrorMessage="Please Enter Contact Person" 
            ValidationGroup="vgCompany"></asp:RequiredFieldValidator>
        <%--<asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail"
            Display="None" ErrorMessage="Please Enter Email Id" 
            ValidationGroup="vgCompany"></asp:RequiredFieldValidator>--%>
           
              <%--<asp:RegularExpressionValidator ID="rfvValidEmailId" runat="server" 
         Display="None" ErrorMessage="Please Enter Valid Email Id"
         ValidationGroup="vgCompany" ControlToValidate="txtEmail" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>--%>
         
                            </div>
             </div>
         </div>

                      <div class="row">
              <div class="col-lg-12">
    <table width="100%" align="center">
        <tr>
            <td>
                 <telerik:RadGrid ID="grdCustomerDetail" runat="server"  AllowMultiRowEdit="True" AllowPaging="True"    
                         CellSpacing="0" AllowSorting="True" 
                            EnableHeaderContextFilterMenu="true" EnableHeaderContextMenu="true" AllowFilteringByColumn="false"
                        Selecting-AllowRowSelect="true" AutoGenerateColumns="False" onselectedindexchanged="grdCustomerDetail_SelectedIndexChanged"
                            GridLines="None" Skin="MetroTouch" 
                            CssClass="RadGrid_ModernBrowsers">
                   <PagerStyle AlwaysVisible="true" Mode="NextPrevAndNumeric" />
                        <ClientSettings AllowColumnsReorder="true" EnablePostBackOnRowClick="true">
                        <selecting allowrowselect="True"  />
                            <Scrolling AllowScroll="true" UseStaticHeaders="true" SaveScrollPosition="true" ScrollHeight="150px" />
                            <Resizing AllowColumnResize="true" ResizeGridOnColumnResize="true" EnableRealTimeResize="true"
                                AllowResizeToFit="true" />
                        </ClientSettings>
                            <MasterTableView CommandItemDisplay="None" EditMode="InPlace" AllowAutomaticInserts="true" DataKeyNames="Id">
                                <CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

                                   <Columns>
                                    <telerik:GridTemplateColumn  DataField="Id" HeaderText="Id" ShowFilterIcon="false" FilterDelay="200"  CurrentFilterFunction="Contains" Visible="false"
                                        UniqueName="Id" SortExpression="Id">
                                        <HeaderStyle Width="20%" HorizontalAlign="Left" />
                                        <ItemStyle HorizontalAlign="Left" />
                                        <ItemTemplate>
                                            <asp:Label ID="lblCustomerId" runat="server" Text=' <%# Eval("Id")%>' ToolTip='<%# Eval("Id")%>' Visible="false"></asp:Label>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn  DataField="CustomerId" HeaderText="CustomerId" ShowFilterIcon="false" FilterDelay="200"  CurrentFilterFunction="Contains" Visible="false"
                                        UniqueName="CustomerId" SortExpression="Id">
                                        <HeaderStyle Width="20%" HorizontalAlign="Left" />
                                        <ItemStyle HorizontalAlign="Left" />
                                        <ItemTemplate>
                                            <asp:Label ID="lblCustomerId" runat="server" Text=' <%# Eval("CustomerId")%>' ToolTip='<%# Eval("CustomerId")%>' Visible="false"></asp:Label>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn  DataField="CompanyName" HeaderText="Company Name"  ShowFilterIcon="false" FilterDelay="200"  CurrentFilterFunction="Contains"
                                        UniqueName="CompanyName" SortExpression="CompanyName">
                                        <HeaderStyle Width="20%" HorizontalAlign="Left" />
                                        <ItemStyle HorizontalAlign="Left" />
                                        <ItemTemplate>
                                            <asp:Label ID="lblCustomerName" runat="server" Text=' <%# Eval("CustomerName")%>'
                                                ToolTip='<%# Eval("CustomerName")%>'></asp:Label>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="Address1" HeaderText="Address1"  ShowFilterIcon="false" FilterDelay="200"  CurrentFilterFunction="Contains"
                                        UniqueName="Address1" SortExpression="ContactPerson">
                                        <HeaderStyle Width="20%" HorizontalAlign="Left" />
                                        <ItemStyle HorizontalAlign="Left" />
                                        <ItemTemplate>
                                            <asp:Label ID="lblAddress1" runat="server" Text=' <%# Eval("Address1")%>'
                                                ToolTip='<%# Eval("Address1")%>'></asp:Label>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="Address2" HeaderText="Address2"  ShowFilterIcon="false" FilterDelay="200"  CurrentFilterFunction="Contains"
                                        UniqueName="Address2" SortExpression="Address2">
                                        <HeaderStyle Width="20%" HorizontalAlign="Left" />
                                        <ItemStyle HorizontalAlign="Left" />
                                        <ItemTemplate>
                                            <asp:Label ID="lblAddress2" runat="server" Text=' <%# Eval("Address2")%>'
                                                ToolTip='<%# Eval("Address2")%>'></asp:Label>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="City" HeaderText="City"  ShowFilterIcon="false" FilterDelay="200"  CurrentFilterFunction="Contains"
                                        UniqueName="City" SortExpression="City">
                                        <HeaderStyle Width="20%" HorizontalAlign="Left" />
                                        <ItemStyle HorizontalAlign="Left" />
                                        <ItemTemplate>
                                            <asp:Label ID="lblCity" runat="server" Text=' <%# Eval("City")%>'
                                                ToolTip='<%# Eval("City")%>'></asp:Label>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="Pincode" HeaderText="Pincode"  ShowFilterIcon="false" FilterDelay="200"  CurrentFilterFunction="Contains"
                                        UniqueName="Pincode" SortExpression="Pincode">
                                        <HeaderStyle Width="20%" HorizontalAlign="Left" />
                                        <ItemStyle HorizontalAlign="Left" />
                                        <ItemTemplate>
                                            <asp:Label ID="lblPincode" runat="server" Text=' <%# Eval("Pincode")%>'
                                                ToolTip='<%# Eval("Pincode")%>'></asp:Label>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="Vat_Tin" HeaderText="Vat_Tin"  ShowFilterIcon="false" FilterDelay="200"  CurrentFilterFunction="Contains"
                                        UniqueName="Vat_Tin" SortExpression="Vat_Tin">
                                        <HeaderStyle Width="20%" HorizontalAlign="Left" />
                                        <ItemStyle HorizontalAlign="Left" />
                                        <ItemTemplate>
                                            <asp:Label ID="lblVat_Tin" runat="server" Text=' <%# Eval("Vat_Tin")%>'
                                                ToolTip='<%# Eval("Vat_Tin")%>'></asp:Label>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="CST_No" HeaderText="CST_No"  ShowFilterIcon="false" FilterDelay="200"  CurrentFilterFunction="Contains"
                                        UniqueName="CST_No" SortExpression="CST_No">
                                        <HeaderStyle Width="20%" HorizontalAlign="Left" />
                                        <ItemStyle HorizontalAlign="Left" />
                                        <ItemTemplate>
                                            <asp:Label ID="lblCST_No" runat="server" Text=' <%# Eval("CST_No")%>'
                                                ToolTip='<%# Eval("CST_No")%>'></asp:Label>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="ContactNo" HeaderText="ContactNo"  ShowFilterIcon="false" FilterDelay="200"  CurrentFilterFunction="Contains"
                                        UniqueName="ContactNo" SortExpression="ContactNo">
                                        <HeaderStyle Width="20%" HorizontalAlign="Left" />
                                        <ItemStyle HorizontalAlign="Left" />
                                        <ItemTemplate>
                                            <asp:Label ID="lblContactNo" runat="server" Text=' <%# Eval("ContactNo")%>'
                                                ToolTip='<%# Eval("ContactNo")%>'></asp:Label>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <%--<telerik:GridTemplateColumn DataField="Logo" HeaderText="Logo"  ShowFilterIcon="false" FilterDelay="200"  CurrentFilterFunction="Contains"
                                        UniqueName="Logo" SortExpression="Logo">
                                        <HeaderStyle Width="20%" HorizontalAlign="Left" />
                                        <ItemStyle HorizontalAlign="Left" />
                                        <ItemTemplate>
                                           
                                              <telerik:RadBinaryImage runat="server" ID="imgLogo" DataValue='<%#Eval("Logo") %>'
                                                AutoAdjustImageControlSize="false" Height="80px" Width="80px" >
                                               </telerik:RadBinaryImage>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>--%>
                                     </Columns>
                                <PagerStyle AlwaysVisible="True" />
                            </MasterTableView>
                 </telerik:RadGrid>
            </td>
        </tr>
    </table>
    </div>
    </div>

         </div>
</asp:Content>
