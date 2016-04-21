
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_SearchProduct" Codebehind="SearchProduct.ascx.cs" %>
<asp:PlaceHolder id="phSingleInstance" runat="server" visible="true">
<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
	<tr>
		<td colspan="4" class="content">
			<hr align="left" size="1">
			<b>Fill in the primary key field(s)</b><br><br>
		</td>
	</tr>
	<tr>
		<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
		<td class="formtexts" >
			ProductId:
		</td>
		<td class="content">
			<asp:textbox id="tbxProductId" runat="server" maxlength="11" size="11" Text="" ValidationGroup="PkSearchValidation"  CssClass="required"/>  <asp:RangeValidator ID="valProductId" runat="server" ControlToValidate="tbxProductId" ValidationGroup="PkSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="PkSearchValidation" ID="reqProductId" runat="server" ControlToValidate="tbxProductId" Display="Dynamic" ErrorMessage="Required" />
		</td>
		<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="2" nowrap="nowrap" class="content">&nbsp;</td>
		<td class="content">
			<br>
			<asp:Button ID="btnSearchPk" runat="server" CausesValidation="True" ValidationGroup="PkSearchValidation" Text="Search..." SkinId="ButtonSkin" OnClick="btnSearchPk_Click"/>
			&nbsp;&nbsp;&nbsp;
			<asp:Button ID="btnCancelSearchPK" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			<br><br>
		</td>
		<td width="20" nowrap class="content">&nbsp;</td>
	</tr>

</table>
</asp:PlaceHolder>
<asp:PlaceHolder id="phMultiInstance" runat="server" visible="true">
<table cellpadding="2" border="0" cellspacing="0" class="formtexts">
	<tr>
		<td colspan="5" class="content">
			<b>Fill in one or more fields to find a subset.</b><br>
			To enable a filter on a field, check the checkbox in front of the field. Only if you use a Between operator, you have to fill in the second value textbox(es).
			If you use the Null operator, you can leave both textbox(es) empty. If you use the Like operator, you should use the '%' character as wildcard character.
			<br><br>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;">&nbsp;</td>
		<td class="content tableborder"><b>Fieldname</b></td>
		<td class="content tableborder"><b>Not</b></td>
		<td class="content tableborder"><b>Operator</b></td>
		<td class="content tableborder"><b>Values</b></td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableProductId" runat="server" /></td>
		<td class="formtexts tableborder">
			ProductId:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotProductId" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opProductId" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxProductIdMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiProductIdMiFrom" runat="server" ControlToValidate="tbxProductIdMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxProductIdMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiProductIdMiTo" runat="server" ControlToValidate="tbxProductIdMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableProductName" runat="server" /></td>
		<td class="formtexts tableborder">
			ProductName:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotProductName" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opProductName" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxProductNameMiFrom" runat="server" maxlength="40" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableSupplierId" runat="server" /></td>
		<td class="formtexts tableborder">
			SupplierId:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotSupplierId" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opSupplierId" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
				<asp:ListItem Value="6" Text="Null"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxSupplierIdMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiSupplierIdMiFrom" runat="server" ControlToValidate="tbxSupplierIdMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxSupplierIdMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiSupplierIdMiTo" runat="server" ControlToValidate="tbxSupplierIdMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableCategoryId" runat="server" /></td>
		<td class="formtexts tableborder">
			CategoryId:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotCategoryId" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opCategoryId" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
				<asp:ListItem Value="6" Text="Null"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxCategoryIdMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiCategoryIdMiFrom" runat="server" ControlToValidate="tbxCategoryIdMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxCategoryIdMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiCategoryIdMiTo" runat="server" ControlToValidate="tbxCategoryIdMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableQuantityPerUnit" runat="server" /></td>
		<td class="formtexts tableborder">
			QuantityPerUnit:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotQuantityPerUnit" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opQuantityPerUnit" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxQuantityPerUnitMiFrom" runat="server" maxlength="20" size="20" Text="" ValidationGroup="SubSetSearchValidation" /> 

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableUnitPrice" runat="server" /></td>
		<td class="formtexts tableborder">
			UnitPrice:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotUnitPrice" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opUnitPrice" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
				<asp:ListItem Value="6" Text="Null"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxUnitPriceMiFrom" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
			and
			<asp:textbox id="tbxUnitPriceMiTo" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableUnitsInStock" runat="server" /></td>
		<td class="formtexts tableborder">
			UnitsInStock:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotUnitsInStock" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opUnitsInStock" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
				<asp:ListItem Value="6" Text="Null"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxUnitsInStockMiFrom" runat="server" maxlength="6" size="6" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiUnitsInStockMiFrom" runat="server" ControlToValidate="tbxUnitsInStockMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-32768" MaximumValue="32767" Type="integer"/>
			and
			<asp:textbox id="tbxUnitsInStockMiTo" runat="server" maxlength="6" size="6" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiUnitsInStockMiTo" runat="server" ControlToValidate="tbxUnitsInStockMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-32768" MaximumValue="32767" Type="integer"/>

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableUnitsOnOrder" runat="server" /></td>
		<td class="formtexts tableborder">
			UnitsOnOrder:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotUnitsOnOrder" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opUnitsOnOrder" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
				<asp:ListItem Value="6" Text="Null"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxUnitsOnOrderMiFrom" runat="server" maxlength="6" size="6" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiUnitsOnOrderMiFrom" runat="server" ControlToValidate="tbxUnitsOnOrderMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-32768" MaximumValue="32767" Type="integer"/>
			and
			<asp:textbox id="tbxUnitsOnOrderMiTo" runat="server" maxlength="6" size="6" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiUnitsOnOrderMiTo" runat="server" ControlToValidate="tbxUnitsOnOrderMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-32768" MaximumValue="32767" Type="integer"/>

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableReorderLevel" runat="server" /></td>
		<td class="formtexts tableborder">
			ReorderLevel:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotReorderLevel" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opReorderLevel" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
				<asp:ListItem Value="6" Text="Null"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxReorderLevelMiFrom" runat="server" maxlength="6" size="6" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiReorderLevelMiFrom" runat="server" ControlToValidate="tbxReorderLevelMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-32768" MaximumValue="32767" Type="integer"/>
			and
			<asp:textbox id="tbxReorderLevelMiTo" runat="server" maxlength="6" size="6" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiReorderLevelMiTo" runat="server" ControlToValidate="tbxReorderLevelMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-32768" MaximumValue="32767" Type="integer"/>

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableDiscontinued" runat="server" /></td>
		<td class="formtexts tableborder">
			Discontinued:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotDiscontinued" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opDiscontinued" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:checkbox id="chkDiscontinuedMiFrom" runat="server" Checked=""/>

		</td>
	</tr>

	<tr>
		<td colspan="2" nowrap="nowrap" class="content">&nbsp;</td>
		<td colspan="3" class="content">
			<br>
			<asp:Button ID="btnSearchSubSet" runat="server" CausesValidation="True" ValidationGroup="SubSetSearchValidation" Text="Search..." SkinId="ButtonSkin" OnClick="btnSearchSubSet_Click"/>
			&nbsp;&nbsp;&nbsp;
			<asp:Button ID="btnCancelSearchSubSet" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			<br><br>
		</td>
	</tr>
</table>
</asp:PlaceHolder>
