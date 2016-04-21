<%@ Page Language="C#" AutoEventWireup="true" Inherits="_Default" MasterPageFile="~/Main.master" Title="Auditing Example - Database editor" Codebehind="Default.aspx.cs" %>
<asp:Content ContentPlaceHolderID="phMainContent" runat="server">
	<table width="100%" cellpadding="5" cellspacing="0" border="0">
	<tr>
        <td class="darkbackground" colspan="3">
			<h1>
                LLBLGenPro v5.x Auditing Example</h1>
        </td>
	</tr>
	<tr>
        <td class="headers" colspan="3">
            This example shows how to perform Auditing with LLBLGen Pro Auditor Classes and Dependency
            Injection.</td>
	</tr>
	<tr>
        <td class="content">
            <br />
            <asp:Button ID="btnListAllProducts" runat="server" Text="List all Products" SkinID="ButtonSkin" OnClick="btnListAllProducts_Click" /><br />
            <br />
            To see audit info, open
            <asp:Label ID="lblAuditTextFileName" runat="server" Text="xxx"></asp:Label>.<br />
            To change filename go to web.config</td>
        <td class="content">
            <br />
            <asp:Button ID="btnListAllCustomers" runat="server" Text="List all Customers" SkinID="ButtonSkin" OnClick="btnListAllCustomers_Click" /><br />
            <br />
            <asp:HyperLink ID="hplAuditInfo" runat="server" NavigateUrl="ListAll.aspx?EntityType=1">See AuditInfo</asp:HyperLink></td>
        <td class="content">
            <br />
            <asp:Button ID="btnListAllOrders" runat="server" Text="List all Orders" SkinID="ButtonSkin" OnClick="btnListAllOrders_Click" /><br />
            <br />
            <asp:HyperLink ID="hplOrderAuditInfo" runat="server" NavigateUrl="ListAll.aspx?EntityType=9">See OrderAuditInfo</asp:HyperLink></td>
	</tr>
        <tr>
            <td class="content" colspan="3">
                <em><span style="text-decoration: underline">
                    <br />
                    NOTES:<br />
                    <br />
                </span><strong>
            SimpleTextAuditor</strong></em> is injected into <strong>ProductEntity</strong>
                instances<br/>
                <em><strong>
            DatabaseAuditor</strong></em> is injected into <strong>CustomerEntity</strong>
                instances<br/>
                <strong><em>
            DatabaseAuditorSpecific</em></strong> (or Advance) is injected to <strong>
                    OrderEntity</strong> instances<br />
                <br />
                <em>(If you want to change the Auditor target entity, modify the Auditor classes.)<br />
                    <br />
                    <br />
                    <br />
                    <br />
                </em></td>
        </tr>
        <tr>
            <td colspan="3" class="contentlight">                
    If you want perform CRUD operations to other entities, please select an Entity and
    an Action:<br />
                <br />
                &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; Entity: &nbsp;&nbsp; &nbsp;
                <asp:DropDownList ID="cbxEntity" runat="server" Font-Size="10pt"/><br />
                <br />
                &nbsp; &nbsp; &nbsp;&nbsp;
			<asp:Button ID="btnAdd" runat="server" Text="Add new" SkinID="ButtonSkin" OnClick="btnAdd_Click"/>&nbsp; &nbsp;&nbsp;
			<asp:Button ID="btnEdit" runat="server" Text="Edit existing" SkinID="ButtonSkin" OnClick="btnEdit_Click" />&nbsp; &nbsp; &nbsp;<asp:Button ID="btnDelete" runat="server" Text="Delete existing" SkinID="ButtonSkin" OnClick="btnDelete_Click" />&nbsp; &nbsp; &nbsp;<asp:Button ID="btnListSubSet" runat="server" Text="List subset" SkinID="ButtonSkin" OnClick="btnListSubSet_Click" />&nbsp; &nbsp; &nbsp;<asp:Button ID="btnListAll" runat="server" Text="List all" SkinID="ButtonSkin" OnClick="btnListAll_Click" /></td>
        </tr>
	</table>
    <em><span style="text-decoration: underline"></span></em>
</asp:Content>
