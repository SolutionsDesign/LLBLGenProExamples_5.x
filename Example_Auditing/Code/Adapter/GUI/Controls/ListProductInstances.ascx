
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_ListProductInstances" Codebehind="ListProductInstances.ascx.cs" %>
<asp:placeholder id="phHomeButton" runat="server" Visible="true">
	<asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" SkinID="ButtonSkin"/>
	&nbsp;&nbsp;&nbsp;
</asp:placeholder>
<asp:placeholder id="phAddNewButton" runat="server" Visible="true">
	<asp:button ID="btnAddNew" runat="server" Text="Add new" SkinID="ButtonSkin" OnClick="btnAddNew_Click"/>
</asp:placeholder>
<br />
<br />
<asp:Button ID="btnDirectUpdate" runat="server" OnClick="btnDirectUpdate_Click" SkinID="ButtonSkin"
    Text="Set Discontinued the SeaFood Category Products" />
(Test <em>AuditOfDirectUpdateOfEntities</em>)<br />
<br />
<llblgenpro:LLBLGenProDataSource2 ID="_ProductDS" runat="server" DataContainerType="EntityCollection" AdapterTypeName="SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.Examples.AuditingDBSpecific" EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.ProductEntityFactory, SD.LLBLGen.Pro.Examples.Auditing" CacheLocation="Session" EnablePaging="True" />
<asp:GridView ID="theGrid" runat="server" CssClass="Content" AutoGenerateColumns="False" DataKeyNames="ProductId" DataSourceID="_ProductDS" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" AllowSorting="True" OnRowCommand="theGrid_RowCommand">
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
				<asp:Button ID="btnDeleteExisting" runat="server" CausesValidation="false" CommandArgument='<%# DataBinder.Eval(Container,"RowIndex") %>' CommandName="Delete" Text="Delete" SkinID="ButtonSkin" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this Product instance with PK values: "  + "ProductId: " + Eval("ProductId") + " ?\");" %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="ProductId" SortExpression="ProductId" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:Label ID="lblProductId" runat="server" Text='<%# Bind("ProductId") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="ProductName" SortExpression="ProductName" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:Label ID="lblProductName" runat="server" Text='<%# Bind("ProductName") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Supplier" SortExpression="SupplierId" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:HyperLink ID="lnkSupplierId" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.SupplierEntity).ToString() + "&SupplierId=" + Eval("SupplierId")%>' Text='<%# Eval("Suppliers.CompanyName") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Category" SortExpression="CategoryId" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:HyperLink ID="lnkCategoryId" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.CategoryEntity).ToString() + "&CategoryId=" + Eval("CategoryId")%>' Text='<%# Eval("Categories.CategoryName") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="QuantityPerUnit" SortExpression="QuantityPerUnit" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:Label ID="lblQuantityPerUnit" runat="server" Text='<%# Bind("QuantityPerUnit") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="UnitPrice" SortExpression="UnitPrice" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:Label ID="lblUnitPrice" runat="server" Text='<%# Bind("UnitPrice") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="UnitsInStock" SortExpression="UnitsInStock" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:Label ID="lblUnitsInStock" runat="server" Text='<%# Bind("UnitsInStock") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="UnitsOnOrder" SortExpression="UnitsOnOrder" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:Label ID="lblUnitsOnOrder" runat="server" Text='<%# Bind("UnitsOnOrder") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="ReorderLevel" SortExpression="ReorderLevel" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:Label ID="lblReorderLevel" runat="server" Text='<%# Bind("ReorderLevel") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Discontinued" SortExpression="Discontinued" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:Label ID="lblDiscontinued" runat="server" Text='<%# Bind("Discontinued") %>'/>
			</ItemTemplate>
		</asp:TemplateField>

	</Columns>
	<PagerStyle CssClass="headers" HorizontalAlign="Center" />
	<HeaderStyle CssClass="tableheaders" />
</asp:GridView>
