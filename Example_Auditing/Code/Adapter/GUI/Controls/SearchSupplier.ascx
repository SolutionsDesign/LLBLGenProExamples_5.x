
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_SearchSupplier" Codebehind="SearchSupplier.ascx.cs" %>
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
			SupplierId:
		</td>
		<td class="content">
			<asp:textbox id="tbxSupplierId" runat="server" maxlength="11" size="11" Text="" ValidationGroup="PkSearchValidation"  CssClass="required"/>  <asp:RangeValidator ID="valSupplierId" runat="server" ControlToValidate="tbxSupplierId" ValidationGroup="PkSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="PkSearchValidation" ID="reqSupplierId" runat="server" ControlToValidate="tbxSupplierId" Display="Dynamic" ErrorMessage="Required" />
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
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxSupplierIdMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiSupplierIdMiFrom" runat="server" ControlToValidate="tbxSupplierIdMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxSupplierIdMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiSupplierIdMiTo" runat="server" ControlToValidate="tbxSupplierIdMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableCompanyName" runat="server" /></td>
		<td class="formtexts tableborder">
			CompanyName:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotCompanyName" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opCompanyName" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxCompanyNameMiFrom" runat="server" maxlength="40" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableContactName" runat="server" /></td>
		<td class="formtexts tableborder">
			ContactName:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotContactName" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opContactName" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxContactNameMiFrom" runat="server" maxlength="30" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableContactTitle" runat="server" /></td>
		<td class="formtexts tableborder">
			ContactTitle:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotContactTitle" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opContactTitle" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxContactTitleMiFrom" runat="server" maxlength="30" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableAddress" runat="server" /></td>
		<td class="formtexts tableborder">
			Address:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotAddress" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opAddress" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxAddressMiFrom" runat="server" maxlength="60" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableCity" runat="server" /></td>
		<td class="formtexts tableborder">
			City:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotCity" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opCity" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxCityMiFrom" runat="server" maxlength="15" size="15" Text="" ValidationGroup="SubSetSearchValidation" /> 

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableRegion" runat="server" /></td>
		<td class="formtexts tableborder">
			Region:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotRegion" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opRegion" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxRegionMiFrom" runat="server" maxlength="15" size="15" Text="" ValidationGroup="SubSetSearchValidation" /> 

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnablePostalCode" runat="server" /></td>
		<td class="formtexts tableborder">
			PostalCode:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotPostalCode" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opPostalCode" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxPostalCodeMiFrom" runat="server" maxlength="10" size="10" Text="" ValidationGroup="SubSetSearchValidation" /> 

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableCountry" runat="server" /></td>
		<td class="formtexts tableborder">
			Country:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotCountry" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opCountry" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxCountryMiFrom" runat="server" maxlength="15" size="15" Text="" ValidationGroup="SubSetSearchValidation" /> 

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnablePhone" runat="server" /></td>
		<td class="formtexts tableborder">
			Phone:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotPhone" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opPhone" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxPhoneMiFrom" runat="server" maxlength="24" size="24" Text="" ValidationGroup="SubSetSearchValidation" /> 

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableFax" runat="server" /></td>
		<td class="formtexts tableborder">
			Fax:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotFax" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opFax" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxFaxMiFrom" runat="server" maxlength="24" size="24" Text="" ValidationGroup="SubSetSearchValidation" /> 

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableHomePage" runat="server" /></td>
		<td class="formtexts tableborder">
			HomePage:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotHomePage" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opHomePage" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxHomePageMiFrom" runat="server" maxlength="1073741823" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 

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
