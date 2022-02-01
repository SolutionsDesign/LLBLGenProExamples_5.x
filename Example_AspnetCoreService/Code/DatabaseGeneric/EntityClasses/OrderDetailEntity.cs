﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using NWService.Dal.HelperClasses;
using NWService.Dal.FactoryClasses;
using NWService.Dal.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NWService.Dal.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'OrderDetail'.<br/><br/></summary>
	[Serializable]
	public partial class OrderDetailEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private OrderEntity _order;
		private ProductEntity _product;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static OrderDetailEntityStaticMetaData _staticMetaData = new OrderDetailEntityStaticMetaData();
		private static OrderDetailRelations _relationsFactory = new OrderDetailRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Order</summary>
			public static readonly string Order = "Order";
			/// <summary>Member name Product</summary>
			public static readonly string Product = "Product";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class OrderDetailEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public OrderDetailEntityStaticMetaData()
			{
				SetEntityCoreInfo("OrderDetailEntity", InheritanceHierarchyType.None, false, (int)NWService.Dal.EntityType.OrderDetailEntity, typeof(OrderDetailEntity), typeof(OrderDetailEntityFactory), false);
				AddNavigatorMetaData<OrderDetailEntity, OrderEntity>("Order", "OrderDetails", (a, b) => a._order = b, a => a._order, (a, b) => a.Order = b, NWService.Dal.RelationClasses.StaticOrderDetailRelations.OrderEntityUsingOrderIdStatic, ()=>new OrderDetailRelations().OrderEntityUsingOrderId, null, new int[] { (int)OrderDetailFieldIndex.OrderId }, null, true, (int)NWService.Dal.EntityType.OrderEntity);
				AddNavigatorMetaData<OrderDetailEntity, ProductEntity>("Product", "OrderDetails", (a, b) => a._product = b, a => a._product, (a, b) => a.Product = b, NWService.Dal.RelationClasses.StaticOrderDetailRelations.ProductEntityUsingProductIdStatic, ()=>new OrderDetailRelations().ProductEntityUsingProductId, null, new int[] { (int)OrderDetailFieldIndex.ProductId }, null, true, (int)NWService.Dal.EntityType.ProductEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static OrderDetailEntity()
		{
		}

		/// <summary> CTor</summary>
		public OrderDetailEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public OrderDetailEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this OrderDetailEntity</param>
		public OrderDetailEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="orderId">PK value for OrderDetail which data should be fetched into this OrderDetail object</param>
		/// <param name="productId">PK value for OrderDetail which data should be fetched into this OrderDetail object</param>
		public OrderDetailEntity(System.Int32 orderId, System.Int32 productId) : this(orderId, productId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="orderId">PK value for OrderDetail which data should be fetched into this OrderDetail object</param>
		/// <param name="productId">PK value for OrderDetail which data should be fetched into this OrderDetail object</param>
		/// <param name="validator">The custom validator object for this OrderDetailEntity</param>
		public OrderDetailEntity(System.Int32 orderId, System.Int32 productId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.OrderId = orderId;
			this.ProductId = productId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected OrderDetailEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Order' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoOrder() { return CreateRelationInfoForNavigator("Order"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Product' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProduct() { return CreateRelationInfoForNavigator("Product"); }
		
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
		/// <param name="validator">The validator object for this OrderDetailEntity</param>
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
		public static OrderDetailRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Order' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathOrder { get { return _staticMetaData.GetPrefetchPathElement("Order", CommonEntityBase.CreateEntityCollection<OrderEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProduct { get { return _staticMetaData.GetPrefetchPathElement("Product", CommonEntityBase.CreateEntityCollection<ProductEntity>()); } }

		/// <summary>The Discount property of the Entity OrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Order Details"."Discount".<br/>Table field type characteristics (type, precision, scale, length): Real, 24, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Single Discount
		{
			get { return (System.Single)GetValue((int)OrderDetailFieldIndex.Discount, true); }
			set	{ SetValue((int)OrderDetailFieldIndex.Discount, value); }
		}

		/// <summary>The OrderId property of the Entity OrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Order Details"."OrderID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 OrderId
		{
			get { return (System.Int32)GetValue((int)OrderDetailFieldIndex.OrderId, true); }
			set	{ SetValue((int)OrderDetailFieldIndex.OrderId, value); }
		}

		/// <summary>The ProductId property of the Entity OrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Order Details"."ProductID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ProductId
		{
			get { return (System.Int32)GetValue((int)OrderDetailFieldIndex.ProductId, true); }
			set	{ SetValue((int)OrderDetailFieldIndex.ProductId, value); }
		}

		/// <summary>The Quantity property of the Entity OrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Order Details"."Quantity".<br/>Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 Quantity
		{
			get { return (System.Int16)GetValue((int)OrderDetailFieldIndex.Quantity, true); }
			set	{ SetValue((int)OrderDetailFieldIndex.Quantity, value); }
		}

		/// <summary>The UnitPrice property of the Entity OrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Order Details"."UnitPrice".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal UnitPrice
		{
			get { return (System.Decimal)GetValue((int)OrderDetailFieldIndex.UnitPrice, true); }
			set	{ SetValue((int)OrderDetailFieldIndex.UnitPrice, value); }
		}

		/// <summary>Gets / sets related entity of type 'OrderEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual OrderEntity Order
		{
			get { return _order; }
			set { SetSingleRelatedEntityNavigator(value, "Order"); }
		}

		/// <summary>Gets / sets related entity of type 'ProductEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ProductEntity Product
		{
			get { return _product; }
			set { SetSingleRelatedEntityNavigator(value, "Product"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace NWService.Dal
{
	public enum OrderDetailFieldIndex
	{
		///<summary>Discount. </summary>
		Discount,
		///<summary>OrderId. </summary>
		OrderId,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>Quantity. </summary>
		Quantity,
		///<summary>UnitPrice. </summary>
		UnitPrice,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace NWService.Dal.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: OrderDetail. </summary>
	public partial class OrderDetailRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between OrderDetailEntity and OrderEntity over the m:1 relation they have, using the relation between the fields: OrderDetail.OrderId - Order.OrderId</summary>
		public virtual IEntityRelation OrderEntityUsingOrderId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Order", false, new[] { OrderFields.OrderId, OrderDetailFields.OrderId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between OrderDetailEntity and ProductEntity over the m:1 relation they have, using the relation between the fields: OrderDetail.ProductId - Product.ProductId</summary>
		public virtual IEntityRelation ProductEntityUsingProductId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Product", false, new[] { ProductFields.ProductId, OrderDetailFields.ProductId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticOrderDetailRelations
	{
		internal static readonly IEntityRelation OrderEntityUsingOrderIdStatic = new OrderDetailRelations().OrderEntityUsingOrderId;
		internal static readonly IEntityRelation ProductEntityUsingProductIdStatic = new OrderDetailRelations().ProductEntityUsingProductId;

		/// <summary>CTor</summary>
		static StaticOrderDetailRelations() { }
	}
}
