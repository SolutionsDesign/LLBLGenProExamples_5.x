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
	/// <summary>Entity class which represents the entity 'Territory'. <br/><br/></summary>
	[Serializable]
	public partial class TerritoryEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeTerritoryCollection	_employeeTerritories;
		private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection _employeesCollectionViaEmployeeTerritories;
		private RegionEntity _region;
		private bool	_regionReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static TerritoryEntityStaticMetaData _staticMetaData = new TerritoryEntityStaticMetaData();
		private static TerritoryRelations _relationsFactory = new TerritoryRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Region</summary>
			public static readonly string Region = "Region";
			/// <summary>Member name EmployeeTerritories</summary>
			public static readonly string EmployeeTerritories = "EmployeeTerritories";
			/// <summary>Member name EmployeesCollectionViaEmployeeTerritories</summary>
			public static readonly string EmployeesCollectionViaEmployeeTerritories = "EmployeesCollectionViaEmployeeTerritories";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class TerritoryEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public TerritoryEntityStaticMetaData()
			{
				SetEntityCoreInfo("TerritoryEntity", InheritanceHierarchyType.None, false, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.TerritoryEntity, typeof(TerritoryEntity), typeof(TerritoryEntityFactory), false);
				AddNavigatorMetaData<TerritoryEntity, SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeTerritoryCollection>("EmployeeTerritories", a => a._employeeTerritories, (a, b) => a._employeeTerritories = b, a => a.EmployeeTerritories, () => new TerritoryRelations().EmployeeTerritoryEntityUsingTerritoryId, typeof(EmployeeTerritoryEntity), (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.EmployeeTerritoryEntity);
				AddNavigatorMetaData<TerritoryEntity, RegionEntity>("Region", "Territories", (a, b) => a._region = b, a => a._region, (a, b) => a.Region = b, SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticTerritoryRelations.RegionEntityUsingRegionIdStatic, ()=>new TerritoryRelations().RegionEntityUsingRegionId, null, new int[] { (int)TerritoryFieldIndex.RegionId }, null, true, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.RegionEntity);
				AddNavigatorMetaData<TerritoryEntity, SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection>("EmployeesCollectionViaEmployeeTerritories", a => a._employeesCollectionViaEmployeeTerritories, (a, b) => a._employeesCollectionViaEmployeeTerritories = b, a => a.EmployeesCollectionViaEmployeeTerritories, () => new TerritoryRelations().EmployeeTerritoryEntityUsingTerritoryId, () => new EmployeeTerritoryRelations().EmployeeEntityUsingEmployeeId, "TerritoryEntity__", "EmployeeTerritory_", typeof(EmployeeEntity), (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.EmployeeEntity);
			}
		}
		
		/// <summary>Static ctor</summary>
		static TerritoryEntity()
		{
		}

		/// <summary>CTor</summary>
		public TerritoryEntity() :base()
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="territoryId">PK value for Territory which data should be fetched into this Territory object</param>
		public TerritoryEntity(System.String territoryId)
		{
			InitClassFetch(territoryId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="territoryId">PK value for Territory which data should be fetched into this Territory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public TerritoryEntity(System.String territoryId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(territoryId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="territoryId">PK value for Territory which data should be fetched into this Territory object</param>
		/// <param name="validator">The custom validator object for this TerritoryEntity</param>
		public TerritoryEntity(System.String territoryId, IValidator validator)
		{
			InitClassFetch(territoryId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected TerritoryEntity(SerializationInfo info, StreamingContext context):base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}



		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="territoryId">PK value for Territory which data should be fetched into this Territory object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String territoryId)
		{
			return FetchUsingPK(territoryId, null, null, null);
		}

		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="territoryId">PK value for Territory which data should be fetched into this Territory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String territoryId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(territoryId, prefetchPathToUse, null, null);
		}

		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="territoryId">PK value for Territory which data should be fetched into this Territory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String territoryId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(territoryId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="territoryId">PK value for Territory which data should be fetched into this Territory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String territoryId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(territoryId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <inheritdoc/>
		public override bool Refetch()
		{
			return Fetch(this.TerritoryId, null, null, null);
		}

		/// <summary>Retrieves all related entities of type 'EmployeeTerritoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeTerritoryEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeTerritoryCollection GetMultiEmployeeTerritories(bool forceFetch)
		{
			return GetMultiEmployeeTerritories(forceFetch, _employeeTerritories.EntityFactoryToUse, null);
		}

		/// <summary>Retrieves all related entities of type 'EmployeeTerritoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeTerritoryEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeTerritoryCollection GetMultiEmployeeTerritories(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiEmployeeTerritories(forceFetch, _employeeTerritories.EntityFactoryToUse, filter);
		}

		/// <summary>Retrieves all related entities of type 'EmployeeTerritoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeTerritoryCollection GetMultiEmployeeTerritories(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiEmployeeTerritories(forceFetch, entityFactoryToUse, null);
		}

		/// <summary>Retrieves all related entities of type 'EmployeeTerritoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeTerritoryCollection GetMultiEmployeeTerritories(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
			return PerformMultiEntityLazyLoading<SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeTerritoryCollection>("EmployeeTerritories", forceFetch, entityFactoryToUse, (c,r)=>c.GetMultiManyToOne(null, this, filter));
		}

		/// <summary>Sets the collection parameters for the collection for 'EmployeeTerritories'. These settings will be taken into account
		/// when the property EmployeeTerritories is requested or GetMultiEmployeeTerritories is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeTerritories(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeTerritories.SortClauses=sortClauses;
			_employeeTerritories.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary>Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection GetMultiEmployeesCollectionViaEmployeeTerritories(bool forceFetch)
		{
			return GetMultiEmployeesCollectionViaEmployeeTerritories(forceFetch, _employeesCollectionViaEmployeeTerritories.EntityFactoryToUse);
		}

		/// <summary>Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection GetMultiEmployeesCollectionViaEmployeeTerritories(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			var filter = new PredicateExpression();
			filter.Add(new FieldCompareValuePredicate(TerritoryFields.TerritoryId, ComparisonOperator.Equal, this.TerritoryId, "TerritoryEntity__"));
			return PerformMultiEntityLazyLoading<SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection>("EmployeesCollectionViaEmployeeTerritories", forceFetch, entityFactoryToUse, (c,r)=>c.GetMulti(filter, r));
		}

		/// <summary>Sets the collection parameters for the collection for 'EmployeesCollectionViaEmployeeTerritories'. These settings will be taken into account
		/// when the property EmployeesCollectionViaEmployeeTerritories is requested or GetMultiEmployeesCollectionViaEmployeeTerritories is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeesCollectionViaEmployeeTerritories(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeesCollectionViaEmployeeTerritories.SortClauses=sortClauses;
			_employeesCollectionViaEmployeeTerritories.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary>Retrieves the related entity of type 'RegionEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'RegionEntity' which is related to this entity.</returns>
		public virtual RegionEntity GetSingleRegion(bool forceFetch=false)
		{
			return PerformSingleEntityLazyLoading<RegionEntity>("Region", forceFetch, _regionReturnsNewIfNotFound, e=>e.FetchUsingPK(this.RegionId));
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
		/// <param name="territoryId">PK value for Territory which data should be fetched into this Territory object</param>
		/// <param name="validator">The validator object for this TerritoryEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.String territoryId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(territoryId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			_employeeTerritories = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeTerritoryCollection();
			_employeeTerritories.SetContainingEntityInfo(this, "Territories");
			_employeesCollectionViaEmployeeTerritories = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection();
			_regionReturnsNewIfNotFound = true;
			PerformDependencyInjection();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}


		/// <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="territoryId">PK value for Territory which data should be fetched into this Territory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.String territoryId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)TerritoryFieldIndex.TerritoryId].ForcedCurrentValueWrite(territoryId);
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
		protected override IDao CreateDAOInstance() { return DAOFactory.CreateTerritoryDAO(); }
		
		/// <summary>Gets the entity static meta data instance from the generated type.</summary>
		/// <returns>The instance requested</returns>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() { return _staticMetaData; }
		
		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static TerritoryRelations Relations { get { return _relationsFactory; } }


		/// <summary>Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'EmployeeTerritory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeTerritories { get { return _staticMetaData.GetPrefetchPathElement("EmployeeTerritories", new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeTerritoryCollection()); } }

		/// <summary>Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeesCollectionViaEmployeeTerritories { get { return _staticMetaData.GetPrefetchPathElement("EmployeesCollectionViaEmployeeTerritories", new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection()); } }

		/// <summary>Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Region'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRegion { get { return _staticMetaData.GetPrefetchPathElement("Region", new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.RegionCollection()); } }


		/// <summary>The RegionId property of the Entity Territory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Territories"."RegionID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 RegionId
		{
			get { return (System.Int32)GetValue((int)TerritoryFieldIndex.RegionId, true); }
			set	{ SetValue((int)TerritoryFieldIndex.RegionId, value, true); }
		}

		/// <summary>The TerritoryDescription property of the Entity Territory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Territories"."TerritoryDescription"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String TerritoryDescription
		{
			get { return (System.String)GetValue((int)TerritoryFieldIndex.TerritoryDescription, true); }
			set	{ SetValue((int)TerritoryFieldIndex.TerritoryDescription, value, true); }
		}

		/// <summary>The TerritoryId property of the Entity Territory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Territories"."TerritoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String TerritoryId
		{
			get { return (System.String)GetValue((int)TerritoryFieldIndex.TerritoryId, true); }
			set	{ SetValue((int)TerritoryFieldIndex.TerritoryId, value, true); }
		}

		/// <summary>Retrieves all related entities of type 'EmployeeTerritoryEntity' using a relation of type '1:n'.<br/><br/></summary>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeTerritoryCollection EmployeeTerritories { get { return GetMultiEmployeeTerritories(false); } }

		/// <summary>Gets / sets the lazy loading flag for EmployeeTerritories. When set to true, EmployeeTerritories is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeTerritories is accessed. You can always execute/ a forced fetch by calling GetMultiEmployeeTerritories(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeTerritories
		{
			get	{ return GetAlwaysFetchValueForNavigator("EmployeeTerritories"); }
			set	{ SetAlwaysFetchValueForNavigator("EmployeeTerritories", value); }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeTerritories already has been fetched. Setting this property to false when EmployeeTerritories has been fetched
		/// will clear the EmployeeTerritories collection well. Setting this property to true while EmployeeTerritories hasn't been fetched disables lazy loading for EmployeeTerritories</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeTerritories
		{
			get { return GetAlreadyFetchedValueForNavigator("EmployeeTerritories");}
			set { SetAlreadyFetchedValueForNavigator("EmployeeTerritories", value, true);}
		}

		/// <summary>Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.<br/><br/></summary>
		public virtual SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection EmployeesCollectionViaEmployeeTerritories { get { return GetMultiEmployeesCollectionViaEmployeeTerritories(false); } }

		/// <summary>Gets / sets the lazy loading flag for EmployeesCollectionViaEmployeeTerritories. When set to true, EmployeesCollectionViaEmployeeTerritories is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeesCollectionViaEmployeeTerritories is accessed. You can always execute a forced fetch by calling GetMultiEmployeesCollectionViaEmployeeTerritories(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeesCollectionViaEmployeeTerritories
		{
			get	{ return GetAlwaysFetchValueForNavigator("EmployeesCollectionViaEmployeeTerritories"); }
			set	{ SetAlwaysFetchValueForNavigator("EmployeesCollectionViaEmployeeTerritories", value); }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeesCollectionViaEmployeeTerritories already has been fetched. Setting this property to false when EmployeesCollectionViaEmployeeTerritories has been fetched
		/// will clear the EmployeesCollectionViaEmployeeTerritories collection well. Setting this property to true while EmployeesCollectionViaEmployeeTerritories hasn't been fetched disables lazy loading for EmployeesCollectionViaEmployeeTerritories</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeesCollectionViaEmployeeTerritories
		{
			get { return GetAlreadyFetchedValueForNavigator("EmployeesCollectionViaEmployeeTerritories");}
			set { SetAlreadyFetchedValueForNavigator("EmployeesCollectionViaEmployeeTerritories", value, true);}
		}

		/// <summary>Gets / sets related entity of type 'RegionEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/></summary>
		[Browsable(true)]
		public virtual RegionEntity Region
		{
			get	{ return GetSingleRegion(false); }
			set { SetSingleRelatedEntityNavigator(value, "Region"); }
		}

		/// <summary>Gets / sets the lazy loading flag for Region. When set to true, Region is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Region is accessed. You can always execute a forced fetch by calling GetSingleRegion(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRegion
		{
			get	{ return GetAlwaysFetchValueForNavigator("Region"); }
			set	{ SetAlwaysFetchValueForNavigator("Region", value); }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Region already has been fetched. Setting this property to false when Region has been fetched
		/// will set Region to null as well. Setting this property to true while Region hasn't been fetched disables lazy loading for Region</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRegion
		{
			get { return GetAlreadyFetchedValueForNavigator("Region");}
			set { SetAlreadyFetchedValueForNavigator("Region", value, true);}
		}

		/// <summary>Gets / sets the flag for what to do if the related entity available through the property Region is not found
		/// in the database. When set to true, Region will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool RegionReturnsNewIfNotFound
		{
			get	{ return _regionReturnsNewIfNotFound; }
			set { _regionReturnsNewIfNotFound = value; }	
		}



		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace SD.LLBLGen.Pro.Examples.Auditing
{
	public enum TerritoryFieldIndex
	{
		///<summary>RegionId. </summary>
		RegionId,
		///<summary>TerritoryDescription. </summary>
		TerritoryDescription,
		///<summary>TerritoryId. </summary>
		TerritoryId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace SD.LLBLGen.Pro.Examples.Auditing.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Territory. </summary>
	public partial class TerritoryRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between TerritoryEntity and EmployeeTerritoryEntity over the 1:n relation they have, using the relation between the fields: Territory.TerritoryId - EmployeeTerritory.TerritoryId</summary>
		public virtual IEntityRelation EmployeeTerritoryEntityUsingTerritoryId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "EmployeeTerritories", true, new[] { TerritoryFields.TerritoryId, EmployeeTerritoryFields.TerritoryId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between TerritoryEntity and RegionEntity over the m:1 relation they have, using the relation between the fields: Territory.RegionId - Region.RegionId</summary>
		public virtual IEntityRelation RegionEntityUsingRegionId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Region", false, new[] { RegionFields.RegionId, TerritoryFields.RegionId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticTerritoryRelations
	{
		internal static readonly IEntityRelation EmployeeTerritoryEntityUsingTerritoryIdStatic = new TerritoryRelations().EmployeeTerritoryEntityUsingTerritoryId;
		internal static readonly IEntityRelation RegionEntityUsingRegionIdStatic = new TerritoryRelations().RegionEntityUsingRegionId;

		/// <summary>CTor</summary>
		static StaticTerritoryRelations() { }
	}
}
