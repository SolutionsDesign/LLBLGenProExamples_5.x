
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_ViewRelatedToOrder" Codebehind="ViewRelatedToOrder.ascx.cs" %>

<%@ Register TagPrefix="dbeditor" TagName="OrderDetailInstances" Src="ListOrderDetailInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="OrderAuditInfoInstances" Src="ListOrderAuditInfoInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="ProductInstances" Src="ListProductInstances.ascx"%>
	<tr>
		<td class="headers">
			Related OrderDetail instances (field mapped: OrderDetails)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:OrderDetailInstances ID="laOrderDetails" runat="server" ShowHomeButton="false" />
			<br><br>
		</td>
	</tr>

	<tr>
		<td class="headers">
			Related OrderAuditInfo instances (field mapped: OrderAuditInfo)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:OrderAuditInfoInstances ID="laOrderAuditInfo" runat="server" ShowHomeButton="false" />
			<br><br>
		</td>
	</tr>
	