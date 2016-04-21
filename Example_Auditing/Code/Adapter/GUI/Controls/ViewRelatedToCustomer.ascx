
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_ViewRelatedToCustomer" Codebehind="ViewRelatedToCustomer.ascx.cs" %>

<%@ Register TagPrefix="dbeditor" TagName="CustomerCustomerDemoInstances" Src="ListCustomerCustomerDemoInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="OrderInstances" Src="ListOrderInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="CustomerDemographyInstances" Src="ListCustomerDemographyInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="EmployeeInstances" Src="ListEmployeeInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="ShipperInstances" Src="ListShipperInstances.ascx"%>
	<tr>
		<td class="headers">
			Related CustomerCustomerDemo instances (field mapped: CustomerCustomerDemo)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:CustomerCustomerDemoInstances ID="laCustomerCustomerDemo" runat="server" ShowHomeButton="false" />
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
			Related CustomerDemography instances (field mapped: CustomerDemographicsCollectionViaCustomerCustomerDemo)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:CustomerDemographyInstances ID="laCustomerDemographicsCollectionViaCustomerCustomerDemo" runat="server" ShowHomeButton="false"  ShowAddNewButton="false" />
			<br><br>
		</td>
	</tr>

