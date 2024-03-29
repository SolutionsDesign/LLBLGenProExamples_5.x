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
	/// <summary>Entity class which represents the entity 'CustomerCustomerDemo'.<br/><br/></summary>
	[Serializable]
	public partial class CustomerCustomerDemoEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private CustomerEntity _customer;
		private CustomerDemographicEntity _customerDemographic;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static CustomerCustomerDemoEntityStaticMetaData _staticMetaData = new CustomerCustomerDemoEntityStaticMetaData();
		private static CustomerCustomerDemoRelations _relationsFactory = new CustomerCustomerDemoRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Customer</summary>
			public static readonly string Customer = "Customer";
			/// <summary>Member name CustomerDemographic</summary>
			public static readonly string CustomerDemographic = "CustomerDemographic";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class CustomerCustomerDemoEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public CustomerCustomerDemoEntityStaticMetaData()
			{
				SetEntityCoreInfo("CustomerCustomerDemoEntity", InheritanceHierarchyType.None, false, (int)Northwind.DAL.EntityType.CustomerCustomerDemoEntity, typeof(CustomerCustomerDemoEntity), typeof(CustomerCustomerDemoEntityFactory), false);
				AddNavigatorMetaData<CustomerCustomerDemoEntity, CustomerEntity>("Customer", "CustomerCustomerDemos", (a, b) => a._customer = b, a => a._customer, (a, b) => a.Customer = b, Northwind.DAL.RelationClasses.StaticCustomerCustomerDemoRelations.CustomerEntityUsingCustomerIdStatic, ()=>new CustomerCustomerDemoRelations().CustomerEntityUsingCustomerId, null, new int[] { (int)CustomerCustomerDemoFieldIndex.CustomerId }, null, true, (int)Northwind.DAL.EntityType.CustomerEntity);
				AddNavigatorMetaData<CustomerCustomerDemoEntity, CustomerDemographicEntity>("CustomerDemographic", "CustomerCustomerDemos", (a, b) => a._customerDemographic = b, a => a._customerDemographic, (a, b) => a.CustomerDemographic = b, Northwind.DAL.RelationClasses.StaticCustomerCustomerDemoRelations.CustomerDemographicEntityUsingCustomerTypeIdStatic, ()=>new CustomerCustomerDemoRelations().CustomerDemographicEntityUsingCustomerTypeId, null, new int[] { (int)CustomerCustomerDemoFieldIndex.CustomerTypeId }, null, true, (int)Northwind.DAL.EntityType.CustomerDemographicEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static CustomerCustomerDemoEntity()
		{
		}

		/// <summary> CTor</summary>
		public CustomerCustomerDemoEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public CustomerCustomerDemoEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this CustomerCustomerDemoEntity</param>
		public CustomerCustomerDemoEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="customerId">PK value for CustomerCustomerDemo which data should be fetched into this CustomerCustomerDemo object</param>
		/// <param name="customerTypeId">PK value for CustomerCustomerDemo which data should be fetched into this CustomerCustomerDemo object</param>
		public CustomerCustomerDemoEntity(System.String customerId, System.String customerTypeId) : this(customerId, customerTypeId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="customerId">PK value for CustomerCustomerDemo which data should be fetched into this CustomerCustomerDemo object</param>
		/// <param name="customerTypeId">PK value for CustomerCustomerDemo which data should be fetched into this CustomerCustomerDemo object</param>
		/// <param name="validator">The custom validator object for this CustomerCustomerDemoEntity</param>
		public CustomerCustomerDemoEntity(System.String customerId, System.String customerTypeId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.CustomerId = customerId;
			this.CustomerTypeId = customerTypeId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CustomerCustomerDemoEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Customer' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCustomer() { return CreateRelationInfoForNavigator("Customer"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'CustomerDemographic' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCustomerDemographic() { return CreateRelationInfoForNavigator("CustomerDemographic"); }
		
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
		/// <param name="validator">The validator object for this CustomerCustomerDemoEntity</param>
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
		public static CustomerCustomerDemoRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Customer' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCustomer { get { return _staticMetaData.GetPrefetchPathElement("Customer", CommonEntityBase.CreateEntityCollection<CustomerEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CustomerDemographic' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCustomerDemographic { get { return _staticMetaData.GetPrefetchPathElement("CustomerDemographic", CommonEntityBase.CreateEntityCollection<CustomerDemographicEntity>()); } }

		/// <summary>The CustomerId property of the Entity CustomerCustomerDemo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CustomerCustomerDemo"."CustomerID".<br/>Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 5.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CustomerId
		{
			get { return (System.String)GetValue((int)CustomerCustomerDemoFieldIndex.CustomerId, true); }
			set	{ SetValue((int)CustomerCustomerDemoFieldIndex.CustomerId, value); }
		}

		/// <summary>The CustomerTypeId property of the Entity CustomerCustomerDemo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CustomerCustomerDemo"."CustomerTypeID".<br/>Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 10.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CustomerTypeId
		{
			get { return (System.String)GetValue((int)CustomerCustomerDemoFieldIndex.CustomerTypeId, true); }
			set	{ SetValue((int)CustomerCustomerDemoFieldIndex.CustomerTypeId, value); }
		}

		/// <summary>Gets / sets related entity of type 'CustomerEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual CustomerEntity Customer
		{
			get { return _customer; }
			set { SetSingleRelatedEntityNavigator(value, "Customer"); }
		}

		/// <summary>Gets / sets related entity of type 'CustomerDemographicEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual CustomerDemographicEntity CustomerDemographic
		{
			get { return _customerDemographic; }
			set { SetSingleRelatedEntityNavigator(value, "CustomerDemographic"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace Northwind.DAL
{
	public enum CustomerCustomerDemoFieldIndex
	{
		///<summary>CustomerId. </summary>
		CustomerId,
		///<summary>CustomerTypeId. </summary>
		CustomerTypeId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace Northwind.DAL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: CustomerCustomerDemo. </summary>
	public partial class CustomerCustomerDemoRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between CustomerCustomerDemoEntity and CustomerEntity over the m:1 relation they have, using the relation between the fields: CustomerCustomerDemo.CustomerId - Customer.CustomerId</summary>
		public virtual IEntityRelation CustomerEntityUsingCustomerId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Customer", false, new[] { CustomerFields.CustomerId, CustomerCustomerDemoFields.CustomerId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between CustomerCustomerDemoEntity and CustomerDemographicEntity over the m:1 relation they have, using the relation between the fields: CustomerCustomerDemo.CustomerTypeId - CustomerDemographic.CustomerTypeId</summary>
		public virtual IEntityRelation CustomerDemographicEntityUsingCustomerTypeId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "CustomerDemographic", false, new[] { CustomerDemographicFields.CustomerTypeId, CustomerCustomerDemoFields.CustomerTypeId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticCustomerCustomerDemoRelations
	{
		internal static readonly IEntityRelation CustomerEntityUsingCustomerIdStatic = new CustomerCustomerDemoRelations().CustomerEntityUsingCustomerId;
		internal static readonly IEntityRelation CustomerDemographicEntityUsingCustomerTypeIdStatic = new CustomerCustomerDemoRelations().CustomerDemographicEntityUsingCustomerTypeId;

		/// <summary>CTor</summary>
		static StaticCustomerCustomerDemoRelations() { }
	}
}
