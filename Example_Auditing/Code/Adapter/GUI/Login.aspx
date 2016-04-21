<%@ Page Language="C#" AutoEventWireup="true" Inherits="_Login" MasterPageFile="~/Main.master" Title="Auditing Example - Login" Codebehind="Login.aspx.cs" %>
<asp:Content ContentPlaceHolderID="phMainContent" runat="server">
	<table width="100%" cellpadding="5" cellspacing="0" border="0">
	<tr>
		<td class="darkbackground" colspan="2">
			<h1>LLBLGen Pro v5.x Auditing Example - Login</h1>
		</td>
	</tr>
        <tr>
            <td class="headers" colspan="2">
            </td>
        </tr>
	<tr>
        <td class="content" style="text-align: center">
            <br />
            <table>
                <tr>
                    <td class="content" style="width: 165px; height: 16px; text-align: right">
                        User
                    </td>
                    <td class="content" style="width: 314px; height: 16px">
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="content" style="width: 165px; text-align: right">
                        Password</td>
                    <td class="content" style="width: 314px">
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="content" style="width: 165px">
                    </td>
                    <td class="content" style="width: 314px">
			            <asp:Button ID="btnLogIn" runat="server" Text="Log In" SkinID="ButtonSkin" OnClick="btnAdd_Click"/>
                        <asp:Label ID="lblLoginValidate" runat="server" ForeColor="Red" Text="Incorrect login information"
                            Visible="False">
                    </asp:Label></td>
                </tr>
            </table>
            <br />
            <table>
                <tr>
                    <td class="smallheaders">                        
                        <strong> user:</strong> jbaker</td>
                    <td class="smallheaders">                        
                        <strong>pwd:</strong> jbaker</td>
                </tr>
                <tr>
                    <td class="smallheaders">                        
                        <strong> user:</strong> efisher
                    </td>
                    <td class="smallheaders">                        
                        <strong>pwd:</strong> efisher</td>
                </tr>
                <tr>
                    <td class="smallheaders">                        
                        <strong> user:</strong> lcowboy
                    </td>
                    <td class="smallheaders">                        
                        <strong>pwd:</strong> lcowboy
                    </td>
                </tr>
            </table>
            <br />
            <br />
        </td>
	</tr>
	<tr>
		<td class="darkbackground" colspan="2" >
		</td>
	</tr>
	</table>
</asp:Content>