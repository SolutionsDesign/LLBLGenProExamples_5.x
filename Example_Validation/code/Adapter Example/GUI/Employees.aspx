<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" Codebehind="Employees.aspx.cs"
    Inherits="AdapterWebApp.Employees" Title="Employees" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>
            Employees</h1>
        <llblgenpro:llblgenprodatasource2 ID="EmployeesListDS" runat="server" 
            AdapterTypeName="SD.LLBLGen.Pro.Examples.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.ExamplesDBSpecific" 
            DataContainerType="EntityCollection"
            EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.FactoryClasses.EmployeeEntityFactory, SD.LLBLGen.Pro.Examples"            
            AllowDuplicates="False" EnablePaging="True" EnableViewState="False" LivePersistence="False"
            OnPerformGetDbCount="EmployeesListDS_PerformGetDbCount" OnPerformSelect="EmployeesListDS_PerformSelect"
            OnPerformWork="EmployeesListDS_PerformWork">
        </llblgenpro:llblgenprodatasource2>
        <llblgenpro:llblgenprodatasource2 ID="EmployeeDetailsDS" runat="server" 
            AdapterTypeName="SD.LLBLGen.Pro.Examples.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.ExamplesDBSpecific" 
            DataContainerType="EntityCollection"
            EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.FactoryClasses.EmployeeEntityFactory, SD.LLBLGen.Pro.Examples"            
            AllowDuplicates="False" LivePersistence="False" OnPerformGetDbCount="EmployeeDetailsDS_PerformGetDbCount"
            OnPerformSelect="EmployeeDetailsDS_PerformSelect" OnPerformWork="EmployeeDetailsDS_PerformWork">
            <SelectParameters>
                <asp:ControlParameter ControlID="EmployeesGridView" Name="EmployeeId" PropertyName="SelectedValue"
                    Type="String" />
            </SelectParameters>
        </llblgenpro:llblgenprodatasource2>
                <br />
                <table width="100%">
                    <tr>
                        <td><b>Employees List</b></td>
                        <td><b>Employee Details</b></td>
                    </tr>
                    <tr>
                        <td style="width: 40%; vertical-align: top;">
                            <asp:GridView ID="EmployeesGridView" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                DataKeyNames="EmployeeId" DataSourceID="EmployeesListDS" OnSelectedIndexChanged="EmployeesGridView_SelectedIndexChanged"
                                PageSize="20" OnDataBound="EmployeesGridView_DataBound">
                                <SelectedRowStyle BackColor="#666666" ForeColor="#FF6600" Width="100%" />
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="Select" CommandName="Select" runat="server">>></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="EmployeeId" HeaderText="ID" InsertVisible="False" ReadOnly="True"
                                        SortExpression="EmployeeId" />
                                    <asp:BoundField DataField="LastName" HeaderText="Last Name" SortExpression="LastName" />
                                    <asp:BoundField DataField="FirstName" HeaderText="First Name" SortExpression="FirstName" />
                                    <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                                </Columns>
                            </asp:GridView>
                        </td>
                        <td style="width: 60%; vertical-align: top;">
                            &nbsp;<asp:BulletedList ID="blEmployeeEntityErrors" runat="server" ForeColor="Red" Visible="False">
                            </asp:BulletedList>
                            <br />
                            <asp:FormView ID="EmployeeFormView" runat="server" DataKeyNames="EmployeeId" DataSourceID="EmployeeDetailsDS"
                                OnItemDeleted="EmployeeFormView_ItemDeleted" OnItemInserted="EmployeeFormView_ItemInserted"
                                OnItemUpdated="EmployeeFormView_ItemUpdated" OnModeChanging="EmployeeFormView_ModeChanging">
                                <EditItemTemplate>
                                    <table>
                                        <tr>
                                            <td class="coloredLabel">
                                                ID:</td>
                                            <td>
                                                <asp:Label ID="EmployeeIdLabel1" runat="server" Text='<%# Eval("EmployeeId") %>' /></td>
                                            <td class="coloredLabel">
                                                Prefix:</td>
                                            <td>
                                                <asp:TextBox ID="TitleOfCourtesyTextBox" runat="server" Text='<%# Bind("TitleOfCourtesy") %>' /></td>
                                        </tr>
                                        <tr>
                                            <td class="mandatoryLabel">
                                                Last Name:</td>
                                            <td>
                                                <asp:TextBox ID="LastNameTextBox" runat="server" Text='<%# Bind("LastName") %>' />
                                                </td>
                                            <td class="mandatoryLabel">
                                                First Name:</td>
                                            <td>
                                                <asp:TextBox ID="FirstNameTextBox" runat="server" Text='<%# Bind("FirstName") %>' />
                                                </td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Birth Date:</td>
                                            <td>
                                                <asp:TextBox ID="BirthDateTextBox" runat="server" Text='<%# Bind("BirthDate", "{0:d}") %>' />
                                                </td>
                                            <td class="coloredLabel">
                                                Photo:</td>
                                            <td>
                                                <asp:FileUpload Width="200px"  ID="FileUpload1" runat="server" /></td>                                        
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Title:</td>
                                            <td colspan="2">
                                                <asp:TextBox ID="TitleTextBox" runat="server" Text='<%# Bind("Title") %>' Width="100%" /></td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Reports To:</td>
                                            <td>
                                                <asp:DropDownList ID="Managers" runat="server" DataSourceID="ManagersDS" DataTextField="LastName"
                                                    DataValueField="EmployeeId" SelectedValue='<%# Bind("ReportsTo") %>' AppendDataBoundItems="true">
                                                    <asp:ListItem Value="" Text=""></asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Hire Date:</td>
                                            <td>
                                                <asp:TextBox ID="HireDateTextBox" runat="server" Text='<%# Bind("HireDate", "{0:d}") %>' />
                                                </td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Country:</td>
                                            <td>
                                                <asp:TextBox ID="CountryTextBox" runat="server" Text='<%# Bind("Country") %>' /></td>
                                            <td class="coloredLabel">
                                                Region:</td>
                                            <td>
                                                <asp:TextBox ID="RegionTextBox" runat="server" Text='<%# Bind("Region") %>' /></td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                City:</td>
                                            <td>
                                                <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' /></td>
                                            <td class="coloredLabel">
                                                Postal Code:</td>
                                            <td>
                                                <asp:TextBox ID="PostalCodeTextBox" runat="server" Text='<%# Bind("PostalCode") %>' /></td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Address:</td>
                                            <td colspan="2">
                                                <asp:TextBox ID="AddressTextBox" runat="server" Text='<%# Bind("Address") %>' Width="100%" /></td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Home Phone:</td>
                                            <td>
                                                <asp:TextBox ID="HomePhoneTextBox" runat="server" Text='<%# Bind("HomePhone") %>' /></td>
                                            <td class="coloredLabel">
                                                Extension:</td>
                                            <td>
                                                <asp:TextBox ID="ExtensionTextBox" runat="server" Text='<%# Bind("Extension") %>' /></td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Notes:</td>
                                            <td colspan="3">
                                                <asp:TextBox ID="NotesTextBox" Rows="5" TextMode="MultiLine" runat="server" Text='<%# Bind("Notes") %>'
                                                    Width="95%" />
                                            </td>
                                        </tr>
                                    </table>
                                    <table>
                                        <tr>
                                            <td valign="top">
                                                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update"
                                                    Text="Update" ValidationGroup="EditEmployeeValidation">
                                                </asp:LinkButton>
                                                <asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel"
                                                    Text="Cancel">
                                                </asp:LinkButton>&nbsp;
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </EditItemTemplate>
                                <InsertItemTemplate>
                                    <table>
                                        <tr>
                                            <td class="coloredLabel">
                                                Prefix:</td>
                                            <td>
                                                <asp:TextBox ID="TitleOfCourtesyTextBox" runat="server" Text='<%# Bind("TitleOfCourtesy") %>' /></td>
                                        </tr>
                                        <tr>
                                            <td class="mandatoryLabel">
                                                Last Name:</td>
                                            <td>
                                                <asp:TextBox ID="LastNameTextBox" runat="server" Text='<%# Bind("LastName") %>' />
                                                </td>
                                            <td class="mandatoryLabel">
                                                First Name:</td>
                                            <td>
                                                <asp:TextBox ID="FirstNameTextBox" runat="server" Text='<%# Bind("FirstName") %>' />
                                                </td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Birth Date:</td>
                                            <td>
                                                <asp:TextBox ID="BirthDateTextBox" runat="server" Text='<%# Bind("BirthDate", "{0:d}") %>' />
                                                </td>                                        
                                            <td class="coloredLabel">
                                                Photo:</td>
                                            <td>
                                                <asp:FileUpload Width="200px"  ID="FileUpload1" runat="server" /></td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Title:</td>
                                            <td colspan="2">
                                                <asp:TextBox ID="TitleTextBox" runat="server" Text='<%# Bind("Title") %>' Width="100%" /></td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Reports To:</td>
                                            <td>
                                                <asp:DropDownList ID="Managers" runat="server" DataSourceID="ManagersDS" DataTextField="LastName"
                                                    DataValueField="EmployeeId" SelectedValue='<%# Bind("ReportsTo") %>' AppendDataBoundItems="true">
                                                    <asp:ListItem Value="" Text=""></asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Hire Date:</td>
                                            <td>
                                                <asp:TextBox ID="HireDateTextBox" runat="server" Text='<%# Bind("HireDate", "{0:d}") %>' />
                                                </td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Country:</td>
                                            <td>
                                                <asp:TextBox ID="CountryTextBox" runat="server" Text='<%# Bind("Country") %>' /></td>
                                            <td class="coloredLabel">
                                                Region:</td>
                                            <td>
                                                <asp:TextBox ID="RegionTextBox" runat="server" Text='<%# Bind("Region") %>' /></td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                City:</td>
                                            <td>
                                                <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' /></td>
                                            <td class="coloredLabel">
                                                Postal Code:</td>
                                            <td>
                                                <asp:TextBox ID="PostalCodeTextBox" runat="server" Text='<%# Bind("PostalCode") %>' /></td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Address:</td>
                                            <td colspan="2">
                                                <asp:TextBox ID="AddressTextBox" runat="server" Text='<%# Bind("Address") %>' Width="100%" /></td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Home Phone:</td>
                                            <td>
                                                <asp:TextBox ID="HomePhoneTextBox" runat="server" Text='<%# Bind("HomePhone") %>' /></td>
                                            <td class="coloredLabel">
                                                Extension:</td>
                                            <td>
                                                <asp:TextBox ID="ExtensionTextBox" runat="server" Text='<%# Bind("Extension") %>' /></td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Notes:</td>
                                            <td colspan="3">
                                                <asp:TextBox ID="NotesTextBox" Rows="5" TextMode="MultiLine" runat="server" Text='<%# Bind("Notes") %>'
                                                    Width="95%" />
                                            </td>
                                        </tr>
                                    </table>
                                    <table>
                                        <tr>
                                            <td valign="top">
                                                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert"
                                                    Text="Insert" ValidationGroup="InsertEmployeeValidation">
                                                </asp:LinkButton>
                                                <asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel"
                                                    Text="Cancel">
                                                </asp:LinkButton>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </InsertItemTemplate>
                                <ItemTemplate>
                                    <table>
                                        <tr>
                                            <td class="coloredLabel">
                                                ID:</td>
                                            <td>
                                                <asp:Label ID="EmployeeIdLabel" runat="server" Text='<%# Eval("EmployeeId") %>' /></td>
                                            <td class="coloredLabel">
                                                Prefix:</td>
                                            <td>
                                                <asp:Label ID="TitleOfCourtesyLabel" runat="server" Text='<%# Eval("TitleOfCourtesy") %>' /></td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Last Name:</td>
                                            <td>
                                                <asp:Label ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>' /></td>
                                            <td class="coloredLabel">
                                                First Name:</td>
                                            <td>
                                                <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Eval("FirstName") %>' /></td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Birth Date:</td>
                                            <td>
                                                <asp:Label ID="BirthDateLabel" runat="server" Text='<%# Eval("BirthDate", "{0:d}") %>' /></td>
                                            <td colspan="2" rowspan="4">
                                                <asp:Image GenerateEmptyAlternateText="true" Height="110px" Width="180px"  ID="Label1" runat="server" ImageUrl='<%#"~/Image.aspx?EmployeeId=" + Eval("EmployeeId") %>' /></td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Title:</td>
                                            <td>
                                                <asp:Label ID="TitleLabel" runat="server" Text='<%# Eval("Title") %>' Width="100%" /></td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Reports To:</td>
                                            <td>
                                                <asp:Label ID="ReportsToLabel" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "EmployeeSuperior.LastName") %>' /></td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Hire Date:</td>
                                            <td>
                                                <asp:Label ID="HireDateLabel" runat="server" Text='<%# Eval("HireDate", "{0:d}") %>' /></td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Country:</td>
                                            <td>
                                                <asp:Label ID="CountryLabel" runat="server" Text='<%# Eval("Country") %>' /></td>
                                            <td class="coloredLabel">
                                                Region:</td>
                                            <td>
                                                <asp:Label ID="RegionLabel" runat="server" Text='<%# Eval("Region") %>' /></td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                City:</td>
                                            <td>
                                                <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' /></td>
                                            <td class="coloredLabel">
                                                Postal Code:</td>
                                            <td>
                                                <asp:Label ID="PostalCodeLabel" runat="server" Text='<%# Eval("PostalCode") %>' /></td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Address:</td>
                                            <td>
                                                <asp:Label ID="AddressLabel" runat="server" Text='<%# Eval("Address") %>' /></td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Home Phone:</td>
                                            <td width="210px;">
                                                <asp:Label ID="HomePhoneLabel" runat="server" Text='<%# Eval("HomePhone") %>' /></td>
                                            <td class="coloredLabel">
                                                Extension:</td>
                                            <td width="210px;">
                                                <asp:Label ID="ExtensionLabel" runat="server" Text='<%# Eval("Extension") %>' /></td>
                                        </tr>
                                        <tr>
                                            <td class="coloredLabel">
                                                Notes:</td>
                                            <td colspan="3">
                                                <asp:Label ID="NotesLabel" runat="server" Text='<%# Eval("Notes") %>' Width="100%" />
                                            </td>
                                        </tr>
                                    </table>
                                    <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit"
                                        Text="Edit">
                                    </asp:LinkButton>
                                    <asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete"
                                        Text="Delete" OnClientClick="return confirm('Are you sure you want to delete this employee?');">
                                    </asp:LinkButton>
                                    <asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New"
                                        Text="New">
                                    </asp:LinkButton>
                                </ItemTemplate>
                                <EmptyDataTemplate>
                                    <br />
                                    Currently, there are no Employees in the system,
                                    <br />
                                    click on
                                    <asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New"
                                        Text="New" />
                                    to start adding Employees.
                                </EmptyDataTemplate>
                            </asp:FormView>
                        </td>
                    </tr>
                </table>
        <llblgenpro:llblgenprodatasource2 ID="ManagersDS" runat="server" 
            AdapterTypeName="SD.LLBLGen.Pro.Examples.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.ExamplesDBSpecific" 
            DataContainerType="EntityCollection"
            EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.FactoryClasses.EmployeeEntityFactory, SD.LLBLGen.Pro.Examples"            
            AllowDuplicates="False" EnableViewState="False">
        </llblgenpro:llblgenprodatasource2>
        <strong>Example info<br />
            <br />
        </strong>- This page demonstrates how to work with validaton and LLBLGen Pro v3,
        this page works with EmployeeEntity instances.
        <br />
        - This page uses a <em>GridView</em> as searcher and a <em>FormView</em> as CRUD
        control.
        <br />
        - Entity-side (field and entity) validation is implemented by <strong>EmployeeEntity.ValidateEntity()</strong>
        method. For more information please see the comments in the validator class
        <br />
        - No <em>System.Web.UI.IValidator</em> controls are used. When <em>LLBLGenProDataSource2</em>
        performs the work, <em>ValidateEntity</em> will report the errors (if applicable) and are shown
        to the user in a <em>BulletedList</em>.<br />
        <br />
        <br />
        <strong>The ValidateEntity() medhod validates the following<br />
        </strong>
        <br />
        - HomePhone format and PostalCode format (US-Employees only). This is powered by regular expressions. For more
        info, please check the EmployeeEntity partial class.<br />
        - BirthDate &lt; Today<br />
        - HireDate &gt; BirthDate<br />
        <br />
        (feel free to add your own validation rules and test the behavior)<br />
    </div>
</asp:Content>
