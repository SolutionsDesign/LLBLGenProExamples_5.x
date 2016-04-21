///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: donderdag 21 april 2016 12:25:28
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.Authorization.DatabaseSpecific
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
			this.InitClass(7);
			InitCustomersEntityMappings();
			InitEmployeesEntityMappings();
			InitGroupEntityMappings();
			InitOrderDetailsEntityMappings();
			InitOrdersEntityMappings();
			InitUserEntityMappings();
			InitUserGroupEntityMappings();
		}

		/// <summary>Inits CustomersEntity's mappings</summary>
		private void InitCustomersEntityMappings()
		{
			this.AddElementMapping("CustomersEntity", @"Northwind", @"dbo", "Customers", 11, 0);
			this.AddElementFieldMapping("CustomersEntity", "Address", "Address", true, "NVarChar", 60, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("CustomersEntity", "City", "City", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("CustomersEntity", "CompanyName", "CompanyName", false, "NVarChar", 40, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("CustomersEntity", "ContactName", "ContactName", true, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("CustomersEntity", "ContactTitle", "ContactTitle", true, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("CustomersEntity", "Country", "Country", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("CustomersEntity", "CustomerId", "CustomerID", false, "NChar", 5, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("CustomersEntity", "Fax", "Fax", true, "NVarChar", 24, 0, 0, false, "", null, typeof(System.String), 7);
			this.AddElementFieldMapping("CustomersEntity", "Phone", "Phone", true, "NVarChar", 24, 0, 0, false, "", null, typeof(System.String), 8);
			this.AddElementFieldMapping("CustomersEntity", "PostalCode", "PostalCode", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 9);
			this.AddElementFieldMapping("CustomersEntity", "Region", "Region", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 10);
		}

		/// <summary>Inits EmployeesEntity's mappings</summary>
		private void InitEmployeesEntityMappings()
		{
			this.AddElementMapping("EmployeesEntity", @"Northwind", @"dbo", "Employees", 18, 0);
			this.AddElementFieldMapping("EmployeesEntity", "Address", "Address", true, "NVarChar", 60, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("EmployeesEntity", "BirthDate", "BirthDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("EmployeesEntity", "City", "City", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("EmployeesEntity", "Country", "Country", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("EmployeesEntity", "EmployeeId", "EmployeeID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("EmployeesEntity", "Extension", "Extension", true, "NVarChar", 4, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("EmployeesEntity", "FirstName", "FirstName", false, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("EmployeesEntity", "HireDate", "HireDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7);
			this.AddElementFieldMapping("EmployeesEntity", "HomePhone", "HomePhone", true, "NVarChar", 24, 0, 0, false, "", null, typeof(System.String), 8);
			this.AddElementFieldMapping("EmployeesEntity", "LastName", "LastName", false, "NVarChar", 20, 0, 0, false, "", null, typeof(System.String), 9);
			this.AddElementFieldMapping("EmployeesEntity", "Notes", "Notes", true, "NText", 1073741823, 0, 0, false, "", null, typeof(System.String), 10);
			this.AddElementFieldMapping("EmployeesEntity", "Photo", "Photo", true, "Image", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 11);
			this.AddElementFieldMapping("EmployeesEntity", "PhotoPath", "PhotoPath", true, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 12);
			this.AddElementFieldMapping("EmployeesEntity", "PostalCode", "PostalCode", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 13);
			this.AddElementFieldMapping("EmployeesEntity", "Region", "Region", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 14);
			this.AddElementFieldMapping("EmployeesEntity", "ReportsTo", "ReportsTo", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 15);
			this.AddElementFieldMapping("EmployeesEntity", "Title", "Title", true, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 16);
			this.AddElementFieldMapping("EmployeesEntity", "TitleOfCourtesy", "TitleOfCourtesy", true, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 17);
		}

		/// <summary>Inits GroupEntity's mappings</summary>
		private void InitGroupEntityMappings()
		{
			this.AddElementMapping("GroupEntity", @"Northwind", @"dbo", "Group", 2, 0);
			this.AddElementFieldMapping("GroupEntity", "Id", "Id", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("GroupEntity", "Name", "Name", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
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

		/// <summary>Inits OrdersEntity's mappings</summary>
		private void InitOrdersEntityMappings()
		{
			this.AddElementMapping("OrdersEntity", @"Northwind", @"dbo", "Orders", 14, 0);
			this.AddElementFieldMapping("OrdersEntity", "CustomerId", "CustomerID", true, "NChar", 5, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("OrdersEntity", "EmployeeId", "EmployeeID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("OrdersEntity", "Freight", "Freight", true, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 2);
			this.AddElementFieldMapping("OrdersEntity", "OrderDate", "OrderDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("OrdersEntity", "OrderId", "OrderID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("OrdersEntity", "RequiredDate", "RequiredDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5);
			this.AddElementFieldMapping("OrdersEntity", "ShipAddress", "ShipAddress", true, "NVarChar", 60, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("OrdersEntity", "ShipCity", "ShipCity", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 7);
			this.AddElementFieldMapping("OrdersEntity", "ShipCountry", "ShipCountry", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 8);
			this.AddElementFieldMapping("OrdersEntity", "ShipName", "ShipName", true, "NVarChar", 40, 0, 0, false, "", null, typeof(System.String), 9);
			this.AddElementFieldMapping("OrdersEntity", "ShippedDate", "ShippedDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 10);
			this.AddElementFieldMapping("OrdersEntity", "ShipPostalCode", "ShipPostalCode", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 11);
			this.AddElementFieldMapping("OrdersEntity", "ShipRegion", "ShipRegion", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 12);
			this.AddElementFieldMapping("OrdersEntity", "ShipVia", "ShipVia", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 13);
		}

		/// <summary>Inits UserEntity's mappings</summary>
		private void InitUserEntityMappings()
		{
			this.AddElementMapping("UserEntity", @"Northwind", @"dbo", "User", 3, 0);
			this.AddElementFieldMapping("UserEntity", "FullName", "FullName", true, "VarChar", 150, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("UserEntity", "Password", "Password", false, "VarChar", 15, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("UserEntity", "UserId", "UserID", false, "VarChar", 15, 0, 0, false, "", null, typeof(System.String), 2);
		}

		/// <summary>Inits UserGroupEntity's mappings</summary>
		private void InitUserGroupEntityMappings()
		{
			this.AddElementMapping("UserGroupEntity", @"Northwind", @"dbo", "UserGroup", 2, 0);
			this.AddElementFieldMapping("UserGroupEntity", "GroupId", "GroupId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("UserGroupEntity", "UserId", "UserId", false, "VarChar", 15, 0, 0, false, "", null, typeof(System.String), 1);
		}

	}
}
