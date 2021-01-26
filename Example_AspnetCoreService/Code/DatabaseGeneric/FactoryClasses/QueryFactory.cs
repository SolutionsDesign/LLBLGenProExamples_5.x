﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.8.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
////////////////////////////////////////////////////////////// 
using System;
using System.Linq;
using NWService.Dal.EntityClasses;
using NWService.Dal.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec.AdapterSpecific;
using SD.LLBLGen.Pro.QuerySpec;

namespace NWService.Dal.FactoryClasses
{
	/// <summary>Factory class to produce DynamicQuery instances and EntityQuery instances</summary>
	public partial class QueryFactory : QueryFactoryBase2
	{
		/// <summary>Creates and returns a new EntityQuery for the Category entity</summary>
		public EntityQuery<CategoryEntity> Category { get { return Create<CategoryEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Customer entity</summary>
		public EntityQuery<CustomerEntity> Customer { get { return Create<CustomerEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Employee entity</summary>
		public EntityQuery<EmployeeEntity> Employee { get { return Create<EmployeeEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Order entity</summary>
		public EntityQuery<OrderEntity> Order { get { return Create<OrderEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the OrderDetail entity</summary>
		public EntityQuery<OrderDetailEntity> OrderDetail { get { return Create<OrderDetailEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Product entity</summary>
		public EntityQuery<ProductEntity> Product { get { return Create<ProductEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Region entity</summary>
		public EntityQuery<RegionEntity> Region { get { return Create<RegionEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Shipper entity</summary>
		public EntityQuery<ShipperEntity> Shipper { get { return Create<ShipperEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Supplier entity</summary>
		public EntityQuery<SupplierEntity> Supplier { get { return Create<SupplierEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Territory entity</summary>
		public EntityQuery<TerritoryEntity> Territory { get { return Create<TerritoryEntity>(); } }

		/// <inheritdoc/>
		protected override IElementCreatorCore CreateElementCreator() { return new ElementCreator(); }
 
	}
}