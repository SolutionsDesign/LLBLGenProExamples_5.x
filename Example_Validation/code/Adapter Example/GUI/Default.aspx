<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AdapterWebApp._Default" 
Title="Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
    <br />
    <br />
    This is a series of samples intended to demonstrate the <em>Validation </em>mechanism
    of the LLBLGen Pro v4 framework. There are 4 examples, each one has its own features.<br />
</div>
    <div>
    <ul>
        <li><a href="Customers.aspx" title="Customers example">Customers example</a> has the
            following characteristics:</li><ul>
                <li>Using <em>CustomerValidator</em> class</li><li>Validator initialized via <em>OnInitialized() </em>method override (see partial
                    class)</li><li><em>System.Web.UI.IValidator</em> objects are used.</li><li>Entity field validation using Regular Expressions.</li></ul>
    </ul>
</div>
    <div>
        <ul>
            <li><a href="Products.aspx" title="Products example">Products example</a> has the following
                characteristics:</li><ul>
                <li>Implementing validation INSIDE &nbsp;<em>ProductEntity </em> class (see partial class).</li><li><em>System.Web.UI.IValidator</em> objects are NOT used. The errors are shown
                    trapping the entity/entityFields errors.</li><li>Entity field validation using Regular Expressions.</li></ul>
        </ul>
        <p>
        </p>
        <ul>
            <li><a href="Orders.aspx" title="Orders example">Orders example</a> has the following
                characteristics:<ul>
                    <li>Using <em>OrderValidator</em> class (see SD.LLBLGen.Pro.Examples.Validators project).</li>
                    <li>Validator initialized via <em>Dependency Injection </em>mechanism (see web.config).</li>
                    <li><em>System.Web.UI.IValidator</em> objects are used.</li>
                    <li>Entity field validation using Regular Expressions.</li>
                </ul>
                <p>
                </p>
            </li>
            <li><a href="Employees.aspx" title="Employees example">Employees example</a> has the
                following characteristics:</li><ul>
                <li>Using <em>ValidateEntity()</em> method for validation performing (see partial class).</li>
                <li>Method is called at <em>PerformWork </em>event handler (<em>LLBLGenProDataSource2</em>).</li>
                <li><em>System.Web.UI.IValidator</em> objects are NOT used. The errors are shown trapping
                    the entity/entityFields errors.</li>
                <li>Entity field validation using Regular Expressions.</li>
            </ul>
        </ul>
    <br />    The examples should only be used for demo purposes. The code of this example should not be used directly in production without further testing.<br />
        <br />
        To obtain more information and/or help, please read LLBLGen Pro documentation and
        visit <a href="http://www.llblgen.com/tinyforum">LLBLGen Pro support forums</a>.<br />     
</div>
</asp:Content>
