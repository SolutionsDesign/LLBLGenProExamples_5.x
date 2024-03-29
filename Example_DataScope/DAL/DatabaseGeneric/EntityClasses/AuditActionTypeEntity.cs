﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Northwind.DAL.HelperClasses;
using Northwind.DAL.FactoryClasses;
using Northwind.DAL.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.DAL.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'AuditActionType'.<br/><br/></summary>
	[Serializable]
	public partial class AuditActionTypeEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<AuditInfoEntity> _auditInfos;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static AuditActionTypeEntityStaticMetaData _staticMetaData = new AuditActionTypeEntityStaticMetaData();
		private static AuditActionTypeRelations _relationsFactory = new AuditActionTypeRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name AuditInfos</summary>
			public static readonly string AuditInfos = "AuditInfos";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class AuditActionTypeEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public AuditActionTypeEntityStaticMetaData()
			{
				SetEntityCoreInfo("AuditActionTypeEntity", InheritanceHierarchyType.None, false, (int)Northwind.DAL.EntityType.AuditActionTypeEntity, typeof(AuditActionTypeEntity), typeof(AuditActionTypeEntityFactory), false);
				AddNavigatorMetaData<AuditActionTypeEntity, EntityCollection<AuditInfoEntity>>("AuditInfos", a => a._auditInfos, (a, b) => a._auditInfos = b, a => a.AuditInfos, () => new AuditActionTypeRelations().AuditInfoEntityUsingAuditActionTypeId, typeof(AuditInfoEntity), (int)Northwind.DAL.EntityType.AuditInfoEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static AuditActionTypeEntity()
		{
		}

		/// <summary> CTor</summary>
		public AuditActionTypeEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public AuditActionTypeEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this AuditActionTypeEntity</param>
		public AuditActionTypeEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="auditActionTypeId">PK value for AuditActionType which data should be fetched into this AuditActionType object</param>
		public AuditActionTypeEntity(System.Int32 auditActionTypeId) : this(auditActionTypeId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="auditActionTypeId">PK value for AuditActionType which data should be fetched into this AuditActionType object</param>
		/// <param name="validator">The custom validator object for this AuditActionTypeEntity</param>
		public AuditActionTypeEntity(System.Int32 auditActionTypeId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.AuditActionTypeId = auditActionTypeId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AuditActionTypeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'AuditInfo' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAuditInfos() { return CreateRelationInfoForNavigator("AuditInfos"); }
		
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
		/// <param name="validator">The validator object for this AuditActionTypeEntity</param>
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
		public static AuditActionTypeRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AuditInfo' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAuditInfos { get { return _staticMetaData.GetPrefetchPathElement("AuditInfos", CommonEntityBase.CreateEntityCollection<AuditInfoEntity>()); } }

		/// <summary>The AuditActionTypeId property of the Entity AuditActionType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditActionType"."AuditActionTypeID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 AuditActionTypeId
		{
			get { return (System.Int32)GetValue((int)AuditActionTypeFieldIndex.AuditActionTypeId, true); }
			set	{ SetValue((int)AuditActionTypeFieldIndex.AuditActionTypeId, value); }
		}

		/// <summary>The Name property of the Entity AuditActionType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditActionType"."Name".<br/>Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)AuditActionTypeFieldIndex.Name, true); }
			set	{ SetValue((int)AuditActionTypeFieldIndex.Name, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'AuditInfoEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(AuditInfoEntity))]
		public virtual EntityCollection<AuditInfoEntity> AuditInfos { get { return GetOrCreateEntityCollection<AuditInfoEntity, AuditInfoEntityFactory>("AuditActionType", true, false, ref _auditInfos); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace Northwind.DAL
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

namespace Northwind.DAL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: AuditActionType. </summary>
	public partial class AuditActionTypeRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between AuditActionTypeEntity and AuditInfoEntity over the 1:n relation they have, using the relation between the fields: AuditActionType.AuditActionTypeId - AuditInfo.AuditActionTypeId</summary>
		public virtual IEntityRelation AuditInfoEntityUsingAuditActionTypeId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "AuditInfos", true, new[] { AuditActionTypeFields.AuditActionTypeId, AuditInfoFields.AuditActionTypeId }); }
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
