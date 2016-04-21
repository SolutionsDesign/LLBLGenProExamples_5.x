///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: donderdag 21 april 2016 12:49:00
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Linq;
using System.Collections.Generic;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

using SD.LLBLGen.Pro.Examples;
using SD.LLBLGen.Pro.Examples.DaoClasses;
using SD.LLBLGen.Pro.Examples.EntityClasses;
using SD.LLBLGen.Pro.Examples.FactoryClasses;
using SD.LLBLGen.Pro.Examples.HelperClasses;
using SD.LLBLGen.Pro.Examples.RelationClasses;

namespace SD.LLBLGen.Pro.Examples.Linq
{
	/// <summary>Meta-data class for the construction of Linq queries which are to be executed using LLBLGen Pro code.</summary>
	public partial class LinqMetaData : ILinqMetaData
	{
		#region Class Member Declarations
		private ITransaction _transactionToUse;
		private FunctionMappingStore _customFunctionMappings;
		private Context _contextToUse;
		#endregion
		
		/// <summary>CTor. Using this ctor will leave the transaction object to use empty. This is ok if you're not executing queries created with this
		/// meta data inside a transaction. If you're executing the queries created with this meta-data inside a transaction, either set the Transaction property
		/// on the IQueryable.Provider instance of the created LLBLGenProQuery object prior to execution or use the ctor which accepts a transaction object.</summary>
		public LinqMetaData() : this(null, null)
		{
		}
		
		/// <summary>CTor. If you're executing the queries created with this meta-data inside a transaction, pass a live ITransaction object to this ctor.</summary>
		/// <param name="transactionToUse">the transaction to use in queries created with this meta-data</param>
		/// <remarks> Be aware that the ITransaction object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(ITransaction transactionToUse) : this(transactionToUse, null)
		{
		}
		
		/// <summary>CTor. If you're executing the queries created with this meta-data inside a transaction, pass a live ITransaction object to this ctor.</summary>
		/// <param name="transactionToUse">the transaction to use in queries created with this meta-data</param>
		/// <param name="customFunctionMappings">The custom function mappings to use. These take higher precedence than the ones in the DQE to use.</param>
		/// <remarks> Be aware that the ITransaction object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(ITransaction transactionToUse, FunctionMappingStore customFunctionMappings)
		{
			_transactionToUse = transactionToUse;
			_customFunctionMappings = customFunctionMappings;
		}
		
		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <param name="typeOfEntity">the type of the entity to get the datasource for</param>
		/// <returns>the requested datasource</returns>
		public IDataSource GetQueryableForEntity(int typeOfEntity)
		{
			IDataSource toReturn = null;
			switch((SD.LLBLGen.Pro.Examples.EntityType)typeOfEntity)
			{
				case SD.LLBLGen.Pro.Examples.EntityType.CategoryEntity:
					toReturn = this.Category;
					break;
				case SD.LLBLGen.Pro.Examples.EntityType.CustomerEntity:
					toReturn = this.Customer;
					break;
				case SD.LLBLGen.Pro.Examples.EntityType.CustomerCustomerDemoEntity:
					toReturn = this.CustomerCustomerDemo;
					break;
				case SD.LLBLGen.Pro.Examples.EntityType.CustomerDemographyEntity:
					toReturn = this.CustomerDemography;
					break;
				case SD.LLBLGen.Pro.Examples.EntityType.EmployeeEntity:
					toReturn = this.Employee;
					break;
				case SD.LLBLGen.Pro.Examples.EntityType.EmployeeTerritoryEntity:
					toReturn = this.EmployeeTerritory;
					break;
				case SD.LLBLGen.Pro.Examples.EntityType.OrderEntity:
					toReturn = this.Order;
					break;
				case SD.LLBLGen.Pro.Examples.EntityType.OrderDetailEntity:
					toReturn = this.OrderDetail;
					break;
				case SD.LLBLGen.Pro.Examples.EntityType.ProductEntity:
					toReturn = this.Product;
					break;
				case SD.LLBLGen.Pro.Examples.EntityType.RegionEntity:
					toReturn = this.Region;
					break;
				case SD.LLBLGen.Pro.Examples.EntityType.ShipperEntity:
					toReturn = this.Shipper;
					break;
				case SD.LLBLGen.Pro.Examples.EntityType.SupplierEntity:
					toReturn = this.Supplier;
					break;
				case SD.LLBLGen.Pro.Examples.EntityType.TerritoryEntity:
					toReturn = this.Territory;
					break;
				default:
					toReturn = null;
					break;
			}
			return toReturn;
		}

		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <typeparam name="TEntity">the type of the entity to get the datasource for</typeparam>
		/// <returns>the requested datasource</returns>
		public DataSource<TEntity> GetQueryableForEntity<TEntity>()
			    where TEntity : class
		{
    		return new DataSource<TEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse);
		}

