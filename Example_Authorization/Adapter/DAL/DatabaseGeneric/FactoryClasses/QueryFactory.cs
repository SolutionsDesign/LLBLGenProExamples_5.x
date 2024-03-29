﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: Tuesday, 1 February 2022 16:15:36
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
////////////////////////////////////////////////////////////// 
using System;
using System.Linq;
using SD.LLBLGen.Pro.Examples.Authorization.EntityClasses;
using SD.LLBLGen.Pro.Examples.Authorization.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec.AdapterSpecific;
using SD.LLBLGen.Pro.QuerySpec;

namespace SD.LLBLGen.Pro.Examples.Authorization.FactoryClasses
{
	/// <summary>Factory class to produce DynamicQuery instances and EntityQuery instances</summary>
	public partial class QueryFactory : QueryFactoryBase2
	{
		/// <summary>Creates and returns a new EntityQuery for the Customers entity</summary>
		public EntityQuery<CustomersEntity> Customers { get { return Create<CustomersEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Employees entity</summary>
		public EntityQuery<EmployeesEntity> Employees { get { return Create<EmployeesEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Group entity</summary>
		public EntityQuery<GroupEntity> Group { get { return Create<GroupEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the OrderDetails entity</summary>
		public EntityQuery<OrderDetailsEntity> OrderDetails { get { return Create<OrderDetailsEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Orders entity</summary>
		public EntityQuery<OrdersEntity> Orders { get { return Create<OrdersEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the User entity</summary>
		public EntityQuery<UserEntity> User { get { return Create<UserEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the UserGroup entity</summary>
		public EntityQuery<UserGroupEntity> UserGroup { get { return Create<UserGroupEntity>(); } }

		/// <inheritdoc/>
		protected override IElementCreatorCore CreateElementCreator() { return new ElementCreator(); }
 
	}
}