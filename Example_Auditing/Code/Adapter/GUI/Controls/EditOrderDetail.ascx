
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_EditOrderDetail" Codebehind="EditOrderDetail.ascx.cs" %>
<llblgenpro:LLBLGenProDataSource2 ID="_OrderDetailDS" runat="server" MaxNumberOfItemsToReturn="1" DataContainerType="EntityCollection" AdapterTypeName="SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.Examples.AuditingDBSpecific" EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.OrderDetailEntityFactory, SD.LLBLGen.Pro.Examples.Auditing" LivePersistence="False" OnPerformSelect="_OrderDetailDS_PerformSelect" OnPerformWork="_OrderDetailDS_PerformWork"/>
<asp:FormView ID="frmEditOrderDetail" DataKeyNames="OrderId, ProductId" runat="server" DefaultMode="insert" DataSourceID="_OrderDetailDS" Cellpadding="0" OnItemCommand="frmEditOrderDetail_ItemCommand" OnItemCreated="frmEditOrderDetail_ItemCreated">
<InsertItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				OrderId:
			</td>
			<td class="content">
				<asp:textbox id="tbxOrderId" runat="server" maxlength="11" size="11" Text='<%# Bind("OrderId") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valOrderId" runat="server" ControlToValidate="tbxOrderId" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqOrderId" runat="server" ControlToValidate="tbxOrderId" Display="Dynamic" ErrorMessage="Required" />
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ProductId:
			</td>
			<td class="content">
				<asp:textbox id="tbxProductId" runat="server" maxlength="11" size="11" Text='<%# Bind("ProductId") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valProductId" runat="server" ControlToValidate="tbxProductId" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqProductId" runat="server" ControlToValidate="tbxProductId" Display="Dynamic" ErrorMessage="Required" />
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				UnitPrice:
			</td>
			<td class="content">
				<asp:textbox id="tbxUnitPrice" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("UnitPrice") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqUnitPrice" runat="server" ControlToValidate="tbxUnitPrice" Display="Dynamic" ErrorMessage="Required" />
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Quantity:
			</td>
			<td class="content">
				<asp:textbox id="tbxQuantity" runat="server" maxlength="6" size="6" Text='<%# Bind("Quantity") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valQuantity" runat="server" ControlToValidate="tbxQuantity" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-32768" MaximumValue="32767" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqQuantity" runat="server" ControlToValidate="tbxQuantity" Display="Dynamic" ErrorMessage="Required" />
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Discount:
			</td>
			<td class="content">
				<asp:textbox id="tbxDiscount" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("Discount") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqDiscount" runat="server" ControlToValidate="tbxDiscount" Display="Dynamic" ErrorMessage="Required" />
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
				OrderId:
			</td>
			<td class="content">
				<asp:Label ID="lblOrderId" runat="server" Text='<%# Bind("OrderId") %>'/>			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ProductId:
			</td>
			<td class="content">
				<asp:Label ID="lblProductId" runat="server" Text='<%# Bind("ProductId") %>'/>			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				UnitPrice:
			</td>
			<td class="content">
				<asp:textbox id="tbxUnitPrice" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("UnitPrice") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqUnitPrice" runat="server" ControlToValidate="tbxUnitPrice" Display="Dynamic" ErrorMessage="Required" />
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Quantity:
			</td>
			<td class="content">
				<asp:textbox id="tbxQuantity" runat="server" maxlength="6" size="6" Text='<%# Bind("Quantity") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valQuantity" runat="server" ControlToValidate="tbxQuantity" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-32768" MaximumValue="32767" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqQuantity" runat="server" ControlToValidate="tbxQuantity" Display="Dynamic" ErrorMessage="Required" />
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Discount:
			</td>
			<td class="content">
				<asp:textbox id="tbxDiscount" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("Discount") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqDiscount" runat="server" ControlToValidate="tbxDiscount" Display="Dynamic" ErrorMessage="Required" />
			</td>
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
				OrderId:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblOrderId" runat="server" Text='<%# Bind("OrderId") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ProductId:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblProductId" runat="server" Text='<%# Bind("ProductId") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				UnitPrice:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblUnitPrice" runat="server" Text='<%# Bind("UnitPrice") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Quantity:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblQuantity" runat="server" Text='<%# Bind("Quantity") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Discount:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblDiscount" runat="server" Text='<%# Bind("Discount") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br>
				<hr align="left" size="1" />
				<asp:Button ID="btnEdit" runat="server" CausesValidation="True" CommandName="EditExisting" Text="Edit" SkinId="ButtonSkin"/>
				<asp:Button ID="btnDelete" runat="server" CausesValidation="True" CommandName="DeleteExisting" Text="Delete and Home" SkinId="ButtonSkin" visible="false" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this OrderDetail instance with PK values: "  + "OrderId: " + Eval("OrderId") + "ProductId: " + Eval("ProductId") + " ?\");" %>'/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</ItemTemplate>
</asp:FormView>