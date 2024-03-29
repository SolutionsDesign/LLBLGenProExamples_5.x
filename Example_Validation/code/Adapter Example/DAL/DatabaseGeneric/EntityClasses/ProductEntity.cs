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

	/// <summary>Entity class which represents the entity 'Product'.<br/><br/></summary>
	[Serializable]
	public partial class ProductEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		private EntityCollection<OrderDetailEntity> _orderDetails;
		private EntityCollection<OrderEntity> _orderCollectionViaOrderDetails;
		private CategoryEntity _category;
		private SupplierEntity _supplier;
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static ProductEntityStaticMetaData _staticMetaData = new ProductEntityStaticMetaData();
		private static ProductRelations _relationsFactory = new ProductRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Category</summary>
			public static readonly string Category = "Category";
			/// <summary>Member name Supplier</summary>
			public static readonly string Supplier = "Supplier";
			/// <summary>Member name OrderDetails</summary>
			public static readonly string OrderDetails = "OrderDetails";
			/// <summary>Member name OrderCollectionViaOrderDetails</summary>
			public static readonly string OrderCollectionViaOrderDetails = "OrderCollectionViaOrderDetails";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class ProductEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public ProductEntityStaticMetaData()
			{
				SetEntityCoreInfo("ProductEntity", InheritanceHierarchyType.None, false, (int)SD.LLBLGen.Pro.Examples.EntityType.ProductEntity, typeof(ProductEntity), typeof(ProductEntityFactory), false);
				AddNavigatorMetaData<ProductEntity, EntityCollection<OrderDetailEntity>>("OrderDetails", a => a._orderDetails, (a, b) => a._orderDetails = b, a => a.OrderDetails, () => new ProductRelations().OrderDetailEntityUsingProductId, typeof(OrderDetailEntity), (int)SD.LLBLGen.Pro.Examples.EntityType.OrderDetailEntity);
				AddNavigatorMetaData<ProductEntity, CategoryEntity>("Category", "Products", (a, b) => a._category = b, a => a._category, (a, b) => a.Category = b, SD.LLBLGen.Pro.Examples.RelationClasses.StaticProductRelations.CategoryEntityUsingCategoryIdStatic, ()=>new ProductRelations().CategoryEntityUsingCategoryId, null, new int[] { (int)ProductFieldIndex.CategoryId }, null, true, (int)SD.LLBLGen.Pro.Examples.EntityType.CategoryEntity);
				AddNavigatorMetaData<ProductEntity, SupplierEntity>("Supplier", "Products", (a, b) => a._supplier = b, a => a._supplier, (a, b) => a.Supplier = b, SD.LLBLGen.Pro.Examples.RelationClasses.StaticProductRelations.SupplierEntityUsingSupplierIdStatic, ()=>new ProductRelations().SupplierEntityUsingSupplierId, null, new int[] { (int)ProductFieldIndex.SupplierId }, null, true, (int)SD.LLBLGen.Pro.Examples.EntityType.SupplierEntity);
				AddNavigatorMetaData<ProductEntity, EntityCollection<OrderEntity>>("OrderCollectionViaOrderDetails", a => a._orderCollectionViaOrderDetails, (a, b) => a._orderCollectionViaOrderDetails = b, a => a.OrderCollectionViaOrderDetails, () => new ProductRelations().OrderDetailEntityUsingProductId, () => new OrderDetailRelations().OrderEntityUsingOrderId, "ProductEntity__", "OrderDetail_", typeof(OrderEntity), (int)SD.LLBLGen.Pro.Examples.EntityType.OrderEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static ProductEntity()
		{
		}

		/// <summary> CTor</summary>
		public ProductEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ProductEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ProductEntity</param>
		public ProductEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		public ProductEntity(System.Int32 productId) : this(productId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="validator">The custom validator object for this ProductEntity</param>
		public ProductEntity(System.Int32 productId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.ProductId = productId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'OrderDetail' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoOrderDetails() { return CreateRelationInfoForNavigator("OrderDetails"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Order' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoOrderCollectionViaOrderDetails() { return CreateRelationInfoForNavigator("OrderCollectionViaOrderDetails"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Category' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCategory() { return CreateRelationInfoForNavigator("Category"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Supplier' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSupplier() { return CreateRelationInfoForNavigator("Supplier"); }
		
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
		/// <param name="validator">The validator object for this ProductEntity</param>
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
		public static ProductRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'OrderDetail' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathOrderDetails { get { return _staticMetaData.GetPrefetchPathElement("OrderDetails", CommonEntityBase.CreateEntityCollection<OrderDetailEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Order' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathOrderCollectionViaOrderDetails { get { return _staticMetaData.GetPrefetchPathElement("OrderCollectionViaOrderDetails", CommonEntityBase.CreateEntityCollection<OrderEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Category' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCategory { get { return _staticMetaData.GetPrefetchPathElement("Category", CommonEntityBase.CreateEntityCollection<CategoryEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Supplier' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSupplier { get { return _staticMetaData.GetPrefetchPathElement("Supplier", CommonEntityBase.CreateEntityCollection<SupplierEntity>()); } }

		/// <summary>The CategoryId property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."CategoryID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> CategoryId
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductFieldIndex.CategoryId, false); }
			set	{ SetValue((int)ProductFieldIndex.CategoryId, value); }
		}

		/// <summary>The Discontinued property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."Discontinued".<br/>Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean Discontinued
		{
			get { return (System.Boolean)GetValue((int)ProductFieldIndex.Discontinued, true); }
			set	{ SetValue((int)ProductFieldIndex.Discontinued, value); }
		}

		/// <summary>The ProductId property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."ProductID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ProductId
		{
			get { return (System.Int32)GetValue((int)ProductFieldIndex.ProductId, true); }
			set { SetValue((int)ProductFieldIndex.ProductId, value); }		}

		/// <summary>The ProductName property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."ProductName".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 40.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ProductName
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.ProductName, true); }
			set	{ SetValue((int)ProductFieldIndex.ProductName, value); }
		}

		/// <summary>The QuantityPerUnit property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."QuantityPerUnit".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String QuantityPerUnit
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.QuantityPerUnit, true); }
			set	{ SetValue((int)ProductFieldIndex.QuantityPerUnit, value); }
		}

		/// <summary>The ReorderLevel property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."ReorderLevel".<br/>Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int16> ReorderLevel
		{
			get { return (Nullable<System.Int16>)GetValue((int)ProductFieldIndex.ReorderLevel, false); }
			set	{ SetValue((int)ProductFieldIndex.ReorderLevel, value); }
		}

		/// <summary>The SupplierId property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."SupplierID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> SupplierId
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductFieldIndex.SupplierId, false); }
			set	{ SetValue((int)ProductFieldIndex.SupplierId, value); }
		}

		/// <summary>The UnitPrice property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."UnitPrice".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> UnitPrice
		{
			get { return (Nullable<System.Decimal>)GetValue((int)ProductFieldIndex.UnitPrice, false); }
			set	{ SetValue((int)ProductFieldIndex.UnitPrice, value); }
		}

		/// <summary>The UnitsInStock property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."UnitsInStock".<br/>Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int16> UnitsInStock
		{
			get { return (Nullable<System.Int16>)GetValue((int)ProductFieldIndex.UnitsInStock, false); }
			set	{ SetValue((int)ProductFieldIndex.UnitsInStock, value); }
		}

		/// <summary>The UnitsOnOrder property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."UnitsOnOrder".<br/>Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int16> UnitsOnOrder
		{
			get { return (Nullable<System.Int16>)GetValue((int)ProductFieldIndex.UnitsOnOrder, false); }
			set	{ SetValue((int)ProductFieldIndex.UnitsOnOrder, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'OrderDetailEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(OrderDetailEntity))]
		public virtual EntityCollection<OrderDetailEntity> OrderDetails { get { return GetOrCreateEntityCollection<OrderDetailEntity, OrderDetailEntityFactory>("Product", true, false, ref _orderDetails); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'OrderEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(OrderEntity))]
		public virtual EntityCollection<OrderEntity> OrderCollectionViaOrderDetails { get { return GetOrCreateEntityCollection<OrderEntity, OrderEntityFactory>("ProductCollectionViaOrderDetails", false, true, ref _orderCollectionViaOrderDetails); } }

		/// <summary>Gets / sets related entity of type 'CategoryEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual CategoryEntity Category
		{
			get { return _category; }
			set { SetSingleRelatedEntityNavigator(value, "Category"); }
		}

		/// <summary>Gets / sets related entity of type 'SupplierEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual SupplierEntity Supplier
		{
			get { return _supplier; }
			set { SetSingleRelatedEntityNavigator(value, "Supplier"); }
		}
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace SD.LLBLGen.Pro.Examples
{
	public enum ProductFieldIndex
	{
		///<summary>CategoryId. </summary>
		CategoryId,
		///<summary>Discontinued. </summary>
		Discontinued,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>ProductName. </summary>
		ProductName,
		///<summary>QuantityPerUnit. </summary>
		QuantityPerUnit,
		///<summary>ReorderLevel. </summary>
		ReorderLevel,
		///<summary>SupplierId. </summary>
		SupplierId,
		///<summary>UnitPrice. </summary>
		UnitPrice,
		///<summary>UnitsInStock. </summary>
		UnitsInStock,
		///<summary>UnitsOnOrder. </summary>
		UnitsOnOrder,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace SD.LLBLGen.Pro.Examples.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Product. </summary>
	public partial class ProductRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between ProductEntity and OrderDetailEntity over the 1:n relation they have, using the relation between the fields: Product.ProductId - OrderDetail.ProductId</summary>
		public virtual IEntityRelation OrderDetailEntityUsingProductId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "OrderDetails", true, new[] { ProductFields.ProductId, OrderDetailFields.ProductId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and CategoryEntity over the m:1 relation they have, using the relation between the fields: Product.CategoryId - Category.CategoryId</summary>
		public virtual IEntityRelation CategoryEntityUsingCategoryId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Category", false, new[] { CategoryFields.CategoryId, ProductFields.CategoryId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and SupplierEntity over the m:1 relation they have, using the relation between the fields: Product.SupplierId - Supplier.SupplierId</summary>
		public virtual IEntityRelation SupplierEntityUsingSupplierId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Supplier", false, new[] { SupplierFields.SupplierId, ProductFields.SupplierId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticProductRelations
	{
		internal static readonly IEntityRelation OrderDetailEntityUsingProductIdStatic = new ProductRelations().OrderDetailEntityUsingProductId;
		internal static readonly IEntityRelation CategoryEntityUsingCategoryIdStatic = new ProductRelations().CategoryEntityUsingCategoryId;
		internal static readonly IEntityRelation SupplierEntityUsingSupplierIdStatic = new ProductRelations().SupplierEntityUsingSupplierId;

		/// <summary>CTor</summary>
		static StaticProductRelations() { }
	}
}
