﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: Tuesday, 1 February 2022 16:05:05
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.Examples.Auditing.DaoClasses;

namespace SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses
{
	/// <summary>Generic factory for DAO objects.</summary>
	public partial class DAOFactory
	{
		/// <summary>Private CTor, no instantiation possible.</summary>
		private DAOFactory() { }

		/// <summary>Creates a new AuditActionTypeDAO object</summary>
		/// <returns>the new DAO object ready to use for AuditActionType Entities</returns>
		public static AuditActionTypeDAO CreateAuditActionTypeDAO()	{ return new AuditActionTypeDAO(); }

		/// <summary>Creates a new AuditInfoDAO object</summary>
		/// <returns>the new DAO object ready to use for AuditInfo Entities</returns>
		public static AuditInfoDAO CreateAuditInfoDAO()	{ return new AuditInfoDAO(); }

		/// <summary>Creates a new CategoryDAO object</summary>
		/// <returns>the new DAO object ready to use for Category Entities</returns>
		public static CategoryDAO CreateCategoryDAO()	{ return new CategoryDAO(); }

		/// <summary>Creates a new CustomerDAO object</summary>
		/// <returns>the new DAO object ready to use for Customer Entities</returns>
		public static CustomerDAO CreateCustomerDAO()	{ return new CustomerDAO(); }

		/// <summary>Creates a new CustomerCustomerDemoDAO object</summary>
		/// <returns>the new DAO object ready to use for CustomerCustomerDemo Entities</returns>
		public static CustomerCustomerDemoDAO CreateCustomerCustomerDemoDAO()	{ return new CustomerCustomerDemoDAO(); }

		/// <summary>Creates a new CustomerDemographyDAO object</summary>
		/// <returns>the new DAO object ready to use for CustomerDemography Entities</returns>
		public static CustomerDemographyDAO CreateCustomerDemographyDAO()	{ return new CustomerDemographyDAO(); }

		/// <summary>Creates a new EmployeeDAO object</summary>
		/// <returns>the new DAO object ready to use for Employee Entities</returns>
		public static EmployeeDAO CreateEmployeeDAO()	{ return new EmployeeDAO(); }

		/// <summary>Creates a new EmployeeTerritoryDAO object</summary>
		/// <returns>the new DAO object ready to use for EmployeeTerritory Entities</returns>
		public static EmployeeTerritoryDAO CreateEmployeeTerritoryDAO()	{ return new EmployeeTerritoryDAO(); }

		/// <summary>Creates a new OrderDAO object</summary>
		/// <returns>the new DAO object ready to use for Order Entities</returns>
		public static OrderDAO CreateOrderDAO()	{ return new OrderDAO(); }

		/// <summary>Creates a new OrderAuditInfoDAO object</summary>
		/// <returns>the new DAO object ready to use for OrderAuditInfo Entities</returns>
		public static OrderAuditInfoDAO CreateOrderAuditInfoDAO()	{ return new OrderAuditInfoDAO(); }

		/// <summary>Creates a new OrderDetailDAO object</summary>
		/// <returns>the new DAO object ready to use for OrderDetail Entities</returns>
		public static OrderDetailDAO CreateOrderDetailDAO()	{ return new OrderDetailDAO(); }

		/// <summary>Creates a new ProductDAO object</summary>
		/// <returns>the new DAO object ready to use for Product Entities</returns>
		public static ProductDAO CreateProductDAO()	{ return new ProductDAO(); }

		/// <summary>Creates a new RegionDAO object</summary>
		/// <returns>the new DAO object ready to use for Region Entities</returns>
		public static RegionDAO CreateRegionDAO()	{ return new RegionDAO(); }

		/// <summary>Creates a new ShipperDAO object</summary>
		/// <returns>the new DAO object ready to use for Shipper Entities</returns>
		public static ShipperDAO CreateShipperDAO()	{ return new ShipperDAO(); }

		/// <summary>Creates a new SupplierDAO object</summary>
		/// <returns>the new DAO object ready to use for Supplier Entities</returns>
		public static SupplierDAO CreateSupplierDAO()	{ return new SupplierDAO(); }

		/// <summary>Creates a new TerritoryDAO object</summary>
		/// <returns>the new DAO object ready to use for Territory Entities</returns>
		public static TerritoryDAO CreateTerritoryDAO()	{ return new TerritoryDAO(); }

		/// <summary>Creates a new UserDAO object</summary>
		/// <returns>the new DAO object ready to use for User Entities</returns>
		public static UserDAO CreateUserDAO()	{ return new UserDAO(); }

		/// <summary>Creates a new TypedListDAO object</summary>
		/// <returns>The new DAO object ready to use for Typed Lists</returns>
		public static TypedListDAO CreateTypedListDAO()
		{
			return new TypedListDAO();
		}

	}
}
