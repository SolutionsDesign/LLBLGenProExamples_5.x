///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: 
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
using Northwind.SSDAL;
using Northwind.SSDAL.FactoryClasses;
using Northwind.SSDAL.DaoClasses;
using Northwind.SSDAL.RelationClasses;
using Northwind.SSDAL.HelperClasses;
using Northwind.SSDAL.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.SSDAL.EntityClasses
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
		private Northwind.SSDAL.CollectionClasses.OrderAuditInfoCollection	_orderAuditInfos;
		private bool	_alwaysFetchOrderAuditInfos, _alreadyFetchedOrderAuditInfos;
		private Northwind.SSDAL.CollectionClasses.OrderDetailCollection	_orderDetails;
		private bool	_alwaysFetchOrderDetails, _alreadyFetchedOrderDetails;
		private CustomerEntity _customer;
		private bool	_alwaysFetchCustomer, _alreadyFetchedCustomer, _customerReturnsNewIfNotFound;
		private EmployeeEntity _employee;
		private bool	_alwaysFetchEmployee, _alreadyFetchedEmployee, _employeeReturnsNewIfNotFound;
		private ShipperEntity _shipper;
		private bool	_alwaysFetchShipper, _alreadyFetchedShipper, _shipperReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Customer</summary>
			public static readonly string Customer = "Customer";
			/// <summary>Member name Employee</summary>
			public static readonly string Employee = "Employee";
			/// <summary>Member name Shipper</summary>
			public static readonly string Shipper = "Shipper";
			/// <summary>Member name OrderAuditInfos</summary>
			public static readonly string OrderAuditInfos = "OrderAuditInfos";
			/// <summary>Member name OrderDetails</summary>
			public static readonly string OrderDetails = "OrderDetails";
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
			_orderAuditInfos = (Northwind.SSDAL.CollectionClasses.OrderAuditInfoCollection)info.GetValue("_orderAuditInfos", typeof(Northwind.SSDAL.CollectionClasses.OrderAuditInfoCollection));
			_alwaysFetchOrderAuditInfos = info.GetBoolean("_alwaysFetchOrderAuditInfos");
			_alreadyFetchedOrderAuditInfos = info.GetBoolean("_alreadyFetchedOrderAuditInfos");

			_orderDetails = (Northwind.SSDAL.CollectionClasses.OrderDetailCollection)info.GetValue("_orderDetails", typeof(Northwind.SSDAL.CollectionClasses.OrderDetailCollection));
			_alwaysFetchOrderDetails = info.GetBoolean("_alwaysFetchOrderDetails");
			_alreadyFetchedOrderDetails = info.GetBoolean("_alreadyFetchedOrderDetails");
			_customer = (CustomerEntity)info.GetValue("_customer", typeof(CustomerEntity));
			if(_customer!=null)
			{
				_customer.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_customerReturnsNewIfNotFound = info.GetBoolean("_customerReturnsNewIfNotFound");
			_alwaysFetchCustomer = info.GetBoolean("_alwaysFetchCustomer");
			_alreadyFetchedCustomer = info.GetBoolean("_alreadyFetchedCustomer");

			_employee = (EmployeeEntity)info.GetValue("_employee", typeof(EmployeeEntity));
			if(_employee!=null)
			{
				_employee.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_employeeReturnsNewIfNotFound = info.GetBoolean("_employeeReturnsNewIfNotFound");
			_alwaysFetchEmployee = info.GetBoolean("_alwaysFetchEmployee");
			_alreadyFetchedEmployee = info.GetBoolean("_alreadyFetchedEmployee");

			_shipper = (ShipperEntity)info.GetValue("_shipper", typeof(ShipperEntity));
			if(_shipper!=null)
			{
				_shipper.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_shipperReturnsNewIfNotFound = info.GetBoolean("_shipperReturnsNewIfNotFound");
			_alwaysFetchShipper = info.GetBoolean("_alwaysFetchShipper");
			_alreadyFetchedShipper = info.GetBoolean("_alreadyFetchedShipper");
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
					DesetupSyncCustomer(true, false);
					_alreadyFetchedCustomer = false;
					break;
				case OrderFieldIndex.EmployeeId:
					DesetupSyncEmployee(true, false);
					_alreadyFetchedEmployee = false;
					break;
				case OrderFieldIndex.ShipVia:
					DesetupSyncShipper(true, false);
					_alreadyFetchedShipper = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedOrderAuditInfos = (_orderAuditInfos.Count > 0);
			_alreadyFetchedOrderDetails = (_orderDetails.Count > 0);
			_alreadyFetchedCustomer = (_customer != null);
			_alreadyFetchedEmployee = (_employee != null);
			_alreadyFetchedShipper = (_shipper != null);
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
				case "Customer":
					toReturn.Add(Relations.CustomerEntityUsingCustomerId);
					break;
				case "Employee":
					toReturn.Add(Relations.EmployeeEntityUsingEmployeeId);
					break;
				case "Shipper":
					toReturn.Add(Relations.ShipperEntityUsingShipVia);
					break;
				case "OrderAuditInfos":
					toReturn.Add(Relations.OrderAuditInfoEntityUsingOrderId);
					break;
				case "OrderDetails":
					toReturn.Add(Relations.OrderDetailEntityUsingOrderId);
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
			info.AddValue("_orderAuditInfos", (!this.MarkedForDeletion?_orderAuditInfos:null));
			info.AddValue("_alwaysFetchOrderAuditInfos", _alwaysFetchOrderAuditInfos);
			info.AddValue("_alreadyFetchedOrderAuditInfos", _alreadyFetchedOrderAuditInfos);
			info.AddValue("_orderDetails", (!this.MarkedForDeletion?_orderDetails:null));
			info.AddValue("_alwaysFetchOrderDetails", _alwaysFetchOrderDetails);
			info.AddValue("_alreadyFetchedOrderDetails", _alreadyFetchedOrderDetails);
			info.AddValue("_customer", (!this.MarkedForDeletion?_customer:null));
			info.AddValue("_customerReturnsNewIfNotFound", _customerReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCustomer", _alwaysFetchCustomer);
			info.AddValue("_alreadyFetchedCustomer", _alreadyFetchedCustomer);
			info.AddValue("_employee", (!this.MarkedForDeletion?_employee:null));
			info.AddValue("_employeeReturnsNewIfNotFound", _employeeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchEmployee", _alwaysFetchEmployee);
			info.AddValue("_alreadyFetchedEmployee", _alreadyFetchedEmployee);
			info.AddValue("_shipper", (!this.MarkedForDeletion?_shipper:null));
			info.AddValue("_shipperReturnsNewIfNotFound", _shipperReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchShipper", _alwaysFetchShipper);
			info.AddValue("_alreadyFetchedShipper", _alreadyFetchedShipper);

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
				case "Customer":
					_alreadyFetchedCustomer = true;
					this.Customer = (CustomerEntity)entity;
					break;
				case "Employee":
					_alreadyFetchedEmployee = true;
					this.Employee = (EmployeeEntity)entity;
					break;
				case "Shipper":
					_alreadyFetchedShipper = true;
					this.Shipper = (ShipperEntity)entity;
					break;
				case "OrderAuditInfos":
					_alreadyFetchedOrderAuditInfos = true;
					if(entity!=null)
					{
						this.OrderAuditInfos.Add((OrderAuditInfoEntity)entity);
					}
					break;
				case "OrderDetails":
					_alreadyFetchedOrderDetails = true;
					if(entity!=null)
					{
						this.OrderDetails.Add((OrderDetailEntity)entity);
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
				case "Customer":
					SetupSyncCustomer(relatedEntity);
					break;
				case "Employee":
					SetupSyncEmployee(relatedEntity);
					break;
				case "Shipper":
					SetupSyncShipper(relatedEntity);
					break;
				case "OrderAuditInfos":
					_orderAuditInfos.Add((OrderAuditInfoEntity)relatedEntity);
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
				case "Customer":
					DesetupSyncCustomer(false, true);
					break;
				case "Employee":
					DesetupSyncEmployee(false, true);
					break;
				case "Shipper":
					DesetupSyncShipper(false, true);
					break;
				case "OrderAuditInfos":
					this.PerformRelatedEntityRemoval(_orderAuditInfos, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_customer!=null)
			{
				toReturn.Add(_customer);
			}
			if(_employee!=null)
			{
				toReturn.Add(_employee);
			}
			if(_shipper!=null)
			{
				toReturn.Add(_shipper);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_orderAuditInfos);
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
		public Northwind.SSDAL.CollectionClasses.OrderAuditInfoCollection GetMultiOrderAuditInfos(bool forceFetch)
		{
			return GetMultiOrderAuditInfos(forceFetch, _orderAuditInfos.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'OrderAuditInfoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'OrderAuditInfoEntity'</returns>
		public Northwind.SSDAL.CollectionClasses.OrderAuditInfoCollection GetMultiOrderAuditInfos(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiOrderAuditInfos(forceFetch, _orderAuditInfos.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'OrderAuditInfoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Northwind.SSDAL.CollectionClasses.OrderAuditInfoCollection GetMultiOrderAuditInfos(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiOrderAuditInfos(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'OrderAuditInfoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Northwind.SSDAL.CollectionClasses.OrderAuditInfoCollection GetMultiOrderAuditInfos(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedOrderAuditInfos || forceFetch || _alwaysFetchOrderAuditInfos) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_orderAuditInfos);
				_orderAuditInfos.SuppressClearInGetMulti=!forceFetch;
				_orderAuditInfos.EntityFactoryToUse = entityFactoryToUse;
				_orderAuditInfos.GetMultiManyToOne(null, this, null, filter);
				_orderAuditInfos.SuppressClearInGetMulti=false;
				_alreadyFetchedOrderAuditInfos = true;
			}
			return _orderAuditInfos;
		}

		/// <summary> Sets the collection parameters for the collection for 'OrderAuditInfos'. These settings will be taken into account
		/// when the property OrderAuditInfos is requested or GetMultiOrderAuditInfos is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersOrderAuditInfos(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_orderAuditInfos.SortClauses=sortClauses;
			_orderAuditInfos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'OrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'OrderDetailEntity'</returns>
		public Northwind.SSDAL.CollectionClasses.OrderDetailCollection GetMultiOrderDetails(bool forceFetch)
		{
			return GetMultiOrderDetails(forceFetch, _orderDetails.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'OrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'OrderDetailEntity'</returns>
		public Northwind.SSDAL.CollectionClasses.OrderDetailCollection GetMultiOrderDetails(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiOrderDetails(forceFetch, _orderDetails.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'OrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Northwind.SSDAL.CollectionClasses.OrderDetailCollection GetMultiOrderDetails(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiOrderDetails(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'OrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Northwind.SSDAL.CollectionClasses.OrderDetailCollection GetMultiOrderDetails(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
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

		/// <summary> Retrieves the related entity of type 'CustomerEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'CustomerEntity' which is related to this entity.</returns>
		public CustomerEntity GetSingleCustomer()
		{
			return GetSingleCustomer(false);
		}

		/// <summary> Retrieves the related entity of type 'CustomerEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CustomerEntity' which is related to this entity.</returns>
		public virtual CustomerEntity GetSingleCustomer(bool forceFetch)
		{
			if( ( !_alreadyFetchedCustomer || forceFetch || _alwaysFetchCustomer) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
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
					if(!_customerReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Customer = newEntity;
				_alreadyFetchedCustomer = fetchResult;
			}
			return _customer;
		}


		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public EmployeeEntity GetSingleEmployee()
		{
			return GetSingleEmployee(false);
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public virtual EmployeeEntity GetSingleEmployee(bool forceFetch)
		{
			if( ( !_alreadyFetchedEmployee || forceFetch || _alwaysFetchEmployee) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
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
					if(!_employeeReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Employee = newEntity;
				_alreadyFetchedEmployee = fetchResult;
			}
			return _employee;
		}


		/// <summary> Retrieves the related entity of type 'ShipperEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ShipperEntity' which is related to this entity.</returns>
		public ShipperEntity GetSingleShipper()
		{
			return GetSingleShipper(false);
		}

		/// <summary> Retrieves the related entity of type 'ShipperEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ShipperEntity' which is related to this entity.</returns>
		public virtual ShipperEntity GetSingleShipper(bool forceFetch)
		{
			if( ( !_alreadyFetchedShipper || forceFetch || _alwaysFetchShipper) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
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
					if(!_shipperReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Shipper = newEntity;
				_alreadyFetchedShipper = fetchResult;
			}
			return _shipper;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Customer", _customer);
			toReturn.Add("Employee", _employee);
			toReturn.Add("Shipper", _shipper);
			toReturn.Add("OrderAuditInfos", _orderAuditInfos);
			toReturn.Add("OrderDetails", _orderDetails);
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

			_orderAuditInfos = new Northwind.SSDAL.CollectionClasses.OrderAuditInfoCollection();
			_orderAuditInfos.SetContainingEntityInfo(this, "Order");

			_orderDetails = new Northwind.SSDAL.CollectionClasses.OrderDetailCollection();
			_orderDetails.SetContainingEntityInfo(this, "Order");
			_customerReturnsNewIfNotFound = false;
			_employeeReturnsNewIfNotFound = false;
			_shipperReturnsNewIfNotFound = false;
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

		/// <summary> Removes the sync logic for member _customer</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCustomer(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _customer, new PropertyChangedEventHandler( OnCustomerPropertyChanged ), "Customer", Northwind.SSDAL.RelationClasses.StaticOrderRelations.CustomerEntityUsingCustomerIdStatic, true, signalRelatedEntity, "Orders", resetFKFields, new int[] { (int)OrderFieldIndex.CustomerId } );		
			_customer = null;
		}
		
		/// <summary> setups the sync logic for member _customer</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCustomer(IEntityCore relatedEntity)
		{
			if(_customer!=relatedEntity)
			{		
				DesetupSyncCustomer(true, true);
				_customer = (CustomerEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _customer, new PropertyChangedEventHandler( OnCustomerPropertyChanged ), "Customer", Northwind.SSDAL.RelationClasses.StaticOrderRelations.CustomerEntityUsingCustomerIdStatic, true, ref _alreadyFetchedCustomer, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCustomerPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _employee</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", Northwind.SSDAL.RelationClasses.StaticOrderRelations.EmployeeEntityUsingEmployeeIdStatic, true, signalRelatedEntity, "Orders", resetFKFields, new int[] { (int)OrderFieldIndex.EmployeeId } );		
			_employee = null;
		}
		
		/// <summary> setups the sync logic for member _employee</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployee(IEntityCore relatedEntity)
		{
			if(_employee!=relatedEntity)
			{		
				DesetupSyncEmployee(true, true);
				_employee = (EmployeeEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", Northwind.SSDAL.RelationClasses.StaticOrderRelations.EmployeeEntityUsingEmployeeIdStatic, true, ref _alreadyFetchedEmployee, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEmployeePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _shipper</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncShipper(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _shipper, new PropertyChangedEventHandler( OnShipperPropertyChanged ), "Shipper", Northwind.SSDAL.RelationClasses.StaticOrderRelations.ShipperEntityUsingShipViaStatic, true, signalRelatedEntity, "Orders", resetFKFields, new int[] { (int)OrderFieldIndex.ShipVia } );		
			_shipper = null;
		}
		
		/// <summary> setups the sync logic for member _shipper</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncShipper(IEntityCore relatedEntity)
		{
			if(_shipper!=relatedEntity)
			{		
				DesetupSyncShipper(true, true);
				_shipper = (ShipperEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _shipper, new PropertyChangedEventHandler( OnShipperPropertyChanged ), "Shipper", Northwind.SSDAL.RelationClasses.StaticOrderRelations.ShipperEntityUsingShipViaStatic, true, ref _alreadyFetchedShipper, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnShipperPropertyChanged( object sender, PropertyChangedEventArgs e )
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
		public static IPrefetchPathElement PrefetchPathOrderAuditInfos
		{
			get { return new PrefetchPathElement(new Northwind.SSDAL.CollectionClasses.OrderAuditInfoCollection(), (IEntityRelation)GetRelationsForField("OrderAuditInfos")[0], (int)Northwind.SSDAL.EntityType.OrderEntity, (int)Northwind.SSDAL.EntityType.OrderAuditInfoEntity, 0, null, null, null, "OrderAuditInfos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OrderDetail' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathOrderDetails
		{
			get { return new PrefetchPathElement(new Northwind.SSDAL.CollectionClasses.OrderDetailCollection(), (IEntityRelation)GetRelationsForField("OrderDetails")[0], (int)Northwind.SSDAL.EntityType.OrderEntity, (int)Northwind.SSDAL.EntityType.OrderDetailEntity, 0, null, null, null, "OrderDetails", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Customer'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomer
		{
			get	{ return new PrefetchPathElement(new Northwind.SSDAL.CollectionClasses.CustomerCollection(), (IEntityRelation)GetRelationsForField("Customer")[0], (int)Northwind.SSDAL.EntityType.OrderEntity, (int)Northwind.SSDAL.EntityType.CustomerEntity, 0, null, null, null, "Customer", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployee
		{
			get	{ return new PrefetchPathElement(new Northwind.SSDAL.CollectionClasses.EmployeeCollection(), (IEntityRelation)GetRelationsForField("Employee")[0], (int)Northwind.SSDAL.EntityType.OrderEntity, (int)Northwind.SSDAL.EntityType.EmployeeEntity, 0, null, null, null, "Employee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Shipper'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShipper
		{
			get	{ return new PrefetchPathElement(new Northwind.SSDAL.CollectionClasses.ShipperCollection(), (IEntityRelation)GetRelationsForField("Shipper")[0], (int)Northwind.SSDAL.EntityType.OrderEntity, (int)Northwind.SSDAL.EntityType.ShipperEntity, 0, null, null, null, "Shipper", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiOrderAuditInfos()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Northwind.SSDAL.CollectionClasses.OrderAuditInfoCollection OrderAuditInfos
		{
			get	{ return GetMultiOrderAuditInfos(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for OrderAuditInfos. When set to true, OrderAuditInfos is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time OrderAuditInfos is accessed. You can always execute/ a forced fetch by calling GetMultiOrderAuditInfos(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchOrderAuditInfos
		{
			get	{ return _alwaysFetchOrderAuditInfos; }
			set	{ _alwaysFetchOrderAuditInfos = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property OrderAuditInfos already has been fetched. Setting this property to false when OrderAuditInfos has been fetched
		/// will clear the OrderAuditInfos collection well. Setting this property to true while OrderAuditInfos hasn't been fetched disables lazy loading for OrderAuditInfos</summary>
		[Browsable(false)]
		public bool AlreadyFetchedOrderAuditInfos
		{
			get { return _alreadyFetchedOrderAuditInfos;}
			set 
			{
				if(_alreadyFetchedOrderAuditInfos && !value && (_orderAuditInfos != null))
				{
					_orderAuditInfos.Clear();
				}
				_alreadyFetchedOrderAuditInfos = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'OrderDetailEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiOrderDetails()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Northwind.SSDAL.CollectionClasses.OrderDetailCollection OrderDetails
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

		/// <summary> Gets / sets related entity of type 'CustomerEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCustomer()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CustomerEntity Customer
		{
			get	{ return GetSingleCustomer(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncCustomer(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Orders", "Customer", _customer, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Customer. When set to true, Customer is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Customer is accessed. You can always execute a forced fetch by calling GetSingleCustomer(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomer
		{
			get	{ return _alwaysFetchCustomer; }
			set	{ _alwaysFetchCustomer = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Customer already has been fetched. Setting this property to false when Customer has been fetched
		/// will set Customer to null as well. Setting this property to true while Customer hasn't been fetched disables lazy loading for Customer</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomer
		{
			get { return _alreadyFetchedCustomer;}
			set 
			{
				if(_alreadyFetchedCustomer && !value)
				{
					this.Customer = null;
				}
				_alreadyFetchedCustomer = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Customer is not found
		/// in the database. When set to true, Customer will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool CustomerReturnsNewIfNotFound
		{
			get	{ return _customerReturnsNewIfNotFound; }
			set { _customerReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'EmployeeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleEmployee()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual EmployeeEntity Employee
		{
			get	{ return GetSingleEmployee(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncEmployee(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Orders", "Employee", _employee, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Employee. When set to true, Employee is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employee is accessed. You can always execute a forced fetch by calling GetSingleEmployee(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployee
		{
			get	{ return _alwaysFetchEmployee; }
			set	{ _alwaysFetchEmployee = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Employee already has been fetched. Setting this property to false when Employee has been fetched
		/// will set Employee to null as well. Setting this property to true while Employee hasn't been fetched disables lazy loading for Employee</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployee
		{
			get { return _alreadyFetchedEmployee;}
			set 
			{
				if(_alreadyFetchedEmployee && !value)
				{
					this.Employee = null;
				}
				_alreadyFetchedEmployee = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Employee is not found
		/// in the database. When set to true, Employee will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool EmployeeReturnsNewIfNotFound
		{
			get	{ return _employeeReturnsNewIfNotFound; }
			set { _employeeReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'ShipperEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleShipper()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ShipperEntity Shipper
		{
			get	{ return GetSingleShipper(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncShipper(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Orders", "Shipper", _shipper, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Shipper. When set to true, Shipper is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Shipper is accessed. You can always execute a forced fetch by calling GetSingleShipper(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchShipper
		{
			get	{ return _alwaysFetchShipper; }
			set	{ _alwaysFetchShipper = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Shipper already has been fetched. Setting this property to false when Shipper has been fetched
		/// will set Shipper to null as well. Setting this property to true while Shipper hasn't been fetched disables lazy loading for Shipper</summary>
		[Browsable(false)]
		public bool AlreadyFetchedShipper
		{
			get { return _alreadyFetchedShipper;}
			set 
			{
				if(_alreadyFetchedShipper && !value)
				{
					this.Shipper = null;
				}
				_alreadyFetchedShipper = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Shipper is not found
		/// in the database. When set to true, Shipper will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool ShipperReturnsNewIfNotFound
		{
			get	{ return _shipperReturnsNewIfNotFound; }
			set { _shipperReturnsNewIfNotFound = value; }	
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
		
		/// <summary>Returns the Northwind.SSDAL.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)Northwind.SSDAL.EntityType.OrderEntity; }
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
