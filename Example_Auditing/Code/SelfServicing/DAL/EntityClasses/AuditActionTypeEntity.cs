﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: Tuesday, 1 February 2022 16:05:06
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
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
	/// <summary>Entity class which represents the entity 'AuditActionType'. <br/><br/></summary>
	[Serializable]
	public partial class AuditActionTypeEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditInfoCollection	_auditInfo;
		private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.UserCollection _userCollectionViaAuditInfo;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static AuditActionTypeEntityStaticMetaData _staticMetaData = new AuditActionTypeEntityStaticMetaData();
		private static AuditActionTypeRelations _relationsFactory = new AuditActionTypeRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name AuditInfo</summary>
			public static readonly string AuditInfo = "AuditInfo";
			/// <summary>Member name UserCollectionViaAuditInfo</summary>
			public static readonly string UserCollectionViaAuditInfo = "UserCollectionViaAuditInfo";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class AuditActionTypeEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public AuditActionTypeEntityStaticMetaData()
			{
				SetEntityCoreInfo("AuditActionTypeEntity", InheritanceHierarchyType.None, false, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.AuditActionTypeEntity, typeof(AuditActionTypeEntity), typeof(AuditActionTypeEntityFactory), false);
				AddNavigatorMetaData<AuditActionTypeEntity, SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditInfoCollection>("AuditInfo", a => a._auditInfo, (a, b) => a._auditInfo = b, a => a.AuditInfo, () => new AuditActionTypeRelations().AuditInfoEntityUsingAuditActionTypeId, typeof(AuditInfoEntity), (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.AuditInfoEntity);
				AddNavigatorMetaData<AuditActionTypeEntity, SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.UserCollection>("UserCollectionViaAuditInfo", a => a._userCollectionViaAuditInfo, (a, b) => a._userCollectionViaAuditInfo = b, a => a.UserCollectionViaAuditInfo, () => new AuditActionTypeRelations().AuditInfoEntityUsingAuditActionTypeId, () => new AuditInfoRelations().UserEntityUsingUserId, "AuditActionTypeEntity__", "AuditInfo_", typeof(UserEntity), (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.UserEntity);
			}
		}
		
		/// <summary>Static ctor</summary>
		static AuditActionTypeEntity()
		{
		}

		/// <summary>CTor</summary>
		public AuditActionTypeEntity() :base()
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="auditActionTypeId">PK value for AuditActionType which data should be fetched into this AuditActionType object</param>
		public AuditActionTypeEntity(System.Int32 auditActionTypeId)
		{
			InitClassFetch(auditActionTypeId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="auditActionTypeId">PK value for AuditActionType which data should be fetched into this AuditActionType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public AuditActionTypeEntity(System.Int32 auditActionTypeId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(auditActionTypeId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="auditActionTypeId">PK value for AuditActionType which data should be fetched into this AuditActionType object</param>
		/// <param name="validator">The custom validator object for this AuditActionTypeEntity</param>
		public AuditActionTypeEntity(System.Int32 auditActionTypeId, IValidator validator)
		{
			InitClassFetch(auditActionTypeId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AuditActionTypeEntity(SerializationInfo info, StreamingContext context):base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}



		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="auditActionTypeId">PK value for AuditActionType which data should be fetched into this AuditActionType object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 auditActionTypeId)
		{
			return FetchUsingPK(auditActionTypeId, null, null, null);
		}

		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="auditActionTypeId">PK value for AuditActionType which data should be fetched into this AuditActionType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 auditActionTypeId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(auditActionTypeId, prefetchPathToUse, null, null);
		}

		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="auditActionTypeId">PK value for AuditActionType which data should be fetched into this AuditActionType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 auditActionTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(auditActionTypeId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
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

		/// <inheritdoc/>
		public override bool Refetch()
		{
			return Fetch(this.AuditActionTypeId, null, null, null);
		}

		/// <summary>Retrieves all related entities of type 'AuditInfoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AuditInfoEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditInfoCollection GetMultiAuditInfo(bool forceFetch)
		{
			return GetMultiAuditInfo(forceFetch, _auditInfo.EntityFactoryToUse, null);
		}

		/// <summary>Retrieves all related entities of type 'AuditInfoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'AuditInfoEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditInfoCollection GetMultiAuditInfo(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiAuditInfo(forceFetch, _auditInfo.EntityFactoryToUse, filter);
		}

		/// <summary>Retrieves all related entities of type 'AuditInfoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditInfoCollection GetMultiAuditInfo(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiAuditInfo(forceFetch, entityFactoryToUse, null);
		}

		/// <summary>Retrieves all related entities of type 'AuditInfoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditInfoCollection GetMultiAuditInfo(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
			return PerformMultiEntityLazyLoading<SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditInfoCollection>("AuditInfo", forceFetch, entityFactoryToUse, (c,r)=>c.GetMultiManyToOne(this, null, filter));
		}

		/// <summary>Sets the collection parameters for the collection for 'AuditInfo'. These settings will be taken into account
		/// when the property AuditInfo is requested or GetMultiAuditInfo is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAuditInfo(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_auditInfo.SortClauses=sortClauses;
			_auditInfo.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary>Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UserEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.UserCollection GetMultiUserCollectionViaAuditInfo(bool forceFetch)
		{
			return GetMultiUserCollectionViaAuditInfo(forceFetch, _userCollectionViaAuditInfo.EntityFactoryToUse);
		}

		/// <summary>Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.UserCollection GetMultiUserCollectionViaAuditInfo(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			var filter = new PredicateExpression();
			filter.Add(new FieldCompareValuePredicate(AuditActionTypeFields.AuditActionTypeId, ComparisonOperator.Equal, this.AuditActionTypeId, "AuditActionTypeEntity__"));
			return PerformMultiEntityLazyLoading<SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.UserCollection>("UserCollectionViaAuditInfo", forceFetch, entityFactoryToUse, (c,r)=>c.GetMulti(filter, r));
		}

		/// <summary>Sets the collection parameters for the collection for 'UserCollectionViaAuditInfo'. These settings will be taken into account
		/// when the property UserCollectionViaAuditInfo is requested or GetMultiUserCollectionViaAuditInfo is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUserCollectionViaAuditInfo(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_userCollectionViaAuditInfo.SortClauses=sortClauses;
			_userCollectionViaAuditInfo.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
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

		/// <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
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

		/// <summary>Initializes the class members</summary>
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


		/// <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
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

		/// <summary>Creates the DAO instance for this type</summary>
		/// <returns></returns>
		protected override IDao CreateDAOInstance() { return DAOFactory.CreateAuditActionTypeDAO(); }
		
		/// <summary>Gets the entity static meta data instance from the generated type.</summary>
		/// <returns>The instance requested</returns>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() { return _staticMetaData; }
		
		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static AuditActionTypeRelations Relations { get { return _relationsFactory; } }


		/// <summary>Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AuditInfo' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAuditInfo { get { return _staticMetaData.GetPrefetchPathElement("AuditInfo", new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditInfoCollection()); } }

		/// <summary>Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserCollectionViaAuditInfo { get { return _staticMetaData.GetPrefetchPathElement("UserCollectionViaAuditInfo", new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.UserCollection()); } }


		/// <summary>The AuditActionTypeId property of the Entity AuditActionType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditActionType"."AuditActionTypeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 AuditActionTypeId
		{
			get { return (System.Int32)GetValue((int)AuditActionTypeFieldIndex.AuditActionTypeId, true); }
			set	{ SetValue((int)AuditActionTypeFieldIndex.AuditActionTypeId, value, true); }
		}

		/// <summary>The Name property of the Entity AuditActionType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditActionType"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)AuditActionTypeFieldIndex.Name, true); }
			set	{ SetValue((int)AuditActionTypeFieldIndex.Name, value, true); }
		}

		/// <summary>Retrieves all related entities of type 'AuditInfoEntity' using a relation of type '1:n'.<br/><br/></summary>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditInfoCollection AuditInfo { get { return GetMultiAuditInfo(false); } }

		/// <summary>Gets / sets the lazy loading flag for AuditInfo. When set to true, AuditInfo is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AuditInfo is accessed. You can always execute/ a forced fetch by calling GetMultiAuditInfo(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAuditInfo
		{
			get	{ return GetAlwaysFetchValueForNavigator("AuditInfo"); }
			set	{ SetAlwaysFetchValueForNavigator("AuditInfo", value); }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property AuditInfo already has been fetched. Setting this property to false when AuditInfo has been fetched
		/// will clear the AuditInfo collection well. Setting this property to true while AuditInfo hasn't been fetched disables lazy loading for AuditInfo</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAuditInfo
		{
			get { return GetAlreadyFetchedValueForNavigator("AuditInfo");}
			set { SetAlreadyFetchedValueForNavigator("AuditInfo", value, true);}
		}

		/// <summary>Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.<br/><br/></summary>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.UserCollection UserCollectionViaAuditInfo { get { return GetMultiUserCollectionViaAuditInfo(false); } }

		/// <summary>Gets / sets the lazy loading flag for UserCollectionViaAuditInfo. When set to true, UserCollectionViaAuditInfo is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UserCollectionViaAuditInfo is accessed. You can always execute a forced fetch by calling GetMultiUserCollectionViaAuditInfo(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUserCollectionViaAuditInfo
		{
			get	{ return GetAlwaysFetchValueForNavigator("UserCollectionViaAuditInfo"); }
			set	{ SetAlwaysFetchValueForNavigator("UserCollectionViaAuditInfo", value); }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UserCollectionViaAuditInfo already has been fetched. Setting this property to false when UserCollectionViaAuditInfo has been fetched
		/// will clear the UserCollectionViaAuditInfo collection well. Setting this property to true while UserCollectionViaAuditInfo hasn't been fetched disables lazy loading for UserCollectionViaAuditInfo</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUserCollectionViaAuditInfo
		{
			get { return GetAlreadyFetchedValueForNavigator("UserCollectionViaAuditInfo");}
			set { SetAlreadyFetchedValueForNavigator("UserCollectionViaAuditInfo", value, true);}
		}



		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace SD.LLBLGen.Pro.Examples.Auditing
{
	public enum AuditActionTypeFieldIndex
	{
		///<summary>AuditActionTypeId. </summary>
		AuditActionTypeId,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace SD.LLBLGen.Pro.Examples.Auditing.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: AuditActionType. </summary>
	public partial class AuditActionTypeRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between AuditActionTypeEntity and AuditInfoEntity over the 1:n relation they have, using the relation between the fields: AuditActionType.AuditActionTypeId - AuditInfo.AuditActionTypeId</summary>
		public virtual IEntityRelation AuditInfoEntityUsingAuditActionTypeId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "AuditInfo", true, new[] { AuditActionTypeFields.AuditActionTypeId, AuditInfoFields.AuditActionTypeId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticAuditActionTypeRelations
	{
		internal static readonly IEntityRelation AuditInfoEntityUsingAuditActionTypeIdStatic = new AuditActionTypeRelations().AuditInfoEntityUsingAuditActionTypeId;

		/// <summary>CTor</summary>
		static StaticAuditActionTypeRelations() { }
	}
}
