
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_SearchOrderAuditInfo" Codebehind="SearchOrderAuditInfo.ascx.cs" %>
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
			AuditInfoId:
		</td>
		<td class="content">
			<asp:textbox id="tbxAuditInfoId" runat="server" maxlength="11" size="11" Text="" ValidationGroup="PkSearchValidation"  CssClass="required"/>  <asp:RangeValidator ID="valAuditInfoId" runat="server" ControlToValidate="tbxAuditInfoId" ValidationGroup="PkSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="PkSearchValidation" ID="reqAuditInfoId" runat="server" ControlToValidate="tbxAuditInfoId" Display="Dynamic" ErrorMessage="Required" />
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
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableAuditInfoId" runat="server" /></td>
		<td class="formtexts tableborder">
			AuditInfoId:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotAuditInfoId" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opAuditInfoId" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxAuditInfoIdMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiAuditInfoIdMiFrom" runat="server" ControlToValidate="tbxAuditInfoIdMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxAuditInfoIdMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiAuditInfoIdMiTo" runat="server" ControlToValidate="tbxAuditInfoIdMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableActionDateTime" runat="server" /></td>
		<td class="formtexts tableborder">
			ActionDateTime:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotActionDateTime" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opActionDateTime" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<cc:datetextbox id="dtxActionDateTimeMiFrom" runat="server" Required="False" ValidationGroup="SubSetSearchValidation" /> 
			and
			<cc:datetextbox id="dtxActionDateTimeMiTo" runat="server" Required="False" ValidationGroup="SubSetSearchValidation" /> 

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableAffectedEntityName" runat="server" /></td>
		<td class="formtexts tableborder">
			AffectedEntityName:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotAffectedEntityName" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opAffectedEntityName" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxAffectedEntityNameMiFrom" runat="server" maxlength="100" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableAuditActionTypeId" runat="server" /></td>
		<td class="formtexts tableborder">
			AuditActionTypeId:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotAuditActionTypeId" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opAuditActionTypeId" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxAuditActionTypeIdMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiAuditActionTypeIdMiFrom" runat="server" ControlToValidate="tbxAuditActionTypeIdMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxAuditActionTypeIdMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiAuditActionTypeIdMiTo" runat="server" ControlToValidate="tbxAuditActionTypeIdMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableActionData" runat="server" /></td>
		<td class="formtexts tableborder">
			ActionData:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotActionData" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opActionData" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxActionDataMiFrom" runat="server" maxlength="250" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 

		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableUserId" runat="server" /></td>
		<td class="formtexts tableborder">
			UserId:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotUserId" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opUserId" runat="server">
				<asp:ListItem Value="0" Text="Equal"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		<td class="content tableborder" nowrap="nowrap">
			<asp:textbox id="tbxUserIdMiFrom" runat="server" maxlength="15" size="15" Text="" ValidationGroup="SubSetSearchValidation" /> 

		</td>
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
