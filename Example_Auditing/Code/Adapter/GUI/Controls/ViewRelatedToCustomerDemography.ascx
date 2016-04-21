
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_ViewRelatedToCustomerDemography" Codebehind="ViewRelatedToCustomerDemography.ascx.cs" %>

<%@ Register TagPrefix="dbeditor" TagName="CustomerCustomerDemoInstances" Src="ListCustomerCustomerDemoInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="CustomerInstances" Src="ListCustomerInstances.ascx"%>
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
			Related Customer instances (field mapped: CustomersCollectionViaCustomerCustomerDemo)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:CustomerInstances ID="laCustomersCollectionViaCustomerCustomerDemo" runat="server" ShowHomeButton="false"  ShowAddNewButton="false" />
			<br><br>
		</td>
	</tr>
	