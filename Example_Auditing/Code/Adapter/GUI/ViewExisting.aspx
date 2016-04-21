<%@ Page Language="C#" AutoEventWireup="true" Inherits="ViewExisting"  MasterPageFile="~/Main.master" Title="View existing " Codebehind="ViewExisting.aspx.cs" %>
<asp:Content ContentPlaceHolderID="phMainContent" runat="server">
<table width="100%" cellpadding="5" cellspacing="0" border="0">
	<tr>
		<td class="darkbackground">
			<h1>LLBLGen Pro v5.x Auditing Example</h1>
		</td>
	</tr>
	<tr>
		<td class="headers">
			View existing <asp:Label ID="lblEntityName" runat="server"/> entity
		</td>
	</tr>
	<tr>
		<td class="content">
			<br><br>
			<asp:PlaceHolder ID="phControls" runat="server"/>
			<br><br>
		</td>
	</tr>
	<asp:PlaceHolder ID="phRelatedEntities" runat="server"/>
</table>
</asp:Content> 