///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
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

	/// <summary>Entity class which represents the entity 'CustomerCustomerDemo'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class CustomerCustomerDemoEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private CustomerEntity _customer;
		private bool	_alwaysFetchCustomer, _alreadyFetchedCustomer, _customerReturnsNewIfNotFound;
		private CustomerDemographicEntity _customerDemographic;
		private bool	_alwaysFetchCustomerDemographic, _alreadyFetchedCustomerDemographic, _customerDemographicReturnsNewIfNotFound;

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
			/// <summary>Member name CustomerDemographic</summary>
			public static readonly string CustomerDemographic = "CustomerDemographic";
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
			_customer = (CustomerEntity)info.GetValue("_customer", typeof(CustomerEntity));
			if(_customer!=null)
			{
				_customer.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_customerReturnsNewIfNotFound = info.GetBoolean("_customerReturnsNewIfNotFound");
			_alwaysFetchCustomer = info.GetBoolean("_alwaysFetchCustomer");
			_alreadyFetchedCustomer = info.GetBoolean("_alreadyFetchedCustomer");

			_customerDemographic = (CustomerDemographicEntity)info.GetValue("_customerDemographic", typeof(CustomerDemographicEntity));
			if(_customerDemographic!=null)
			{
				_customerDemographic.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_customerDemographicReturnsNewIfNotFound = info.GetBoolean("_customerDemographicReturnsNewIfNotFound");
			_alwaysFetchCustomerDemographic = info.GetBoolean("_alwaysFetchCustomerDemographic");
			_alreadyFetchedCustomerDemographic = info.GetBoolean("_alreadyFetchedCustomerDemographic");
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
					DesetupSyncCustomer(true, false);
					_alreadyFetchedCustomer = false;
					break;
				case CustomerCustomerDemoFieldIndex.CustomerTypeId:
					DesetupSyncCustomerDemographic(true, false);
					_alreadyFetchedCustomerDemographic = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedCustomer = (_customer != null);
			_alreadyFetchedCustomerDemographic = (_customerDemographic != null);
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
				case "CustomerDemographic":
					toReturn.Add(Relations.CustomerDemographicEntityUsingCustomerTypeId);
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
			info.AddValue("_customer", (!this.MarkedForDeletion?_customer:null));
			info.AddValue("_customerReturnsNewIfNotFound", _customerReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCustomer", _alwaysFetchCustomer);
			info.AddValue("_alreadyFetchedCustomer", _alreadyFetchedCustomer);
			info.AddValue("_customerDemographic", (!this.MarkedForDeletion?_customerDemographic:null));
			info.AddValue("_customerDemographicReturnsNewIfNotFound", _customerDemographicReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCustomerDemographic", _alwaysFetchCustomerDemographic);
			info.AddValue("_alreadyFetchedCustomerDemographic", _alreadyFetchedCustomerDemographic);

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
				case "CustomerDemographic":
					_alreadyFetchedCustomerDemographic = true;
					this.CustomerDemographic = (CustomerDemographicEntity)entity;
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
				case "CustomerDemographic":
					SetupSyncCustomerDemographic(relatedEntity);
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
				case "CustomerDemographic":
					DesetupSyncCustomerDemographic(false, true);
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
			if(_customerDemographic!=null)
			{
				toReturn.Add(_customerDemographic);
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


		/// <summary> Retrieves the related entity of type 'CustomerDemographicEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'CustomerDemographicEntity' which is related to this entity.</returns>
		public CustomerDemographicEntity GetSingleCustomerDemographic()
		{
			return GetSingleCustomerDemographic(false);
		}

		/// <summary> Retrieves the related entity of type 'CustomerDemographicEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CustomerDemographicEntity' which is related to this entity.</returns>
		public virtual CustomerDemographicEntity GetSingleCustomerDemographic(bool forceFetch)
		{
			if( ( !_alreadyFetchedCustomerDemographic || forceFetch || _alwaysFetchCustomerDemographic) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.CustomerDemographicEntityUsingCustomerTypeId);
				CustomerDemographicEntity newEntity = new CustomerDemographicEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.CustomerTypeId);
				}
				if(fetchResult)
				{
					newEntity = (CustomerDemographicEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_customerDemographicReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.CustomerDemographic = newEntity;
				_alreadyFetchedCustomerDemographic = fetchResult;
			}
			return _customerDemographic;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Customer", _customer);
			toReturn.Add("CustomerDemographic", _customerDemographic);
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
			_customerReturnsNewIfNotFound = false;
			_customerDemographicReturnsNewIfNotFound = false;
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

		/// <summary> Removes the sync logic for member _customer</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCustomer(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _customer, new PropertyChangedEventHandler( OnCustomerPropertyChanged ), "Customer", Northwind.SSDAL.RelationClasses.StaticCustomerCustomerDemoRelations.CustomerEntityUsingCustomerIdStatic, true, signalRelatedEntity, "CustomerCustomerDemos", resetFKFields, new int[] { (int)CustomerCustomerDemoFieldIndex.CustomerId } );		
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
				this.PerformSetupSyncRelatedEntity( _customer, new PropertyChangedEventHandler( OnCustomerPropertyChanged ), "Customer", Northwind.SSDAL.RelationClasses.StaticCustomerCustomerDemoRelations.CustomerEntityUsingCustomerIdStatic, true, ref _alreadyFetchedCustomer, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _customerDemographic</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCustomerDemographic(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _customerDemographic, new PropertyChangedEventHandler( OnCustomerDemographicPropertyChanged ), "CustomerDemographic", Northwind.SSDAL.RelationClasses.StaticCustomerCustomerDemoRelations.CustomerDemographicEntityUsingCustomerTypeIdStatic, true, signalRelatedEntity, "CustomerCustomerDemos", resetFKFields, new int[] { (int)CustomerCustomerDemoFieldIndex.CustomerTypeId } );		
			_customerDemographic = null;
		}
		
		/// <summary> setups the sync logic for member _customerDemographic</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCustomerDemographic(IEntityCore relatedEntity)
		{
			if(_customerDemographic!=relatedEntity)
			{		
				DesetupSyncCustomerDemographic(true, true);
				_customerDemographic = (CustomerDemographicEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _customerDemographic, new PropertyChangedEventHandler( OnCustomerDemographicPropertyChanged ), "CustomerDemographic", Northwind.SSDAL.RelationClasses.StaticCustomerCustomerDemoRelations.CustomerDemographicEntityUsingCustomerTypeIdStatic, true, ref _alreadyFetchedCustomerDemographic, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCustomerDemographicPropertyChanged( object sender, PropertyChangedEventArgs e )
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
		public static IPrefetchPathElement PrefetchPathCustomer
		{
			get	{ return new PrefetchPathElement(new Northwind.SSDAL.CollectionClasses.CustomerCollection(), (IEntityRelation)GetRelationsForField("Customer")[0], (int)Northwind.SSDAL.EntityType.CustomerCustomerDemoEntity, (int)Northwind.SSDAL.EntityType.CustomerEntity, 0, null, null, null, "Customer", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CustomerDemographic'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerDemographic
		{
			get	{ return new PrefetchPathElement(new Northwind.SSDAL.CollectionClasses.CustomerDemographicCollection(), (IEntityRelation)GetRelationsForField("CustomerDemographic")[0], (int)Northwind.SSDAL.EntityType.CustomerCustomerDemoEntity, (int)Northwind.SSDAL.EntityType.CustomerDemographicEntity, 0, null, null, null, "CustomerDemographic", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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
					SetSingleRelatedEntityNavigator(value, "CustomerCustomerDemos", "Customer", _customer, true); 
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

		/// <summary> Gets / sets related entity of type 'CustomerDemographicEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCustomerDemographic()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CustomerDemographicEntity CustomerDemographic
		{
			get	{ return GetSingleCustomerDemographic(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncCustomerDemographic(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "CustomerCustomerDemos", "CustomerDemographic", _customerDemographic, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerDemographic. When set to true, CustomerDemographic is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerDemographic is accessed. You can always execute a forced fetch by calling GetSingleCustomerDemographic(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerDemographic
		{
			get	{ return _alwaysFetchCustomerDemographic; }
			set	{ _alwaysFetchCustomerDemographic = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerDemographic already has been fetched. Setting this property to false when CustomerDemographic has been fetched
		/// will set CustomerDemographic to null as well. Setting this property to true while CustomerDemographic hasn't been fetched disables lazy loading for CustomerDemographic</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerDemographic
		{
			get { return _alreadyFetchedCustomerDemographic;}
			set 
			{
				if(_alreadyFetchedCustomerDemographic && !value)
				{
					this.CustomerDemographic = null;
				}
				_alreadyFetchedCustomerDemographic = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property CustomerDemographic is not found
		/// in the database. When set to true, CustomerDemographic will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool CustomerDemographicReturnsNewIfNotFound
		{
			get	{ return _customerDemographicReturnsNewIfNotFound; }
			set { _customerDemographicReturnsNewIfNotFound = value; }	
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
			get { return (int)Northwind.SSDAL.EntityType.CustomerCustomerDemoEntity; }
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
