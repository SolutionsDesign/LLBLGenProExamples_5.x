///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: donderdag 21 april 2016 12:49:00
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
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
	public partial class EntityFactoryBase : EntityFactoryCore
	{
		private readonly SD.LLBLGen.Pro.Examples.EntityType _typeOfEntity;
		
		/// <summary>CTor</summary>
		/// <param name="entityName">Name of the entity.</param>
		/// <param name="typeOfEntity">The type of entity.</param>
		public EntityFactoryBase(string entityName, SD.LLBLGen.Pro.Examples.EntityType typeOfEntity) : base(entityName)
		{
			_typeOfEntity = typeOfEntity;
		}

		/// <summary>Creates a new entity instance using the GeneralEntityFactory in the generated code, using the passed in entitytype value</summary>
		/// <param name="entityTypeValue">The entity type value of the entity to create an instance for.</param>
		/// <returns>new IEntity instance</returns>
		public override IEntity CreateEntityFromEntityTypeValue(int entityTypeValue)
		{
			return GeneralEntityFactory.Create((SD.LLBLGen.Pro.Examples.EntityType)entityTypeValue);
		}
		
		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public override IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(_typeOfEntity);
		}

		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <param name="objectAlias">The object alias to use for the elements in the relations.</param>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public override IRelationCollection CreateHierarchyRelations(string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetHierarchyRelations(ForEntityName, objectAlias);
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public override IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return (IEntityFactory)InheritanceInfoProviderSingleton.GetInstance().GetEntityFactory(ForEntityName, fieldValues, entityFieldStartIndexesPerEntity) ?? this;
		}
						
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public override IEntityCollection CreateEntityCollection()
		{
			return GeneralEntityCollectionFactory.Create(_typeOfEntity);
		}
	}
	
	/// <summary>Factory to create new, empty CategoryEntity objects.</summary>
	[Serializable]
	public partial class CategoryEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CategoryEntityFactory() : base("CategoryEntity", SD.LLBLGen.Pro.Examples.EntityType.CategoryEntity) { }

		/// <summary>Creates a new, empty CategoryEntity object.</summary>
		/// <returns>A new, empty CategoryEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CategoryEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCategory
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CustomerEntity objects.</summary>
	[Serializable]
	public partial class CustomerEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CustomerEntityFactory() : base("CustomerEntity", SD.LLBLGen.Pro.Examples.EntityType.CustomerEntity) { }

		/// <summary>Creates a new, empty CustomerEntity object.</summary>
		/// <returns>A new, empty CustomerEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CustomerEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCustomer
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CustomerCustomerDemoEntity objects.</summary>
	[Serializable]
	public partial class CustomerCustomerDemoEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CustomerCustomerDemoEntityFactory() : base("CustomerCustomerDemoEntity", SD.LLBLGen.Pro.Examples.EntityType.CustomerCustomerDemoEntity) { }

		/// <summary>Creates a new, empty CustomerCustomerDemoEntity object.</summary>
		/// <returns>A new, empty CustomerCustomerDemoEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CustomerCustomerDemoEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCustomerCustomerDemo
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CustomerDemographyEntity objects.</summary>
	[Serializable]
	public partial class CustomerDemographyEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CustomerDemographyEntityFactory() : base("CustomerDemographyEntity", SD.LLBLGen.Pro.Examples.EntityType.CustomerDemographyEntity) { }

		/// <summary>Creates a new, empty CustomerDemographyEntity object.</summary>
		/// <returns>A new, empty CustomerDemographyEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CustomerDemographyEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCustomerDemography
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty EmployeeEntity objects.</summary>
	[Serializable]
	public partial class EmployeeEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public EmployeeEntityFactory() : base("EmployeeEntity", SD.LLBLGen.Pro.Examples.EntityType.EmployeeEntity) { }

		/// <summary>Creates a new, empty EmployeeEntity object.</summary>
		/// <returns>A new, empty EmployeeEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new EmployeeEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEmployee
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty EmployeeTerritoryEntity objects.</summary>
	[Serializable]
	public partial class EmployeeTerritoryEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public EmployeeTerritoryEntityFactory() : base("EmployeeTerritoryEntity", SD.LLBLGen.Pro.Examples.EntityType.EmployeeTerritoryEntity) { }

		/// <summary>Creates a new, empty EmployeeTerritoryEntity object.</summary>
		/// <returns>A new, empty EmployeeTerritoryEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new EmployeeTerritoryEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEmployeeTerritory
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty OrderEntity objects.</summary>
	[Serializable]
	public partial class OrderEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public OrderEntityFactory() : base("OrderEntity", SD.LLBLGen.Pro.Examples.EntityType.OrderEntity) { }

		/// <summary>Creates a new, empty OrderEntity object.</summary>
		/// <returns>A new, empty OrderEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new OrderEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewOrder
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty OrderDetailEntity objects.</summary>
	[Serializable]
	public partial class OrderDetailEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public OrderDetailEntityFactory() : base("OrderDetailEntity", SD.LLBLGen.Pro.Examples.EntityType.OrderDetailEntity) { }

		/// <summary>Creates a new, empty OrderDetailEntity object.</summary>
		/// <returns>A new, empty OrderDetailEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new OrderDetailEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewOrderDetail
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ProductEntity objects.</summary>
	[Serializable]
	public partial class ProductEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ProductEntityFactory() : base("ProductEntity", SD.LLBLGen.Pro.Examples.EntityType.ProductEntity) { }

		/// <summary>Creates a new, empty ProductEntity object.</summary>
		/// <returns>A new, empty ProductEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ProductEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProduct
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty RegionEntity objects.</summary>
	[Serializable]
	public partial class RegionEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public RegionEntityFactory() : base("RegionEntity", SD.LLBLGen.Pro.Examples.EntityType.RegionEntity) { }

		/// <summary>Creates a new, empty RegionEntity object.</summary>
		/// <returns>A new, empty RegionEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new RegionEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRegion
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ShipperEntity objects.</summary>
	[Serializable]
	public partial class ShipperEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ShipperEntityFactory() : base("ShipperEntity", SD.LLBLGen.Pro.Examples.EntityType.ShipperEntity) { }

		/// <summary>Creates a new, empty ShipperEntity object.</summary>
		/// <returns>A new, empty ShipperEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ShipperEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewShipper
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty SupplierEntity objects.</summary>
	[Serializable]
	public partial class SupplierEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public SupplierEntityFactory() : base("SupplierEntity", SD.LLBLGen.Pro.Examples.EntityType.SupplierEntity) { }

		/// <summary>Creates a new, empty SupplierEntity object.</summary>
		/// <returns>A new, empty SupplierEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new SupplierEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSupplier
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty TerritoryEntity objects.</summary>
	[Serializable]
	public partial class TerritoryEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public TerritoryEntityFactory() : base("TerritoryEntity", SD.LLBLGen.Pro.Examples.EntityType.TerritoryEntity) { }

		/// <summary>Creates a new, empty TerritoryEntity object.</summary>
		/// <returns>A new, empty TerritoryEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new TerritoryEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTerritory
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
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
			IEntityFactory factoryToUse = null;
			switch(entityTypeToCreate)
			{
				case SD.LLBLGen.Pro.Examples.EntityType.CategoryEntity:
					factoryToUse = new CategoryEntityFactory();
					break;
				case SD.LLBLGen.Pro.Examples.EntityType.CustomerEntity:
					factoryToUse = new CustomerEntityFactory();
					break;
				case SD.LLBLGen.Pro.Examples.EntityType.CustomerCustomerDemoEntity:
					factoryToUse = new CustomerCustomerDemoEntityFactory();
					break;
				case SD.LLBLGen.Pro.Examples.EntityType.CustomerDemographyEntity:
					factoryToUse = new CustomerDemographyEntityFactory();
					break;
				case SD.LLBLGen.Pro.Examples.EntityType.EmployeeEntity:
					factoryToUse = new EmployeeEntityFactory();
					break;
				case SD.LLBLGen.Pro.Examples.EntityType.EmployeeTerritoryEntity:
					factoryToUse = new EmployeeTerritoryEntityFactory();
					break;
				case SD.LLBLGen.Pro.Examples.EntityType.OrderEntity:
					factoryToUse = new OrderEntityFactory();
					break;
				case SD.LLBLGen.Pro.Examples.EntityType.OrderDetailEntity:
					factoryToUse = new OrderDetailEntityFactory();
					break;
				case SD.LLBLGen.Pro.Examples.EntityType.ProductEntity:
					factoryToUse = new ProductEntityFactory();
					break;
				case SD.LLBLGen.Pro.Examples.EntityType.RegionEntity:
					factoryToUse = new RegionEntityFactory();
					break;
				case SD.LLBLGen.Pro.Examples.EntityType.ShipperEntity:
					factoryToUse = new ShipperEntityFactory();
					break;
				case SD.LLBLGen.Pro.Examples.EntityType.SupplierEntity:
					factoryToUse = new SupplierEntityFactory();
					break;
				case SD.LLBLGen.Pro.Examples.EntityType.TerritoryEntity:
					factoryToUse = new TerritoryEntityFactory();
					break;
			}
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
			Array entityTypeValues = Enum.GetValues(typeof(SD.LLBLGen.Pro.Examples.EntityType));
			foreach(int entityTypeValue in entityTypeValues)
			{
				IEntity dummy = GeneralEntityFactory.Create((SD.LLBLGen.Pro.Examples.EntityType)entityTypeValue);
				_factoryPerType.Add(dummy.GetType(), dummy.GetEntityFactory());
			}
		}

		/// <summary>Gets the factory of the entity with the .NET type specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(Type typeOfEntity)
		{
			IEntityFactory toReturn = null;
			_factoryPerType.TryGetValue(typeOfEntity, out toReturn);
			return toReturn;
		}

		/// <summary>Gets the factory of the entity with the SD.LLBLGen.Pro.Examples.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(SD.LLBLGen.Pro.Examples.EntityType typeOfEntity)
		{
			return GetFactory(GeneralEntityFactory.Create(typeOfEntity).GetType());
		}
	}
	
	/// <summary>Element creator for creating project elements from somewhere else, like inside Linq providers.</summary>
	public class ElementCreator : ElementCreatorBase, IElementCreator
	{
		/// <summary>Gets the factory of the Entity type with the SD.LLBLGen.Pro.Examples.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory GetFactory(int entityTypeValue)
		{
			return (IEntityFactory)this.GetFactoryImpl(entityTypeValue);
		}

		/// <summary>Gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory GetFactory(Type typeOfEntity)
		{
			return (IEntityFactory)this.GetFactoryImpl(typeOfEntity);
		}

		/// <summary>Creates a new resultset fields object with the number of field slots reserved as specified</summary>
		/// <param name="numberOfFields">The number of fields.</param>
		/// <returns>ready to use resultsetfields object</returns>
		public IEntityFields CreateResultsetFields(int numberOfFields)
		{
			return new ResultsetFields(numberOfFields);
		}
		
		/// <summary>Gets an instance of the TypedListDAO class to execute dynamic lists and projections.</summary>
		/// <returns>ready to use typedlistDAO</returns>
		public IDao GetTypedListDao()
		{
			return new TypedListDAO();
		}
		
		/// <summary>Obtains the inheritance info provider instance from the singleton </summary>
		/// <returns>The singleton instance of the inheritance info provider</returns>
		public override IInheritanceInfoProvider ObtainInheritanceInfoProviderInstance()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}


		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand)
		{
			return new DynamicRelation(leftOperand);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperand">The right operand.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperand">The right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(IEntityFieldCore leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, string aliasLeftOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, aliasLeftOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (SD.LLBLGen.Pro.Examples.EntityType)Enum.Parse(typeof(SD.LLBLGen.Pro.Examples.EntityType), rightOperandEntityName, false), aliasRightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperandEntityName">Name of the entity which is used as the left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(string leftOperandEntityName, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation((SD.LLBLGen.Pro.Examples.EntityType)Enum.Parse(typeof(SD.LLBLGen.Pro.Examples.EntityType), leftOperandEntityName, false), joinType, (SD.LLBLGen.Pro.Examples.EntityType)Enum.Parse(typeof(SD.LLBLGen.Pro.Examples.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(IEntityFieldCore leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (SD.LLBLGen.Pro.Examples.EntityType)Enum.Parse(typeof(SD.LLBLGen.Pro.Examples.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the SD.LLBLGen.Pro.Examples.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(int entityTypeValue)
		{
			return EntityFactoryFactory.GetFactory((SD.LLBLGen.Pro.Examples.EntityType)entityTypeValue);
		}
	
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(Type typeOfEntity)
		{
			return EntityFactoryFactory.GetFactory(typeOfEntity);
		}

	}
}
