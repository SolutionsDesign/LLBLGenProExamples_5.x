
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_SearchOrderDetail" Codebehind="SearchOrderDetail.ascx.cs" %>
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
			OrderId:
		</td>
		<td class="content">
			<asp:textbox id="tbxOrderId" runat="server" maxlength="11" size="11" Text="" ValidationGroup="PkSearchValidation"  CssClass="required"/>  <asp:RangeValidator ID="valOrderId" runat="server" ControlToValidate="tbxOrderId" ValidationGroup="PkSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="PkSearchValidation" ID="reqOrderId" runat="server" ControlToValidate="tbxOrderId" Display="Dynamic" ErrorMessage="Required" />
		</td>
		<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
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
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableOrderId" runat="server" /></td>
		<td class="formtexts tableborder">
			OrderId:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotOrderId" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opOrderId" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxOrderIdMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiOrderIdMiFrom" runat="server" ControlToValidate="tbxOrderIdMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxOrderIdMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiOrderIdMiTo" runat="server" ControlToValidate="tbxOrderIdMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>

		</td>
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
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxUnitPriceMiFrom" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
			and
			<asp:textbox id="tbxUnitPriceMiTo" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableQuantity" runat="server" /></td>
		<td class="formtexts tableborder">
			Quantity:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotQuantity" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opQuantity" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxQuantityMiFrom" runat="server" maxlength="6" size="6" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiQuantityMiFrom" runat="server" ControlToValidate="tbxQuantityMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-32768" MaximumValue="32767" Type="integer"/>
			and
			<asp:textbox id="tbxQuantityMiTo" runat="server" maxlength="6" size="6" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiQuantityMiTo" runat="server" ControlToValidate="tbxQuantityMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-32768" MaximumValue="32767" Type="integer"/>

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableDiscount" runat="server" /></td>
		<td class="formtexts tableborder">
			Discount:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotDiscount" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opDiscount" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxDiscountMiFrom" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
			and
			<asp:textbox id="tbxDiscountMiTo" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 

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
