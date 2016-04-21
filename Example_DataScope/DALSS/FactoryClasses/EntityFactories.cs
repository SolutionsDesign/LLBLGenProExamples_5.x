///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using Northwind.SSDAL.HelperClasses;
using Northwind.SSDAL.RelationClasses;
using Northwind.SSDAL.DaoClasses;

using Northwind.SSDAL.EntityClasses;
using Northwind.SSDAL.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.SSDAL.FactoryClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>general base class for the generated factories</summary>
	[Serializable]
	public partial class EntityFactoryBase : EntityFactoryCore
	{
		private readonly Northwind.SSDAL.EntityType _typeOfEntity;
		
		/// <summary>CTor</summary>
		/// <param name="entityName">Name of the entity.</param>
		/// <param name="typeOfEntity">The type of entity.</param>
		public EntityFactoryBase(string entityName, Northwind.SSDAL.EntityType typeOfEntity) : base(entityName)
		{
			_typeOfEntity = typeOfEntity;
		}

		/// <summary>Creates a new entity instance using the GeneralEntityFactory in the generated code, using the passed in entitytype value</summary>
		/// <param name="entityTypeValue">The entity type value of the entity to create an instance for.</param>
		/// <returns>new IEntity instance</returns>
		public override IEntity CreateEntityFromEntityTypeValue(int entityTypeValue)
		{
			return GeneralEntityFactory.Create((Northwind.SSDAL.EntityType)entityTypeValue);
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
	
	/// <summary>Factory to create new, empty AuditActionTypeEntity objects.</summary>
	[Serializable]
	public partial class AuditActionTypeEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public AuditActionTypeEntityFactory() : base("AuditActionTypeEntity", Northwind.SSDAL.EntityType.AuditActionTypeEntity) { }

		/// <summary>Creates a new, empty AuditActionTypeEntity object.</summary>
		/// <returns>A new, empty AuditActionTypeEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new AuditActionTypeEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAuditActionType
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty AuditInfoEntity objects.</summary>
	[Serializable]
	public partial class AuditInfoEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public AuditInfoEntityFactory() : base("AuditInfoEntity", Northwind.SSDAL.EntityType.AuditInfoEntity) { }

		/// <summary>Creates a new, empty AuditInfoEntity object.</summary>
		/// <returns>A new, empty AuditInfoEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new AuditInfoEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAuditInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public override IEntityFields CreateHierarchyFields()
		{
			return new EntityFields(InheritanceInfoProviderSingleton.GetInstance().GetHierarchyFields("AuditInfoEntity"), InheritanceInfoProviderSingleton.GetInstance(), null);
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CategoryEntity objects.</summary>
	[Serializable]
	public partial class CategoryEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CategoryEntityFactory() : base("CategoryEntity", Northwind.SSDAL.EntityType.CategoryEntity) { }

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
		public CustomerEntityFactory() : base("CustomerEntity", Northwind.SSDAL.EntityType.CustomerEntity) { }

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
		public CustomerCustomerDemoEntityFactory() : base("CustomerCustomerDemoEntity", Northwind.SSDAL.EntityType.CustomerCustomerDemoEntity) { }

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
	
	/// <summary>Factory to create new, empty CustomerDemographicEntity objects.</summary>
	[Serializable]
	public partial class CustomerDemographicEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CustomerDemographicEntityFactory() : base("CustomerDemographicEntity", Northwind.SSDAL.EntityType.CustomerDemographicEntity) { }

		/// <summary>Creates a new, empty CustomerDemographicEntity object.</summary>
		/// <returns>A new, empty CustomerDemographicEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CustomerDemographicEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCustomerDemographic
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
		public EmployeeEntityFactory() : base("EmployeeEntity", Northwind.SSDAL.EntityType.EmployeeEntity) { }

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
		public EmployeeTerritoryEntityFactory() : base("EmployeeTerritoryEntity", Northwind.SSDAL.EntityType.EmployeeTerritoryEntity) { }

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
	
	/// <summary>Factory to create new, empty GroupEntity objects.</summary>
	[Serializable]
	public partial class GroupEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public GroupEntityFactory() : base("GroupEntity", Northwind.SSDAL.EntityType.GroupEntity) { }

		/// <summary>Creates a new, empty GroupEntity object.</summary>
		/// <returns>A new, empty GroupEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new GroupEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewGroup
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
		public OrderEntityFactory() : base("OrderEntity", Northwind.SSDAL.EntityType.OrderEntity) { }

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
	
	/// <summary>Factory to create new, empty OrderAuditInfoEntity objects.</summary>
	[Serializable]
	public partial class OrderAuditInfoEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public OrderAuditInfoEntityFactory() : base("OrderAuditInfoEntity", Northwind.SSDAL.EntityType.OrderAuditInfoEntity) { }

		/// <summary>Creates a new, empty OrderAuditInfoEntity object.</summary>
		/// <returns>A new, empty OrderAuditInfoEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new OrderAuditInfoEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewOrderAuditInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public override IEntityFields CreateHierarchyFields()
		{
			return new EntityFields(InheritanceInfoProviderSingleton.GetInstance().GetHierarchyFields("OrderAuditInfoEntity"), InheritanceInfoProviderSingleton.GetInstance(), null);
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty OrderDetailEntity objects.</summary>
	[Serializable]
	public partial class OrderDetailEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public OrderDetailEntityFactory() : base("OrderDetailEntity", Northwind.SSDAL.EntityType.OrderDetailEntity) { }

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
		public ProductEntityFactory() : base("ProductEntity", Northwind.SSDAL.EntityType.ProductEntity) { }

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
		public RegionEntityFactory() : base("RegionEntity", Northwind.SSDAL.EntityType.RegionEntity) { }

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
		public ShipperEntityFactory() : base("ShipperEntity", Northwind.SSDAL.EntityType.ShipperEntity) { }

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
		public SupplierEntityFactory() : base("SupplierEntity", Northwind.SSDAL.EntityType.SupplierEntity) { }

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
		public TerritoryEntityFactory() : base("TerritoryEntity", Northwind.SSDAL.EntityType.TerritoryEntity) { }

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
	
	/// <summary>Factory to create new, empty UserEntity objects.</summary>
	[Serializable]
	public partial class UserEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public UserEntityFactory() : base("UserEntity", Northwind.SSDAL.EntityType.UserEntity) { }

		/// <summary>Creates a new, empty UserEntity object.</summary>
		/// <returns>A new, empty UserEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new UserEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUser
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty UserGroupEntity objects.</summary>
	[Serializable]
	public partial class UserGroupEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public UserGroupEntityFactory() : base("UserGroupEntity", Northwind.SSDAL.EntityType.UserGroupEntity) { }

		/// <summary>Creates a new, empty UserGroupEntity object.</summary>
		/// <returns>A new, empty UserGroupEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new UserGroupEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUserGroup
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
		public static IEntityCollection Create(Northwind.SSDAL.EntityType typeToUse)
		{
			switch(typeToUse)
			{
				case Northwind.SSDAL.EntityType.AuditActionTypeEntity:
					return new AuditActionTypeCollection();
				case Northwind.SSDAL.EntityType.AuditInfoEntity:
					return new AuditInfoCollection();
				case Northwind.SSDAL.EntityType.CategoryEntity:
					return new CategoryCollection();
				case Northwind.SSDAL.EntityType.CustomerEntity:
					return new CustomerCollection();
				case Northwind.SSDAL.EntityType.CustomerCustomerDemoEntity:
					return new CustomerCustomerDemoCollection();
				case Northwind.SSDAL.EntityType.CustomerDemographicEntity:
					return new CustomerDemographicCollection();
				case Northwind.SSDAL.EntityType.EmployeeEntity:
					return new EmployeeCollection();
				case Northwind.SSDAL.EntityType.EmployeeTerritoryEntity:
					return new EmployeeTerritoryCollection();
				case Northwind.SSDAL.EntityType.GroupEntity:
					return new GroupCollection();
				case Northwind.SSDAL.EntityType.OrderEntity:
					return new OrderCollection();
				case Northwind.SSDAL.EntityType.OrderAuditInfoEntity:
					return new OrderAuditInfoCollection();
				case Northwind.SSDAL.EntityType.OrderDetailEntity:
					return new OrderDetailCollection();
				case Northwind.SSDAL.EntityType.ProductEntity:
					return new ProductCollection();
				case Northwind.SSDAL.EntityType.RegionEntity:
					return new RegionCollection();
				case Northwind.SSDAL.EntityType.ShipperEntity:
					return new ShipperCollection();
				case Northwind.SSDAL.EntityType.SupplierEntity:
					return new SupplierCollection();
				case Northwind.SSDAL.EntityType.TerritoryEntity:
					return new TerritoryCollection();
				case Northwind.SSDAL.EntityType.UserEntity:
					return new UserCollection();
				case Northwind.SSDAL.EntityType.UserGroupEntity:
					return new UserGroupCollection();
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
		public static IEntity Create(Northwind.SSDAL.EntityType entityTypeToCreate)
		{
			IEntityFactory factoryToUse = null;
			switch(entityTypeToCreate)
			{
				case Northwind.SSDAL.EntityType.AuditActionTypeEntity:
					factoryToUse = new AuditActionTypeEntityFactory();
					break;
				case Northwind.SSDAL.EntityType.AuditInfoEntity:
					factoryToUse = new AuditInfoEntityFactory();
					break;
				case Northwind.SSDAL.EntityType.CategoryEntity:
					factoryToUse = new CategoryEntityFactory();
					break;
				case Northwind.SSDAL.EntityType.CustomerEntity:
					factoryToUse = new CustomerEntityFactory();
					break;
				case Northwind.SSDAL.EntityType.CustomerCustomerDemoEntity:
					factoryToUse = new CustomerCustomerDemoEntityFactory();
					break;
				case Northwind.SSDAL.EntityType.CustomerDemographicEntity:
					factoryToUse = new CustomerDemographicEntityFactory();
					break;
				case Northwind.SSDAL.EntityType.EmployeeEntity:
					factoryToUse = new EmployeeEntityFactory();
					break;
				case Northwind.SSDAL.EntityType.EmployeeTerritoryEntity:
					factoryToUse = new EmployeeTerritoryEntityFactory();
					break;
				case Northwind.SSDAL.EntityType.GroupEntity:
					factoryToUse = new GroupEntityFactory();
					break;
				case Northwind.SSDAL.EntityType.OrderEntity:
					factoryToUse = new OrderEntityFactory();
					break;
				case Northwind.SSDAL.EntityType.OrderAuditInfoEntity:
					factoryToUse = new OrderAuditInfoEntityFactory();
					break;
				case Northwind.SSDAL.EntityType.OrderDetailEntity:
					factoryToUse = new OrderDetailEntityFactory();
					break;
				case Northwind.SSDAL.EntityType.ProductEntity:
					factoryToUse = new ProductEntityFactory();
					break;
				case Northwind.SSDAL.EntityType.RegionEntity:
					factoryToUse = new RegionEntityFactory();
					break;
				case Northwind.SSDAL.EntityType.ShipperEntity:
					factoryToUse = new ShipperEntityFactory();
					break;
				case Northwind.SSDAL.EntityType.SupplierEntity:
					factoryToUse = new SupplierEntityFactory();
					break;
				case Northwind.SSDAL.EntityType.TerritoryEntity:
					factoryToUse = new TerritoryEntityFactory();
					break;
				case Northwind.SSDAL.EntityType.UserEntity:
					factoryToUse = new UserEntityFactory();
					break;
				case Northwind.SSDAL.EntityType.UserGroupEntity:
					factoryToUse = new UserGroupEntityFactory();
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
			Array entityTypeValues = Enum.GetValues(typeof(Northwind.SSDAL.EntityType));
			foreach(int entityTypeValue in entityTypeValues)
			{
				IEntity dummy = GeneralEntityFactory.Create((Northwind.SSDAL.EntityType)entityTypeValue);
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

		/// <summary>Gets the factory of the entity with the Northwind.SSDAL.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(Northwind.SSDAL.EntityType typeOfEntity)
		{
			return GetFactory(GeneralEntityFactory.Create(typeOfEntity).GetType());
		}
	}
	
	/// <summary>Element creator for creating project elements from somewhere else, like inside Linq providers.</summary>
	public class ElementCreator : ElementCreatorBase, IElementCreator
	{
		/// <summary>Gets the factory of the Entity type with the Northwind.SSDAL.EntityType value passed in</summary>
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
			return new DynamicRelation(leftOperand, joinType, (Northwind.SSDAL.EntityType)Enum.Parse(typeof(Northwind.SSDAL.EntityType), rightOperandEntityName, false), aliasRightOperand, onClause);
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
			return new DynamicRelation((Northwind.SSDAL.EntityType)Enum.Parse(typeof(Northwind.SSDAL.EntityType), leftOperandEntityName, false), joinType, (Northwind.SSDAL.EntityType)Enum.Parse(typeof(Northwind.SSDAL.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
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
			return new DynamicRelation(leftOperand, joinType, (Northwind.SSDAL.EntityType)Enum.Parse(typeof(Northwind.SSDAL.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the Northwind.SSDAL.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(int entityTypeValue)
		{
			return EntityFactoryFactory.GetFactory((Northwind.SSDAL.EntityType)entityTypeValue);
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
