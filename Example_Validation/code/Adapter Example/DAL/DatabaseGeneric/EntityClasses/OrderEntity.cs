﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: Tuesday, 1 February 2022 16:34:52
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using SD.LLBLGen.Pro.Examples.HelperClasses;
using SD.LLBLGen.Pro.Examples.FactoryClasses;
using SD.LLBLGen.Pro.Examples.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'Order'.<br/><br/></summary>
	[Serializable]
	public partial class OrderEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		private EntityCollection<OrderDetailEntity> _orderDetails;
		private EntityCollection<ProductEntity> _productCollectionViaOrderDetails;
		private CustomerEntity _customer;
		private EmployeeEntity _employee;
		private ShipperEntity _shipper;
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static OrderEntityStaticMetaData _staticMetaData = new OrderEntityStaticMetaData();
		private static OrderRelations _relationsFactory = new OrderRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Customer</summary>
			public static readonly string Customer = "Customer";
			/// <summary>Member name Employee</summary>
			public static readonly string Employee = "Employee";
			/// <summary>Member name Shipper</summary>
			public static readonly string Shipper = "Shipper";
			/// <summary>Member name OrderDetails</summary>
			public static readonly string OrderDetails = "OrderDetails";
			/// <summary>Member name ProductCollectionViaOrderDetails</summary>
			public static readonly string ProductCollectionViaOrderDetails = "ProductCollectionViaOrderDetails";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class OrderEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public OrderEntityStaticMetaData()
			{
				SetEntityCoreInfo("OrderEntity", InheritanceHierarchyType.None, false, (int)SD.LLBLGen.Pro.Examples.EntityType.OrderEntity, typeof(OrderEntity), typeof(OrderEntityFactory), false);
				AddNavigatorMetaData<OrderEntity, EntityCollection<OrderDetailEntity>>("OrderDetails", a => a._orderDetails, (a, b) => a._orderDetails = b, a => a.OrderDetails, () => new OrderRelations().OrderDetailEntityUsingOrderId, typeof(OrderDetailEntity), (int)SD.LLBLGen.Pro.Examples.EntityType.OrderDetailEntity);
				AddNavigatorMetaData<OrderEntity, CustomerEntity>("Customer", "Orders", (a, b) => a._customer = b, a => a._customer, (a, b) => a.Customer = b, SD.LLBLGen.Pro.Examples.RelationClasses.StaticOrderRelations.CustomerEntityUsingCustomerIdStatic, ()=>new OrderRelations().CustomerEntityUsingCustomerId, null, new int[] { (int)OrderFieldIndex.CustomerId }, null, true, (int)SD.LLBLGen.Pro.Examples.EntityType.CustomerEntity);
				AddNavigatorMetaData<OrderEntity, EmployeeEntity>("Employee", "Orders", (a, b) => a._employee = b, a => a._employee, (a, b) => a.Employee = b, SD.LLBLGen.Pro.Examples.RelationClasses.StaticOrderRelations.EmployeeEntityUsingEmployeeIdStatic, ()=>new OrderRelations().EmployeeEntityUsingEmployeeId, null, new int[] { (int)OrderFieldIndex.EmployeeId }, null, true, (int)SD.LLBLGen.Pro.Examples.EntityType.EmployeeEntity);
				AddNavigatorMetaData<OrderEntity, ShipperEntity>("Shipper", "Orders", (a, b) => a._shipper = b, a => a._shipper, (a, b) => a.Shipper = b, SD.LLBLGen.Pro.Examples.RelationClasses.StaticOrderRelations.ShipperEntityUsingShipViaStatic, ()=>new OrderRelations().ShipperEntityUsingShipVia, null, new int[] { (int)OrderFieldIndex.ShipVia }, null, true, (int)SD.LLBLGen.Pro.Examples.EntityType.ShipperEntity);
				AddNavigatorMetaData<OrderEntity, EntityCollection<ProductEntity>>("ProductCollectionViaOrderDetails", a => a._productCollectionViaOrderDetails, (a, b) => a._productCollectionViaOrderDetails = b, a => a.ProductCollectionViaOrderDetails, () => new OrderRelations().OrderDetailEntityUsingOrderId, () => new OrderDetailRelations().ProductEntityUsingProductId, "OrderEntity__", "OrderDetail_", typeof(ProductEntity), (int)SD.LLBLGen.Pro.Examples.EntityType.ProductEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static OrderEntity()
		{
		}

		/// <summary> CTor</summary>
		public OrderEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public OrderEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this OrderEntity</param>
		public OrderEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="orderId">PK value for Order which data should be fetched into this Order object</param>
		public OrderEntity(System.Int32 orderId) : this(orderId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="orderId">PK value for Order which data should be fetched into this Order object</param>
		/// <param name="validator">The custom validator object for this OrderEntity</param>
		public OrderEntity(System.Int32 orderId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.OrderId = orderId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected OrderEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'OrderDetail' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoOrderDetails() { return CreateRelationInfoForNavigator("OrderDetails"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Product' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductCollectionViaOrderDetails() { return CreateRelationInfoForNavigator("ProductCollectionViaOrderDetails"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Customer' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCustomer() { return CreateRelationInfoForNavigator("Customer"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Employee' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployee() { return CreateRelationInfoForNavigator("Employee"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Shipper' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoShipper() { return CreateRelationInfoForNavigator("Shipper"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this OrderEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END


			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static OrderRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'OrderDetail' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathOrderDetails { get { return _staticMetaData.GetPrefetchPathElement("OrderDetails", CommonEntityBase.CreateEntityCollection<OrderDetailEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductCollectionViaOrderDetails { get { return _staticMetaData.GetPrefetchPathElement("ProductCollectionViaOrderDetails", CommonEntityBase.CreateEntityCollection<ProductEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Customer' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCustomer { get { return _staticMetaData.GetPrefetchPathElement("Customer", CommonEntityBase.CreateEntityCollection<CustomerEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployee { get { return _staticMetaData.GetPrefetchPathElement("Employee", CommonEntityBase.CreateEntityCollection<EmployeeEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Shipper' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathShipper { get { return _staticMetaData.GetPrefetchPathElement("Shipper", CommonEntityBase.CreateEntityCollection<ShipperEntity>()); } }

		/// <summary>The CustomerId property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."CustomerID".<br/>Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 5.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CustomerId
		{
			get { return (System.String)GetValue((int)OrderFieldIndex.CustomerId, true); }
			set	{ SetValue((int)OrderFieldIndex.CustomerId, value); }
		}

		/// <summary>The EmployeeId property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."EmployeeID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> EmployeeId
		{
			get { return (Nullable<System.Int32>)GetValue((int)OrderFieldIndex.EmployeeId, false); }
			set	{ SetValue((int)OrderFieldIndex.EmployeeId, value); }
		}

		/// <summary>The Freight property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."Freight".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Freight
		{
			get { return (Nullable<System.Decimal>)GetValue((int)OrderFieldIndex.Freight, false); }
			set	{ SetValue((int)OrderFieldIndex.Freight, value); }
		}

		/// <summary>The OrderDate property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."OrderDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> OrderDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)OrderFieldIndex.OrderDate, false); }
			set	{ SetValue((int)OrderFieldIndex.OrderDate, value); }
		}

		/// <summary>The OrderId property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."OrderID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 OrderId
		{
			get { return (System.Int32)GetValue((int)OrderFieldIndex.OrderId, true); }
			set { SetValue((int)OrderFieldIndex.OrderId, value); }		}

		/// <summary>The RequiredDate property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."RequiredDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> RequiredDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)OrderFieldIndex.RequiredDate, false); }
			set	{ SetValue((int)OrderFieldIndex.RequiredDate, value); }
		}

		/// <summary>The ShipAddress property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."ShipAddress".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ShipAddress
		{
			get { return (System.String)GetValue((int)OrderFieldIndex.ShipAddress, true); }
			set	{ SetValue((int)OrderFieldIndex.ShipAddress, value); }
		}

		/// <summary>The ShipCity property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."ShipCity".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ShipCity
		{
			get { return (System.String)GetValue((int)OrderFieldIndex.ShipCity, true); }
			set	{ SetValue((int)OrderFieldIndex.ShipCity, value); }
		}

		/// <summary>The ShipCountry property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."ShipCountry".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ShipCountry
		{
			get { return (System.String)GetValue((int)OrderFieldIndex.ShipCountry, true); }
			set	{ SetValue((int)OrderFieldIndex.ShipCountry, value); }
		}

		/// <summary>The ShipName property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."ShipName".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 40.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ShipName
		{
			get { return (System.String)GetValue((int)OrderFieldIndex.ShipName, true); }
			set	{ SetValue((int)OrderFieldIndex.ShipName, value); }
		}

		/// <summary>The ShippedDate property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."ShippedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> ShippedDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)OrderFieldIndex.ShippedDate, false); }
			set	{ SetValue((int)OrderFieldIndex.ShippedDate, value); }
		}

		/// <summary>The ShipPostalCode property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."ShipPostalCode".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ShipPostalCode
		{
			get { return (System.String)GetValue((int)OrderFieldIndex.ShipPostalCode, true); }
			set	{ SetValue((int)OrderFieldIndex.ShipPostalCode, value); }
		}

		/// <summary>The ShipRegion property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."ShipRegion".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ShipRegion
		{
			get { return (System.String)GetValue((int)OrderFieldIndex.ShipRegion, true); }
			set	{ SetValue((int)OrderFieldIndex.ShipRegion, value); }
		}

		/// <summary>The ShipVia property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."ShipVia".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ShipVia
		{
			get { return (Nullable<System.Int32>)GetValue((int)OrderFieldIndex.ShipVia, false); }
			set	{ SetValue((int)OrderFieldIndex.ShipVia, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'OrderDetailEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(OrderDetailEntity))]
		public virtual EntityCollection<OrderDetailEntity> OrderDetails { get { return GetOrCreateEntityCollection<OrderDetailEntity, OrderDetailEntityFactory>("Order", true, false, ref _orderDetails); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'ProductEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductEntity))]
		public virtual EntityCollection<ProductEntity> ProductCollectionViaOrderDetails { get { return GetOrCreateEntityCollection<ProductEntity, ProductEntityFactory>("OrderCollectionViaOrderDetails", false, true, ref _productCollectionViaOrderDetails); } }

		/// <summary>Gets / sets related entity of type 'CustomerEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual CustomerEntity Customer
		{
			get { return _customer; }
			set { SetSingleRelatedEntityNavigator(value, "Customer"); }
		}

		/// <summary>Gets / sets related entity of type 'EmployeeEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual EmployeeEntity Employee
		{
			get { return _employee; }
			set { SetSingleRelatedEntityNavigator(value, "Employee"); }
		}

		/// <summary>Gets / sets related entity of type 'ShipperEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual ShipperEntity Shipper
		{
			get { return _shipper; }
			set { SetSingleRelatedEntityNavigator(value, "Shipper"); }
		}
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace SD.LLBLGen.Pro.Examples
{
	public enum OrderFieldIndex
	{
		///<summary>CustomerId. </summary>
		CustomerId,
		///<summary>EmployeeId. </summary>
		EmployeeId,
		///<summary>Freight. </summary>
		Freight,
		///<summary>OrderDate. </summary>
		OrderDate,
		///<summary>OrderId. </summary>
		OrderId,
		///<summary>RequiredDate. </summary>
		RequiredDate,
		///<summary>ShipAddress. </summary>
		ShipAddress,
		///<summary>ShipCity. </summary>
		ShipCity,
		///<summary>ShipCountry. </summary>
		ShipCountry,
		///<summary>ShipName. </summary>
		ShipName,
		///<summary>ShippedDate. </summary>
		ShippedDate,
		///<summary>ShipPostalCode. </summary>
		ShipPostalCode,
		///<summary>ShipRegion. </summary>
		ShipRegion,
		///<summary>ShipVia. </summary>
		ShipVia,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace SD.LLBLGen.Pro.Examples.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Order. </summary>
	public partial class OrderRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between OrderEntity and OrderDetailEntity over the 1:n relation they have, using the relation between the fields: Order.OrderId - OrderDetail.OrderId</summary>
		public virtual IEntityRelation OrderDetailEntityUsingOrderId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "OrderDetails", true, new[] { OrderFields.OrderId, OrderDetailFields.OrderId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between OrderEntity and CustomerEntity over the m:1 relation they have, using the relation between the fields: Order.CustomerId - Customer.CustomerId</summary>
		public virtual IEntityRelation CustomerEntityUsingCustomerId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Customer", false, new[] { CustomerFields.CustomerId, OrderFields.CustomerId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between OrderEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields: Order.EmployeeId - Employee.EmployeeId</summary>
		public virtual IEntityRelation EmployeeEntityUsingEmployeeId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Employee", false, new[] { EmployeeFields.EmployeeId, OrderFields.EmployeeId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between OrderEntity and ShipperEntity over the m:1 relation they have, using the relation between the fields: Order.ShipVia - Shipper.ShipperId</summary>
		public virtual IEntityRelation ShipperEntityUsingShipVia
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Shipper", false, new[] { ShipperFields.ShipperId, OrderFields.ShipVia }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticOrderRelations
	{
		internal static readonly IEntityRelation OrderDetailEntityUsingOrderIdStatic = new OrderRelations().OrderDetailEntityUsingOrderId;
		internal static readonly IEntityRelation CustomerEntityUsingCustomerIdStatic = new OrderRelations().CustomerEntityUsingCustomerId;
		internal static readonly IEntityRelation EmployeeEntityUsingEmployeeIdStatic = new OrderRelations().EmployeeEntityUsingEmployeeId;
		internal static readonly IEntityRelation ShipperEntityUsingShipViaStatic = new OrderRelations().ShipperEntityUsingShipVia;

		/// <summary>CTor</summary>
		static StaticOrderRelations() { }
	}
}
