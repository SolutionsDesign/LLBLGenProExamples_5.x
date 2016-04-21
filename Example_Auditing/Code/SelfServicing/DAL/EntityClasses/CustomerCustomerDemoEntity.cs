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

	/// <summary>Entity class which represents the entity 'CustomerCustomerDemo'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class CustomerCustomerDemoEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private CustomerEntity _customers;
		private bool	_alwaysFetchCustomers, _alreadyFetchedCustomers, _customersReturnsNewIfNotFound;
		private CustomerDemographyEntity _customerDemographics;
		private bool	_alwaysFetchCustomerDemographics, _alreadyFetchedCustomerDemographics, _customerDemographicsReturnsNewIfNotFound;

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
			/// <summary>Member name CustomerDemographics</summary>
			public static readonly string CustomerDemographics = "CustomerDemographics";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CustomerCustomerDemoEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public CustomerCustomerDemoEntity() :base("CustomerCustomerDemoEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="customerId">PK value for CustomerCustomerDemo which data should be fetched into this CustomerCustomerDemo object</param>
		/// <param name="customerTypeId">PK value for CustomerCustomerDemo which data should be fetched into this CustomerCustomerDemo object</param>
		public CustomerCustomerDemoEntity(System.String customerId, System.String customerTypeId):base("CustomerCustomerDemoEntity")
		{
			InitClassFetch(customerId, customerTypeId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="customerId">PK value for CustomerCustomerDemo which data should be fetched into this CustomerCustomerDemo object</param>
		/// <param name="customerTypeId">PK value for CustomerCustomerDemo which data should be fetched into this CustomerCustomerDemo object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CustomerCustomerDemoEntity(System.String customerId, System.String customerTypeId, IPrefetchPath prefetchPathToUse):base("CustomerCustomerDemoEntity")
		{
			InitClassFetch(customerId, customerTypeId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="customerId">PK value for CustomerCustomerDemo which data should be fetched into this CustomerCustomerDemo object</param>
		/// <param name="customerTypeId">PK value for CustomerCustomerDemo which data should be fetched into this CustomerCustomerDemo object</param>
		/// <param name="validator">The custom validator object for this CustomerCustomerDemoEntity</param>
		public CustomerCustomerDemoEntity(System.String customerId, System.String customerTypeId, IValidator validator):base("CustomerCustomerDemoEntity")
		{
			InitClassFetch(customerId, customerTypeId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CustomerCustomerDemoEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_customers = (CustomerEntity)info.GetValue("_customers", typeof(CustomerEntity));
			if(_customers!=null)
			{
				_customers.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_customersReturnsNewIfNotFound = info.GetBoolean("_customersReturnsNewIfNotFound");
			_alwaysFetchCustomers = info.GetBoolean("_alwaysFetchCustomers");
			_alreadyFetchedCustomers = info.GetBoolean("_alreadyFetchedCustomers");

			_customerDemographics = (CustomerDemographyEntity)info.GetValue("_customerDemographics", typeof(CustomerDemographyEntity));
			if(_customerDemographics!=null)
			{
				_customerDemographics.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_customerDemographicsReturnsNewIfNotFound = info.GetBoolean("_customerDemographicsReturnsNewIfNotFound");
			_alwaysFetchCustomerDemographics = info.GetBoolean("_alwaysFetchCustomerDemographics");
			_alreadyFetchedCustomerDemographics = info.GetBoolean("_alreadyFetchedCustomerDemographics");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((CustomerCustomerDemoFieldIndex)fieldIndex)
			{
				case CustomerCustomerDemoFieldIndex.CustomerId:
					DesetupSyncCustomers(true, false);
					_alreadyFetchedCustomers = false;
					break;
				case CustomerCustomerDemoFieldIndex.CustomerTypeId:
					DesetupSyncCustomerDemographics(true, false);
					_alreadyFetchedCustomerDemographics = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedCustomers = (_customers != null);
			_alreadyFetchedCustomerDemographics = (_customerDemographics != null);
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
				case "CustomerDemographics":
					toReturn.Add(Relations.CustomerDemographyEntityUsingCustomerTypeId);
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
			info.AddValue("_customers", (!this.MarkedForDeletion?_customers:null));
			info.AddValue("_customersReturnsNewIfNotFound", _customersReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCustomers", _alwaysFetchCustomers);
			info.AddValue("_alreadyFetchedCustomers", _alreadyFetchedCustomers);
			info.AddValue("_customerDemographics", (!this.MarkedForDeletion?_customerDemographics:null));
			info.AddValue("_customerDemographicsReturnsNewIfNotFound", _customerDemographicsReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCustomerDemographics", _alwaysFetchCustomerDemographics);
			info.AddValue("_alreadyFetchedCustomerDemographics", _alreadyFetchedCustomerDemographics);

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
				case "CustomerDemographics":
					_alreadyFetchedCustomerDemographics = true;
					this.CustomerDemographics = (CustomerDemographyEntity)entity;
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
				case "CustomerDemographics":
					SetupSyncCustomerDemographics(relatedEntity);
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
				case "CustomerDemographics":
					DesetupSyncCustomerDemographics(false, true);
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
			if(_customerDemographics!=null)
			{
				toReturn.Add(_customerDemographics);
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
		/// <param name="customerId">PK value for CustomerCustomerDemo which data should be fetched into this CustomerCustomerDemo object</param>
		/// <param name="customerTypeId">PK value for CustomerCustomerDemo which data should be fetched into this CustomerCustomerDemo object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String customerId, System.String customerTypeId)
		{
			return FetchUsingPK(customerId, customerTypeId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerId">PK value for CustomerCustomerDemo which data should be fetched into this CustomerCustomerDemo object</param>
		/// <param name="customerTypeId">PK value for CustomerCustomerDemo which data should be fetched into this CustomerCustomerDemo object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String customerId, System.String customerTypeId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(customerId, customerTypeId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerId">PK value for CustomerCustomerDemo which data should be fetched into this CustomerCustomerDemo object</param>
		/// <param name="customerTypeId">PK value for CustomerCustomerDemo which data should be fetched into this CustomerCustomerDemo object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String customerId, System.String customerTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(customerId, customerTypeId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerId">PK value for CustomerCustomerDemo which data should be fetched into this CustomerCustomerDemo object</param>
		/// <param name="customerTypeId">PK value for CustomerCustomerDemo which data should be fetched into this CustomerCustomerDemo object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String customerId, System.String customerTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(customerId, customerTypeId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CustomerId, this.CustomerTypeId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new CustomerCustomerDemoRelations().GetAllRelations();
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


		/// <summary> Retrieves the related entity of type 'CustomerDemographyEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'CustomerDemographyEntity' which is related to this entity.</returns>
		public CustomerDemographyEntity GetSingleCustomerDemographics()
		{
			return GetSingleCustomerDemographics(false);
		}

		/// <summary> Retrieves the related entity of type 'CustomerDemographyEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CustomerDemographyEntity' which is related to this entity.</returns>
		public virtual CustomerDemographyEntity GetSingleCustomerDemographics(bool forceFetch)
		{
			if( ( !_alreadyFetchedCustomerDemographics || forceFetch || _alwaysFetchCustomerDemographics) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.CustomerDemographyEntityUsingCustomerTypeId);
				CustomerDemographyEntity newEntity = new CustomerDemographyEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.CustomerTypeId);
				}
				if(fetchResult)
				{
					newEntity = (CustomerDemographyEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_customerDemographicsReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.CustomerDemographics = newEntity;
				_alreadyFetchedCustomerDemographics = fetchResult;
			}
			return _customerDemographics;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Customers", _customers);
			toReturn.Add("CustomerDemographics", _customerDemographics);
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
		/// <param name="customerId">PK value for CustomerCustomerDemo which data should be fetched into this CustomerCustomerDemo object</param>
		/// <param name="customerTypeId">PK value for CustomerCustomerDemo which data should be fetched into this CustomerCustomerDemo object</param>
		/// <param name="validator">The validator object for this CustomerCustomerDemoEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.String customerId, System.String customerTypeId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(customerId, customerTypeId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_customersReturnsNewIfNotFound = true;
			_customerDemographicsReturnsNewIfNotFound = true;
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
			_fieldsCustomProperties.Add("CustomerTypeId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _customers</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCustomers(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _customers, new PropertyChangedEventHandler( OnCustomersPropertyChanged ), "Customers", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticCustomerCustomerDemoRelations.CustomerEntityUsingCustomerIdStatic, true, signalRelatedEntity, "CustomerCustomerDemo", resetFKFields, new int[] { (int)CustomerCustomerDemoFieldIndex.CustomerId } );		
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
				this.PerformSetupSyncRelatedEntity( _customers, new PropertyChangedEventHandler( OnCustomersPropertyChanged ), "Customers", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticCustomerCustomerDemoRelations.CustomerEntityUsingCustomerIdStatic, true, ref _alreadyFetchedCustomers, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _customerDemographics</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCustomerDemographics(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _customerDemographics, new PropertyChangedEventHandler( OnCustomerDemographicsPropertyChanged ), "CustomerDemographics", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticCustomerCustomerDemoRelations.CustomerDemographyEntityUsingCustomerTypeIdStatic, true, signalRelatedEntity, "CustomerCustomerDemo", resetFKFields, new int[] { (int)CustomerCustomerDemoFieldIndex.CustomerTypeId } );		
			_customerDemographics = null;
		}
		
		/// <summary> setups the sync logic for member _customerDemographics</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCustomerDemographics(IEntityCore relatedEntity)
		{
			if(_customerDemographics!=relatedEntity)
			{		
				DesetupSyncCustomerDemographics(true, true);
				_customerDemographics = (CustomerDemographyEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _customerDemographics, new PropertyChangedEventHandler( OnCustomerDemographicsPropertyChanged ), "CustomerDemographics", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticCustomerCustomerDemoRelations.CustomerDemographyEntityUsingCustomerTypeIdStatic, true, ref _alreadyFetchedCustomerDemographics, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCustomerDemographicsPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="customerId">PK value for CustomerCustomerDemo which data should be fetched into this CustomerCustomerDemo object</param>
		/// <param name="customerTypeId">PK value for CustomerCustomerDemo which data should be fetched into this CustomerCustomerDemo object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.String customerId, System.String customerTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)CustomerCustomerDemoFieldIndex.CustomerId].ForcedCurrentValueWrite(customerId);
				this.Fields[(int)CustomerCustomerDemoFieldIndex.CustomerTypeId].ForcedCurrentValueWrite(customerTypeId);
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
			return DAOFactory.CreateCustomerCustomerDemoDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new CustomerCustomerDemoEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static CustomerCustomerDemoRelations Relations
		{
			get	{ return new CustomerCustomerDemoRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Customer'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomers
		{
			get	{ return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerCollection(), (IEntityRelation)GetRelationsForField("Customers")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.CustomerCustomerDemoEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.CustomerEntity, 0, null, null, null, "Customers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CustomerDemography'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerDemographics
		{
			get	{ return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerDemographyCollection(), (IEntityRelation)GetRelationsForField("CustomerDemographics")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.CustomerCustomerDemoEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.CustomerDemographyEntity, 0, null, null, null, "CustomerDemographics", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The CustomerId property of the Entity CustomerCustomerDemo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CustomerCustomerDemo"."CustomerID"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 5<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CustomerId
		{
			get { return (System.String)GetValue((int)CustomerCustomerDemoFieldIndex.CustomerId, true); }
			set	{ SetValue((int)CustomerCustomerDemoFieldIndex.CustomerId, value, true); }
		}

		/// <summary> The CustomerTypeId property of the Entity CustomerCustomerDemo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CustomerCustomerDemo"."CustomerTypeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CustomerTypeId
		{
			get { return (System.String)GetValue((int)CustomerCustomerDemoFieldIndex.CustomerTypeId, true); }
			set	{ SetValue((int)CustomerCustomerDemoFieldIndex.CustomerTypeId, value, true); }
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
					SetSingleRelatedEntityNavigator(value, "CustomerCustomerDemo", "Customers", _customers, true); 
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

		/// <summary> Gets / sets related entity of type 'CustomerDemographyEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCustomerDemographics()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual CustomerDemographyEntity CustomerDemographics
		{
			get	{ return GetSingleCustomerDemographics(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncCustomerDemographics(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "CustomerCustomerDemo", "CustomerDemographics", _customerDemographics, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerDemographics. When set to true, CustomerDemographics is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerDemographics is accessed. You can always execute a forced fetch by calling GetSingleCustomerDemographics(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerDemographics
		{
			get	{ return _alwaysFetchCustomerDemographics; }
			set	{ _alwaysFetchCustomerDemographics = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerDemographics already has been fetched. Setting this property to false when CustomerDemographics has been fetched
		/// will set CustomerDemographics to null as well. Setting this property to true while CustomerDemographics hasn't been fetched disables lazy loading for CustomerDemographics</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerDemographics
		{
			get { return _alreadyFetchedCustomerDemographics;}
			set 
			{
				if(_alreadyFetchedCustomerDemographics && !value)
				{
					this.CustomerDemographics = null;
				}
				_alreadyFetchedCustomerDemographics = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property CustomerDemographics is not found
		/// in the database. When set to true, CustomerDemographics will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool CustomerDemographicsReturnsNewIfNotFound
		{
			get	{ return _customerDemographicsReturnsNewIfNotFound; }
			set { _customerDemographicsReturnsNewIfNotFound = value; }	
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
			get { return (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.CustomerCustomerDemoEntity; }
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
