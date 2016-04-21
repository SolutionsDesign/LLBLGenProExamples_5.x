
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_ViewRelatedToUser" Codebehind="ViewRelatedToUser.ascx.cs" %>

<%@ Register TagPrefix="dbeditor" TagName="AuditInfoInstances" Src="ListAuditInfoInstances.ascx"%>
	<tr>
		<td class="headers">
			Related AuditInfo instances (field mapped: AuditInfo)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:AuditInfoInstances ID="laAuditInfo" runat="server" ShowHomeButton="false" />
			<br><br>
		</td>
	</tr>
	