﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: Tuesday, 1 February 2022 16:05:06
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses;
using SD.LLBLGen.Pro.Examples.Auditing.DaoClasses;
using SD.LLBLGen.Pro.Examples.Auditing.RelationClasses;
using SD.LLBLGen.Pro.Examples.Auditing.HelperClasses;
using SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.Auditing.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'Product'. <br/><br/></summary>
	[Serializable]
	public partial class ProductEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderDetailCollection	_orderDetails;
		private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection _ordersCollectionViaOrderDetails;
		private CategoryEntity _categories;
		private bool	_categoriesReturnsNewIfNotFound;
		private SupplierEntity _suppliers;
		private bool	_suppliersReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static ProductEntityStaticMetaData _staticMetaData = new ProductEntityStaticMetaData();
		private static ProductRelations _relationsFactory = new ProductRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Categories</summary>
			public static readonly string Categories = "Categories";
			/// <summary>Member name Suppliers</summary>
			public static readonly string Suppliers = "Suppliers";
			/// <summary>Member name OrderDetails</summary>
			public static readonly string OrderDetails = "OrderDetails";
			/// <summary>Member name OrdersCollectionViaOrderDetails</summary>
			public static readonly string OrdersCollectionViaOrderDetails = "OrdersCollectionViaOrderDetails";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class ProductEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public ProductEntityStaticMetaData()
			{
				SetEntityCoreInfo("ProductEntity", InheritanceHierarchyType.None, false, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.ProductEntity, typeof(ProductEntity), typeof(ProductEntityFactory), false);
				AddNavigatorMetaData<ProductEntity, SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderDetailCollection>("OrderDetails", a => a._orderDetails, (a, b) => a._orderDetails = b, a => a.OrderDetails, () => new ProductRelations().OrderDetailEntityUsingProductId, typeof(OrderDetailEntity), (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.OrderDetailEntity);
				AddNavigatorMetaData<ProductEntity, CategoryEntity>("Categories", "Products", (a, b) => a._categories = b, a => a._categories, (a, b) => a.Categories = b, SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticProductRelations.CategoryEntityUsingCategoryIdStatic, ()=>new ProductRelations().CategoryEntityUsingCategoryId, null, new int[] { (int)ProductFieldIndex.CategoryId }, null, true, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.CategoryEntity);
				AddNavigatorMetaData<ProductEntity, SupplierEntity>("Suppliers", "Products", (a, b) => a._suppliers = b, a => a._suppliers, (a, b) => a.Suppliers = b, SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticProductRelations.SupplierEntityUsingSupplierIdStatic, ()=>new ProductRelations().SupplierEntityUsingSupplierId, null, new int[] { (int)ProductFieldIndex.SupplierId }, null, true, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.SupplierEntity);
				AddNavigatorMetaData<ProductEntity, SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection>("OrdersCollectionViaOrderDetails", a => a._ordersCollectionViaOrderDetails, (a, b) => a._ordersCollectionViaOrderDetails = b, a => a.OrdersCollectionViaOrderDetails, () => new ProductRelations().OrderDetailEntityUsingProductId, () => new OrderDetailRelations().OrderEntityUsingOrderId, "ProductEntity__", "OrderDetail_", typeof(OrderEntity), (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.OrderEntity);
			}
		}
		
		/// <summary>Static ctor</summary>
		static ProductEntity()
		{
		}

		/// <summary>CTor</summary>
		public ProductEntity() :base()
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		public ProductEntity(System.Int32 productId)
		{
			InitClassFetch(productId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ProductEntity(System.Int32 productId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(productId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="validator">The custom validator object for this ProductEntity</param>
		public ProductEntity(System.Int32 productId, IValidator validator)
		{
			InitClassFetch(productId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductEntity(SerializationInfo info, StreamingContext context):base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}



		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productId)
		{
			return FetchUsingPK(productId, null, null, null);
		}

		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(productId, prefetchPathToUse, null, null);
		}

		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(productId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(productId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <inheritdoc/>
		public override bool Refetch()
		{
			return Fetch(this.ProductId, null, null, null);
		}

		/// <summary>Retrieves all related entities of type 'OrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'OrderDetailEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderDetailCollection GetMultiOrderDetails(bool forceFetch)
		{
			return GetMultiOrderDetails(forceFetch, _orderDetails.EntityFactoryToUse, null);
		}

		/// <summary>Retrieves all related entities of type 'OrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'OrderDetailEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderDetailCollection GetMultiOrderDetails(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiOrderDetails(forceFetch, _orderDetails.EntityFactoryToUse, filter);
		}

		/// <summary>Retrieves all related entities of type 'OrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderDetailCollection GetMultiOrderDetails(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiOrderDetails(forceFetch, entityFactoryToUse, null);
		}

		/// <summary>Retrieves all related entities of type 'OrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderDetailCollection GetMultiOrderDetails(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
			return PerformMultiEntityLazyLoading<SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderDetailCollection>("OrderDetails", forceFetch, entityFactoryToUse, (c,r)=>c.GetMultiManyToOne(null, this, filter));
		}

		/// <summary>Sets the collection parameters for the collection for 'OrderDetails'. These settings will be taken into account
		/// when the property OrderDetails is requested or GetMultiOrderDetails is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersOrderDetails(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_orderDetails.SortClauses=sortClauses;
			_orderDetails.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary>Retrieves all related entities of type 'OrderEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'OrderEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection GetMultiOrdersCollectionViaOrderDetails(bool forceFetch)
		{
			return GetMultiOrdersCollectionViaOrderDetails(forceFetch, _ordersCollectionViaOrderDetails.EntityFactoryToUse);
		}

		/// <summary>Retrieves all related entities of type 'OrderEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection GetMultiOrdersCollectionViaOrderDetails(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			var filter = new PredicateExpression();
			filter.Add(new FieldCompareValuePredicate(ProductFields.ProductId, ComparisonOperator.Equal, this.ProductId, "ProductEntity__"));
			return PerformMultiEntityLazyLoading<SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection>("OrdersCollectionViaOrderDetails", forceFetch, entityFactoryToUse, (c,r)=>c.GetMulti(filter, r));
		}

		/// <summary>Sets the collection parameters for the collection for 'OrdersCollectionViaOrderDetails'. These settings will be taken into account
		/// when the property OrdersCollectionViaOrderDetails is requested or GetMultiOrdersCollectionViaOrderDetails is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersOrdersCollectionViaOrderDetails(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_ordersCollectionViaOrderDetails.SortClauses=sortClauses;
			_ordersCollectionViaOrderDetails.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary>Retrieves the related entity of type 'CategoryEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CategoryEntity' which is related to this entity.</returns>
		public virtual CategoryEntity GetSingleCategories(bool forceFetch=false)
		{
			return PerformSingleEntityLazyLoading<CategoryEntity>("Categories", forceFetch, _categoriesReturnsNewIfNotFound, e=>e.FetchUsingPK(this.CategoryId.GetValueOrDefault()));
		}

		/// <summary>Retrieves the related entity of type 'SupplierEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'SupplierEntity' which is related to this entity.</returns>
		public virtual SupplierEntity GetSingleSuppliers(bool forceFetch=false)
		{
			return PerformSingleEntityLazyLoading<SupplierEntity>("Suppliers", forceFetch, _suppliersReturnsNewIfNotFound, e=>e.FetchUsingPK(this.SupplierId.GetValueOrDefault()));
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		private void InitClassEmpty(IValidator validatorToUse)
		{
			OnInitializing();
			this.Fields = CreateFields();
			this.Validator = validatorToUse;
			InitClassMembers();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}		

		/// <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="validator">The validator object for this ProductEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 productId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(productId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			_orderDetails = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderDetailCollection();
			_orderDetails.SetContainingEntityInfo(this, "Products");
			_ordersCollectionViaOrderDetails = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection();
			_categoriesReturnsNewIfNotFound = true;
			_suppliersReturnsNewIfNotFound = true;
			PerformDependencyInjection();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}


		/// <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 productId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)ProductFieldIndex.ProductId].ForcedCurrentValueWrite(productId);
				CreateDAOInstance().FetchExisting(this, this.Transaction, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (this.Fields.State == EntityState.Fetched);
			}
			finally
			{
				OnFetchComplete();
			}
		}

		/// <summary>Creates the DAO instance for this type</summary>
		/// <returns></returns>
		protected override IDao CreateDAOInstance() { return DAOFactory.CreateProductDAO(); }
		
		/// <summary>Gets the entity static meta data instance from the generated type.</summary>
		/// <returns>The instance requested</returns>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() { return _staticMetaData; }
		
		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static ProductRelations Relations { get { return _relationsFactory; } }


		/// <summary>Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OrderDetail' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathOrderDetails { get { return _staticMetaData.GetPrefetchPathElement("OrderDetails", new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderDetailCollection()); } }

		/// <summary>Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Order'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathOrdersCollectionViaOrderDetails { get { return _staticMetaData.GetPrefetchPathElement("OrdersCollectionViaOrderDetails", new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection()); } }

		/// <summary>Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Category'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCategories { get { return _staticMetaData.GetPrefetchPathElement("Categories", new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CategoryCollection()); } }

		/// <summary>Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Supplier'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSuppliers { get { return _staticMetaData.GetPrefetchPathElement("Suppliers", new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.SupplierCollection()); } }


		/// <summary>The CategoryId property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."CategoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> CategoryId
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductFieldIndex.CategoryId, false); }
			set	{ SetValue((int)ProductFieldIndex.CategoryId, value, true); }
		}

		/// <summary>The Discontinued property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."Discontinued"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean Discontinued
		{
			get { return (System.Boolean)GetValue((int)ProductFieldIndex.Discontinued, true); }
			set	{ SetValue((int)ProductFieldIndex.Discontinued, value, true); }
		}

		/// <summary>The ProductId property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."ProductID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ProductId
		{
			get { return (System.Int32)GetValue((int)ProductFieldIndex.ProductId, true); }
			set	{ SetValue((int)ProductFieldIndex.ProductId, value, true); }
		}

		/// <summary>The ProductName property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."ProductName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 40<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ProductName
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.ProductName, true); }
			set	{ SetValue((int)ProductFieldIndex.ProductName, value, true); }
		}

		/// <summary>The QuantityPerUnit property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."QuantityPerUnit"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String QuantityPerUnit
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.QuantityPerUnit, true); }
			set	{ SetValue((int)ProductFieldIndex.QuantityPerUnit, value, true); }
		}

		/// <summary>The ReorderLevel property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."ReorderLevel"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int16> ReorderLevel
		{
			get { return (Nullable<System.Int16>)GetValue((int)ProductFieldIndex.ReorderLevel, false); }
			set	{ SetValue((int)ProductFieldIndex.ReorderLevel, value, true); }
		}

		/// <summary>The SupplierId property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."SupplierID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> SupplierId
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductFieldIndex.SupplierId, false); }
			set	{ SetValue((int)ProductFieldIndex.SupplierId, value, true); }
		}

		/// <summary>The UnitPrice property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."UnitPrice"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> UnitPrice
		{
			get { return (Nullable<System.Decimal>)GetValue((int)ProductFieldIndex.UnitPrice, false); }
			set	{ SetValue((int)ProductFieldIndex.UnitPrice, value, true); }
		}

		/// <summary>The UnitsInStock property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."UnitsInStock"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int16> UnitsInStock
		{
			get { return (Nullable<System.Int16>)GetValue((int)ProductFieldIndex.UnitsInStock, false); }
			set	{ SetValue((int)ProductFieldIndex.UnitsInStock, value, true); }
		}

		/// <summary>The UnitsOnOrder property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."UnitsOnOrder"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int16> UnitsOnOrder
		{
			get { return (Nullable<System.Int16>)GetValue((int)ProductFieldIndex.UnitsOnOrder, false); }
			set	{ SetValue((int)ProductFieldIndex.UnitsOnOrder, value, true); }
		}

		/// <summary>Retrieves all related entities of type 'OrderDetailEntity' using a relation of type '1:n'.<br/><br/></summary>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderDetailCollection OrderDetails { get { return GetMultiOrderDetails(false); } }

		/// <summary>Gets / sets the lazy loading flag for OrderDetails. When set to true, OrderDetails is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time OrderDetails is accessed. You can always execute/ a forced fetch by calling GetMultiOrderDetails(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchOrderDetails
		{
			get	{ return GetAlwaysFetchValueForNavigator("OrderDetails"); }
			set	{ SetAlwaysFetchValueForNavigator("OrderDetails", value); }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property OrderDetails already has been fetched. Setting this property to false when OrderDetails has been fetched
		/// will clear the OrderDetails collection well. Setting this property to true while OrderDetails hasn't been fetched disables lazy loading for OrderDetails</summary>
		[Browsable(false)]
		public bool AlreadyFetchedOrderDetails
		{
			get { return GetAlreadyFetchedValueForNavigator("OrderDetails");}
			set { SetAlreadyFetchedValueForNavigator("OrderDetails", value, true);}
		}

		/// <summary>Retrieves all related entities of type 'OrderEntity' using a relation of type 'm:n'.<br/><br/></summary>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection OrdersCollectionViaOrderDetails { get { return GetMultiOrdersCollectionViaOrderDetails(false); } }

		/// <summary>Gets / sets the lazy loading flag for OrdersCollectionViaOrderDetails. When set to true, OrdersCollectionViaOrderDetails is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time OrdersCollectionViaOrderDetails is accessed. You can always execute a forced fetch by calling GetMultiOrdersCollectionViaOrderDetails(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchOrdersCollectionViaOrderDetails
		{
			get	{ return GetAlwaysFetchValueForNavigator("OrdersCollectionViaOrderDetails"); }
			set	{ SetAlwaysFetchValueForNavigator("OrdersCollectionViaOrderDetails", value); }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property OrdersCollectionViaOrderDetails already has been fetched. Setting this property to false when OrdersCollectionViaOrderDetails has been fetched
		/// will clear the OrdersCollectionViaOrderDetails collection well. Setting this property to true while OrdersCollectionViaOrderDetails hasn't been fetched disables lazy loading for OrdersCollectionViaOrderDetails</summary>
		[Browsable(false)]
		public bool AlreadyFetchedOrdersCollectionViaOrderDetails
		{
			get { return GetAlreadyFetchedValueForNavigator("OrdersCollectionViaOrderDetails");}
			set { SetAlreadyFetchedValueForNavigator("OrdersCollectionViaOrderDetails", value, true);}
		}

		/// <summary>Gets / sets related entity of type 'CategoryEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/></summary>
		[Browsable(true)]
		public virtual CategoryEntity Categories
		{
			get	{ return GetSingleCategories(false); }
			set { SetSingleRelatedEntityNavigator(value, "Categories"); }
		}

		/// <summary>Gets / sets the lazy loading flag for Categories. When set to true, Categories is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Categories is accessed. You can always execute a forced fetch by calling GetSingleCategories(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCategories
		{
			get	{ return GetAlwaysFetchValueForNavigator("Categories"); }
			set	{ SetAlwaysFetchValueForNavigator("Categories", value); }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Categories already has been fetched. Setting this property to false when Categories has been fetched
		/// will set Categories to null as well. Setting this property to true while Categories hasn't been fetched disables lazy loading for Categories</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCategories
		{
			get { return GetAlreadyFetchedValueForNavigator("Categories");}
			set { SetAlreadyFetchedValueForNavigator("Categories", value, true);}
		}

		/// <summary>Gets / sets the flag for what to do if the related entity available through the property Categories is not found
		/// in the database. When set to true, Categories will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool CategoriesReturnsNewIfNotFound
		{
			get	{ return _categoriesReturnsNewIfNotFound; }
			set { _categoriesReturnsNewIfNotFound = value; }	
		}

		/// <summary>Gets / sets related entity of type 'SupplierEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/></summary>
		[Browsable(true)]
		public virtual SupplierEntity Suppliers
		{
			get	{ return GetSingleSuppliers(false); }
			set { SetSingleRelatedEntityNavigator(value, "Suppliers"); }
		}

		/// <summary>Gets / sets the lazy loading flag for Suppliers. When set to true, Suppliers is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Suppliers is accessed. You can always execute a forced fetch by calling GetSingleSuppliers(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSuppliers
		{
			get	{ return GetAlwaysFetchValueForNavigator("Suppliers"); }
			set	{ SetAlwaysFetchValueForNavigator("Suppliers", value); }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Suppliers already has been fetched. Setting this property to false when Suppliers has been fetched
		/// will set Suppliers to null as well. Setting this property to true while Suppliers hasn't been fetched disables lazy loading for Suppliers</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSuppliers
		{
			get { return GetAlreadyFetchedValueForNavigator("Suppliers");}
			set { SetAlreadyFetchedValueForNavigator("Suppliers", value, true);}
		}

		/// <summary>Gets / sets the flag for what to do if the related entity available through the property Suppliers is not found
		/// in the database. When set to true, Suppliers will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool SuppliersReturnsNewIfNotFound
		{
			get	{ return _suppliersReturnsNewIfNotFound; }
			set { _suppliersReturnsNewIfNotFound = value; }	
		}



		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace SD.LLBLGen.Pro.Examples.Auditing
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

namespace SD.LLBLGen.Pro.Examples.Auditing.RelationClasses
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
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Categories", false, new[] { CategoryFields.CategoryId, ProductFields.CategoryId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and SupplierEntity over the m:1 relation they have, using the relation between the fields: Product.SupplierId - Supplier.SupplierId</summary>
		public virtual IEntityRelation SupplierEntityUsingSupplierId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Suppliers", false, new[] { SupplierFields.SupplierId, ProductFields.SupplierId }); }
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
