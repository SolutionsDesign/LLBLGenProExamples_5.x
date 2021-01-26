﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.8.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Linq;
using System.Collections.Generic;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NWService.Dal.EntityClasses;
using NWService.Dal.FactoryClasses;

namespace NWService.Dal.Linq
{
	/// <summary>Meta-data class for the construction of Linq queries which are to be executed using LLBLGen Pro code.</summary>
	public partial class LinqMetaData: ILinqMetaData
	{
		/// <summary>CTor. Using this ctor will leave the IDataAccessAdapter object to use empty. To be able to execute the query, an IDataAccessAdapter instance
		/// is required, and has to be set on the LLBLGenProProvider2 object in the query to execute. </summary>
		public LinqMetaData() : this(null, null) { }
		
		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse) : this (adapterToUse, null) { }

		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <param name="customFunctionMappings">The custom function mappings to use. These take higher precedence than the ones in the DQE to use.</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse, FunctionMappingStore customFunctionMappings)
		{
			this.AdapterToUse = adapterToUse;
			this.CustomFunctionMappings = customFunctionMappings;
		}
	
		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <param name="typeOfEntity">the type of the entity to get the datasource for</param>
		/// <returns>the requested datasource</returns>
		public IDataSource GetQueryableForEntity(int typeOfEntity)
		{
			switch((NWService.Dal.EntityType)typeOfEntity)
			{
				case NWService.Dal.EntityType.CategoryEntity:
					return this.Category;
				case NWService.Dal.EntityType.CustomerEntity:
					return this.Customer;
				case NWService.Dal.EntityType.EmployeeEntity:
					return this.Employee;
				case NWService.Dal.EntityType.OrderEntity:
					return this.Order;
				case NWService.Dal.EntityType.OrderDetailEntity:
					return this.OrderDetail;
				case NWService.Dal.EntityType.ProductEntity:
					return this.Product;
				case NWService.Dal.EntityType.RegionEntity:
					return this.Region;
				case NWService.Dal.EntityType.ShipperEntity:
					return this.Shipper;
				case NWService.Dal.EntityType.SupplierEntity:
					return this.Supplier;
				case NWService.Dal.EntityType.TerritoryEntity:
					return this.Territory;
				default:
					return null;
			}
		}

		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <typeparam name="TEntity">the type of the entity to get the datasource for</typeparam>
		/// <returns>the requested datasource</returns>
		public DataSource2<TEntity> GetQueryableForEntity<TEntity>()
				where TEntity : class
		{
			return new DataSource2<TEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse);
		}

		/// <summary>returns the datasource to use in a Linq query when targeting CategoryEntity instances in the database.</summary>
		public DataSource2<CategoryEntity> Category {	get { return new DataSource2<CategoryEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting CustomerEntity instances in the database.</summary>
		public DataSource2<CustomerEntity> Customer {	get { return new DataSource2<CustomerEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting EmployeeEntity instances in the database.</summary>
		public DataSource2<EmployeeEntity> Employee {	get { return new DataSource2<EmployeeEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting OrderEntity instances in the database.</summary>
		public DataSource2<OrderEntity> Order {	get { return new DataSource2<OrderEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting OrderDetailEntity instances in the database.</summary>
		public DataSource2<OrderDetailEntity> OrderDetail {	get { return new DataSource2<OrderDetailEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductEntity instances in the database.</summary>
		public DataSource2<ProductEntity> Product {	get { return new DataSource2<ProductEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting RegionEntity instances in the database.</summary>
		public DataSource2<RegionEntity> Region {	get { return new DataSource2<RegionEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ShipperEntity instances in the database.</summary>
		public DataSource2<ShipperEntity> Shipper {	get { return new DataSource2<ShipperEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting SupplierEntity instances in the database.</summary>
		public DataSource2<SupplierEntity> Supplier {	get { return new DataSource2<SupplierEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting TerritoryEntity instances in the database.</summary>
		public DataSource2<TerritoryEntity> Territory {	get { return new DataSource2<TerritoryEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		


		/// <summary> Gets / sets the IDataAccessAdapter to use for the queries created with this meta data object.</summary>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public IDataAccessAdapter AdapterToUse { get; set; }
		
		/// <summary>Gets or sets the custom function mappings to use. These take higher precedence than the ones in the DQE to use</summary>
		public FunctionMappingStore CustomFunctionMappings { get; set; }
		
		/// <summary>Gets or sets the Context instance to use for entity fetches.</summary>
		public Context ContextToUse { get; set; }
	}
}