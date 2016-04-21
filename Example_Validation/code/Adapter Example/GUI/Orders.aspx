<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" Codebehind="Orders.aspx.cs"
    Inherits="AdapterWebApp.Orders" Title="Orders" MaintainScrollPositionOnPostback="true"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>
            Orders Details</h1>
        <llblgenpro:llblgenprodatasource2 ID="OrdersDS" runat="server" 
            AdapterTypeName="SD.LLBLGen.Pro.Examples.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.ExamplesDBSpecific" 
            DataContainerType="EntityCollection"
            EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.FactoryClasses.OrderEntityFactory, SD.LLBLGen.Pro.Examples"            
            EnablePaging="True" OnEntityDeleted="OrdersDS_EntityDeleted" OnEntityDeleting="OrdersDS_EntityDeleting" 
            OnEntityInserted="OrdersDS_EntityInserted" OnEntityUpdated="OrdersDS_EntityUpdated" OnElementsFetched="OrdersDS_ElementsFetched" OnPerformGetDbCount="OrdersDS_PerformGetDbCount" OnPerformSelect="OrdersDS_PerformSelect" OnPerformWork="OrdersDS_PerformWork" LivePersistence="False">
        </llblgenpro:llblgenprodatasource2>
        <llblgenpro:llblgenprodatasource2 ID="OrderDetailsDS" runat="server" 
            AdapterTypeName="SD.LLBLGen.Pro.Examples.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.ExamplesDBSpecific" 
            DataContainerType="EntityCollection"
            EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.FactoryClasses.OrderDetailEntityFactory, SD.LLBLGen.Pro.Examples"
            SortingMode="ClientSide" EnablePaging="True" OnElementsFetched="OrderDetailsDS_ElementsFetched">
            <SelectParameters>
                <asp:ControlParameter ControlID="OrdersFormView" Name="OrderId" PropertyName="SelectedValue"
                    Type="String" />
            </SelectParameters>
            <InsertParameters>
                <asp:ControlParameter ControlID="OrdersFormView" Name="OrderId" PropertyName="SelectedValue"
                    Type="String" />
            </InsertParameters>
        </llblgenpro:llblgenprodatasource2>
        <llblgenpro:llblgenprodatasource2 ID="ProductsDS" runat="server" 
            AdapterTypeName="SD.LLBLGen.Pro.Examples.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.ExamplesDBSpecific" 
            DataContainerType="EntityCollection"
            EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.FactoryClasses.ProductEntityFactory, SD.LLBLGen.Pro.Examples"
            EnableViewState="False">
        </llblgenpro:llblgenprodatasource2>
        <llblgenpro:llblgenprodatasource2 ID="CustomersDS" runat="server" 
            AdapterTypeName="SD.LLBLGen.Pro.Examples.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.ExamplesDBSpecific" 
            DataContainerType="EntityCollection"
            EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.FactoryClasses.CustomerEntityFactory, SD.LLBLGen.Pro.Examples"
            EnableViewState="False">
        </llblgenpro:llblgenprodatasource2>
        <llblgenpro:llblgenprodatasource2 ID="EmployeesDS" runat="server" 
            AdapterTypeName="SD.LLBLGen.Pro.Examples.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.ExamplesDBSpecific" 
            DataContainerType="EntityCollection"
            EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.FactoryClasses.EmployeeEntityFactory, SD.LLBLGen.Pro.Examples"
            EnableViewState="False">
        </llblgenpro:llblgenprodatasource2>
        <llblgenpro:llblgenprodatasource2 ID="ShippersDS" runat="server" 
            AdapterTypeName="SD.LLBLGen.Pro.Examples.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.ExamplesDBSpecific" 
            DataContainerType="EntityCollection"
            EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.FactoryClasses.ShipperEntityFactory, SD.LLBLGen.Pro.Examples"
            EnableViewState="False">
        </llblgenpro:llblgenprodatasource2>
                <asp:Label ID="OrderMessage" runat="server" />
                        <asp:ValidationSummary ID="OrderValidationSummary" runat="server" ValidationGroup="OrderValidation" />
                        <asp:BulletedList ID="blOrderErrors" runat="server" ForeColor="Red" Visible="False">
                        </asp:BulletedList>
                <br />
                <asp:FormView ID="OrdersFormView" runat="server" AllowPaging="True" DataKeyNames="OrderId"
                    DataSourceID="OrdersDS" OnModeChanged="OrdersFormView_ModeChanged" OnModeChanging="OrdersFormView_ModeChanging">
                    <EditItemTemplate>
                        <table>
                            <tr>
                                <td colspan="2"><b>Basic information:</b></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    ID:</td>
                                <td>
                                    <asp:Label ID="OrderIdLabel" runat="server" Text='<%# Eval("OrderId") %>'/></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    Customer:</td>
                                <td colspan="2">
                                    <asp:DropDownList ID="Customers" runat="server" DataSourceID="CustomersDS" DataTextField="CompanyName"
                                        DataValueField="CustomerId" SelectedValue='<%# Bind("CustomerId") %>' Width="100%"/></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    Employee:</td>
                                <td>
                                    <asp:DropDownList ID="Employees" runat="server" DataSourceID="EmployeesDS" DataTextField="LastName"
                                        DataValueField="EmployeeId" SelectedValue='<%# Bind("EmployeeId") %>' /></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    Order Date:</td>
                                <td>
                                    <asp:TextBox ID="OrderDateTextBox" runat="server" Text='<%# Bind("OrderDate", "{0:d}") %>'/>
                                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="OrderDateTextBox"
                                        Display="Static" ErrorMessage="Order Date should be entered as mm/dd/yyyy"
                                        ValidationGroup="OrderValidation" Type="Date" Operator="DataTypeCheck"
                                        Text="*" ToolTip="Dates should be entered as mm/dd/yyyy." CultureInvariantValues="true"/></td>
                                <td class="coloredLabel">
                                    Required Date:</td>
                                <td>
                                    <asp:TextBox ID="RequiredDateTextBox" runat="server" Text='<%# Bind("RequiredDate", "{0:d}") %>'/>
                                    <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="RequiredDateTextBox"
                                        Display="Static" ErrorMessage="Required Date should be entered as mm/dd/yyyy."
                                        ValidationGroup="OrderValidation" Type="Date" Operator="DataTypeCheck"
                                        Text="*" ToolTip="Dates should be entered as mm/dd/yyyy."/></td>
                            </tr>
                            <tr>
                                <td colspan="2"><b>Shipment details:</b></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    Shipped Via:</td>
                                <td>
                                    <asp:DropDownList ID="ShipViaDropDownList" runat="server" DataSourceID="ShippersDS" DataTextField="CompanyName"
                                        DataValueField="ShipperId" SelectedValue='<%# Bind("ShipVia") %>' /></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    Shipper Name:</td>
                                <td colspan="2">
                                    <asp:TextBox ID="ShipNameTextBox" runat="server" Text='<%# Bind("ShipName") %>' Width="100%"/></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    Freight:</td>
                                <td>
                                    <asp:TextBox ID="Freight" runat="server" Text='<%# Bind("Freight","{0:#,#.##}") %>'/>
                                    <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="Freight"
                                        Display="Static" ErrorMessage="You must enter a valid numeric value for the freight value."
                                        ValidationGroup="OrderValidation" Operator="GreaterThanEqual" Type="Currency" ValueToCompare="0"
                                        Text="*" ToolTip="You must enter a valid numeric value for the freight value." CultureInvariantValues="true"/></td>
                                <td class="coloredLabel">
                                    Shipment Date:</td>
                                <td>
                                    <asp:TextBox ID="ShippedDateTextBox" runat="server" Text='<%# Bind("ShippedDate", "{0:d}") %>'/>
                                    <asp:CompareValidator ID="CompareValidator4" runat="server" ControlToValidate="ShippedDateTextBox"
                                        Display="Static" ErrorMessage="Shipped Date should be entered as mm/dd/yyyy"
                                        ValidationGroup="OrderValidation" Type="Date" Operator="DataTypeCheck"
                                        Text="*" ToolTip="Dates should be entered in the following formatt mm/dd/yyyy"/></td>
                            </tr>
                            <tr>
                                <td colspan="2"><b>Destination details:</b></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    Country:</td>
                                <td>
                                    <asp:TextBox ID="ShipCountryTextBox" runat="server" Text='<%# Bind("ShipCountry") %>'/></td>
                                <td class="coloredLabel">
                                    Region:</td>
                                <td>
                                    <asp:TextBox ID="ShipRegionTextBox" runat="server" Text='<%# Bind("ShipRegion") %>'/></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    City:</td>
                                <td>
                                    <asp:TextBox ID="ShipCityTextBox" runat="server" Text='<%# Bind("ShipCity") %>'/></td>
                                <td class="coloredLabel">
                                    Postal Code:</td>
                                <td>
                                    <asp:TextBox ID="ShipPostalCodeTextBox" runat="server" Text='<%# Bind("ShipPostalCode") %>'/></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    Address:</td>
                                <td colspan="2">
                                    <asp:TextBox ID="ShipAddressTextBox" runat="server" Text='<%# Bind("ShipAddress") %>' Width="100%"/></td>
                            </tr>
                        </table>
                        <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update"
                            Text="Update" ValidationGroup="OrderValidation">
                        </asp:LinkButton>
                        <asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel"
                            Text="Cancel">
                        </asp:LinkButton>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <table>
                            <tr>
                                <td colspan="2"><b>Basic information:</b></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    Customer:</td>
                                <td colspan="2">
                                    <asp:DropDownList ID="Customers" runat="server" DataSourceID="CustomersDS" DataTextField="CompanyName"
                                        DataValueField="CustomerId" SelectedValue='<%# Bind("CustomerId") %>' Width="100%" /></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    Employee:</td>
                                <td>
                                    <asp:DropDownList ID="Employees" runat="server" DataSourceID="EmployeesDS" DataTextField="LastName"
                                        DataValueField="EmployeeId" SelectedValue='<%# Bind("EmployeeId") %>' /></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    Order Date:</td>
                                <td>
                                    <asp:TextBox ID="OrderDateTextBox" runat="server" Text='<%# Bind("OrderDate") %>'/>
                                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="OrderDateTextBox"
                                        Display="Static" ErrorMessage="Order Date should be entered as mm/dd/yyyy"
                                        ValidationGroup="OrderValidation" Type="Date" Operator="DataTypeCheck"
                                        Text="*" ToolTip="Dates should be entered as mm/dd/yyyy."/></td>
                                <td class="coloredLabel">
                                    Required Date:</td>
                                <td>
                                    <asp:TextBox ID="RequiredDateTextBox" runat="server" Text='<%# Bind("RequiredDate") %>'/>
                                    <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="RequiredDateTextBox"
                                        Display="Static" ErrorMessage="Required Date should be entered as mm/dd/yyyy."
                                        ValidationGroup="OrderValidation" Type="Date" Operator="DataTypeCheck"
                                        Text="*" ToolTip="Dates should be entered as mm/dd/yyyy."/></td>
                            </tr>
                            <tr>
                                <td colspan="2"><b>Shipment details:</b></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    Shipped Via:</td>
                                <td>
                                    <asp:DropDownList ID="ShipViaDropDownList" runat="server" DataSourceID="ShippersDS" DataTextField="CompanyName"
                                        DataValueField="ShipperId" SelectedValue='<%# Bind("ShipVia") %>' /></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    Ship Name:</td>
                                <td colspan="2">
                                    <asp:TextBox ID="ShipNameTextBox" runat="server" Text='<%# Bind("ShipName") %>' Width="100%"/></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    Freight:</td>
                                <td>
                                    <asp:TextBox ID="Freight" runat="server" Text='<%# Bind("Freight") %>'/>
                                    <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="Freight"
                                        Display="Static" ErrorMessage="You must enter a valid numeric value for the freight value."
                                        ValidationGroup="OrderValidation" Operator="GreaterThanEqual" Type="Currency" ValueToCompare="0"
                                        Text="*" ToolTip="You must enter a valid numeric value for the freight value."/></td>
                                <td class="coloredLabel">
                                    Shipment Date:</td>
                                <td>
                                    <asp:TextBox ID="ShippedDateTextBox" runat="server" Text='<%# Bind("ShippedDate") %>'/>
                                    <asp:CompareValidator ID="CompareValidator4" runat="server" ControlToValidate="ShippedDateTextBox"
                                        Display="Static" ErrorMessage="Shipped Date should be entered as mm/dd/yyyy"
                                        ValidationGroup="OrderValidation" Type="Date" Operator="DataTypeCheck"
                                        Text="*" ToolTip="Dates should be entered in the following formatt mm/dd/yyyy"/></td>
                            </tr>
                            <tr>
                                <td colspan="2"><b>Destination details:</b></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    Country:</td>
                                <td>
                                    <asp:TextBox ID="ShipCountryTextBox" runat="server" Text='<%# Bind("ShipCountry") %>'/></td>
                                <td class="coloredLabel">
                                    Region:</td>
                                <td>
                                    <asp:TextBox ID="ShipRegionTextBox" runat="server" Text='<%# Bind("ShipRegion") %>'/></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    City:</td>
                                <td>
                                    <asp:TextBox ID="ShipCityTextBox" runat="server" Text='<%# Bind("ShipCity") %>'/></td>
                                <td class="coloredLabel">
                                    Postal Code:</td>
                                <td>
                                    <asp:TextBox ID="ShipPostalCodeTextBox" runat="server" Text='<%# Bind("ShipPostalCode") %>'/></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    Address:</td>
                                <td colspan="2">
                                    <asp:TextBox ID="ShipAddressTextBox" runat="server" Text='<%# Bind("ShipAddress") %>' Width="100%" /></td>
                            </tr>
                        </table>
                        <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" ValidationGroup="OrderValidation" CommandName="Insert"
                            Text="Insert">
                        </asp:LinkButton>
                        <asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel"
                            Text="Cancel">
                        </asp:LinkButton>
                        
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <table>
                            <tr>
                                <td colspan="2"><b>Basic information:</b></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    ID:</td>
                                <td>
                                    <asp:Label ID="OrderIdLabel" runat="server" Text='<%# Eval("OrderId") %>' /></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    Customer:</td>
                                <td>
                                    <asp:Label ID="CustomerIdLabel" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Customer.CompanyName") %>' /></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    Employee:</td>
                                <td>
                                    <asp:Label ID="EmployeeIdLabel" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Employee.LastName") + ", " + DataBinder.Eval(Container.DataItem, "Employee.FirstName") %>' /></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    Order Date:</td>
                                <td>
                                    <asp:Label ID="OrderDateLabel" runat="server" Text='<%# Eval("OrderDate", "{0:d}") %>' /></td>
                                <td class="coloredLabel">
                                    Required Date:</td>
                                <td>
                                    <asp:Label ID="RequiredDateLabel" runat="server" Text='<%# Eval("RequiredDate", "{0:d}") %>' /></td>
                            </tr>
                            <tr>
                                <td colspan="2"><b>Shipment details:</b></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    Shipped Via:</td>
                                <td>
                                    <asp:Label ID="ShipViaLabel" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Shipper.CompanyName") %>' /></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    Shipper Name:</td>
                                <td>
                                    <asp:Label ID="ShipNameLabel" runat="server" Text='<%# Eval("ShipName") %>' /></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    Freight:</td>
                                <td>
                                    <asp:Label ID="Freight" runat="server" Text='<%# Eval("Freight", "{0:c}") %>' /></td>
                                <td class="coloredLabel">
                                    Shipment Date:</td>
                                <td>
                                    <asp:Label ID="ShippedDateLabel" runat="server" Text='<%# Eval("ShippedDate", "{0:d}") %>' /></td>
                            </tr>
                            <tr>
                                <td colspan="2"><b>Destination details:</b></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    Country:</td>
                                <td>
                                    <asp:Label ID="ShipCountryLabel" runat="server" Text='<%# Eval("ShipCountry") %>' /></td>
                                <td class="coloredLabel">
                                    Region:</td>
                                <td>
                                    <asp:Label ID="ShipRegionLabel" runat="server" Text='<%# Eval("ShipRegion") %>' /></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    City:</td>
                                <td>
                                    <asp:Label ID="ShipCityLabel" runat="server" Text='<%# Eval("ShipCity") %>' /></td>
                                <td class="coloredLabel">
                                    Postal Code:</td>
                                <td>
                                    <asp:Label ID="ShipPostalCodeLabel" runat="server" Text='<%# Eval("ShipPostalCode") %>' /></td>
                            </tr>
                            <tr>
                                <td class="coloredLabel">
                                    Address:</td>
                                <td>
                                    <asp:Label ID="ShipAddressLabel" runat="server" Text='<%# Eval("ShipAddress") %>' /></td>
                            </tr>
                        </table>
                        <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit"
                            Text="Edit">
                        </asp:LinkButton>
                        <asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete"
                            Text="Delete" OnClientClick="return confirm('This order and any related details will be deleted.\nDo you want to proceed?');">
                        </asp:LinkButton>
                        <asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New"
                            Text="New">
                        </asp:LinkButton>
                    </ItemTemplate>
                </asp:FormView>
        <br />
        <br />
                <asp:Label ID="OrderDetailMessage" runat="server" />                
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="FooterAdd" />
                <asp:ValidationSummary ID="ValidationSummary2" runat="server" ValidationGroup="EmptyAdd" />
                <asp:GridView ID="OrderDetailsGridView" runat="server" DataKeyNames="OrderId,ProductId"
                    DataSourceID="OrderDetailsDS" ShowFooter="True" OnRowCommand="OrderDetailsGridView_RowCommand">
                    <Columns>
                        <asp:CommandField ShowEditButton="True" />
                        <asp:TemplateField HeaderText="Product" SortExpression="ProductName">
                            <EditItemTemplate>
                                <asp:DropDownList ID="Products" runat="server" DataSourceID="ProductsDS" DataTextField="ProductName"
                                    DataValueField="ProductId" SelectedValue='<%# Bind("ProductId") %>' />
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Product" runat="server" Text='<%# Bind("ProductName")%>' />
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:DropDownList ID="FooterProducts" runat="server" DataSourceID="ProductsDS" DataTextField="ProductName"
                                    DataValueField="ProductId" />
                            </FooterTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Unit Price" SortExpression="UnitPrice">
                            <EditItemTemplate>
                                <asp:TextBox ID="EditUnitPrice" runat="server" Text='<%# Bind("UnitPrice", "{0:c}") %>'></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator5" runat="server" ControlToValidate="EditUnitPrice"
                                    Display="Dynamic" ErrorMessage="You must enter a valid numeric value for the unit price."
                                    ValidationGroup="FooterAdd" Operator="GreaterThanEqual" Type="Integer" ValueToCompare="0"
                                    Text="*" ToolTip="You must enter a valid numeric value for the unit price."/>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="EditUnitPrice"
                                    Display="Dynamic" ErrorMessage="You must enter a unit price." ValidationGroup="FooterAdd" 
                                    ToolTip="You must enter a unit price." Text="*"/>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("UnitPrice", "{0:c}") %>'></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="FooterUnitPrice" runat="server" />
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="FooterUnitPrice"
                                    Display="Dynamic" ErrorMessage="You must enter a valid numeric value for the unit price."
                                    ValidationGroup="FooterAdd" Operator="GreaterThanEqual" Type="Integer" ValueToCompare="0"
                                    Text="*" ToolTip="You must enter a valid numeric value for the unit price."/>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FooterUnitPrice"
                                    Display="Dynamic" ErrorMessage="You must enter a unit price." ValidationGroup="FooterAdd" 
                                    ToolTip="You must enter a unit price." Text="*"/>
                            </FooterTemplate>
                            <FooterStyle Wrap="False" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Quantity" SortExpression="Quantity">
                            <EditItemTemplate>
                                <asp:TextBox ID="EditQuantity" runat="server" Text='<%# Bind("Quantity") %>'></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator6" runat="server" ControlToValidate="EditQuantity"
                                    Display="Dynamic" ErrorMessage="You must enter a valid numeric value for the quantity."
                                    ValidationGroup="FooterAdd" Operator="GreaterThanEqual" Type="Integer" ValueToCompare="0"
                                    Text="*" ToolTip="You must enter a valid numeric value for the quantity."/>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="EditQuantity"
                                    Display="Dynamic" ErrorMessage="You must enter a quantity." ValidationGroup="FooterAdd" 
                                    ToolTip="You must enter a quantity." Text="*"/>                                    
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("Quantity") %>'></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="FooterQuantity" runat="server"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="FooterQuantity"
                                    Display="Dynamic" ErrorMessage="You must enter a valid numeric value for the quantity."
                                    ValidationGroup="FooterAdd" Operator="GreaterThanEqual" Type="Integer" ValueToCompare="0"
                                    Text="*" ToolTip="You must enter a valid numeric value for the quantity."/>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="FooterQuantity"
                                    Display="Dynamic" ErrorMessage="You must enter a quantity." ValidationGroup="FooterAdd" 
                                    ToolTip="You must enter a quantity." Text="*"/>                                    
                            </FooterTemplate>
                            <FooterStyle Wrap="False" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Discount" SortExpression="Discount">
                            <EditItemTemplate>
                                <asp:TextBox ID="EditDiscount" runat="server" Text='<%# Bind("Discount") %>'></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator7" runat="server" ControlToValidate="EditDiscount"
                                    Display="Dynamic" ErrorMessage="You must enter a discount percentage between 0 & 100."
                                    ValidationGroup="FooterAdd" Operator="GreaterThanEqual" Type="Double" ValueToCompare="0"
                                    Text="*" ToolTip="You must enter a discount percentage between 0 & 100."/>
                                <asp:CompareValidator ID="CompareValidator8" runat="server" ControlToValidate="EditDiscount"
                                    Display="Dynamic" ErrorMessage="You must enter a discount percentage between 0 & 100."
                                    ValidationGroup="FooterAdd" Operator="LessThanEqual" Type="Double" ValueToCompare="100"
                                    Text="*" ToolTip="You must enter a discount percentage between 0 & 100."/>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("Discount","{0:P2}") %>'></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="FooterDiscount" runat="server"></asp:TextBox>%
                                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="FooterDiscount"
                                 Display="Dynamic"  ErrorMessage="You must enter a discount percentage between 0 & 100." 
                                 ValidationGroup="FooterAdd" Type="Double" MinimumValue="0" MaximumValue="100"
                                 Text="*" ToolTip="You must enter a discount percentage between 0 & 100."                                 />
                            </FooterTemplate>
                            <FooterStyle Wrap="False" />
                        </asp:TemplateField>
                        <asp:BoundField HeaderText="Total" DataField="Total" SortExpression="Total" ReadOnly="True" DataFormatString="{0:C}" HtmlEncode="False">
                            <ItemStyle Width="100px" />
                        </asp:BoundField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="delete" CommandName="Delete" runat="server" OnClientClick="return confirm('Are you sure you want to delete this record?');">Delete</asp:LinkButton>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:LinkButton ID="FooterAdd" CommandName="AddFromFooter" runat="server" Text="Add"
                                    ValidationGroup="FooterAdd" />
                            </FooterTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EmptyDataTemplate>
                        <div>
                        <table width="100%">
                            <tr class="GridHeader">
                                <td>Product</td>
                                <td>Unit Price</td>
                                <td>Quantity</td>
                                <td>Discount</td>
                                <td></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DropDownList ID="EmptyProducts" runat="server" DataSourceID="ProductsDS" DataTextField="ProductName"
                                        DataValueField="ProductId" />
                                </td>
                                <td>
                                    <asp:TextBox ID="EmptyUnitPrice" runat="server" Text='<%# Bind("UnitPrice", "{0:c}") %>' />
                                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="EmptyUnitPrice"
                                        Display="Dynamic" ErrorMessage="You must enter a valid numeric value for the unit price."
                                        ValidationGroup="EmptyAdd" Operator="GreaterThanEqual" Type="Integer" ValueToCompare="0"
                                        Text="*" ToolTip="You must enter a valid numeric value for the unit price."/>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="EmptyUnitPrice"
                                        Display="Dynamic" ErrorMessage="You must enter a unit price." ValidationGroup="EmptyAdd" 
                                        ToolTip="You must enter a unit price." Text="*"/>                                    
                                </td>
                                <td>
                                    <asp:TextBox ID="EmptyQuantity" runat="server"></asp:TextBox>
                                    <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="EmptyQuantity"
                                        Display="Dynamic" ErrorMessage="You must enter a valid numeric value for the quantity."
                                        ValidationGroup="EmptyAdd" Operator="GreaterThanEqual" Type="Integer" ValueToCompare="0"
                                        Text="*" ToolTip="You must enter a valid numeric value for the quantity."/>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="EmptyQuantity"
                                        Display="Dynamic" ErrorMessage="You must enter a quantity." ValidationGroup="EmptyAdd" 
                                        ToolTip="You must enter a quantity." Text="*"/>                                    
                                </td>
                                <td>
                                    <asp:TextBox ID="EmptyDiscount" runat="server"></asp:TextBox>%
                                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="EmptyDiscount"
                                     Display="Dynamic"  ErrorMessage="You must enter a discount percentage between 0 & 100." 
                                     ValidationGroup="EmptyAdd" Type="Double" MinimumValue="0" MaximumValue="100"
                                     Text="*" ToolTip="You must enter a discount percentage between 0 & 100."/>
                                </td>
                                <td>
                                    <asp:LinkButton ID="EmptyAdd" CommandName="AddFromEmpty" runat="server" Text="Add"
                                        ValidationGroup="EmptyAdd" />
                                </td>
                            </tr>
                        </table>
                        </div>
                    </EmptyDataTemplate>
                </asp:GridView>
        <strong>General info<br />
        </strong>
        <br />
        This page demonstrates how to work with validaton and LLBLGen Pro v3, this page
        works with OrderEntity instances.
        <br />
        - This page uses a <em>FormView </em>as CRUD control.
        <br />
        - Entity-side (field and entity) validation is implemented by <em>OrderValidator</em>
        class (please see the <em>Validators project</em>). The validator is injected via <em>Dependency
            Injection (DI)</em>. For more information see the <em>web.config</em> file and
        the <em>LLBLGen Pro Manual</em>.&nbsp;<br />
        - GUI-side-fields validation is implemented by <em>System.Web.UI.IValidator</em>
        objects.
        <br />
        - GUI-side-entity validation is implemented by showing to the user (in a <em>BulltedList</em>)
        the errors returned from the validator.<br />
        <br />
        <br />
        <strong>OrderValidator checks the following</strong><br />
        <br />
        - OrderDate &gt; (Today - 1 month). You can't add orders which are too old.<br />
        - Freight &gt;= 0<br />
        - RequiredDate &gt;= OrderDate<br />
        - ShippedDate &gt;= OrderDate<br />
        <br />
        (feel free to add your own validation rules and test the behavior)<br />
                <div style="text-align:right;"><asp:Label ID="TotalAmount" runat="server" Font-Bold="true"/></div>
        
    </div>
</asp:Content>
