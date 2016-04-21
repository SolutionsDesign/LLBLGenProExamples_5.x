
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_ViewRelatedToEmployee" Codebehind="ViewRelatedToEmployee.ascx.cs" %>

<%@ Register TagPrefix="dbeditor" TagName="EmployeeInstances" Src="ListEmployeeInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="EmployeeTerritoryInstances" Src="ListEmployeeTerritoryInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="OrderInstances" Src="ListOrderInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="TerritoryInstances" Src="ListTerritoryInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="CustomerInstances" Src="ListCustomerInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="ShipperInstances" Src="ListShipperInstances.ascx"%>
	<tr>
		<td class="headers">
			Related Employee instances (field mapped: Employees_)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:EmployeeInstances ID="laEmployees_" runat="server" ShowHomeButton="false" />
			<br><br>
		</td>
	</tr>

	<tr>
		<td class="headers">
			Related EmployeeTerritory instances (field mapped: EmployeeTerritories)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:EmployeeTerritoryInstances ID="laEmployeeTerritories" runat="server" ShowHomeButton="false" />
			<br><br>
		</td>
	</tr>

	<tr>
		<td class="headers">
			Related Order instances (field mapped: Orders)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:OrderInstances ID="laOrders" runat="server" ShowHomeButton="false" />
			<br><br>
		</td>
	</tr>

	<tr>
		<td class="headers">
			Related Territory instances (field mapped: TerritoriesCollectionViaEmployeeTerritories)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:TerritoryInstances ID="laTerritoriesCollectionViaEmployeeTerritories" runat="server" ShowHomeButton="false"  ShowAddNewButton="false" />
			<br><br>
		</td>
	</tr>

	<tr>
		<td class="headers">
			Related Customer instances (field mapped: CustomersCollectionViaOrders)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:CustomerInstances ID="laCustomersCollectionViaOrders" runat="server" ShowHomeButton="false"  ShowAddNewButton="false" />
			<br><br>
		</td>
	</tr>

	<tr>
		<td class="headers">
			Related Shipper instances (field mapped: ShippersCollectionViaOrders)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:ShipperInstances ID="laShippersCollectionViaOrders" runat="server" ShowHomeButton="false"  ShowAddNewButton="false" />
			<br><br>
		</td>
	</tr>
	