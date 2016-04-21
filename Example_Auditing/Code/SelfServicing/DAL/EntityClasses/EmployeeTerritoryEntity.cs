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

	/// <summary>Entity class which represents the entity 'EmployeeTerritory'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class EmployeeTerritoryEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EmployeeEntity _employees;
		private bool	_alwaysFetchEmployees, _alreadyFetchedEmployees, _employeesReturnsNewIfNotFound;
		private TerritoryEntity _territories;
		private bool	_alwaysFetchTerritories, _alreadyFetchedTerritories, _territoriesReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Employees</summary>
			public static readonly string Employees = "Employees";
			/// <summary>Member name Territories</summary>
			public static readonly string Territories = "Territories";
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
			_employees = (EmployeeEntity)info.GetValue("_employees", typeof(EmployeeEntity));
			if(_employees!=null)
			{
				_employees.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_employeesReturnsNewIfNotFound = info.GetBoolean("_employeesReturnsNewIfNotFound");
			_alwaysFetchEmployees = info.GetBoolean("_alwaysFetchEmployees");
			_alreadyFetchedEmployees = info.GetBoolean("_alreadyFetchedEmployees");

			_territories = (TerritoryEntity)info.GetValue("_territories", typeof(TerritoryEntity));
			if(_territories!=null)
			{
				_territories.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_territoriesReturnsNewIfNotFound = info.GetBoolean("_territoriesReturnsNewIfNotFound");
			_alwaysFetchTerritories = info.GetBoolean("_alwaysFetchTerritories");
			_alreadyFetchedTerritories = info.GetBoolean("_alreadyFetchedTerritories");
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
					DesetupSyncEmployees(true, false);
					_alreadyFetchedEmployees = false;
					break;
				case EmployeeTerritoryFieldIndex.TerritoryId:
					DesetupSyncTerritories(true, false);
					_alreadyFetchedTerritories = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedEmployees = (_employees != null);
			_alreadyFetchedTerritories = (_territories != null);
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
				case "Employees":
					toReturn.Add(Relations.EmployeeEntityUsingEmployeeId);
					break;
				case "Territories":
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
			info.AddValue("_employees", (!this.MarkedForDeletion?_employees:null));
			info.AddValue("_employeesReturnsNewIfNotFound", _employeesReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchEmployees", _alwaysFetchEmployees);
			info.AddValue("_alreadyFetchedEmployees", _alreadyFetchedEmployees);
			info.AddValue("_territories", (!this.MarkedForDeletion?_territories:null));
			info.AddValue("_territoriesReturnsNewIfNotFound", _territoriesReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchTerritories", _alwaysFetchTerritories);
			info.AddValue("_alreadyFetchedTerritories", _alreadyFetchedTerritories);

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
				case "Employees":
					_alreadyFetchedEmployees = true;
					this.Employees = (EmployeeEntity)entity;
					break;
				case "Territories":
					_alreadyFetchedTerritories = true;
					this.Territories = (TerritoryEntity)entity;
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
				case "Employees":
					SetupSyncEmployees(relatedEntity);
					break;
				case "Territories":
					SetupSyncTerritories(relatedEntity);
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
				case "Employees":
					DesetupSyncEmployees(false, true);
					break;
				case "Territories":
					DesetupSyncTerritories(false, true);
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
			if(_employees!=null)
			{
				toReturn.Add(_employees);
			}
			if(_territories!=null)
			{
				toReturn.Add(_territories);
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
					fetchResult = newEntity.FetchUsingPK(this.EmployeeId);
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


		/// <summary> Retrieves the related entity of type 'TerritoryEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'TerritoryEntity' which is related to this entity.</returns>
		public TerritoryEntity GetSingleTerritories()
		{
			return GetSingleTerritories(false);
		}

		/// <summary> Retrieves the related entity of type 'TerritoryEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'TerritoryEntity' which is related to this entity.</returns>
		public virtual TerritoryEntity GetSingleTerritories(bool forceFetch)
		{
			if( ( !_alreadyFetchedTerritories || forceFetch || _alwaysFetchTerritories) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
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
					if(!_territoriesReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Territories = newEntity;
				_alreadyFetchedTerritories = fetchResult;
			}
			return _territories;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Employees", _employees);
			toReturn.Add("Territories", _territories);
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
			_employeesReturnsNewIfNotFound = true;
			_territoriesReturnsNewIfNotFound = true;
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

		/// <summary> Removes the sync logic for member _employees</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployees(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _employees, new PropertyChangedEventHandler( OnEmployeesPropertyChanged ), "Employees", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticEmployeeTerritoryRelations.EmployeeEntityUsingEmployeeIdStatic, true, signalRelatedEntity, "EmployeeTerritories", resetFKFields, new int[] { (int)EmployeeTerritoryFieldIndex.EmployeeId } );		
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
				this.PerformSetupSyncRelatedEntity( _employees, new PropertyChangedEventHandler( OnEmployeesPropertyChanged ), "Employees", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticEmployeeTerritoryRelations.EmployeeEntityUsingEmployeeIdStatic, true, ref _alreadyFetchedEmployees, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _territories</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncTerritories(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _territories, new PropertyChangedEventHandler( OnTerritoriesPropertyChanged ), "Territories", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticEmployeeTerritoryRelations.TerritoryEntityUsingTerritoryIdStatic, true, signalRelatedEntity, "EmployeeTerritories", resetFKFields, new int[] { (int)EmployeeTerritoryFieldIndex.TerritoryId } );		
			_territories = null;
		}
		
		/// <summary> setups the sync logic for member _territories</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncTerritories(IEntityCore relatedEntity)
		{
			if(_territories!=relatedEntity)
			{		
				DesetupSyncTerritories(true, true);
				_territories = (TerritoryEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _territories, new PropertyChangedEventHandler( OnTerritoriesPropertyChanged ), "Territories", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticEmployeeTerritoryRelations.TerritoryEntityUsingTerritoryIdStatic, true, ref _alreadyFetchedTerritories, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnTerritoriesPropertyChanged( object sender, PropertyChangedEventArgs e )
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
		public static IPrefetchPathElement PrefetchPathEmployees
		{
			get	{ return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection(), (IEntityRelation)GetRelationsForField("Employees")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.EmployeeTerritoryEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.EmployeeEntity, 0, null, null, null, "Employees", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Territory'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathTerritories
		{
			get	{ return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.TerritoryCollection(), (IEntityRelation)GetRelationsForField("Territories")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.EmployeeTerritoryEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.TerritoryEntity, 0, null, null, null, "Territories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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
					SetSingleRelatedEntityNavigator(value, "EmployeeTerritories", "Employees", _employees, true); 
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

		/// <summary> Gets / sets related entity of type 'TerritoryEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleTerritories()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual TerritoryEntity Territories
		{
			get	{ return GetSingleTerritories(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncTerritories(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "EmployeeTerritories", "Territories", _territories, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Territories. When set to true, Territories is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Territories is accessed. You can always execute a forced fetch by calling GetSingleTerritories(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchTerritories
		{
			get	{ return _alwaysFetchTerritories; }
			set	{ _alwaysFetchTerritories = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Territories already has been fetched. Setting this property to false when Territories has been fetched
		/// will set Territories to null as well. Setting this property to true while Territories hasn't been fetched disables lazy loading for Territories</summary>
		[Browsable(false)]
		public bool AlreadyFetchedTerritories
		{
			get { return _alreadyFetchedTerritories;}
			set 
			{
				if(_alreadyFetchedTerritories && !value)
				{
					this.Territories = null;
				}
				_alreadyFetchedTerritories = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Territories is not found
		/// in the database. When set to true, Territories will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool TerritoriesReturnsNewIfNotFound
		{
			get	{ return _territoriesReturnsNewIfNotFound; }
			set { _territoriesReturnsNewIfNotFound = value; }	
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
			get { return (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.EmployeeTerritoryEntity; }
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
