<%@ Page Language="C#" AutoEventWireup="true" Inherits="AddNew" MasterPageFile="~/Main.master" Title="Add new " ValidateRequest="false" Codebehind="AddNew.aspx.cs" %>
<asp:Content ContentPlaceHolderID="phMainContent" runat="server">
<table width="100%" cellpadding="5" cellspacing="0" border="0">
	<tr>
		<td class="darkbackground">
			<h1>LLBLGenPro v5.x Auditing Example</h1>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Add new <asp:Label ID="lblEntityName" runat="server"/> entity
		</td>
	</tr>
	<tr>
		<td class="content">
			<br><br>
			<strong>Please note:</strong> Required fields have a different background color and are marked with a <b>*</b>!
			<br><br>
			<asp:PlaceHolder ID="phControls" runat="server"/>
			<br><br>
		</td>
	</tr>
</table>
</asp:Content>