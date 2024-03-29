﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: Tuesday, 1 February 2022 15:54:55
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.Auditing.HelperClasses
{
	/// <summary>Field Creation Class for entity AuditActionTypeEntity</summary>
	public partial class AuditActionTypeFields
	{
		/// <summary>Creates a new AuditActionTypeEntity.AuditActionTypeId field instance</summary>
		public static EntityField2 AuditActionTypeId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(AuditActionTypeFieldIndex.AuditActionTypeId); }}
		/// <summary>Creates a new AuditActionTypeEntity.Name field instance</summary>
		public static EntityField2 Name { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(AuditActionTypeFieldIndex.Name); }}
	}

	/// <summary>Field Creation Class for entity AuditInfoEntity</summary>
	public partial class AuditInfoFields
	{
		/// <summary>Creates a new AuditInfoEntity.ActionData field instance</summary>
		public static EntityField2 ActionData { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(AuditInfoFieldIndex.ActionData); }}
		/// <summary>Creates a new AuditInfoEntity.ActionDateTime field instance</summary>
		public static EntityField2 ActionDateTime { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(AuditInfoFieldIndex.ActionDateTime); }}
		/// <summary>Creates a new AuditInfoEntity.AffectedEntityName field instance</summary>
		public static EntityField2 AffectedEntityName { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(AuditInfoFieldIndex.AffectedEntityName); }}
		/// <summary>Creates a new AuditInfoEntity.AuditActionTypeId field instance</summary>
		public static EntityField2 AuditActionTypeId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(AuditInfoFieldIndex.AuditActionTypeId); }}
		/// <summary>Creates a new AuditInfoEntity.AuditInfoId field instance</summary>
		public static EntityField2 AuditInfoId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(AuditInfoFieldIndex.AuditInfoId); }}
		/// <summary>Creates a new AuditInfoEntity.UserId field instance</summary>
		public static EntityField2 UserId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(AuditInfoFieldIndex.UserId); }}
	}

	/// <summary>Field Creation Class for entity CategoryEntity</summary>
	public partial class CategoryFields
	{
		/// <summary>Creates a new CategoryEntity.CategoryId field instance</summary>
		public static EntityField2 CategoryId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CategoryFieldIndex.CategoryId); }}
		/// <summary>Creates a new CategoryEntity.CategoryName field instance</summary>
		public static EntityField2 CategoryName { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CategoryFieldIndex.CategoryName); }}
		/// <summary>Creates a new CategoryEntity.Description field instance</summary>
		public static EntityField2 Description { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CategoryFieldIndex.Description); }}
		/// <summary>Creates a new CategoryEntity.Picture field instance</summary>
		public static EntityField2 Picture { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CategoryFieldIndex.Picture); }}
	}

	/// <summary>Field Creation Class for entity CustomerEntity</summary>
	public partial class CustomerFields
	{
		/// <summary>Creates a new CustomerEntity.Address field instance</summary>
		public static EntityField2 Address { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CustomerFieldIndex.Address); }}
		/// <summary>Creates a new CustomerEntity.City field instance</summary>
		public static EntityField2 City { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CustomerFieldIndex.City); }}
		/// <summary>Creates a new CustomerEntity.CompanyName field instance</summary>
		public static EntityField2 CompanyName { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CustomerFieldIndex.CompanyName); }}
		/// <summary>Creates a new CustomerEntity.ContactName field instance</summary>
		public static EntityField2 ContactName { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CustomerFieldIndex.ContactName); }}
		/// <summary>Creates a new CustomerEntity.ContactTitle field instance</summary>
		public static EntityField2 ContactTitle { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CustomerFieldIndex.ContactTitle); }}
		/// <summary>Creates a new CustomerEntity.Country field instance</summary>
		public static EntityField2 Country { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CustomerFieldIndex.Country); }}
		/// <summary>Creates a new CustomerEntity.CustomerId field instance</summary>
		public static EntityField2 CustomerId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CustomerFieldIndex.CustomerId); }}
		/// <summary>Creates a new CustomerEntity.Fax field instance</summary>
		public static EntityField2 Fax { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CustomerFieldIndex.Fax); }}
		/// <summary>Creates a new CustomerEntity.Phone field instance</summary>
		public static EntityField2 Phone { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CustomerFieldIndex.Phone); }}
		/// <summary>Creates a new CustomerEntity.PostalCode field instance</summary>
		public static EntityField2 PostalCode { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CustomerFieldIndex.PostalCode); }}
		/// <summary>Creates a new CustomerEntity.Region field instance</summary>
		public static EntityField2 Region { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CustomerFieldIndex.Region); }}
	}

	/// <summary>Field Creation Class for entity CustomerCustomerDemoEntity</summary>
	public partial class CustomerCustomerDemoFields
	{
		/// <summary>Creates a new CustomerCustomerDemoEntity.CustomerId field instance</summary>
		public static EntityField2 CustomerId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CustomerCustomerDemoFieldIndex.CustomerId); }}
		/// <summary>Creates a new CustomerCustomerDemoEntity.CustomerTypeId field instance</summary>
		public static EntityField2 CustomerTypeId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CustomerCustomerDemoFieldIndex.CustomerTypeId); }}
	}

	/// <summary>Field Creation Class for entity CustomerDemographyEntity</summary>
	public partial class CustomerDemographyFields
	{
		/// <summary>Creates a new CustomerDemographyEntity.CustomerDesc field instance</summary>
		public static EntityField2 CustomerDesc { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CustomerDemographyFieldIndex.CustomerDesc); }}
		/// <summary>Creates a new CustomerDemographyEntity.CustomerTypeId field instance</summary>
		public static EntityField2 CustomerTypeId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CustomerDemographyFieldIndex.CustomerTypeId); }}
	}

	/// <summary>Field Creation Class for entity EmployeeEntity</summary>
	public partial class EmployeeFields
	{
		/// <summary>Creates a new EmployeeEntity.Address field instance</summary>
		public static EntityField2 Address { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(EmployeeFieldIndex.Address); }}
		/// <summary>Creates a new EmployeeEntity.BirthDate field instance</summary>
		public static EntityField2 BirthDate { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(EmployeeFieldIndex.BirthDate); }}
		/// <summary>Creates a new EmployeeEntity.City field instance</summary>
		public static EntityField2 City { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(EmployeeFieldIndex.City); }}
		/// <summary>Creates a new EmployeeEntity.Country field instance</summary>
		public static EntityField2 Country { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(EmployeeFieldIndex.Country); }}
		/// <summary>Creates a new EmployeeEntity.EmployeeId field instance</summary>
		public static EntityField2 EmployeeId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(EmployeeFieldIndex.EmployeeId); }}
		/// <summary>Creates a new EmployeeEntity.Extension field instance</summary>
		public static EntityField2 Extension { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(EmployeeFieldIndex.Extension); }}
		/// <summary>Creates a new EmployeeEntity.FirstName field instance</summary>
		public static EntityField2 FirstName { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(EmployeeFieldIndex.FirstName); }}
		/// <summary>Creates a new EmployeeEntity.HireDate field instance</summary>
		public static EntityField2 HireDate { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(EmployeeFieldIndex.HireDate); }}
		/// <summary>Creates a new EmployeeEntity.HomePhone field instance</summary>
		public static EntityField2 HomePhone { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(EmployeeFieldIndex.HomePhone); }}
		/// <summary>Creates a new EmployeeEntity.LastName field instance</summary>
		public static EntityField2 LastName { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(EmployeeFieldIndex.LastName); }}
		/// <summary>Creates a new EmployeeEntity.Notes field instance</summary>
		public static EntityField2 Notes { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(EmployeeFieldIndex.Notes); }}
		/// <summary>Creates a new EmployeeEntity.Photo field instance</summary>
		public static EntityField2 Photo { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(EmployeeFieldIndex.Photo); }}
		/// <summary>Creates a new EmployeeEntity.PhotoPath field instance</summary>
		public static EntityField2 PhotoPath { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(EmployeeFieldIndex.PhotoPath); }}
		/// <summary>Creates a new EmployeeEntity.PostalCode field instance</summary>
		public static EntityField2 PostalCode { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(EmployeeFieldIndex.PostalCode); }}
		/// <summary>Creates a new EmployeeEntity.Region field instance</summary>
		public static EntityField2 Region { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(EmployeeFieldIndex.Region); }}
		/// <summary>Creates a new EmployeeEntity.ReportsTo field instance</summary>
		public static EntityField2 ReportsTo { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(EmployeeFieldIndex.ReportsTo); }}
		/// <summary>Creates a new EmployeeEntity.Title field instance</summary>
		public static EntityField2 Title { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(EmployeeFieldIndex.Title); }}
		/// <summary>Creates a new EmployeeEntity.TitleOfCourtesy field instance</summary>
		public static EntityField2 TitleOfCourtesy { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(EmployeeFieldIndex.TitleOfCourtesy); }}
	}

	/// <summary>Field Creation Class for entity EmployeeTerritoryEntity</summary>
	public partial class EmployeeTerritoryFields
	{
		/// <summary>Creates a new EmployeeTerritoryEntity.EmployeeId field instance</summary>
		public static EntityField2 EmployeeId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(EmployeeTerritoryFieldIndex.EmployeeId); }}
		/// <summary>Creates a new EmployeeTerritoryEntity.TerritoryId field instance</summary>
		public static EntityField2 TerritoryId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(EmployeeTerritoryFieldIndex.TerritoryId); }}
	}

	/// <summary>Field Creation Class for entity OrderEntity</summary>
	public partial class OrderFields
	{
		/// <summary>Creates a new OrderEntity.CustomerId field instance</summary>
		public static EntityField2 CustomerId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderFieldIndex.CustomerId); }}
		/// <summary>Creates a new OrderEntity.EmployeeId field instance</summary>
		public static EntityField2 EmployeeId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderFieldIndex.EmployeeId); }}
		/// <summary>Creates a new OrderEntity.Freight field instance</summary>
		public static EntityField2 Freight { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderFieldIndex.Freight); }}
		/// <summary>Creates a new OrderEntity.OrderDate field instance</summary>
		public static EntityField2 OrderDate { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderFieldIndex.OrderDate); }}
		/// <summary>Creates a new OrderEntity.OrderId field instance</summary>
		public static EntityField2 OrderId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderFieldIndex.OrderId); }}
		/// <summary>Creates a new OrderEntity.RequiredDate field instance</summary>
		public static EntityField2 RequiredDate { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderFieldIndex.RequiredDate); }}
		/// <summary>Creates a new OrderEntity.ShipAddress field instance</summary>
		public static EntityField2 ShipAddress { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderFieldIndex.ShipAddress); }}
		/// <summary>Creates a new OrderEntity.ShipCity field instance</summary>
		public static EntityField2 ShipCity { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderFieldIndex.ShipCity); }}
		/// <summary>Creates a new OrderEntity.ShipCountry field instance</summary>
		public static EntityField2 ShipCountry { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderFieldIndex.ShipCountry); }}
		/// <summary>Creates a new OrderEntity.ShipName field instance</summary>
		public static EntityField2 ShipName { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderFieldIndex.ShipName); }}
		/// <summary>Creates a new OrderEntity.ShippedDate field instance</summary>
		public static EntityField2 ShippedDate { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderFieldIndex.ShippedDate); }}
		/// <summary>Creates a new OrderEntity.ShipPostalCode field instance</summary>
		public static EntityField2 ShipPostalCode { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderFieldIndex.ShipPostalCode); }}
		/// <summary>Creates a new OrderEntity.ShipRegion field instance</summary>
		public static EntityField2 ShipRegion { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderFieldIndex.ShipRegion); }}
		/// <summary>Creates a new OrderEntity.ShipVia field instance</summary>
		public static EntityField2 ShipVia { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderFieldIndex.ShipVia); }}
	}

	/// <summary>Field Creation Class for entity OrderAuditInfoEntity</summary>
	public partial class OrderAuditInfoFields
	{
		/// <summary>Creates a new OrderAuditInfoEntity.ActionData field instance</summary>
		public static EntityField2 ActionData { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderAuditInfoFieldIndex.ActionData); }}
		/// <summary>Creates a new OrderAuditInfoEntity.ActionDateTime field instance</summary>
		public static EntityField2 ActionDateTime { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderAuditInfoFieldIndex.ActionDateTime); }}
		/// <summary>Creates a new OrderAuditInfoEntity.AffectedEntityName field instance</summary>
		public static EntityField2 AffectedEntityName { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderAuditInfoFieldIndex.AffectedEntityName); }}
		/// <summary>Creates a new OrderAuditInfoEntity.AuditActionTypeId field instance</summary>
		public static EntityField2 AuditActionTypeId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderAuditInfoFieldIndex.AuditActionTypeId); }}
		/// <summary>Creates a new OrderAuditInfoEntity.AuditInfoId field instance</summary>
		public static EntityField2 AuditInfoId_AuditInfo { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderAuditInfoFieldIndex.AuditInfoId_AuditInfo); }}
		/// <summary>Creates a new OrderAuditInfoEntity.UserId field instance</summary>
		public static EntityField2 UserId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderAuditInfoFieldIndex.UserId); }}
		/// <summary>Creates a new OrderAuditInfoEntity.AuditInfoId field instance</summary>
		public static EntityField2 AuditInfoId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderAuditInfoFieldIndex.AuditInfoId); }}
		/// <summary>Creates a new OrderAuditInfoEntity.OrderId field instance</summary>
		public static EntityField2 OrderId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderAuditInfoFieldIndex.OrderId); }}
	}

	/// <summary>Field Creation Class for entity OrderDetailEntity</summary>
	public partial class OrderDetailFields
	{
		/// <summary>Creates a new OrderDetailEntity.Discount field instance</summary>
		public static EntityField2 Discount { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderDetailFieldIndex.Discount); }}
		/// <summary>Creates a new OrderDetailEntity.OrderId field instance</summary>
		public static EntityField2 OrderId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderDetailFieldIndex.OrderId); }}
		/// <summary>Creates a new OrderDetailEntity.ProductId field instance</summary>
		public static EntityField2 ProductId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderDetailFieldIndex.ProductId); }}
		/// <summary>Creates a new OrderDetailEntity.Quantity field instance</summary>
		public static EntityField2 Quantity { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderDetailFieldIndex.Quantity); }}
		/// <summary>Creates a new OrderDetailEntity.UnitPrice field instance</summary>
		public static EntityField2 UnitPrice { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderDetailFieldIndex.UnitPrice); }}
	}

	/// <summary>Field Creation Class for entity ProductEntity</summary>
	public partial class ProductFields
	{
		/// <summary>Creates a new ProductEntity.CategoryId field instance</summary>
		public static EntityField2 CategoryId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(ProductFieldIndex.CategoryId); }}
		/// <summary>Creates a new ProductEntity.Discontinued field instance</summary>
		public static EntityField2 Discontinued { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(ProductFieldIndex.Discontinued); }}
		/// <summary>Creates a new ProductEntity.ProductId field instance</summary>
		public static EntityField2 ProductId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(ProductFieldIndex.ProductId); }}
		/// <summary>Creates a new ProductEntity.ProductName field instance</summary>
		public static EntityField2 ProductName { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(ProductFieldIndex.ProductName); }}
		/// <summary>Creates a new ProductEntity.QuantityPerUnit field instance</summary>
		public static EntityField2 QuantityPerUnit { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(ProductFieldIndex.QuantityPerUnit); }}
		/// <summary>Creates a new ProductEntity.ReorderLevel field instance</summary>
		public static EntityField2 ReorderLevel { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(ProductFieldIndex.ReorderLevel); }}
		/// <summary>Creates a new ProductEntity.SupplierId field instance</summary>
		public static EntityField2 SupplierId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(ProductFieldIndex.SupplierId); }}
		/// <summary>Creates a new ProductEntity.UnitPrice field instance</summary>
		public static EntityField2 UnitPrice { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(ProductFieldIndex.UnitPrice); }}
		/// <summary>Creates a new ProductEntity.UnitsInStock field instance</summary>
		public static EntityField2 UnitsInStock { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(ProductFieldIndex.UnitsInStock); }}
		/// <summary>Creates a new ProductEntity.UnitsOnOrder field instance</summary>
		public static EntityField2 UnitsOnOrder { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(ProductFieldIndex.UnitsOnOrder); }}
	}

	/// <summary>Field Creation Class for entity RegionEntity</summary>
	public partial class RegionFields
	{
		/// <summary>Creates a new RegionEntity.RegionDescription field instance</summary>
		public static EntityField2 RegionDescription { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RegionFieldIndex.RegionDescription); }}
		/// <summary>Creates a new RegionEntity.RegionId field instance</summary>
		public static EntityField2 RegionId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RegionFieldIndex.RegionId); }}
	}

	/// <summary>Field Creation Class for entity ShipperEntity</summary>
	public partial class ShipperFields
	{
		/// <summary>Creates a new ShipperEntity.CompanyName field instance</summary>
		public static EntityField2 CompanyName { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(ShipperFieldIndex.CompanyName); }}
		/// <summary>Creates a new ShipperEntity.Phone field instance</summary>
		public static EntityField2 Phone { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(ShipperFieldIndex.Phone); }}
		/// <summary>Creates a new ShipperEntity.ShipperId field instance</summary>
		public static EntityField2 ShipperId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(ShipperFieldIndex.ShipperId); }}
	}

	/// <summary>Field Creation Class for entity SupplierEntity</summary>
	public partial class SupplierFields
	{
		/// <summary>Creates a new SupplierEntity.Address field instance</summary>
		public static EntityField2 Address { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(SupplierFieldIndex.Address); }}
		/// <summary>Creates a new SupplierEntity.City field instance</summary>
		public static EntityField2 City { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(SupplierFieldIndex.City); }}
		/// <summary>Creates a new SupplierEntity.CompanyName field instance</summary>
		public static EntityField2 CompanyName { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(SupplierFieldIndex.CompanyName); }}
		/// <summary>Creates a new SupplierEntity.ContactName field instance</summary>
		public static EntityField2 ContactName { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(SupplierFieldIndex.ContactName); }}
		/// <summary>Creates a new SupplierEntity.ContactTitle field instance</summary>
		public static EntityField2 ContactTitle { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(SupplierFieldIndex.ContactTitle); }}
		/// <summary>Creates a new SupplierEntity.Country field instance</summary>
		public static EntityField2 Country { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(SupplierFieldIndex.Country); }}
		/// <summary>Creates a new SupplierEntity.Fax field instance</summary>
		public static EntityField2 Fax { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(SupplierFieldIndex.Fax); }}
		/// <summary>Creates a new SupplierEntity.HomePage field instance</summary>
		public static EntityField2 HomePage { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(SupplierFieldIndex.HomePage); }}
		/// <summary>Creates a new SupplierEntity.Phone field instance</summary>
		public static EntityField2 Phone { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(SupplierFieldIndex.Phone); }}
		/// <summary>Creates a new SupplierEntity.PostalCode field instance</summary>
		public static EntityField2 PostalCode { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(SupplierFieldIndex.PostalCode); }}
		/// <summary>Creates a new SupplierEntity.Region field instance</summary>
		public static EntityField2 Region { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(SupplierFieldIndex.Region); }}
		/// <summary>Creates a new SupplierEntity.SupplierId field instance</summary>
		public static EntityField2 SupplierId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(SupplierFieldIndex.SupplierId); }}
	}

	/// <summary>Field Creation Class for entity TerritoryEntity</summary>
	public partial class TerritoryFields
	{
		/// <summary>Creates a new TerritoryEntity.RegionId field instance</summary>
		public static EntityField2 RegionId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(TerritoryFieldIndex.RegionId); }}
		/// <summary>Creates a new TerritoryEntity.TerritoryDescription field instance</summary>
		public static EntityField2 TerritoryDescription { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(TerritoryFieldIndex.TerritoryDescription); }}
		/// <summary>Creates a new TerritoryEntity.TerritoryId field instance</summary>
		public static EntityField2 TerritoryId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(TerritoryFieldIndex.TerritoryId); }}
	}

	/// <summary>Field Creation Class for entity UserEntity</summary>
	public partial class UserFields
	{
		/// <summary>Creates a new UserEntity.FullName field instance</summary>
		public static EntityField2 FullName { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.FullName); }}
		/// <summary>Creates a new UserEntity.Password field instance</summary>
		public static EntityField2 Password { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.Password); }}
		/// <summary>Creates a new UserEntity.UserId field instance</summary>
		public static EntityField2 UserId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.UserId); }}
	}
	

}