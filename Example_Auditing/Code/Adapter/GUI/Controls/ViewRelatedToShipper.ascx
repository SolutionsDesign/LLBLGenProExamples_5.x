
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_ViewRelatedToShipper" Codebehind="ViewRelatedToShipper.ascx.cs" %>

<%@ Register TagPrefix="dbeditor" TagName="OrderInstances" Src="ListOrderInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="CustomerInstances" Src="ListCustomerInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="EmployeeInstances" Src="ListEmployeeInstances.ascx"%>
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
			Related Employee instances (field mapped: EmployeesCollectionViaOrders)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:EmployeeInstances ID="laEmployeesCollectionViaOrders" runat="server" ShowHomeButton="false"  ShowAddNewButton="false" />
			<br><br>
		</td>
	</tr>
	