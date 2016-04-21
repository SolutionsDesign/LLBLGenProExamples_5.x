
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_ListSupplierInstances" Codebehind="ListSupplierInstances.ascx.cs" %>
<asp:placeholder id="phHomeButton" runat="server" Visible="true">
	<asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" SkinID="ButtonSkin"/>
	&nbsp;&nbsp;&nbsp;
</asp:placeholder>
<asp:placeholder id="phAddNewButton" runat="server" Visible="true">
	<asp:button ID="btnAddNew" runat="server" Text="Add new" SkinID="ButtonSkin" OnClick="btnAddNew_Click"/>
</asp:placeholder>
<br /><br />
<llblgenpro:LLBLGenProDataSource2 ID="_SupplierDS" runat="server" DataContainerType="EntityCollection" AdapterTypeName="SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.Examples.AuditingDBSpecific" EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.SupplierEntityFactory, SD.LLBLGen.Pro.Examples.Auditing" CacheLocation="Session" EnablePaging="True" />
<asp:GridView ID="theGrid" runat="server" CssClass="Content" AutoGenerateColumns="False" DataKeyNames="SupplierId" DataSourceID="_SupplierDS" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" AllowSorting="True" OnRowCommand="theGrid_RowCommand">
	<Columns>
		<asp:TemplateField ShowHeader="False" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" >
			<ItemTemplate>
				<asp:Button ID="btnViewExisting" runat="server" CausesValidation="false" CommandArgument='<%# DataBinder.Eval(Container,"RowIndex") %>' CommandName="ViewExisting" Text="View" SkinID="ButtonSkin" />
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField ShowHeader="False" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders">
			<ItemTemplate>
				<asp:Button ID="btnEditExisting" runat="server" CausesValidation="false" CommandArgument='<%# DataBinder.Eval(Container,"RowIndex") %>' CommandName="EditExisting" Text="Edit" SkinID="ButtonSkin" />
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField ShowHeader="False" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left">
			<ItemTemplate>
				<asp:Button ID="btnDeleteExisting" runat="server" CausesValidation="false" CommandArgument='<%# DataBinder.Eval(Container,"RowIndex") %>' CommandName="Delete" Text="Delete" SkinID="ButtonSkin" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this Supplier instance with PK values: "  + "SupplierId: " + Eval("SupplierId") + " ?\");" %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="SupplierId" SortExpression="SupplierId" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:Label ID="lblSupplierId" runat="server" Text='<%# Bind("SupplierId") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="CompanyName" SortExpression="CompanyName" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:Label ID="lblCompanyName" runat="server" Text='<%# Bind("CompanyName") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="ContactName" SortExpression="ContactName" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:Label ID="lblContactName" runat="server" Text='<%# Bind("ContactName") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="ContactTitle" SortExpression="ContactTitle" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:Label ID="lblContactTitle" runat="server" Text='<%# Bind("ContactTitle") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="City" SortExpression="City" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:Label ID="lblCity" runat="server" Text='<%# Bind("City") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Region" SortExpression="Region" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:Label ID="lblRegion" runat="server" Text='<%# Bind("Region") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="PostalCode" SortExpression="PostalCode" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:Label ID="lblPostalCode" runat="server" Text='<%# Bind("PostalCode") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Country" SortExpression="Country" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:Label ID="lblCountry" runat="server" Text='<%# Bind("Country") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Phone" SortExpression="Phone" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:Label ID="lblPhone" runat="server" Text='<%# Bind("Phone") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Fax" SortExpression="Fax" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:Label ID="lblFax" runat="server" Text='<%# Bind("Fax") %>'/>
			</ItemTemplate>
		</asp:TemplateField>

	</Columns>
	<PagerStyle CssClass="headers" HorizontalAlign="Center" />
	<HeaderStyle CssClass="tableheaders" />
</asp:GridView>
