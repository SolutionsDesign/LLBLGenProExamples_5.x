<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" Codebehind="Customers.aspx.cs"
    Inherits="AdapterWebApp.Customers" Title="Customers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div>
        <h1>
            Customers</h1>
        <llblgenpro:llblgenprodatasource2 ID="CustomersDS" runat="server" 
            AdapterTypeName="SD.LLBLGen.Pro.Examples.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.ExamplesDBSpecific" 
            DataContainerType="EntityCollection" 
            EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.FactoryClasses.CustomerEntityFactory, SD.LLBLGen.Pro.Examples"            
            OnEntityDeleted="CustomersDS_EntityDeleted" OnEntityUpdated="CustomersDS_EntityUpdated" EnablePaging="True" AllowDuplicates="False" LivePersistence="False" OnPerformGetDbCount="CustomersDS_PerformGetDbCount" OnPerformSelect="CustomersDS_PerformSelect" OnPerformWork="CustomersDS_PerformWork">
        </llblgenpro:llblgenprodatasource2>
                <asp:Label ID="Message" runat="server" />
                <asp:ValidationSummary ID="CustomerValidationSummary" runat="server" ValidationGroup="CustomerValidationGroup" />
                <asp:ValidationSummary ID="CustomorInsertValidationSummary" runat="server" ValidationGroup="CustomerInsertValidationGroup" />
        <asp:BulletedList ID="blCustomerEntityErrors" runat="server" ForeColor="Red" Visible="False">
        </asp:BulletedList>
                <br />
                <asp:GridView runat="server" ID="CustomersGridView" DataKeyNames="CustomerId" DataSourceID="CustomersDS" AllowPaging="True" AllowSorting="True" ShowFooter="True" OnRowCommand="CustomersGridView_RowCommand" OnRowUpdating="CustomersGridView_RowUpdating">
                    <Columns>
                        <asp:CommandField ShowEditButton="True"  ValidationGroup="CustomerValidationGroup"/>
                        <asp:TemplateField HeaderText="Customer Id" SortExpression="CustomerId">
                            <FooterTemplate>
                                <asp:TextBox ID="InsertCustomerId" runat="server" Width="53px" />                                
                                <asp:RequiredFieldValidator ID="InsertCustomerIdRequiredFieldValidator" runat="server" ControlToValidate="InsertCustomerId"
                                    Display="None" ErrorMessage="You must enter a customer Id." ValidationGroup="CustomerInsertValidationGroup" 
                                    ToolTip="You must enter a customer Id." Text="*"/>
                            </FooterTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="EditCustomerId" runat="server" Text='<%# Bind("CustomerId") %>' Width="53px"></asp:TextBox>                                
                                <asp:RequiredFieldValidator ID="EditCustomerIdRequiredFieldValidator" runat="server" ControlToValidate="EditCustomerId"
                                    Display="None" ErrorMessage="You must enter a customer Id." ValidationGroup="CustomerValidationGroup" 
                                    ToolTip="You must enter a customer Id." Text="*"/>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="CustomerId" runat="server" Text='<%# Bind("CustomerId")%>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                        <asp:TemplateField HeaderText="Company" SortExpression="CompanyName">
                            <FooterTemplate>
                                <asp:TextBox ID="InsertCompanyName" runat="server" Width="127px" />                                
                                <asp:RequiredFieldValidator ID="InsertCompanyNameRequiredFieldValidator" runat="server" ControlToValidate="InsertCompanyName"
                                    Display="None" ErrorMessage="You must enter a company name." ValidationGroup="CustomerInsertValidationGroup" 
                                    ToolTip="You must enter a company name." Text="*" Font-Size="Smaller"/>
                                <asp:RegularExpressionValidator ID="InsertCompanyNameRegularExpressionValidator" runat="server" ControlToValidate="InsertCompanyName"
                                    Display="None" ErrorMessage="Company name is in incorrect format." ValidationExpression="^[a-zA-Záéíóú'\.\s]{2,255}$"
                                    ValidationGroup="CustomerInsertValidationGroup" Font-Size="Smaller"></asp:RegularExpressionValidator>                                
                            </FooterTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="EditCompanyName" runat="server" Text='<%# Bind("CompanyName") %>' Width="127px"></asp:TextBox>                                
                                <asp:RequiredFieldValidator ID="EditCompanyNameRequiredFieldValidator" runat="server" ControlToValidate="EditCompanyName"
                                    Display="None" ErrorMessage="You must enter a company name." ValidationGroup="CustomerValidationGroup" 
                                    ToolTip="You must enter a company name." Text="*"/>
                                <asp:RegularExpressionValidator ID="EditCompanyNameRegularExpressionValidator" runat="server" ControlToValidate="EditCompanyName"
                                    Display="None" ErrorMessage="Company name is in incorrect format." ValidationExpression="^[a-zA-Záéíóú'\.\s]{2,255}$"
                                    ValidationGroup="CustomerValidationGroup" Font-Size="Smaller"></asp:RegularExpressionValidator>                                
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="CompanyName" runat="server" Text='<%# Bind("CompanyName")%>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                                                
                        <asp:TemplateField HeaderText="Contact" SortExpression="ContactName">
                            <FooterTemplate>
                                <asp:TextBox ID="InsertContactName" runat="server" Width="119px" />
                                <asp:RegularExpressionValidator ID="InsertContactNameRegularExpressionValidator" runat="server" ControlToValidate="InsertContactName"
                                    Display="None" ErrorMessage="Contact name is in incorrect format." ValidationExpression="^[a-zA-Záéíóú'\.\s]{2,255}$"
                                    ValidationGroup="CustomerInsertValidationGroup" Font-Size="Smaller"></asp:RegularExpressionValidator>                                
                            </FooterTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="EditContactName" runat="server" Text='<%# Bind("ContactName") %>' Width="119px"></asp:TextBox>                                
                                <asp:RegularExpressionValidator ID="EditContactNameRegularExpressionValidator" runat="server" ControlToValidate="EditContactName"
                                    Display="None" ErrorMessage="Contact name is in incorrect format." ValidationExpression="^[a-zA-Záéíóú'\.\s]{2,255}$"
                                    ValidationGroup="CustomerValidationGroup" Font-Size="Smaller"></asp:RegularExpressionValidator>                                                                                                    
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="ContactName" runat="server" Text='<%# Bind("ContactName")%>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                        <asp:TemplateField HeaderText="Contact Title" SortExpression="ContactTitle">
                            <FooterTemplate>
                                <asp:TextBox ID="InsertContactTitle" runat="server" Width="107px" />
                                <asp:RegularExpressionValidator ID="InsertContactTitleRegularExpressionValidator" runat="server" ControlToValidate="InsertContactTitle"
                                    Display="None" ErrorMessage="Contact title is in incorrect format." ValidationExpression="^[a-zA-Záéíóú'\.\s]{2,255}$"
                                    ValidationGroup="CustomerInsertValidationGroup" Font-Size="Smaller"></asp:RegularExpressionValidator>                                
                            </FooterTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="EditContactTitle" runat="server" Text='<%# Bind("ContactTitle") %>' Width="107px"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="EditContactTitleRegularExpressionValidator" runat="server" ControlToValidate="EditContactTitle"
                                    Display="None" ErrorMessage="Contact title is in incorrect format." ValidationExpression="^[a-zA-Záéíóú'\.\s]{2,255}$"
                                    ValidationGroup="CustomerValidationGroup" Font-Size="Smaller"></asp:RegularExpressionValidator>                                                                                                    
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="ContactTitle" runat="server" Text='<%# Bind("ContactTitle")%>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                        <asp:TemplateField HeaderText="City" SortExpression="City">
                            <FooterTemplate>
                                <asp:TextBox ID="InsertCity" runat="server" Width="69px" />
                                <asp:RegularExpressionValidator ID="InsertCityRegularExpressionValidator" runat="server" ControlToValidate="InsertCity"
                                    Display="None" ErrorMessage="City is in incorrect format." ValidationExpression="^[a-zA-Záéíóú'\.\s]{2,255}$"
                                    ValidationGroup="CustomerInsertValidationGroup" Font-Size="Smaller"></asp:RegularExpressionValidator>                                
                            </FooterTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="EditCity" runat="server" Text='<%# Bind("City") %>' Width="69px"></asp:TextBox>                                
                                <asp:RegularExpressionValidator ID="EditCityRegularExpressionValidator" runat="server" ControlToValidate="EditCity"
                                    Display="None" ErrorMessage="City is in incorrect format." ValidationExpression="^[a-zA-Záéíóú'\.\s]{2,255}$"
                                    ValidationGroup="CustomerValidationGroup" Font-Size="Smaller"></asp:RegularExpressionValidator>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="City" runat="server" Text='<%# Bind("City")%>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                                                        
                        <asp:TemplateField HeaderText="PostalCode" SortExpression="PostalCode">
                            <FooterTemplate>
                                <asp:TextBox ID="InsertPostalCode" runat="server" Width="76px" />
                                <asp:RegularExpressionValidator ID="InsertPostalCodeRegularExpressionValidator" runat="server" ControlToValidate="InsertPostalCode"
                                    Display="None" ErrorMessage="Postal code is in incorrect format." ValidationExpression="^(\d{5}-\d{4}|\d{5}|\d{9})$"
                                    ValidationGroup="CustomerInsertValidationGroup" Font-Size="Smaller"></asp:RegularExpressionValidator>                                
                            </FooterTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="EditPostalCode" runat="server" Text='<%# Bind("PostalCode") %>' Width="76px"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="EditPostalCodeRegularExpressionValidator" runat="server" ControlToValidate="EditPostalCode"
                                    Display="None" ErrorMessage="PostalCode is in incorrect format." ValidationExpression="^(\d{5}-\d{4}|\d{5}|\d{9})$"
                                    ValidationGroup="CustomerValidationGroup" Font-Size="Smaller"></asp:RegularExpressionValidator>                                                                                                    
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="PostalCode" runat="server" Text='<%# Bind("PostalCode")%>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                        <asp:TemplateField HeaderText="Country" SortExpression="Country">
                            <FooterTemplate>
                                <asp:TextBox ID="InsertCountry" runat="server" Width="77px" />
                                <asp:RegularExpressionValidator ID="InsertCountryRegularExpressionValidator" runat="server" ControlToValidate="InsertCountry"
                                    Display="None" ErrorMessage="Country is in incorrect format." ValidationExpression="^[a-zA-Záéíóú'\.\s]{2,255}$"
                                    ValidationGroup="CustomerInsertValidationGroup" Font-Size="Smaller"></asp:RegularExpressionValidator>                                
                            </FooterTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="EditCountry" runat="server" Text='<%# Bind("Country") %>' Width="77px"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="EditCountryRegularExpressionValidator" runat="server" ControlToValidate="EditCountry"
                                    Display="None" ErrorMessage="Country is in incorrect format." ValidationExpression="^[a-zA-Záéíóú'\.\s]{2,255}$"
                                    ValidationGroup="CustomerValidationGroup" Font-Size="Smaller"></asp:RegularExpressionValidator>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Country" runat="server" Text='<%# Bind("Country")%>' />
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Phone" SortExpression="Phone">
                            <FooterTemplate>
                                <asp:TextBox ID="InsertPhone" runat="server" Width="87px" />                                
                            </FooterTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="EditPhone" runat="server" Text='<%# Bind("Phone") %>' Width="87px"></asp:TextBox>                                
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Phone" runat="server" Text='<%# Bind("Phone")%>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                                                                                                                                                                           
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="delete" CommandName="Delete" runat="server" OnClientClick="return confirm('Are you sure you want to delete this record?');">Delete</asp:LinkButton>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:LinkButton ID="FooterAdd" CommandName="AddFromFooter" runat="server" Text="Add"
                                    ValidationGroup="CustomerInsertValidationGroup" />
                            </FooterTemplate>
                        </asp:TemplateField>                       
                        
                    </Columns>

                    <EmptyDataTemplate>
                        There are no customers in the database.
                    </EmptyDataTemplate>
                </asp:GridView>
        <strong>General info<br />
        </strong>
        <br />
        This page demonstrates how to work with validaton and LLBLGen Pro v3, this page
        works with CustomerEntity instances.
        <br />
        <br />
        - This page uses a GridView as CRUD control.<br />
        - Entity-side (field and entity) validation is implemented by CustomerValidator
        class. For more information please see the code comments in that class.<br />
        - GUI-side-fields validation is implemented by System.Web.UI.IValidator objects,<br />
        - GUI-side-entity validation is implemented by showing to the user (in a BulletedList)
        the errors returned from the validator.&nbsp;<br />
        <br />
        <br />
        <strong>Rules that CustomerValidator is checking</strong><br />
        <br />
        - All fields must match a suitable format, provided by regular expressions. The
        regular expressions are implemented in both the ValidateFieldValue method of CudsomerValidator
        and in the System.Web.UI.IValidator objects as well. For more information, please check
        the CustomerValidator.cs and RegexHelper.cs files<br />
        <br />
        - You can't delete a customer which has orders. You will see a elegant
        message instead of a ugly exception page.<br />
        - Note: ValidateFieldValue will reject an invalid US-Phone Number. However a UI:IValidator
        isn't added to that control because there isn't an easy way to include all valid
        world phone number formats in a single regular expression.&nbsp; If you want to
        trap that field error (US-PhoneNumbers in incorrect format) please see how this
        is implemented in Employee example.<br />
        <br />
        (feel free to add your own validations and test the behavior)<br />

    </div>
</asp:Content>
