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

	/// <summary>Entity class which represents the entity 'Employee'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class EmployeeEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private Northwind.SSDAL.CollectionClasses.EmployeeCollection	_employees;
		private bool	_alwaysFetchEmployees, _alreadyFetchedEmployees;
		private Northwind.SSDAL.CollectionClasses.EmployeeTerritoryCollection	_employeeTerritories;
		private bool	_alwaysFetchEmployeeTerritories, _alreadyFetchedEmployeeTerritories;
		private Northwind.SSDAL.CollectionClasses.OrderCollection	_orders;
		private bool	_alwaysFetchOrders, _alreadyFetchedOrders;
		private EmployeeEntity _employee;
		private bool	_alwaysFetchEmployee, _alreadyFetchedEmployee, _employeeReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Employee</summary>
			public static readonly string Employee = "Employee";
			/// <summary>Member name Employees</summary>
			public static readonly string Employees = "Employees";
			/// <summary>Member name EmployeeTerritories</summary>
			public static readonly string EmployeeTerritories = "EmployeeTerritories";
			/// <summary>Member name Orders</summary>
			public static readonly string Orders = "Orders";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static EmployeeEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public EmployeeEntity() :base("EmployeeEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		public EmployeeEntity(System.Int32 employeeId):base("EmployeeEntity")
		{
			InitClassFetch(employeeId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public EmployeeEntity(System.Int32 employeeId, IPrefetchPath prefetchPathToUse):base("EmployeeEntity")
		{
			InitClassFetch(employeeId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="validator">The custom validator object for this EmployeeEntity</param>
		public EmployeeEntity(System.Int32 employeeId, IValidator validator):base("EmployeeEntity")
		{
			InitClassFetch(employeeId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected EmployeeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_employees = (Northwind.SSDAL.CollectionClasses.EmployeeCollection)info.GetValue("_employees", typeof(Northwind.SSDAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployees = info.GetBoolean("_alwaysFetchEmployees");
			_alreadyFetchedEmployees = info.GetBoolean("_alreadyFetchedEmployees");

			_employeeTerritories = (Northwind.SSDAL.CollectionClasses.EmployeeTerritoryCollection)info.GetValue("_employeeTerritories", typeof(Northwind.SSDAL.CollectionClasses.EmployeeTerritoryCollection));
			_alwaysFetchEmployeeTerritories = info.GetBoolean("_alwaysFetchEmployeeTerritories");
			_alreadyFetchedEmployeeTerritories = info.GetBoolean("_alreadyFetchedEmployeeTerritories");

			_orders = (Northwind.SSDAL.CollectionClasses.OrderCollection)info.GetValue("_orders", typeof(Northwind.SSDAL.CollectionClasses.OrderCollection));
			_alwaysFetchOrders = info.GetBoolean("_alwaysFetchOrders");
			_alreadyFetchedOrders = info.GetBoolean("_alreadyFetchedOrders");
			_employee = (EmployeeEntity)info.GetValue("_employee", typeof(EmployeeEntity));
			if(_employee!=null)
			{
				_employee.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_employeeReturnsNewIfNotFound = info.GetBoolean("_employeeReturnsNewIfNotFound");
			_alwaysFetchEmployee = info.GetBoolean("_alwaysFetchEmployee");
			_alreadyFetchedEmployee = info.GetBoolean("_alreadyFetchedEmployee");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((EmployeeFieldIndex)fieldIndex)
			{
				case EmployeeFieldIndex.ReportsTo:
					DesetupSyncEmployee(true, false);
					_alreadyFetchedEmployee = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedEmployees = (_employees.Count > 0);
			_alreadyFetchedEmployeeTerritories = (_employeeTerritories.Count > 0);
			_alreadyFetchedOrders = (_orders.Count > 0);
			_alreadyFetchedEmployee = (_employee != null);
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
				case "Employee":
					toReturn.Add(Relations.EmployeeEntityUsingEmployeeIdReportsTo);
					break;
				case "Employees":
					toReturn.Add(Relations.EmployeeEntityUsingReportsTo);
					break;
				case "EmployeeTerritories":
					toReturn.Add(Relations.EmployeeTerritoryEntityUsingEmployeeId);
					break;
				case "Orders":
					toReturn.Add(Relations.OrderEntityUsingEmployeeId);
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
			info.AddValue("_employees", (!this.MarkedForDeletion?_employees:null));
			info.AddValue("_alwaysFetchEmployees", _alwaysFetchEmployees);
			info.AddValue("_alreadyFetchedEmployees", _alreadyFetchedEmployees);
			info.AddValue("_employeeTerritories", (!this.MarkedForDeletion?_employeeTerritories:null));
			info.AddValue("_alwaysFetchEmployeeTerritories", _alwaysFetchEmployeeTerritories);
			info.AddValue("_alreadyFetchedEmployeeTerritories", _alreadyFetchedEmployeeTerritories);
			info.AddValue("_orders", (!this.MarkedForDeletion?_orders:null));
			info.AddValue("_alwaysFetchOrders", _alwaysFetchOrders);
			info.AddValue("_alreadyFetchedOrders", _alreadyFetchedOrders);
			info.AddValue("_employee", (!this.MarkedForDeletion?_employee:null));
			info.AddValue("_employeeReturnsNewIfNotFound", _employeeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchEmployee", _alwaysFetchEmployee);
			info.AddValue("_alreadyFetchedEmployee", _alreadyFetchedEmployee);

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
				case "Employee":
					_alreadyFetchedEmployee = true;
					this.Employee = (EmployeeEntity)entity;
					break;
				case "Employees":
					_alreadyFetchedEmployees = true;
					if(entity!=null)
					{
						this.Employees.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeTerritories":
					_alreadyFetchedEmployeeTerritories = true;
					if(entity!=null)
					{
						this.EmployeeTerritories.Add((EmployeeTerritoryEntity)entity);
					}
					break;
				case "Orders":
					_alreadyFetchedOrders = true;
					if(entity!=null)
					{
						this.Orders.Add((OrderEntity)entity);
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
				case "Employee":
					SetupSyncEmployee(relatedEntity);
					break;
				case "Employees":
					_employees.Add((EmployeeEntity)relatedEntity);
					break;
				case "EmployeeTerritories":
					_employeeTerritories.Add((EmployeeTerritoryEntity)relatedEntity);
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
				case "Employee":
					DesetupSyncEmployee(false, true);
					break;
				case "Employees":
					this.PerformRelatedEntityRemoval(_employees, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "EmployeeTerritories":
					this.PerformRelatedEntityRemoval(_employeeTerritories, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_employee!=null)
			{
				toReturn.Add(_employee);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_employees);
			toReturn.Add(_employeeTerritories);
			toReturn.Add(_orders);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 employeeId)
		{
			return FetchUsingPK(employeeId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 employeeId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(employeeId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 employeeId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(employeeId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 employeeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(employeeId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.EmployeeId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new EmployeeRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Northwind.SSDAL.CollectionClasses.EmployeeCollection GetMultiEmployees(bool forceFetch)
		{
			return GetMultiEmployees(forceFetch, _employees.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Northwind.SSDAL.CollectionClasses.EmployeeCollection GetMultiEmployees(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiEmployees(forceFetch, _employees.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Northwind.SSDAL.CollectionClasses.EmployeeCollection GetMultiEmployees(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiEmployees(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Northwind.SSDAL.CollectionClasses.EmployeeCollection GetMultiEmployees(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployees || forceFetch || _alwaysFetchEmployees) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_employees);
				_employees.SuppressClearInGetMulti=!forceFetch;
				_employees.EntityFactoryToUse = entityFactoryToUse;
				_employees.GetMultiManyToOne(this, filter);
				_employees.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployees = true;
			}
			return _employees;
		}

		/// <summary> Sets the collection parameters for the collection for 'Employees'. These settings will be taken into account
		/// when the property Employees is requested or GetMultiEmployees is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployees(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employees.SortClauses=sortClauses;
			_employees.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeTerritoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeTerritoryEntity'</returns>
		public Northwind.SSDAL.CollectionClasses.EmployeeTerritoryCollection GetMultiEmployeeTerritories(bool forceFetch)
		{
			return GetMultiEmployeeTerritories(forceFetch, _employeeTerritories.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeTerritoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeTerritoryEntity'</returns>
		public Northwind.SSDAL.CollectionClasses.EmployeeTerritoryCollection GetMultiEmployeeTerritories(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiEmployeeTerritories(forceFetch, _employeeTerritories.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeTerritoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Northwind.SSDAL.CollectionClasses.EmployeeTerritoryCollection GetMultiEmployeeTerritories(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiEmployeeTerritories(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeTerritoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Northwind.SSDAL.CollectionClasses.EmployeeTerritoryCollection GetMultiEmployeeTerritories(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployeeTerritories || forceFetch || _alwaysFetchEmployeeTerritories) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_employeeTerritories);
				_employeeTerritories.SuppressClearInGetMulti=!forceFetch;
				_employeeTerritories.EntityFactoryToUse = entityFactoryToUse;
				_employeeTerritories.GetMultiManyToOne(this, null, filter);
				_employeeTerritories.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeTerritories = true;
			}
			return _employeeTerritories;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeTerritories'. These settings will be taken into account
		/// when the property EmployeeTerritories is requested or GetMultiEmployeeTerritories is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeTerritories(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeTerritories.SortClauses=sortClauses;
			_employeeTerritories.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'OrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'OrderEntity'</returns>
		public Northwind.SSDAL.CollectionClasses.OrderCollection GetMultiOrders(bool forceFetch)
		{
			return GetMultiOrders(forceFetch, _orders.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'OrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'OrderEntity'</returns>
		public Northwind.SSDAL.CollectionClasses.OrderCollection GetMultiOrders(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiOrders(forceFetch, _orders.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'OrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Northwind.SSDAL.CollectionClasses.OrderCollection GetMultiOrders(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiOrders(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'OrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Northwind.SSDAL.CollectionClasses.OrderCollection GetMultiOrders(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedOrders || forceFetch || _alwaysFetchOrders) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_orders);
				_orders.SuppressClearInGetMulti=!forceFetch;
				_orders.EntityFactoryToUse = entityFactoryToUse;
				_orders.GetMultiManyToOne(null, this, null, filter);
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
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.EmployeeEntityUsingEmployeeIdReportsTo);
				EmployeeEntity newEntity = new EmployeeEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ReportsTo.GetValueOrDefault());
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


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Employee", _employee);
			toReturn.Add("Employees", _employees);
			toReturn.Add("EmployeeTerritories", _employeeTerritories);
			toReturn.Add("Orders", _orders);
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
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="validator">The validator object for this EmployeeEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 employeeId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(employeeId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_employees = new Northwind.SSDAL.CollectionClasses.EmployeeCollection();
			_employees.SetContainingEntityInfo(this, "Employee");

			_employeeTerritories = new Northwind.SSDAL.CollectionClasses.EmployeeTerritoryCollection();
			_employeeTerritories.SetContainingEntityInfo(this, "Employee");

			_orders = new Northwind.SSDAL.CollectionClasses.OrderCollection();
			_orders.SetContainingEntityInfo(this, "Employee");
			_employeeReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("BirthDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("City", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Country", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("EmployeeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Extension", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FirstName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("HireDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("HomePhone", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LastName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Notes", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Photo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PhotoPath", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PostalCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Region", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ReportsTo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Title", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TitleOfCourtesy", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _employee</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", Northwind.SSDAL.RelationClasses.StaticEmployeeRelations.EmployeeEntityUsingEmployeeIdReportsToStatic, true, signalRelatedEntity, "Employees", resetFKFields, new int[] { (int)EmployeeFieldIndex.ReportsTo } );		
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
				this.PerformSetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", Northwind.SSDAL.RelationClasses.StaticEmployeeRelations.EmployeeEntityUsingEmployeeIdReportsToStatic, true, ref _alreadyFetchedEmployee, new string[] {  } );
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

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 employeeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)EmployeeFieldIndex.EmployeeId].ForcedCurrentValueWrite(employeeId);
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
			return DAOFactory.CreateEmployeeDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new EmployeeEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static EmployeeRelations Relations
		{
			get	{ return new EmployeeRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployees
		{
			get { return new PrefetchPathElement(new Northwind.SSDAL.CollectionClasses.EmployeeCollection(), (IEntityRelation)GetRelationsForField("Employees")[0], (int)Northwind.SSDAL.EntityType.EmployeeEntity, (int)Northwind.SSDAL.EntityType.EmployeeEntity, 0, null, null, null, "Employees", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'EmployeeTerritory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeTerritories
		{
			get { return new PrefetchPathElement(new Northwind.SSDAL.CollectionClasses.EmployeeTerritoryCollection(), (IEntityRelation)GetRelationsForField("EmployeeTerritories")[0], (int)Northwind.SSDAL.EntityType.EmployeeEntity, (int)Northwind.SSDAL.EntityType.EmployeeTerritoryEntity, 0, null, null, null, "EmployeeTerritories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Order' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathOrders
		{
			get { return new PrefetchPathElement(new Northwind.SSDAL.CollectionClasses.OrderCollection(), (IEntityRelation)GetRelationsForField("Orders")[0], (int)Northwind.SSDAL.EntityType.EmployeeEntity, (int)Northwind.SSDAL.EntityType.OrderEntity, 0, null, null, null, "Orders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployee
		{
			get	{ return new PrefetchPathElement(new Northwind.SSDAL.CollectionClasses.EmployeeCollection(), (IEntityRelation)GetRelationsForField("Employee")[0], (int)Northwind.SSDAL.EntityType.EmployeeEntity, (int)Northwind.SSDAL.EntityType.EmployeeEntity, 0, null, null, null, "Employee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The Address property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."Address"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Address
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Address, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Address, value, true); }
		}

		/// <summary> The BirthDate property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."BirthDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> BirthDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)EmployeeFieldIndex.BirthDate, false); }
			set	{ SetValue((int)EmployeeFieldIndex.BirthDate, value, true); }
		}

		/// <summary> The City property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."City"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String City
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.City, true); }
			set	{ SetValue((int)EmployeeFieldIndex.City, value, true); }
		}

		/// <summary> The Country property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."Country"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Country
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Country, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Country, value, true); }
		}

		/// <summary> The EmployeeId property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."EmployeeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 EmployeeId
		{
			get { return (System.Int32)GetValue((int)EmployeeFieldIndex.EmployeeId, true); }
			set	{ SetValue((int)EmployeeFieldIndex.EmployeeId, value, true); }
		}

		/// <summary> The Extension property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."Extension"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 4<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Extension
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Extension, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Extension, value, true); }
		}

		/// <summary> The FirstName property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."FirstName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String FirstName
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.FirstName, true); }
			set	{ SetValue((int)EmployeeFieldIndex.FirstName, value, true); }
		}

		/// <summary> The HireDate property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."HireDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> HireDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)EmployeeFieldIndex.HireDate, false); }
			set	{ SetValue((int)EmployeeFieldIndex.HireDate, value, true); }
		}

		/// <summary> The HomePhone property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."HomePhone"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 24<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String HomePhone
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.HomePhone, true); }
			set	{ SetValue((int)EmployeeFieldIndex.HomePhone, value, true); }
		}

		/// <summary> The LastName property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."LastName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String LastName
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.LastName, true); }
			set	{ SetValue((int)EmployeeFieldIndex.LastName, value, true); }
		}

		/// <summary> The Notes property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."Notes"<br/>
		/// Table field type characteristics (type, precision, scale, length): NText, 0, 0, 1073741823<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Notes
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Notes, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Notes, value, true); }
		}

		/// <summary> The Photo property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."Photo"<br/>
		/// Table field type characteristics (type, precision, scale, length): Image, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Byte[] Photo
		{
			get { return (System.Byte[])GetValue((int)EmployeeFieldIndex.Photo, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Photo, value, true); }
		}

		/// <summary> The PhotoPath property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."PhotoPath"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String PhotoPath
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.PhotoPath, true); }
			set	{ SetValue((int)EmployeeFieldIndex.PhotoPath, value, true); }
		}

		/// <summary> The PostalCode property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."PostalCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String PostalCode
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.PostalCode, true); }
			set	{ SetValue((int)EmployeeFieldIndex.PostalCode, value, true); }
		}

		/// <summary> The Region property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."Region"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Region
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Region, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Region, value, true); }
		}

		/// <summary> The ReportsTo property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."ReportsTo"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ReportsTo
		{
			get { return (Nullable<System.Int32>)GetValue((int)EmployeeFieldIndex.ReportsTo, false); }
			set	{ SetValue((int)EmployeeFieldIndex.ReportsTo, value, true); }
		}

		/// <summary> The Title property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."Title"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 30<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Title, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Title, value, true); }
		}

		/// <summary> The TitleOfCourtesy property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."TitleOfCourtesy"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String TitleOfCourtesy
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.TitleOfCourtesy, true); }
			set	{ SetValue((int)EmployeeFieldIndex.TitleOfCourtesy, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployees()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Northwind.SSDAL.CollectionClasses.EmployeeCollection Employees
		{
			get	{ return GetMultiEmployees(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Employees. When set to true, Employees is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employees is accessed. You can always execute/ a forced fetch by calling GetMultiEmployees(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployees
		{
			get	{ return _alwaysFetchEmployees; }
			set	{ _alwaysFetchEmployees = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Employees already has been fetched. Setting this property to false when Employees has been fetched
		/// will clear the Employees collection well. Setting this property to true while Employees hasn't been fetched disables lazy loading for Employees</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployees
		{
			get { return _alreadyFetchedEmployees;}
			set 
			{
				if(_alreadyFetchedEmployees && !value && (_employees != null))
				{
					_employees.Clear();
				}
				_alreadyFetchedEmployees = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeTerritoryEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeTerritories()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Northwind.SSDAL.CollectionClasses.EmployeeTerritoryCollection EmployeeTerritories
		{
			get	{ return GetMultiEmployeeTerritories(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeTerritories. When set to true, EmployeeTerritories is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeTerritories is accessed. You can always execute/ a forced fetch by calling GetMultiEmployeeTerritories(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeTerritories
		{
			get	{ return _alwaysFetchEmployeeTerritories; }
			set	{ _alwaysFetchEmployeeTerritories = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeTerritories already has been fetched. Setting this property to false when EmployeeTerritories has been fetched
		/// will clear the EmployeeTerritories collection well. Setting this property to true while EmployeeTerritories hasn't been fetched disables lazy loading for EmployeeTerritories</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeTerritories
		{
			get { return _alreadyFetchedEmployeeTerritories;}
			set 
			{
				if(_alreadyFetchedEmployeeTerritories && !value && (_employeeTerritories != null))
				{
					_employeeTerritories.Clear();
				}
				_alreadyFetchedEmployeeTerritories = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'OrderEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiOrders()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Northwind.SSDAL.CollectionClasses.OrderCollection Orders
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
					SetSingleRelatedEntityNavigator(value, "Employees", "Employee", _employee, true); 
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
			get { return (int)Northwind.SSDAL.EntityType.EmployeeEntity; }
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
