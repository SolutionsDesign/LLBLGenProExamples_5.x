﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
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
	/// <summary>Entity class which represents the entity 'User'. <br/><br/></summary>
	[Serializable]
	public partial class UserEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private Northwind.SSDAL.CollectionClasses.AuditInfoCollection	_auditInfos;
		private Northwind.SSDAL.CollectionClasses.UserGroupCollection	_userGroups;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static UserEntityStaticMetaData _staticMetaData = new UserEntityStaticMetaData();
		private static UserRelations _relationsFactory = new UserRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name AuditInfos</summary>
			public static readonly string AuditInfos = "AuditInfos";
			/// <summary>Member name UserGroups</summary>
			public static readonly string UserGroups = "UserGroups";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class UserEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public UserEntityStaticMetaData()
			{
				SetEntityCoreInfo("UserEntity", InheritanceHierarchyType.None, false, (int)Northwind.SSDAL.EntityType.UserEntity, typeof(UserEntity), typeof(UserEntityFactory), false);
				AddNavigatorMetaData<UserEntity, Northwind.SSDAL.CollectionClasses.AuditInfoCollection>("AuditInfos", a => a._auditInfos, (a, b) => a._auditInfos = b, a => a.AuditInfos, () => new UserRelations().AuditInfoEntityUsingUserId, typeof(AuditInfoEntity), (int)Northwind.SSDAL.EntityType.AuditInfoEntity);
				AddNavigatorMetaData<UserEntity, Northwind.SSDAL.CollectionClasses.UserGroupCollection>("UserGroups", a => a._userGroups, (a, b) => a._userGroups = b, a => a.UserGroups, () => new UserRelations().UserGroupEntityUsingUserId, typeof(UserGroupEntity), (int)Northwind.SSDAL.EntityType.UserGroupEntity);
			}
		}
		
		/// <summary>Static ctor</summary>
		static UserEntity()
		{
		}

		/// <summary>CTor</summary>
		public UserEntity() :base()
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="userId">PK value for User which data should be fetched into this User object</param>
		public UserEntity(System.String userId)
		{
			InitClassFetch(userId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="userId">PK value for User which data should be fetched into this User object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public UserEntity(System.String userId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(userId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="userId">PK value for User which data should be fetched into this User object</param>
		/// <param name="validator">The custom validator object for this UserEntity</param>
		public UserEntity(System.String userId, IValidator validator)
		{
			InitClassFetch(userId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected UserEntity(SerializationInfo info, StreamingContext context):base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}



		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="userId">PK value for User which data should be fetched into this User object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String userId)
		{
			return FetchUsingPK(userId, null, null, null);
		}

		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="userId">PK value for User which data should be fetched into this User object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String userId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(userId, prefetchPathToUse, null, null);
		}

		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="userId">PK value for User which data should be fetched into this User object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String userId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(userId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="userId">PK value for User which data should be fetched into this User object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String userId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(userId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <inheritdoc/>
		public override bool Refetch()
		{
			return Fetch(this.UserId, null, null, null);
		}

		/// <summary>Retrieves all related entities of type 'AuditInfoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AuditInfoEntity'</returns>
		public Northwind.SSDAL.CollectionClasses.AuditInfoCollection GetMultiAuditInfos(bool forceFetch)
		{
			return GetMultiAuditInfos(forceFetch, _auditInfos.EntityFactoryToUse, null);
		}

		/// <summary>Retrieves all related entities of type 'AuditInfoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'AuditInfoEntity'</returns>
		public Northwind.SSDAL.CollectionClasses.AuditInfoCollection GetMultiAuditInfos(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiAuditInfos(forceFetch, _auditInfos.EntityFactoryToUse, filter);
		}

		/// <summary>Retrieves all related entities of type 'AuditInfoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Northwind.SSDAL.CollectionClasses.AuditInfoCollection GetMultiAuditInfos(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiAuditInfos(forceFetch, entityFactoryToUse, null);
		}

		/// <summary>Retrieves all related entities of type 'AuditInfoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Northwind.SSDAL.CollectionClasses.AuditInfoCollection GetMultiAuditInfos(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
			return PerformMultiEntityLazyLoading<Northwind.SSDAL.CollectionClasses.AuditInfoCollection>("AuditInfos", forceFetch, entityFactoryToUse, (c,r)=>c.GetMultiManyToOne(null, this, filter));
		}

		/// <summary>Sets the collection parameters for the collection for 'AuditInfos'. These settings will be taken into account
		/// when the property AuditInfos is requested or GetMultiAuditInfos is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAuditInfos(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_auditInfos.SortClauses=sortClauses;
			_auditInfos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary>Retrieves all related entities of type 'UserGroupEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UserGroupEntity'</returns>
		public Northwind.SSDAL.CollectionClasses.UserGroupCollection GetMultiUserGroups(bool forceFetch)
		{
			return GetMultiUserGroups(forceFetch, _userGroups.EntityFactoryToUse, null);
		}

		/// <summary>Retrieves all related entities of type 'UserGroupEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'UserGroupEntity'</returns>
		public Northwind.SSDAL.CollectionClasses.UserGroupCollection GetMultiUserGroups(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiUserGroups(forceFetch, _userGroups.EntityFactoryToUse, filter);
		}

		/// <summary>Retrieves all related entities of type 'UserGroupEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Northwind.SSDAL.CollectionClasses.UserGroupCollection GetMultiUserGroups(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiUserGroups(forceFetch, entityFactoryToUse, null);
		}

		/// <summary>Retrieves all related entities of type 'UserGroupEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Northwind.SSDAL.CollectionClasses.UserGroupCollection GetMultiUserGroups(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
			return PerformMultiEntityLazyLoading<Northwind.SSDAL.CollectionClasses.UserGroupCollection>("UserGroups", forceFetch, entityFactoryToUse, (c,r)=>c.GetMultiManyToOne(null, this, filter));
		}

		/// <summary>Sets the collection parameters for the collection for 'UserGroups'. These settings will be taken into account
		/// when the property UserGroups is requested or GetMultiUserGroups is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUserGroups(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_userGroups.SortClauses=sortClauses;
			_userGroups.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
		/// <param name="userId">PK value for User which data should be fetched into this User object</param>
		/// <param name="validator">The validator object for this UserEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.String userId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(userId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			_auditInfos = new Northwind.SSDAL.CollectionClasses.AuditInfoCollection();
			_auditInfos.SetContainingEntityInfo(this, "User");

			_userGroups = new Northwind.SSDAL.CollectionClasses.UserGroupCollection();
			_userGroups.SetContainingEntityInfo(this, "User");
			PerformDependencyInjection();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}


		/// <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="userId">PK value for User which data should be fetched into this User object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.String userId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)UserFieldIndex.UserId].ForcedCurrentValueWrite(userId);
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
		protected override IDao CreateDAOInstance() { return DAOFactory.CreateUserDAO(); }
		
		/// <summary>Gets the entity static meta data instance from the generated type.</summary>
		/// <returns>The instance requested</returns>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() { return _staticMetaData; }
		
		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static UserRelations Relations { get { return _relationsFactory; } }


		/// <summary>Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AuditInfo' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAuditInfos { get { return _staticMetaData.GetPrefetchPathElement("AuditInfos", new Northwind.SSDAL.CollectionClasses.AuditInfoCollection()); } }

		/// <summary>Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UserGroup' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserGroups { get { return _staticMetaData.GetPrefetchPathElement("UserGroups", new Northwind.SSDAL.CollectionClasses.UserGroupCollection()); } }


		/// <summary>The FullName property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."FullName"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 150<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String FullName
		{
			get { return (System.String)GetValue((int)UserFieldIndex.FullName, true); }
			set	{ SetValue((int)UserFieldIndex.FullName, value, true); }
		}

		/// <summary>The Password property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."Password"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Password
		{
			get { return (System.String)GetValue((int)UserFieldIndex.Password, true); }
			set	{ SetValue((int)UserFieldIndex.Password, value, true); }
		}

		/// <summary>The UserId property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."UserID"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String UserId
		{
			get { return (System.String)GetValue((int)UserFieldIndex.UserId, true); }
			set	{ SetValue((int)UserFieldIndex.UserId, value, true); }
		}

		/// <summary>Retrieves all related entities of type 'AuditInfoEntity' using a relation of type '1:n'.<br/><br/></summary>
		public virtual Northwind.SSDAL.CollectionClasses.AuditInfoCollection AuditInfos { get { return GetMultiAuditInfos(false); } }

		/// <summary>Gets / sets the lazy loading flag for AuditInfos. When set to true, AuditInfos is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AuditInfos is accessed. You can always execute/ a forced fetch by calling GetMultiAuditInfos(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAuditInfos
		{
			get	{ return GetAlwaysFetchValueForNavigator("AuditInfos"); }
			set	{ SetAlwaysFetchValueForNavigator("AuditInfos", value); }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property AuditInfos already has been fetched. Setting this property to false when AuditInfos has been fetched
		/// will clear the AuditInfos collection well. Setting this property to true while AuditInfos hasn't been fetched disables lazy loading for AuditInfos</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAuditInfos
		{
			get { return GetAlreadyFetchedValueForNavigator("AuditInfos");}
			set { SetAlreadyFetchedValueForNavigator("AuditInfos", value, true);}
		}
		/// <summary>Retrieves all related entities of type 'UserGroupEntity' using a relation of type '1:n'.<br/><br/></summary>
		public virtual Northwind.SSDAL.CollectionClasses.UserGroupCollection UserGroups { get { return GetMultiUserGroups(false); } }

		/// <summary>Gets / sets the lazy loading flag for UserGroups. When set to true, UserGroups is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UserGroups is accessed. You can always execute/ a forced fetch by calling GetMultiUserGroups(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUserGroups
		{
			get	{ return GetAlwaysFetchValueForNavigator("UserGroups"); }
			set	{ SetAlwaysFetchValueForNavigator("UserGroups", value); }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property UserGroups already has been fetched. Setting this property to false when UserGroups has been fetched
		/// will clear the UserGroups collection well. Setting this property to true while UserGroups hasn't been fetched disables lazy loading for UserGroups</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUserGroups
		{
			get { return GetAlreadyFetchedValueForNavigator("UserGroups");}
			set { SetAlreadyFetchedValueForNavigator("UserGroups", value, true);}
		}



		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace Northwind.SSDAL
{
	public enum UserFieldIndex
	{
		///<summary>FullName. </summary>
		FullName,
		///<summary>Password. </summary>
		Password,
		///<summary>UserId. </summary>
		UserId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace Northwind.SSDAL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: User. </summary>
	public partial class UserRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between UserEntity and AuditInfoEntity over the 1:n relation they have, using the relation between the fields: User.UserId - AuditInfo.UserId</summary>
		public virtual IEntityRelation AuditInfoEntityUsingUserId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "AuditInfos", true, new[] { UserFields.UserId, AuditInfoFields.UserId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between UserEntity and UserGroupEntity over the 1:n relation they have, using the relation between the fields: User.UserId - UserGroup.UserId</summary>
		public virtual IEntityRelation UserGroupEntityUsingUserId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "UserGroups", true, new[] { UserFields.UserId, UserGroupFields.UserId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticUserRelations
	{
		internal static readonly IEntityRelation AuditInfoEntityUsingUserIdStatic = new UserRelations().AuditInfoEntityUsingUserId;
		internal static readonly IEntityRelation UserGroupEntityUsingUserIdStatic = new UserRelations().UserGroupEntityUsingUserId;

		/// <summary>CTor</summary>
		static StaticUserRelations() { }
	}
}
