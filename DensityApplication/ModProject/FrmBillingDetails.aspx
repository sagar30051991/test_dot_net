<%@ Page Title="" Language="C#" MasterPageFile="~/Master/MasterPage.Master" AutoEventWireup="true" CodeBehind="FrmBillingDetails.aspx.cs" Inherits="DensityApplication.ModProject.FrmBillingDetails" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadScriptManager ID="rsm2ToilSale" runat="server">        
        </telerik:RadScriptManager>  
<h2 style="color: #09639F">
       Billing Detail
    </h2>
    <div class="container-fluid">
         <div class="row">
            
                    
                          <div >
                              <table width="100%">
                                  <tr class="form-group">
                                      <td height="70" style="width: 10%">
                                          <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name:" Text-align="left"></asp:Label>
                                          <asp:DropDownList ID="ddlCustomerName" runat="server" class="form-control" Width="75%"
                                              AutoPostBack="True" AppendDataBoundItems="True" >
                                              <asp:ListItem Text="select" />
                                          </asp:DropDownList>
                                      </td>
                                      <td style="width: 3%; text-align: left">
                                          <asp:Label ID="lblDate" runat="server" Text="Date" Text-align="left"></asp:Label>
                                          <br />
                                          <telerik:RadDateTimePicker ID="dpFromDate" Width="166px" runat="server" Height="22px" DateInput-DateFormat="dd/MM/yyyy HH:mm:ss" Culture="en-US"></telerik:RadDateTimePicker>
                                          <%--<telerik:RadDateTimePicker ID="dpFromDate" Width="166px" runat="server" Height="22px"
                                              DateInput-DateFormat="dd/MM/yyyy HH:mm:ss" Culture="en-US">
                                              <TimeView ID="TimeView1" CellSpacing="-1" runat="server">
                                              </TimeView>
                                              <TimePopupButton HoverImageUrl="" ImageUrl="" />
                                              <Calendar ID="Calendar1" UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False"
                                                  ViewSelectorText="x" BorderStyle="None" runat="server">
                                                  <SpecialDays>
                                                      <telerik:RadCalendarDay Date="" IsToday="True" Repeatable="Today" ToolTip="Today">
                                                          <ItemStyle BackColor="#FCDB00" ForeColor="White" />
                                                      </telerik:RadCalendarDay>
                                                  </SpecialDays>
                                                  <WeekendDayStyle BackColor="#F3F3F3" BorderStyle="Inset" BorderColor="#F3F3F3" />
                                              </Calendar>
                                              <DateInput ID="DateInput1" DateFormat="dd/MM/yyyy HH:mm:ss" runat="server" DisplayDateFormat="dd/MM/yyyy HH:mm:ss"
                                                  Height="22px" LabelWidth="40%">
                                              </DateInput>
                                              <DatePopupButton HoverImageUrl="" ImageUrl="" />
                                              <ClientEvents OnDateSelected="OnDateSelected"></ClientEvents>
                                          </telerik:RadDateTimePicker>--%>
                                      </td>
                                  </tr>
                                  <tr class="form-group">
                                      <td height="70" style="width: 10%">                                      
                                          <asp:Label ID="lblParticular" runat="server" Text="Particular" Text-align="left"></asp:Label>
                                          <br />
                                          <asp:TextBox ID="txtParticular" runat="server" Width="75%" class="form-control"></asp:TextBox>
                                      </td>
                                      <td style="width: 3%; text-align: left">
                                          <asp:Label ID="lbQty" runat="server" Text="Qty:" Text-align="left"></asp:Label>
                                          <asp:TextBox ID="txtQty" runat="server" Width="80%" class="form-control"></asp:TextBox>
                                      </td>
                                      <td style="width: 25%; text-align: left">
                                          <asp:Label ID="lblRate" runat="server" Text="Rate:" Text-align="left"></asp:Label>
                                          <br />
                                          <asp:TextBox ID="txtRate" runat="server" Width="20%" class="form-control"></asp:TextBox>
                                      </td>
                                  </tr>
                                  <tr class="form-group">
                                      
                                      <td style="width: 10%; text-align: left">
                                          <asp:Label ID="lblSave" runat="server" Text="Save Items Then Select" Text-align="left"></asp:Label>
                                          <br />
                                          <asp:CheckBox ID="ChbSave" runat="server" 
                                               AutoPostBack="True" Width="75%" oncheckedchanged="ChbSave_CheckedChanged"/>
                                      </td>
                                      <td height="70" style="width: 3%">
                                          <asp:Label ID="CST_VAT" runat="server" Text="CST/VAT:" Text-align="left"></asp:Label>
                                          <asp:DropDownList ID="ddlCST_VAT" runat="server" class="form-control" Width="80%"
                                              AutoPostBack="True" AppendDataBoundItems="True">
                                             
                                              <asp:ListItem Text="select" />
                                              <asp:ListItem Text="CST 2%" Value="1"></asp:ListItem>
                                              <asp:ListItem Text="VAT 12.5%" Value="2"></asp:ListItem>
                                          </asp:DropDownList>
                                      </td>
                                      <td style="width: 25%; text-align: left">
                                           <asp:Button ID="btnSavedItem" runat="server" Text="Saved Item" 
                                               class="btn btn-default" ValidationGroup="vgCompany" 
                                               onclick="btnSavedItem_Click" />
                                      </td>
                                  </tr>
                                  <%--<tr class="form-group">
                                      <td height="70" style="width: 10%">
                                          <asp:Label ID="lblNET2" runat="server" Text="Net 2 %:" Text-align="left"></asp:Label>
                                          <asp:TextBox ID="txtNET2" runat="server" Width="75%" class="form-control" Enabled="false"></asp:TextBox>
                                      </td>
                                      <td style="width: 3%; text-align: left">
                                          <asp:Label ID="lblCST2" runat="server" Text="CST 2 %:" Text-align="left"></asp:Label>
                                          <br />
                                          <asp:TextBox ID="txtCST2" runat="server" Width="80%" class="form-control" Enabled="false"></asp:TextBox>
                                      </td>
                                      <td style="width: 25%; text-align: left">
                                          <asp:Label ID="lblToalAmount" runat="server" Text="Toal Amount:" Text-align="left"></asp:Label>
                                          <br />
                                          <asp:TextBox ID="txtTotalAmount" runat="server" Width="20%" 
                                              class="form-control" Enabled="false"></asp:TextBox>
                                      </td>
                                  </tr>--%>
                                 
                                  <tr>
                                      <td colspan="2" style="padding-left: 30px;" width="100%">
                                          <asp:Button ID="btnAdd" runat="server" Text="Add" class="btn btn-default" 
                                              ValidationGroup="vgCompany" onclick="btnAdd_Click" />
                                          <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-default" ValidationGroup="vgCompany" />
                                          <asp:Button ID="btnDelete" runat="server" Text="Delete" class="btn btn-default" ValidationGroup="vgCompany" />
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
                                       <%--<asp:RequiredFieldValidator ID="rfvCustomerName" runat="server" ControlToValidate="txtCustomerName"
            Display="None" ErrorMessage="Please select Company Name" 
            ValidationGroup="vgCompany"></asp:RequiredFieldValidator>--%>
                                <%--<asp:RequiredFieldValidator ID="rfvAddress1" runat="server" ControlToValidate="txtAddress1"
            Display="None" ErrorMessage="Please Enter Contact Person" 
            ValidationGroup="vgCompany"></asp:RequiredFieldValidator>--%>
        <%--<asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail"
            Display="None" ErrorMessage="Please Enter Email Id" 
            ValidationGroup="vgCompany"></asp:RequiredFieldValidator>--%>
           
              <%--<asp:RegularExpressionValidator ID="rfvValidEmailId" runat="server" 
         Display="None" ErrorMessage="Please Enter Valid Email Id"
         ValidationGroup="vgCompany" ControlToValidate="txtEmail" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>--%>
         
                            </div>
             
         </div>

                      <div class="row">
              <div class="col-lg-12">
    <table width="100%" align="center">
        <tr>
            <td>
                 <telerik:RadGrid ID="grdItemsDetail" runat="server"  AllowMultiRowEdit="True" AllowPaging="True"    
                         CellSpacing="0" AllowSorting="True"  
                            EnableHeaderContextFilterMenu="true" EnableHeaderContextMenu="true" AllowFilteringByColumn="false"
                        Selecting-AllowRowSelect="true" AutoGenerateColumns="False" 
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
                                            <asp:Label ID="lblItemId" runat="server" Text=' <%# Eval("Id")%>' ToolTip='<%# Eval("Id")%>' Visible="false"></asp:Label>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn  DataField="CustomerId" HeaderText="Customer Id"  ShowFilterIcon="false" FilterDelay="200"  CurrentFilterFunction="Contains" Visible=false
                                        UniqueName="CustomerId" SortExpression="CustomerId">
                                        <HeaderStyle Width="20%" HorizontalAlign="Left" />
                                        <ItemStyle HorizontalAlign="Left" />
                                        <ItemTemplate>
                                            <asp:Label ID="lblCustomerId" runat="server" Text=' <%# Eval("CustomerId")%>'
                                                ToolTip='<%# Eval("CustomerId")%>'></asp:Label>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="Particulars" HeaderText="Particulars"  ShowFilterIcon="false" FilterDelay="200"  CurrentFilterFunction="Contains"
                                        UniqueName="Particulars" SortExpression="Particulars">
                                        <HeaderStyle Width="20%" HorizontalAlign="Left" />
                                        <ItemStyle HorizontalAlign="Left" />
                                        <ItemTemplate>
                                            <asp:Label ID="lblParticulars" runat="server" Text=' <%# Eval("Particulars")%>'
                                                ToolTip='<%# Eval("Particulars")%>'></asp:Label>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="Quantity" HeaderText="Quantity"  ShowFilterIcon="false" FilterDelay="200"  CurrentFilterFunction="Contains"
                                        UniqueName="Quantity" SortExpression="Quantity">
                                        <HeaderStyle Width="20%" HorizontalAlign="Left" />
                                        <ItemStyle HorizontalAlign="Left" />
                                        <ItemTemplate>
                                            <asp:Label ID="lblQuantity" runat="server" Text=' <%# Eval("Quantity")%>'
                                                ToolTip='<%# Eval("Quantity")%>'></asp:Label>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="Rate" HeaderText="Logo"  ShowFilterIcon="false" FilterDelay="200"  CurrentFilterFunction="Contains"
                                        UniqueName="Rate" SortExpression="Rate">
                                        <HeaderStyle Width="20%" HorizontalAlign="Left" />
                                        <ItemStyle HorizontalAlign="Left" />
                                        <ItemTemplate>
                                            <asp:Label ID="lblQuantity" runat="server" Text=' <%# Eval("Rate")%>'
                                                ToolTip='<%# Eval("Rate")%>'></asp:Label>
                                              
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
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
