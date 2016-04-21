///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: donderdag 21 april 2016 15:04:54
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.WCF.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal static class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass( (6 + 3));
			InitCategoryEntityInfos();
			InitCustomerEntityInfos();
			InitEmployeeEntityInfos();
			InitOrderEntityInfos();
			InitOrderDetailsEntityInfos();
			InitProductEntityInfos();
			InitInvoicesTypedViewInfos();
			InitProductsByCategoryTypedViewInfos();
			InitSalesByCategoryTypedViewInfos();
			this.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits CategoryEntity's FieldInfo objects</summary>
		private void InitCategoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CategoryFieldIndex), "CategoryEntity");
			this.AddElementFieldInfo("CategoryEntity", "CategoryId", typeof(System.Int32), true, false, true, false,  (int)CategoryFieldIndex.CategoryId, 0, 0, 10);
			this.AddElementFieldInfo("CategoryEntity", "CategoryName", typeof(System.String), false, false, false, false,  (int)CategoryFieldIndex.CategoryName, 15, 0, 0);
			this.AddElementFieldInfo("CategoryEntity", "Description", typeof(System.String), false, false, false, true,  (int)CategoryFieldIndex.Description, 1073741823, 0, 0);
			this.AddElementFieldInfo("CategoryEntity", "Picture", typeof(System.Byte[]), false, false, false, true,  (int)CategoryFieldIndex.Picture, 2147483647, 0, 0);
		}
		/// <summary>Inits CustomerEntity's FieldInfo objects</summary>
		private void InitCustomerEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CustomerFieldIndex), "CustomerEntity");
			this.AddElementFieldInfo("CustomerEntity", "Address", typeof(System.String), false, false, false, true,  (int)CustomerFieldIndex.Address, 60, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "City", typeof(System.String), false, false, false, true,  (int)CustomerFieldIndex.City, 15, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "CompanyName", typeof(System.String), false, false, false, false,  (int)CustomerFieldIndex.CompanyName, 40, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "ContactName", typeof(System.String), false, false, false, true,  (int)CustomerFieldIndex.ContactName, 30, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "ContactTitle", typeof(System.String), false, false, false, true,  (int)CustomerFieldIndex.ContactTitle, 30, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "Country", typeof(System.String), false, false, false, true,  (int)CustomerFieldIndex.Country, 15, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "CustomerId", typeof(System.String), true, false, false, false,  (int)CustomerFieldIndex.CustomerId, 5, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "Fax", typeof(System.String), false, false, false, true,  (int)CustomerFieldIndex.Fax, 24, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "Phone", typeof(System.String), false, false, false, true,  (int)CustomerFieldIndex.Phone, 24, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "PostalCode", typeof(System.String), false, false, false, true,  (int)CustomerFieldIndex.PostalCode, 10, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "Region", typeof(System.String), false, false, false, true,  (int)CustomerFieldIndex.Region, 15, 0, 0);
		}
		/// <summary>Inits EmployeeEntity's FieldInfo objects</summary>
		private void InitEmployeeEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(EmployeeFieldIndex), "EmployeeEntity");
			this.AddElementFieldInfo("EmployeeEntity", "Address", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.Address, 60, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "BirthDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)EmployeeFieldIndex.BirthDate, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "City", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.City, 15, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "Country", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.Country, 15, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "EmployeeId", typeof(System.Int32), true, false, true, false,  (int)EmployeeFieldIndex.EmployeeId, 0, 0, 10);
			this.AddElementFieldInfo("EmployeeEntity", "Extension", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.Extension, 4, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "FirstName", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.FirstName, 10, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "HireDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)EmployeeFieldIndex.HireDate, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "HomePhone", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.HomePhone, 24, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "LastName", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.LastName, 20, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "Notes", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.Notes, 1073741823, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "Photo", typeof(System.Byte[]), false, false, false, true,  (int)EmployeeFieldIndex.Photo, 2147483647, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "PhotoPath", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.PhotoPath, 255, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "PostalCode", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.PostalCode, 10, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "Region", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.Region, 15, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "ReportsTo", typeof(System.Int32), false, true, false, false,  (int)EmployeeFieldIndex.ReportsTo, 0, 0, 10);
			this.AddElementFieldInfo("EmployeeEntity", "Title", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.Title, 30, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "TitleOfCourtesy", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.TitleOfCourtesy, 25, 0, 0);
		}
		/// <summary>Inits OrderEntity's FieldInfo objects</summary>
		private void InitOrderEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(OrderFieldIndex), "OrderEntity");
			this.AddElementFieldInfo("OrderEntity", "CustomerId", typeof(System.String), false, true, false, false,  (int)OrderFieldIndex.CustomerId, 5, 0, 0);
			this.AddElementFieldInfo("OrderEntity", "EmployeeId", typeof(System.Int32), false, true, false, false,  (int)OrderFieldIndex.EmployeeId, 0, 0, 10);
			this.AddElementFieldInfo("OrderEntity", "Freight", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)OrderFieldIndex.Freight, 0, 4, 19);
			this.AddElementFieldInfo("OrderEntity", "OrderDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)OrderFieldIndex.OrderDate, 0, 0, 0);
			this.AddElementFieldInfo("OrderEntity", "OrderId", typeof(System.Int32), true, false, true, false,  (int)OrderFieldIndex.OrderId, 0, 0, 10);
			this.AddElementFieldInfo("OrderEntity", "RequiredDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)OrderFieldIndex.RequiredDate, 0, 0, 0);
			this.AddElementFieldInfo("OrderEntity", "ShipAddress", typeof(System.String), false, false, false, true,  (int)OrderFieldIndex.ShipAddress, 60, 0, 0);
			this.AddElementFieldInfo("OrderEntity", "ShipCity", typeof(System.String), false, false, false, true,  (int)OrderFieldIndex.ShipCity, 15, 0, 0);
			this.AddElementFieldInfo("OrderEntity", "ShipCountry", typeof(System.String), false, false, false, true,  (int)OrderFieldIndex.ShipCountry, 15, 0, 0);
			this.AddElementFieldInfo("OrderEntity", "ShipName", typeof(System.String), false, false, false, true,  (int)OrderFieldIndex.ShipName, 40, 0, 0);
			this.AddElementFieldInfo("OrderEntity", "ShippedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)OrderFieldIndex.ShippedDate, 0, 0, 0);
			this.AddElementFieldInfo("OrderEntity", "ShipPostalCode", typeof(System.String), false, false, false, true,  (int)OrderFieldIndex.ShipPostalCode, 10, 0, 0);
			this.AddElementFieldInfo("OrderEntity", "ShipRegion", typeof(System.String), false, false, false, true,  (int)OrderFieldIndex.ShipRegion, 15, 0, 0);
			this.AddElementFieldInfo("OrderEntity", "ShipVia", typeof(Nullable<System.Int32>), false, false, false, true,  (int)OrderFieldIndex.ShipVia, 0, 0, 10);
		}
		/// <summary>Inits OrderDetailsEntity's FieldInfo objects</summary>
		private void InitOrderDetailsEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(OrderDetailsFieldIndex), "OrderDetailsEntity");
			this.AddElementFieldInfo("OrderDetailsEntity", "Discount", typeof(System.Single), false, false, false, false,  (int)OrderDetailsFieldIndex.Discount, 0, 0, 24);
			this.AddElementFieldInfo("OrderDetailsEntity", "OrderId", typeof(System.Int32), true, true, false, false,  (int)OrderDetailsFieldIndex.OrderId, 0, 0, 10);
			this.AddElementFieldInfo("OrderDetailsEntity", "ProductId", typeof(System.Int32), true, true, false, false,  (int)OrderDetailsFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("OrderDetailsEntity", "Quantity", typeof(System.Int16), false, false, false, false,  (int)OrderDetailsFieldIndex.Quantity, 0, 0, 5);
			this.AddElementFieldInfo("OrderDetailsEntity", "UnitPrice", typeof(System.Decimal), false, false, false, false,  (int)OrderDetailsFieldIndex.UnitPrice, 0, 4, 19);
		}
		/// <summary>Inits ProductEntity's FieldInfo objects</summary>
		private void InitProductEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductFieldIndex), "ProductEntity");
			this.AddElementFieldInfo("ProductEntity", "CategoryId", typeof(System.Int32), false, true, false, false,  (int)ProductFieldIndex.CategoryId, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "Discontinued", typeof(System.Boolean), false, false, false, false,  (int)ProductFieldIndex.Discontinued, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "ProductId", typeof(System.Int32), true, false, true, false,  (int)ProductFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "ProductName", typeof(System.String), false, false, false, false,  (int)ProductFieldIndex.ProductName, 40, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "QuantityPerUnit", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.QuantityPerUnit, 20, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "ReorderLevel", typeof(Nullable<System.Int16>), false, false, false, true,  (int)ProductFieldIndex.ReorderLevel, 0, 0, 5);
			this.AddElementFieldInfo("ProductEntity", "SupplierId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ProductFieldIndex.SupplierId, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "UnitPrice", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ProductFieldIndex.UnitPrice, 0, 4, 19);
			this.AddElementFieldInfo("ProductEntity", "UnitsInStock", typeof(Nullable<System.Int16>), false, false, false, true,  (int)ProductFieldIndex.UnitsInStock, 0, 0, 5);
			this.AddElementFieldInfo("ProductEntity", "UnitsOnOrder", typeof(Nullable<System.Int16>), false, false, false, true,  (int)ProductFieldIndex.UnitsOnOrder, 0, 0, 5);
		}

		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitInvoicesTypedViewInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(InvoicesFieldIndex), "InvoicesTypedView");
			this.AddElementFieldInfo("InvoicesTypedView", "ShipName", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.ShipName, 40, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "ShipAddress", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.ShipAddress, 60, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "ShipCity", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.ShipCity, 15, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "ShipRegion", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.ShipRegion, 15, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "ShipPostalCode", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.ShipPostalCode, 10, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "ShipCountry", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.ShipCountry, 15, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "CustomerId", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.CustomerId, 5, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "CustomerName", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.CustomerName, 40, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "Address", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.Address, 60, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "City", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.City, 15, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "Region", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.Region, 15, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "PostalCode", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.PostalCode, 10, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "Country", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.Country, 15, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "Salesperson", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.Salesperson, 31, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "OrderId", typeof(System.Int32), false, false, true, false, (int)InvoicesFieldIndex.OrderId, 0, 0, 10);
			this.AddElementFieldInfo("InvoicesTypedView", "OrderDate", typeof(System.DateTime), false, false, true, false, (int)InvoicesFieldIndex.OrderDate, 0, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "RequiredDate", typeof(System.DateTime), false, false, true, false, (int)InvoicesFieldIndex.RequiredDate, 0, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "ShippedDate", typeof(System.DateTime), false, false, true, false, (int)InvoicesFieldIndex.ShippedDate, 0, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "ShipperName", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.ShipperName, 40, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "ProductId", typeof(System.Int32), false, false, true, false, (int)InvoicesFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("InvoicesTypedView", "ProductName", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.ProductName, 40, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "UnitPrice", typeof(System.Decimal), false, false, true, false, (int)InvoicesFieldIndex.UnitPrice, 0, 4, 19);
			this.AddElementFieldInfo("InvoicesTypedView", "Quantity", typeof(System.Int16), false, false, true, false, (int)InvoicesFieldIndex.Quantity, 0, 0, 5);
			this.AddElementFieldInfo("InvoicesTypedView", "Discount", typeof(System.Single), false, false, true, false, (int)InvoicesFieldIndex.Discount, 0, 0, 24);
			this.AddElementFieldInfo("InvoicesTypedView", "ExtendedPrice", typeof(System.Decimal), false, false, true, false, (int)InvoicesFieldIndex.ExtendedPrice, 0, 4, 19);
			this.AddElementFieldInfo("InvoicesTypedView", "Freight", typeof(System.Decimal), false, false, true, false, (int)InvoicesFieldIndex.Freight, 0, 4, 19);
		}
		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitProductsByCategoryTypedViewInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductsByCategoryFieldIndex), "ProductsByCategoryTypedView");
			this.AddElementFieldInfo("ProductsByCategoryTypedView", "CategoryName", typeof(System.String), false, false, true, false, (int)ProductsByCategoryFieldIndex.CategoryName, 15, 0, 0);
			this.AddElementFieldInfo("ProductsByCategoryTypedView", "ProductName", typeof(System.String), false, false, true, false, (int)ProductsByCategoryFieldIndex.ProductName, 40, 0, 0);
			this.AddElementFieldInfo("ProductsByCategoryTypedView", "QuantityPerUnit", typeof(System.String), false, false, true, false, (int)ProductsByCategoryFieldIndex.QuantityPerUnit, 20, 0, 0);
			this.AddElementFieldInfo("ProductsByCategoryTypedView", "UnitsInStock", typeof(System.Int16), false, false, true, false, (int)ProductsByCategoryFieldIndex.UnitsInStock, 0, 0, 5);
			this.AddElementFieldInfo("ProductsByCategoryTypedView", "Discontinued", typeof(System.Boolean), false, false, true, false, (int)ProductsByCategoryFieldIndex.Discontinued, 0, 0, 0);
		}
		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitSalesByCategoryTypedViewInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SalesByCategoryFieldIndex), "SalesByCategoryTypedView");
			this.AddElementFieldInfo("SalesByCategoryTypedView", "CategoryId", typeof(System.Int32), false, false, true, false, (int)SalesByCategoryFieldIndex.CategoryId, 0, 0, 10);
			this.AddElementFieldInfo("SalesByCategoryTypedView", "CategoryName", typeof(System.String), false, false, true, false, (int)SalesByCategoryFieldIndex.CategoryName, 15, 0, 0);
			this.AddElementFieldInfo("SalesByCategoryTypedView", "ProductName", typeof(System.String), false, false, true, false, (int)SalesByCategoryFieldIndex.ProductName, 40, 0, 0);
			this.AddElementFieldInfo("SalesByCategoryTypedView", "ProductSales", typeof(System.Decimal), false, false, true, false, (int)SalesByCategoryFieldIndex.ProductSales, 0, 4, 19);
		}		
	}
}




