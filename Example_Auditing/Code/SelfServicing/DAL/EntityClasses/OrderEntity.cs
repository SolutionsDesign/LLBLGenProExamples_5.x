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

	/// <summary>Entity class which represents the entity 'Order'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class OrderEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderAuditInfoCollection	_orderAuditInfo;
		private bool	_alwaysFetchOrderAuditInfo, _alreadyFetchedOrderAuditInfo;
		private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderDetailCollection	_orderDetails;
		private bool	_alwaysFetchOrderDetails, _alreadyFetchedOrderDetails;
		private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ProductCollection _productsCollectionViaOrderDetails;
		private bool	_alwaysFetchProductsCollectionViaOrderDetails, _alreadyFetchedProductsCollectionViaOrderDetails;
		private CustomerEntity _customers;
		private bool	_alwaysFetchCustomers, _alreadyFetchedCustomers, _customersReturnsNewIfNotFound;
		private EmployeeEntity _employees;
		private bool	_alwaysFetchEmployees, _alreadyFetchedEmployees, _employeesReturnsNewIfNotFound;
		private ShipperEntity _shippers;
		private bool	_alwaysFetchShippers, _alreadyFetchedShippers, _shippersReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Customers</summary>
			public static readonly string Customers = "Customers";
			/// <summary>Member name Employees</summary>
			public static readonly string Employees = "Employees";
			/// <summary>Member name Shippers</summary>
			public static readonly string Shippers = "Shippers";
			/// <summary>Member name OrderAuditInfo</summary>
			public static readonly string OrderAuditInfo = "OrderAuditInfo";
			/// <summary>Member name OrderDetails</summary>
			public static readonly string OrderDetails = "OrderDetails";
			/// <summary>Member name ProductsCollectionViaOrderDetails</summary>
			public static readonly string ProductsCollectionViaOrderDetails = "ProductsCollectionViaOrderDetails";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static OrderEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public OrderEntity() :base("OrderEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="orderId">PK value for Order which data should be fetched into this Order object</param>
		public OrderEntity(System.Int32 orderId):base("OrderEntity")
		{
			InitClassFetch(orderId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="orderId">PK value for Order which data should be fetched into this Order object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public OrderEntity(System.Int32 orderId, IPrefetchPath prefetchPathToUse):base("OrderEntity")
		{
			InitClassFetch(orderId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="orderId">PK value for Order which data should be fetched into this Order object</param>
		/// <param name="validator">The custom validator object for this OrderEntity</param>
		public OrderEntity(System.Int32 orderId, IValidator validator):base("OrderEntity")
		{
			InitClassFetch(orderId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected OrderEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_orderAuditInfo = (SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderAuditInfoCollection)info.GetValue("_orderAuditInfo", typeof(SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderAuditInfoCollection));
			_alwaysFetchOrderAuditInfo = info.GetBoolean("_alwaysFetchOrderAuditInfo");
			_alreadyFetchedOrderAuditInfo = info.GetBoolean("_alreadyFetchedOrderAuditInfo");

			_orderDetails = (SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderDetailCollection)info.GetValue("_orderDetails", typeof(SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderDetailCollection));
			_alwaysFetchOrderDetails = info.GetBoolean("_alwaysFetchOrderDetails");
			_alreadyFetchedOrderDetails = info.GetBoolean("_alreadyFetchedOrderDetails");
			_productsCollectionViaOrderDetails = (SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ProductCollection)info.GetValue("_productsCollectionViaOrderDetails", typeof(SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ProductCollection));
			_alwaysFetchProductsCollectionViaOrderDetails = info.GetBoolean("_alwaysFetchProductsCollectionViaOrderDetails");
			_alreadyFetchedProductsCollectionViaOrderDetails = info.GetBoolean("_alreadyFetchedProductsCollectionViaOrderDetails");
			_customers = (CustomerEntity)info.GetValue("_customers", typeof(CustomerEntity));
			if(_customers!=null)
			{
				_customers.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_customersReturnsNewIfNotFound = info.GetBoolean("_customersReturnsNewIfNotFound");
			_alwaysFetchCustomers = info.GetBoolean("_alwaysFetchCustomers");
			_alreadyFetchedCustomers = info.GetBoolean("_alreadyFetchedCustomers");

			_employees = (EmployeeEntity)info.GetValue("_employees", typeof(EmployeeEntity));
			if(_employees!=null)
			{
				_employees.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_employeesReturnsNewIfNotFound = info.GetBoolean("_employeesReturnsNewIfNotFound");
			_alwaysFetchEmployees = info.GetBoolean("_alwaysFetchEmployees");
			_alreadyFetchedEmployees = info.GetBoolean("_alreadyFetchedEmployees");

			_shippers = (ShipperEntity)info.GetValue("_shippers", typeof(ShipperEntity));
			if(_shippers!=null)
			{
				_shippers.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_shippersReturnsNewIfNotFound = info.GetBoolean("_shippersReturnsNewIfNotFound");
			_alwaysFetchShippers = info.GetBoolean("_alwaysFetchShippers");
			_alreadyFetchedShippers = info.GetBoolean("_alreadyFetchedShippers");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((OrderFieldIndex)fieldIndex)
			{
				case OrderFieldIndex.CustomerId:
					DesetupSyncCustomers(true, false);
					_alreadyFetchedCustomers = false;
					break;
				case OrderFieldIndex.EmployeeId:
					DesetupSyncEmployees(true, false);
					_alreadyFetchedEmployees = false;
					break;
				case OrderFieldIndex.ShipVia:
					DesetupSyncShippers(true, false);
					_alreadyFetchedShippers = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedOrderAuditInfo = (_orderAuditInfo.Count > 0);
			_alreadyFetchedOrderDetails = (_orderDetails.Count > 0);
			_alreadyFetchedProductsCollectionViaOrderDetails = (_productsCollectionViaOrderDetails.Count > 0);
			_alreadyFetchedCustomers = (_customers != null);
			_alreadyFetchedEmployees = (_employees != null);
			_alreadyFetchedShippers = (_shippers != null);
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
				case "Customers":
					toReturn.Add(Relations.CustomerEntityUsingCustomerId);
					break;
				case "Employees":
					toReturn.Add(Relations.EmployeeEntityUsingEmployeeId);
					break;
				case "Shippers":
					toReturn.Add(Relations.ShipperEntityUsingShipVia);
					break;
				case "OrderAuditInfo":
					toReturn.Add(Relations.OrderAuditInfoEntityUsingOrderId);
					break;
				case "OrderDetails":
					toReturn.Add(Relations.OrderDetailEntityUsingOrderId);
					break;
				case "ProductsCollectionViaOrderDetails":
					toReturn.Add(Relations.OrderDetailEntityUsingOrderId, "OrderEntity__", "OrderDetail_", JoinHint.None);
					toReturn.Add(OrderDetailEntity.Relations.ProductEntityUsingProductId, "OrderDetail_", string.Empty, JoinHint.None);
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
			info.AddValue("_orderAuditInfo", (!this.MarkedForDeletion?_orderAuditInfo:null));
			info.AddValue("_alwaysFetchOrderAuditInfo", _alwaysFetchOrderAuditInfo);
			info.AddValue("_alreadyFetchedOrderAuditInfo", _alreadyFetchedOrderAuditInfo);
			info.AddValue("_orderDetails", (!this.MarkedForDeletion?_orderDetails:null));
			info.AddValue("_alwaysFetchOrderDetails", _alwaysFetchOrderDetails);
			info.AddValue("_alreadyFetchedOrderDetails", _alreadyFetchedOrderDetails);
			info.AddValue("_productsCollectionViaOrderDetails", (!this.MarkedForDeletion?_productsCollectionViaOrderDetails:null));
			info.AddValue("_alwaysFetchProductsCollectionViaOrderDetails", _alwaysFetchProductsCollectionViaOrderDetails);
			info.AddValue("_alreadyFetchedProductsCollectionViaOrderDetails", _alreadyFetchedProductsCollectionViaOrderDetails);
			info.AddValue("_customers", (!this.MarkedForDeletion?_customers:null));
			info.AddValue("_customersReturnsNewIfNotFound", _customersReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCustomers", _alwaysFetchCustomers);
			info.AddValue("_alreadyFetchedCustomers", _alreadyFetchedCustomers);
			info.AddValue("_employees", (!this.MarkedForDeletion?_employees:null));
			info.AddValue("_employeesReturnsNewIfNotFound", _employeesReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchEmployees", _alwaysFetchEmployees);
			info.AddValue("_alreadyFetchedEmployees", _alreadyFetchedEmployees);
			info.AddValue("_shippers", (!this.MarkedForDeletion?_shippers:null));
			info.AddValue("_shippersReturnsNewIfNotFound", _shippersReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchShippers", _alwaysFetchShippers);
			info.AddValue("_alreadyFetchedShippers", _alreadyFetchedShippers);

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
				case "Customers":
					_alreadyFetchedCustomers = true;
					this.Customers = (CustomerEntity)entity;
					break;
				case "Employees":
					_alreadyFetchedEmployees = true;
					this.Employees = (EmployeeEntity)entity;
					break;
				case "Shippers":
					_alreadyFetchedShippers = true;
					this.Shippers = (ShipperEntity)entity;
					break;
				case "OrderAuditInfo":
					_alreadyFetchedOrderAuditInfo = true;
					if(entity!=null)
					{
						this.OrderAuditInfo.Add((OrderAuditInfoEntity)entity);
					}
					break;
				case "OrderDetails":
					_alreadyFetchedOrderDetails = true;
					if(entity!=null)
					{
						this.OrderDetails.Add((OrderDetailEntity)entity);
					}
					break;
				case "ProductsCollectionViaOrderDetails":
					_alreadyFetchedProductsCollectionViaOrderDetails = true;
					if(entity!=null)
					{
						this.ProductsCollectionViaOrderDetails.Add((ProductEntity)entity);
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
				case "Customers":
					SetupSyncCustomers(relatedEntity);
					break;
				case "Employees":
					SetupSyncEmployees(relatedEntity);
					break;
				case "Shippers":
					SetupSyncShippers(relatedEntity);
					break;
				case "OrderAuditInfo":
					_orderAuditInfo.Add((OrderAuditInfoEntity)relatedEntity);
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
				case "Customers":
					DesetupSyncCustomers(false, true);
					break;
				case "Employees":
					DesetupSyncEmployees(false, true);
					break;
				case "Shippers":
					DesetupSyncShippers(false, true);
					break;
				case "OrderAuditInfo":
					this.PerformRelatedEntityRemoval(_orderAuditInfo, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_customers!=null)
			{
				toReturn.Add(_customers);
			}
			if(_employees!=null)
			{
				toReturn.Add(_employees);
			}
			if(_shippers!=null)
			{
				toReturn.Add(_shippers);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_orderAuditInfo);
			toReturn.Add(_orderDetails);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="orderId">PK value for Order which data should be fetched into this Order object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 orderId)
		{
			return FetchUsingPK(orderId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="orderId">PK value for Order which data should be fetched into this Order object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 orderId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(orderId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="orderId">PK value for Order which data should be fetched into this Order object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 orderId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(orderId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="orderId">PK value for Order which data should be fetched into this Order object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 orderId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(orderId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.OrderId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new OrderRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'OrderAuditInfoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'OrderAuditInfoEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderAuditInfoCollection GetMultiOrderAuditInfo(bool forceFetch)
		{
			return GetMultiOrderAuditInfo(forceFetch, _orderAuditInfo.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'OrderAuditInfoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'OrderAuditInfoEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderAuditInfoCollection GetMultiOrderAuditInfo(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiOrderAuditInfo(forceFetch, _orderAuditInfo.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'OrderAuditInfoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderAuditInfoCollection GetMultiOrderAuditInfo(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiOrderAuditInfo(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'OrderAuditInfoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderAuditInfoCollection GetMultiOrderAuditInfo(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedOrderAuditInfo || forceFetch || _alwaysFetchOrderAuditInfo) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_orderAuditInfo);
				_orderAuditInfo.SuppressClearInGetMulti=!forceFetch;
				_orderAuditInfo.EntityFactoryToUse = entityFactoryToUse;
				_orderAuditInfo.GetMultiManyToOne(null, this, null, filter);
				_orderAuditInfo.SuppressClearInGetMulti=false;
				_alreadyFetchedOrderAuditInfo = true;
			}
			return _orderAuditInfo;
		}

		/// <summary> Sets the collection parameters for the collection for 'OrderAuditInfo'. These settings will be taken into account
		/// when the property OrderAuditInfo is requested or GetMultiOrderAuditInfo is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersOrderAuditInfo(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_orderAuditInfo.SortClauses=sortClauses;
			_orderAuditInfo.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_orderDetails.GetMultiManyToOne(this, null, filter);
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

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ProductCollection GetMultiProductsCollectionViaOrderDetails(bool forceFetch)
		{
			return GetMultiProductsCollectionViaOrderDetails(forceFetch, _productsCollectionViaOrderDetails.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ProductCollection GetMultiProductsCollectionViaOrderDetails(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductsCollectionViaOrderDetails || forceFetch || _alwaysFetchProductsCollectionViaOrderDetails) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_productsCollectionViaOrderDetails);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(OrderFields.OrderId, ComparisonOperator.Equal, this.OrderId, "OrderEntity__"));
				_productsCollectionViaOrderDetails.SuppressClearInGetMulti=!forceFetch;
				_productsCollectionViaOrderDetails.EntityFactoryToUse = entityFactoryToUse;
				_productsCollectionViaOrderDetails.GetMulti(filter, GetRelationsForField("ProductsCollectionViaOrderDetails"));
				_productsCollectionViaOrderDetails.SuppressClearInGetMulti=false;
				_alreadyFetchedProductsCollectionViaOrderDetails = true;
			}
			return _productsCollectionViaOrderDetails;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductsCollectionViaOrderDetails'. These settings will be taken into account
		/// when the property ProductsCollectionViaOrderDetails is requested or GetMultiProductsCollectionViaOrderDetails is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductsCollectionViaOrderDetails(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productsCollectionViaOrderDetails.SortClauses=sortClauses;
			_productsCollectionViaOrderDetails.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'CustomerEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'CustomerEntity' which is related to this entity.</returns>
		public CustomerEntity GetSingleCustomers()
		{
			return GetSingleCustomers(false);
		}

		/// <summary> Retrieves the related entity of type 'CustomerEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CustomerEntity' which is related to this entity.</returns>
		public virtual CustomerEntity GetSingleCustomers(bool forceFetch)
		{
			if( ( !_alreadyFetchedCustomers || forceFetch || _alwaysFetchCustomers) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.CustomerEntityUsingCustomerId);
				CustomerEntity newEntity = new CustomerEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.CustomerId);
				}
				if(fetchResult)
				{
					newEntity = (CustomerEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_customersReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Customers = newEntity;
				_alreadyFetchedCustomers = fetchResult;
			}
			return _customers;
		}


		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public EmployeeEntity GetSingleEmployees()
		{
			return GetSingleEmployees(false);
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public virtual EmployeeEntity GetSingleEmployees(bool forceFetch)
		{
			if( ( !_alreadyFetchedEmployees || forceFetch || _alwaysFetchEmployees) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.EmployeeEntityUsingEmployeeId);
				EmployeeEntity newEntity = new EmployeeEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.EmployeeId.GetValueOrDefault());
				}
				if(fetchResult)
				{
					newEntity = (EmployeeEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_employeesReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Employees = newEntity;
				_alreadyFetchedEmployees = fetchResult;
			}
			return _employees;
		}


		/// <summary> Retrieves the related entity of type 'ShipperEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ShipperEntity' which is related to this entity.</returns>
		public ShipperEntity GetSingleShippers()
		{
			return GetSingleShippers(false);
		}

		/// <summary> Retrieves the related entity of type 'ShipperEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ShipperEntity' which is related to this entity.</returns>
		public virtual ShipperEntity GetSingleShippers(bool forceFetch)
		{
			if( ( !_alreadyFetchedShippers || forceFetch || _alwaysFetchShippers) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.ShipperEntityUsingShipVia);
				ShipperEntity newEntity = new ShipperEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ShipVia.GetValueOrDefault());
				}
				if(fetchResult)
				{
					newEntity = (ShipperEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_shippersReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Shippers = newEntity;
				_alreadyFetchedShippers = fetchResult;
			}
			return _shippers;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Customers", _customers);
			toReturn.Add("Employees", _employees);
			toReturn.Add("Shippers", _shippers);
			toReturn.Add("OrderAuditInfo", _orderAuditInfo);
			toReturn.Add("OrderDetails", _orderDetails);
			toReturn.Add("ProductsCollectionViaOrderDetails", _productsCollectionViaOrderDetails);
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
		/// <param name="orderId">PK value for Order which data should be fetched into this Order object</param>
		/// <param name="validator">The validator object for this OrderEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 orderId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(orderId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_orderAuditInfo = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderAuditInfoCollection();
			_orderAuditInfo.SetContainingEntityInfo(this, "Order");

			_orderDetails = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderDetailCollection();
			_orderDetails.SetContainingEntityInfo(this, "Orders");
			_productsCollectionViaOrderDetails = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ProductCollection();
			_customersReturnsNewIfNotFound = true;
			_employeesReturnsNewIfNotFound = true;
			_shippersReturnsNewIfNotFound = true;
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
			_fieldsCustomProperties.Add("CustomerId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("EmployeeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Freight", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("OrderDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("OrderId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("RequiredDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShipAddress", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShipCity", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShipCountry", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShipName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShippedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShipPostalCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShipRegion", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShipVia", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _customers</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCustomers(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _customers, new PropertyChangedEventHandler( OnCustomersPropertyChanged ), "Customers", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticOrderRelations.CustomerEntityUsingCustomerIdStatic, true, signalRelatedEntity, "Orders", resetFKFields, new int[] { (int)OrderFieldIndex.CustomerId } );		
			_customers = null;
		}
		
		/// <summary> setups the sync logic for member _customers</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCustomers(IEntityCore relatedEntity)
		{
			if(_customers!=relatedEntity)
			{		
				DesetupSyncCustomers(true, true);
				_customers = (CustomerEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _customers, new PropertyChangedEventHandler( OnCustomersPropertyChanged ), "Customers", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticOrderRelations.CustomerEntityUsingCustomerIdStatic, true, ref _alreadyFetchedCustomers, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCustomersPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _employees</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployees(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _employees, new PropertyChangedEventHandler( OnEmployeesPropertyChanged ), "Employees", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticOrderRelations.EmployeeEntityUsingEmployeeIdStatic, true, signalRelatedEntity, "Orders", resetFKFields, new int[] { (int)OrderFieldIndex.EmployeeId } );		
			_employees = null;
		}
		
		/// <summary> setups the sync logic for member _employees</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployees(IEntityCore relatedEntity)
		{
			if(_employees!=relatedEntity)
			{		
				DesetupSyncEmployees(true, true);
				_employees = (EmployeeEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _employees, new PropertyChangedEventHandler( OnEmployeesPropertyChanged ), "Employees", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticOrderRelations.EmployeeEntityUsingEmployeeIdStatic, true, ref _alreadyFetchedEmployees, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEmployeesPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _shippers</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncShippers(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _shippers, new PropertyChangedEventHandler( OnShippersPropertyChanged ), "Shippers", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticOrderRelations.ShipperEntityUsingShipViaStatic, true, signalRelatedEntity, "Orders", resetFKFields, new int[] { (int)OrderFieldIndex.ShipVia } );		
			_shippers = null;
		}
		
		/// <summary> setups the sync logic for member _shippers</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncShippers(IEntityCore relatedEntity)
		{
			if(_shippers!=relatedEntity)
			{		
				DesetupSyncShippers(true, true);
				_shippers = (ShipperEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _shippers, new PropertyChangedEventHandler( OnShippersPropertyChanged ), "Shippers", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticOrderRelations.ShipperEntityUsingShipViaStatic, true, ref _alreadyFetchedShippers, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnShippersPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="orderId">PK value for Order which data should be fetched into this Order object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 orderId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)OrderFieldIndex.OrderId].ForcedCurrentValueWrite(orderId);
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
			return DAOFactory.CreateOrderDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new OrderEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static OrderRelations Relations
		{
			get	{ return new OrderRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OrderAuditInfo' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathOrderAuditInfo
		{
			get { return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderAuditInfoCollection(), (IEntityRelation)GetRelationsForField("OrderAuditInfo")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.OrderEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.OrderAuditInfoEntity, 0, null, null, null, "OrderAuditInfo", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OrderDetail' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathOrderDetails
		{
			get { return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderDetailCollection(), (IEntityRelation)GetRelationsForField("OrderDetails")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.OrderEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.OrderDetailEntity, 0, null, null, null, "OrderDetails", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductsCollectionViaOrderDetails
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.OrderDetailEntityUsingOrderId;
				intermediateRelation.SetAliases(string.Empty, "OrderDetail_");
				return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ProductCollection(), intermediateRelation,	(int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.OrderEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.ProductEntity, 0, null, null, GetRelationsForField("ProductsCollectionViaOrderDetails"), "ProductsCollectionViaOrderDetails", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Customer'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomers
		{
			get	{ return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerCollection(), (IEntityRelation)GetRelationsForField("Customers")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.OrderEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.CustomerEntity, 0, null, null, null, "Customers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployees
		{
			get	{ return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection(), (IEntityRelation)GetRelationsForField("Employees")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.OrderEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.EmployeeEntity, 0, null, null, null, "Employees", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Shipper'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShippers
		{
			get	{ return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ShipperCollection(), (IEntityRelation)GetRelationsForField("Shippers")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.OrderEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.ShipperEntity, 0, null, null, null, "Shippers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The CustomerId property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."CustomerID"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 5<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CustomerId
		{
			get { return (System.String)GetValue((int)OrderFieldIndex.CustomerId, true); }
			set	{ SetValue((int)OrderFieldIndex.CustomerId, value, true); }
		}

		/// <summary> The EmployeeId property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."EmployeeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> EmployeeId
		{
			get { return (Nullable<System.Int32>)GetValue((int)OrderFieldIndex.EmployeeId, false); }
			set	{ SetValue((int)OrderFieldIndex.EmployeeId, value, true); }
		}

		/// <summary> The Freight property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."Freight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Freight
		{
			get { return (Nullable<System.Decimal>)GetValue((int)OrderFieldIndex.Freight, false); }
			set	{ SetValue((int)OrderFieldIndex.Freight, value, true); }
		}

		/// <summary> The OrderDate property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."OrderDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> OrderDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)OrderFieldIndex.OrderDate, false); }
			set	{ SetValue((int)OrderFieldIndex.OrderDate, value, true); }
		}

		/// <summary> The OrderId property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."OrderID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 OrderId
		{
			get { return (System.Int32)GetValue((int)OrderFieldIndex.OrderId, true); }
			set	{ SetValue((int)OrderFieldIndex.OrderId, value, true); }
		}

		/// <summary> The RequiredDate property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."RequiredDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> RequiredDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)OrderFieldIndex.RequiredDate, false); }
			set	{ SetValue((int)OrderFieldIndex.RequiredDate, value, true); }
		}

		/// <summary> The ShipAddress property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."ShipAddress"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ShipAddress
		{
			get { return (System.String)GetValue((int)OrderFieldIndex.ShipAddress, true); }
			set	{ SetValue((int)OrderFieldIndex.ShipAddress, value, true); }
		}

		/// <summary> The ShipCity property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."ShipCity"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ShipCity
		{
			get { return (System.String)GetValue((int)OrderFieldIndex.ShipCity, true); }
			set	{ SetValue((int)OrderFieldIndex.ShipCity, value, true); }
		}

		/// <summary> The ShipCountry property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."ShipCountry"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ShipCountry
		{
			get { return (System.String)GetValue((int)OrderFieldIndex.ShipCountry, true); }
			set	{ SetValue((int)OrderFieldIndex.ShipCountry, value, true); }
		}

		/// <summary> The ShipName property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."ShipName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 40<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ShipName
		{
			get { return (System.String)GetValue((int)OrderFieldIndex.ShipName, true); }
			set	{ SetValue((int)OrderFieldIndex.ShipName, value, true); }
		}

		/// <summary> The ShippedDate property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."ShippedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> ShippedDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)OrderFieldIndex.ShippedDate, false); }
			set	{ SetValue((int)OrderFieldIndex.ShippedDate, value, true); }
		}

		/// <summary> The ShipPostalCode property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."ShipPostalCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ShipPostalCode
		{
			get { return (System.String)GetValue((int)OrderFieldIndex.ShipPostalCode, true); }
			set	{ SetValue((int)OrderFieldIndex.ShipPostalCode, value, true); }
		}

		/// <summary> The ShipRegion property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."ShipRegion"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ShipRegion
		{
			get { return (System.String)GetValue((int)OrderFieldIndex.ShipRegion, true); }
			set	{ SetValue((int)OrderFieldIndex.ShipRegion, value, true); }
		}

		/// <summary> The ShipVia property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Orders"."ShipVia"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ShipVia
		{
			get { return (Nullable<System.Int32>)GetValue((int)OrderFieldIndex.ShipVia, false); }
			set	{ SetValue((int)OrderFieldIndex.ShipVia, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'OrderAuditInfoEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiOrderAuditInfo()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderAuditInfoCollection OrderAuditInfo
		{
			get	{ return GetMultiOrderAuditInfo(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for OrderAuditInfo. When set to true, OrderAuditInfo is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time OrderAuditInfo is accessed. You can always execute/ a forced fetch by calling GetMultiOrderAuditInfo(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchOrderAuditInfo
		{
			get	{ return _alwaysFetchOrderAuditInfo; }
			set	{ _alwaysFetchOrderAuditInfo = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property OrderAuditInfo already has been fetched. Setting this property to false when OrderAuditInfo has been fetched
		/// will clear the OrderAuditInfo collection well. Setting this property to true while OrderAuditInfo hasn't been fetched disables lazy loading for OrderAuditInfo</summary>
		[Browsable(false)]
		public bool AlreadyFetchedOrderAuditInfo
		{
			get { return _alreadyFetchedOrderAuditInfo;}
			set 
			{
				if(_alreadyFetchedOrderAuditInfo && !value && (_orderAuditInfo != null))
				{
					_orderAuditInfo.Clear();
				}
				_alreadyFetchedOrderAuditInfo = value;
			}
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

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductsCollectionViaOrderDetails()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ProductCollection ProductsCollectionViaOrderDetails
		{
			get { return GetMultiProductsCollectionViaOrderDetails(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductsCollectionViaOrderDetails. When set to true, ProductsCollectionViaOrderDetails is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductsCollectionViaOrderDetails is accessed. You can always execute a forced fetch by calling GetMultiProductsCollectionViaOrderDetails(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductsCollectionViaOrderDetails
		{
			get	{ return _alwaysFetchProductsCollectionViaOrderDetails; }
			set	{ _alwaysFetchProductsCollectionViaOrderDetails = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductsCollectionViaOrderDetails already has been fetched. Setting this property to false when ProductsCollectionViaOrderDetails has been fetched
		/// will clear the ProductsCollectionViaOrderDetails collection well. Setting this property to true while ProductsCollectionViaOrderDetails hasn't been fetched disables lazy loading for ProductsCollectionViaOrderDetails</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductsCollectionViaOrderDetails
		{
			get { return _alreadyFetchedProductsCollectionViaOrderDetails;}
			set 
			{
				if(_alreadyFetchedProductsCollectionViaOrderDetails && !value && (_productsCollectionViaOrderDetails != null))
				{
					_productsCollectionViaOrderDetails.Clear();
				}
				_alreadyFetchedProductsCollectionViaOrderDetails = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'CustomerEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCustomers()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual CustomerEntity Customers
		{
			get	{ return GetSingleCustomers(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncCustomers(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Orders", "Customers", _customers, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Customers. When set to true, Customers is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Customers is accessed. You can always execute a forced fetch by calling GetSingleCustomers(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomers
		{
			get	{ return _alwaysFetchCustomers; }
			set	{ _alwaysFetchCustomers = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Customers already has been fetched. Setting this property to false when Customers has been fetched
		/// will set Customers to null as well. Setting this property to true while Customers hasn't been fetched disables lazy loading for Customers</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomers
		{
			get { return _alreadyFetchedCustomers;}
			set 
			{
				if(_alreadyFetchedCustomers && !value)
				{
					this.Customers = null;
				}
				_alreadyFetchedCustomers = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Customers is not found
		/// in the database. When set to true, Customers will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool CustomersReturnsNewIfNotFound
		{
			get	{ return _customersReturnsNewIfNotFound; }
			set { _customersReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'EmployeeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleEmployees()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual EmployeeEntity Employees
		{
			get	{ return GetSingleEmployees(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncEmployees(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Orders", "Employees", _employees, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Employees. When set to true, Employees is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employees is accessed. You can always execute a forced fetch by calling GetSingleEmployees(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployees
		{
			get	{ return _alwaysFetchEmployees; }
			set	{ _alwaysFetchEmployees = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Employees already has been fetched. Setting this property to false when Employees has been fetched
		/// will set Employees to null as well. Setting this property to true while Employees hasn't been fetched disables lazy loading for Employees</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployees
		{
			get { return _alreadyFetchedEmployees;}
			set 
			{
				if(_alreadyFetchedEmployees && !value)
				{
					this.Employees = null;
				}
				_alreadyFetchedEmployees = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Employees is not found
		/// in the database. When set to true, Employees will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool EmployeesReturnsNewIfNotFound
		{
			get	{ return _employeesReturnsNewIfNotFound; }
			set { _employeesReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'ShipperEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleShippers()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual ShipperEntity Shippers
		{
			get	{ return GetSingleShippers(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncShippers(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Orders", "Shippers", _shippers, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Shippers. When set to true, Shippers is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Shippers is accessed. You can always execute a forced fetch by calling GetSingleShippers(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchShippers
		{
			get	{ return _alwaysFetchShippers; }
			set	{ _alwaysFetchShippers = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Shippers already has been fetched. Setting this property to false when Shippers has been fetched
		/// will set Shippers to null as well. Setting this property to true while Shippers hasn't been fetched disables lazy loading for Shippers</summary>
		[Browsable(false)]
		public bool AlreadyFetchedShippers
		{
			get { return _alreadyFetchedShippers;}
			set 
			{
				if(_alreadyFetchedShippers && !value)
				{
					this.Shippers = null;
				}
				_alreadyFetchedShippers = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Shippers is not found
		/// in the database. When set to true, Shippers will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ShippersReturnsNewIfNotFound
		{
			get	{ return _shippersReturnsNewIfNotFound; }
			set { _shippersReturnsNewIfNotFound = value; }	
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
			get { return (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.OrderEntity; }
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
