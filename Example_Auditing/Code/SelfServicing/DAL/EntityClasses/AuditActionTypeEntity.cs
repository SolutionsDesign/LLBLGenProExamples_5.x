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

	/// <summary>Entity class which represents the entity 'AuditActionType'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class AuditActionTypeEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditInfoCollection	_auditInfo;
		private bool	_alwaysFetchAuditInfo, _alreadyFetchedAuditInfo;
		private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.UserCollection _userCollectionViaAuditInfo;
		private bool	_alwaysFetchUserCollectionViaAuditInfo, _alreadyFetchedUserCollectionViaAuditInfo;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name AuditInfo</summary>
			public static readonly string AuditInfo = "AuditInfo";
			/// <summary>Member name UserCollectionViaAuditInfo</summary>
			public static readonly string UserCollectionViaAuditInfo = "UserCollectionViaAuditInfo";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static AuditActionTypeEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public AuditActionTypeEntity() :base("AuditActionTypeEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="auditActionTypeId">PK value for AuditActionType which data should be fetched into this AuditActionType object</param>
		public AuditActionTypeEntity(System.Int32 auditActionTypeId):base("AuditActionTypeEntity")
		{
			InitClassFetch(auditActionTypeId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="auditActionTypeId">PK value for AuditActionType which data should be fetched into this AuditActionType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public AuditActionTypeEntity(System.Int32 auditActionTypeId, IPrefetchPath prefetchPathToUse):base("AuditActionTypeEntity")
		{
			InitClassFetch(auditActionTypeId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="auditActionTypeId">PK value for AuditActionType which data should be fetched into this AuditActionType object</param>
		/// <param name="validator">The custom validator object for this AuditActionTypeEntity</param>
		public AuditActionTypeEntity(System.Int32 auditActionTypeId, IValidator validator):base("AuditActionTypeEntity")
		{
			InitClassFetch(auditActionTypeId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AuditActionTypeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_auditInfo = (SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditInfoCollection)info.GetValue("_auditInfo", typeof(SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditInfoCollection));
			_alwaysFetchAuditInfo = info.GetBoolean("_alwaysFetchAuditInfo");
			_alreadyFetchedAuditInfo = info.GetBoolean("_alreadyFetchedAuditInfo");
			_userCollectionViaAuditInfo = (SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.UserCollection)info.GetValue("_userCollectionViaAuditInfo", typeof(SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.UserCollection));
			_alwaysFetchUserCollectionViaAuditInfo = info.GetBoolean("_alwaysFetchUserCollectionViaAuditInfo");
			_alreadyFetchedUserCollectionViaAuditInfo = info.GetBoolean("_alreadyFetchedUserCollectionViaAuditInfo");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedAuditInfo = (_auditInfo.Count > 0);
			_alreadyFetchedUserCollectionViaAuditInfo = (_userCollectionViaAuditInfo.Count > 0);
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
				case "AuditInfo":
					toReturn.Add(Relations.AuditInfoEntityUsingAuditActionTypeId);
					break;
				case "UserCollectionViaAuditInfo":
					toReturn.Add(Relations.AuditInfoEntityUsingAuditActionTypeId, "AuditActionTypeEntity__", "AuditInfo_", JoinHint.None);
					toReturn.Add(AuditInfoEntity.Relations.UserEntityUsingUserId, "AuditInfo_", string.Empty, JoinHint.None);
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
			info.AddValue("_auditInfo", (!this.MarkedForDeletion?_auditInfo:null));
			info.AddValue("_alwaysFetchAuditInfo", _alwaysFetchAuditInfo);
			info.AddValue("_alreadyFetchedAuditInfo", _alreadyFetchedAuditInfo);
			info.AddValue("_userCollectionViaAuditInfo", (!this.MarkedForDeletion?_userCollectionViaAuditInfo:null));
			info.AddValue("_alwaysFetchUserCollectionViaAuditInfo", _alwaysFetchUserCollectionViaAuditInfo);
			info.AddValue("_alreadyFetchedUserCollectionViaAuditInfo", _alreadyFetchedUserCollectionViaAuditInfo);

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
				case "AuditInfo":
					_alreadyFetchedAuditInfo = true;
					if(entity!=null)
					{
						this.AuditInfo.Add((AuditInfoEntity)entity);
					}
					break;
				case "UserCollectionViaAuditInfo":
					_alreadyFetchedUserCollectionViaAuditInfo = true;
					if(entity!=null)
					{
						this.UserCollectionViaAuditInfo.Add((UserEntity)entity);
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
				case "AuditInfo":
					_auditInfo.Add((AuditInfoEntity)relatedEntity);
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
				case "AuditInfo":
					this.PerformRelatedEntityRemoval(_auditInfo, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_auditInfo);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="auditActionTypeId">PK value for AuditActionType which data should be fetched into this AuditActionType object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 auditActionTypeId)
		{
			return FetchUsingPK(auditActionTypeId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="auditActionTypeId">PK value for AuditActionType which data should be fetched into this AuditActionType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 auditActionTypeId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(auditActionTypeId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="auditActionTypeId">PK value for AuditActionType which data should be fetched into this AuditActionType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 auditActionTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(auditActionTypeId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="auditActionTypeId">PK value for AuditActionType which data should be fetched into this AuditActionType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 auditActionTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(auditActionTypeId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.AuditActionTypeId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new AuditActionTypeRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'AuditInfoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AuditInfoEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditInfoCollection GetMultiAuditInfo(bool forceFetch)
		{
			return GetMultiAuditInfo(forceFetch, _auditInfo.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AuditInfoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'AuditInfoEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditInfoCollection GetMultiAuditInfo(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiAuditInfo(forceFetch, _auditInfo.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'AuditInfoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditInfoCollection GetMultiAuditInfo(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiAuditInfo(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AuditInfoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditInfoCollection GetMultiAuditInfo(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedAuditInfo || forceFetch || _alwaysFetchAuditInfo) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_auditInfo);
				_auditInfo.SuppressClearInGetMulti=!forceFetch;
				_auditInfo.EntityFactoryToUse = entityFactoryToUse;
				_auditInfo.GetMultiManyToOne(this, null, filter);
				_auditInfo.SuppressClearInGetMulti=false;
				_alreadyFetchedAuditInfo = true;
			}
			return _auditInfo;
		}

		/// <summary> Sets the collection parameters for the collection for 'AuditInfo'. These settings will be taken into account
		/// when the property AuditInfo is requested or GetMultiAuditInfo is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAuditInfo(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_auditInfo.SortClauses=sortClauses;
			_auditInfo.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UserEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.UserCollection GetMultiUserCollectionViaAuditInfo(bool forceFetch)
		{
			return GetMultiUserCollectionViaAuditInfo(forceFetch, _userCollectionViaAuditInfo.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.UserCollection GetMultiUserCollectionViaAuditInfo(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUserCollectionViaAuditInfo || forceFetch || _alwaysFetchUserCollectionViaAuditInfo) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_userCollectionViaAuditInfo);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AuditActionTypeFields.AuditActionTypeId, ComparisonOperator.Equal, this.AuditActionTypeId, "AuditActionTypeEntity__"));
				_userCollectionViaAuditInfo.SuppressClearInGetMulti=!forceFetch;
				_userCollectionViaAuditInfo.EntityFactoryToUse = entityFactoryToUse;
				_userCollectionViaAuditInfo.GetMulti(filter, GetRelationsForField("UserCollectionViaAuditInfo"));
				_userCollectionViaAuditInfo.SuppressClearInGetMulti=false;
				_alreadyFetchedUserCollectionViaAuditInfo = true;
			}
			return _userCollectionViaAuditInfo;
		}

		/// <summary> Sets the collection parameters for the collection for 'UserCollectionViaAuditInfo'. These settings will be taken into account
		/// when the property UserCollectionViaAuditInfo is requested or GetMultiUserCollectionViaAuditInfo is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUserCollectionViaAuditInfo(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_userCollectionViaAuditInfo.SortClauses=sortClauses;
			_userCollectionViaAuditInfo.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("AuditInfo", _auditInfo);
			toReturn.Add("UserCollectionViaAuditInfo", _userCollectionViaAuditInfo);
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
		/// <param name="auditActionTypeId">PK value for AuditActionType which data should be fetched into this AuditActionType object</param>
		/// <param name="validator">The validator object for this AuditActionTypeEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 auditActionTypeId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(auditActionTypeId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_auditInfo = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditInfoCollection();
			_auditInfo.SetContainingEntityInfo(this, "AuditActionType");
			_userCollectionViaAuditInfo = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.UserCollection();
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
			_fieldsCustomProperties.Add("AuditActionTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="auditActionTypeId">PK value for AuditActionType which data should be fetched into this AuditActionType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 auditActionTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)AuditActionTypeFieldIndex.AuditActionTypeId].ForcedCurrentValueWrite(auditActionTypeId);
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
			return DAOFactory.CreateAuditActionTypeDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new AuditActionTypeEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static AuditActionTypeRelations Relations
		{
			get	{ return new AuditActionTypeRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AuditInfo' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAuditInfo
		{
			get { return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditInfoCollection(), (IEntityRelation)GetRelationsForField("AuditInfo")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.AuditActionTypeEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.AuditInfoEntity, 0, null, null, null, "AuditInfo", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserCollectionViaAuditInfo
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.AuditInfoEntityUsingAuditActionTypeId;
				intermediateRelation.SetAliases(string.Empty, "AuditInfo_");
				return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.UserCollection(), intermediateRelation,	(int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.AuditActionTypeEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaAuditInfo"), "UserCollectionViaAuditInfo", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
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

		/// <summary> The AuditActionTypeId property of the Entity AuditActionType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditActionType"."AuditActionTypeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 AuditActionTypeId
		{
			get { return (System.Int32)GetValue((int)AuditActionTypeFieldIndex.AuditActionTypeId, true); }
			set	{ SetValue((int)AuditActionTypeFieldIndex.AuditActionTypeId, value, true); }
		}

		/// <summary> The Name property of the Entity AuditActionType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditActionType"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)AuditActionTypeFieldIndex.Name, true); }
			set	{ SetValue((int)AuditActionTypeFieldIndex.Name, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'AuditInfoEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAuditInfo()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditInfoCollection AuditInfo
		{
			get	{ return GetMultiAuditInfo(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AuditInfo. When set to true, AuditInfo is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AuditInfo is accessed. You can always execute/ a forced fetch by calling GetMultiAuditInfo(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAuditInfo
		{
			get	{ return _alwaysFetchAuditInfo; }
			set	{ _alwaysFetchAuditInfo = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property AuditInfo already has been fetched. Setting this property to false when AuditInfo has been fetched
		/// will clear the AuditInfo collection well. Setting this property to true while AuditInfo hasn't been fetched disables lazy loading for AuditInfo</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAuditInfo
		{
			get { return _alreadyFetchedAuditInfo;}
			set 
			{
				if(_alreadyFetchedAuditInfo && !value && (_auditInfo != null))
				{
					_auditInfo.Clear();
				}
				_alreadyFetchedAuditInfo = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUserCollectionViaAuditInfo()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.UserCollection UserCollectionViaAuditInfo
		{
			get { return GetMultiUserCollectionViaAuditInfo(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for UserCollectionViaAuditInfo. When set to true, UserCollectionViaAuditInfo is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UserCollectionViaAuditInfo is accessed. You can always execute a forced fetch by calling GetMultiUserCollectionViaAuditInfo(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUserCollectionViaAuditInfo
		{
			get	{ return _alwaysFetchUserCollectionViaAuditInfo; }
			set	{ _alwaysFetchUserCollectionViaAuditInfo = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UserCollectionViaAuditInfo already has been fetched. Setting this property to false when UserCollectionViaAuditInfo has been fetched
		/// will clear the UserCollectionViaAuditInfo collection well. Setting this property to true while UserCollectionViaAuditInfo hasn't been fetched disables lazy loading for UserCollectionViaAuditInfo</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUserCollectionViaAuditInfo
		{
			get { return _alreadyFetchedUserCollectionViaAuditInfo;}
			set 
			{
				if(_alreadyFetchedUserCollectionViaAuditInfo && !value && (_userCollectionViaAuditInfo != null))
				{
					_userCollectionViaAuditInfo.Clear();
				}
				_alreadyFetchedUserCollectionViaAuditInfo = value;
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
			get { return (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.AuditActionTypeEntity; }
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
