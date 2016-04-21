
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_EditOrder" Codebehind="EditOrder.ascx.cs" %>
<llblgenpro:LLBLGenProDataSource2 ID="_OrderDS" runat="server" MaxNumberOfItemsToReturn="1" DataContainerType="EntityCollection" AdapterTypeName="SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.Examples.AuditingDBSpecific" EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.OrderEntityFactory, SD.LLBLGen.Pro.Examples.Auditing" LivePersistence="False" OnPerformSelect="_OrderDS_PerformSelect" OnPerformWork="_OrderDS_PerformWork"/>
<asp:FormView ID="frmEditOrder" DataKeyNames="OrderId" runat="server" DefaultMode="insert" DataSourceID="_OrderDS" Cellpadding="0" OnItemCommand="frmEditOrder_ItemCommand" OnItemCreated="frmEditOrder_ItemCreated">
<InsertItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				OrderId:
			</td>
			<td class="content">
				Auto generated
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Customer:
			</td>
			<td class="content" style="width: 345px">
                <llblgenpro:LLBLGenProDataSource2 ID="_Customer_CustomerIdDS" runat="server" AdapterTypeName="SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.Examples.AuditingDBSpecific"
                    DataContainerType="EntityCollection" EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.CustomerEntityFactory, SD.LLBLGen.Pro.Examples.Auditing">
                </llblgenpro:LLBLGenProDataSource2>
				<asp:DropDownList ID="cbxCustomer" runat="server" AppendDataBoundItems="true" SelectedValue='<%# Bind("CustomerId") %>' DataSourceID="_Customer_CustomerIdDS" DataValueField="CustomerId" DataTextField="CompanyName" AutoPostBack="False">                    

				</asp:DropDownList>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Employee:
			</td>
			<td class="content" style="width: 345px">
                <llblgenpro:LLBLGenProDataSource2 ID="_Employee_EmployeeIdDS" runat="server" AdapterTypeName="SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.Examples.AuditingDBSpecific"
                    DataContainerType="EntityCollection" EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.EmployeeEntityFactory, SD.LLBLGen.Pro.Examples.Auditing">
                </llblgenpro:LLBLGenProDataSource2>
				<asp:DropDownList ID="cbxEmployee" runat="server" AppendDataBoundItems="true" SelectedValue='<%# Bind("EmployeeId") %>' DataSourceID="_Employee_EmployeeIdDS" DataValueField="EmployeeId" DataTextField="FullName" AutoPostBack="False">

				</asp:DropDownList>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				OrderDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxOrderDate" runat="server" Required="False" Value='<%# Bind("OrderDate") %>' ValidationGroup="InsertValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				RequiredDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxRequiredDate" runat="server" Required="False" Value='<%# Bind("RequiredDate") %>' ValidationGroup="InsertValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ShippedDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxShippedDate" runat="server" Required="False" Value='<%# Bind("ShippedDate") %>' ValidationGroup="InsertValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ShipVia:
			</td>
			<td class="content" style="width: 345px">
                <llblgenpro:LLBLGenProDataSource2 ID="_Shipper_ShipViaDS" runat="server" AdapterTypeName="SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.Examples.AuditingDBSpecific"
                    DataContainerType="EntityCollection" EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.ShipperEntityFactory, SD.LLBLGen.Pro.Examples.Auditing">
                </llblgenpro:LLBLGenProDataSource2>
				<asp:DropDownList ID="cbxShipper" runat="server" AppendDataBoundItems="true" SelectedValue='<%# Bind("ShipVia") %>' DataSourceID="_Shipper_ShipViaDS" DataValueField="ShipperId" DataTextField="CompanyName" AutoPostBack="False">

				</asp:DropDownList>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Freight:
			</td>
			<td class="content">
				<asp:textbox id="tbxFreight" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("Freight") %>' /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ShipName:
			</td>
			<td class="content">
				<asp:textbox id="tbxShipName" runat="server" maxlength="40" size="40" Text='<%# Bind("ShipName") %>' ValidationGroup="InsertValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				ShipAddress:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="2" id="tbxShipAddress" runat="server" maxlength="60" Text='<%# Bind("ShipAddress") %>' ValidationGroup="InsertValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ShipCity:
			</td>
			<td class="content">
				<asp:textbox id="tbxShipCity" runat="server" maxlength="15" size="15" Text='<%# Bind("ShipCity") %>' ValidationGroup="InsertValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ShipRegion:
			</td>
			<td class="content">
				<asp:textbox id="tbxShipRegion" runat="server" maxlength="15" size="15" Text='<%# Bind("ShipRegion") %>' ValidationGroup="InsertValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ShipPostalCode:
			</td>
			<td class="content">
				<asp:textbox id="tbxShipPostalCode" runat="server" maxlength="10" size="10" Text='<%# Bind("ShipPostalCode") %>' ValidationGroup="InsertValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ShipCountry:
			</td>
			<td class="content">
				<asp:textbox id="tbxShipCountry" runat="server" maxlength="15" size="15" Text='<%# Bind("ShipCountry") %>' ValidationGroup="InsertValidations" /> 
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
				Customer:
			</td>
			<td class="content" style="width: 345px">
                <llblgenpro:LLBLGenProDataSource2 ID="_Customer_CustomerIdDS" runat="server" AdapterTypeName="SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.Examples.AuditingDBSpecific"
                    DataContainerType="EntityCollection" EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.CustomerEntityFactory, SD.LLBLGen.Pro.Examples.Auditing">
                </llblgenpro:LLBLGenProDataSource2>
				<asp:DropDownList ID="cbxCustomer" runat="server" AppendDataBoundItems="true" SelectedValue='<%# Bind("CustomerId") %>' DataSourceID="_Customer_CustomerIdDS" DataValueField="CustomerId" DataTextField="CompanyName" AutoPostBack="False">                    

				</asp:DropDownList>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Employee:
			</td>
			<td class="content" style="width: 345px">
                <llblgenpro:LLBLGenProDataSource2 ID="_Employee_EmployeeIdDS" runat="server" AdapterTypeName="SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.Examples.AuditingDBSpecific"
                    DataContainerType="EntityCollection" EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.EmployeeEntityFactory, SD.LLBLGen.Pro.Examples.Auditing">
                </llblgenpro:LLBLGenProDataSource2>
				<asp:DropDownList ID="cbxEmployee" runat="server" AppendDataBoundItems="true" SelectedValue='<%# Bind("EmployeeId") %>' DataSourceID="_Employee_EmployeeIdDS" DataValueField="EmployeeId" DataTextField="FullName" AutoPostBack="False">

				</asp:DropDownList>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				OrderDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxOrderDate" runat="server" Required="False" Value='<%# Bind("OrderDate") %>' ValidationGroup="EditValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				RequiredDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxRequiredDate" runat="server" Required="False" Value='<%# Bind("RequiredDate") %>' ValidationGroup="EditValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ShippedDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxShippedDate" runat="server" Required="False" Value='<%# Bind("ShippedDate") %>' ValidationGroup="EditValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ShipVia:
			</td>
            <td class="content" style="width: 345px">
                <llblgenpro:LLBLGenProDataSource2 ID="_Shipper_ShipViaDS" runat="server" AdapterTypeName="SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.Examples.AuditingDBSpecific"
                    DataContainerType="EntityCollection" EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.ShipperEntityFactory, SD.LLBLGen.Pro.Examples.Auditing">
                </llblgenpro:LLBLGenProDataSource2>
				<asp:DropDownList ID="cbxShipper" runat="server" AppendDataBoundItems="true" SelectedValue='<%# Bind("ShipVia") %>' DataSourceID="_Shipper_ShipViaDS" DataValueField="ShipperId" DataTextField="CompanyName" AutoPostBack="False">

				</asp:DropDownList>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Freight:
			</td>
			<td class="content">
				<asp:textbox id="tbxFreight" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("Freight") %>' /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ShipName:
			</td>
			<td class="content">
				<asp:textbox id="tbxShipName" runat="server" maxlength="40" size="40" Text='<%# Bind("ShipName") %>' ValidationGroup="EditValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				ShipAddress:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="2" id="tbxShipAddress" runat="server" maxlength="60" Text='<%# Bind("ShipAddress") %>' ValidationGroup="EditValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ShipCity:
			</td>
			<td class="content">
				<asp:textbox id="tbxShipCity" runat="server" maxlength="15" size="15" Text='<%# Bind("ShipCity") %>' ValidationGroup="EditValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ShipRegion:
			</td>
			<td class="content">
				<asp:textbox id="tbxShipRegion" runat="server" maxlength="15" size="15" Text='<%# Bind("ShipRegion") %>' ValidationGroup="EditValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ShipPostalCode:
			</td>
			<td class="content">
				<asp:textbox id="tbxShipPostalCode" runat="server" maxlength="10" size="10" Text='<%# Bind("ShipPostalCode") %>' ValidationGroup="EditValidations" /> 
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ShipCountry:
			</td>
			<td class="content">
				<asp:textbox id="tbxShipCountry" runat="server" maxlength="15" size="15" Text='<%# Bind("ShipCountry") %>' ValidationGroup="EditValidations" /> 
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
				Customer:
			</td>
			<td class="content" width="100%">
				<asp:HyperLink ID="lnkCustomerId" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.CustomerEntity).ToString() + "&CustomerId=" + Eval("CustomerId")%>' Text='<%# Eval("Customers.CompanyName") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Employee:
			</td>
			<td class="content" width="100%">
				<asp:HyperLink ID="lnkEmployeeId" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.EmployeeEntity).ToString() + "&EmployeeId=" + Eval("EmployeeId")%>' Text='<%# Eval("Employees.FullName") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				OrderDate:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblOrderDate" runat="server" Text='<%# Bind("OrderDate", "{0:dd-MMM-yyyy HH:mm.ss}") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				RequiredDate:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblRequiredDate" runat="server" Text='<%# Bind("RequiredDate", "{0:dd-MMM-yyyy HH:mm.ss}") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ShippedDate:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblShippedDate" runat="server" Text='<%# Bind("ShippedDate", "{0:dd-MMM-yyyy HH:mm.ss}") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ShipVia:
			</td>
			<td class="content" width="100%">
				<asp:HyperLink ID="lnkShipVia" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.ShipperEntity).ToString() + "&ShipperId=" + Eval("ShipVia")%>' Text='<%# Eval("Shippers.CompanyName") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Freight:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblFreight" runat="server" Text='<%# Bind("Freight") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ShipName:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblShipName" runat="server" Text='<%# Bind("ShipName") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ShipAddress:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblShipAddress" runat="server" Text='<%# Bind("ShipAddress") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ShipCity:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblShipCity" runat="server" Text='<%# Bind("ShipCity") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ShipRegion:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblShipRegion" runat="server" Text='<%# Bind("ShipRegion") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ShipPostalCode:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblShipPostalCode" runat="server" Text='<%# Bind("ShipPostalCode") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ShipCountry:
			</td>
			<td class="content" width="100%">
				<asp:Label ID="lblShipCountry" runat="server" Text='<%# Bind("ShipCountry") %>'/>
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br>
				<hr align="left" size="1" />
				<asp:Button ID="btnEdit" runat="server" CausesValidation="True" CommandName="EditExisting" Text="Edit" SkinId="ButtonSkin"/>
				<asp:Button ID="btnDelete" runat="server" CausesValidation="True" CommandName="DeleteExisting" Text="Delete and Home" SkinId="ButtonSkin" visible="false" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this Order instance with PK values: "  + "OrderId: " + Eval("OrderId") + " ?\");" %>'/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</ItemTemplate>
</asp:FormView>