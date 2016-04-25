<%@ Page Title="" Language="C#" MasterPageFile="~/Master/MasterPage.Master" AutoEventWireup="true"
    CodeBehind="FrmLandingPage.aspx.cs" Inherits="DensityApplication.ModProject.FrmLandingPage" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .box
        {
          /*  background: #9FFF00; */
               border: 1px solid #427BD6;
         /*   border-radius: 4px;
             -moz-border-radius: 15px; */
               border-radius: 10px 0 0 10px;
              -moz-border-radius: 10px 0 0 10px;
            
        }
        .tdStyle
        {
           
            width: 4%;
            padding-left:20px;
            /*margin-left: -10%;
           /* float: left;*/
        }
        .tdStyle1
        {
           
            width: 4%;
         
            /*margin-left: -10%;*/
          
            text-align:left;
        }
        
        .rounded { 
           
            border-radius: 15px; 
        }
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%--<telerik:RadAjaxLoadingPanel ID="lpLanding" runat="server" HorizontalAlign="Center" Transparency="20">
   
    </telerik:RadAjaxLoadingPanel> --%>
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
    </telerik:RadScriptManager>
    <%--   <telerik:RadAjaxPanel  Id="RadAjaxPanel" runat="server" LoadingPanelID="lpLanding">--%>
    <%--<h2 style="color: #09639F">
        Today Schedule
    </h2>--%>
    <div class="container-fluid">
        <div class="row">
        <%--    <div class="col-lg-4">
                &nbsp;
            </div>--%>
           <%-- <div class="col-lg-4">--%>
                <div>

                    <%--<table width="50%" align="center">
                        <tr id="tr21"  style="width: 100%" runat="server">
                       <td id="td337" runat="server"  >
                           <h4 align="left" style="color: #09639F">
                               <asp:Label ID="lblday" runat="server" Text=""></asp:Label>
                             </h4>
                       </td>
                    
                      </tr>
                    </table>--%>
               <%--     <div id="div1" style="width:50%;margin:0 auto;" runat="server">
                      
                        <span id="Span1" runat="server" class="tdStyle"></span>
                        <span id="Span2" runat="server" class="tdStyle"></span>
                        <span id="Span3" runat="server" class="tdStyle"></span>
                        <span id="Span4" runat="server" class="tdStyle"></span>
                        <span id="Span5" runat="server" class="tdStyle"></span>
                        <span id="Span6" runat="server" class="tdStyle"></span>
                        <span id="Span7" runat="server" class="tdStyle"></span>
                        <span id="Span8" runat="server" class="tdStyle"></span>
                        <span id="Span9" runat="server" class="tdStyle"></span>
                        <span id="Span10" runat="server" class="tdStyle"></span>
                        <span id="Span11" runat="server" class="tdStyle"></span>
                        <span id="Span12" runat="server" class="tdStyle"></span>
                        <span id="Span13" runat="server" class="tdStyle"></span>
                        <span id="Span14" runat="server" class="tdStyle"></span>
                        <span id="Span15" runat="server" class="tdStyle"></span>
                        <span id="Span16" runat="server" class="tdStyle"></span>
                        <span id="Span17" runat="server" class="tdStyle"></span>
                        <span id="Span18" runat="server" class="tdStyle"></span>
                        <span id="Span19" runat="server" class="tdStyle"></span>
                        <span id="Span20" runat="server" class="tdStyle"></span>
                        <span id="Span21" runat="server" class="tdStyle"></span>
                        <span id="Span22" runat="server" class="tdStyle"></span>
                        <span id="Span23" runat="server" class="tdStyle"></span>
                        <span id="Span24" runat="server" class="tdStyle"></span>
                    </div>--%>
                    <table width="50%" align="center">
                     
                        <tr id="tr1" class="box" style="width: 100%" runat="server">
                            <%--<td height="20" id="td1"  runat="server" class="tdStyle" title="0">
                            </td>
                            <td id="td2" runat="server" class="tdStyle" title="1">
                            </td>
                            <td id="td3" runat="server" class="tdStyle" title="2">
                            </td>
                            <td id="td4" runat="server" class="tdStyle" title="3">
                            </td>
                            <td id="td5" runat="server" class="tdStyle">
                            </td>
                            <td id="td6" runat="server" class="tdStyle">
                            </td>
                            <td id="td7" runat="server" class="tdStyle">
                            </td>
                            <td id="td8" runat="server" class="tdStyle">
                            </td>
                            <td id="td9" runat="server" class="tdStyle">
                            </td>
                            <td id="td10" runat="server" class="tdStyle">
                            </td>
                            <td id="td11" runat="server" class="tdStyle">
                            </td>
                            <td id="td12" runat="server" class="tdStyle">
                            </td>
                            <td id="td13" runat="server" class="tdStyle">
                            </td>
                            <td id="td14" runat="server" class="tdStyle">
                            </td>
                            <td id="td15" runat="server" class="tdStyle">
                            </td>
                            <td id="td16" runat="server" class="tdStyle">
                            </td>
                            <td id="td17" runat="server" class="tdStyle">
                            </td>
                            <td id="td18" runat="server" class="tdStyle">
                            </td>
                            <td id="td19" runat="server" class="tdStyle">
                            </td>
                            <td id="td20" runat="server" class="tdStyle">
                            </td>
                            <td id="td21" runat="server" class="tdStyle">
                            </td>
                            <td id="td22" runat="server" class="tdStyle">
                            </td>
                            <td id="td23" runat="server" class="tdStyle">
                            </td>
                            <td id="td24" runat="server" class="tdStyle">
                            </td>--%>
                        </tr>
                        </table>

                        <%--<table width="50%" align="center">
                             <tr id="tr2"  style="width: 100%" runat="server">
                            <td height="20" id="td25"  runat="server"  title="0" class="tdStyle1">
                            0
                            </td>
                            <td id="td26" runat="server"  title="1" class="tdStyle1">
                            1
                            </td>
                            <td id="td27" runat="server" class="tdStyle1" title="2">
                            2
                            </td>
                            <td id="td28" runat="server" class="tdStyle1" title="3">
                            3
                            </td>
                            <td id="td29" runat="server" class="tdStyle1">
                            4
                            </td>
                            <td id="td30" runat="server" class="tdStyle1">
                            5
                            </td>
                            <td id="td31" runat="server" class="tdStyle1">
                            6
                            </td>
                            <td id="td32" runat="server" class="tdStyle1">
                            7
                            </td>
                            <td id="td33" runat="server" class="tdStyle1">
                            8
                            </td>
                            <td id="td34" runat="server" class="tdStyle1">
                            9
                            </td>
                            <td id="td35" runat="server" class="tdStyle1">
                            10
                            </td>
                            <td id="td36" runat="server" class="tdStyle1">
                            11
                            </td>
                            <td id="td37" runat="server" class="tdStyle1">
                            12
                            </td>
                            <td id="td38" runat="server" class="tdStyle1">
                            13
                            </td>
                            <td id="td39" runat="server" class="tdStyle1">
                            14
                            </td>
                            <td id="td40" runat="server" class="tdStyle1">
                            15
                            </td>
                            <td id="td41" runat="server" class="tdStyle1">
                            16
                            </td>
                            <td id="td42" runat="server" class="tdStyle1">
                            17
                            </td>
                            <td id="td43" runat="server" class="tdStyle1">
                            18
                            </td>

                            <td id="td44" runat="server" class="tdStyle1">
                            19
                            </td>
                            <td id="td45" runat="server" class="tdStyle1">
                            20
                            </td>
                            <td id="td46" runat="server" class="tdStyle1">
                            21
                            </td>
                            <td id="td47" runat="server" class="tdStyle1">
                            22
                            </td>
                            <td id="td48" runat="server" class="tdStyle1">
                            23
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
                        </table>--%>
                <table width="50%" align="center">
                <tr>
                </tr>
                </table>
                      <%--  <table width="50%" align="center">
                        <tr class="form-group">
                            <td height="100" style="width: 37%">
                                <asp:Label ID="lblWing" runat="server" Text="Wing:"></asp:Label>
                                <asp:DropDownList ID="ddlWing" runat="server" class="form-control" style="width: 138px;" AutoPostBack="True"
                                    AppendDataBoundItems="True" OnSelectedIndexChanged="ddlWing_SelectedIndexChanged">
                                    <asp:ListItem Text="select" />
                                </asp:DropDownList>
                            </td>
                            <td style="width: 35%; text-align: left">
                                <asp:Label ID="lblZone" runat="server" Text="Zone:"></asp:Label>
                                <br />
                                <asp:DropDownList ID="ddlZone" runat="server" class="form-control"  AutoPostBack="True" style="width: 138px;"
                                    AppendDataBoundItems="True" OnSelectedIndexChanged="ddlZone_SelectedIndexChanged">
                                    <asp:ListItem Text="Please select" />
                                </asp:DropDownList>
                            </td>
                            <td style="width: 30%; text-align: left">
                                <asp:Label ID="lblStatus" runat="server" Text="Status:"></asp:Label>
                                <br />
                                <asp:Button ID="btnON" runat="server" Text="ON" class="btn btn-default" />
                            </td>
                        </tr>
                    </table>--%>
                </div>
         <%--   </div>--%>
        </div>


          <div class="row">
        <div class="col-lg-12">
            <table width="50%" align="center">
                    <tr>
                        <td>
                            <%--<asp:Button ID="btnViewMore" runat="server" Text="View More" 
                                class="btn btn-default"  />--%>
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
            </div>
            </div>


          <%--<div class="row">
        <div class="col-lg-12">
            <table width="100%" align="center">
                <tr>
                    <td>
                        <telerik:RadGrid ID="grdLandingPage" runat="server" AllowMultiRowEdit="True"
                            CellSpacing="0" AllowSorting="True" EnableHeaderContextFilterMenu="true" 
                            EnableHeaderContextMenu="true" AllowFilteringByColumn="false" 
                            Selecting-AllowRowSelect="true" onneeddatasource="grdLandingPage_NeedDataSource"
                            AutoGenerateColumns="False"  GridLines="None" 
                            Skin="MetroTouch" CssClass="RadGrid_ModernBrowsers" 
                           >
                            <PagerStyle AlwaysVisible="true" Mode="NextPrevAndNumeric" />
                            <ClientSettings AllowColumnsReorder="true" EnablePostBackOnRowClick="true">
                                <Selecting AllowRowSelect="True" />
                                <Scrolling AllowScroll="true" UseStaticHeaders="true" SaveScrollPosition="true" ScrollHeight="150px" />
                                <Resizing AllowColumnResize="true" ResizeGridOnColumnResize="true" EnableRealTimeResize="true"
                                    AllowResizeToFit="true" />
                            </ClientSettings>
                            <MasterTableView CommandItemDisplay="None" EditMode="InPlace" AllowAutomaticInserts="true"
                                DataKeyNames="Id">
                                <CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>
                                <Columns>
                                    <telerik:GridTemplateColumn DataField="Id" HeaderText="Id" ShowFilterIcon="false"
                                        FilterDelay="200" CurrentFilterFunction="Contains" Visible="false" UniqueName="Id"
                                        SortExpression="Id">
                                        <HeaderStyle Width="20%" HorizontalAlign="Left" />
                                        <ItemStyle HorizontalAlign="Left" />
                                        <ItemTemplate>
                                            <asp:Label ID="lblWorkingSlotId" runat="server" Text=' <%# Eval("Id")%>' ToolTip='<%# Eval("Id")%>'
                                                Visible="false"></asp:Label>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="Wing" HeaderText="Wing" ShowFilterIcon="false"
                                        FilterDelay="200" CurrentFilterFunction="Contains" UniqueName="Wing" SortExpression="Wing">
                                        <HeaderStyle Width="20%" HorizontalAlign="Left" />
                                        <ItemStyle HorizontalAlign="Left" />
                                        <ItemTemplate>
                                            <asp:Label ID="lblWing" runat="server" Text=' <%# Eval("WingName")%>' ToolTip='<%# Eval("WingName")%>'></asp:Label>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                      <telerik:GridTemplateColumn DataField="Zone" HeaderText="Zone" ShowFilterIcon="false"
                                        FilterDelay="200" CurrentFilterFunction="Contains" UniqueName="Zone" SortExpression="Zone">
                                        <HeaderStyle Width="20%" HorizontalAlign="Left" />
                                        <ItemStyle HorizontalAlign="Left" />
                                        <ItemTemplate>
                                            <asp:Label ID="lblZone" runat="server" Text=' <%# Eval("ZoneName")%>' ToolTip='<%# Eval("ZoneName")%>'></asp:Label>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="StartTime" HeaderText="Start Time" ShowFilterIcon="false"
                                        FilterDelay="200" CurrentFilterFunction="Contains" UniqueName="StartTime" SortExpression="StartTime">
                                        <HeaderStyle Width="20%" HorizontalAlign="Left" />
                                        <ItemStyle HorizontalAlign="Left" />
                                        <ItemTemplate>
                                            <asp:Label ID="lblStartTime" runat="server" Text=' <%# Eval("StartTime")%>' ToolTip='<%# Eval("StartTime")%>'></asp:Label>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn DataField="EndTime" HeaderText="End Time" ShowFilterIcon="false"
                                        FilterDelay="200" CurrentFilterFunction="Contains" UniqueName="EndTime" SortExpression="EndTime">
                                        <HeaderStyle Width="20%" HorizontalAlign="Left" />
                                        <ItemStyle HorizontalAlign="Left" />
                                        <ItemTemplate>
                                            <asp:Label ID="lblEndTime" runat="server" Text=' <%# Eval("EndTime")%>' ToolTip='<%# Eval("EndTime")%>'></asp:Label>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>

                                       <telerik:GridTemplateColumn DataField="Status" HeaderText="Status" ShowFilterIcon="false"
                                        FilterDelay="200" CurrentFilterFunction="Contains" UniqueName="Status" SortExpression="Status">
                                        <HeaderStyle Width="20%" HorizontalAlign="Left" />
                                        <ItemStyle HorizontalAlign="Left" />
                                        <ItemTemplate>
                                            <asp:Label ID="lblStatus" runat="server" Text=' <%# Eval("Status")%>' ToolTip='<%# Eval("Status")%>'></asp:Label>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>

                                     <telerik:GridTemplateColumn DataField="Action" HeaderText="Action" ShowFilterIcon="false" 
                                        FilterDelay="200" CurrentFilterFunction="Contains" UniqueName="Action" SortExpression="Action">
                                        <HeaderStyle Width="20%" HorizontalAlign="Left" />
                                        <ItemStyle HorizontalAlign="Left" />
                                        <ItemTemplate>
                                            <asp:Button ID="btnAction" class="btn btn-default" runat="server" Text=' <%# Eval("Status1")%>' ToolTip='<%# Eval("Status1")%>' />            
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                 <%--   <telerik:GridButtonColumn CommandName="OFF" Text="OFF" UniqueName="OFF" HeaderText="Action">
                                      <HeaderStyle Width="20%" HorizontalAlign="Left" />
                                    </telerik:GridButtonColumn>--%>
                                                            
                                </Columns>
                                <PagerStyle AlwaysVisible="True" />
                            </MasterTableView>
                        </telerik:RadGrid>
                    </td>
                </tr>
            </table>
        </div>
    </div>--%>
    </div>

    <%-- </telerik:RadAjaxPanel>--%>
</asp:Content>

