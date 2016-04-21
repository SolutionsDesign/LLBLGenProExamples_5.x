///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.SSDAL.HelperClasses
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
			this.InitClass( (19 + 0));
			InitAuditActionTypeEntityInfos();
			InitAuditInfoEntityInfos();
			InitCategoryEntityInfos();
			InitCustomerEntityInfos();
			InitCustomerCustomerDemoEntityInfos();
			InitCustomerDemographicEntityInfos();
			InitEmployeeEntityInfos();
			InitEmployeeTerritoryEntityInfos();
			InitGroupEntityInfos();
			InitOrderEntityInfos();
			InitOrderAuditInfoEntityInfos();
			InitOrderDetailEntityInfos();
			InitProductEntityInfos();
			InitRegionEntityInfos();
			InitShipperEntityInfos();
			InitSupplierEntityInfos();
			InitTerritoryEntityInfos();
			InitUserEntityInfos();
			InitUserGroupEntityInfos();

			this.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits AuditActionTypeEntity's FieldInfo objects</summary>
		private void InitAuditActionTypeEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AuditActionTypeFieldIndex), "AuditActionTypeEntity");
			this.AddElementFieldInfo("AuditActionTypeEntity", "AuditActionTypeId", typeof(System.Int32), true, false, false, false,  (int)AuditActionTypeFieldIndex.AuditActionTypeId, 0, 0, 10);
			this.AddElementFieldInfo("AuditActionTypeEntity", "Name", typeof(System.String), false, false, false, false,  (int)AuditActionTypeFieldIndex.Name, 50, 0, 0);
		}
		/// <summary>Inits AuditInfoEntity's FieldInfo objects</summary>
		private void InitAuditInfoEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AuditInfoFieldIndex), "AuditInfoEntity");
			this.AddElementFieldInfo("AuditInfoEntity", "ActionData", typeof(System.String), false, false, false, true,  (int)AuditInfoFieldIndex.ActionData, 250, 0, 0);
			this.AddElementFieldInfo("AuditInfoEntity", "ActionDateTime", typeof(System.DateTime), false, false, false, false,  (int)AuditInfoFieldIndex.ActionDateTime, 0, 0, 0);
			this.AddElementFieldInfo("AuditInfoEntity", "AffectedEntityName", typeof(System.String), false, false, false, false,  (int)AuditInfoFieldIndex.AffectedEntityName, 100, 0, 0);
			this.AddElementFieldInfo("AuditInfoEntity", "AuditActionTypeId", typeof(System.Int32), false, true, false, false,  (int)AuditInfoFieldIndex.AuditActionTypeId, 0, 0, 10);
			this.AddElementFieldInfo("AuditInfoEntity", "AuditInfoId", typeof(System.Int32), true, false, true, false,  (int)AuditInfoFieldIndex.AuditInfoId, 0, 0, 10);
			this.AddElementFieldInfo("AuditInfoEntity", "UserId", typeof(System.String), false, true, false, false,  (int)AuditInfoFieldIndex.UserId, 15, 0, 0);
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
		/// <summary>Inits CustomerCustomerDemoEntity's FieldInfo objects</summary>
		private void InitCustomerCustomerDemoEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CustomerCustomerDemoFieldIndex), "CustomerCustomerDemoEntity");
			this.AddElementFieldInfo("CustomerCustomerDemoEntity", "CustomerId", typeof(System.String), true, true, false, false,  (int)CustomerCustomerDemoFieldIndex.CustomerId, 5, 0, 0);
			this.AddElementFieldInfo("CustomerCustomerDemoEntity", "CustomerTypeId", typeof(System.String), true, true, false, false,  (int)CustomerCustomerDemoFieldIndex.CustomerTypeId, 10, 0, 0);
		}
		/// <summary>Inits CustomerDemographicEntity's FieldInfo objects</summary>
		private void InitCustomerDemographicEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CustomerDemographicFieldIndex), "CustomerDemographicEntity");
			this.AddElementFieldInfo("CustomerDemographicEntity", "CustomerDesc", typeof(System.String), false, false, false, true,  (int)CustomerDemographicFieldIndex.CustomerDesc, 1073741823, 0, 0);
			this.AddElementFieldInfo("CustomerDemographicEntity", "CustomerTypeId", typeof(System.String), true, false, false, false,  (int)CustomerDemographicFieldIndex.CustomerTypeId, 10, 0, 0);
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
			this.AddElementFieldInfo("EmployeeEntity", "ReportsTo", typeof(Nullable<System.Int32>), false, true, false, true,  (int)EmployeeFieldIndex.ReportsTo, 0, 0, 10);
			this.AddElementFieldInfo("EmployeeEntity", "Title", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.Title, 30, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "TitleOfCourtesy", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.TitleOfCourtesy, 25, 0, 0);
		}
		/// <summary>Inits EmployeeTerritoryEntity's FieldInfo objects</summary>
		private void InitEmployeeTerritoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(EmployeeTerritoryFieldIndex), "EmployeeTerritoryEntity");
			this.AddElementFieldInfo("EmployeeTerritoryEntity", "EmployeeId", typeof(System.Int32), true, true, false, false,  (int)EmployeeTerritoryFieldIndex.EmployeeId, 0, 0, 10);
			this.AddElementFieldInfo("EmployeeTerritoryEntity", "TerritoryId", typeof(System.String), true, true, false, false,  (int)EmployeeTerritoryFieldIndex.TerritoryId, 20, 0, 0);
		}
		/// <summary>Inits GroupEntity's FieldInfo objects</summary>
		private void InitGroupEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(GroupFieldIndex), "GroupEntity");
			this.AddElementFieldInfo("GroupEntity", "Id", typeof(System.Int32), true, false, false, false,  (int)GroupFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("GroupEntity", "Name", typeof(System.String), false, false, false, true,  (int)GroupFieldIndex.Name, 50, 0, 0);
		}
		/// <summary>Inits OrderEntity's FieldInfo objects</summary>
		private void InitOrderEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(OrderFieldIndex), "OrderEntity");
			this.AddElementFieldInfo("OrderEntity", "CustomerId", typeof(System.String), false, true, false, true,  (int)OrderFieldIndex.CustomerId, 5, 0, 0);
			this.AddElementFieldInfo("OrderEntity", "EmployeeId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)OrderFieldIndex.EmployeeId, 0, 0, 10);
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
			this.AddElementFieldInfo("OrderEntity", "ShipVia", typeof(Nullable<System.Int32>), false, true, false, true,  (int)OrderFieldIndex.ShipVia, 0, 0, 10);
		}
		/// <summary>Inits OrderAuditInfoEntity's FieldInfo objects</summary>
		private void InitOrderAuditInfoEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(OrderAuditInfoFieldIndex), "OrderAuditInfoEntity");
			this.AddElementFieldInfo("OrderAuditInfoEntity", "AuditInfoId", typeof(System.Int32), true, false, true, false,  (int)OrderAuditInfoFieldIndex.AuditInfoId, 0, 0, 10);
			this.AddElementFieldInfo("OrderAuditInfoEntity", "OrderId", typeof(System.Int32), false, true, false, false,  (int)OrderAuditInfoFieldIndex.OrderId, 0, 0, 10);
		}
		/// <summary>Inits OrderDetailEntity's FieldInfo objects</summary>
		private void InitOrderDetailEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(OrderDetailFieldIndex), "OrderDetailEntity");
			this.AddElementFieldInfo("OrderDetailEntity", "Discount", typeof(System.Single), false, false, false, false,  (int)OrderDetailFieldIndex.Discount, 0, 0, 24);
			this.AddElementFieldInfo("OrderDetailEntity", "OrderId", typeof(System.Int32), true, true, false, false,  (int)OrderDetailFieldIndex.OrderId, 0, 0, 10);
			this.AddElementFieldInfo("OrderDetailEntity", "ProductId", typeof(System.Int32), true, true, false, false,  (int)OrderDetailFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("OrderDetailEntity", "Quantity", typeof(System.Int16), false, false, false, false,  (int)OrderDetailFieldIndex.Quantity, 0, 0, 5);
			this.AddElementFieldInfo("OrderDetailEntity", "UnitPrice", typeof(System.Decimal), false, false, false, false,  (int)OrderDetailFieldIndex.UnitPrice, 0, 4, 19);
		}
		/// <summary>Inits ProductEntity's FieldInfo objects</summary>
		private void InitProductEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductFieldIndex), "ProductEntity");
			this.AddElementFieldInfo("ProductEntity", "CategoryId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ProductFieldIndex.CategoryId, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "Discontinued", typeof(System.Boolean), false, false, false, false,  (int)ProductFieldIndex.Discontinued, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "ProductId", typeof(System.Int32), true, false, true, false,  (int)ProductFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "ProductName", typeof(System.String), false, false, false, false,  (int)ProductFieldIndex.ProductName, 40, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "QuantityPerUnit", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.QuantityPerUnit, 20, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "ReorderLevel", typeof(Nullable<System.Int16>), false, false, false, true,  (int)ProductFieldIndex.ReorderLevel, 0, 0, 5);
			this.AddElementFieldInfo("ProductEntity", "SupplierId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ProductFieldIndex.SupplierId, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "UnitPrice", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ProductFieldIndex.UnitPrice, 0, 4, 19);
			this.AddElementFieldInfo("ProductEntity", "UnitsInStock", typeof(Nullable<System.Int16>), false, false, false, true,  (int)ProductFieldIndex.UnitsInStock, 0, 0, 5);
			this.AddElementFieldInfo("ProductEntity", "UnitsOnOrder", typeof(Nullable<System.Int16>), false, false, false, true,  (int)ProductFieldIndex.UnitsOnOrder, 0, 0, 5);
		}
		/// <summary>Inits RegionEntity's FieldInfo objects</summary>
		private void InitRegionEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(RegionFieldIndex), "RegionEntity");
			this.AddElementFieldInfo("RegionEntity", "RegionDescription", typeof(System.String), false, false, false, false,  (int)RegionFieldIndex.RegionDescription, 50, 0, 0);
			this.AddElementFieldInfo("RegionEntity", "RegionId", typeof(System.Int32), true, false, false, false,  (int)RegionFieldIndex.RegionId, 0, 0, 10);
		}
		/// <summary>Inits ShipperEntity's FieldInfo objects</summary>
		private void InitShipperEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ShipperFieldIndex), "ShipperEntity");
			this.AddElementFieldInfo("ShipperEntity", "CompanyName", typeof(System.String), false, false, false, false,  (int)ShipperFieldIndex.CompanyName, 40, 0, 0);
			this.AddElementFieldInfo("ShipperEntity", "Phone", typeof(System.String), false, false, false, true,  (int)ShipperFieldIndex.Phone, 24, 0, 0);
			this.AddElementFieldInfo("ShipperEntity", "ShipperId", typeof(System.Int32), true, false, true, false,  (int)ShipperFieldIndex.ShipperId, 0, 0, 10);
		}
		/// <summary>Inits SupplierEntity's FieldInfo objects</summary>
		private void InitSupplierEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SupplierFieldIndex), "SupplierEntity");
			this.AddElementFieldInfo("SupplierEntity", "Address", typeof(System.String), false, false, false, true,  (int)SupplierFieldIndex.Address, 60, 0, 0);
			this.AddElementFieldInfo("SupplierEntity", "City", typeof(System.String), false, false, false, true,  (int)SupplierFieldIndex.City, 15, 0, 0);
			this.AddElementFieldInfo("SupplierEntity", "CompanyName", typeof(System.String), false, false, false, false,  (int)SupplierFieldIndex.CompanyName, 40, 0, 0);
			this.AddElementFieldInfo("SupplierEntity", "ContactName", typeof(System.String), false, false, false, true,  (int)SupplierFieldIndex.ContactName, 30, 0, 0);
			this.AddElementFieldInfo("SupplierEntity", "ContactTitle", typeof(System.String), false, false, false, true,  (int)SupplierFieldIndex.ContactTitle, 30, 0, 0);
			this.AddElementFieldInfo("SupplierEntity", "Country", typeof(System.String), false, false, false, true,  (int)SupplierFieldIndex.Country, 15, 0, 0);
			this.AddElementFieldInfo("SupplierEntity", "Fax", typeof(System.String), false, false, false, true,  (int)SupplierFieldIndex.Fax, 24, 0, 0);
			this.AddElementFieldInfo("SupplierEntity", "HomePage", typeof(System.String), false, false, false, true,  (int)SupplierFieldIndex.HomePage, 1073741823, 0, 0);
			this.AddElementFieldInfo("SupplierEntity", "Phone", typeof(System.String), false, false, false, true,  (int)SupplierFieldIndex.Phone, 24, 0, 0);
			this.AddElementFieldInfo("SupplierEntity", "PostalCode", typeof(System.String), false, false, false, true,  (int)SupplierFieldIndex.PostalCode, 10, 0, 0);
			this.AddElementFieldInfo("SupplierEntity", "Region", typeof(System.String), false, false, false, true,  (int)SupplierFieldIndex.Region, 15, 0, 0);
			this.AddElementFieldInfo("SupplierEntity", "SupplierId", typeof(System.Int32), true, false, true, false,  (int)SupplierFieldIndex.SupplierId, 0, 0, 10);
		}
		/// <summary>Inits TerritoryEntity's FieldInfo objects</summary>
		private void InitTerritoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(TerritoryFieldIndex), "TerritoryEntity");
			this.AddElementFieldInfo("TerritoryEntity", "RegionId", typeof(System.Int32), false, true, false, false,  (int)TerritoryFieldIndex.RegionId, 0, 0, 10);
			this.AddElementFieldInfo("TerritoryEntity", "TerritoryDescription", typeof(System.String), false, false, false, false,  (int)TerritoryFieldIndex.TerritoryDescription, 50, 0, 0);
			this.AddElementFieldInfo("TerritoryEntity", "TerritoryId", typeof(System.String), true, false, false, false,  (int)TerritoryFieldIndex.TerritoryId, 20, 0, 0);
			this.AddElementFieldInfo("TerritoryEntity", "Test", typeof(System.Byte[]), false, false, false, true,  (int)TerritoryFieldIndex.Test, 50, 0, 0);
		}
		/// <summary>Inits UserEntity's FieldInfo objects</summary>
		private void InitUserEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(UserFieldIndex), "UserEntity");
			this.AddElementFieldInfo("UserEntity", "FullName", typeof(System.String), false, false, false, true,  (int)UserFieldIndex.FullName, 150, 0, 0);
			this.AddElementFieldInfo("UserEntity", "Password", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Password, 15, 0, 0);
			this.AddElementFieldInfo("UserEntity", "UserId", typeof(System.String), true, false, false, false,  (int)UserFieldIndex.UserId, 15, 0, 0);
		}
		/// <summary>Inits UserGroupEntity's FieldInfo objects</summary>
		private void InitUserGroupEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(UserGroupFieldIndex), "UserGroupEntity");
			this.AddElementFieldInfo("UserGroupEntity", "GroupId", typeof(System.Int32), true, true, false, false,  (int)UserGroupFieldIndex.GroupId, 0, 0, 10);
			this.AddElementFieldInfo("UserGroupEntity", "UserId", typeof(System.String), true, true, false, false,  (int)UserGroupFieldIndex.UserId, 15, 0, 0);
		}
		
	}
}




