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
	/// <summary>Entity class which represents the entity 'Employees'.<br/><br/></summary>
	[Serializable]
	public partial class EmployeesEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<EmployeesEntity> _employees_;
		private EntityCollection<OrdersEntity> _orders;
		private EntityCollection<CustomersEntity> _customersCollectionViaOrders;
		private EmployeesEntity _employees;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static EmployeesEntityStaticMetaData _staticMetaData = new EmployeesEntityStaticMetaData();
		private static EmployeesRelations _relationsFactory = new EmployeesRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Employees</summary>
			public static readonly string Employees = "Employees";
			/// <summary>Member name Employees_</summary>
			public static readonly string Employees_ = "Employees_";
			/// <summary>Member name Orders</summary>
			public static readonly string Orders = "Orders";
			/// <summary>Member name CustomersCollectionViaOrders</summary>
			public static readonly string CustomersCollectionViaOrders = "CustomersCollectionViaOrders";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class EmployeesEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public EmployeesEntityStaticMetaData()
			{
				SetEntityCoreInfo("EmployeesEntity", InheritanceHierarchyType.None, false, (int)SD.LLBLGen.Pro.Examples.Authorization.EntityType.EmployeesEntity, typeof(EmployeesEntity), typeof(EmployeesEntityFactory), false);
				AddNavigatorMetaData<EmployeesEntity, EntityCollection<EmployeesEntity>>("Employees_", a => a._employees_, (a, b) => a._employees_ = b, a => a.Employees_, () => new EmployeesRelations().EmployeesEntityUsingReportsTo, typeof(EmployeesEntity), (int)SD.LLBLGen.Pro.Examples.Authorization.EntityType.EmployeesEntity);
				AddNavigatorMetaData<EmployeesEntity, EntityCollection<OrdersEntity>>("Orders", a => a._orders, (a, b) => a._orders = b, a => a.Orders, () => new EmployeesRelations().OrdersEntityUsingEmployeeId, typeof(OrdersEntity), (int)SD.LLBLGen.Pro.Examples.Authorization.EntityType.OrdersEntity);
				AddNavigatorMetaData<EmployeesEntity, EmployeesEntity>("Employees", "Employees_", (a, b) => a._employees = b, a => a._employees, (a, b) => a.Employees = b, SD.LLBLGen.Pro.Examples.Authorization.RelationClasses.StaticEmployeesRelations.EmployeesEntityUsingEmployeeIdReportsToStatic, ()=>new EmployeesRelations().EmployeesEntityUsingEmployeeIdReportsTo, null, new int[] { (int)EmployeesFieldIndex.ReportsTo }, null, true, (int)SD.LLBLGen.Pro.Examples.Authorization.EntityType.EmployeesEntity);
				AddNavigatorMetaData<EmployeesEntity, EntityCollection<CustomersEntity>>("CustomersCollectionViaOrders", a => a._customersCollectionViaOrders, (a, b) => a._customersCollectionViaOrders = b, a => a.CustomersCollectionViaOrders, () => new EmployeesRelations().OrdersEntityUsingEmployeeId, () => new OrdersRelations().CustomersEntityUsingCustomerId, "EmployeesEntity__", "Orders_", typeof(CustomersEntity), (int)SD.LLBLGen.Pro.Examples.Authorization.EntityType.CustomersEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static EmployeesEntity()
		{
		}

		/// <summary> CTor</summary>
		public EmployeesEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public EmployeesEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this EmployeesEntity</param>
		public EmployeesEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="employeeId">PK value for Employees which data should be fetched into this Employees object</param>
		public EmployeesEntity(System.Int32 employeeId) : this(employeeId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="employeeId">PK value for Employees which data should be fetched into this Employees object</param>
		/// <param name="validator">The custom validator object for this EmployeesEntity</param>
		public EmployeesEntity(System.Int32 employeeId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.EmployeeId = employeeId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected EmployeesEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Employees' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployees_() { return CreateRelationInfoForNavigator("Employees_"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Orders' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoOrders() { return CreateRelationInfoForNavigator("Orders"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Customers' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCustomersCollectionViaOrders() { return CreateRelationInfoForNavigator("CustomersCollectionViaOrders"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Employees' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployees() { return CreateRelationInfoForNavigator("Employees"); }
		
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
		/// <param name="validator">The validator object for this EmployeesEntity</param>
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
		public static EmployeesRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employees' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployees_ { get { return _staticMetaData.GetPrefetchPathElement("Employees_", CommonEntityBase.CreateEntityCollection<EmployeesEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Orders' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathOrders { get { return _staticMetaData.GetPrefetchPathElement("Orders", CommonEntityBase.CreateEntityCollection<OrdersEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Customers' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCustomersCollectionViaOrders { get { return _staticMetaData.GetPrefetchPathElement("CustomersCollectionViaOrders", CommonEntityBase.CreateEntityCollection<CustomersEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employees' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployees { get { return _staticMetaData.GetPrefetchPathElement("Employees", CommonEntityBase.CreateEntityCollection<EmployeesEntity>()); } }

		/// <summary>The Address property of the Entity Employees<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."Address".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Address
		{
			get { return (System.String)GetValue((int)EmployeesFieldIndex.Address, true); }
			set	{ SetValue((int)EmployeesFieldIndex.Address, value); }
		}

		/// <summary>The BirthDate property of the Entity Employees<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."BirthDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> BirthDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)EmployeesFieldIndex.BirthDate, false); }
			set	{ SetValue((int)EmployeesFieldIndex.BirthDate, value); }
		}

		/// <summary>The City property of the Entity Employees<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."City".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String City
		{
			get { return (System.String)GetValue((int)EmployeesFieldIndex.City, true); }
			set	{ SetValue((int)EmployeesFieldIndex.City, value); }
		}

		/// <summary>The Country property of the Entity Employees<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."Country".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Country
		{
			get { return (System.String)GetValue((int)EmployeesFieldIndex.Country, true); }
			set	{ SetValue((int)EmployeesFieldIndex.Country, value); }
		}

		/// <summary>The EmployeeId property of the Entity Employees<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."EmployeeID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 EmployeeId
		{
			get { return (System.Int32)GetValue((int)EmployeesFieldIndex.EmployeeId, true); }
			set { SetValue((int)EmployeesFieldIndex.EmployeeId, value); }		}

		/// <summary>The Extension property of the Entity Employees<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."Extension".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 4.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Extension
		{
			get { return (System.String)GetValue((int)EmployeesFieldIndex.Extension, true); }
			set	{ SetValue((int)EmployeesFieldIndex.Extension, value); }
		}

		/// <summary>The FirstName property of the Entity Employees<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."FirstName".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String FirstName
		{
			get { return (System.String)GetValue((int)EmployeesFieldIndex.FirstName, true); }
			set	{ SetValue((int)EmployeesFieldIndex.FirstName, value); }
		}

		/// <summary>The HireDate property of the Entity Employees<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."HireDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> HireDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)EmployeesFieldIndex.HireDate, false); }
			set	{ SetValue((int)EmployeesFieldIndex.HireDate, value); }
		}

		/// <summary>The HomePhone property of the Entity Employees<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."HomePhone".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 24.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String HomePhone
		{
			get { return (System.String)GetValue((int)EmployeesFieldIndex.HomePhone, true); }
			set	{ SetValue((int)EmployeesFieldIndex.HomePhone, value); }
		}

		/// <summary>The LastName property of the Entity Employees<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."LastName".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String LastName
		{
			get { return (System.String)GetValue((int)EmployeesFieldIndex.LastName, true); }
			set	{ SetValue((int)EmployeesFieldIndex.LastName, value); }
		}

		/// <summary>The Notes property of the Entity Employees<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."Notes".<br/>Table field type characteristics (type, precision, scale, length): NText, 0, 0, 1073741823.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Notes
		{
			get { return (System.String)GetValue((int)EmployeesFieldIndex.Notes, true); }
			set	{ SetValue((int)EmployeesFieldIndex.Notes, value); }
		}

		/// <summary>The Photo property of the Entity Employees<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."Photo".<br/>Table field type characteristics (type, precision, scale, length): Image, 0, 0, 2147483647.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Byte[] Photo
		{
			get { return (System.Byte[])GetValue((int)EmployeesFieldIndex.Photo, true); }
			set	{ SetValue((int)EmployeesFieldIndex.Photo, value); }
		}

		/// <summary>The PhotoPath property of the Entity Employees<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."PhotoPath".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String PhotoPath
		{
			get { return (System.String)GetValue((int)EmployeesFieldIndex.PhotoPath, true); }
			set	{ SetValue((int)EmployeesFieldIndex.PhotoPath, value); }
		}

		/// <summary>The PostalCode property of the Entity Employees<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."PostalCode".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String PostalCode
		{
			get { return (System.String)GetValue((int)EmployeesFieldIndex.PostalCode, true); }
			set	{ SetValue((int)EmployeesFieldIndex.PostalCode, value); }
		}

		/// <summary>The Region property of the Entity Employees<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."Region".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Region
		{
			get { return (System.String)GetValue((int)EmployeesFieldIndex.Region, true); }
			set	{ SetValue((int)EmployeesFieldIndex.Region, value); }
		}

		/// <summary>The ReportsTo property of the Entity Employees<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."ReportsTo".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ReportsTo
		{
			get { return (Nullable<System.Int32>)GetValue((int)EmployeesFieldIndex.ReportsTo, false); }
			set	{ SetValue((int)EmployeesFieldIndex.ReportsTo, value); }
		}

		/// <summary>The Title property of the Entity Employees<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."Title".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 30.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)EmployeesFieldIndex.Title, true); }
			set	{ SetValue((int)EmployeesFieldIndex.Title, value); }
		}

		/// <summary>The TitleOfCourtesy property of the Entity Employees<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."TitleOfCourtesy".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String TitleOfCourtesy
		{
			get { return (System.String)GetValue((int)EmployeesFieldIndex.TitleOfCourtesy, true); }
			set	{ SetValue((int)EmployeesFieldIndex.TitleOfCourtesy, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'EmployeesEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(EmployeesEntity))]
		public virtual EntityCollection<EmployeesEntity> Employees_ { get { return GetOrCreateEntityCollection<EmployeesEntity, EmployeesEntityFactory>("Employees", true, false, ref _employees_); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'OrdersEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(OrdersEntity))]
		public virtual EntityCollection<OrdersEntity> Orders { get { return GetOrCreateEntityCollection<OrdersEntity, OrdersEntityFactory>("Employees", true, false, ref _orders); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'CustomersEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CustomersEntity))]
		public virtual EntityCollection<CustomersEntity> CustomersCollectionViaOrders { get { return GetOrCreateEntityCollection<CustomersEntity, CustomersEntityFactory>("EmployeesCollectionViaOrders", false, true, ref _customersCollectionViaOrders); } }

		/// <summary>Gets / sets related entity of type 'EmployeesEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual EmployeesEntity Employees
		{
			get { return _employees; }
			set { SetSingleRelatedEntityNavigator(value, "Employees"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace SD.LLBLGen.Pro.Examples.Authorization
{
	public enum EmployeesFieldIndex
	{
		///<summary>Address. </summary>
		Address,
		///<summary>BirthDate. </summary>
		BirthDate,
		///<summary>City. </summary>
		City,
		///<summary>Country. </summary>
		Country,
		///<summary>EmployeeId. </summary>
		EmployeeId,
		///<summary>Extension. </summary>
		Extension,
		///<summary>FirstName. </summary>
		FirstName,
		///<summary>HireDate. </summary>
		HireDate,
		///<summary>HomePhone. </summary>
		HomePhone,
		///<summary>LastName. </summary>
		LastName,
		///<summary>Notes. </summary>
		Notes,
		///<summary>Photo. </summary>
		Photo,
		///<summary>PhotoPath. </summary>
		PhotoPath,
		///<summary>PostalCode. </summary>
		PostalCode,
		///<summary>Region. </summary>
		Region,
		///<summary>ReportsTo. </summary>
		ReportsTo,
		///<summary>Title. </summary>
		Title,
		///<summary>TitleOfCourtesy. </summary>
		TitleOfCourtesy,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace SD.LLBLGen.Pro.Examples.Authorization.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Employees. </summary>
	public partial class EmployeesRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between EmployeesEntity and EmployeesEntity over the 1:n relation they have, using the relation between the fields: Employees.EmployeeId - Employees.ReportsTo</summary>
		public virtual IEntityRelation EmployeesEntityUsingReportsTo
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Employees_", true, new[] { EmployeesFields.EmployeeId, EmployeesFields.ReportsTo }); }
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeesEntity and OrdersEntity over the 1:n relation they have, using the relation between the fields: Employees.EmployeeId - Orders.EmployeeId</summary>
		public virtual IEntityRelation OrdersEntityUsingEmployeeId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Orders", true, new[] { EmployeesFields.EmployeeId, OrdersFields.EmployeeId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeesEntity and EmployeesEntity over the m:1 relation they have, using the relation between the fields: Employees.ReportsTo - Employees.EmployeeId</summary>
		public virtual IEntityRelation EmployeesEntityUsingEmployeeIdReportsTo
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Employees", false, new[] { EmployeesFields.EmployeeId, EmployeesFields.ReportsTo }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticEmployeesRelations
	{
		internal static readonly IEntityRelation EmployeesEntityUsingReportsToStatic = new EmployeesRelations().EmployeesEntityUsingReportsTo;
		internal static readonly IEntityRelation OrdersEntityUsingEmployeeIdStatic = new EmployeesRelations().OrdersEntityUsingEmployeeId;
		internal static readonly IEntityRelation EmployeesEntityUsingEmployeeIdReportsToStatic = new EmployeesRelations().EmployeesEntityUsingEmployeeIdReportsTo;

		/// <summary>CTor</summary>
		static StaticEmployeesRelations() { }
	}
}
