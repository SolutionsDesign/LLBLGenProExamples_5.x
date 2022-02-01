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
	/// <summary>Entity class which represents the entity 'Shipper'. <br/><br/></summary>
	[Serializable]
	public partial class ShipperEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private Northwind.SSDAL.CollectionClasses.OrderCollection	_orders;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static ShipperEntityStaticMetaData _staticMetaData = new ShipperEntityStaticMetaData();
		private static ShipperRelations _relationsFactory = new ShipperRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Orders</summary>
			public static readonly string Orders = "Orders";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class ShipperEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public ShipperEntityStaticMetaData()
			{
				SetEntityCoreInfo("ShipperEntity", InheritanceHierarchyType.None, false, (int)Northwind.SSDAL.EntityType.ShipperEntity, typeof(ShipperEntity), typeof(ShipperEntityFactory), false);
				AddNavigatorMetaData<ShipperEntity, Northwind.SSDAL.CollectionClasses.OrderCollection>("Orders", a => a._orders, (a, b) => a._orders = b, a => a.Orders, () => new ShipperRelations().OrderEntityUsingShipVia, typeof(OrderEntity), (int)Northwind.SSDAL.EntityType.OrderEntity);
			}
		}
		
		/// <summary>Static ctor</summary>
		static ShipperEntity()
		{
		}

		/// <summary>CTor</summary>
		public ShipperEntity() :base()
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="shipperId">PK value for Shipper which data should be fetched into this Shipper object</param>
		public ShipperEntity(System.Int32 shipperId)
		{
			InitClassFetch(shipperId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="shipperId">PK value for Shipper which data should be fetched into this Shipper object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ShipperEntity(System.Int32 shipperId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(shipperId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="shipperId">PK value for Shipper which data should be fetched into this Shipper object</param>
		/// <param name="validator">The custom validator object for this ShipperEntity</param>
		public ShipperEntity(System.Int32 shipperId, IValidator validator)
		{
			InitClassFetch(shipperId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ShipperEntity(SerializationInfo info, StreamingContext context):base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}



		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="shipperId">PK value for Shipper which data should be fetched into this Shipper object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 shipperId)
		{
			return FetchUsingPK(shipperId, null, null, null);
		}

		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="shipperId">PK value for Shipper which data should be fetched into this Shipper object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 shipperId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(shipperId, prefetchPathToUse, null, null);
		}

		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="shipperId">PK value for Shipper which data should be fetched into this Shipper object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 shipperId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(shipperId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary>Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="shipperId">PK value for Shipper which data should be fetched into this Shipper object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 shipperId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(shipperId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <inheritdoc/>
		public override bool Refetch()
		{
			return Fetch(this.ShipperId, null, null, null);
		}

		/// <summary>Retrieves all related entities of type 'OrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'OrderEntity'</returns>
		public Northwind.SSDAL.CollectionClasses.OrderCollection GetMultiOrders(bool forceFetch)
		{
			return GetMultiOrders(forceFetch, _orders.EntityFactoryToUse, null);
		}

		/// <summary>Retrieves all related entities of type 'OrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'OrderEntity'</returns>
		public Northwind.SSDAL.CollectionClasses.OrderCollection GetMultiOrders(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiOrders(forceFetch, _orders.EntityFactoryToUse, filter);
		}

		/// <summary>Retrieves all related entities of type 'OrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Northwind.SSDAL.CollectionClasses.OrderCollection GetMultiOrders(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiOrders(forceFetch, entityFactoryToUse, null);
		}

		/// <summary>Retrieves all related entities of type 'OrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Northwind.SSDAL.CollectionClasses.OrderCollection GetMultiOrders(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
			return PerformMultiEntityLazyLoading<Northwind.SSDAL.CollectionClasses.OrderCollection>("Orders", forceFetch, entityFactoryToUse, (c,r)=>c.GetMultiManyToOne(null, null, this, filter));
		}

		/// <summary>Sets the collection parameters for the collection for 'Orders'. These settings will be taken into account
		/// when the property Orders is requested or GetMultiOrders is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersOrders(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_orders.SortClauses=sortClauses;
			_orders.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
		/// <param name="shipperId">PK value for Shipper which data should be fetched into this Shipper object</param>
		/// <param name="validator">The validator object for this ShipperEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 shipperId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(shipperId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			_orders = new Northwind.SSDAL.CollectionClasses.OrderCollection();
			_orders.SetContainingEntityInfo(this, "Shipper");
			PerformDependencyInjection();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}


		/// <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="shipperId">PK value for Shipper which data should be fetched into this Shipper object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 shipperId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)ShipperFieldIndex.ShipperId].ForcedCurrentValueWrite(shipperId);
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
		protected override IDao CreateDAOInstance() { return DAOFactory.CreateShipperDAO(); }
		
		/// <summary>Gets the entity static meta data instance from the generated type.</summary>
		/// <returns>The instance requested</returns>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() { return _staticMetaData; }
		
		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static ShipperRelations Relations { get { return _relationsFactory; } }


		/// <summary>Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Order' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathOrders { get { return _staticMetaData.GetPrefetchPathElement("Orders", new Northwind.SSDAL.CollectionClasses.OrderCollection()); } }


		/// <summary>The CompanyName property of the Entity Shipper<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Shippers"."CompanyName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 40<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CompanyName
		{
			get { return (System.String)GetValue((int)ShipperFieldIndex.CompanyName, true); }
			set	{ SetValue((int)ShipperFieldIndex.CompanyName, value, true); }
		}

		/// <summary>The Phone property of the Entity Shipper<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Shippers"."Phone"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 24<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Phone
		{
			get { return (System.String)GetValue((int)ShipperFieldIndex.Phone, true); }
			set	{ SetValue((int)ShipperFieldIndex.Phone, value, true); }
		}

		/// <summary>The ShipperId property of the Entity Shipper<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Shippers"."ShipperID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ShipperId
		{
			get { return (System.Int32)GetValue((int)ShipperFieldIndex.ShipperId, true); }
			set	{ SetValue((int)ShipperFieldIndex.ShipperId, value, true); }
		}

		/// <summary>Retrieves all related entities of type 'OrderEntity' using a relation of type '1:n'.<br/><br/></summary>
		public virtual Northwind.SSDAL.CollectionClasses.OrderCollection Orders { get { return GetMultiOrders(false); } }

		/// <summary>Gets / sets the lazy loading flag for Orders. When set to true, Orders is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Orders is accessed. You can always execute/ a forced fetch by calling GetMultiOrders(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchOrders
		{
			get	{ return GetAlwaysFetchValueForNavigator("Orders"); }
			set	{ SetAlwaysFetchValueForNavigator("Orders", value); }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Orders already has been fetched. Setting this property to false when Orders has been fetched
		/// will clear the Orders collection well. Setting this property to true while Orders hasn't been fetched disables lazy loading for Orders</summary>
		[Browsable(false)]
		public bool AlreadyFetchedOrders
		{
			get { return GetAlreadyFetchedValueForNavigator("Orders");}
			set { SetAlreadyFetchedValueForNavigator("Orders", value, true);}
		}



		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace Northwind.SSDAL
{
	public enum ShipperFieldIndex
	{
		///<summary>CompanyName. </summary>
		CompanyName,
		///<summary>Phone. </summary>
		Phone,
		///<summary>ShipperId. </summary>
		ShipperId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace Northwind.SSDAL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Shipper. </summary>
	public partial class ShipperRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between ShipperEntity and OrderEntity over the 1:n relation they have, using the relation between the fields: Shipper.ShipperId - Order.ShipVia</summary>
		public virtual IEntityRelation OrderEntityUsingShipVia
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Orders", true, new[] { ShipperFields.ShipperId, OrderFields.ShipVia }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticShipperRelations
	{
		internal static readonly IEntityRelation OrderEntityUsingShipViaStatic = new ShipperRelations().OrderEntityUsingShipVia;

		/// <summary>CTor</summary>
		static StaticShipperRelations() { }
	}
}
