﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: Tuesday, 1 February 2022 16:46:57
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
////////////////////////////////////////////////////////////// 
using System;
using System.Linq;
using SD.LLBLGen.Pro.Examples.WCF.EntityClasses;
using SD.LLBLGen.Pro.Examples.WCF.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec.AdapterSpecific;
using SD.LLBLGen.Pro.QuerySpec;

namespace SD.LLBLGen.Pro.Examples.WCF.FactoryClasses
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

		/// <summary>Creates and returns a new EntityQuery for the OrderDetails entity</summary>
		public EntityQuery<OrderDetailsEntity> OrderDetails { get { return Create<OrderDetailsEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Product entity</summary>
		public EntityQuery<ProductEntity> Product { get { return Create<ProductEntity>(); } }

		/// <inheritdoc/>
		protected override IElementCreatorCore CreateElementCreator() { return new ElementCreator(); }
 
	}
}