		/// <summary>returns the datasource to use in a Linq query when targeting CategoryEntity instances in the database.</summary>
		public DataSource<CategoryEntity> Category
		{
			get { return new DataSource<CategoryEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting CustomerEntity instances in the database.</summary>
		public DataSource<CustomerEntity> Customer
		{
			get { return new DataSource<CustomerEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting CustomerCustomerDemoEntity instances in the database.</summary>
		public DataSource<CustomerCustomerDemoEntity> CustomerCustomerDemo
		{
			get { return new DataSource<CustomerCustomerDemoEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting CustomerDemographyEntity instances in the database.</summary>
		public DataSource<CustomerDemographyEntity> CustomerDemography
		{
			get { return new DataSource<CustomerDemographyEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting EmployeeEntity instances in the database.</summary>
		public DataSource<EmployeeEntity> Employee
		{
			get { return new DataSource<EmployeeEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting EmployeeTerritoryEntity instances in the database.</summary>
		public DataSource<EmployeeTerritoryEntity> EmployeeTerritory
		{
			get { return new DataSource<EmployeeTerritoryEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting OrderEntity instances in the database.</summary>
		public DataSource<OrderEntity> Order
		{
			get { return new DataSource<OrderEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting OrderDetailEntity instances in the database.</summary>
		public DataSource<OrderDetailEntity> OrderDetail
		{
			get { return new DataSource<OrderDetailEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ProductEntity instances in the database.</summary>
		public DataSource<ProductEntity> Product
		{
			get { return new DataSource<ProductEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting RegionEntity instances in the database.</summary>
		public DataSource<RegionEntity> Region
		{
			get { return new DataSource<RegionEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ShipperEntity instances in the database.</summary>
		public DataSource<ShipperEntity> Shipper
		{
			get { return new DataSource<ShipperEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting SupplierEntity instances in the database.</summary>
		public DataSource<SupplierEntity> Supplier
		{
			get { return new DataSource<SupplierEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting TerritoryEntity instances in the database.</summary>
		public DataSource<TerritoryEntity> Territory
		{
			get { return new DataSource<TerritoryEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}

		#region Class Property Declarations
		/// <summary> Gets / sets the ITransaction to use for the queries created with this meta data object.</summary>
		/// <remarks> Be aware that the ITransaction object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public ITransaction TransactionToUse
		{
			get { return _transactionToUse;}
			set { _transactionToUse = value;}
		}

		/// <summary>Gets or sets the custom function mappings to use. These take higher precedence than the ones in the DQE to use</summary>
		public FunctionMappingStore CustomFunctionMappings
		{
			get { return _customFunctionMappings; }
			set { _customFunctionMappings = value; }
		}
		
		/// <summary>Gets or sets the Context instance to use for entity fetches.</summary>
		public Context ContextToUse
		{
			get { return _contextToUse;}
			set { _contextToUse = value;}
		}
		#endregion
	}
}