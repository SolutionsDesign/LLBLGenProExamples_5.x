
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_EditAuditInfo" Codebehind="EditAuditInfo.ascx.cs" %>
<llblgenpro:LLBLGenProDataSource2 ID="_AuditInfoDS" runat="server" MaxNumberOfItemsToReturn="1" DataContainerType="EntityCollection" AdapterTypeName="SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.Examples.AuditingDBSpecific" EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.AuditInfoEntityFactory, SD.LLBLGen.Pro.Examples.Auditing" LivePersistence="False" OnPerformSelect="_AuditInfoDS_PerformSelect" OnPerformWork="_AuditInfoDS_PerformWork"/>
<asp:FormView ID="frmEditAuditInfo" DataKeyNames="AuditInfoId" runat="server" DefaultMode="insert" DataSourceID="_AuditInfoDS" Cellpadding="0" OnItemCommand="frmEditAuditInfo_ItemCommand" OnItemCreated="frmEditAuditInfo_ItemCreated">
<InsertItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				AuditInfoId:
			</td>
			<td class="content">
				Auto generated
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ActionDateTime:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxActionDateTime" runat="server" Required="True" Value='<%# Bind("ActionDateTime") %>' ValidationGroup="InsertValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqActionDateTime" runat="server" ControlToValidate="dtxActionDateTime" Display="Dynamic" ErrorMessage="Required" />
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				AffectedEntityName:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="3" id="tbxAffectedEntityName" runat="server" maxlength="100" Text='<%# Bind("AffectedEntityName") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqAffectedEntityName" runat="server" ControlToValidate="tbxAffectedEntityName" Display="Dynamic" ErrorMessage="Required" />
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				AuditActionTypeId:
			</td>
			<td class="content">
				<asp:textbox id="tbxAuditActionTypeId" runat="server" maxlength="11" size="11" Text='<%# Bind("AuditActionTypeId") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valAuditActionTypeId" runat="server" ControlToValidate="tbxAuditActionTypeId" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqAuditActionTypeId" runat="server" ControlToValidate="tbxAuditActionTypeId" Display="Dynamic" ErrorMessage="Required" />
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				ActionData:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="6" id="tbxActionData" runat="server" maxlength="250" Text='<%# Bind("ActionData") %>' ValidationGroup="InsertValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				UserId:
			</td>
			<td class="content">
				<asp:textbox id="tbxUserId" runat="server" maxlength="15" size="15" Text='<%# Bind("UserId") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqUserId" runat="server" ControlToValidate="tbxUserId" Display="Dynamic" ErrorMessage="Required" />
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
				AuditInfoId:
			</td>
			<td class="content">
				<asp:Label ID="lblAuditInfoId" runat="server" Text='<%# Bind("AuditInfoId") %>'/>			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ActionDateTime:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxActionDateTime" runat="server" Required="True" Value='<%# Bind("ActionDateTime") %>' ValidationGroup="EditValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqActionDateTime" runat="server" ControlToValidate="dtxActionDateTime" Display="Dynamic" ErrorMessage="Required" />
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				AffectedEntityName:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="3" id="tbxAffectedEntityName" runat="server" maxlength="100" Text='<%# Bind("AffectedEntityName") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqAffectedEntityName" runat="server" ControlToValidate="tbxAffectedEntityName" Display="Dynamic" ErrorMessage="Required" />
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				AuditActionTypeId:
			</td>
			<td class="content">
				<asp:textbox id="tbxAuditActionTypeId" runat="server" maxlength="11" size="11" Text='<%# Bind("AuditActionTypeId") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valAuditActionTypeId" runat="server" ControlToValidate="tbxAuditActionTypeId" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Invalid value" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqAuditActionTypeId" runat="server" ControlToValidate="tbxAuditActionTypeId" Display="Dynamic" ErrorMessage="Required" />
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				ActionData:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="6" id="tbxActionData" runat="server" maxlength="250" Text='<%# Bind("ActionData") %>' ValidationGroup="EditValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				UserId:
			</td>
			<td class="content">
				<asp:textbox id="tbxUserId" runat="server" maxlength="15" size="15" Text='<%# Bind("UserId") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqUserId" runat="server" ControlToValidate="tbxUserId" Display="Dynamic" ErrorMessage="Required" />
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
				AuditInfoId:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblAuditInfoId" runat="server" Text='<%# Bind("AuditInfoId") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ActionDateTime:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblActionDateTime" runat="server" Text='<%# Bind("ActionDateTime", "{0:dd-MMM-yyyy HH:mm.ss}") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				AffectedEntityName:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblAffectedEntityName" runat="server" Text='<%# Bind("AffectedEntityName") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				AuditActionType:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblAuditActionTypeId" runat="server" Text='<%# Eval("AuditActionType.Name") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ActionData:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblActionData" runat="server" Text='<%# Bind("ActionData") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				UserId:
			</td>
			<td class="content" width="100%">
				<asp:HyperLink ID="lnkUserId" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.UserEntity).ToString() + "&UserId=" + Eval("UserId")%>' Text='<%# Bind("UserId") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br>
				<hr align="left" size="1" />
				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</ItemTemplate>
</asp:FormView>