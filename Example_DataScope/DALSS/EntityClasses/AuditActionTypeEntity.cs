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
	/// <summary>Entity class which represents the entity 'AuditActionType'. <br/><br/></summary>
	[Serializable]
	public partial class AuditActionTypeEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private Northwind.SSDAL.CollectionClasses.AuditInfoCollection	_auditInfos;

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
				SetEntityCoreInfo("AuditActionTypeEntity", InheritanceHierarchyType.None, false, (int)Northwind.SSDAL.EntityType.AuditActionTypeEntity, typeof(AuditActionTypeEntity), typeof(AuditActionTypeEntityFactory), false);
				AddNavigatorMetaData<AuditActionTypeEntity, Northwind.SSDAL.CollectionClasses.AuditInfoCollection>("AuditInfos", a => a._auditInfos, (a, b) => a._auditInfos = b, a => a.AuditInfos, () => new AuditActionTypeRelations().AuditInfoEntityUsingAuditActionTypeId, typeof(AuditInfoEntity), (int)Northwind.SSDAL.EntityType.AuditInfoEntity);
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
			return PerformMultiEntityLazyLoading<Northwind.SSDAL.CollectionClasses.AuditInfoCollection>("AuditInfos", forceFetch, entityFactoryToUse, (c,r)=>c.GetMultiManyToOne(this, null, filter));
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
			_auditInfos = new Northwind.SSDAL.CollectionClasses.AuditInfoCollection();
			_auditInfos.SetContainingEntityInfo(this, "AuditActionType");
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
		public static IPrefetchPathElement PrefetchPathAuditInfos { get { return _staticMetaData.GetPrefetchPathElement("AuditInfos", new Northwind.SSDAL.CollectionClasses.AuditInfoCollection()); } }


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



		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace Northwind.SSDAL
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

namespace Northwind.SSDAL.RelationClasses
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
