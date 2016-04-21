///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: donderdag 21 april 2016 11:36:44
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses;
using SD.LLBLGen.Pro.Examples.Auditing;

namespace SD.LLBLGen.Pro.Examples.Auditing.HelperClasses
{
	/// <summary>Field Creation Class for entity AuditActionTypeEntity</summary>
	public partial class AuditActionTypeFields
	{
		/// <summary>Creates a new AuditActionTypeEntity.AuditActionTypeId field instance</summary>
		public static EntityField AuditActionTypeId
		{
			get { return (EntityField)EntityFieldFactory.Create(AuditActionTypeFieldIndex.AuditActionTypeId);}
		}
		/// <summary>Creates a new AuditActionTypeEntity.Name field instance</summary>
		public static EntityField Name
		{
			get { return (EntityField)EntityFieldFactory.Create(AuditActionTypeFieldIndex.Name);}
		}
	}

	/// <summary>Field Creation Class for entity AuditInfoEntity</summary>
	public partial class AuditInfoFields
	{
		/// <summary>Creates a new AuditInfoEntity.ActionData field instance</summary>
		public static EntityField ActionData
		{
			get { return (EntityField)EntityFieldFactory.Create(AuditInfoFieldIndex.ActionData);}
		}
		/// <summary>Creates a new AuditInfoEntity.ActionDateTime field instance</summary>
		public static EntityField ActionDateTime
		{
			get { return (EntityField)EntityFieldFactory.Create(AuditInfoFieldIndex.ActionDateTime);}
		}
		/// <summary>Creates a new AuditInfoEntity.AffectedEntityName field instance</summary>
		public static EntityField AffectedEntityName
		{
			get { return (EntityField)EntityFieldFactory.Create(AuditInfoFieldIndex.AffectedEntityName);}
		}
		/// <summary>Creates a new AuditInfoEntity.AuditActionTypeId field instance</summary>
		public static EntityField AuditActionTypeId
		{
			get { return (EntityField)EntityFieldFactory.Create(AuditInfoFieldIndex.AuditActionTypeId);}
		}
		/// <summary>Creates a new AuditInfoEntity.AuditInfoId field instance</summary>
		public static EntityField AuditInfoId
		{
			get { return (EntityField)EntityFieldFactory.Create(AuditInfoFieldIndex.AuditInfoId);}
		}
		/// <summary>Creates a new AuditInfoEntity.UserId field instance</summary>
		public static EntityField UserId
		{
			get { return (EntityField)EntityFieldFactory.Create(AuditInfoFieldIndex.UserId);}
		}
	}

	/// <summary>Field Creation Class for entity CategoryEntity</summary>
	public partial class CategoryFields
	{
		/// <summary>Creates a new CategoryEntity.CategoryId field instance</summary>
		public static EntityField CategoryId
		{
			get { return (EntityField)EntityFieldFactory.Create(CategoryFieldIndex.CategoryId);}
		}
		/// <summary>Creates a new CategoryEntity.CategoryName field instance</summary>
		public static EntityField CategoryName
		{
			get { return (EntityField)EntityFieldFactory.Create(CategoryFieldIndex.CategoryName);}
		}
		/// <summary>Creates a new CategoryEntity.Description field instance</summary>
		public static EntityField Description
		{
			get { return (EntityField)EntityFieldFactory.Create(CategoryFieldIndex.Description);}
		}
		/// <summary>Creates a new CategoryEntity.Picture field instance</summary>
		public static EntityField Picture
		{
			get { return (EntityField)EntityFieldFactory.Create(CategoryFieldIndex.Picture);}
		}
	}

