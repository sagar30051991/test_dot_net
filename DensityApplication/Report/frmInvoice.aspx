<%@ Page Title="" Language="C#" MasterPageFile="~/Master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmInvoice.aspx.cs" Inherits="DensityApplication.Report.frmInvoice" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
    </telerik:RadScriptManager>
    <h2 style="color: #09639F">
       Invoice
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
                                     <td height="70" style="width: 60%">
                                         <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name:" Text-align="left"></asp:Label>
                                          <asp:DropDownList ID="ddlCustomerName" runat="server" class="form-control" Width="77%"
                                              AutoPostBack="True" AppendDataBoundItems="True" 
                                             onselectedindexchanged="ddlCustomerName_SelectedIndexChanged" >
                                              <asp:ListItem Text="select" />
                                          </asp:DropDownList>
                                     </td>
                                     <td style="width: 40%; text-align: left">
                                         <asp:Label ID="LalblBillNobel1" runat="server" Text="Bill No:" Text-align="left"></asp:Label>
                                          <asp:DropDownList ID="ddlBillNo" runat="server" class="form-control" Width="130%"
                                              AutoPostBack="True" AppendDataBoundItems="True" >
                                              <asp:ListItem Text="select" />
                                          </asp:DropDownList>
                                     </td>
                                 </tr>

                                 <tr>
                                     <td colspan="2" style="padding-left: 1px;" width="100%">
                                         <asp:Button ID="btnGenerate" runat="server" Text="Genearte" class="btn btn-default" 
                                             ValidationGroup="vgCompany" onclick="btnGenerate_Click" />                                       
                                     </td>
                                     <td>
                                         &nbsp;</td>
                                </tr>
                             </table>
                          </div>
                      </div>
           </div>
      </div>


</asp:Content>
