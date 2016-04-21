
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_ViewRelatedToTerritory" Codebehind="ViewRelatedToTerritory.ascx.cs" %>

<%@ Register TagPrefix="dbeditor" TagName="EmployeeTerritoryInstances" Src="ListEmployeeTerritoryInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="EmployeeInstances" Src="ListEmployeeInstances.ascx"%>
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
			Related Employee instances (field mapped: EmployeesCollectionViaEmployeeTerritories)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:EmployeeInstances ID="laEmployeesCollectionViaEmployeeTerritories" runat="server" ShowHomeButton="false"  ShowAddNewButton="false" />
			<br><br>
		</td>
	</tr>
	