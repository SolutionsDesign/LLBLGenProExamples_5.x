
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_EditProduct" Codebehind="EditProduct.ascx.cs" %>
<llblgenpro:LLBLGenProDataSource2 ID="_ProductDS" runat="server" MaxNumberOfItemsToReturn="1" DataContainerType="EntityCollection" AdapterTypeName="SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.Examples.AuditingDBSpecific" EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.ProductEntityFactory, SD.LLBLGen.Pro.Examples.Auditing" LivePersistence="False" OnPerformSelect="_ProductDS_PerformSelect" OnPerformWork="_ProductDS_PerformWork"/>
<asp:FormView ID="frmEditProduct" DataKeyNames="ProductId" runat="server" DefaultMode="insert" DataSourceID="_ProductDS" Cellpadding="0" OnItemCommand="frmEditProduct_ItemCommand" OnItemCreated="frmEditProduct_ItemCreated">
<InsertItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ProductId:
			</td>
			<td class="content">
				Auto generated
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ProductName:
			</td>
			<td class="content">
				<asp:textbox id="tbxProductName" runat="server" maxlength="40" size="40" Text='<%# Bind("ProductName") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqProductName" runat="server" ControlToValidate="tbxProductName" Display="Dynamic" ErrorMessage="Required" />
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Supplier:
			</td>
			<td class="content" style="width: 345px">
                <llblgenpro:LLBLGenProDataSource2 ID="_Supplier_SupplierIdDS" runat="server" AdapterTypeName="SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.Examples.AuditingDBSpecific"
                    DataContainerType="EntityCollection" EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.SupplierEntityFactory, SD.LLBLGen.Pro.Examples.Auditing">
                </llblgenpro:LLBLGenProDataSource2>
				<asp:DropDownList ID="cbxSupplier" runat="server" AppendDataBoundItems="true" SelectedValue='<%# Bind("SupplierId") %>' DataSourceID="_Supplier_SupplierIdDS" DataValueField="SupplierId" DataTextField="CompanyName" AutoPostBack="False">

				</asp:DropDownList>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Category:
			</td>
			<td class="content" style="width: 345px">
                <llblgenpro:LLBLGenProDataSource2 ID="_Category_CategoryIdDS" runat="server" AdapterTypeName="SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.Examples.AuditingDBSpecific"
                    DataContainerType="EntityCollection" EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.CategoryEntityFactory, SD.LLBLGen.Pro.Examples.Auditing">
                </llblgenpro:LLBLGenProDataSource2>
				<asp:DropDownList ID="cbxCategory" runat="server" AppendDataBoundItems="true" SelectedValue='<%# Bind("CategoryId") %>' DataSourceID="_Category_CategoryIdDS" DataValueField="CategoryId" DataTextField="CategoryName" AutoPostBack="False">

				</asp:DropDownList>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				QuantityPerUnit:
			</td>
			<td class="content">
				<asp:textbox id="tbxQuantityPerUnit" runat="server" maxlength="20" size="20" Text='<%# Bind("QuantityPerUnit") %>' ValidationGroup="InsertValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				UnitPrice:
			</td>
			<td class="content">
				<asp:textbox id="tbxUnitPrice" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("UnitPrice") %>' /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				UnitsInStock:
			</td>
			<td class="content">
				<asp:textbox id="tbxUnitsInStock" runat="server" maxlength="6" size="6" Text='<%# Bind("UnitsInStock") %>' ValidationGroup="InsertValidations" /> <asp:RangeValidator ID="valUnitsInStock" runat="server" ControlToValidate="tbxUnitsInStock" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-32768" MaximumValue="32767" Type="integer"/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				UnitsOnOrder:
			</td>
			<td class="content">
				<asp:textbox id="tbxUnitsOnOrder" runat="server" maxlength="6" size="6" Text='<%# Bind("UnitsOnOrder") %>' ValidationGroup="InsertValidations" /> <asp:RangeValidator ID="valUnitsOnOrder" runat="server" ControlToValidate="tbxUnitsOnOrder" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-32768" MaximumValue="32767" Type="integer"/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ReorderLevel:
			</td>
			<td class="content">
				<asp:textbox id="tbxReorderLevel" runat="server" maxlength="6" size="6" Text='<%# Bind("ReorderLevel") %>' ValidationGroup="InsertValidations" /> <asp:RangeValidator ID="valReorderLevel" runat="server" ControlToValidate="tbxReorderLevel" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-32768" MaximumValue="32767" Type="integer"/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Discontinued:
			</td>
			<td class="content">
				<asp:checkbox id="chkDiscontinued" runat="server" Checked='<%# Bind("Discontinued") %>' CssClass="required"/>
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
				ProductId:
			</td>
			<td class="content">
				<asp:Label ID="lblProductId" runat="server" Text='<%# Bind("ProductId") %>'/>			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ProductName:
			</td>
			<td class="content">
				<asp:textbox id="tbxProductName" runat="server" maxlength="40" size="40" Text='<%# Bind("ProductName") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqProductName" runat="server" ControlToValidate="tbxProductName" Display="Dynamic" ErrorMessage="Required" />
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Supplier:
			</td>
			<td class="content" style="width: 345px">
                <llblgenpro:LLBLGenProDataSource2 ID="_Supplier_SupplierIdDS" runat="server" AdapterTypeName="SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.Examples.AuditingDBSpecific"
                    DataContainerType="EntityCollection" EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.SupplierEntityFactory, SD.LLBLGen.Pro.Examples.Auditing">
                </llblgenpro:LLBLGenProDataSource2>
				<asp:DropDownList ID="cbxSupplier" runat="server" AppendDataBoundItems="true" SelectedValue='<%# Bind("SupplierId") %>' DataSourceID="_Supplier_SupplierIdDS" DataValueField="SupplierId" DataTextField="CompanyName" AutoPostBack="False">

				</asp:DropDownList>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Category:
			</td>
			<td class="content" style="width: 345px">
                <llblgenpro:LLBLGenProDataSource2 ID="_Category_CategoryIdDS" runat="server" AdapterTypeName="SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.Examples.AuditingDBSpecific"
                    DataContainerType="EntityCollection" EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.CategoryEntityFactory, SD.LLBLGen.Pro.Examples.Auditing">
                </llblgenpro:LLBLGenProDataSource2>
				<asp:DropDownList ID="cbxCategory" runat="server" AppendDataBoundItems="true" SelectedValue='<%# Bind("CategoryId") %>' DataSourceID="_Category_CategoryIdDS" DataValueField="CategoryId" DataTextField="CategoryName" AutoPostBack="False">

				</asp:DropDownList>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				QuantityPerUnit:
			</td>
			<td class="content">
				<asp:textbox id="tbxQuantityPerUnit" runat="server" maxlength="20" size="20" Text='<%# Bind("QuantityPerUnit") %>' ValidationGroup="EditValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				UnitPrice:
			</td>
			<td class="content">
				<asp:textbox id="tbxUnitPrice" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("UnitPrice") %>' /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				UnitsInStock:
			</td>
			<td class="content">
				<asp:textbox id="tbxUnitsInStock" runat="server" maxlength="6" size="6" Text='<%# Bind("UnitsInStock") %>' ValidationGroup="EditValidations" /> <asp:RangeValidator ID="valUnitsInStock" runat="server" ControlToValidate="tbxUnitsInStock" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-32768" MaximumValue="32767" Type="integer"/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				UnitsOnOrder:
			</td>
			<td class="content">
				<asp:textbox id="tbxUnitsOnOrder" runat="server" maxlength="6" size="6" Text='<%# Bind("UnitsOnOrder") %>' ValidationGroup="EditValidations" /> <asp:RangeValidator ID="valUnitsOnOrder" runat="server" ControlToValidate="tbxUnitsOnOrder" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-32768" MaximumValue="32767" Type="integer"/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ReorderLevel:
			</td>
			<td class="content">
				<asp:textbox id="tbxReorderLevel" runat="server" maxlength="6" size="6" Text='<%# Bind("ReorderLevel") %>' ValidationGroup="EditValidations" /> <asp:RangeValidator ID="valReorderLevel" runat="server" ControlToValidate="tbxReorderLevel" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-32768" MaximumValue="32767" Type="integer"/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Discontinued:
			</td>
			<td class="content">
				<asp:checkbox id="chkDiscontinued" runat="server" Checked='<%# Bind("Discontinued") %>' CssClass="required"/>
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
				ProductName:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblProductName" runat="server" Text='<%# Bind("ProductName") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Supplier:
			</td>
			<td class="content" width="100%">
				<asp:HyperLink ID="lnkSupplierId" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.SupplierEntity).ToString() + "&SupplierId=" + Eval("SupplierId")%>' Text='<%# Eval("Suppliers.CompanyName") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Category:
			</td>
			<td class="content" width="100%">
				<asp:HyperLink ID="lnkCategoryId" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.CategoryEntity).ToString() + "&CategoryId=" + Eval("CategoryId")%>' Text='<%# Eval("Categories.CategoryName") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				QuantityPerUnit:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblQuantityPerUnit" runat="server" Text='<%# Bind("QuantityPerUnit") %>'/>
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
				UnitsInStock:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblUnitsInStock" runat="server" Text='<%# Bind("UnitsInStock") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				UnitsOnOrder:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblUnitsOnOrder" runat="server" Text='<%# Bind("UnitsOnOrder") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ReorderLevel:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblReorderLevel" runat="server" Text='<%# Bind("ReorderLevel") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Discontinued:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblDiscontinued" runat="server" Text='<%# Bind("Discontinued") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br>
				<hr align="left" size="1" />
				<asp:Button ID="btnEdit" runat="server" CausesValidation="True" CommandName="EditExisting" Text="Edit" SkinId="ButtonSkin"/>
				<asp:Button ID="btnDelete" runat="server" CausesValidation="True" CommandName="DeleteExisting" Text="Delete and Home" SkinId="ButtonSkin" visible="false" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this Product instance with PK values: "  + "ProductId: " + Eval("ProductId") + " ?\");" %>'/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</ItemTemplate>
</asp:FormView>