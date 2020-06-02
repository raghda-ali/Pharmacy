<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="showreport.aspx.cs" Inherits="Pharmacy.showreport" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="900px" Font-Names="verdana" Font-Size="8pt" waitMessagefont-name="verdana" BackColor="" ClientIDMode="AutoID" HighlightBackgroundColor="" InternalBorderColor="204, 204, 204" InternalBorderStyle="Solid" InternalBorderWidth="1px" LinkActiveColor="" LinkActiveHoverColor="" LinkDisabledColor="" PrimaryButtonBackgroundColor="" PrimaryButtonForegroundColor="" PrimaryButtonHoverBackgroundColor="" PrimaryButtonHoverForegroundColor="" SecondaryButtonBackgroundColor="" SecondaryButtonForegroundColor="" SecondaryButtonHoverBackgroundColor="" SecondaryButtonHoverForegroundColor="" SplitterBackColor="" ToolbarDividerColor="" ToolbarForegroundColor="" ToolbarForegroundDisabledColor="" ToolbarHoverBackgroundColor="" ToolbarHoverForegroundColor="" ToolBarItemBorderColor="" ToolBarItemBorderStyle="Solid" ToolBarItemBorderWidth="1px" ToolBarItemHoverBackColor="" ToolBarItemPressedBorderColor="51, 102, 153" ToolBarItemPressedBorderStyle="Solid" ToolBarItemPressedBorderWidth="1px" ToolBarItemPressedHoverBackColor="153, 187, 226">

                <LocalReport ReportPath="rpt_medicineDetails.rdlc">
                    <DataSources>
                     <%--   <rsweb:ReportDataSource Name="medicineDetails" DataSourceId="SqlDataSource1"></rsweb:ReportDataSource>--%>
                    </DataSources>
                </LocalReport>

            </rsweb:ReportViewer>


            
            <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:C:\USERS\ELHOUDA\PHARMACY\PHARMACY\APP_DATA\PHARMACY.MODELS.MYDBCONTEXT.MDFConnectionString %>' SelectCommand="SELECT * FROM [__MigrationHistory]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
<%--<rsweb:ReportViewer ID="ReportViewer1" runat="server"></rsweb:ReportViewer>--%>
