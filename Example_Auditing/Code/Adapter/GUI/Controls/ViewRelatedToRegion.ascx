
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_ViewRelatedToRegion" Codebehind="ViewRelatedToRegion.ascx.cs" %>

<%@ Register TagPrefix="dbeditor" TagName="TerritoryInstances" Src="ListTerritoryInstances.ascx"%>
	<tr>
		<td class="headers">
			Related Territory instances (field mapped: Territories)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:TerritoryInstances ID="laTerritories" runat="server" ShowHomeButton="false" />
			<br><br>
		</td>
	</tr>
	