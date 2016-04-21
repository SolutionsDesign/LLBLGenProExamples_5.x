
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_ListOrderAuditInfoInstances" Codebehind="ListOrderAuditInfoInstances.ascx.cs" %>
<asp:placeholder id="phHomeButton" runat="server" Visible="true">
	<asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" SkinID="ButtonSkin"/>
	&nbsp;&nbsp;&nbsp;
</asp:placeholder>
<br /><br />
<llblgenpro:LLBLGenProDataSource2 ID="_OrderAuditInfoDS" runat="server" DataContainerType="EntityCollection" AdapterTypeName="SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.Examples.AuditingDBSpecific" EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.OrderAuditInfoEntityFactory, SD.LLBLGen.Pro.Examples.Auditing" CacheLocation="Session" EnablePaging="True" />
<asp:GridView ID="theGrid" runat="server" CssClass="Content" AutoGenerateColumns="False" DataKeyNames="AuditInfoId" DataSourceID="_OrderAuditInfoDS" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" AllowSorting="True" OnRowCommand="theGrid_RowCommand">
	<Columns>
		<asp:TemplateField ShowHeader="False" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" >
			<ItemTemplate>
				<asp:Button ID="btnViewExisting" runat="server" CausesValidation="false" CommandArgument='<%# DataBinder.Eval(Container,"RowIndex") %>' CommandName="ViewExisting" Text="View" SkinID="ButtonSkin" />
			</ItemTemplate>
		</asp:TemplateField>		
		<asp:TemplateField HeaderText="AuditInfoId" SortExpression="AuditInfoId" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:Label ID="lblAuditInfoId" runat="server" Text='<%# Bind("AuditInfoId") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="ActionDateTime" SortExpression="ActionDateTime" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:Label ID="lblActionDateTime" runat="server" Text='<%# Bind("ActionDateTime", "{0:dd-MMM-yyyy HH:mm.ss}") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="AffectedEntityName" SortExpression="AffectedEntityName" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:Label ID="lblAffectedEntityName" runat="server" Text='<%# Bind("AffectedEntityName") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="AuditActionType" SortExpression="AuditActionTypeId" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:Label ID="lblAuditActionTypeId" runat="server" Text='<%# Eval("AuditActionType.Name") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="ActionData" SortExpression="ActionData" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:Label ID="lblActionData" runat="server" Text='<%# Bind("ActionData") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="UserId" SortExpression="UserId" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:Label ID="lblUserId" runat="server" Text='<%# Bind("UserId") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="OrderId" SortExpression="OrderId" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false">
			<ItemTemplate>
				<asp:HyperLink ID="lnkOrderId" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.OrderEntity).ToString() + "&OrderId=" + Eval("OrderId")%>' Text='<%# Bind("OrderId") %>'/>
			</ItemTemplate>
		</asp:TemplateField>

	</Columns>
	<PagerStyle CssClass="headers" HorizontalAlign="Center" />
	<HeaderStyle CssClass="tableheaders" />
</asp:GridView>
