﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: Tuesday, 1 February 2022 16:31:17
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using SD.LLBLGen.Pro.Examples.HelperClasses;
using SD.LLBLGen.Pro.Examples.RelationClasses;
using SD.LLBLGen.Pro.Examples.DaoClasses;

using SD.LLBLGen.Pro.Examples.EntityClasses;
using SD.LLBLGen.Pro.Examples.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.FactoryClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>general base class for the generated factories</summary>
	[Serializable]
	public partial class EntityFactoryBase<TEntity> : EntityFactoryCore
			where TEntity : EntityBase, IEntity
	{
		private readonly SD.LLBLGen.Pro.Examples.EntityType _typeOfEntity;
		private readonly bool _isInHierarchy;

		/// <summary>CTor</summary>
		/// <param name="entityName">Name of the entity.</param>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <param name="isInHierarchy">Flag whether the entity to produce is in an inheritance hierarchy</param>
		public EntityFactoryBase(string entityName, SD.LLBLGen.Pro.Examples.EntityType typeOfEntity, bool isInHierarchy) : base(entityName, (int)typeOfEntity)
		{
			_typeOfEntity = typeOfEntity;
			_isInHierarchy = isInHierarchy;
		}

		/// <inheritdoc/>
		public override IEntity CreateEntityFromEntityTypeValue(int entityTypeValue) { return GeneralEntityFactory.Create((SD.LLBLGen.Pro.Examples.EntityType)entityTypeValue); }
		
		/// <inheritdoc/>
		public override IEntityFields CreateFields() { return EntityFieldsFactory.CreateEntityFieldsObject(_typeOfEntity); }

		/// <inheritdoc/>
		public override IRelationCollection CreateHierarchyRelations(string objectAlias) { return ModelInfoProviderSingleton.GetInstance().GetHierarchyRelations(ForEntityName, objectAlias); }

		/// <inheritdoc/>
		public override IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return (IEntityFactory)ModelInfoProviderSingleton.GetInstance().GetEntityFactory(ForEntityName, fieldValues, entityFieldStartIndexesPerEntity) ?? this;
		}
						
		/// <inheritdoc/>
		public override IEntityCollection CreateEntityCollection() { return GeneralEntityCollectionFactory.Create(_typeOfEntity); }

		/// <inheritdoc/>
		public override IEntityFields CreateHierarchyFields() 
		{
			return _isInHierarchy ? new EntityFields(ModelInfoProviderSingleton.GetInstance().GetHierarchyFields(this.ForEntityName), ModelInfoProviderSingleton.GetInstance(), null) : base.CreateHierarchyFields();
		}
				
		/// <inheritdoc/>
		protected override Type ForEntityType { get { return typeof(TEntity); } }
	}
	
	/// <summary>Factory to create new, empty CategoryEntity objects.</summary>
	[Serializable]
	public partial class CategoryEntityFactory : EntityFactoryBase<CategoryEntity>
	{
		/// <summary>CTor</summary>
		public CategoryEntityFactory() : base("CategoryEntity", SD.LLBLGen.Pro.Examples.EntityType.CategoryEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity CreateImpl() { return new CategoryEntity(); }
	}
	
	/// <summary>Factory to create new, empty CustomerEntity objects.</summary>
	[Serializable]
	public partial class CustomerEntityFactory : EntityFactoryBase<CustomerEntity>
	{
		/// <summary>CTor</summary>
		public CustomerEntityFactory() : base("CustomerEntity", SD.LLBLGen.Pro.Examples.EntityType.CustomerEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity CreateImpl() { return new CustomerEntity(); }
	}
	
	/// <summary>Factory to create new, empty CustomerCustomerDemoEntity objects.</summary>
	[Serializable]
	public partial class CustomerCustomerDemoEntityFactory : EntityFactoryBase<CustomerCustomerDemoEntity>
	{
		/// <summary>CTor</summary>
		public CustomerCustomerDemoEntityFactory() : base("CustomerCustomerDemoEntity", SD.LLBLGen.Pro.Examples.EntityType.CustomerCustomerDemoEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity CreateImpl() { return new CustomerCustomerDemoEntity(); }
	}
	
	/// <summary>Factory to create new, empty CustomerDemographyEntity objects.</summary>
	[Serializable]
	public partial class CustomerDemographyEntityFactory : EntityFactoryBase<CustomerDemographyEntity>
	{
		/// <summary>CTor</summary>
		public CustomerDemographyEntityFactory() : base("CustomerDemographyEntity", SD.LLBLGen.Pro.Examples.EntityType.CustomerDemographyEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity CreateImpl() { return new CustomerDemographyEntity(); }
	}
	
	/// <summary>Factory to create new, empty EmployeeEntity objects.</summary>
	[Serializable]
	public partial class EmployeeEntityFactory : EntityFactoryBase<EmployeeEntity>
	{
		/// <summary>CTor</summary>
		public EmployeeEntityFactory() : base("EmployeeEntity", SD.LLBLGen.Pro.Examples.EntityType.EmployeeEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity CreateImpl() { return new EmployeeEntity(); }
	}
	
	/// <summary>Factory to create new, empty EmployeeTerritoryEntity objects.</summary>
	[Serializable]
	public partial class EmployeeTerritoryEntityFactory : EntityFactoryBase<EmployeeTerritoryEntity>
	{
		/// <summary>CTor</summary>
		public EmployeeTerritoryEntityFactory() : base("EmployeeTerritoryEntity", SD.LLBLGen.Pro.Examples.EntityType.EmployeeTerritoryEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity CreateImpl() { return new EmployeeTerritoryEntity(); }
	}
	
	/// <summary>Factory to create new, empty OrderEntity objects.</summary>
	[Serializable]
	public partial class OrderEntityFactory : EntityFactoryBase<OrderEntity>
	{
		/// <summary>CTor</summary>
		public OrderEntityFactory() : base("OrderEntity", SD.LLBLGen.Pro.Examples.EntityType.OrderEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity CreateImpl() { return new OrderEntity(); }
	}
	
	/// <summary>Factory to create new, empty OrderDetailEntity objects.</summary>
	[Serializable]
	public partial class OrderDetailEntityFactory : EntityFactoryBase<OrderDetailEntity>
	{
		/// <summary>CTor</summary>
		public OrderDetailEntityFactory() : base("OrderDetailEntity", SD.LLBLGen.Pro.Examples.EntityType.OrderDetailEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity CreateImpl() { return new OrderDetailEntity(); }
	}
	
	/// <summary>Factory to create new, empty ProductEntity objects.</summary>
	[Serializable]
	public partial class ProductEntityFactory : EntityFactoryBase<ProductEntity>
	{
		/// <summary>CTor</summary>
		public ProductEntityFactory() : base("ProductEntity", SD.LLBLGen.Pro.Examples.EntityType.ProductEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity CreateImpl() { return new ProductEntity(); }
	}
	
	/// <summary>Factory to create new, empty RegionEntity objects.</summary>
	[Serializable]
	public partial class RegionEntityFactory : EntityFactoryBase<RegionEntity>
	{
		/// <summary>CTor</summary>
		public RegionEntityFactory() : base("RegionEntity", SD.LLBLGen.Pro.Examples.EntityType.RegionEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity CreateImpl() { return new RegionEntity(); }
	}
	
	/// <summary>Factory to create new, empty ShipperEntity objects.</summary>
	[Serializable]
	public partial class ShipperEntityFactory : EntityFactoryBase<ShipperEntity>
	{
		/// <summary>CTor</summary>
		public ShipperEntityFactory() : base("ShipperEntity", SD.LLBLGen.Pro.Examples.EntityType.ShipperEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity CreateImpl() { return new ShipperEntity(); }
	}
	
	/// <summary>Factory to create new, empty SupplierEntity objects.</summary>
	[Serializable]
	public partial class SupplierEntityFactory : EntityFactoryBase<SupplierEntity>
	{
		/// <summary>CTor</summary>
		public SupplierEntityFactory() : base("SupplierEntity", SD.LLBLGen.Pro.Examples.EntityType.SupplierEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity CreateImpl() { return new SupplierEntity(); }
	}
	
	/// <summary>Factory to create new, empty TerritoryEntity objects.</summary>
	[Serializable]
	public partial class TerritoryEntityFactory : EntityFactoryBase<TerritoryEntity>
	{
		/// <summary>CTor</summary>
		public TerritoryEntityFactory() : base("TerritoryEntity", SD.LLBLGen.Pro.Examples.EntityType.TerritoryEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity CreateImpl() { return new TerritoryEntity(); }
	}

	/// <summary>Factory to create new entity collection objects</summary>
	[Serializable]
	public partial class GeneralEntityCollectionFactory
	{
		/// <summary>Creates a new entity collection</summary>
		/// <param name="typeToUse">The entity type to create the collection for.</param>
		/// <returns>A new entity collection object.</returns>
		public static IEntityCollection Create(SD.LLBLGen.Pro.Examples.EntityType typeToUse)
		{
			switch(typeToUse)
			{
				case SD.LLBLGen.Pro.Examples.EntityType.CategoryEntity:
					return new CategoryCollection();
				case SD.LLBLGen.Pro.Examples.EntityType.CustomerEntity:
					return new CustomerCollection();
				case SD.LLBLGen.Pro.Examples.EntityType.CustomerCustomerDemoEntity:
					return new CustomerCustomerDemoCollection();
				case SD.LLBLGen.Pro.Examples.EntityType.CustomerDemographyEntity:
					return new CustomerDemographyCollection();
				case SD.LLBLGen.Pro.Examples.EntityType.EmployeeEntity:
					return new EmployeeCollection();
				case SD.LLBLGen.Pro.Examples.EntityType.EmployeeTerritoryEntity:
					return new EmployeeTerritoryCollection();
				case SD.LLBLGen.Pro.Examples.EntityType.OrderEntity:
					return new OrderCollection();
				case SD.LLBLGen.Pro.Examples.EntityType.OrderDetailEntity:
					return new OrderDetailCollection();
				case SD.LLBLGen.Pro.Examples.EntityType.ProductEntity:
					return new ProductCollection();
				case SD.LLBLGen.Pro.Examples.EntityType.RegionEntity:
					return new RegionCollection();
				case SD.LLBLGen.Pro.Examples.EntityType.ShipperEntity:
					return new ShipperCollection();
				case SD.LLBLGen.Pro.Examples.EntityType.SupplierEntity:
					return new SupplierCollection();
				case SD.LLBLGen.Pro.Examples.EntityType.TerritoryEntity:
					return new TerritoryCollection();
				default:
					return null;
			}
		}		
	}
	
	/// <summary>Factory to create new, empty Entity objects based on the entity type specified. Uses entity specific factory objects</summary>
	[Serializable]
	public partial class GeneralEntityFactory
	{
		/// <summary>Creates a new, empty Entity object of the type specified</summary>
		/// <param name="entityTypeToCreate">The entity type to create.</param>
		/// <returns>A new, empty Entity object.</returns>
		public static IEntity Create(SD.LLBLGen.Pro.Examples.EntityType entityTypeToCreate)
		{
			var factoryToUse = EntityFactoryFactory.GetFactory(entityTypeToCreate);
			IEntity toReturn = null;
			if(factoryToUse != null)
			{
				toReturn = factoryToUse.Create();
			}
			return toReturn;
		}		
	}
	
	/// <summary>Class which is used to obtain the entity factory based on the .NET type of the entity. </summary>
	[Serializable]
	public static class EntityFactoryFactory
	{
		private static readonly Dictionary<Type, IEntityFactory> _factoryPerType = new Dictionary<Type, IEntityFactory>();

		/// <summary>Initializes the <see cref="EntityFactoryFactory"/> class.</summary>
		static EntityFactoryFactory()
		{
			foreach(int entityTypeValue in Enum.GetValues(typeof(SD.LLBLGen.Pro.Examples.EntityType)))
			{
				var factory = GetFactory((SD.LLBLGen.Pro.Examples.EntityType)entityTypeValue);
				_factoryPerType.Add((factory.ForEntityType ?? factory.Create().GetType()), factory);
			}
		}

		/// <summary>Gets the factory of the entity with the .NET type specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(Type typeOfEntity) { return _factoryPerType.GetValue(typeOfEntity);	}

		/// <summary>Gets the factory of the entity with the SD.LLBLGen.Pro.Examples.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(SD.LLBLGen.Pro.Examples.EntityType typeOfEntity)
		{
			switch(typeOfEntity)
			{
				case SD.LLBLGen.Pro.Examples.EntityType.CategoryEntity:
					return new CategoryEntityFactory();
				case SD.LLBLGen.Pro.Examples.EntityType.CustomerEntity:
					return new CustomerEntityFactory();
				case SD.LLBLGen.Pro.Examples.EntityType.CustomerCustomerDemoEntity:
					return new CustomerCustomerDemoEntityFactory();
				case SD.LLBLGen.Pro.Examples.EntityType.CustomerDemographyEntity:
					return new CustomerDemographyEntityFactory();
				case SD.LLBLGen.Pro.Examples.EntityType.EmployeeEntity:
					return new EmployeeEntityFactory();
				case SD.LLBLGen.Pro.Examples.EntityType.EmployeeTerritoryEntity:
					return new EmployeeTerritoryEntityFactory();
				case SD.LLBLGen.Pro.Examples.EntityType.OrderEntity:
					return new OrderEntityFactory();
				case SD.LLBLGen.Pro.Examples.EntityType.OrderDetailEntity:
					return new OrderDetailEntityFactory();
				case SD.LLBLGen.Pro.Examples.EntityType.ProductEntity:
					return new ProductEntityFactory();
				case SD.LLBLGen.Pro.Examples.EntityType.RegionEntity:
					return new RegionEntityFactory();
				case SD.LLBLGen.Pro.Examples.EntityType.ShipperEntity:
					return new ShipperEntityFactory();
				case SD.LLBLGen.Pro.Examples.EntityType.SupplierEntity:
					return new SupplierEntityFactory();
				case SD.LLBLGen.Pro.Examples.EntityType.TerritoryEntity:
					return new TerritoryEntityFactory();
				default:
					return null;
			}
		}
	}
	
	/// <summary>Element creator for creating project elements from somewhere else, like inside Linq providers.</summary>
	public class ElementCreator : ElementCreatorBase, IElementCreator
	{
		/// <summary>Gets the factory of the Entity type with the SD.LLBLGen.Pro.Examples.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory GetFactory(int entityTypeValue) { return (IEntityFactory)this.GetFactoryImpl(entityTypeValue); }

		/// <summary>Gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory GetFactory(Type typeOfEntity) { return (IEntityFactory)this.GetFactoryImpl(typeOfEntity); }

		/// <summary>Creates a new resultset fields object with the number of field slots reserved as specified</summary>
		/// <param name="numberOfFields">The number of fields.</param>
		/// <returns>ready to use resultsetfields object</returns>
		public IEntityFields CreateResultsetFields(int numberOfFields) { return new ResultsetFields(numberOfFields); }
		
		/// <summary>Gets an instance of the TypedListDAO class to execute dynamic lists and projections.</summary>
		/// <returns>ready to use typedlistDAO</returns>
		public IDao GetTypedListDao() { return new TypedListDAO(); }
		
		/// <inheritdoc/>
		public override IInheritanceInfoProvider ObtainInheritanceInfoProviderInstance()
		{
			return ModelInfoProviderSingleton.GetInstance();
		}

		/// <inheritdoc/>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand) { return new DynamicRelation(leftOperand); }

		/// <inheritdoc/>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, onClause);
		}

		/// <inheritdoc/>
		public override IDynamicRelation CreateDynamicRelation(IEntityFieldCore leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, string aliasLeftOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, aliasLeftOperand, onClause);
		}

		/// <inheritdoc/>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (SD.LLBLGen.Pro.Examples.EntityType)Enum.Parse(typeof(SD.LLBLGen.Pro.Examples.EntityType), rightOperandEntityName, false), aliasRightOperand, onClause);
		}

		/// <inheritdoc/>
		public override IDynamicRelation CreateDynamicRelation(string leftOperandEntityName, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation((SD.LLBLGen.Pro.Examples.EntityType)Enum.Parse(typeof(SD.LLBLGen.Pro.Examples.EntityType), leftOperandEntityName, false), joinType, (SD.LLBLGen.Pro.Examples.EntityType)Enum.Parse(typeof(SD.LLBLGen.Pro.Examples.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <inheritdoc/>
		public override IDynamicRelation CreateDynamicRelation(IEntityFieldCore leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (SD.LLBLGen.Pro.Examples.EntityType)Enum.Parse(typeof(SD.LLBLGen.Pro.Examples.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <inheritdoc/>
		protected override IEntityFactoryCore GetFactoryImpl(int entityTypeValue) {	return EntityFactoryFactory.GetFactory((SD.LLBLGen.Pro.Examples.EntityType)entityTypeValue); }
	
		/// <inheritdoc/>
		protected override IEntityFactoryCore GetFactoryImpl(Type typeOfEntity) { return EntityFactoryFactory.GetFactory(typeOfEntity);	}

	}
}
