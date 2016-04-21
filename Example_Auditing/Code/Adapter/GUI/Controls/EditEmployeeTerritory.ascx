
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_EditEmployeeTerritory" Codebehind="EditEmployeeTerritory.ascx.cs" %>
<llblgenpro:LLBLGenProDataSource2 ID="_EmployeeTerritoryDS" runat="server" MaxNumberOfItemsToReturn="1" DataContainerType="EntityCollection" AdapterTypeName="SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.Examples.AuditingDBSpecific" EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.EmployeeTerritoryEntityFactory, SD.LLBLGen.Pro.Examples.Auditing" LivePersistence="False" OnPerformSelect="_EmployeeTerritoryDS_PerformSelect" OnPerformWork="_EmployeeTerritoryDS_PerformWork"/>
<asp:FormView ID="frmEditEmployeeTerritory" DataKeyNames="EmployeeId, TerritoryId" runat="server" DefaultMode="insert" DataSourceID="_EmployeeTerritoryDS" Cellpadding="0" OnItemCommand="frmEditEmployeeTerritory_ItemCommand" OnItemCreated="frmEditEmployeeTerritory_ItemCreated">
<InsertItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				EmployeeId:
			</td>
			<td class="content">
				<asp:textbox id="tbxEmployeeId" runat="server" maxlength="11" size="11" Text='<%# Bind("EmployeeId") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valEmployeeId" runat="server" ControlToValidate="tbxEmployeeId" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqEmployeeId" runat="server" ControlToValidate="tbxEmployeeId" Display="Dynamic" ErrorMessage="Required" />
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				TerritoryId:
			</td>
			<td class="content">
				<asp:textbox id="tbxTerritoryId" runat="server" maxlength="20" size="20" Text='<%# Bind("TerritoryId") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqTerritoryId" runat="server" ControlToValidate="tbxTerritoryId" Display="Dynamic" ErrorMessage="Required" />
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br>
				<hr align="left" size="1" />
				<asp:Button ID="btnInsertAndNew" runat="server" CausesValidation="True" ValidationGroup="InsertValidations" CommandName="InsertAndNew" Text="Insert and New" SkinId="ButtonSkin"/>
				<asp:Button ID="btnInsertAndHome" runat="server" CausesValidation="True" ValidationGroup="InsertValidations" CommandName="InsertAndHome" Text="Insert and Home" SkinId="ButtonSkin"/>
				<asp:Button ID="btnInsertAndView" runat="server" CausesValidation="True" ValidationGroup="InsertValidations" CommandName="InsertAndView" Text="Insert and View" SkinId="ButtonSkin"/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</InsertItemTemplate>
<EditItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				EmployeeId:
			</td>
			<td class="content">
				<asp:Label ID="lblEmployeeId" runat="server" Text='<%# Bind("EmployeeId") %>'/>			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				TerritoryId:
			</td>
			<td class="content">
				<asp:Label ID="lblTerritoryId" runat="server" Text='<%# Bind("TerritoryId") %>'/>			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br>
				<hr align="left" size="1" />
				<asp:Button ID="btnUpdateAndHome" runat="server" ValidationGroup="EditValidations" CausesValidation="True" CommandName="UpdateAndHome" Text="Update and Home" SkinId="ButtonSkin"/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</EditItemTemplate>
<ItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts" width="700">
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				EmployeeId:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblEmployeeId" runat="server" Text='<%# Bind("EmployeeId") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				TerritoryId:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblTerritoryId" runat="server" Text='<%# Bind("TerritoryId") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br>
				<hr align="left" size="1" />
				<asp:Button ID="btnEdit" runat="server" CausesValidation="True" CommandName="EditExisting" Text="Edit" SkinId="ButtonSkin"/>
				<asp:Button ID="btnDelete" runat="server" CausesValidation="True" CommandName="DeleteExisting" Text="Delete and Home" SkinId="ButtonSkin" visible="false" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this EmployeeTerritory instance with PK values: "  + "EmployeeId: " + Eval("EmployeeId") + "TerritoryId: " + Eval("TerritoryId") + " ?\");" %>'/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</ItemTemplate>
</asp:FormView>