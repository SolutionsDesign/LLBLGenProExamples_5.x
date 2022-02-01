﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: Tuesday, 1 February 2022 16:05:05
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.Examples.Auditing.EntityClasses;
using SD.LLBLGen.Pro.Examples.Auditing.HelperClasses;
using SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.Auditing.DaoClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>General DAO class for the Supplier Entity. It will perform database oriented actions for a entity of type 'SupplierEntity'.</summary>
	public partial class SupplierDAO : CommonDaoBase
	{
		/// <summary>CTor</summary>
		public SupplierDAO() : base(InheritanceHierarchyType.None, "SupplierEntity", new SupplierEntityFactory()) { }



		/// <summary>Retrieves in the calling SupplierCollection object all SupplierEntity objects which are related via a relation of type 'm:n' with the passed in CategoryEntity.</summary>
		/// <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or null if not.</param>
		/// <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. When set to 0, no limitations are specified.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="categoryInstance">CategoryEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiUsingCategoriesCollectionViaProducts(ITransaction containingTransaction, IEntityCollection collectionToFill, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IEntityFactory entityFactoryToUse, IEntity categoryInstance, IPrefetchPath prefetchPathToUse, int pageNumber, int pageSize)
		{
			var relations = new RelationCollection();
			relations.Add(SupplierEntity.Relations.ProductEntityUsingSupplierId, "Product_");
			relations.Add(ProductEntity.Relations.CategoryEntityUsingCategoryId, "Product_", string.Empty, JoinHint.None);
			var selectFilter = new PredicateExpression();
			selectFilter.Add(new FieldCompareValuePredicate(categoryInstance.Fields[(int)CategoryFieldIndex.CategoryId], ComparisonOperator.Equal));
			return this.GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse, pageNumber, pageSize);
		}



		// __LLBLGENPRO_USER_CODE_REGION_START CustomDAOCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}
