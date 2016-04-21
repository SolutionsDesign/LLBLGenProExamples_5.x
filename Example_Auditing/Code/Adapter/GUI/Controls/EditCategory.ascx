
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_EditCategory" Codebehind="EditCategory.ascx.cs" %>
<llblgenpro:LLBLGenProDataSource2 ID="_CategoryDS" runat="server" MaxNumberOfItemsToReturn="1" DataContainerType="EntityCollection" AdapterTypeName="SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.Examples.AuditingDBSpecific" EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.CategoryEntityFactory, SD.LLBLGen.Pro.Examples.Auditing" LivePersistence="False" OnPerformSelect="_CategoryDS_PerformSelect" OnPerformWork="_CategoryDS_PerformWork"/>
<asp:FormView ID="frmEditCategory" DataKeyNames="CategoryId" runat="server" DefaultMode="insert" DataSourceID="_CategoryDS" Cellpadding="0" OnItemCommand="frmEditCategory_ItemCommand" OnItemCreated="frmEditCategory_ItemCreated">
<InsertItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CategoryId:
			</td>
			<td class="content">
				Auto generated
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CategoryName:
			</td>
			<td class="content">
				<asp:textbox id="tbxCategoryName" runat="server" maxlength="15" size="15" Text='<%# Bind("CategoryName") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqCategoryName" runat="server" ControlToValidate="tbxCategoryName" Display="Dynamic" ErrorMessage="Required" />
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Description:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="10" id="tbxDescription" runat="server" maxlength="1073741823" Text='<%# Bind("Description") %>' ValidationGroup="InsertValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Picture:
			</td>
			<td class="content">
				<asp:FileUpload ID="fuPicture" runat="server" size="50" ValidationGroup="InsertValidations" FileBytes='<%# Bind("Picture") %>' /> 
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
				CategoryId:
			</td>
			<td class="content">
				<asp:Label ID="lblCategoryId" runat="server" Text='<%# Bind("CategoryId") %>'/>			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CategoryName:
			</td>
			<td class="content">
				<asp:textbox id="tbxCategoryName" runat="server" maxlength="15" size="15" Text='<%# Bind("CategoryName") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqCategoryName" runat="server" ControlToValidate="tbxCategoryName" Display="Dynamic" ErrorMessage="Required" />
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Description:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="10" id="tbxDescription" runat="server" maxlength="1073741823" Text='<%# Bind("Description") %>' ValidationGroup="EditValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Picture:
			</td>
			<td class="content">
				Binary lob
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
				CategoryId:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblCategoryId" runat="server" Text='<%# Bind("CategoryId") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				CategoryName:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblCategoryName" runat="server" Text='<%# Bind("CategoryName") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Description:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblDescription" runat="server" Text='<%# Bind("Description") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Picture:
			</td>
			<td class="content" width="100%">
						Binary lob 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br>
				<hr align="left" size="1" />
				<asp:Button ID="btnEdit" runat="server" CausesValidation="True" CommandName="EditExisting" Text="Edit" SkinId="ButtonSkin"/>
				<asp:Button ID="btnDelete" runat="server" CausesValidation="True" CommandName="DeleteExisting" Text="Delete and Home" SkinId="ButtonSkin" visible="false" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this Category instance with PK values: "  + "CategoryId: " + Eval("CategoryId") + " ?\");" %>'/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</ItemTemplate>
</asp:FormView>