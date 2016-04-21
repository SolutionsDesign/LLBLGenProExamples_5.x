///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated on: vrijdag 20 juni 2014 13:18:28
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

	/// <summary>Entity class which represents the entity 'CustomerDemography'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class CustomerDemographyEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private SD.LLBLGen.Pro.Examples.CollectionClasses.CustomerCustomerDemoCollection	_customerCustomerDemo;
		private bool	_alwaysFetchCustomerCustomerDemo, _alreadyFetchedCustomerCustomerDemo;
		private SD.LLBLGen.Pro.Examples.CollectionClasses.CustomerCollection _customerCollectionViaCustomerCustomerDemo;
		private bool	_alwaysFetchCustomerCollectionViaCustomerCustomerDemo, _alreadyFetchedCustomerCollectionViaCustomerCustomerDemo;

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
			/// <summary>Member name CustomerCollectionViaCustomerCustomerDemo</summary>
			public static readonly string CustomerCollectionViaCustomerCustomerDemo = "CustomerCollectionViaCustomerCustomerDemo";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CustomerDemographyEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public CustomerDemographyEntity() :base("CustomerDemographyEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="customerTypeId">PK value for CustomerDemography which data should be fetched into this CustomerDemography object</param>
		public CustomerDemographyEntity(System.String customerTypeId):base("CustomerDemographyEntity")
		{
			InitClassFetch(customerTypeId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="customerTypeId">PK value for CustomerDemography which data should be fetched into this CustomerDemography object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CustomerDemographyEntity(System.String customerTypeId, IPrefetchPath prefetchPathToUse):base("CustomerDemographyEntity")
		{
			InitClassFetch(customerTypeId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="customerTypeId">PK value for CustomerDemography which data should be fetched into this CustomerDemography object</param>
		/// <param name="validator">The custom validator object for this CustomerDemographyEntity</param>
		public CustomerDemographyEntity(System.String customerTypeId, IValidator validator):base("CustomerDemographyEntity")
		{
			InitClassFetch(customerTypeId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CustomerDemographyEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_customerCustomerDemo = (SD.LLBLGen.Pro.Examples.CollectionClasses.CustomerCustomerDemoCollection)info.GetValue("_customerCustomerDemo", typeof(SD.LLBLGen.Pro.Examples.CollectionClasses.CustomerCustomerDemoCollection));
			_alwaysFetchCustomerCustomerDemo = info.GetBoolean("_alwaysFetchCustomerCustomerDemo");
			_alreadyFetchedCustomerCustomerDemo = info.GetBoolean("_alreadyFetchedCustomerCustomerDemo");
			_customerCollectionViaCustomerCustomerDemo = (SD.LLBLGen.Pro.Examples.CollectionClasses.CustomerCollection)info.GetValue("_customerCollectionViaCustomerCustomerDemo", typeof(SD.LLBLGen.Pro.Examples.CollectionClasses.CustomerCollection));
			_alwaysFetchCustomerCollectionViaCustomerCustomerDemo = info.GetBoolean("_alwaysFetchCustomerCollectionViaCustomerCustomerDemo");
			_alreadyFetchedCustomerCollectionViaCustomerCustomerDemo = info.GetBoolean("_alreadyFetchedCustomerCollectionViaCustomerCustomerDemo");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedCustomerCustomerDemo = (_customerCustomerDemo.Count > 0);
			_alreadyFetchedCustomerCollectionViaCustomerCustomerDemo = (_customerCollectionViaCustomerCustomerDemo.Count > 0);
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
					toReturn.Add(Relations.CustomerCustomerDemoEntityUsingCustomerTypeId);
					break;
				case "CustomerCollectionViaCustomerCustomerDemo":
					toReturn.Add(Relations.CustomerCustomerDemoEntityUsingCustomerTypeId, "CustomerDemographyEntity__", "CustomerCustomerDemo_", JoinHint.None);
					toReturn.Add(CustomerCustomerDemoEntity.Relations.CustomerEntityUsingCustomerId, "CustomerCustomerDemo_", string.Empty, JoinHint.None);
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
			info.AddValue("_customerCollectionViaCustomerCustomerDemo", (!this.MarkedForDeletion?_customerCollectionViaCustomerCustomerDemo:null));
			info.AddValue("_alwaysFetchCustomerCollectionViaCustomerCustomerDemo", _alwaysFetchCustomerCollectionViaCustomerCustomerDemo);
			info.AddValue("_alreadyFetchedCustomerCollectionViaCustomerCustomerDemo", _alreadyFetchedCustomerCollectionViaCustomerCustomerDemo);

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
				case "CustomerCollectionViaCustomerCustomerDemo":
					_alreadyFetchedCustomerCollectionViaCustomerCustomerDemo = true;
					if(entity!=null)
					{
						this.CustomerCollectionViaCustomerCustomerDemo.Add((CustomerEntity)entity);
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

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerTypeId">PK value for CustomerDemography which data should be fetched into this CustomerDemography object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String customerTypeId)
		{
			return FetchUsingPK(customerTypeId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerTypeId">PK value for CustomerDemography which data should be fetched into this CustomerDemography object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String customerTypeId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(customerTypeId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerTypeId">PK value for CustomerDemography which data should be fetched into this CustomerDemography object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String customerTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(customerTypeId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerTypeId">PK value for CustomerDemography which data should be fetched into this CustomerDemography object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String customerTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(customerTypeId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CustomerTypeId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new CustomerDemographyRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'CustomerCustomerDemoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerCustomerDemoEntity'</returns>
		public SD.LLBLGen.Pro.Examples.CollectionClasses.CustomerCustomerDemoCollection GetMultiCustomerCustomerDemo(bool forceFetch)
		{
			return GetMultiCustomerCustomerDemo(forceFetch, _customerCustomerDemo.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CustomerCustomerDemoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'CustomerCustomerDemoEntity'</returns>
		public SD.LLBLGen.Pro.Examples.CollectionClasses.CustomerCustomerDemoCollection GetMultiCustomerCustomerDemo(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiCustomerCustomerDemo(forceFetch, _customerCustomerDemo.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'CustomerCustomerDemoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SD.LLBLGen.Pro.Examples.CollectionClasses.CustomerCustomerDemoCollection GetMultiCustomerCustomerDemo(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiCustomerCustomerDemo(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CustomerCustomerDemoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SD.LLBLGen.Pro.Examples.CollectionClasses.CustomerCustomerDemoCollection GetMultiCustomerCustomerDemo(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedCustomerCustomerDemo || forceFetch || _alwaysFetchCustomerCustomerDemo) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_customerCustomerDemo);
				_customerCustomerDemo.SuppressClearInGetMulti=!forceFetch;
				_customerCustomerDemo.EntityFactoryToUse = entityFactoryToUse;
				_customerCustomerDemo.GetMultiManyToOne(null, this, filter);
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

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerEntity'</returns>
		public SD.LLBLGen.Pro.Examples.CollectionClasses.CustomerCollection GetMultiCustomerCollectionViaCustomerCustomerDemo(bool forceFetch)
		{
			return GetMultiCustomerCollectionViaCustomerCustomerDemo(forceFetch, _customerCollectionViaCustomerCustomerDemo.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SD.LLBLGen.Pro.Examples.CollectionClasses.CustomerCollection GetMultiCustomerCollectionViaCustomerCustomerDemo(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCustomerCollectionViaCustomerCustomerDemo || forceFetch || _alwaysFetchCustomerCollectionViaCustomerCustomerDemo) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_customerCollectionViaCustomerCustomerDemo);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(CustomerDemographyFields.CustomerTypeId, ComparisonOperator.Equal, this.CustomerTypeId, "CustomerDemographyEntity__"));
				_customerCollectionViaCustomerCustomerDemo.SuppressClearInGetMulti=!forceFetch;
				_customerCollectionViaCustomerCustomerDemo.EntityFactoryToUse = entityFactoryToUse;
				_customerCollectionViaCustomerCustomerDemo.GetMulti(filter, GetRelationsForField("CustomerCollectionViaCustomerCustomerDemo"));
				_customerCollectionViaCustomerCustomerDemo.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerCollectionViaCustomerCustomerDemo = true;
			}
			return _customerCollectionViaCustomerCustomerDemo;
		}

		/// <summary> Sets the collection parameters for the collection for 'CustomerCollectionViaCustomerCustomerDemo'. These settings will be taken into account
		/// when the property CustomerCollectionViaCustomerCustomerDemo is requested or GetMultiCustomerCollectionViaCustomerCustomerDemo is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomerCollectionViaCustomerCustomerDemo(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customerCollectionViaCustomerCustomerDemo.SortClauses=sortClauses;
			_customerCollectionViaCustomerCustomerDemo.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("CustomerCustomerDemo", _customerCustomerDemo);
			toReturn.Add("CustomerCollectionViaCustomerCustomerDemo", _customerCollectionViaCustomerCustomerDemo);
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
		/// <param name="customerTypeId">PK value for CustomerDemography which data should be fetched into this CustomerDemography object</param>
		/// <param name="validator">The validator object for this CustomerDemographyEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.String customerTypeId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(customerTypeId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_customerCustomerDemo = new SD.LLBLGen.Pro.Examples.CollectionClasses.CustomerCustomerDemoCollection();
			_customerCustomerDemo.SetContainingEntityInfo(this, "CustomerDemography");
			_customerCollectionViaCustomerCustomerDemo = new SD.LLBLGen.Pro.Examples.CollectionClasses.CustomerCollection();
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
			_fieldsCustomProperties.Add("CustomerDesc", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CustomerTypeId", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="customerTypeId">PK value for CustomerDemography which data should be fetched into this CustomerDemography object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.String customerTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)CustomerDemographyFieldIndex.CustomerTypeId].ForcedCurrentValueWrite(customerTypeId);
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
			return DAOFactory.CreateCustomerDemographyDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new CustomerDemographyEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static CustomerDemographyRelations Relations
		{
			get	{ return new CustomerDemographyRelations(); }
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
			get { return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.CollectionClasses.CustomerCustomerDemoCollection(), (IEntityRelation)GetRelationsForField("CustomerCustomerDemo")[0], (int)SD.LLBLGen.Pro.Examples.EntityType.CustomerDemographyEntity, (int)SD.LLBLGen.Pro.Examples.EntityType.CustomerCustomerDemoEntity, 0, null, null, null, "CustomerCustomerDemo", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Customer'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerCollectionViaCustomerCustomerDemo
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.CustomerCustomerDemoEntityUsingCustomerTypeId;
				intermediateRelation.SetAliases(string.Empty, "CustomerCustomerDemo_");
				return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.CollectionClasses.CustomerCollection(), intermediateRelation,	(int)SD.LLBLGen.Pro.Examples.EntityType.CustomerDemographyEntity, (int)SD.LLBLGen.Pro.Examples.EntityType.CustomerEntity, 0, null, null, GetRelationsForField("CustomerCollectionViaCustomerCustomerDemo"), "CustomerCollectionViaCustomerCustomerDemo", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
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

		/// <summary> The CustomerDesc property of the Entity CustomerDemography<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CustomerDemographics"."CustomerDesc"<br/>
		/// Table field type characteristics (type, precision, scale, length): NText, 0, 0, 1073741823<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CustomerDesc
		{
			get { return (System.String)GetValue((int)CustomerDemographyFieldIndex.CustomerDesc, true); }
			set	{ SetValue((int)CustomerDemographyFieldIndex.CustomerDesc, value, true); }
		}

		/// <summary> The CustomerTypeId property of the Entity CustomerDemography<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CustomerDemographics"."CustomerTypeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CustomerTypeId
		{
			get { return (System.String)GetValue((int)CustomerDemographyFieldIndex.CustomerTypeId, true); }
			set	{ SetValue((int)CustomerDemographyFieldIndex.CustomerTypeId, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'CustomerCustomerDemoEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerCustomerDemo()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual SD.LLBLGen.Pro.Examples.CollectionClasses.CustomerCustomerDemoCollection CustomerCustomerDemo
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

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerCollectionViaCustomerCustomerDemo()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual SD.LLBLGen.Pro.Examples.CollectionClasses.CustomerCollection CustomerCollectionViaCustomerCustomerDemo
		{
			get { return GetMultiCustomerCollectionViaCustomerCustomerDemo(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerCollectionViaCustomerCustomerDemo. When set to true, CustomerCollectionViaCustomerCustomerDemo is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerCollectionViaCustomerCustomerDemo is accessed. You can always execute a forced fetch by calling GetMultiCustomerCollectionViaCustomerCustomerDemo(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerCollectionViaCustomerCustomerDemo
		{
			get	{ return _alwaysFetchCustomerCollectionViaCustomerCustomerDemo; }
			set	{ _alwaysFetchCustomerCollectionViaCustomerCustomerDemo = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerCollectionViaCustomerCustomerDemo already has been fetched. Setting this property to false when CustomerCollectionViaCustomerCustomerDemo has been fetched
		/// will clear the CustomerCollectionViaCustomerCustomerDemo collection well. Setting this property to true while CustomerCollectionViaCustomerCustomerDemo hasn't been fetched disables lazy loading for CustomerCollectionViaCustomerCustomerDemo</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerCollectionViaCustomerCustomerDemo
		{
			get { return _alreadyFetchedCustomerCollectionViaCustomerCustomerDemo;}
			set 
			{
				if(_alreadyFetchedCustomerCollectionViaCustomerCustomerDemo && !value && (_customerCollectionViaCustomerCustomerDemo != null))
				{
					_customerCollectionViaCustomerCustomerDemo.Clear();
				}
				_alreadyFetchedCustomerCollectionViaCustomerCustomerDemo = value;
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
		
		/// <summary>Returns the SD.LLBLGen.Pro.Examples.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)SD.LLBLGen.Pro.Examples.EntityType.CustomerDemographyEntity; }
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
