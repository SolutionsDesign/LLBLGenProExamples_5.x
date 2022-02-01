﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: Tuesday, 1 February 2022 16:15:36
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using SD.LLBLGen.Pro.Examples.Authorization.HelperClasses;
using SD.LLBLGen.Pro.Examples.Authorization.FactoryClasses;
using SD.LLBLGen.Pro.Examples.Authorization.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.Authorization.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'User'.<br/><br/></summary>
	[Serializable]
	public partial class UserEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<UserGroupEntity> _userGroup;
		private EntityCollection<GroupEntity> _groupCollectionViaUserGroup;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static UserEntityStaticMetaData _staticMetaData = new UserEntityStaticMetaData();
		private static UserRelations _relationsFactory = new UserRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name UserGroup</summary>
			public static readonly string UserGroup = "UserGroup";
			/// <summary>Member name GroupCollectionViaUserGroup</summary>
			public static readonly string GroupCollectionViaUserGroup = "GroupCollectionViaUserGroup";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class UserEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public UserEntityStaticMetaData()
			{
				SetEntityCoreInfo("UserEntity", InheritanceHierarchyType.None, false, (int)SD.LLBLGen.Pro.Examples.Authorization.EntityType.UserEntity, typeof(UserEntity), typeof(UserEntityFactory), false);
				AddNavigatorMetaData<UserEntity, EntityCollection<UserGroupEntity>>("UserGroup", a => a._userGroup, (a, b) => a._userGroup = b, a => a.UserGroup, () => new UserRelations().UserGroupEntityUsingUserId, typeof(UserGroupEntity), (int)SD.LLBLGen.Pro.Examples.Authorization.EntityType.UserGroupEntity);
				AddNavigatorMetaData<UserEntity, EntityCollection<GroupEntity>>("GroupCollectionViaUserGroup", a => a._groupCollectionViaUserGroup, (a, b) => a._groupCollectionViaUserGroup = b, a => a.GroupCollectionViaUserGroup, () => new UserRelations().UserGroupEntityUsingUserId, () => new UserGroupRelations().GroupEntityUsingGroupId, "UserEntity__", "UserGroup_", typeof(GroupEntity), (int)SD.LLBLGen.Pro.Examples.Authorization.EntityType.GroupEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static UserEntity()
		{
		}

		/// <summary> CTor</summary>
		public UserEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public UserEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this UserEntity</param>
		public UserEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="userId">PK value for User which data should be fetched into this User object</param>
		public UserEntity(System.String userId) : this(userId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="userId">PK value for User which data should be fetched into this User object</param>
		/// <param name="validator">The custom validator object for this UserEntity</param>
		public UserEntity(System.String userId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.UserId = userId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected UserEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'UserGroup' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserGroup() { return CreateRelationInfoForNavigator("UserGroup"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Group' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoGroupCollectionViaUserGroup() { return CreateRelationInfoForNavigator("GroupCollectionViaUserGroup"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this UserEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static UserRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UserGroup' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserGroup { get { return _staticMetaData.GetPrefetchPathElement("UserGroup", CommonEntityBase.CreateEntityCollection<UserGroupEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Group' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathGroupCollectionViaUserGroup { get { return _staticMetaData.GetPrefetchPathElement("GroupCollectionViaUserGroup", CommonEntityBase.CreateEntityCollection<GroupEntity>()); } }

		/// <summary>The FullName property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."FullName".<br/>Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 150.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String FullName
		{
			get { return (System.String)GetValue((int)UserFieldIndex.FullName, true); }
			set	{ SetValue((int)UserFieldIndex.FullName, value); }
		}

		/// <summary>The Password property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."Password".<br/>Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 15.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Password
		{
			get { return (System.String)GetValue((int)UserFieldIndex.Password, true); }
			set	{ SetValue((int)UserFieldIndex.Password, value); }
		}

		/// <summary>The UserId property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."UserID".<br/>Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 15.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String UserId
		{
			get { return (System.String)GetValue((int)UserFieldIndex.UserId, true); }
			set	{ SetValue((int)UserFieldIndex.UserId, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'UserGroupEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(UserGroupEntity))]
		public virtual EntityCollection<UserGroupEntity> UserGroup { get { return GetOrCreateEntityCollection<UserGroupEntity, UserGroupEntityFactory>("User", true, false, ref _userGroup); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'GroupEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(GroupEntity))]
		public virtual EntityCollection<GroupEntity> GroupCollectionViaUserGroup { get { return GetOrCreateEntityCollection<GroupEntity, GroupEntityFactory>("UserCollectionViaUserGroup", false, true, ref _groupCollectionViaUserGroup); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace SD.LLBLGen.Pro.Examples.Authorization
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

namespace SD.LLBLGen.Pro.Examples.Authorization.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: User. </summary>
	public partial class UserRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between UserEntity and UserGroupEntity over the 1:n relation they have, using the relation between the fields: User.UserId - UserGroup.UserId</summary>
		public virtual IEntityRelation UserGroupEntityUsingUserId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "UserGroup", true, new[] { UserFields.UserId, UserGroupFields.UserId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticUserRelations
	{
		internal static readonly IEntityRelation UserGroupEntityUsingUserIdStatic = new UserRelations().UserGroupEntityUsingUserId;

		/// <summary>CTor</summary>
		static StaticUserRelations() { }
	}
}
