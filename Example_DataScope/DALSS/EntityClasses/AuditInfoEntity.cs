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
	/// <summary>Entity class which represents the entity 'AuditInfo'. <br/><br/></summary>
	[Serializable]
	public partial class AuditInfoEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private AuditActionTypeEntity _auditActionType;
		private bool	_auditActionTypeReturnsNewIfNotFound;
		private UserEntity _user;
		private bool	_userReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static AuditInfoEntityStaticMetaData _staticMetaData = new AuditInfoEntityStaticMetaData();
		private static AuditInfoRelations _relationsFactory = new AuditInfoRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name AuditActionType</summary>
			public static readonly string AuditActionType = "AuditActionType";
			/// <summary>Member name User</summary>
			public static readonly string User = "User";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class AuditInfoEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public AuditInfoEntityStaticMetaData()
			{
				SetEntityCoreInfo("AuditInfoEntity", InheritanceHierarchyType.TargetPerEntity, false, (int)Northwind.SSDAL.EntityType.AuditInfoEntity, typeof(AuditInfoEntity), typeof(AuditInfoEntityFactory), false);
				AddNavigatorMetaData<AuditInfoEntity, AuditActionTypeEntity>("AuditActionType", "AuditInfos", (a, b) => a._auditActionType = b, a => a._auditActionType, (a, b) => a.AuditActionType = b, Northwind.SSDAL.RelationClasses.StaticAuditInfoRelations.AuditActionTypeEntityUsingAuditActionTypeIdStatic, ()=>new AuditInfoRelations().AuditActionTypeEntityUsingAuditActionTypeId, null, new int[] { (int)AuditInfoFieldIndex.AuditActionTypeId }, null, true, (int)Northwind.SSDAL.EntityType.AuditActionTypeEntity);
				AddNavigatorMetaData<AuditInfoEntity, UserEntity>("User", "AuditInfos", (a, b) => a._user = b, a => a._user, (a, b) => a.User = b, Northwind.SSDAL.RelationClasses.StaticAuditInfoRelations.UserEntityUsingUserIdStatic, ()=>new AuditInfoRelations().UserEntityUsingUserId, null, new int[] { (int)AuditInfoFieldIndex.UserId }, null, true, (int)Northwind.SSDAL.EntityType.UserEntity);
			}
		}
		
		/// <summary>Static ctor</summary>
		static AuditInfoEntity()
		{
		}

		/// <summary>CTor</summary>
		public AuditInfoEntity() :base()
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="auditInfoId">PK value for AuditInfo which data should be fetched into this AuditInfo object</param>
		public AuditInfoEntity(System.Int32 auditInfoId)
		{
			InitClassFetch(auditInfoId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="auditInfoId">PK value for AuditInfo which data should be fetched into this AuditInfo object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public AuditInfoEntity(System.Int32 auditInfoId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(auditInfoId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="auditInfoId">PK value for AuditInfo which data should be fetched into this AuditInfo object</param>
		/// <param name="validator">The custom validator object for this AuditInfoEntity</param>
		public AuditInfoEntity(System.Int32 auditInfoId, IValidator validator)
		{
			InitClassFetch(auditInfoId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AuditInfoEntity(SerializationInfo info, StreamingContext context):base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		/// <summary>Gets a predicateexpression which filters on this entity. Only useful in entity fetches.</summary>
		/// <param name="negate">Flag to produce a NOT filter, (true), or a normal filter (false). </param>
		/// <returns>ready to use predicateexpression</returns>
		public  static IPredicateExpression GetEntityTypeFilter(bool negate=false)
		{
			return ModelInfoProviderSingleton.GetInstance().GetEntityTypeFilter("AuditInfoEntity", negate);
		}

		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key specified in a polymorphic way, so the entity returned  could be of a subtype of the current entity or the current entity.</summary>
		/// <param name="transactionToUse">transaction to use during fetch</param>
		/// <param name="auditInfoId">PK value for AuditInfo which data should be fetched into this AuditInfo object</param>
		/// <param name="contextToUse">Context to use for fetch</param>
		/// <returns>Fetched entity of the type of this entity or a subtype, or an empty entity of that type if not found.</returns>
		public static  AuditInfoEntity FetchPolymorphic(ITransaction transactionToUse, System.Int32 auditInfoId, Context contextToUse)
		{
			return FetchPolymorphic(transactionToUse, auditInfoId, contextToUse, null);
		}
				
		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key specified in a polymorphic way, so the entity returned  could be of a subtype of the current entity or the current entity.</summary>
		/// <param name="transactionToUse">transaction to use during fetch</param>
		/// <param name="auditInfoId">PK value for AuditInfo which data should be fetched into this AuditInfo object</param>
		/// <param name="contextToUse">Context to use for fetch</param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>Fetched entity of the type of this entity or a subtype, or an empty entity of that type if not found.</returns>
		public static  AuditInfoEntity FetchPolymorphic(ITransaction transactionToUse, System.Int32 auditInfoId, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			IEntityFields fields = EntityFieldsFactory.CreateEntityFieldsObject(Northwind.SSDAL.EntityType.AuditInfoEntity);
			fields.ForcedValueWrite((int)AuditInfoFieldIndex.AuditInfoId, auditInfoId);
			return (AuditInfoEntity)new AuditInfoDAO().FetchExistingPolymorphic(transactionToUse, fields, contextToUse, excludedIncludedFields);
		}
		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="auditInfoId">PK value for AuditInfo which data should be fetched into this AuditInfo object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 auditInfoId)
		{
			return FetchUsingPK(auditInfoId, null, null, null);
		}

		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="auditInfoId">PK value for AuditInfo which data should be fetched into this AuditInfo object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 auditInfoId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(auditInfoId, prefetchPathToUse, null, null);
		}

		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="auditInfoId">PK value for AuditInfo which data should be fetched into this AuditInfo object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 auditInfoId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(auditInfoId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="auditInfoId">PK value for AuditInfo which data should be fetched into this AuditInfo object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 auditInfoId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(auditInfoId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <inheritdoc/>
		public override bool Refetch()
		{
			return Fetch(this.AuditInfoId, null, null, null);
		}

		/// <summary>Retrieves the related entity of type 'AuditActionTypeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'AuditActionTypeEntity' which is related to this entity.</returns>
		public virtual AuditActionTypeEntity GetSingleAuditActionType(bool forceFetch=false)
		{
			return PerformSingleEntityLazyLoading<AuditActionTypeEntity>("AuditActionType", forceFetch, _auditActionTypeReturnsNewIfNotFound, e=>e.FetchUsingPK(this.AuditActionTypeId));
		}

		/// <summary>Retrieves the related entity of type 'UserEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'UserEntity' which is related to this entity.</returns>
		public virtual UserEntity GetSingleUser(bool forceFetch=false)
		{
			return PerformSingleEntityLazyLoading<UserEntity>("User", forceFetch, _userReturnsNewIfNotFound, e=>e.FetchUsingPK(this.UserId));
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
		/// <param name="auditInfoId">PK value for AuditInfo which data should be fetched into this AuditInfo object</param>
		/// <param name="validator">The validator object for this AuditInfoEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 auditInfoId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(auditInfoId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{			_auditActionTypeReturnsNewIfNotFound = false;
			_userReturnsNewIfNotFound = false;
			PerformDependencyInjection();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}


		/// <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="auditInfoId">PK value for AuditInfo which data should be fetched into this AuditInfo object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 auditInfoId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)AuditInfoFieldIndex.AuditInfoId].ForcedCurrentValueWrite(auditInfoId);
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
		protected override IDao CreateDAOInstance() { return DAOFactory.CreateAuditInfoDAO(); }
		
		/// <summary>Gets the entity static meta data instance from the generated type.</summary>
		/// <returns>The instance requested</returns>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() { return _staticMetaData; }
		
		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static AuditInfoRelations Relations { get { return _relationsFactory; } }


		/// <summary>Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AuditActionType'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAuditActionType { get { return _staticMetaData.GetPrefetchPathElement("AuditActionType", new Northwind.SSDAL.CollectionClasses.AuditActionTypeCollection()); } }

		/// <summary>Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUser { get { return _staticMetaData.GetPrefetchPathElement("User", new Northwind.SSDAL.CollectionClasses.UserCollection()); } }


		/// <summary>The ActionData property of the Entity AuditInfo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditInfo"."ActionData"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ActionData
		{
			get { return (System.String)GetValue((int)AuditInfoFieldIndex.ActionData, true); }
			set	{ SetValue((int)AuditInfoFieldIndex.ActionData, value, true); }
		}

		/// <summary>The ActionDateTime property of the Entity AuditInfo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditInfo"."ActionDateTime"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ActionDateTime
		{
			get { return (System.DateTime)GetValue((int)AuditInfoFieldIndex.ActionDateTime, true); }
			set	{ SetValue((int)AuditInfoFieldIndex.ActionDateTime, value, true); }
		}

		/// <summary>The AffectedEntityName property of the Entity AuditInfo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditInfo"."AffectedEntityName"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String AffectedEntityName
		{
			get { return (System.String)GetValue((int)AuditInfoFieldIndex.AffectedEntityName, true); }
			set	{ SetValue((int)AuditInfoFieldIndex.AffectedEntityName, value, true); }
		}

		/// <summary>The AuditActionTypeId property of the Entity AuditInfo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditInfo"."AuditActionTypeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 AuditActionTypeId
		{
			get { return (System.Int32)GetValue((int)AuditInfoFieldIndex.AuditActionTypeId, true); }
			set	{ SetValue((int)AuditInfoFieldIndex.AuditActionTypeId, value, true); }
		}

		/// <summary>The AuditInfoId property of the Entity AuditInfo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditInfo"."AuditInfoID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 AuditInfoId
		{
			get { return (System.Int32)GetValue((int)AuditInfoFieldIndex.AuditInfoId, true); }
			set	{ SetValue((int)AuditInfoFieldIndex.AuditInfoId, value, true); }
		}

		/// <summary>The UserId property of the Entity AuditInfo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditInfo"."UserID"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String UserId
		{
			get { return (System.String)GetValue((int)AuditInfoFieldIndex.UserId, true); }
			set	{ SetValue((int)AuditInfoFieldIndex.UserId, value, true); }
		}


		/// <summary>Gets / sets related entity of type 'AuditActionTypeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/></summary>
		[Browsable(false)]
		public virtual AuditActionTypeEntity AuditActionType
		{
			get	{ return GetSingleAuditActionType(false); }
			set { SetSingleRelatedEntityNavigator(value, "AuditActionType"); }
		}

		/// <summary>Gets / sets the lazy loading flag for AuditActionType. When set to true, AuditActionType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AuditActionType is accessed. You can always execute a forced fetch by calling GetSingleAuditActionType(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAuditActionType
		{
			get	{ return GetAlwaysFetchValueForNavigator("AuditActionType"); }
			set	{ SetAlwaysFetchValueForNavigator("AuditActionType", value); }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AuditActionType already has been fetched. Setting this property to false when AuditActionType has been fetched
		/// will set AuditActionType to null as well. Setting this property to true while AuditActionType hasn't been fetched disables lazy loading for AuditActionType</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAuditActionType
		{
			get { return GetAlreadyFetchedValueForNavigator("AuditActionType");}
			set { SetAlreadyFetchedValueForNavigator("AuditActionType", value, true);}
		}

		/// <summary>Gets / sets the flag for what to do if the related entity available through the property AuditActionType is not found
		/// in the database. When set to true, AuditActionType will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool AuditActionTypeReturnsNewIfNotFound
		{
			get	{ return _auditActionTypeReturnsNewIfNotFound; }
			set { _auditActionTypeReturnsNewIfNotFound = value; }	
		}

		/// <summary>Gets / sets related entity of type 'UserEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/></summary>
		[Browsable(false)]
		public virtual UserEntity User
		{
			get	{ return GetSingleUser(false); }
			set { SetSingleRelatedEntityNavigator(value, "User"); }
		}

		/// <summary>Gets / sets the lazy loading flag for User. When set to true, User is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time User is accessed. You can always execute a forced fetch by calling GetSingleUser(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUser
		{
			get	{ return GetAlwaysFetchValueForNavigator("User"); }
			set	{ SetAlwaysFetchValueForNavigator("User", value); }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property User already has been fetched. Setting this property to false when User has been fetched
		/// will set User to null as well. Setting this property to true while User hasn't been fetched disables lazy loading for User</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUser
		{
			get { return GetAlreadyFetchedValueForNavigator("User");}
			set { SetAlreadyFetchedValueForNavigator("User", value, true);}
		}

		/// <summary>Gets / sets the flag for what to do if the related entity available through the property User is not found
		/// in the database. When set to true, User will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool UserReturnsNewIfNotFound
		{
			get	{ return _userReturnsNewIfNotFound; }
			set { _userReturnsNewIfNotFound = value; }	
		}



		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace Northwind.SSDAL
{
	public enum AuditInfoFieldIndex
	{
		///<summary>ActionData. </summary>
		ActionData,
		///<summary>ActionDateTime. </summary>
		ActionDateTime,
		///<summary>AffectedEntityName. </summary>
		AffectedEntityName,
		///<summary>AuditActionTypeId. </summary>
		AuditActionTypeId,
		///<summary>AuditInfoId. </summary>
		AuditInfoId,
		///<summary>UserId. </summary>
		UserId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace Northwind.SSDAL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: AuditInfo. </summary>
	public partial class AuditInfoRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between AuditInfoEntity and AuditActionTypeEntity over the m:1 relation they have, using the relation between the fields: AuditInfo.AuditActionTypeId - AuditActionType.AuditActionTypeId</summary>
		public virtual IEntityRelation AuditActionTypeEntityUsingAuditActionTypeId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "AuditActionType", false, new[] { AuditActionTypeFields.AuditActionTypeId, AuditInfoFields.AuditActionTypeId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between AuditInfoEntity and UserEntity over the m:1 relation they have, using the relation between the fields: AuditInfo.UserId - User.UserId</summary>
		public virtual IEntityRelation UserEntityUsingUserId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "User", false, new[] { UserFields.UserId, AuditInfoFields.UserId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between AuditInfoEntity and OrderAuditInfoEntity over the 1:1 relation they have, which is used to build a target per entity hierarchy</summary>		
		internal IEntityRelation RelationToSubTypeOrderAuditInfoEntity
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateHierarchyRelation(true, new[] { AuditInfoFields.AuditInfoId, OrderAuditInfoFields.AuditInfoId }); }
		}

		/// <inheritdoc/>
		public override IEntityRelation GetSubTypeRelation(string subTypeEntityName)
		{
			switch(subTypeEntityName)
			{
				case "OrderAuditInfoEntity":
					return this.RelationToSubTypeOrderAuditInfoEntity;
				default:
					return null;
			}
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticAuditInfoRelations
	{
		internal static readonly IEntityRelation AuditActionTypeEntityUsingAuditActionTypeIdStatic = new AuditInfoRelations().AuditActionTypeEntityUsingAuditActionTypeId;
		internal static readonly IEntityRelation UserEntityUsingUserIdStatic = new AuditInfoRelations().UserEntityUsingUserId;

		/// <summary>CTor</summary>
		static StaticAuditInfoRelations() { }
	}
}
