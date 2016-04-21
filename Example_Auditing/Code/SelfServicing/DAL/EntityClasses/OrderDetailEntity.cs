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

	/// <summary>Entity class which represents the entity 'OrderDetail'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class OrderDetailEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private OrderEntity _orders;
		private bool	_alwaysFetchOrders, _alreadyFetchedOrders, _ordersReturnsNewIfNotFound;
		private ProductEntity _products;
		private bool	_alwaysFetchProducts, _alreadyFetchedProducts, _productsReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Orders</summary>
			public static readonly string Orders = "Orders";
			/// <summary>Member name Products</summary>
			public static readonly string Products = "Products";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static OrderDetailEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public OrderDetailEntity() :base("OrderDetailEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="orderId">PK value for OrderDetail which data should be fetched into this OrderDetail object</param>
		/// <param name="productId">PK value for OrderDetail which data should be fetched into this OrderDetail object</param>
		public OrderDetailEntity(System.Int32 orderId, System.Int32 productId):base("OrderDetailEntity")
		{
			InitClassFetch(orderId, productId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="orderId">PK value for OrderDetail which data should be fetched into this OrderDetail object</param>
		/// <param name="productId">PK value for OrderDetail which data should be fetched into this OrderDetail object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public OrderDetailEntity(System.Int32 orderId, System.Int32 productId, IPrefetchPath prefetchPathToUse):base("OrderDetailEntity")
		{
			InitClassFetch(orderId, productId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="orderId">PK value for OrderDetail which data should be fetched into this OrderDetail object</param>
		/// <param name="productId">PK value for OrderDetail which data should be fetched into this OrderDetail object</param>
		/// <param name="validator">The custom validator object for this OrderDetailEntity</param>
		public OrderDetailEntity(System.Int32 orderId, System.Int32 productId, IValidator validator):base("OrderDetailEntity")
		{
			InitClassFetch(orderId, productId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected OrderDetailEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_orders = (OrderEntity)info.GetValue("_orders", typeof(OrderEntity));
			if(_orders!=null)
			{
				_orders.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_ordersReturnsNewIfNotFound = info.GetBoolean("_ordersReturnsNewIfNotFound");
			_alwaysFetchOrders = info.GetBoolean("_alwaysFetchOrders");
			_alreadyFetchedOrders = info.GetBoolean("_alreadyFetchedOrders");

			_products = (ProductEntity)info.GetValue("_products", typeof(ProductEntity));
			if(_products!=null)
			{
				_products.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_productsReturnsNewIfNotFound = info.GetBoolean("_productsReturnsNewIfNotFound");
			_alwaysFetchProducts = info.GetBoolean("_alwaysFetchProducts");
			_alreadyFetchedProducts = info.GetBoolean("_alreadyFetchedProducts");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((OrderDetailFieldIndex)fieldIndex)
			{
				case OrderDetailFieldIndex.OrderId:
					DesetupSyncOrders(true, false);
					_alreadyFetchedOrders = false;
					break;
				case OrderDetailFieldIndex.ProductId:
					DesetupSyncProducts(true, false);
					_alreadyFetchedProducts = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedOrders = (_orders != null);
			_alreadyFetchedProducts = (_products != null);
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
				case "Orders":
					toReturn.Add(Relations.OrderEntityUsingOrderId);
					break;
				case "Products":
					toReturn.Add(Relations.ProductEntityUsingProductId);
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
			info.AddValue("_orders", (!this.MarkedForDeletion?_orders:null));
			info.AddValue("_ordersReturnsNewIfNotFound", _ordersReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchOrders", _alwaysFetchOrders);
			info.AddValue("_alreadyFetchedOrders", _alreadyFetchedOrders);
			info.AddValue("_products", (!this.MarkedForDeletion?_products:null));
			info.AddValue("_productsReturnsNewIfNotFound", _productsReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchProducts", _alwaysFetchProducts);
			info.AddValue("_alreadyFetchedProducts", _alreadyFetchedProducts);

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
				case "Orders":
					_alreadyFetchedOrders = true;
					this.Orders = (OrderEntity)entity;
					break;
				case "Products":
					_alreadyFetchedProducts = true;
					this.Products = (ProductEntity)entity;
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
				case "Orders":
					SetupSyncOrders(relatedEntity);
					break;
				case "Products":
					SetupSyncProducts(relatedEntity);
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
				case "Orders":
					DesetupSyncOrders(false, true);
					break;
				case "Products":
					DesetupSyncProducts(false, true);
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
			if(_orders!=null)
			{
				toReturn.Add(_orders);
			}
			if(_products!=null)
			{
				toReturn.Add(_products);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();


			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="orderId">PK value for OrderDetail which data should be fetched into this OrderDetail object</param>
		/// <param name="productId">PK value for OrderDetail which data should be fetched into this OrderDetail object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 orderId, System.Int32 productId)
		{
			return FetchUsingPK(orderId, productId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="orderId">PK value for OrderDetail which data should be fetched into this OrderDetail object</param>
		/// <param name="productId">PK value for OrderDetail which data should be fetched into this OrderDetail object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 orderId, System.Int32 productId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(orderId, productId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="orderId">PK value for OrderDetail which data should be fetched into this OrderDetail object</param>
		/// <param name="productId">PK value for OrderDetail which data should be fetched into this OrderDetail object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 orderId, System.Int32 productId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(orderId, productId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="orderId">PK value for OrderDetail which data should be fetched into this OrderDetail object</param>
		/// <param name="productId">PK value for OrderDetail which data should be fetched into this OrderDetail object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 orderId, System.Int32 productId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(orderId, productId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.OrderId, this.ProductId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new OrderDetailRelations().GetAllRelations();
		}

		/// <summary> Retrieves the related entity of type 'OrderEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'OrderEntity' which is related to this entity.</returns>
		public OrderEntity GetSingleOrders()
		{
			return GetSingleOrders(false);
		}

		/// <summary> Retrieves the related entity of type 'OrderEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'OrderEntity' which is related to this entity.</returns>
		public virtual OrderEntity GetSingleOrders(bool forceFetch)
		{
			if( ( !_alreadyFetchedOrders || forceFetch || _alwaysFetchOrders) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.OrderEntityUsingOrderId);
				OrderEntity newEntity = new OrderEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.OrderId);
				}
				if(fetchResult)
				{
					newEntity = (OrderEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_ordersReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Orders = newEntity;
				_alreadyFetchedOrders = fetchResult;
			}
			return _orders;
		}


		/// <summary> Retrieves the related entity of type 'ProductEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ProductEntity' which is related to this entity.</returns>
		public ProductEntity GetSingleProducts()
		{
			return GetSingleProducts(false);
		}

		/// <summary> Retrieves the related entity of type 'ProductEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ProductEntity' which is related to this entity.</returns>
		public virtual ProductEntity GetSingleProducts(bool forceFetch)
		{
			if( ( !_alreadyFetchedProducts || forceFetch || _alwaysFetchProducts) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.ProductEntityUsingProductId);
				ProductEntity newEntity = new ProductEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ProductId);
				}
				if(fetchResult)
				{
					newEntity = (ProductEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_productsReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Products = newEntity;
				_alreadyFetchedProducts = fetchResult;
			}
			return _products;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Orders", _orders);
			toReturn.Add("Products", _products);
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
		/// <param name="orderId">PK value for OrderDetail which data should be fetched into this OrderDetail object</param>
		/// <param name="productId">PK value for OrderDetail which data should be fetched into this OrderDetail object</param>
		/// <param name="validator">The validator object for this OrderDetailEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 orderId, System.Int32 productId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(orderId, productId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_ordersReturnsNewIfNotFound = true;
			_productsReturnsNewIfNotFound = true;
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
			_fieldsCustomProperties.Add("Discount", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("OrderId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Quantity", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UnitPrice", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _orders</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncOrders(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _orders, new PropertyChangedEventHandler( OnOrdersPropertyChanged ), "Orders", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticOrderDetailRelations.OrderEntityUsingOrderIdStatic, true, signalRelatedEntity, "OrderDetails", resetFKFields, new int[] { (int)OrderDetailFieldIndex.OrderId } );		
			_orders = null;
		}
		
		/// <summary> setups the sync logic for member _orders</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncOrders(IEntityCore relatedEntity)
		{
			if(_orders!=relatedEntity)
			{		
				DesetupSyncOrders(true, true);
				_orders = (OrderEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _orders, new PropertyChangedEventHandler( OnOrdersPropertyChanged ), "Orders", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticOrderDetailRelations.OrderEntityUsingOrderIdStatic, true, ref _alreadyFetchedOrders, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnOrdersPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _products</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProducts(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _products, new PropertyChangedEventHandler( OnProductsPropertyChanged ), "Products", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticOrderDetailRelations.ProductEntityUsingProductIdStatic, true, signalRelatedEntity, "OrderDetails", resetFKFields, new int[] { (int)OrderDetailFieldIndex.ProductId } );		
			_products = null;
		}
		
		/// <summary> setups the sync logic for member _products</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProducts(IEntityCore relatedEntity)
		{
			if(_products!=relatedEntity)
			{		
				DesetupSyncProducts(true, true);
				_products = (ProductEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _products, new PropertyChangedEventHandler( OnProductsPropertyChanged ), "Products", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticOrderDetailRelations.ProductEntityUsingProductIdStatic, true, ref _alreadyFetchedProducts, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnProductsPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="orderId">PK value for OrderDetail which data should be fetched into this OrderDetail object</param>
		/// <param name="productId">PK value for OrderDetail which data should be fetched into this OrderDetail object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 orderId, System.Int32 productId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)OrderDetailFieldIndex.OrderId].ForcedCurrentValueWrite(orderId);
				this.Fields[(int)OrderDetailFieldIndex.ProductId].ForcedCurrentValueWrite(productId);
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
			return DAOFactory.CreateOrderDetailDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new OrderDetailEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static OrderDetailRelations Relations
		{
			get	{ return new OrderDetailRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Order'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathOrders
		{
			get	{ return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection(), (IEntityRelation)GetRelationsForField("Orders")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.OrderDetailEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.OrderEntity, 0, null, null, null, "Orders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProducts
		{
			get	{ return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ProductCollection(), (IEntityRelation)GetRelationsForField("Products")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.OrderDetailEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.ProductEntity, 0, null, null, null, "Products", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The Discount property of the Entity OrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Order Details"."Discount"<br/>
		/// Table field type characteristics (type, precision, scale, length): Real, 24, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Single Discount
		{
			get { return (System.Single)GetValue((int)OrderDetailFieldIndex.Discount, true); }
			set	{ SetValue((int)OrderDetailFieldIndex.Discount, value, true); }
		}

		/// <summary> The OrderId property of the Entity OrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Order Details"."OrderID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 OrderId
		{
			get { return (System.Int32)GetValue((int)OrderDetailFieldIndex.OrderId, true); }
			set	{ SetValue((int)OrderDetailFieldIndex.OrderId, value, true); }
		}

		/// <summary> The ProductId property of the Entity OrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Order Details"."ProductID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ProductId
		{
			get { return (System.Int32)GetValue((int)OrderDetailFieldIndex.ProductId, true); }
			set	{ SetValue((int)OrderDetailFieldIndex.ProductId, value, true); }
		}

		/// <summary> The Quantity property of the Entity OrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Order Details"."Quantity"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 Quantity
		{
			get { return (System.Int16)GetValue((int)OrderDetailFieldIndex.Quantity, true); }
			set	{ SetValue((int)OrderDetailFieldIndex.Quantity, value, true); }
		}

		/// <summary> The UnitPrice property of the Entity OrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Order Details"."UnitPrice"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal UnitPrice
		{
			get { return (System.Decimal)GetValue((int)OrderDetailFieldIndex.UnitPrice, true); }
			set	{ SetValue((int)OrderDetailFieldIndex.UnitPrice, value, true); }
		}


		/// <summary> Gets / sets related entity of type 'OrderEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleOrders()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual OrderEntity Orders
		{
			get	{ return GetSingleOrders(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncOrders(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "OrderDetails", "Orders", _orders, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Orders. When set to true, Orders is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Orders is accessed. You can always execute a forced fetch by calling GetSingleOrders(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchOrders
		{
			get	{ return _alwaysFetchOrders; }
			set	{ _alwaysFetchOrders = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Orders already has been fetched. Setting this property to false when Orders has been fetched
		/// will set Orders to null as well. Setting this property to true while Orders hasn't been fetched disables lazy loading for Orders</summary>
		[Browsable(false)]
		public bool AlreadyFetchedOrders
		{
			get { return _alreadyFetchedOrders;}
			set 
			{
				if(_alreadyFetchedOrders && !value)
				{
					this.Orders = null;
				}
				_alreadyFetchedOrders = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Orders is not found
		/// in the database. When set to true, Orders will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool OrdersReturnsNewIfNotFound
		{
			get	{ return _ordersReturnsNewIfNotFound; }
			set { _ordersReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'ProductEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProducts()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual ProductEntity Products
		{
			get	{ return GetSingleProducts(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncProducts(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "OrderDetails", "Products", _products, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Products. When set to true, Products is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Products is accessed. You can always execute a forced fetch by calling GetSingleProducts(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProducts
		{
			get	{ return _alwaysFetchProducts; }
			set	{ _alwaysFetchProducts = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Products already has been fetched. Setting this property to false when Products has been fetched
		/// will set Products to null as well. Setting this property to true while Products hasn't been fetched disables lazy loading for Products</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProducts
		{
			get { return _alreadyFetchedProducts;}
			set 
			{
				if(_alreadyFetchedProducts && !value)
				{
					this.Products = null;
				}
				_alreadyFetchedProducts = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Products is not found
		/// in the database. When set to true, Products will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ProductsReturnsNewIfNotFound
		{
			get	{ return _productsReturnsNewIfNotFound; }
			set { _productsReturnsNewIfNotFound = value; }	
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
			get { return (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.OrderDetailEntity; }
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
