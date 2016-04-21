<%@ Page Language="C#" AutoEventWireup="true" Inherits="ListAll" MasterPageFile="~/Main.master" Title="List All " Codebehind="ListAll.aspx.cs" %>
<asp:Content ContentPlaceHolderID="phMainContent" runat="server">
<table width="100%" cellpadding="5" cellspacing="0" border="0">
	<tr>
		<td class="darkbackground">
			<h1>LLBLGen Pro v5.x Auditing Example</h1>
		</td>
	</tr>
	<tr>
		<td class="headers">
			All <asp:Label ID="lblEntityName" runat="server"/> instances
		</td>
	</tr>
	<tr>
		<td class="content">
			<asp:PlaceHolder ID="phControls" runat="server"/>
		</td>
	</tr>
</table>
</asp:Content>
