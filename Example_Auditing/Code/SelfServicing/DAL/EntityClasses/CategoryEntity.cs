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

	/// <summary>Entity class which represents the entity 'Category'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class CategoryEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ProductCollection	_products;
		private bool	_alwaysFetchProducts, _alreadyFetchedProducts;
		private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.SupplierCollection _suppliersCollectionViaProducts;
		private bool	_alwaysFetchSuppliersCollectionViaProducts, _alreadyFetchedSuppliersCollectionViaProducts;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Products</summary>
			public static readonly string Products = "Products";
			/// <summary>Member name SuppliersCollectionViaProducts</summary>
			public static readonly string SuppliersCollectionViaProducts = "SuppliersCollectionViaProducts";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CategoryEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public CategoryEntity() :base("CategoryEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="categoryId">PK value for Category which data should be fetched into this Category object</param>
		public CategoryEntity(System.Int32 categoryId):base("CategoryEntity")
		{
			InitClassFetch(categoryId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="categoryId">PK value for Category which data should be fetched into this Category object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CategoryEntity(System.Int32 categoryId, IPrefetchPath prefetchPathToUse):base("CategoryEntity")
		{
			InitClassFetch(categoryId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="categoryId">PK value for Category which data should be fetched into this Category object</param>
		/// <param name="validator">The custom validator object for this CategoryEntity</param>
		public CategoryEntity(System.Int32 categoryId, IValidator validator):base("CategoryEntity")
		{
			InitClassFetch(categoryId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CategoryEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_products = (SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ProductCollection)info.GetValue("_products", typeof(SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ProductCollection));
			_alwaysFetchProducts = info.GetBoolean("_alwaysFetchProducts");
			_alreadyFetchedProducts = info.GetBoolean("_alreadyFetchedProducts");
			_suppliersCollectionViaProducts = (SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.SupplierCollection)info.GetValue("_suppliersCollectionViaProducts", typeof(SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.SupplierCollection));
			_alwaysFetchSuppliersCollectionViaProducts = info.GetBoolean("_alwaysFetchSuppliersCollectionViaProducts");
			_alreadyFetchedSuppliersCollectionViaProducts = info.GetBoolean("_alreadyFetchedSuppliersCollectionViaProducts");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedProducts = (_products.Count > 0);
			_alreadyFetchedSuppliersCollectionViaProducts = (_suppliersCollectionViaProducts.Count > 0);
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
				case "Products":
					toReturn.Add(Relations.ProductEntityUsingCategoryId);
					break;
				case "SuppliersCollectionViaProducts":
					toReturn.Add(Relations.ProductEntityUsingCategoryId, "CategoryEntity__", "Product_", JoinHint.None);
					toReturn.Add(ProductEntity.Relations.SupplierEntityUsingSupplierId, "Product_", string.Empty, JoinHint.None);
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
			info.AddValue("_products", (!this.MarkedForDeletion?_products:null));
			info.AddValue("_alwaysFetchProducts", _alwaysFetchProducts);
			info.AddValue("_alreadyFetchedProducts", _alreadyFetchedProducts);
			info.AddValue("_suppliersCollectionViaProducts", (!this.MarkedForDeletion?_suppliersCollectionViaProducts:null));
			info.AddValue("_alwaysFetchSuppliersCollectionViaProducts", _alwaysFetchSuppliersCollectionViaProducts);
			info.AddValue("_alreadyFetchedSuppliersCollectionViaProducts", _alreadyFetchedSuppliersCollectionViaProducts);

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
				case "Products":
					_alreadyFetchedProducts = true;
					if(entity!=null)
					{
						this.Products.Add((ProductEntity)entity);
					}
					break;
				case "SuppliersCollectionViaProducts":
					_alreadyFetchedSuppliersCollectionViaProducts = true;
					if(entity!=null)
					{
						this.SuppliersCollectionViaProducts.Add((SupplierEntity)entity);
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
				case "Products":
					_products.Add((ProductEntity)relatedEntity);
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
				case "Products":
					this.PerformRelatedEntityRemoval(_products, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_products);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="categoryId">PK value for Category which data should be fetched into this Category object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 categoryId)
		{
			return FetchUsingPK(categoryId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="categoryId">PK value for Category which data should be fetched into this Category object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 categoryId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(categoryId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="categoryId">PK value for Category which data should be fetched into this Category object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 categoryId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(categoryId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="categoryId">PK value for Category which data should be fetched into this Category object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 categoryId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(categoryId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CategoryId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new CategoryRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ProductCollection GetMultiProducts(bool forceFetch)
		{
			return GetMultiProducts(forceFetch, _products.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ProductCollection GetMultiProducts(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProducts(forceFetch, _products.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ProductCollection GetMultiProducts(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProducts(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ProductCollection GetMultiProducts(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProducts || forceFetch || _alwaysFetchProducts) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_products);
				_products.SuppressClearInGetMulti=!forceFetch;
				_products.EntityFactoryToUse = entityFactoryToUse;
				_products.GetMultiManyToOne(this, null, filter);
				_products.SuppressClearInGetMulti=false;
				_alreadyFetchedProducts = true;
			}
			return _products;
		}

		/// <summary> Sets the collection parameters for the collection for 'Products'. These settings will be taken into account
		/// when the property Products is requested or GetMultiProducts is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProducts(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_products.SortClauses=sortClauses;
			_products.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SupplierEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SupplierEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.SupplierCollection GetMultiSuppliersCollectionViaProducts(bool forceFetch)
		{
			return GetMultiSuppliersCollectionViaProducts(forceFetch, _suppliersCollectionViaProducts.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'SupplierEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.SupplierCollection GetMultiSuppliersCollectionViaProducts(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSuppliersCollectionViaProducts || forceFetch || _alwaysFetchSuppliersCollectionViaProducts) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_suppliersCollectionViaProducts);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(CategoryFields.CategoryId, ComparisonOperator.Equal, this.CategoryId, "CategoryEntity__"));
				_suppliersCollectionViaProducts.SuppressClearInGetMulti=!forceFetch;
				_suppliersCollectionViaProducts.EntityFactoryToUse = entityFactoryToUse;
				_suppliersCollectionViaProducts.GetMulti(filter, GetRelationsForField("SuppliersCollectionViaProducts"));
				_suppliersCollectionViaProducts.SuppressClearInGetMulti=false;
				_alreadyFetchedSuppliersCollectionViaProducts = true;
			}
			return _suppliersCollectionViaProducts;
		}

		/// <summary> Sets the collection parameters for the collection for 'SuppliersCollectionViaProducts'. These settings will be taken into account
		/// when the property SuppliersCollectionViaProducts is requested or GetMultiSuppliersCollectionViaProducts is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSuppliersCollectionViaProducts(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_suppliersCollectionViaProducts.SortClauses=sortClauses;
			_suppliersCollectionViaProducts.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Products", _products);
			toReturn.Add("SuppliersCollectionViaProducts", _suppliersCollectionViaProducts);
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
		/// <param name="categoryId">PK value for Category which data should be fetched into this Category object</param>
		/// <param name="validator">The validator object for this CategoryEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 categoryId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(categoryId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_products = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ProductCollection();
			_products.SetContainingEntityInfo(this, "Categories");
			_suppliersCollectionViaProducts = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.SupplierCollection();
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
			_fieldsCustomProperties.Add("CategoryId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CategoryName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Picture", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="categoryId">PK value for Category which data should be fetched into this Category object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 categoryId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)CategoryFieldIndex.CategoryId].ForcedCurrentValueWrite(categoryId);
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
			return DAOFactory.CreateCategoryDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new CategoryEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static CategoryRelations Relations
		{
			get	{ return new CategoryRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProducts
		{
			get { return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ProductCollection(), (IEntityRelation)GetRelationsForField("Products")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.CategoryEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.ProductEntity, 0, null, null, null, "Products", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Supplier'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSuppliersCollectionViaProducts
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductEntityUsingCategoryId;
				intermediateRelation.SetAliases(string.Empty, "Product_");
				return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.SupplierCollection(), intermediateRelation,	(int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.CategoryEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.SupplierEntity, 0, null, null, GetRelationsForField("SuppliersCollectionViaProducts"), "SuppliersCollectionViaProducts", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
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

		/// <summary> The CategoryId property of the Entity Category<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Categories"."CategoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 CategoryId
		{
			get { return (System.Int32)GetValue((int)CategoryFieldIndex.CategoryId, true); }
			set	{ SetValue((int)CategoryFieldIndex.CategoryId, value, true); }
		}

		/// <summary> The CategoryName property of the Entity Category<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Categories"."CategoryName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CategoryName
		{
			get { return (System.String)GetValue((int)CategoryFieldIndex.CategoryName, true); }
			set	{ SetValue((int)CategoryFieldIndex.CategoryName, value, true); }
		}

		/// <summary> The Description property of the Entity Category<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Categories"."Description"<br/>
		/// Table field type characteristics (type, precision, scale, length): NText, 0, 0, 1073741823<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)CategoryFieldIndex.Description, true); }
			set	{ SetValue((int)CategoryFieldIndex.Description, value, true); }
		}

		/// <summary> The Picture property of the Entity Category<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Categories"."Picture"<br/>
		/// Table field type characteristics (type, precision, scale, length): Image, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Byte[] Picture
		{
			get { return (System.Byte[])GetValue((int)CategoryFieldIndex.Picture, true); }
			set	{ SetValue((int)CategoryFieldIndex.Picture, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProducts()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ProductCollection Products
		{
			get	{ return GetMultiProducts(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Products. When set to true, Products is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Products is accessed. You can always execute/ a forced fetch by calling GetMultiProducts(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProducts
		{
			get	{ return _alwaysFetchProducts; }
			set	{ _alwaysFetchProducts = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Products already has been fetched. Setting this property to false when Products has been fetched
		/// will clear the Products collection well. Setting this property to true while Products hasn't been fetched disables lazy loading for Products</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProducts
		{
			get { return _alreadyFetchedProducts;}
			set 
			{
				if(_alreadyFetchedProducts && !value && (_products != null))
				{
					_products.Clear();
				}
				_alreadyFetchedProducts = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'SupplierEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSuppliersCollectionViaProducts()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.SupplierCollection SuppliersCollectionViaProducts
		{
			get { return GetMultiSuppliersCollectionViaProducts(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SuppliersCollectionViaProducts. When set to true, SuppliersCollectionViaProducts is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SuppliersCollectionViaProducts is accessed. You can always execute a forced fetch by calling GetMultiSuppliersCollectionViaProducts(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSuppliersCollectionViaProducts
		{
			get	{ return _alwaysFetchSuppliersCollectionViaProducts; }
			set	{ _alwaysFetchSuppliersCollectionViaProducts = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property SuppliersCollectionViaProducts already has been fetched. Setting this property to false when SuppliersCollectionViaProducts has been fetched
		/// will clear the SuppliersCollectionViaProducts collection well. Setting this property to true while SuppliersCollectionViaProducts hasn't been fetched disables lazy loading for SuppliersCollectionViaProducts</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSuppliersCollectionViaProducts
		{
			get { return _alreadyFetchedSuppliersCollectionViaProducts;}
			set 
			{
				if(_alreadyFetchedSuppliersCollectionViaProducts && !value && (_suppliersCollectionViaProducts != null))
				{
					_suppliersCollectionViaProducts.Clear();
				}
				_alreadyFetchedSuppliersCollectionViaProducts = value;
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
			get { return (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.CategoryEntity; }
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
