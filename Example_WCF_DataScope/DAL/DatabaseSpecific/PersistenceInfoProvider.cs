///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated on: vrijdag 20 juni 2014 13:28:26
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.WCF.DatabaseSpecific
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal static class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass(9);
			InitCategoryEntityMappings();
			InitCustomerEntityMappings();
			InitEmployeeEntityMappings();
			InitOrderEntityMappings();
			InitOrderDetailsEntityMappings();
			InitProductEntityMappings();
			InitInvoicesTypedViewMappings();
			InitProductsByCategoryTypedViewMappings();
			InitSalesByCategoryTypedViewMappings();
		}

		/// <summary>Inits CategoryEntity's mappings</summary>
		private void InitCategoryEntityMappings()
		{
			this.AddElementMapping("CategoryEntity", @"Northwind", @"dbo", "Categories", 4, 0);
			this.AddElementFieldMapping("CategoryEntity", "CategoryId", "CategoryID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("CategoryEntity", "CategoryName", "CategoryName", false, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("CategoryEntity", "Description", "Description", true, "NText", 1073741823, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("CategoryEntity", "Picture", "Picture", true, "Image", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 3);
		}

		/// <summary>Inits CustomerEntity's mappings</summary>
		private void InitCustomerEntityMappings()
		{
			this.AddElementMapping("CustomerEntity", @"Northwind", @"dbo", "Customers", 11, 0);
			this.AddElementFieldMapping("CustomerEntity", "Address", "Address", true, "NVarChar", 60, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("CustomerEntity", "City", "City", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("CustomerEntity", "CompanyName", "CompanyName", false, "NVarChar", 40, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("CustomerEntity", "ContactName", "ContactName", true, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("CustomerEntity", "ContactTitle", "ContactTitle", true, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("CustomerEntity", "Country", "Country", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("CustomerEntity", "CustomerId", "CustomerID", false, "NChar", 5, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("CustomerEntity", "Fax", "Fax", true, "NVarChar", 24, 0, 0, false, "", null, typeof(System.String), 7);
			this.AddElementFieldMapping("CustomerEntity", "Phone", "Phone", true, "NVarChar", 24, 0, 0, false, "", null, typeof(System.String), 8);
			this.AddElementFieldMapping("CustomerEntity", "PostalCode", "PostalCode", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 9);
			this.AddElementFieldMapping("CustomerEntity", "Region", "Region", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 10);
		}

		/// <summary>Inits EmployeeEntity's mappings</summary>
		private void InitEmployeeEntityMappings()
		{
			this.AddElementMapping("EmployeeEntity", @"Northwind", @"dbo", "Employees", 18, 0);
			this.AddElementFieldMapping("EmployeeEntity", "Address", "Address", true, "NVarChar", 60, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("EmployeeEntity", "BirthDate", "BirthDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("EmployeeEntity", "City", "City", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("EmployeeEntity", "Country", "Country", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("EmployeeEntity", "EmployeeId", "EmployeeID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("EmployeeEntity", "Extension", "Extension", true, "NVarChar", 4, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("EmployeeEntity", "FirstName", "FirstName", false, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("EmployeeEntity", "HireDate", "HireDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7);
			this.AddElementFieldMapping("EmployeeEntity", "HomePhone", "HomePhone", true, "NVarChar", 24, 0, 0, false, "", null, typeof(System.String), 8);
			this.AddElementFieldMapping("EmployeeEntity", "LastName", "LastName", false, "NVarChar", 20, 0, 0, false, "", null, typeof(System.String), 9);
			this.AddElementFieldMapping("EmployeeEntity", "Notes", "Notes", true, "NText", 1073741823, 0, 0, false, "", null, typeof(System.String), 10);
			this.AddElementFieldMapping("EmployeeEntity", "Photo", "Photo", true, "Image", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 11);
			this.AddElementFieldMapping("EmployeeEntity", "PhotoPath", "PhotoPath", true, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 12);
			this.AddElementFieldMapping("EmployeeEntity", "PostalCode", "PostalCode", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 13);
			this.AddElementFieldMapping("EmployeeEntity", "Region", "Region", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 14);
			this.AddElementFieldMapping("EmployeeEntity", "ReportsTo", "ReportsTo", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 15);
			this.AddElementFieldMapping("EmployeeEntity", "Title", "Title", true, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 16);
			this.AddElementFieldMapping("EmployeeEntity", "TitleOfCourtesy", "TitleOfCourtesy", true, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 17);
		}

		/// <summary>Inits OrderEntity's mappings</summary>
		private void InitOrderEntityMappings()
		{
			this.AddElementMapping("OrderEntity", @"Northwind", @"dbo", "Orders", 14, 0);
			this.AddElementFieldMapping("OrderEntity", "CustomerId", "CustomerID", false, "NChar", 5, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("OrderEntity", "EmployeeId", "EmployeeID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("OrderEntity", "Freight", "Freight", true, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 2);
			this.AddElementFieldMapping("OrderEntity", "OrderDate", "OrderDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("OrderEntity", "OrderId", "OrderID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("OrderEntity", "RequiredDate", "RequiredDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5);
			this.AddElementFieldMapping("OrderEntity", "ShipAddress", "ShipAddress", true, "NVarChar", 60, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("OrderEntity", "ShipCity", "ShipCity", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 7);
			this.AddElementFieldMapping("OrderEntity", "ShipCountry", "ShipCountry", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 8);
			this.AddElementFieldMapping("OrderEntity", "ShipName", "ShipName", true, "NVarChar", 40, 0, 0, false, "", null, typeof(System.String), 9);
			this.AddElementFieldMapping("OrderEntity", "ShippedDate", "ShippedDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 10);
			this.AddElementFieldMapping("OrderEntity", "ShipPostalCode", "ShipPostalCode", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 11);
			this.AddElementFieldMapping("OrderEntity", "ShipRegion", "ShipRegion", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 12);
			this.AddElementFieldMapping("OrderEntity", "ShipVia", "ShipVia", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 13);
		}

		/// <summary>Inits OrderDetailsEntity's mappings</summary>
		private void InitOrderDetailsEntityMappings()
		{
			this.AddElementMapping("OrderDetailsEntity", @"Northwind", @"dbo", "Order Details", 5, 0);
			this.AddElementFieldMapping("OrderDetailsEntity", "Discount", "Discount", false, "Real", 0, 24, 0, false, "", null, typeof(System.Single), 0);
			this.AddElementFieldMapping("OrderDetailsEntity", "OrderId", "OrderID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("OrderDetailsEntity", "ProductId", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("OrderDetailsEntity", "Quantity", "Quantity", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 3);
			this.AddElementFieldMapping("OrderDetailsEntity", "UnitPrice", "UnitPrice", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 4);
		}

		/// <summary>Inits ProductEntity's mappings</summary>
		private void InitProductEntityMappings()
		{
			this.AddElementMapping("ProductEntity", @"Northwind", @"dbo", "Products", 10, 0);
			this.AddElementFieldMapping("ProductEntity", "CategoryId", "CategoryID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("ProductEntity", "Discontinued", "Discontinued", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1);
			this.AddElementFieldMapping("ProductEntity", "ProductId", "ProductID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("ProductEntity", "ProductName", "ProductName", false, "NVarChar", 40, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("ProductEntity", "QuantityPerUnit", "QuantityPerUnit", true, "NVarChar", 20, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("ProductEntity", "ReorderLevel", "ReorderLevel", true, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 5);
			this.AddElementFieldMapping("ProductEntity", "SupplierId", "SupplierID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 6);
			this.AddElementFieldMapping("ProductEntity", "UnitPrice", "UnitPrice", true, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 7);
			this.AddElementFieldMapping("ProductEntity", "UnitsInStock", "UnitsInStock", true, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 8);
			this.AddElementFieldMapping("ProductEntity", "UnitsOnOrder", "UnitsOnOrder", true, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 9);
		}


		/// <summary>Inits InvoicesView's mappings</summary>
		private void InitInvoicesTypedViewMappings()
		{
			this.AddElementMapping("InvoicesTypedView", @"Northwind", @"dbo", "Invoices", 26);
			this.AddElementFieldMapping("InvoicesTypedView", "ShipName", "ShipName", false, "NVarChar", 40, 0, 0, false, string.Empty, null, typeof(System.String), 0);
			this.AddElementFieldMapping("InvoicesTypedView", "ShipAddress", "ShipAddress", false, "NVarChar", 60, 0, 0, false, string.Empty, null, typeof(System.String), 1);
			this.AddElementFieldMapping("InvoicesTypedView", "ShipCity", "ShipCity", false, "NVarChar", 15, 0, 0, false, string.Empty, null, typeof(System.String), 2);
			this.AddElementFieldMapping("InvoicesTypedView", "ShipRegion", "ShipRegion", false, "NVarChar", 15, 0, 0, false, string.Empty, null, typeof(System.String), 3);
			this.AddElementFieldMapping("InvoicesTypedView", "ShipPostalCode", "ShipPostalCode", false, "NVarChar", 10, 0, 0, false, string.Empty, null, typeof(System.String), 4);
			this.AddElementFieldMapping("InvoicesTypedView", "ShipCountry", "ShipCountry", false, "NVarChar", 15, 0, 0, false, string.Empty, null, typeof(System.String), 5);
			this.AddElementFieldMapping("InvoicesTypedView", "CustomerId", "CustomerID", false, "NChar", 5, 0, 0, false, string.Empty, null, typeof(System.String), 6);
			this.AddElementFieldMapping("InvoicesTypedView", "CustomerName", "CustomerName", false, "NVarChar", 40, 0, 0, false, string.Empty, null, typeof(System.String), 7);
			this.AddElementFieldMapping("InvoicesTypedView", "Address", "Address", false, "NVarChar", 60, 0, 0, false, string.Empty, null, typeof(System.String), 8);
			this.AddElementFieldMapping("InvoicesTypedView", "City", "City", false, "NVarChar", 15, 0, 0, false, string.Empty, null, typeof(System.String), 9);
			this.AddElementFieldMapping("InvoicesTypedView", "Region", "Region", false, "NVarChar", 15, 0, 0, false, string.Empty, null, typeof(System.String), 10);
			this.AddElementFieldMapping("InvoicesTypedView", "PostalCode", "PostalCode", false, "NVarChar", 10, 0, 0, false, string.Empty, null, typeof(System.String), 11);
			this.AddElementFieldMapping("InvoicesTypedView", "Country", "Country", false, "NVarChar", 15, 0, 0, false, string.Empty, null, typeof(System.String), 12);
			this.AddElementFieldMapping("InvoicesTypedView", "Salesperson", "Salesperson", false, "NVarChar", 31, 0, 0, false, string.Empty, null, typeof(System.String), 13);
			this.AddElementFieldMapping("InvoicesTypedView", "OrderId", "OrderID", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 14);
			this.AddElementFieldMapping("InvoicesTypedView", "OrderDate", "OrderDate", false, "DateTime", 0, 0, 0, false, string.Empty, null, typeof(System.DateTime), 15);
			this.AddElementFieldMapping("InvoicesTypedView", "RequiredDate", "RequiredDate", false, "DateTime", 0, 0, 0, false, string.Empty, null, typeof(System.DateTime), 16);
			this.AddElementFieldMapping("InvoicesTypedView", "ShippedDate", "ShippedDate", false, "DateTime", 0, 0, 0, false, string.Empty, null, typeof(System.DateTime), 17);
			this.AddElementFieldMapping("InvoicesTypedView", "ShipperName", "ShipperName", false, "NVarChar", 40, 0, 0, false, string.Empty, null, typeof(System.String), 18);
			this.AddElementFieldMapping("InvoicesTypedView", "ProductId", "ProductID", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 19);
			this.AddElementFieldMapping("InvoicesTypedView", "ProductName", "ProductName", false, "NVarChar", 40, 0, 0, false, string.Empty, null, typeof(System.String), 20);
			this.AddElementFieldMapping("InvoicesTypedView", "UnitPrice", "UnitPrice", false, "Money", 0, 19, 4, false, string.Empty, null, typeof(System.Decimal), 21);
			this.AddElementFieldMapping("InvoicesTypedView", "Quantity", "Quantity", false, "SmallInt", 0, 5, 0, false, string.Empty, null, typeof(System.Int16), 22);
			this.AddElementFieldMapping("InvoicesTypedView", "Discount", "Discount", false, "Real", 0, 24, 0, false, string.Empty, null, typeof(System.Single), 23);
			this.AddElementFieldMapping("InvoicesTypedView", "ExtendedPrice", "ExtendedPrice", false, "Money", 0, 19, 4, false, string.Empty, null, typeof(System.Decimal), 24);
			this.AddElementFieldMapping("InvoicesTypedView", "Freight", "Freight", false, "Money", 0, 19, 4, false, string.Empty, null, typeof(System.Decimal), 25);
		}


		/// <summary>Inits ProductsByCategoryView's mappings</summary>
		private void InitProductsByCategoryTypedViewMappings()
		{
			this.AddElementMapping("ProductsByCategoryTypedView", @"Northwind", @"dbo", "Products by Category", 5);
			this.AddElementFieldMapping("ProductsByCategoryTypedView", "CategoryName", "CategoryName", false, "NVarChar", 15, 0, 0, false, string.Empty, null, typeof(System.String), 0);
			this.AddElementFieldMapping("ProductsByCategoryTypedView", "ProductName", "ProductName", false, "NVarChar", 40, 0, 0, false, string.Empty, null, typeof(System.String), 1);
			this.AddElementFieldMapping("ProductsByCategoryTypedView", "QuantityPerUnit", "QuantityPerUnit", false, "NVarChar", 20, 0, 0, false, string.Empty, null, typeof(System.String), 2);
			this.AddElementFieldMapping("ProductsByCategoryTypedView", "UnitsInStock", "UnitsInStock", false, "SmallInt", 0, 5, 0, false, string.Empty, null, typeof(System.Int16), 3);
			this.AddElementFieldMapping("ProductsByCategoryTypedView", "Discontinued", "Discontinued", false, "Bit", 0, 0, 0, false, string.Empty, null, typeof(System.Boolean), 4);
		}


		/// <summary>Inits SalesByCategoryView's mappings</summary>
		private void InitSalesByCategoryTypedViewMappings()
		{
			this.AddElementMapping("SalesByCategoryTypedView", @"Northwind", @"dbo", "Sales by Category", 4);
			this.AddElementFieldMapping("SalesByCategoryTypedView", "CategoryId", "CategoryID", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("SalesByCategoryTypedView", "CategoryName", "CategoryName", false, "NVarChar", 15, 0, 0, false, string.Empty, null, typeof(System.String), 1);
			this.AddElementFieldMapping("SalesByCategoryTypedView", "ProductName", "ProductName", false, "NVarChar", 40, 0, 0, false, string.Empty, null, typeof(System.String), 2);
			this.AddElementFieldMapping("SalesByCategoryTypedView", "ProductSales", "ProductSales", false, "Money", 0, 19, 4, false, string.Empty, null, typeof(System.Decimal), 3);
		}

	}
}
