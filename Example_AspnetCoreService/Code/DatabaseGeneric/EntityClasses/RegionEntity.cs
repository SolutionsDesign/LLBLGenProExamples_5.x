﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.8.</auto-generated>
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
using NWService.Dal.HelperClasses;
using NWService.Dal.FactoryClasses;
using NWService.Dal.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NWService.Dal.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'Region'.<br/><br/></summary>
	[Serializable]
	public partial class RegionEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		private EntityCollection<EmployeeEntity> _employees;
		private EntityCollection<TerritoryEntity> _territories;
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static RegionEntityStaticMetaData _staticMetaData = new RegionEntityStaticMetaData();
		private static RegionRelations _relationsFactory = new RegionRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Employees</summary>
			public static readonly string Employees = "Employees";
			/// <summary>Member name Territories</summary>
			public static readonly string Territories = "Territories";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class RegionEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public RegionEntityStaticMetaData()
			{
				SetEntityCoreInfo("RegionEntity", InheritanceHierarchyType.None, false, (int)NWService.Dal.EntityType.RegionEntity, typeof(RegionEntity), typeof(RegionEntityFactory), false);
				AddNavigatorMetaData<RegionEntity, EntityCollection<EmployeeEntity>>("Employees", a => a._employees, (a, b) => a._employees = b, a => a.Employees, () => new RegionRelations().EmployeeEntityUsingRegionId, typeof(EmployeeEntity), (int)NWService.Dal.EntityType.EmployeeEntity);
				AddNavigatorMetaData<RegionEntity, EntityCollection<TerritoryEntity>>("Territories", a => a._territories, (a, b) => a._territories = b, a => a.Territories, () => new RegionRelations().TerritoryEntityUsingRegionId, typeof(TerritoryEntity), (int)NWService.Dal.EntityType.TerritoryEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static RegionEntity()
		{
		}

		/// <summary> CTor</summary>
		public RegionEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public RegionEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this RegionEntity</param>
		public RegionEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="regionId">PK value for Region which data should be fetched into this Region object</param>
		public RegionEntity(System.Int32 regionId) : this(regionId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="regionId">PK value for Region which data should be fetched into this Region object</param>
		/// <param name="validator">The custom validator object for this RegionEntity</param>
		public RegionEntity(System.Int32 regionId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.RegionId = regionId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected RegionEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Employee' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployees() { return CreateRelationInfoForNavigator("Employees"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Territory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTerritories() { return CreateRelationInfoForNavigator("Territories"); }
		
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
		/// <param name="validator">The validator object for this RegionEntity</param>
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
		public static RegionRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployees { get { return _staticMetaData.GetPrefetchPathElement("Employees", CommonEntityBase.CreateEntityCollection<EmployeeEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Territory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTerritories { get { return _staticMetaData.GetPrefetchPathElement("Territories", CommonEntityBase.CreateEntityCollection<TerritoryEntity>()); } }

		/// <summary>The RegionDescription property of the Entity Region<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Region"."RegionDescription".<br/>Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String RegionDescription
		{
			get { return (System.String)GetValue((int)RegionFieldIndex.RegionDescription, true); }
			set	{ SetValue((int)RegionFieldIndex.RegionDescription, value); }
		}

		/// <summary>The RegionId property of the Entity Region<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Region"."RegionID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 RegionId
		{
			get { return (System.Int32)GetValue((int)RegionFieldIndex.RegionId, true); }
			set	{ SetValue((int)RegionFieldIndex.RegionId, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> Employees { get { return GetOrCreateEntityCollection<EmployeeEntity, EmployeeEntityFactory>("Region1", true, false, ref _employees); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'TerritoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(TerritoryEntity))]
		public virtual EntityCollection<TerritoryEntity> Territories { get { return GetOrCreateEntityCollection<TerritoryEntity, TerritoryEntityFactory>("Region", true, false, ref _territories); } }
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace NWService.Dal
{
	public enum RegionFieldIndex
	{
		///<summary>RegionDescription. </summary>
		RegionDescription,
		///<summary>RegionId. </summary>
		RegionId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace NWService.Dal.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Region. </summary>
	public partial class RegionRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between RegionEntity and EmployeeEntity over the 1:n relation they have, using the relation between the fields: Region.RegionId - Employee.RegionId</summary>
		public virtual IEntityRelation EmployeeEntityUsingRegionId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Employees", true, new[] { RegionFields.RegionId, EmployeeFields.RegionId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between RegionEntity and TerritoryEntity over the 1:n relation they have, using the relation between the fields: Region.RegionId - Territory.RegionId</summary>
		public virtual IEntityRelation TerritoryEntityUsingRegionId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Territories", true, new[] { RegionFields.RegionId, TerritoryFields.RegionId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticRegionRelations
	{
		internal static readonly IEntityRelation EmployeeEntityUsingRegionIdStatic = new RegionRelations().EmployeeEntityUsingRegionId;
		internal static readonly IEntityRelation TerritoryEntityUsingRegionIdStatic = new RegionRelations().TerritoryEntityUsingRegionId;

		/// <summary>CTor</summary>
		static StaticRegionRelations() { }
	}
}
