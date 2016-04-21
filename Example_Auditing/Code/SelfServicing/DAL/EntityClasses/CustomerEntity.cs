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

	/// <summary>Entity class which represents the entity 'Customer'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class CustomerEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerCustomerDemoCollection	_customerCustomerDemo;
		private bool	_alwaysFetchCustomerCustomerDemo, _alreadyFetchedCustomerCustomerDemo;
		private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection	_orders;
		private bool	_alwaysFetchOrders, _alreadyFetchedOrders;
		private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerDemographyCollection _customerDemographicsCollectionViaCustomerCustomerDemo;
		private bool	_alwaysFetchCustomerDemographicsCollectionViaCustomerCustomerDemo, _alreadyFetchedCustomerDemographicsCollectionViaCustomerCustomerDemo;
		private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection _employeesCollectionViaOrders;
		private bool	_alwaysFetchEmployeesCollectionViaOrders, _alreadyFetchedEmployeesCollectionViaOrders;
		private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ShipperCollection _shippersCollectionViaOrders;
		private bool	_alwaysFetchShippersCollectionViaOrders, _alreadyFetchedShippersCollectionViaOrders;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name CustomerCustomerDemo</summary>
			public static readonly string CustomerCustomerDemo = "CustomerCustomerDemo";
			/// <summary>Member name Orders</summary>
			public static readonly string Orders = "Orders";
			/// <summary>Member name CustomerDemographicsCollectionViaCustomerCustomerDemo</summary>
			public static readonly string CustomerDemographicsCollectionViaCustomerCustomerDemo = "CustomerDemographicsCollectionViaCustomerCustomerDemo";
			/// <summary>Member name EmployeesCollectionViaOrders</summary>
			public static readonly string EmployeesCollectionViaOrders = "EmployeesCollectionViaOrders";
			/// <summary>Member name ShippersCollectionViaOrders</summary>
			public static readonly string ShippersCollectionViaOrders = "ShippersCollectionViaOrders";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CustomerEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public CustomerEntity() :base("CustomerEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="customerId">PK value for Customer which data should be fetched into this Customer object</param>
		public CustomerEntity(System.String customerId):base("CustomerEntity")
		{
			InitClassFetch(customerId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="customerId">PK value for Customer which data should be fetched into this Customer object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CustomerEntity(System.String customerId, IPrefetchPath prefetchPathToUse):base("CustomerEntity")
		{
			InitClassFetch(customerId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="customerId">PK value for Customer which data should be fetched into this Customer object</param>
		/// <param name="validator">The custom validator object for this CustomerEntity</param>
		public CustomerEntity(System.String customerId, IValidator validator):base("CustomerEntity")
		{
			InitClassFetch(customerId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CustomerEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_customerCustomerDemo = (SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerCustomerDemoCollection)info.GetValue("_customerCustomerDemo", typeof(SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerCustomerDemoCollection));
			_alwaysFetchCustomerCustomerDemo = info.GetBoolean("_alwaysFetchCustomerCustomerDemo");
			_alreadyFetchedCustomerCustomerDemo = info.GetBoolean("_alreadyFetchedCustomerCustomerDemo");

			_orders = (SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection)info.GetValue("_orders", typeof(SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection));
			_alwaysFetchOrders = info.GetBoolean("_alwaysFetchOrders");
			_alreadyFetchedOrders = info.GetBoolean("_alreadyFetchedOrders");
			_customerDemographicsCollectionViaCustomerCustomerDemo = (SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerDemographyCollection)info.GetValue("_customerDemographicsCollectionViaCustomerCustomerDemo", typeof(SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerDemographyCollection));
			_alwaysFetchCustomerDemographicsCollectionViaCustomerCustomerDemo = info.GetBoolean("_alwaysFetchCustomerDemographicsCollectionViaCustomerCustomerDemo");
			_alreadyFetchedCustomerDemographicsCollectionViaCustomerCustomerDemo = info.GetBoolean("_alreadyFetchedCustomerDemographicsCollectionViaCustomerCustomerDemo");

			_employeesCollectionViaOrders = (SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection)info.GetValue("_employeesCollectionViaOrders", typeof(SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeesCollectionViaOrders = info.GetBoolean("_alwaysFetchEmployeesCollectionViaOrders");
			_alreadyFetchedEmployeesCollectionViaOrders = info.GetBoolean("_alreadyFetchedEmployeesCollectionViaOrders");

			_shippersCollectionViaOrders = (SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ShipperCollection)info.GetValue("_shippersCollectionViaOrders", typeof(SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ShipperCollection));
			_alwaysFetchShippersCollectionViaOrders = info.GetBoolean("_alwaysFetchShippersCollectionViaOrders");
			_alreadyFetchedShippersCollectionViaOrders = info.GetBoolean("_alreadyFetchedShippersCollectionViaOrders");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedCustomerCustomerDemo = (_customerCustomerDemo.Count > 0);
			_alreadyFetchedOrders = (_orders.Count > 0);
			_alreadyFetchedCustomerDemographicsCollectionViaCustomerCustomerDemo = (_customerDemographicsCollectionViaCustomerCustomerDemo.Count > 0);
			_alreadyFetchedEmployeesCollectionViaOrders = (_employeesCollectionViaOrders.Count > 0);
			_alreadyFetchedShippersCollectionViaOrders = (_shippersCollectionViaOrders.Count > 0);
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
				case "CustomerCustomerDemo":
					toReturn.Add(Relations.CustomerCustomerDemoEntityUsingCustomerId);
					break;
				case "Orders":
					toReturn.Add(Relations.OrderEntityUsingCustomerId);
					break;
				case "CustomerDemographicsCollectionViaCustomerCustomerDemo":
					toReturn.Add(Relations.CustomerCustomerDemoEntityUsingCustomerId, "CustomerEntity__", "CustomerCustomerDemo_", JoinHint.None);
					toReturn.Add(CustomerCustomerDemoEntity.Relations.CustomerDemographyEntityUsingCustomerTypeId, "CustomerCustomerDemo_", string.Empty, JoinHint.None);
					break;
				case "EmployeesCollectionViaOrders":
					toReturn.Add(Relations.OrderEntityUsingCustomerId, "CustomerEntity__", "Order_", JoinHint.None);
					toReturn.Add(OrderEntity.Relations.EmployeeEntityUsingEmployeeId, "Order_", string.Empty, JoinHint.None);
					break;
				case "ShippersCollectionViaOrders":
					toReturn.Add(Relations.OrderEntityUsingCustomerId, "CustomerEntity__", "Order_", JoinHint.None);
					toReturn.Add(OrderEntity.Relations.ShipperEntityUsingShipVia, "Order_", string.Empty, JoinHint.None);
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
			info.AddValue("_customerCustomerDemo", (!this.MarkedForDeletion?_customerCustomerDemo:null));
			info.AddValue("_alwaysFetchCustomerCustomerDemo", _alwaysFetchCustomerCustomerDemo);
			info.AddValue("_alreadyFetchedCustomerCustomerDemo", _alreadyFetchedCustomerCustomerDemo);
			info.AddValue("_orders", (!this.MarkedForDeletion?_orders:null));
			info.AddValue("_alwaysFetchOrders", _alwaysFetchOrders);
			info.AddValue("_alreadyFetchedOrders", _alreadyFetchedOrders);
			info.AddValue("_customerDemographicsCollectionViaCustomerCustomerDemo", (!this.MarkedForDeletion?_customerDemographicsCollectionViaCustomerCustomerDemo:null));
			info.AddValue("_alwaysFetchCustomerDemographicsCollectionViaCustomerCustomerDemo", _alwaysFetchCustomerDemographicsCollectionViaCustomerCustomerDemo);
			info.AddValue("_alreadyFetchedCustomerDemographicsCollectionViaCustomerCustomerDemo", _alreadyFetchedCustomerDemographicsCollectionViaCustomerCustomerDemo);
			info.AddValue("_employeesCollectionViaOrders", (!this.MarkedForDeletion?_employeesCollectionViaOrders:null));
			info.AddValue("_alwaysFetchEmployeesCollectionViaOrders", _alwaysFetchEmployeesCollectionViaOrders);
			info.AddValue("_alreadyFetchedEmployeesCollectionViaOrders", _alreadyFetchedEmployeesCollectionViaOrders);
			info.AddValue("_shippersCollectionViaOrders", (!this.MarkedForDeletion?_shippersCollectionViaOrders:null));
			info.AddValue("_alwaysFetchShippersCollectionViaOrders", _alwaysFetchShippersCollectionViaOrders);
			info.AddValue("_alreadyFetchedShippersCollectionViaOrders", _alreadyFetchedShippersCollectionViaOrders);

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
				case "CustomerCustomerDemo":
					_alreadyFetchedCustomerCustomerDemo = true;
					if(entity!=null)
					{
						this.CustomerCustomerDemo.Add((CustomerCustomerDemoEntity)entity);
					}
					break;
				case "Orders":
					_alreadyFetchedOrders = true;
					if(entity!=null)
					{
						this.Orders.Add((OrderEntity)entity);
					}
					break;
				case "CustomerDemographicsCollectionViaCustomerCustomerDemo":
					_alreadyFetchedCustomerDemographicsCollectionViaCustomerCustomerDemo = true;
					if(entity!=null)
					{
						this.CustomerDemographicsCollectionViaCustomerCustomerDemo.Add((CustomerDemographyEntity)entity);
					}
					break;
				case "EmployeesCollectionViaOrders":
					_alreadyFetchedEmployeesCollectionViaOrders = true;
					if(entity!=null)
					{
						this.EmployeesCollectionViaOrders.Add((EmployeeEntity)entity);
					}
					break;
				case "ShippersCollectionViaOrders":
					_alreadyFetchedShippersCollectionViaOrders = true;
					if(entity!=null)
					{
						this.ShippersCollectionViaOrders.Add((ShipperEntity)entity);
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
				case "CustomerCustomerDemo":
					_customerCustomerDemo.Add((CustomerCustomerDemoEntity)relatedEntity);
					break;
				case "Orders":
					_orders.Add((OrderEntity)relatedEntity);
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
				case "CustomerCustomerDemo":
					this.PerformRelatedEntityRemoval(_customerCustomerDemo, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Orders":
					this.PerformRelatedEntityRemoval(_orders, relatedEntity, signalRelatedEntityManyToOne);
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
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_customerCustomerDemo);
			toReturn.Add(_orders);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerId">PK value for Customer which data should be fetched into this Customer object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String customerId)
		{
			return FetchUsingPK(customerId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerId">PK value for Customer which data should be fetched into this Customer object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String customerId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(customerId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerId">PK value for Customer which data should be fetched into this Customer object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String customerId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(customerId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerId">PK value for Customer which data should be fetched into this Customer object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String customerId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(customerId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CustomerId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new CustomerRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'CustomerCustomerDemoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerCustomerDemoEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerCustomerDemoCollection GetMultiCustomerCustomerDemo(bool forceFetch)
		{
			return GetMultiCustomerCustomerDemo(forceFetch, _customerCustomerDemo.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CustomerCustomerDemoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'CustomerCustomerDemoEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerCustomerDemoCollection GetMultiCustomerCustomerDemo(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiCustomerCustomerDemo(forceFetch, _customerCustomerDemo.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'CustomerCustomerDemoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerCustomerDemoCollection GetMultiCustomerCustomerDemo(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiCustomerCustomerDemo(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CustomerCustomerDemoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerCustomerDemoCollection GetMultiCustomerCustomerDemo(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedCustomerCustomerDemo || forceFetch || _alwaysFetchCustomerCustomerDemo) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_customerCustomerDemo);
				_customerCustomerDemo.SuppressClearInGetMulti=!forceFetch;
				_customerCustomerDemo.EntityFactoryToUse = entityFactoryToUse;
				_customerCustomerDemo.GetMultiManyToOne(this, null, filter);
				_customerCustomerDemo.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerCustomerDemo = true;
			}
			return _customerCustomerDemo;
		}

		/// <summary> Sets the collection parameters for the collection for 'CustomerCustomerDemo'. These settings will be taken into account
		/// when the property CustomerCustomerDemo is requested or GetMultiCustomerCustomerDemo is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomerCustomerDemo(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customerCustomerDemo.SortClauses=sortClauses;
			_customerCustomerDemo.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'OrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'OrderEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection GetMultiOrders(bool forceFetch)
		{
			return GetMultiOrders(forceFetch, _orders.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'OrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'OrderEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection GetMultiOrders(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiOrders(forceFetch, _orders.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'OrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection GetMultiOrders(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiOrders(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'OrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection GetMultiOrders(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedOrders || forceFetch || _alwaysFetchOrders) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_orders);
				_orders.SuppressClearInGetMulti=!forceFetch;
				_orders.EntityFactoryToUse = entityFactoryToUse;
				_orders.GetMultiManyToOne(this, null, null, filter);
				_orders.SuppressClearInGetMulti=false;
				_alreadyFetchedOrders = true;
			}
			return _orders;
		}

		/// <summary> Sets the collection parameters for the collection for 'Orders'. These settings will be taken into account
		/// when the property Orders is requested or GetMultiOrders is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersOrders(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_orders.SortClauses=sortClauses;
			_orders.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'CustomerDemographyEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerDemographyEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerDemographyCollection GetMultiCustomerDemographicsCollectionViaCustomerCustomerDemo(bool forceFetch)
		{
			return GetMultiCustomerDemographicsCollectionViaCustomerCustomerDemo(forceFetch, _customerDemographicsCollectionViaCustomerCustomerDemo.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CustomerDemographyEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerDemographyCollection GetMultiCustomerDemographicsCollectionViaCustomerCustomerDemo(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCustomerDemographicsCollectionViaCustomerCustomerDemo || forceFetch || _alwaysFetchCustomerDemographicsCollectionViaCustomerCustomerDemo) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_customerDemographicsCollectionViaCustomerCustomerDemo);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(CustomerFields.CustomerId, ComparisonOperator.Equal, this.CustomerId, "CustomerEntity__"));
				_customerDemographicsCollectionViaCustomerCustomerDemo.SuppressClearInGetMulti=!forceFetch;
				_customerDemographicsCollectionViaCustomerCustomerDemo.EntityFactoryToUse = entityFactoryToUse;
				_customerDemographicsCollectionViaCustomerCustomerDemo.GetMulti(filter, GetRelationsForField("CustomerDemographicsCollectionViaCustomerCustomerDemo"));
				_customerDemographicsCollectionViaCustomerCustomerDemo.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerDemographicsCollectionViaCustomerCustomerDemo = true;
			}
			return _customerDemographicsCollectionViaCustomerCustomerDemo;
		}

		/// <summary> Sets the collection parameters for the collection for 'CustomerDemographicsCollectionViaCustomerCustomerDemo'. These settings will be taken into account
		/// when the property CustomerDemographicsCollectionViaCustomerCustomerDemo is requested or GetMultiCustomerDemographicsCollectionViaCustomerCustomerDemo is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomerDemographicsCollectionViaCustomerCustomerDemo(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customerDemographicsCollectionViaCustomerCustomerDemo.SortClauses=sortClauses;
			_customerDemographicsCollectionViaCustomerCustomerDemo.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection GetMultiEmployeesCollectionViaOrders(bool forceFetch)
		{
			return GetMultiEmployeesCollectionViaOrders(forceFetch, _employeesCollectionViaOrders.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection GetMultiEmployeesCollectionViaOrders(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeesCollectionViaOrders || forceFetch || _alwaysFetchEmployeesCollectionViaOrders) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_employeesCollectionViaOrders);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(CustomerFields.CustomerId, ComparisonOperator.Equal, this.CustomerId, "CustomerEntity__"));
				_employeesCollectionViaOrders.SuppressClearInGetMulti=!forceFetch;
				_employeesCollectionViaOrders.EntityFactoryToUse = entityFactoryToUse;
				_employeesCollectionViaOrders.GetMulti(filter, GetRelationsForField("EmployeesCollectionViaOrders"));
				_employeesCollectionViaOrders.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeesCollectionViaOrders = true;
			}
			return _employeesCollectionViaOrders;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeesCollectionViaOrders'. These settings will be taken into account
		/// when the property EmployeesCollectionViaOrders is requested or GetMultiEmployeesCollectionViaOrders is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeesCollectionViaOrders(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeesCollectionViaOrders.SortClauses=sortClauses;
			_employeesCollectionViaOrders.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ShipperEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ShipperEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ShipperCollection GetMultiShippersCollectionViaOrders(bool forceFetch)
		{
			return GetMultiShippersCollectionViaOrders(forceFetch, _shippersCollectionViaOrders.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ShipperEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ShipperCollection GetMultiShippersCollectionViaOrders(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedShippersCollectionViaOrders || forceFetch || _alwaysFetchShippersCollectionViaOrders) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_shippersCollectionViaOrders);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(CustomerFields.CustomerId, ComparisonOperator.Equal, this.CustomerId, "CustomerEntity__"));
				_shippersCollectionViaOrders.SuppressClearInGetMulti=!forceFetch;
				_shippersCollectionViaOrders.EntityFactoryToUse = entityFactoryToUse;
				_shippersCollectionViaOrders.GetMulti(filter, GetRelationsForField("ShippersCollectionViaOrders"));
				_shippersCollectionViaOrders.SuppressClearInGetMulti=false;
				_alreadyFetchedShippersCollectionViaOrders = true;
			}
			return _shippersCollectionViaOrders;
		}

		/// <summary> Sets the collection parameters for the collection for 'ShippersCollectionViaOrders'. These settings will be taken into account
		/// when the property ShippersCollectionViaOrders is requested or GetMultiShippersCollectionViaOrders is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersShippersCollectionViaOrders(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_shippersCollectionViaOrders.SortClauses=sortClauses;
			_shippersCollectionViaOrders.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("CustomerCustomerDemo", _customerCustomerDemo);
			toReturn.Add("Orders", _orders);
			toReturn.Add("CustomerDemographicsCollectionViaCustomerCustomerDemo", _customerDemographicsCollectionViaCustomerCustomerDemo);
			toReturn.Add("EmployeesCollectionViaOrders", _employeesCollectionViaOrders);
			toReturn.Add("ShippersCollectionViaOrders", _shippersCollectionViaOrders);
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
		/// <param name="customerId">PK value for Customer which data should be fetched into this Customer object</param>
		/// <param name="validator">The validator object for this CustomerEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.String customerId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(customerId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_customerCustomerDemo = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerCustomerDemoCollection();
			_customerCustomerDemo.SetContainingEntityInfo(this, "Customers");

			_orders = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection();
			_orders.SetContainingEntityInfo(this, "Customers");
			_customerDemographicsCollectionViaCustomerCustomerDemo = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerDemographyCollection();
			_employeesCollectionViaOrders = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection();
			_shippersCollectionViaOrders = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ShipperCollection();
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
			_fieldsCustomProperties.Add("Address", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("City", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CompanyName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ContactName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ContactTitle", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Country", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CustomerId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Fax", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Phone", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PostalCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Region", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="customerId">PK value for Customer which data should be fetched into this Customer object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.String customerId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)CustomerFieldIndex.CustomerId].ForcedCurrentValueWrite(customerId);
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
			return DAOFactory.CreateCustomerDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new CustomerEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static CustomerRelations Relations
		{
			get	{ return new CustomerRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CustomerCustomerDemo' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerCustomerDemo
		{
			get { return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerCustomerDemoCollection(), (IEntityRelation)GetRelationsForField("CustomerCustomerDemo")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.CustomerEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.CustomerCustomerDemoEntity, 0, null, null, null, "CustomerCustomerDemo", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Order' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathOrders
		{
			get { return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection(), (IEntityRelation)GetRelationsForField("Orders")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.CustomerEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.OrderEntity, 0, null, null, null, "Orders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CustomerDemography'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerDemographicsCollectionViaCustomerCustomerDemo
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.CustomerCustomerDemoEntityUsingCustomerId;
				intermediateRelation.SetAliases(string.Empty, "CustomerCustomerDemo_");
				return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerDemographyCollection(), intermediateRelation,	(int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.CustomerEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.CustomerDemographyEntity, 0, null, null, GetRelationsForField("CustomerDemographicsCollectionViaCustomerCustomerDemo"), "CustomerDemographicsCollectionViaCustomerCustomerDemo", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeesCollectionViaOrders
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.OrderEntityUsingCustomerId;
				intermediateRelation.SetAliases(string.Empty, "Order_");
				return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection(), intermediateRelation,	(int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.CustomerEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeesCollectionViaOrders"), "EmployeesCollectionViaOrders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Shipper'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShippersCollectionViaOrders
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.OrderEntityUsingCustomerId;
				intermediateRelation.SetAliases(string.Empty, "Order_");
				return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ShipperCollection(), intermediateRelation,	(int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.CustomerEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.ShipperEntity, 0, null, null, GetRelationsForField("ShippersCollectionViaOrders"), "ShippersCollectionViaOrders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
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

		/// <summary> The Address property of the Entity Customer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Customers"."Address"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Address
		{
			get { return (System.String)GetValue((int)CustomerFieldIndex.Address, true); }
			set	{ SetValue((int)CustomerFieldIndex.Address, value, true); }
		}

		/// <summary> The City property of the Entity Customer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Customers"."City"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String City
		{
			get { return (System.String)GetValue((int)CustomerFieldIndex.City, true); }
			set	{ SetValue((int)CustomerFieldIndex.City, value, true); }
		}

		/// <summary> The CompanyName property of the Entity Customer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Customers"."CompanyName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 40<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CompanyName
		{
			get { return (System.String)GetValue((int)CustomerFieldIndex.CompanyName, true); }
			set	{ SetValue((int)CustomerFieldIndex.CompanyName, value, true); }
		}

		/// <summary> The ContactName property of the Entity Customer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Customers"."ContactName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 30<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ContactName
		{
			get { return (System.String)GetValue((int)CustomerFieldIndex.ContactName, true); }
			set	{ SetValue((int)CustomerFieldIndex.ContactName, value, true); }
		}

		/// <summary> The ContactTitle property of the Entity Customer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Customers"."ContactTitle"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 30<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ContactTitle
		{
			get { return (System.String)GetValue((int)CustomerFieldIndex.ContactTitle, true); }
			set	{ SetValue((int)CustomerFieldIndex.ContactTitle, value, true); }
		}

		/// <summary> The Country property of the Entity Customer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Customers"."Country"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Country
		{
			get { return (System.String)GetValue((int)CustomerFieldIndex.Country, true); }
			set	{ SetValue((int)CustomerFieldIndex.Country, value, true); }
		}

		/// <summary> The CustomerId property of the Entity Customer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Customers"."CustomerID"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 5<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CustomerId
		{
			get { return (System.String)GetValue((int)CustomerFieldIndex.CustomerId, true); }
			set	{ SetValue((int)CustomerFieldIndex.CustomerId, value, true); }
		}

		/// <summary> The Fax property of the Entity Customer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Customers"."Fax"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 24<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Fax
		{
			get { return (System.String)GetValue((int)CustomerFieldIndex.Fax, true); }
			set	{ SetValue((int)CustomerFieldIndex.Fax, value, true); }
		}

		/// <summary> The Phone property of the Entity Customer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Customers"."Phone"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 24<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Phone
		{
			get { return (System.String)GetValue((int)CustomerFieldIndex.Phone, true); }
			set	{ SetValue((int)CustomerFieldIndex.Phone, value, true); }
		}

		/// <summary> The PostalCode property of the Entity Customer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Customers"."PostalCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String PostalCode
		{
			get { return (System.String)GetValue((int)CustomerFieldIndex.PostalCode, true); }
			set	{ SetValue((int)CustomerFieldIndex.PostalCode, value, true); }
		}

		/// <summary> The Region property of the Entity Customer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Customers"."Region"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Region
		{
			get { return (System.String)GetValue((int)CustomerFieldIndex.Region, true); }
			set	{ SetValue((int)CustomerFieldIndex.Region, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'CustomerCustomerDemoEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerCustomerDemo()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerCustomerDemoCollection CustomerCustomerDemo
		{
			get	{ return GetMultiCustomerCustomerDemo(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerCustomerDemo. When set to true, CustomerCustomerDemo is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerCustomerDemo is accessed. You can always execute/ a forced fetch by calling GetMultiCustomerCustomerDemo(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerCustomerDemo
		{
			get	{ return _alwaysFetchCustomerCustomerDemo; }
			set	{ _alwaysFetchCustomerCustomerDemo = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerCustomerDemo already has been fetched. Setting this property to false when CustomerCustomerDemo has been fetched
		/// will clear the CustomerCustomerDemo collection well. Setting this property to true while CustomerCustomerDemo hasn't been fetched disables lazy loading for CustomerCustomerDemo</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerCustomerDemo
		{
			get { return _alreadyFetchedCustomerCustomerDemo;}
			set 
			{
				if(_alreadyFetchedCustomerCustomerDemo && !value && (_customerCustomerDemo != null))
				{
					_customerCustomerDemo.Clear();
				}
				_alreadyFetchedCustomerCustomerDemo = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'OrderEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiOrders()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection Orders
		{
			get	{ return GetMultiOrders(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Orders. When set to true, Orders is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Orders is accessed. You can always execute/ a forced fetch by calling GetMultiOrders(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchOrders
		{
			get	{ return _alwaysFetchOrders; }
			set	{ _alwaysFetchOrders = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Orders already has been fetched. Setting this property to false when Orders has been fetched
		/// will clear the Orders collection well. Setting this property to true while Orders hasn't been fetched disables lazy loading for Orders</summary>
		[Browsable(false)]
		public bool AlreadyFetchedOrders
		{
			get { return _alreadyFetchedOrders;}
			set 
			{
				if(_alreadyFetchedOrders && !value && (_orders != null))
				{
					_orders.Clear();
				}
				_alreadyFetchedOrders = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'CustomerDemographyEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerDemographicsCollectionViaCustomerCustomerDemo()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerDemographyCollection CustomerDemographicsCollectionViaCustomerCustomerDemo
		{
			get { return GetMultiCustomerDemographicsCollectionViaCustomerCustomerDemo(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerDemographicsCollectionViaCustomerCustomerDemo. When set to true, CustomerDemographicsCollectionViaCustomerCustomerDemo is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerDemographicsCollectionViaCustomerCustomerDemo is accessed. You can always execute a forced fetch by calling GetMultiCustomerDemographicsCollectionViaCustomerCustomerDemo(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerDemographicsCollectionViaCustomerCustomerDemo
		{
			get	{ return _alwaysFetchCustomerDemographicsCollectionViaCustomerCustomerDemo; }
			set	{ _alwaysFetchCustomerDemographicsCollectionViaCustomerCustomerDemo = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerDemographicsCollectionViaCustomerCustomerDemo already has been fetched. Setting this property to false when CustomerDemographicsCollectionViaCustomerCustomerDemo has been fetched
		/// will clear the CustomerDemographicsCollectionViaCustomerCustomerDemo collection well. Setting this property to true while CustomerDemographicsCollectionViaCustomerCustomerDemo hasn't been fetched disables lazy loading for CustomerDemographicsCollectionViaCustomerCustomerDemo</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerDemographicsCollectionViaCustomerCustomerDemo
		{
			get { return _alreadyFetchedCustomerDemographicsCollectionViaCustomerCustomerDemo;}
			set 
			{
				if(_alreadyFetchedCustomerDemographicsCollectionViaCustomerCustomerDemo && !value && (_customerDemographicsCollectionViaCustomerCustomerDemo != null))
				{
					_customerDemographicsCollectionViaCustomerCustomerDemo.Clear();
				}
				_alreadyFetchedCustomerDemographicsCollectionViaCustomerCustomerDemo = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeesCollectionViaOrders()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection EmployeesCollectionViaOrders
		{
			get { return GetMultiEmployeesCollectionViaOrders(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeesCollectionViaOrders. When set to true, EmployeesCollectionViaOrders is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeesCollectionViaOrders is accessed. You can always execute a forced fetch by calling GetMultiEmployeesCollectionViaOrders(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeesCollectionViaOrders
		{
			get	{ return _alwaysFetchEmployeesCollectionViaOrders; }
			set	{ _alwaysFetchEmployeesCollectionViaOrders = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeesCollectionViaOrders already has been fetched. Setting this property to false when EmployeesCollectionViaOrders has been fetched
		/// will clear the EmployeesCollectionViaOrders collection well. Setting this property to true while EmployeesCollectionViaOrders hasn't been fetched disables lazy loading for EmployeesCollectionViaOrders</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeesCollectionViaOrders
		{
			get { return _alreadyFetchedEmployeesCollectionViaOrders;}
			set 
			{
				if(_alreadyFetchedEmployeesCollectionViaOrders && !value && (_employeesCollectionViaOrders != null))
				{
					_employeesCollectionViaOrders.Clear();
				}
				_alreadyFetchedEmployeesCollectionViaOrders = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'ShipperEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiShippersCollectionViaOrders()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ShipperCollection ShippersCollectionViaOrders
		{
			get { return GetMultiShippersCollectionViaOrders(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ShippersCollectionViaOrders. When set to true, ShippersCollectionViaOrders is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ShippersCollectionViaOrders is accessed. You can always execute a forced fetch by calling GetMultiShippersCollectionViaOrders(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchShippersCollectionViaOrders
		{
			get	{ return _alwaysFetchShippersCollectionViaOrders; }
			set	{ _alwaysFetchShippersCollectionViaOrders = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ShippersCollectionViaOrders already has been fetched. Setting this property to false when ShippersCollectionViaOrders has been fetched
		/// will clear the ShippersCollectionViaOrders collection well. Setting this property to true while ShippersCollectionViaOrders hasn't been fetched disables lazy loading for ShippersCollectionViaOrders</summary>
		[Browsable(false)]
		public bool AlreadyFetchedShippersCollectionViaOrders
		{
			get { return _alreadyFetchedShippersCollectionViaOrders;}
			set 
			{
				if(_alreadyFetchedShippersCollectionViaOrders && !value && (_shippersCollectionViaOrders != null))
				{
					_shippersCollectionViaOrders.Clear();
				}
				_alreadyFetchedShippersCollectionViaOrders = value;
			}
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
			get { return (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.CustomerEntity; }
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