	/// <summary>Field Creation Class for entity CustomerEntity</summary>
	public partial class CustomerFields
	{
		/// <summary>Creates a new CustomerEntity.Address field instance</summary>
		public static EntityField Address
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerFieldIndex.Address);}
		}
		/// <summary>Creates a new CustomerEntity.City field instance</summary>
		public static EntityField City
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerFieldIndex.City);}
		}
		/// <summary>Creates a new CustomerEntity.CompanyName field instance</summary>
		public static EntityField CompanyName
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerFieldIndex.CompanyName);}
		}
		/// <summary>Creates a new CustomerEntity.ContactName field instance</summary>
		public static EntityField ContactName
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerFieldIndex.ContactName);}
		}
		/// <summary>Creates a new CustomerEntity.ContactTitle field instance</summary>
		public static EntityField ContactTitle
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerFieldIndex.ContactTitle);}
		}
		/// <summary>Creates a new CustomerEntity.Country field instance</summary>
		public static EntityField Country
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerFieldIndex.Country);}
		}
		/// <summary>Creates a new CustomerEntity.CustomerId field instance</summary>
		public static EntityField CustomerId
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerFieldIndex.CustomerId);}
		}
		/// <summary>Creates a new CustomerEntity.Fax field instance</summary>
		public static EntityField Fax
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerFieldIndex.Fax);}
		}
		/// <summary>Creates a new CustomerEntity.Phone field instance</summary>
		public static EntityField Phone
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerFieldIndex.Phone);}
		}
		/// <summary>Creates a new CustomerEntity.PostalCode field instance</summary>
		public static EntityField PostalCode
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerFieldIndex.PostalCode);}
		}
		/// <summary>Creates a new CustomerEntity.Region field instance</summary>
		public static EntityField Region
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerFieldIndex.Region);}
		}
	}

	/// <summary>Field Creation Class for entity CustomerCustomerDemoEntity</summary>
	public partial class CustomerCustomerDemoFields
	{
		/// <summary>Creates a new CustomerCustomerDemoEntity.CustomerId field instance</summary>
		public static EntityField CustomerId
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerCustomerDemoFieldIndex.CustomerId);}
		}
		/// <summary>Creates a new CustomerCustomerDemoEntity.CustomerTypeId field instance</summary>
		public static EntityField CustomerTypeId
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerCustomerDemoFieldIndex.CustomerTypeId);}
		}
	}

	/// <summary>Field Creation Class for entity CustomerDemographyEntity</summary>
	public partial class CustomerDemographyFields
	{
		/// <summary>Creates a new CustomerDemographyEntity.CustomerDesc field instance</summary>
		public static EntityField CustomerDesc
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerDemographyFieldIndex.CustomerDesc);}
		}
		/// <summary>Creates a new CustomerDemographyEntity.CustomerTypeId field instance</summary>
		public static EntityField CustomerTypeId
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerDemographyFieldIndex.CustomerTypeId);}
		}
	}

	/// <summary>Field Creation Class for entity EmployeeEntity</summary>
	public partial class EmployeeFields
	{
		/// <summary>Creates a new EmployeeEntity.Address field instance</summary>
		public static EntityField Address
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.Address);}
		}
		/// <summary>Creates a new EmployeeEntity.BirthDate field instance</summary>
		public static EntityField BirthDate
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.BirthDate);}
		}
		/// <summary>Creates a new EmployeeEntity.City field instance</summary>
		public static EntityField City
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.City);}
		}
		/// <summary>Creates a new EmployeeEntity.Country field instance</summary>
		public static EntityField Country
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.Country);}
		}
		/// <summary>Creates a new EmployeeEntity.EmployeeId field instance</summary>
		public static EntityField EmployeeId
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.EmployeeId);}
		}
		/// <summary>Creates a new EmployeeEntity.Extension field instance</summary>
		public static EntityField Extension
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.Extension);}
		}
		/// <summary>Creates a new EmployeeEntity.FirstName field instance</summary>
		public static EntityField FirstName
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.FirstName);}
		}
		/// <summary>Creates a new EmployeeEntity.HireDate field instance</summary>
		public static EntityField HireDate
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.HireDate);}
		}
		/// <summary>Creates a new EmployeeEntity.HomePhone field instance</summary>
		public static EntityField HomePhone
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.HomePhone);}
		}
		/// <summary>Creates a new EmployeeEntity.LastName field instance</summary>
		public static EntityField LastName
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.LastName);}
		}
		/// <summary>Creates a new EmployeeEntity.Notes field instance</summary>
		public static EntityField Notes
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.Notes);}
		}
		/// <summary>Creates a new EmployeeEntity.Photo field instance</summary>
		public static EntityField Photo
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.Photo);}
		}
		/// <summary>Creates a new EmployeeEntity.PhotoPath field instance</summary>
		public static EntityField PhotoPath
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.PhotoPath);}
		}
		/// <summary>Creates a new EmployeeEntity.PostalCode field instance</summary>
		public static EntityField PostalCode
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.PostalCode);}
		}
		/// <summary>Creates a new EmployeeEntity.Region field instance</summary>
		public static EntityField Region
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.Region);}
		}
		/// <summary>Creates a new EmployeeEntity.ReportsTo field instance</summary>
		public static EntityField ReportsTo
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.ReportsTo);}
		}
		/// <summary>Creates a new EmployeeEntity.Title field instance</summary>
		public static EntityField Title
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.Title);}
		}
		/// <summary>Creates a new EmployeeEntity.TitleOfCourtesy field instance</summary>
		public static EntityField TitleOfCourtesy
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.TitleOfCourtesy);}
		}
	}

	/// <summary>Field Creation Class for entity EmployeeTerritoryEntity</summary>
	public partial class EmployeeTerritoryFields
	{
		/// <summary>Creates a new EmployeeTerritoryEntity.EmployeeId field instance</summary>
		public static EntityField EmployeeId
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeTerritoryFieldIndex.EmployeeId);}
		}
		/// <summary>Creates a new EmployeeTerritoryEntity.TerritoryId field instance</summary>
		public static EntityField TerritoryId
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeTerritoryFieldIndex.TerritoryId);}
		}
	}

	/// <summary>Field Creation Class for entity OrderEntity</summary>
	public partial class OrderFields
	{
		/// <summary>Creates a new OrderEntity.CustomerId field instance</summary>
		public static EntityField CustomerId
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderFieldIndex.CustomerId);}
		}
		/// <summary>Creates a new OrderEntity.EmployeeId field instance</summary>
		public static EntityField EmployeeId
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderFieldIndex.EmployeeId);}
		}
		/// <summary>Creates a new OrderEntity.Freight field instance</summary>
		public static EntityField Freight
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderFieldIndex.Freight);}
		}
		/// <summary>Creates a new OrderEntity.OrderDate field instance</summary>
		public static EntityField OrderDate
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderFieldIndex.OrderDate);}
		}
		/// <summary>Creates a new OrderEntity.OrderId field instance</summary>
		public static EntityField OrderId
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderFieldIndex.OrderId);}
		}
		/// <summary>Creates a new OrderEntity.RequiredDate field instance</summary>
		public static EntityField RequiredDate
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderFieldIndex.RequiredDate);}
		}
		/// <summary>Creates a new OrderEntity.ShipAddress field instance</summary>
		public static EntityField ShipAddress
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderFieldIndex.ShipAddress);}
		}
		/// <summary>Creates a new OrderEntity.ShipCity field instance</summary>
		public static EntityField ShipCity
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderFieldIndex.ShipCity);}
		}
		/// <summary>Creates a new OrderEntity.ShipCountry field instance</summary>
		public static EntityField ShipCountry
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderFieldIndex.ShipCountry);}
		}
		/// <summary>Creates a new OrderEntity.ShipName field instance</summary>
		public static EntityField ShipName
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderFieldIndex.ShipName);}
		}
		/// <summary>Creates a new OrderEntity.ShippedDate field instance</summary>
		public static EntityField ShippedDate
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderFieldIndex.ShippedDate);}
		}
		/// <summary>Creates a new OrderEntity.ShipPostalCode field instance</summary>
		public static EntityField ShipPostalCode
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderFieldIndex.ShipPostalCode);}
		}
		/// <summary>Creates a new OrderEntity.ShipRegion field instance</summary>
		public static EntityField ShipRegion
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderFieldIndex.ShipRegion);}
		}
		/// <summary>Creates a new OrderEntity.ShipVia field instance</summary>
		public static EntityField ShipVia
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderFieldIndex.ShipVia);}
		}
	}

	/// <summary>Field Creation Class for entity OrderAuditInfoEntity</summary>
	public partial class OrderAuditInfoFields
	{
		/// <summary>Creates a new OrderAuditInfoEntity.ActionData field instance</summary>
		public static EntityField ActionData
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderAuditInfoFieldIndex.ActionData);}
		}
		/// <summary>Creates a new OrderAuditInfoEntity.ActionDateTime field instance</summary>
		public static EntityField ActionDateTime
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderAuditInfoFieldIndex.ActionDateTime);}
		}
		/// <summary>Creates a new OrderAuditInfoEntity.AffectedEntityName field instance</summary>
		public static EntityField AffectedEntityName
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderAuditInfoFieldIndex.AffectedEntityName);}
		}
		/// <summary>Creates a new OrderAuditInfoEntity.AuditActionTypeId field instance</summary>
		public static EntityField AuditActionTypeId
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderAuditInfoFieldIndex.AuditActionTypeId);}
		}
		/// <summary>Creates a new OrderAuditInfoEntity.AuditInfoId field instance</summary>
		public static EntityField AuditInfoId_AuditInfo
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderAuditInfoFieldIndex.AuditInfoId_AuditInfo);}
		}
		/// <summary>Creates a new OrderAuditInfoEntity.UserId field instance</summary>
		public static EntityField UserId
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderAuditInfoFieldIndex.UserId);}
		}
		/// <summary>Creates a new OrderAuditInfoEntity.AuditInfoId field instance</summary>
		public static EntityField AuditInfoId
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderAuditInfoFieldIndex.AuditInfoId);}
		}
		/// <summary>Creates a new OrderAuditInfoEntity.OrderId field instance</summary>
		public static EntityField OrderId
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderAuditInfoFieldIndex.OrderId);}
		}
	}

	/// <summary>Field Creation Class for entity OrderDetailEntity</summary>
	public partial class OrderDetailFields
	{
		/// <summary>Creates a new OrderDetailEntity.Discount field instance</summary>
		public static EntityField Discount
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderDetailFieldIndex.Discount);}
		}
		/// <summary>Creates a new OrderDetailEntity.OrderId field instance</summary>
		public static EntityField OrderId
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderDetailFieldIndex.OrderId);}
		}
		/// <summary>Creates a new OrderDetailEntity.ProductId field instance</summary>
		public static EntityField ProductId
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderDetailFieldIndex.ProductId);}
		}
		/// <summary>Creates a new OrderDetailEntity.Quantity field instance</summary>
		public static EntityField Quantity
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderDetailFieldIndex.Quantity);}
		}
		/// <summary>Creates a new OrderDetailEntity.UnitPrice field instance</summary>
		public static EntityField UnitPrice
		{
			get { return (EntityField)EntityFieldFactory.Create(OrderDetailFieldIndex.UnitPrice);}
		}
	}

	/// <summary>Field Creation Class for entity ProductEntity</summary>
	public partial class ProductFields
	{
		/// <summary>Creates a new ProductEntity.CategoryId field instance</summary>
		public static EntityField CategoryId
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.CategoryId);}
		}
		/// <summary>Creates a new ProductEntity.Discontinued field instance</summary>
		public static EntityField Discontinued
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.Discontinued);}
		}
		/// <summary>Creates a new ProductEntity.ProductId field instance</summary>
		public static EntityField ProductId
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.ProductId);}
		}
		/// <summary>Creates a new ProductEntity.ProductName field instance</summary>
		public static EntityField ProductName
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.ProductName);}
		}
		/// <summary>Creates a new ProductEntity.QuantityPerUnit field instance</summary>
		public static EntityField QuantityPerUnit
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.QuantityPerUnit);}
		}
		/// <summary>Creates a new ProductEntity.ReorderLevel field instance</summary>
		public static EntityField ReorderLevel
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.ReorderLevel);}
		}
		/// <summary>Creates a new ProductEntity.SupplierId field instance</summary>
		public static EntityField SupplierId
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.SupplierId);}
		}
		/// <summary>Creates a new ProductEntity.UnitPrice field instance</summary>
		public static EntityField UnitPrice
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.UnitPrice);}
		}
		/// <summary>Creates a new ProductEntity.UnitsInStock field instance</summary>
		public static EntityField UnitsInStock
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.UnitsInStock);}
		}
		/// <summary>Creates a new ProductEntity.UnitsOnOrder field instance</summary>
		public static EntityField UnitsOnOrder
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.UnitsOnOrder);}
		}
	}

	/// <summary>Field Creation Class for entity RegionEntity</summary>
	public partial class RegionFields
	{
		/// <summary>Creates a new RegionEntity.RegionDescription field instance</summary>
		public static EntityField RegionDescription
		{
			get { return (EntityField)EntityFieldFactory.Create(RegionFieldIndex.RegionDescription);}
		}
		/// <summary>Creates a new RegionEntity.RegionId field instance</summary>
		public static EntityField RegionId
		{
			get { return (EntityField)EntityFieldFactory.Create(RegionFieldIndex.RegionId);}
		}
	}

	/// <summary>Field Creation Class for entity ShipperEntity</summary>
	public partial class ShipperFields
	{
		/// <summary>Creates a new ShipperEntity.CompanyName field instance</summary>
		public static EntityField CompanyName
		{
			get { return (EntityField)EntityFieldFactory.Create(ShipperFieldIndex.CompanyName);}
		}
		/// <summary>Creates a new ShipperEntity.Phone field instance</summary>
		public static EntityField Phone
		{
			get { return (EntityField)EntityFieldFactory.Create(ShipperFieldIndex.Phone);}
		}
		/// <summary>Creates a new ShipperEntity.ShipperId field instance</summary>
		public static EntityField ShipperId
		{
			get { return (EntityField)EntityFieldFactory.Create(ShipperFieldIndex.ShipperId);}
		}
	}

	/// <summary>Field Creation Class for entity SupplierEntity</summary>
	public partial class SupplierFields
	{
		/// <summary>Creates a new SupplierEntity.Address field instance</summary>
		public static EntityField Address
		{
			get { return (EntityField)EntityFieldFactory.Create(SupplierFieldIndex.Address);}
		}
		/// <summary>Creates a new SupplierEntity.City field instance</summary>
		public static EntityField City
		{
			get { return (EntityField)EntityFieldFactory.Create(SupplierFieldIndex.City);}
		}
		/// <summary>Creates a new SupplierEntity.CompanyName field instance</summary>
		public static EntityField CompanyName
		{
			get { return (EntityField)EntityFieldFactory.Create(SupplierFieldIndex.CompanyName);}
		}
		/// <summary>Creates a new SupplierEntity.ContactName field instance</summary>
		public static EntityField ContactName
		{
			get { return (EntityField)EntityFieldFactory.Create(SupplierFieldIndex.ContactName);}
		}
		/// <summary>Creates a new SupplierEntity.ContactTitle field instance</summary>
		public static EntityField ContactTitle
		{
			get { return (EntityField)EntityFieldFactory.Create(SupplierFieldIndex.ContactTitle);}
		}
		/// <summary>Creates a new SupplierEntity.Country field instance</summary>
		public static EntityField Country
		{
			get { return (EntityField)EntityFieldFactory.Create(SupplierFieldIndex.Country);}
		}
		/// <summary>Creates a new SupplierEntity.Fax field instance</summary>
		public static EntityField Fax
		{
			get { return (EntityField)EntityFieldFactory.Create(SupplierFieldIndex.Fax);}
		}
		/// <summary>Creates a new SupplierEntity.HomePage field instance</summary>
		public static EntityField HomePage
		{
			get { return (EntityField)EntityFieldFactory.Create(SupplierFieldIndex.HomePage);}
		}
		/// <summary>Creates a new SupplierEntity.Phone field instance</summary>
		public static EntityField Phone
		{
			get { return (EntityField)EntityFieldFactory.Create(SupplierFieldIndex.Phone);}
		}
		/// <summary>Creates a new SupplierEntity.PostalCode field instance</summary>
		public static EntityField PostalCode
		{
			get { return (EntityField)EntityFieldFactory.Create(SupplierFieldIndex.PostalCode);}
		}
		/// <summary>Creates a new SupplierEntity.Region field instance</summary>
		public static EntityField Region
		{
			get { return (EntityField)EntityFieldFactory.Create(SupplierFieldIndex.Region);}
		}
		/// <summary>Creates a new SupplierEntity.SupplierId field instance</summary>
		public static EntityField SupplierId
		{
			get { return (EntityField)EntityFieldFactory.Create(SupplierFieldIndex.SupplierId);}
		}
	}

	/// <summary>Field Creation Class for entity TerritoryEntity</summary>
	public partial class TerritoryFields
	{
		/// <summary>Creates a new TerritoryEntity.RegionId field instance</summary>
		public static EntityField RegionId
		{
			get { return (EntityField)EntityFieldFactory.Create(TerritoryFieldIndex.RegionId);}
		}
		/// <summary>Creates a new TerritoryEntity.TerritoryDescription field instance</summary>
		public static EntityField TerritoryDescription
		{
			get { return (EntityField)EntityFieldFactory.Create(TerritoryFieldIndex.TerritoryDescription);}
		}
		/// <summary>Creates a new TerritoryEntity.TerritoryId field instance</summary>
		public static EntityField TerritoryId
		{
			get { return (EntityField)EntityFieldFactory.Create(TerritoryFieldIndex.TerritoryId);}
		}
	}

	/// <summary>Field Creation Class for entity UserEntity</summary>
	public partial class UserFields
	{
		/// <summary>Creates a new UserEntity.FullName field instance</summary>
		public static EntityField FullName
		{
			get { return (EntityField)EntityFieldFactory.Create(UserFieldIndex.FullName);}
		}
		/// <summary>Creates a new UserEntity.Password field instance</summary>
		public static EntityField Password
		{
			get { return (EntityField)EntityFieldFactory.Create(UserFieldIndex.Password);}
		}
		/// <summary>Creates a new UserEntity.UserId field instance</summary>
		public static EntityField UserId
		{
			get { return (EntityField)EntityFieldFactory.Create(UserFieldIndex.UserId);}
		}
	}
	

}