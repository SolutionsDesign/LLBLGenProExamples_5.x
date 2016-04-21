<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" Codebehind="Products.aspx.cs"
    Inherits="AdapterWebApp.Products" Title="Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>
            Products</h1>
        <llblgenpro:llblgenprodatasource2 ID="ProductsDS" runat="server" 
            AdapterTypeName="SD.LLBLGen.Pro.Examples.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.ExamplesDBSpecific" 
            DataContainerType="EntityCollection" 
            EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.FactoryClasses.ProductEntityFactory, SD.LLBLGen.Pro.Examples"            
            LivePersistence="False" OnPerformGetDbCount="ProductsDS_PerformGetDbCount" OnPerformSelect="ProductsDS_PerformSelect"
            OnPerformWork="ProductsDS_PerformWork" EnablePaging="True" AllowDuplicates="False" OnEntityUpdating="ProductsDS_EntityUpdating">
        </llblgenpro:llblgenprodatasource2>
        <llblgenpro:llblgenprodatasource2 ID="CategoriesDS" runat="server" 
            AdapterTypeName="SD.LLBLGen.Pro.Examples.DatabaseSpecific.DataAccessAdapter, SD.LLBLGen.Pro.ExamplesDBSpecific" 
            DataContainerType="EntityCollection" 
            EntityFactoryTypeName="SD.LLBLGen.Pro.Examples.FactoryClasses.CategoryEntityFactory, SD.LLBLGen.Pro.Examples">
        </llblgenpro:llblgenprodatasource2>
                <asp:Label ID="Message" runat="server" />
        <asp:BulletedList ID="blProductEntityErrors" runat="server" ForeColor="Red" Visible="False">
        </asp:BulletedList>
                <br />
                <asp:GridView runat="server" ID="ProductsGridView" DataKeyNames="ProductId" DataSourceID="ProductsDS" AllowPaging="True" AllowSorting="True" OnRowUpdated="ProductsGridView_RowUpdated" OnRowCancelingEdit="ProductsGridView_RowCancelingEdit">
                    <Columns>
                        <asp:CommandField ShowEditButton="True" />
                        <asp:BoundField DataField="ProductName" HeaderText="Name" SortExpression="ProductName" />
                        <asp:TemplateField HeaderText="Category" SortExpression="CategoryId">
                            <ItemTemplate>
                                <asp:Label ID="Category" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Category.CategoryName")%>' />
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:DropDownList ID="Categories" runat="server" DataSourceID="CategoriesDS" DataTextField="CategoryName"
                                    DataValueField="CategoryId" SelectedValue='<%# Bind("CategoryId") %>' />
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="QuantityPerUnit" HeaderText="Quantity Per Unit" SortExpression="QuantityPerUnit" />
                        <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" SortExpression="UnitPrice" />
                        <asp:CheckBoxField DataField="Discontinued" HeaderText="Discontinued" SortExpression="Discontinued" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="delete" CommandName="Delete" runat="server" OnClientClick="return confirm('Are you sure you want to delete this record?');">Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EmptyDataTemplate>
                        There are no Products in the database.
                    </EmptyDataTemplate>
                </asp:GridView>
        <br />
        <strong>General info</strong><br />
        <br />
        This page demonstrates how to work with validaton and LLBLGen Pro v3, this page
        works with <em>ProductEntity </em>instances<br />
        - This page uses a <em>GridView </em>as CRUD control.
        <br />
        - Entity-side (field and entity) validation is implemented by <strong>validation routines
            inside ProductEntity class</strong> (look into its partial class).
        <br />
        - No <em>System.Web.UI.IValidator </em>controls are used. When <em>LLBLGenProDataSource2
        </em>performs the work, validation routines reports the errors (if applicable) and are shown
        to the user in a <em>BulletedList</em>.<br />
        <br />
        <br />
        <strong>Things validated</strong><br />
        <br />
        - UnitPrice &gt;=0<br />
        - UnitsInStock &gt;= 0<br />
        - User can't update an existing discontinued product. First (s)he must save the
        product as Active and then modifications are allowed.<br />
        <br />
        (feel free to add your own validation rules and test the behavior)</div>
</asp:Content>
