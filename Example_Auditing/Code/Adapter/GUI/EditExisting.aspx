<%@ Page Language="C#" AutoEventWireup="true" Inherits="EditExisting"  MasterPageFile="~/Main.master" Title="Edit existing " ValidateRequest="false" Codebehind="EditExisting.aspx.cs" %>
<asp:Content ContentPlaceHolderID="phMainContent" runat="server">
<table width="100%" cellpadding="5" cellspacing="0" border="0">
	<tr>
		<td class="darkbackground">
			<h1>LLBLGen Pro v5.x Auditing Example</h1>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Edit existing <asp:Label ID="lblEntityName" runat="server"/> entity
		</td>
	</tr>
	<tr>
		<td class="content">
			<asp:PlaceHolder ID="phSearchArea" runat="server" Visible="false">
				<br><br>
				Please choose one of the following ways to find the entity/entities:
				<br><br>
				<asp:PlaceHolder ID="phSearchControls" runat="server"/>
				<br><br>
			</asp:PlaceHolder>
			<asp:PlaceHolder ID="phEditArea" runat="server" Visible="false">
				<br><br>
				<b>Please note:</b> Required fields have a different background color and are marked with a <b>*</b>!
				<br><br>
				<asp:PlaceHolder ID="phEditControls" runat="server"/>
				<br><br>
			</asp:PlaceHolder>
		</td>
	</tr>
</table>
</asp:Content>