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
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Data;
using System.Xml.Serialization;
using SD.LLBLGen.Pro.Examples.Auditing;
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

	/// <summary>Entity class which represents the entity 'Product'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class ProductEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderDetailCollection	_orderDetails;
		private bool	_alwaysFetchOrderDetails, _alreadyFetchedOrderDetails;
		private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection _ordersCollectionViaOrderDetails;
		private bool	_alwaysFetchOrdersCollectionViaOrderDetails, _alreadyFetchedOrdersCollectionViaOrderDetails;
		private CategoryEntity _categories;
		private bool	_alwaysFetchCategories, _alreadyFetchedCategories, _categoriesReturnsNewIfNotFound;
		private SupplierEntity _suppliers;
		private bool	_alwaysFetchSuppliers, _alreadyFetchedSuppliers, _suppliersReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

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
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ProductEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ProductEntity() :base("ProductEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		public ProductEntity(System.Int32 productId):base("ProductEntity")
		{
			InitClassFetch(productId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ProductEntity(System.Int32 productId, IPrefetchPath prefetchPathToUse):base("ProductEntity")
		{
			InitClassFetch(productId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="validator">The custom validator object for this ProductEntity</param>
		public ProductEntity(System.Int32 productId, IValidator validator):base("ProductEntity")
		{
			InitClassFetch(productId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_orderDetails = (SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderDetailCollection)info.GetValue("_orderDetails", typeof(SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderDetailCollection));
			_alwaysFetchOrderDetails = info.GetBoolean("_alwaysFetchOrderDetails");
			_alreadyFetchedOrderDetails = info.GetBoolean("_alreadyFetchedOrderDetails");
			_ordersCollectionViaOrderDetails = (SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection)info.GetValue("_ordersCollectionViaOrderDetails", typeof(SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection));
			_alwaysFetchOrdersCollectionViaOrderDetails = info.GetBoolean("_alwaysFetchOrdersCollectionViaOrderDetails");
			_alreadyFetchedOrdersCollectionViaOrderDetails = info.GetBoolean("_alreadyFetchedOrdersCollectionViaOrderDetails");
			_categories = (CategoryEntity)info.GetValue("_categories", typeof(CategoryEntity));
			if(_categories!=null)
			{
				_categories.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_categoriesReturnsNewIfNotFound = info.GetBoolean("_categoriesReturnsNewIfNotFound");
			_alwaysFetchCategories = info.GetBoolean("_alwaysFetchCategories");
			_alreadyFetchedCategories = info.GetBoolean("_alreadyFetchedCategories");

			_suppliers = (SupplierEntity)info.GetValue("_suppliers", typeof(SupplierEntity));
			if(_suppliers!=null)
			{
				_suppliers.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_suppliersReturnsNewIfNotFound = info.GetBoolean("_suppliersReturnsNewIfNotFound");
			_alwaysFetchSuppliers = info.GetBoolean("_alwaysFetchSuppliers");
			_alreadyFetchedSuppliers = info.GetBoolean("_alreadyFetchedSuppliers");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((ProductFieldIndex)fieldIndex)
			{
				case ProductFieldIndex.CategoryId:
					DesetupSyncCategories(true, false);
					_alreadyFetchedCategories = false;
					break;
				case ProductFieldIndex.SupplierId:
					DesetupSyncSuppliers(true, false);
					_alreadyFetchedSuppliers = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedOrderDetails = (_orderDetails.Count > 0);
			_alreadyFetchedOrdersCollectionViaOrderDetails = (_ordersCollectionViaOrderDetails.Count > 0);
			_alreadyFetchedCategories = (_categories != null);
			_alreadyFetchedSuppliers = (_suppliers != null);
		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Categories":
					toReturn.Add(Relations.CategoryEntityUsingCategoryId);
					break;
				case "Suppliers":
					toReturn.Add(Relations.SupplierEntityUsingSupplierId);
					break;
				case "OrderDetails":
					toReturn.Add(Relations.OrderDetailEntityUsingProductId);
					break;
				case "OrdersCollectionViaOrderDetails":
					toReturn.Add(Relations.OrderDetailEntityUsingProductId, "ProductEntity__", "OrderDetail_", JoinHint.None);
					toReturn.Add(OrderDetailEntity.Relations.OrderEntityUsingOrderId, "OrderDetail_", string.Empty, JoinHint.None);
					break;
				default:
					break;				
			}
			return toReturn;
		}



		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_orderDetails", (!this.MarkedForDeletion?_orderDetails:null));
			info.AddValue("_alwaysFetchOrderDetails", _alwaysFetchOrderDetails);
			info.AddValue("_alreadyFetchedOrderDetails", _alreadyFetchedOrderDetails);
			info.AddValue("_ordersCollectionViaOrderDetails", (!this.MarkedForDeletion?_ordersCollectionViaOrderDetails:null));
			info.AddValue("_alwaysFetchOrdersCollectionViaOrderDetails", _alwaysFetchOrdersCollectionViaOrderDetails);
			info.AddValue("_alreadyFetchedOrdersCollectionViaOrderDetails", _alreadyFetchedOrdersCollectionViaOrderDetails);
			info.AddValue("_categories", (!this.MarkedForDeletion?_categories:null));
			info.AddValue("_categoriesReturnsNewIfNotFound", _categoriesReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCategories", _alwaysFetchCategories);
			info.AddValue("_alreadyFetchedCategories", _alreadyFetchedCategories);
			info.AddValue("_suppliers", (!this.MarkedForDeletion?_suppliers:null));
			info.AddValue("_suppliersReturnsNewIfNotFound", _suppliersReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchSuppliers", _alwaysFetchSuppliers);
			info.AddValue("_alreadyFetchedSuppliers", _alreadyFetchedSuppliers);

			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "Categories":
					_alreadyFetchedCategories = true;
					this.Categories = (CategoryEntity)entity;
					break;
				case "Suppliers":
					_alreadyFetchedSuppliers = true;
					this.Suppliers = (SupplierEntity)entity;
					break;
				case "OrderDetails":
					_alreadyFetchedOrderDetails = true;
					if(entity!=null)
					{
						this.OrderDetails.Add((OrderDetailEntity)entity);
					}
					break;
				case "OrdersCollectionViaOrderDetails":
					_alreadyFetchedOrdersCollectionViaOrderDetails = true;
					if(entity!=null)
					{
						this.OrdersCollectionViaOrderDetails.Add((OrderEntity)entity);
					}
					break;
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "Categories":
					SetupSyncCategories(relatedEntity);
					break;
				case "Suppliers":
					SetupSyncSuppliers(relatedEntity);
					break;
				case "OrderDetails":
					_orderDetails.Add((OrderDetailEntity)relatedEntity);
					break;
				default:
					break;
			}
		}
		
		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "Categories":
					DesetupSyncCategories(false, true);
					break;
				case "Suppliers":
					DesetupSyncSuppliers(false, true);
					break;
				case "OrderDetails":
					this.PerformRelatedEntityRemoval(_orderDetails, relatedEntity, signalRelatedEntityManyToOne);
					break;
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		protected override List<IEntity> GetDependingRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		protected override List<IEntity> GetDependentRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			if(_categories!=null)
			{
				toReturn.Add(_categories);
			}
			if(_suppliers!=null)
			{
				toReturn.Add(_suppliers);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_orderDetails);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productId)
		{
			return FetchUsingPK(productId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(productId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(productId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
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

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ProductId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new ProductRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'OrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'OrderDetailEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderDetailCollection GetMultiOrderDetails(bool forceFetch)
		{
			return GetMultiOrderDetails(forceFetch, _orderDetails.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'OrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'OrderDetailEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderDetailCollection GetMultiOrderDetails(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiOrderDetails(forceFetch, _orderDetails.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'OrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderDetailCollection GetMultiOrderDetails(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiOrderDetails(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'OrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderDetailCollection GetMultiOrderDetails(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedOrderDetails || forceFetch || _alwaysFetchOrderDetails) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_orderDetails);
				_orderDetails.SuppressClearInGetMulti=!forceFetch;
				_orderDetails.EntityFactoryToUse = entityFactoryToUse;
				_orderDetails.GetMultiManyToOne(null, this, filter);
				_orderDetails.SuppressClearInGetMulti=false;
				_alreadyFetchedOrderDetails = true;
			}
			return _orderDetails;
		}

		/// <summary> Sets the collection parameters for the collection for 'OrderDetails'. These settings will be taken into account
		/// when the property OrderDetails is requested or GetMultiOrderDetails is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersOrderDetails(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_orderDetails.SortClauses=sortClauses;
			_orderDetails.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'OrderEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'OrderEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection GetMultiOrdersCollectionViaOrderDetails(bool forceFetch)
		{
			return GetMultiOrdersCollectionViaOrderDetails(forceFetch, _ordersCollectionViaOrderDetails.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'OrderEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection GetMultiOrdersCollectionViaOrderDetails(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedOrdersCollectionViaOrderDetails || forceFetch || _alwaysFetchOrdersCollectionViaOrderDetails) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_ordersCollectionViaOrderDetails);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductFields.ProductId, ComparisonOperator.Equal, this.ProductId, "ProductEntity__"));
				_ordersCollectionViaOrderDetails.SuppressClearInGetMulti=!forceFetch;
				_ordersCollectionViaOrderDetails.EntityFactoryToUse = entityFactoryToUse;
				_ordersCollectionViaOrderDetails.GetMulti(filter, GetRelationsForField("OrdersCollectionViaOrderDetails"));
				_ordersCollectionViaOrderDetails.SuppressClearInGetMulti=false;
				_alreadyFetchedOrdersCollectionViaOrderDetails = true;
			}
			return _ordersCollectionViaOrderDetails;
		}

		/// <summary> Sets the collection parameters for the collection for 'OrdersCollectionViaOrderDetails'. These settings will be taken into account
		/// when the property OrdersCollectionViaOrderDetails is requested or GetMultiOrdersCollectionViaOrderDetails is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersOrdersCollectionViaOrderDetails(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_ordersCollectionViaOrderDetails.SortClauses=sortClauses;
			_ordersCollectionViaOrderDetails.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'CategoryEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'CategoryEntity' which is related to this entity.</returns>
		public CategoryEntity GetSingleCategories()
		{
			return GetSingleCategories(false);
		}

		/// <summary> Retrieves the related entity of type 'CategoryEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CategoryEntity' which is related to this entity.</returns>
		public virtual CategoryEntity GetSingleCategories(bool forceFetch)
		{
			if( ( !_alreadyFetchedCategories || forceFetch || _alwaysFetchCategories) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.CategoryEntityUsingCategoryId);
				CategoryEntity newEntity = new CategoryEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.CategoryId.GetValueOrDefault());
				}
				if(fetchResult)
				{
					newEntity = (CategoryEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_categoriesReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Categories = newEntity;
				_alreadyFetchedCategories = fetchResult;
			}
			return _categories;
		}


		/// <summary> Retrieves the related entity of type 'SupplierEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'SupplierEntity' which is related to this entity.</returns>
		public SupplierEntity GetSingleSuppliers()
		{
			return GetSingleSuppliers(false);
		}

		/// <summary> Retrieves the related entity of type 'SupplierEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'SupplierEntity' which is related to this entity.</returns>
		public virtual SupplierEntity GetSingleSuppliers(bool forceFetch)
		{
			if( ( !_alreadyFetchedSuppliers || forceFetch || _alwaysFetchSuppliers) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.SupplierEntityUsingSupplierId);
				SupplierEntity newEntity = new SupplierEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.SupplierId.GetValueOrDefault());
				}
				if(fetchResult)
				{
					newEntity = (SupplierEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_suppliersReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Suppliers = newEntity;
				_alreadyFetchedSuppliers = fetchResult;
			}
			return _suppliers;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Categories", _categories);
			toReturn.Add("Suppliers", _suppliers);
			toReturn.Add("OrderDetails", _orderDetails);
			toReturn.Add("OrdersCollectionViaOrderDetails", _ordersCollectionViaOrderDetails);
			return toReturn;
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
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

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
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

		/// <summary> Initializes the class members</summary>
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

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CategoryId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Discontinued", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("QuantityPerUnit", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ReorderLevel", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SupplierId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UnitPrice", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UnitsInStock", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UnitsOnOrder", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _categories</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCategories(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _categories, new PropertyChangedEventHandler( OnCategoriesPropertyChanged ), "Categories", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticProductRelations.CategoryEntityUsingCategoryIdStatic, true, signalRelatedEntity, "Products", resetFKFields, new int[] { (int)ProductFieldIndex.CategoryId } );		
			_categories = null;
		}
		
		/// <summary> setups the sync logic for member _categories</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCategories(IEntityCore relatedEntity)
		{
			if(_categories!=relatedEntity)
			{		
				DesetupSyncCategories(true, true);
				_categories = (CategoryEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _categories, new PropertyChangedEventHandler( OnCategoriesPropertyChanged ), "Categories", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticProductRelations.CategoryEntityUsingCategoryIdStatic, true, ref _alreadyFetchedCategories, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCategoriesPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _suppliers</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSuppliers(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _suppliers, new PropertyChangedEventHandler( OnSuppliersPropertyChanged ), "Suppliers", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticProductRelations.SupplierEntityUsingSupplierIdStatic, true, signalRelatedEntity, "Products", resetFKFields, new int[] { (int)ProductFieldIndex.SupplierId } );		
			_suppliers = null;
		}
		
		/// <summary> setups the sync logic for member _suppliers</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSuppliers(IEntityCore relatedEntity)
		{
			if(_suppliers!=relatedEntity)
			{		
				DesetupSyncSuppliers(true, true);
				_suppliers = (SupplierEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _suppliers, new PropertyChangedEventHandler( OnSuppliersPropertyChanged ), "Suppliers", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticProductRelations.SupplierEntityUsingSupplierIdStatic, true, ref _alreadyFetchedSuppliers, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSuppliersPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
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

		/// <summary> Creates the DAO instance for this type</summary>
		/// <returns></returns>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateProductDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ProductEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ProductRelations Relations
		{
			get	{ return new ProductRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OrderDetail' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathOrderDetails
		{
			get { return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderDetailCollection(), (IEntityRelation)GetRelationsForField("OrderDetails")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.ProductEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.OrderDetailEntity, 0, null, null, null, "OrderDetails", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Order'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathOrdersCollectionViaOrderDetails
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.OrderDetailEntityUsingProductId;
				intermediateRelation.SetAliases(string.Empty, "OrderDetail_");
				return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection(), intermediateRelation,	(int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.ProductEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.OrderEntity, 0, null, null, GetRelationsForField("OrdersCollectionViaOrderDetails"), "OrdersCollectionViaOrderDetails", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Category'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCategories
		{
			get	{ return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CategoryCollection(), (IEntityRelation)GetRelationsForField("Categories")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.ProductEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.CategoryEntity, 0, null, null, null, "Categories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Supplier'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSuppliers
		{
			get	{ return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.SupplierCollection(), (IEntityRelation)GetRelationsForField("Suppliers")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.ProductEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.SupplierEntity, 0, null, null, null, "Suppliers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The CategoryId property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."CategoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> CategoryId
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductFieldIndex.CategoryId, false); }
			set	{ SetValue((int)ProductFieldIndex.CategoryId, value, true); }
		}

		/// <summary> The Discontinued property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."Discontinued"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean Discontinued
		{
			get { return (System.Boolean)GetValue((int)ProductFieldIndex.Discontinued, true); }
			set	{ SetValue((int)ProductFieldIndex.Discontinued, value, true); }
		}

		/// <summary> The ProductId property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."ProductID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ProductId
		{
			get { return (System.Int32)GetValue((int)ProductFieldIndex.ProductId, true); }
			set	{ SetValue((int)ProductFieldIndex.ProductId, value, true); }
		}

		/// <summary> The ProductName property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."ProductName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 40<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ProductName
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.ProductName, true); }
			set	{ SetValue((int)ProductFieldIndex.ProductName, value, true); }
		}

		/// <summary> The QuantityPerUnit property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."QuantityPerUnit"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String QuantityPerUnit
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.QuantityPerUnit, true); }
			set	{ SetValue((int)ProductFieldIndex.QuantityPerUnit, value, true); }
		}

		/// <summary> The ReorderLevel property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."ReorderLevel"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int16> ReorderLevel
		{
			get { return (Nullable<System.Int16>)GetValue((int)ProductFieldIndex.ReorderLevel, false); }
			set	{ SetValue((int)ProductFieldIndex.ReorderLevel, value, true); }
		}

		/// <summary> The SupplierId property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."SupplierID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> SupplierId
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductFieldIndex.SupplierId, false); }
			set	{ SetValue((int)ProductFieldIndex.SupplierId, value, true); }
		}

		/// <summary> The UnitPrice property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."UnitPrice"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> UnitPrice
		{
			get { return (Nullable<System.Decimal>)GetValue((int)ProductFieldIndex.UnitPrice, false); }
			set	{ SetValue((int)ProductFieldIndex.UnitPrice, value, true); }
		}

		/// <summary> The UnitsInStock property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."UnitsInStock"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int16> UnitsInStock
		{
			get { return (Nullable<System.Int16>)GetValue((int)ProductFieldIndex.UnitsInStock, false); }
			set	{ SetValue((int)ProductFieldIndex.UnitsInStock, value, true); }
		}

		/// <summary> The UnitsOnOrder property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Products"."UnitsOnOrder"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int16> UnitsOnOrder
		{
			get { return (Nullable<System.Int16>)GetValue((int)ProductFieldIndex.UnitsOnOrder, false); }
			set	{ SetValue((int)ProductFieldIndex.UnitsOnOrder, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'OrderDetailEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiOrderDetails()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderDetailCollection OrderDetails
		{
			get	{ return GetMultiOrderDetails(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for OrderDetails. When set to true, OrderDetails is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time OrderDetails is accessed. You can always execute/ a forced fetch by calling GetMultiOrderDetails(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchOrderDetails
		{
			get	{ return _alwaysFetchOrderDetails; }
			set	{ _alwaysFetchOrderDetails = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property OrderDetails already has been fetched. Setting this property to false when OrderDetails has been fetched
		/// will clear the OrderDetails collection well. Setting this property to true while OrderDetails hasn't been fetched disables lazy loading for OrderDetails</summary>
		[Browsable(false)]
		public bool AlreadyFetchedOrderDetails
		{
			get { return _alreadyFetchedOrderDetails;}
			set 
			{
				if(_alreadyFetchedOrderDetails && !value && (_orderDetails != null))
				{
					_orderDetails.Clear();
				}
				_alreadyFetchedOrderDetails = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'OrderEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiOrdersCollectionViaOrderDetails()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection OrdersCollectionViaOrderDetails
		{
			get { return GetMultiOrdersCollectionViaOrderDetails(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for OrdersCollectionViaOrderDetails. When set to true, OrdersCollectionViaOrderDetails is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time OrdersCollectionViaOrderDetails is accessed. You can always execute a forced fetch by calling GetMultiOrdersCollectionViaOrderDetails(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchOrdersCollectionViaOrderDetails
		{
			get	{ return _alwaysFetchOrdersCollectionViaOrderDetails; }
			set	{ _alwaysFetchOrdersCollectionViaOrderDetails = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property OrdersCollectionViaOrderDetails already has been fetched. Setting this property to false when OrdersCollectionViaOrderDetails has been fetched
		/// will clear the OrdersCollectionViaOrderDetails collection well. Setting this property to true while OrdersCollectionViaOrderDetails hasn't been fetched disables lazy loading for OrdersCollectionViaOrderDetails</summary>
		[Browsable(false)]
		public bool AlreadyFetchedOrdersCollectionViaOrderDetails
		{
			get { return _alreadyFetchedOrdersCollectionViaOrderDetails;}
			set 
			{
				if(_alreadyFetchedOrdersCollectionViaOrderDetails && !value && (_ordersCollectionViaOrderDetails != null))
				{
					_ordersCollectionViaOrderDetails.Clear();
				}
				_alreadyFetchedOrdersCollectionViaOrderDetails = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'CategoryEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCategories()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual CategoryEntity Categories
		{
			get	{ return GetSingleCategories(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncCategories(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Products", "Categories", _categories, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Categories. When set to true, Categories is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Categories is accessed. You can always execute a forced fetch by calling GetSingleCategories(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCategories
		{
			get	{ return _alwaysFetchCategories; }
			set	{ _alwaysFetchCategories = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Categories already has been fetched. Setting this property to false when Categories has been fetched
		/// will set Categories to null as well. Setting this property to true while Categories hasn't been fetched disables lazy loading for Categories</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCategories
		{
			get { return _alreadyFetchedCategories;}
			set 
			{
				if(_alreadyFetchedCategories && !value)
				{
					this.Categories = null;
				}
				_alreadyFetchedCategories = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Categories is not found
		/// in the database. When set to true, Categories will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool CategoriesReturnsNewIfNotFound
		{
			get	{ return _categoriesReturnsNewIfNotFound; }
			set { _categoriesReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'SupplierEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSuppliers()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual SupplierEntity Suppliers
		{
			get	{ return GetSingleSuppliers(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncSuppliers(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Products", "Suppliers", _suppliers, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Suppliers. When set to true, Suppliers is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Suppliers is accessed. You can always execute a forced fetch by calling GetSingleSuppliers(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSuppliers
		{
			get	{ return _alwaysFetchSuppliers; }
			set	{ _alwaysFetchSuppliers = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Suppliers already has been fetched. Setting this property to false when Suppliers has been fetched
		/// will set Suppliers to null as well. Setting this property to true while Suppliers hasn't been fetched disables lazy loading for Suppliers</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSuppliers
		{
			get { return _alreadyFetchedSuppliers;}
			set 
			{
				if(_alreadyFetchedSuppliers && !value)
				{
					this.Suppliers = null;
				}
				_alreadyFetchedSuppliers = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Suppliers is not found
		/// in the database. When set to true, Suppliers will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool SuppliersReturnsNewIfNotFound
		{
			get	{ return _suppliersReturnsNewIfNotFound; }
			set { _suppliersReturnsNewIfNotFound = value; }	
		}


		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}

		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		[System.ComponentModel.Browsable(false), XmlIgnore]
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary>Returns the SD.LLBLGen.Pro.Examples.Auditing.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.ProductEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
