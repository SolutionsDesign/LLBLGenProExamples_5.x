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
	/// <summary>Entity class which represents the entity 'Group'. <br/><br/></summary>
	[Serializable]
	public partial class GroupEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private Northwind.SSDAL.CollectionClasses.UserGroupCollection	_userGroups;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static GroupEntityStaticMetaData _staticMetaData = new GroupEntityStaticMetaData();
		private static GroupRelations _relationsFactory = new GroupRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name UserGroups</summary>
			public static readonly string UserGroups = "UserGroups";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class GroupEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public GroupEntityStaticMetaData()
			{
				SetEntityCoreInfo("GroupEntity", InheritanceHierarchyType.None, false, (int)Northwind.SSDAL.EntityType.GroupEntity, typeof(GroupEntity), typeof(GroupEntityFactory), false);
				AddNavigatorMetaData<GroupEntity, Northwind.SSDAL.CollectionClasses.UserGroupCollection>("UserGroups", a => a._userGroups, (a, b) => a._userGroups = b, a => a.UserGroups, () => new GroupRelations().UserGroupEntityUsingGroupId, typeof(UserGroupEntity), (int)Northwind.SSDAL.EntityType.UserGroupEntity);
			}
		}
		
		/// <summary>Static ctor</summary>
		static GroupEntity()
		{
		}

		/// <summary>CTor</summary>
		public GroupEntity() :base()
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="id">PK value for Group which data should be fetched into this Group object</param>
		public GroupEntity(System.Int32 id)
		{
			InitClassFetch(id, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Group which data should be fetched into this Group object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public GroupEntity(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(id, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Group which data should be fetched into this Group object</param>
		/// <param name="validator">The custom validator object for this GroupEntity</param>
		public GroupEntity(System.Int32 id, IValidator validator)
		{
			InitClassFetch(id, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected GroupEntity(SerializationInfo info, StreamingContext context):base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}



		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Group which data should be fetched into this Group object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id)
		{
			return FetchUsingPK(id, null, null, null);
		}

		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Group which data should be fetched into this Group object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, null, null);
		}

		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Group which data should be fetched into this Group object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, contextToUse, null);
		}

		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Group which data should be fetched into this Group object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(id, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <inheritdoc/>
		public override bool Refetch()
		{
			return Fetch(this.Id, null, null, null);
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
			return PerformMultiEntityLazyLoading<Northwind.SSDAL.CollectionClasses.UserGroupCollection>("UserGroups", forceFetch, entityFactoryToUse, (c,r)=>c.GetMultiManyToOne(this, null, filter));
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
		/// <param name="id">PK value for Group which data should be fetched into this Group object</param>
		/// <param name="validator">The validator object for this GroupEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 id, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(id, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			_userGroups = new Northwind.SSDAL.CollectionClasses.UserGroupCollection();
			_userGroups.SetContainingEntityInfo(this, "Group");
			PerformDependencyInjection();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}


		/// <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="id">PK value for Group which data should be fetched into this Group object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)GroupFieldIndex.Id].ForcedCurrentValueWrite(id);
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
		protected override IDao CreateDAOInstance() { return DAOFactory.CreateGroupDAO(); }
		
		/// <summary>Gets the entity static meta data instance from the generated type.</summary>
		/// <returns>The instance requested</returns>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() { return _staticMetaData; }
		
		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static GroupRelations Relations { get { return _relationsFactory; } }


		/// <summary>Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UserGroup' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserGroups { get { return _staticMetaData.GetPrefetchPathElement("UserGroups", new Northwind.SSDAL.CollectionClasses.UserGroupCollection()); } }


		/// <summary>The Id property of the Entity Group<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Group"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)GroupFieldIndex.Id, true); }
			set	{ SetValue((int)GroupFieldIndex.Id, value, true); }
		}

		/// <summary>The Name property of the Entity Group<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Group"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)GroupFieldIndex.Name, true); }
			set	{ SetValue((int)GroupFieldIndex.Name, value, true); }
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
	public enum GroupFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace Northwind.SSDAL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Group. </summary>
	public partial class GroupRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between GroupEntity and UserGroupEntity over the 1:n relation they have, using the relation between the fields: Group.Id - UserGroup.GroupId</summary>
		public virtual IEntityRelation UserGroupEntityUsingGroupId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "UserGroups", true, new[] { GroupFields.Id, UserGroupFields.GroupId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticGroupRelations
	{
		internal static readonly IEntityRelation UserGroupEntityUsingGroupIdStatic = new GroupRelations().UserGroupEntityUsingGroupId;

		/// <summary>CTor</summary>
		static StaticGroupRelations() { }
	}
}
