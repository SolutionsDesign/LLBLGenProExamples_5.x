<%@ Page Language="C#" AutoEventWireup="true" Inherits="ListSubSet"  MasterPageFile="~/Main.master" Title="List Sub-set of " ValidateRequest="false" Codebehind="ListSubSet.aspx.cs" %>
<asp:Content ContentPlaceHolderID="phMainContent" runat="server">
<table width="100%" cellpadding="5" cellspacing="0" border="0">
	<tr>
		<td class="darkbackground">
			<h1>LLBLGen Pro v5.x Auditing Example</h1>
		</td>
	</tr>
	<tr>
		<td class="headers">
			List sub-set of <asp:Label ID="lblEntityName" runat="server"/> instances
		</td>
	</tr>
	<tr>
		<td class="content">
			<asp:PlaceHolder ID="phSearchArea" runat="server" Visible="false">
				<asp:PlaceHolder ID="phSearchControls" runat="server"/>
				<br><br>
			</asp:PlaceHolder>
		
			<asp:PlaceHolder ID="phListArea" runat="server" Visible="false">
				<br><br>
				<asp:PlaceHolder ID="phListControls" runat="server"/>
				<br><br>
			</asp:PlaceHolder>
		</td>
	</tr>
</table>
</asp:Content>