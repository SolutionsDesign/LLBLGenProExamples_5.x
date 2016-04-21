
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_EditEmployee" Codebehind="EditEmployee.ascx.cs" %>
<llblgenpro:LLBLGenProDataSource2 ID="_EmployeeDS" runat="server" MaxNumberOfItemsToReturn="1" DataContainerType="EntityCollection" AdapterTypeName="SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.Examples.AuditingDBSpecific" EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.EmployeeEntityFactory, SD.LLBLGen.Pro.Examples.Auditing" LivePersistence="False" OnPerformSelect="_EmployeeDS_PerformSelect" OnPerformWork="_EmployeeDS_PerformWork"/>
<asp:FormView ID="frmEditEmployee" DataKeyNames="EmployeeId" runat="server" DefaultMode="insert" DataSourceID="_EmployeeDS" Cellpadding="0" OnItemCommand="frmEditEmployee_ItemCommand" OnItemCreated="frmEditEmployee_ItemCreated">
<InsertItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				EmployeeId:
			</td>
			<td class="content">
				Auto generated
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				LastName:
			</td>
			<td class="content">
				<asp:textbox id="tbxLastName" runat="server" maxlength="20" size="20" Text='<%# Bind("LastName") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqLastName" runat="server" ControlToValidate="tbxLastName" Display="Dynamic" ErrorMessage="Required" />
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				FirstName:
			</td>
			<td class="content">
				<asp:textbox id="tbxFirstName" runat="server" maxlength="10" size="10" Text='<%# Bind("FirstName") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqFirstName" runat="server" ControlToValidate="tbxFirstName" Display="Dynamic" ErrorMessage="Required" />
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Title:
			</td>
			<td class="content">
				<asp:textbox id="tbxTitle" runat="server" maxlength="30" size="30" Text='<%# Bind("Title") %>' ValidationGroup="InsertValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				TitleOfCourtesy:
			</td>
			<td class="content">
				<asp:textbox id="tbxTitleOfCourtesy" runat="server" maxlength="25" size="25" Text='<%# Bind("TitleOfCourtesy") %>' ValidationGroup="InsertValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				BirthDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxBirthDate" runat="server" Required="False" Value='<%# Bind("BirthDate") %>' ValidationGroup="InsertValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				HireDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxHireDate" runat="server" Required="False" Value='<%# Bind("HireDate") %>' ValidationGroup="InsertValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Address:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="2" id="tbxAddress" runat="server" maxlength="60" Text='<%# Bind("Address") %>' ValidationGroup="InsertValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				City:
			</td>
			<td class="content">
				<asp:textbox id="tbxCity" runat="server" maxlength="15" size="15" Text='<%# Bind("City") %>' ValidationGroup="InsertValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Region:
			</td>
			<td class="content">
				<asp:textbox id="tbxRegion" runat="server" maxlength="15" size="15" Text='<%# Bind("Region") %>' ValidationGroup="InsertValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				PostalCode:
			</td>
			<td class="content">
				<asp:textbox id="tbxPostalCode" runat="server" maxlength="10" size="10" Text='<%# Bind("PostalCode") %>' ValidationGroup="InsertValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Country:
			</td>
			<td class="content">
				<asp:textbox id="tbxCountry" runat="server" maxlength="15" size="15" Text='<%# Bind("Country") %>' ValidationGroup="InsertValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				HomePhone:
			</td>
			<td class="content">
				<asp:textbox id="tbxHomePhone" runat="server" maxlength="24" size="24" Text='<%# Bind("HomePhone") %>' ValidationGroup="InsertValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Extension:
			</td>
			<td class="content">
				<asp:textbox id="tbxExtension" runat="server" maxlength="4" size="4" Text='<%# Bind("Extension") %>' ValidationGroup="InsertValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Photo:
			</td>
			<td class="content">
				<asp:FileUpload ID="fuPhoto" runat="server" size="50" ValidationGroup="InsertValidations" FileBytes='<%# Bind("Photo") %>' /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Notes:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="10" id="tbxNotes" runat="server" maxlength="1073741823" Text='<%# Bind("Notes") %>' ValidationGroup="InsertValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			
			<td class="formtexts" >
				ReportsTo:
			</td>
			<td class="content" style="width: 345px">
                <llblgenpro:LLBLGenProDataSource2 ID="_Employee_ReportsToDS" runat="server" AdapterTypeName="SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.Examples.AuditingDBSpecific"
                    DataContainerType="EntityCollection" EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.EmployeeEntityFactory, SD.LLBLGen.Pro.Examples.Auditing">
                </llblgenpro:LLBLGenProDataSource2>
				<asp:DropDownList ID="cbxReportsTo" runat="server" AppendDataBoundItems="true" SelectedValue='<%# Bind("ReportsTo") %>' DataSourceID="_Employee_ReportsToDS" DataValueField="EmployeeId" DataTextField="FullName" AutoPostBack="False">

				</asp:DropDownList>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				PhotoPath:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="6" id="tbxPhotoPath" runat="server" maxlength="255" Text='<%# Bind("PhotoPath") %>' ValidationGroup="InsertValidations" /> 
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
				LastName:
			</td>
			<td class="content">
				<asp:textbox id="tbxLastName" runat="server" maxlength="20" size="20" Text='<%# Bind("LastName") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqLastName" runat="server" ControlToValidate="tbxLastName" Display="Dynamic" ErrorMessage="Required" />
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				FirstName:
			</td>
			<td class="content">
				<asp:textbox id="tbxFirstName" runat="server" maxlength="10" size="10" Text='<%# Bind("FirstName") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqFirstName" runat="server" ControlToValidate="tbxFirstName" Display="Dynamic" ErrorMessage="Required" />
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Title:
			</td>
			<td class="content">
				<asp:textbox id="tbxTitle" runat="server" maxlength="30" size="30" Text='<%# Bind("Title") %>' ValidationGroup="EditValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				TitleOfCourtesy:
			</td>
			<td class="content">
				<asp:textbox id="tbxTitleOfCourtesy" runat="server" maxlength="25" size="25" Text='<%# Bind("TitleOfCourtesy") %>' ValidationGroup="EditValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				BirthDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxBirthDate" runat="server" Required="False" Value='<%# Bind("BirthDate") %>' ValidationGroup="EditValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				HireDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxHireDate" runat="server" Required="False" Value='<%# Bind("HireDate") %>' ValidationGroup="EditValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Address:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="2" id="tbxAddress" runat="server" maxlength="60" Text='<%# Bind("Address") %>' ValidationGroup="EditValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				City:
			</td>
			<td class="content">
				<asp:textbox id="tbxCity" runat="server" maxlength="15" size="15" Text='<%# Bind("City") %>' ValidationGroup="EditValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Region:
			</td>
			<td class="content">
				<asp:textbox id="tbxRegion" runat="server" maxlength="15" size="15" Text='<%# Bind("Region") %>' ValidationGroup="EditValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				PostalCode:
			</td>
			<td class="content">
				<asp:textbox id="tbxPostalCode" runat="server" maxlength="10" size="10" Text='<%# Bind("PostalCode") %>' ValidationGroup="EditValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Country:
			</td>
			<td class="content">
				<asp:textbox id="tbxCountry" runat="server" maxlength="15" size="15" Text='<%# Bind("Country") %>' ValidationGroup="EditValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				HomePhone:
			</td>
			<td class="content">
				<asp:textbox id="tbxHomePhone" runat="server" maxlength="24" size="24" Text='<%# Bind("HomePhone") %>' ValidationGroup="EditValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Extension:
			</td>
			<td class="content">
				<asp:textbox id="tbxExtension" runat="server" maxlength="4" size="4" Text='<%# Bind("Extension") %>' ValidationGroup="EditValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Photo:
			</td>
			<td class="content">
				Binary lob
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Notes:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="10" id="tbxNotes" runat="server" maxlength="1073741823" Text='<%# Bind("Notes") %>' ValidationGroup="EditValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ReportsTo:
			</td>
			<td class="content" style="width: 345px">
                <llblgenpro:LLBLGenProDataSource2 ID="_Employee_ReportsToDS" runat="server" AdapterTypeName="SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.Examples.AuditingDBSpecific"
                    DataContainerType="EntityCollection" EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.EmployeeEntityFactory, SD.LLBLGen.Pro.Examples.Auditing">
                </llblgenpro:LLBLGenProDataSource2>
				<asp:DropDownList ID="cbxReportsTo" runat="server" AppendDataBoundItems="true" SelectedValue='<%# Bind("ReportsTo") %>' DataSourceID="_Employee_ReportsToDS" DataValueField="EmployeeId" DataTextField="FullName" AutoPostBack="False">                    

				</asp:DropDownList>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				PhotoPath:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="6" id="tbxPhotoPath" runat="server" maxlength="255" Text='<%# Bind("PhotoPath") %>' ValidationGroup="EditValidations" /> 
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
				LastName:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblLastName" runat="server" Text='<%# Bind("LastName") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				FirstName:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblFirstName" runat="server" Text='<%# Bind("FirstName") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Title:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblTitle" runat="server" Text='<%# Bind("Title") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				TitleOfCourtesy:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblTitleOfCourtesy" runat="server" Text='<%# Bind("TitleOfCourtesy") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				BirthDate:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblBirthDate" runat="server" Text='<%# Bind("BirthDate", "{0:dd-MMM-yyyy HH:mm.ss}") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				HireDate:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblHireDate" runat="server" Text='<%# Bind("HireDate", "{0:dd-MMM-yyyy HH:mm.ss}") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Address:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblAddress" runat="server" Text='<%# Bind("Address") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				City:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblCity" runat="server" Text='<%# Bind("City") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Region:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblRegion" runat="server" Text='<%# Bind("Region") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				PostalCode:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblPostalCode" runat="server" Text='<%# Bind("PostalCode") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Country:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblCountry" runat="server" Text='<%# Bind("Country") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				HomePhone:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblHomePhone" runat="server" Text='<%# Bind("HomePhone") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Extension:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblExtension" runat="server" Text='<%# Bind("Extension") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Photo:
			</td>
			<td class="content" width="100%">
						Binary lob 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Notes:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblNotes" runat="server" Text='<%# Bind("Notes") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ReportsTo:
			</td>
			<td class="content" width="100%">
				<asp:HyperLink ID="lnkReportsTo" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.EmployeeEntity).ToString() + "&EmployeeId=" + Eval("ReportsTo")%>' Text='<%# Eval("Employees.FullName") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				PhotoPath:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblPhotoPath" runat="server" Text='<%# Bind("PhotoPath") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br>
				<hr align="left" size="1" />
				<asp:Button ID="btnEdit" runat="server" CausesValidation="True" CommandName="EditExisting" Text="Edit" SkinId="ButtonSkin"/>
				<asp:Button ID="btnDelete" runat="server" CausesValidation="True" CommandName="DeleteExisting" Text="Delete and Home" SkinId="ButtonSkin" visible="false" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this Employee instance with PK values: "  + "EmployeeId: " + Eval("EmployeeId") + " ?\");" %>'/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</ItemTemplate>
</asp:FormView>