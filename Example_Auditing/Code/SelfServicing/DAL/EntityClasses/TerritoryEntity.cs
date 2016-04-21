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

	/// <summary>Entity class which represents the entity 'Territory'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class TerritoryEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeTerritoryCollection	_employeeTerritories;
		private bool	_alwaysFetchEmployeeTerritories, _alreadyFetchedEmployeeTerritories;
		private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection _employeesCollectionViaEmployeeTerritories;
		private bool	_alwaysFetchEmployeesCollectionViaEmployeeTerritories, _alreadyFetchedEmployeesCollectionViaEmployeeTerritories;
		private RegionEntity _region;
		private bool	_alwaysFetchRegion, _alreadyFetchedRegion, _regionReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Region</summary>
			public static readonly string Region = "Region";
			/// <summary>Member name EmployeeTerritories</summary>
			public static readonly string EmployeeTerritories = "EmployeeTerritories";
			/// <summary>Member name EmployeesCollectionViaEmployeeTerritories</summary>
			public static readonly string EmployeesCollectionViaEmployeeTerritories = "EmployeesCollectionViaEmployeeTerritories";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static TerritoryEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public TerritoryEntity() :base("TerritoryEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="territoryId">PK value for Territory which data should be fetched into this Territory object</param>
		public TerritoryEntity(System.String territoryId):base("TerritoryEntity")
		{
			InitClassFetch(territoryId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="territoryId">PK value for Territory which data should be fetched into this Territory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public TerritoryEntity(System.String territoryId, IPrefetchPath prefetchPathToUse):base("TerritoryEntity")
		{
			InitClassFetch(territoryId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="territoryId">PK value for Territory which data should be fetched into this Territory object</param>
		/// <param name="validator">The custom validator object for this TerritoryEntity</param>
		public TerritoryEntity(System.String territoryId, IValidator validator):base("TerritoryEntity")
		{
			InitClassFetch(territoryId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected TerritoryEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_employeeTerritories = (SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeTerritoryCollection)info.GetValue("_employeeTerritories", typeof(SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeTerritoryCollection));
			_alwaysFetchEmployeeTerritories = info.GetBoolean("_alwaysFetchEmployeeTerritories");
			_alreadyFetchedEmployeeTerritories = info.GetBoolean("_alreadyFetchedEmployeeTerritories");
			_employeesCollectionViaEmployeeTerritories = (SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection)info.GetValue("_employeesCollectionViaEmployeeTerritories", typeof(SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeesCollectionViaEmployeeTerritories = info.GetBoolean("_alwaysFetchEmployeesCollectionViaEmployeeTerritories");
			_alreadyFetchedEmployeesCollectionViaEmployeeTerritories = info.GetBoolean("_alreadyFetchedEmployeesCollectionViaEmployeeTerritories");
			_region = (RegionEntity)info.GetValue("_region", typeof(RegionEntity));
			if(_region!=null)
			{
				_region.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_regionReturnsNewIfNotFound = info.GetBoolean("_regionReturnsNewIfNotFound");
			_alwaysFetchRegion = info.GetBoolean("_alwaysFetchRegion");
			_alreadyFetchedRegion = info.GetBoolean("_alreadyFetchedRegion");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((TerritoryFieldIndex)fieldIndex)
			{
				case TerritoryFieldIndex.RegionId:
					DesetupSyncRegion(true, false);
					_alreadyFetchedRegion = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedEmployeeTerritories = (_employeeTerritories.Count > 0);
			_alreadyFetchedEmployeesCollectionViaEmployeeTerritories = (_employeesCollectionViaEmployeeTerritories.Count > 0);
			_alreadyFetchedRegion = (_region != null);
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
				case "Region":
					toReturn.Add(Relations.RegionEntityUsingRegionId);
					break;
				case "EmployeeTerritories":
					toReturn.Add(Relations.EmployeeTerritoryEntityUsingTerritoryId);
					break;
				case "EmployeesCollectionViaEmployeeTerritories":
					toReturn.Add(Relations.EmployeeTerritoryEntityUsingTerritoryId, "TerritoryEntity__", "EmployeeTerritory_", JoinHint.None);
					toReturn.Add(EmployeeTerritoryEntity.Relations.EmployeeEntityUsingEmployeeId, "EmployeeTerritory_", string.Empty, JoinHint.None);
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
			info.AddValue("_employeeTerritories", (!this.MarkedForDeletion?_employeeTerritories:null));
			info.AddValue("_alwaysFetchEmployeeTerritories", _alwaysFetchEmployeeTerritories);
			info.AddValue("_alreadyFetchedEmployeeTerritories", _alreadyFetchedEmployeeTerritories);
			info.AddValue("_employeesCollectionViaEmployeeTerritories", (!this.MarkedForDeletion?_employeesCollectionViaEmployeeTerritories:null));
			info.AddValue("_alwaysFetchEmployeesCollectionViaEmployeeTerritories", _alwaysFetchEmployeesCollectionViaEmployeeTerritories);
			info.AddValue("_alreadyFetchedEmployeesCollectionViaEmployeeTerritories", _alreadyFetchedEmployeesCollectionViaEmployeeTerritories);
			info.AddValue("_region", (!this.MarkedForDeletion?_region:null));
			info.AddValue("_regionReturnsNewIfNotFound", _regionReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchRegion", _alwaysFetchRegion);
			info.AddValue("_alreadyFetchedRegion", _alreadyFetchedRegion);

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
				case "Region":
					_alreadyFetchedRegion = true;
					this.Region = (RegionEntity)entity;
					break;
				case "EmployeeTerritories":
					_alreadyFetchedEmployeeTerritories = true;
					if(entity!=null)
					{
						this.EmployeeTerritories.Add((EmployeeTerritoryEntity)entity);
					}
					break;
				case "EmployeesCollectionViaEmployeeTerritories":
					_alreadyFetchedEmployeesCollectionViaEmployeeTerritories = true;
					if(entity!=null)
					{
						this.EmployeesCollectionViaEmployeeTerritories.Add((EmployeeEntity)entity);
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
				case "Region":
					SetupSyncRegion(relatedEntity);
					break;
				case "EmployeeTerritories":
					_employeeTerritories.Add((EmployeeTerritoryEntity)relatedEntity);
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
				case "Region":
					DesetupSyncRegion(false, true);
					break;
				case "EmployeeTerritories":
					this.PerformRelatedEntityRemoval(_employeeTerritories, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_region!=null)
			{
				toReturn.Add(_region);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_employeeTerritories);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="territoryId">PK value for Territory which data should be fetched into this Territory object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String territoryId)
		{
			return FetchUsingPK(territoryId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="territoryId">PK value for Territory which data should be fetched into this Territory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String territoryId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(territoryId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="territoryId">PK value for Territory which data should be fetched into this Territory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String territoryId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(territoryId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="territoryId">PK value for Territory which data should be fetched into this Territory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String territoryId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(territoryId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.TerritoryId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new TerritoryRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'EmployeeTerritoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeTerritoryEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeTerritoryCollection GetMultiEmployeeTerritories(bool forceFetch)
		{
			return GetMultiEmployeeTerritories(forceFetch, _employeeTerritories.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeTerritoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeTerritoryEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeTerritoryCollection GetMultiEmployeeTerritories(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiEmployeeTerritories(forceFetch, _employeeTerritories.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeTerritoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeTerritoryCollection GetMultiEmployeeTerritories(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiEmployeeTerritories(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeTerritoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeTerritoryCollection GetMultiEmployeeTerritories(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployeeTerritories || forceFetch || _alwaysFetchEmployeeTerritories) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_employeeTerritories);
				_employeeTerritories.SuppressClearInGetMulti=!forceFetch;
				_employeeTerritories.EntityFactoryToUse = entityFactoryToUse;
				_employeeTerritories.GetMultiManyToOne(null, this, filter);
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

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection GetMultiEmployeesCollectionViaEmployeeTerritories(bool forceFetch)
		{
			return GetMultiEmployeesCollectionViaEmployeeTerritories(forceFetch, _employeesCollectionViaEmployeeTerritories.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection GetMultiEmployeesCollectionViaEmployeeTerritories(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeesCollectionViaEmployeeTerritories || forceFetch || _alwaysFetchEmployeesCollectionViaEmployeeTerritories) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_employeesCollectionViaEmployeeTerritories);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(TerritoryFields.TerritoryId, ComparisonOperator.Equal, this.TerritoryId, "TerritoryEntity__"));
				_employeesCollectionViaEmployeeTerritories.SuppressClearInGetMulti=!forceFetch;
				_employeesCollectionViaEmployeeTerritories.EntityFactoryToUse = entityFactoryToUse;
				_employeesCollectionViaEmployeeTerritories.GetMulti(filter, GetRelationsForField("EmployeesCollectionViaEmployeeTerritories"));
				_employeesCollectionViaEmployeeTerritories.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeesCollectionViaEmployeeTerritories = true;
			}
			return _employeesCollectionViaEmployeeTerritories;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeesCollectionViaEmployeeTerritories'. These settings will be taken into account
		/// when the property EmployeesCollectionViaEmployeeTerritories is requested or GetMultiEmployeesCollectionViaEmployeeTerritories is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeesCollectionViaEmployeeTerritories(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeesCollectionViaEmployeeTerritories.SortClauses=sortClauses;
			_employeesCollectionViaEmployeeTerritories.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'RegionEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'RegionEntity' which is related to this entity.</returns>
		public RegionEntity GetSingleRegion()
		{
			return GetSingleRegion(false);
		}

		/// <summary> Retrieves the related entity of type 'RegionEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'RegionEntity' which is related to this entity.</returns>
		public virtual RegionEntity GetSingleRegion(bool forceFetch)
		{
			if( ( !_alreadyFetchedRegion || forceFetch || _alwaysFetchRegion) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.RegionEntityUsingRegionId);
				RegionEntity newEntity = new RegionEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.RegionId);
				}
				if(fetchResult)
				{
					newEntity = (RegionEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_regionReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Region = newEntity;
				_alreadyFetchedRegion = fetchResult;
			}
			return _region;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Region", _region);
			toReturn.Add("EmployeeTerritories", _employeeTerritories);
			toReturn.Add("EmployeesCollectionViaEmployeeTerritories", _employeesCollectionViaEmployeeTerritories);
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
		/// <param name="territoryId">PK value for Territory which data should be fetched into this Territory object</param>
		/// <param name="validator">The validator object for this TerritoryEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.String territoryId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(territoryId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_employeeTerritories = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeTerritoryCollection();
			_employeeTerritories.SetContainingEntityInfo(this, "Territories");
			_employeesCollectionViaEmployeeTerritories = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection();
			_regionReturnsNewIfNotFound = true;
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
			_fieldsCustomProperties.Add("RegionId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TerritoryDescription", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TerritoryId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _region</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncRegion(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _region, new PropertyChangedEventHandler( OnRegionPropertyChanged ), "Region", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticTerritoryRelations.RegionEntityUsingRegionIdStatic, true, signalRelatedEntity, "Territories", resetFKFields, new int[] { (int)TerritoryFieldIndex.RegionId } );		
			_region = null;
		}
		
		/// <summary> setups the sync logic for member _region</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncRegion(IEntityCore relatedEntity)
		{
			if(_region!=relatedEntity)
			{		
				DesetupSyncRegion(true, true);
				_region = (RegionEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _region, new PropertyChangedEventHandler( OnRegionPropertyChanged ), "Region", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticTerritoryRelations.RegionEntityUsingRegionIdStatic, true, ref _alreadyFetchedRegion, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnRegionPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="territoryId">PK value for Territory which data should be fetched into this Territory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.String territoryId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)TerritoryFieldIndex.TerritoryId].ForcedCurrentValueWrite(territoryId);
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
			return DAOFactory.CreateTerritoryDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new TerritoryEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static TerritoryRelations Relations
		{
			get	{ return new TerritoryRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'EmployeeTerritory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeTerritories
		{
			get { return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeTerritoryCollection(), (IEntityRelation)GetRelationsForField("EmployeeTerritories")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.TerritoryEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.EmployeeTerritoryEntity, 0, null, null, null, "EmployeeTerritories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeesCollectionViaEmployeeTerritories
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.EmployeeTerritoryEntityUsingTerritoryId;
				intermediateRelation.SetAliases(string.Empty, "EmployeeTerritory_");
				return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection(), intermediateRelation,	(int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.TerritoryEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeesCollectionViaEmployeeTerritories"), "EmployeesCollectionViaEmployeeTerritories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Region'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRegion
		{
			get	{ return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.RegionCollection(), (IEntityRelation)GetRelationsForField("Region")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.TerritoryEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.RegionEntity, 0, null, null, null, "Region", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The RegionId property of the Entity Territory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Territories"."RegionID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 RegionId
		{
			get { return (System.Int32)GetValue((int)TerritoryFieldIndex.RegionId, true); }
			set	{ SetValue((int)TerritoryFieldIndex.RegionId, value, true); }
		}

		/// <summary> The TerritoryDescription property of the Entity Territory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Territories"."TerritoryDescription"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String TerritoryDescription
		{
			get { return (System.String)GetValue((int)TerritoryFieldIndex.TerritoryDescription, true); }
			set	{ SetValue((int)TerritoryFieldIndex.TerritoryDescription, value, true); }
		}

		/// <summary> The TerritoryId property of the Entity Territory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Territories"."TerritoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String TerritoryId
		{
			get { return (System.String)GetValue((int)TerritoryFieldIndex.TerritoryId, true); }
			set	{ SetValue((int)TerritoryFieldIndex.TerritoryId, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'EmployeeTerritoryEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeTerritories()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeTerritoryCollection EmployeeTerritories
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

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeesCollectionViaEmployeeTerritories()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection EmployeesCollectionViaEmployeeTerritories
		{
			get { return GetMultiEmployeesCollectionViaEmployeeTerritories(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeesCollectionViaEmployeeTerritories. When set to true, EmployeesCollectionViaEmployeeTerritories is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeesCollectionViaEmployeeTerritories is accessed. You can always execute a forced fetch by calling GetMultiEmployeesCollectionViaEmployeeTerritories(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeesCollectionViaEmployeeTerritories
		{
			get	{ return _alwaysFetchEmployeesCollectionViaEmployeeTerritories; }
			set	{ _alwaysFetchEmployeesCollectionViaEmployeeTerritories = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeesCollectionViaEmployeeTerritories already has been fetched. Setting this property to false when EmployeesCollectionViaEmployeeTerritories has been fetched
		/// will clear the EmployeesCollectionViaEmployeeTerritories collection well. Setting this property to true while EmployeesCollectionViaEmployeeTerritories hasn't been fetched disables lazy loading for EmployeesCollectionViaEmployeeTerritories</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeesCollectionViaEmployeeTerritories
		{
			get { return _alreadyFetchedEmployeesCollectionViaEmployeeTerritories;}
			set 
			{
				if(_alreadyFetchedEmployeesCollectionViaEmployeeTerritories && !value && (_employeesCollectionViaEmployeeTerritories != null))
				{
					_employeesCollectionViaEmployeeTerritories.Clear();
				}
				_alreadyFetchedEmployeesCollectionViaEmployeeTerritories = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'RegionEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleRegion()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual RegionEntity Region
		{
			get	{ return GetSingleRegion(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncRegion(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Territories", "Region", _region, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Region. When set to true, Region is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Region is accessed. You can always execute a forced fetch by calling GetSingleRegion(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRegion
		{
			get	{ return _alwaysFetchRegion; }
			set	{ _alwaysFetchRegion = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Region already has been fetched. Setting this property to false when Region has been fetched
		/// will set Region to null as well. Setting this property to true while Region hasn't been fetched disables lazy loading for Region</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRegion
		{
			get { return _alreadyFetchedRegion;}
			set 
			{
				if(_alreadyFetchedRegion && !value)
				{
					this.Region = null;
				}
				_alreadyFetchedRegion = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Region is not found
		/// in the database. When set to true, Region will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool RegionReturnsNewIfNotFound
		{
			get	{ return _regionReturnsNewIfNotFound; }
			set { _regionReturnsNewIfNotFound = value; }	
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
			get { return (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.TerritoryEntity; }
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
