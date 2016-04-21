///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: donderdag 21 april 2016 12:49:00
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
using SD.LLBLGen.Pro.Examples;
using SD.LLBLGen.Pro.Examples.FactoryClasses;
using SD.LLBLGen.Pro.Examples.DaoClasses;
using SD.LLBLGen.Pro.Examples.RelationClasses;
using SD.LLBLGen.Pro.Examples.HelperClasses;
using SD.LLBLGen.Pro.Examples.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'EmployeeTerritory'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class EmployeeTerritoryEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EmployeeEntity _employee;
		private bool	_alwaysFetchEmployee, _alreadyFetchedEmployee, _employeeReturnsNewIfNotFound;
		private TerritoryEntity _territory;
		private bool	_alwaysFetchTerritory, _alreadyFetchedTerritory, _territoryReturnsNewIfNotFound;

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
			/// <summary>Member name Territory</summary>
			public static readonly string Territory = "Territory";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static EmployeeTerritoryEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public EmployeeTerritoryEntity() :base("EmployeeTerritoryEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="employeeId">PK value for EmployeeTerritory which data should be fetched into this EmployeeTerritory object</param>
		/// <param name="territoryId">PK value for EmployeeTerritory which data should be fetched into this EmployeeTerritory object</param>
		public EmployeeTerritoryEntity(System.Int32 employeeId, System.String territoryId):base("EmployeeTerritoryEntity")
		{
			InitClassFetch(employeeId, territoryId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="employeeId">PK value for EmployeeTerritory which data should be fetched into this EmployeeTerritory object</param>
		/// <param name="territoryId">PK value for EmployeeTerritory which data should be fetched into this EmployeeTerritory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public EmployeeTerritoryEntity(System.Int32 employeeId, System.String territoryId, IPrefetchPath prefetchPathToUse):base("EmployeeTerritoryEntity")
		{
			InitClassFetch(employeeId, territoryId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="employeeId">PK value for EmployeeTerritory which data should be fetched into this EmployeeTerritory object</param>
		/// <param name="territoryId">PK value for EmployeeTerritory which data should be fetched into this EmployeeTerritory object</param>
		/// <param name="validator">The custom validator object for this EmployeeTerritoryEntity</param>
		public EmployeeTerritoryEntity(System.Int32 employeeId, System.String territoryId, IValidator validator):base("EmployeeTerritoryEntity")
		{
			InitClassFetch(employeeId, territoryId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected EmployeeTerritoryEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_employee = (EmployeeEntity)info.GetValue("_employee", typeof(EmployeeEntity));
			if(_employee!=null)
			{
				_employee.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_employeeReturnsNewIfNotFound = info.GetBoolean("_employeeReturnsNewIfNotFound");
			_alwaysFetchEmployee = info.GetBoolean("_alwaysFetchEmployee");
			_alreadyFetchedEmployee = info.GetBoolean("_alreadyFetchedEmployee");

			_territory = (TerritoryEntity)info.GetValue("_territory", typeof(TerritoryEntity));
			if(_territory!=null)
			{
				_territory.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_territoryReturnsNewIfNotFound = info.GetBoolean("_territoryReturnsNewIfNotFound");
			_alwaysFetchTerritory = info.GetBoolean("_alwaysFetchTerritory");
			_alreadyFetchedTerritory = info.GetBoolean("_alreadyFetchedTerritory");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((EmployeeTerritoryFieldIndex)fieldIndex)
			{
				case EmployeeTerritoryFieldIndex.EmployeeId:
					DesetupSyncEmployee(true, false);
					_alreadyFetchedEmployee = false;
					break;
				case EmployeeTerritoryFieldIndex.TerritoryId:
					DesetupSyncTerritory(true, false);
					_alreadyFetchedTerritory = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedEmployee = (_employee != null);
			_alreadyFetchedTerritory = (_territory != null);
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
					toReturn.Add(Relations.EmployeeEntityUsingEmployeeId);
					break;
				case "Territory":
					toReturn.Add(Relations.TerritoryEntityUsingTerritoryId);
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
			info.AddValue("_employee", (!this.MarkedForDeletion?_employee:null));
			info.AddValue("_employeeReturnsNewIfNotFound", _employeeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchEmployee", _alwaysFetchEmployee);
			info.AddValue("_alreadyFetchedEmployee", _alreadyFetchedEmployee);
			info.AddValue("_territory", (!this.MarkedForDeletion?_territory:null));
			info.AddValue("_territoryReturnsNewIfNotFound", _territoryReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchTerritory", _alwaysFetchTerritory);
			info.AddValue("_alreadyFetchedTerritory", _alreadyFetchedTerritory);

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
				case "Territory":
					_alreadyFetchedTerritory = true;
					this.Territory = (TerritoryEntity)entity;
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
				case "Territory":
					SetupSyncTerritory(relatedEntity);
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
				case "Territory":
					DesetupSyncTerritory(false, true);
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
			if(_territory!=null)
			{
				toReturn.Add(_territory);
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
		/// <param name="employeeId">PK value for EmployeeTerritory which data should be fetched into this EmployeeTerritory object</param>
		/// <param name="territoryId">PK value for EmployeeTerritory which data should be fetched into this EmployeeTerritory object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 employeeId, System.String territoryId)
		{
			return FetchUsingPK(employeeId, territoryId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="employeeId">PK value for EmployeeTerritory which data should be fetched into this EmployeeTerritory object</param>
		/// <param name="territoryId">PK value for EmployeeTerritory which data should be fetched into this EmployeeTerritory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 employeeId, System.String territoryId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(employeeId, territoryId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="employeeId">PK value for EmployeeTerritory which data should be fetched into this EmployeeTerritory object</param>
		/// <param name="territoryId">PK value for EmployeeTerritory which data should be fetched into this EmployeeTerritory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 employeeId, System.String territoryId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(employeeId, territoryId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="employeeId">PK value for EmployeeTerritory which data should be fetched into this EmployeeTerritory object</param>
		/// <param name="territoryId">PK value for EmployeeTerritory which data should be fetched into this EmployeeTerritory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 employeeId, System.String territoryId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(employeeId, territoryId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.EmployeeId, this.TerritoryId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new EmployeeTerritoryRelations().GetAllRelations();
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
					fetchResult = newEntity.FetchUsingPK(this.EmployeeId);
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


		/// <summary> Retrieves the related entity of type 'TerritoryEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'TerritoryEntity' which is related to this entity.</returns>
		public TerritoryEntity GetSingleTerritory()
		{
			return GetSingleTerritory(false);
		}

		/// <summary> Retrieves the related entity of type 'TerritoryEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'TerritoryEntity' which is related to this entity.</returns>
		public virtual TerritoryEntity GetSingleTerritory(bool forceFetch)
		{
			if( ( !_alreadyFetchedTerritory || forceFetch || _alwaysFetchTerritory) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.TerritoryEntityUsingTerritoryId);
				TerritoryEntity newEntity = new TerritoryEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.TerritoryId);
				}
				if(fetchResult)
				{
					newEntity = (TerritoryEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_territoryReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Territory = newEntity;
				_alreadyFetchedTerritory = fetchResult;
			}
			return _territory;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Employee", _employee);
			toReturn.Add("Territory", _territory);
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
		/// <param name="employeeId">PK value for EmployeeTerritory which data should be fetched into this EmployeeTerritory object</param>
		/// <param name="territoryId">PK value for EmployeeTerritory which data should be fetched into this EmployeeTerritory object</param>
		/// <param name="validator">The validator object for this EmployeeTerritoryEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 employeeId, System.String territoryId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(employeeId, territoryId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_employeeReturnsNewIfNotFound = true;
			_territoryReturnsNewIfNotFound = true;
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
			_fieldsCustomProperties.Add("EmployeeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TerritoryId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _employee</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", SD.LLBLGen.Pro.Examples.RelationClasses.StaticEmployeeTerritoryRelations.EmployeeEntityUsingEmployeeIdStatic, true, signalRelatedEntity, "EmployeeTerritories", resetFKFields, new int[] { (int)EmployeeTerritoryFieldIndex.EmployeeId } );		
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
				this.PerformSetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", SD.LLBLGen.Pro.Examples.RelationClasses.StaticEmployeeTerritoryRelations.EmployeeEntityUsingEmployeeIdStatic, true, ref _alreadyFetchedEmployee, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _territory</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncTerritory(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _territory, new PropertyChangedEventHandler( OnTerritoryPropertyChanged ), "Territory", SD.LLBLGen.Pro.Examples.RelationClasses.StaticEmployeeTerritoryRelations.TerritoryEntityUsingTerritoryIdStatic, true, signalRelatedEntity, "EmployeeTerritories", resetFKFields, new int[] { (int)EmployeeTerritoryFieldIndex.TerritoryId } );		
			_territory = null;
		}
		
		/// <summary> setups the sync logic for member _territory</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncTerritory(IEntityCore relatedEntity)
		{
			if(_territory!=relatedEntity)
			{		
				DesetupSyncTerritory(true, true);
				_territory = (TerritoryEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _territory, new PropertyChangedEventHandler( OnTerritoryPropertyChanged ), "Territory", SD.LLBLGen.Pro.Examples.RelationClasses.StaticEmployeeTerritoryRelations.TerritoryEntityUsingTerritoryIdStatic, true, ref _alreadyFetchedTerritory, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnTerritoryPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="employeeId">PK value for EmployeeTerritory which data should be fetched into this EmployeeTerritory object</param>
		/// <param name="territoryId">PK value for EmployeeTerritory which data should be fetched into this EmployeeTerritory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 employeeId, System.String territoryId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)EmployeeTerritoryFieldIndex.EmployeeId].ForcedCurrentValueWrite(employeeId);
				this.Fields[(int)EmployeeTerritoryFieldIndex.TerritoryId].ForcedCurrentValueWrite(territoryId);
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
			return DAOFactory.CreateEmployeeTerritoryDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new EmployeeTerritoryEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static EmployeeTerritoryRelations Relations
		{
			get	{ return new EmployeeTerritoryRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployee
		{
			get	{ return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.CollectionClasses.EmployeeCollection(), (IEntityRelation)GetRelationsForField("Employee")[0], (int)SD.LLBLGen.Pro.Examples.EntityType.EmployeeTerritoryEntity, (int)SD.LLBLGen.Pro.Examples.EntityType.EmployeeEntity, 0, null, null, null, "Employee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Territory'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathTerritory
		{
			get	{ return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.CollectionClasses.TerritoryCollection(), (IEntityRelation)GetRelationsForField("Territory")[0], (int)SD.LLBLGen.Pro.Examples.EntityType.EmployeeTerritoryEntity, (int)SD.LLBLGen.Pro.Examples.EntityType.TerritoryEntity, 0, null, null, null, "Territory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The EmployeeId property of the Entity EmployeeTerritory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "EmployeeTerritories"."EmployeeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 EmployeeId
		{
			get { return (System.Int32)GetValue((int)EmployeeTerritoryFieldIndex.EmployeeId, true); }
			set	{ SetValue((int)EmployeeTerritoryFieldIndex.EmployeeId, value, true); }
		}

		/// <summary> The TerritoryId property of the Entity EmployeeTerritory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "EmployeeTerritories"."TerritoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String TerritoryId
		{
			get { return (System.String)GetValue((int)EmployeeTerritoryFieldIndex.TerritoryId, true); }
			set	{ SetValue((int)EmployeeTerritoryFieldIndex.TerritoryId, value, true); }
		}


		/// <summary> Gets / sets related entity of type 'EmployeeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleEmployee()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
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
					SetSingleRelatedEntityNavigator(value, "EmployeeTerritories", "Employee", _employee, true); 
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
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool EmployeeReturnsNewIfNotFound
		{
			get	{ return _employeeReturnsNewIfNotFound; }
			set { _employeeReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'TerritoryEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleTerritory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual TerritoryEntity Territory
		{
			get	{ return GetSingleTerritory(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncTerritory(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "EmployeeTerritories", "Territory", _territory, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Territory. When set to true, Territory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Territory is accessed. You can always execute a forced fetch by calling GetSingleTerritory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchTerritory
		{
			get	{ return _alwaysFetchTerritory; }
			set	{ _alwaysFetchTerritory = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Territory already has been fetched. Setting this property to false when Territory has been fetched
		/// will set Territory to null as well. Setting this property to true while Territory hasn't been fetched disables lazy loading for Territory</summary>
		[Browsable(false)]
		public bool AlreadyFetchedTerritory
		{
			get { return _alreadyFetchedTerritory;}
			set 
			{
				if(_alreadyFetchedTerritory && !value)
				{
					this.Territory = null;
				}
				_alreadyFetchedTerritory = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Territory is not found
		/// in the database. When set to true, Territory will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool TerritoryReturnsNewIfNotFound
		{
			get	{ return _territoryReturnsNewIfNotFound; }
			set { _territoryReturnsNewIfNotFound = value; }	
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
		
		/// <summary>Returns the SD.LLBLGen.Pro.Examples.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)SD.LLBLGen.Pro.Examples.EntityType.EmployeeTerritoryEntity; }
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
