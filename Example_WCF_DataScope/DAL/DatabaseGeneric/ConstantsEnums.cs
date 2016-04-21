///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: donderdag 21 april 2016 15:04:54
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;

namespace SD.LLBLGen.Pro.Examples.WCF
{
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Category.</summary>
	public enum CategoryFieldIndex
	{
		///<summary>CategoryId. </summary>
		CategoryId,
		///<summary>CategoryName. </summary>
		CategoryName,
		///<summary>Description. </summary>
		Description,
		///<summary>Picture. </summary>
		Picture,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Customer.</summary>
	public enum CustomerFieldIndex
	{
		///<summary>Address. </summary>
		Address,
		///<summary>City. </summary>
		City,
		///<summary>CompanyName. </summary>
		CompanyName,
		///<summary>ContactName. </summary>
		ContactName,
		///<summary>ContactTitle. </summary>
		ContactTitle,
		///<summary>Country. </summary>
		Country,
		///<summary>CustomerId. </summary>
		CustomerId,
		///<summary>Fax. </summary>
		Fax,
		///<summary>Phone. </summary>
		Phone,
		///<summary>PostalCode. </summary>
		PostalCode,
		///<summary>Region. </summary>
		Region,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Employee.</summary>
	public enum EmployeeFieldIndex
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
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Order.</summary>
	public enum OrderFieldIndex
	{
		///<summary>CustomerId. </summary>
		CustomerId,
		///<summary>EmployeeId. </summary>
		EmployeeId,
		///<summary>Freight. </summary>
		Freight,
		///<summary>OrderDate. </summary>
		OrderDate,
		///<summary>OrderId. </summary>
		OrderId,
		///<summary>RequiredDate. </summary>
		RequiredDate,
		///<summary>ShipAddress. </summary>
		ShipAddress,
		///<summary>ShipCity. </summary>
		ShipCity,
		///<summary>ShipCountry. </summary>
		ShipCountry,
		///<summary>ShipName. </summary>
		ShipName,
		///<summary>ShippedDate. </summary>
		ShippedDate,
		///<summary>ShipPostalCode. </summary>
		ShipPostalCode,
		///<summary>ShipRegion. </summary>
		ShipRegion,
		///<summary>ShipVia. </summary>
		ShipVia,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: OrderDetails.</summary>
	public enum OrderDetailsFieldIndex
	{
		///<summary>Discount. </summary>
		Discount,
		///<summary>OrderId. </summary>
		OrderId,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>Quantity. </summary>
		Quantity,
		///<summary>UnitPrice. </summary>
		UnitPrice,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Product.</summary>
	public enum ProductFieldIndex
	{
		///<summary>CategoryId. </summary>
		CategoryId,
		///<summary>Discontinued. </summary>
		Discontinued,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>ProductName. </summary>
		ProductName,
		///<summary>QuantityPerUnit. </summary>
		QuantityPerUnit,
		///<summary>ReorderLevel. </summary>
		ReorderLevel,
		///<summary>SupplierId. </summary>
		SupplierId,
		///<summary>UnitPrice. </summary>
		UnitPrice,
		///<summary>UnitsInStock. </summary>
		UnitsInStock,
		///<summary>UnitsOnOrder. </summary>
		UnitsOnOrder,
		/// <summary></summary>
		AmountOfFields
	}

	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : Invoices.</summary>
	public enum InvoicesFieldIndex
	{
		///<summary>ShipName</summary>
		ShipName,
		///<summary>ShipAddress</summary>
		ShipAddress,
		///<summary>ShipCity</summary>
		ShipCity,
		///<summary>ShipRegion</summary>
		ShipRegion,
		///<summary>ShipPostalCode</summary>
		ShipPostalCode,
		///<summary>ShipCountry</summary>
		ShipCountry,
		///<summary>CustomerId</summary>
		CustomerId,
		///<summary>CustomerName</summary>
		CustomerName,
		///<summary>Address</summary>
		Address,
		///<summary>City</summary>
		City,
		///<summary>Region</summary>
		Region,
		///<summary>PostalCode</summary>
		PostalCode,
		///<summary>Country</summary>
		Country,
		///<summary>Salesperson</summary>
		Salesperson,
		///<summary>OrderId</summary>
		OrderId,
		///<summary>OrderDate</summary>
		OrderDate,
		///<summary>RequiredDate</summary>
		RequiredDate,
		///<summary>ShippedDate</summary>
		ShippedDate,
		///<summary>ShipperName</summary>
		ShipperName,
		///<summary>ProductId</summary>
		ProductId,
		///<summary>ProductName</summary>
		ProductName,
		///<summary>UnitPrice</summary>
		UnitPrice,
		///<summary>Quantity</summary>
		Quantity,
		///<summary>Discount</summary>
		Discount,
		///<summary>ExtendedPrice</summary>
		ExtendedPrice,
		///<summary>Freight</summary>
		Freight,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : ProductsByCategory.</summary>
	public enum ProductsByCategoryFieldIndex
	{
		///<summary>CategoryName</summary>
		CategoryName,
		///<summary>ProductName</summary>
		ProductName,
		///<summary>QuantityPerUnit</summary>
		QuantityPerUnit,
		///<summary>UnitsInStock</summary>
		UnitsInStock,
		///<summary>Discontinued</summary>
		Discontinued,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : SalesByCategory.</summary>
	public enum SalesByCategoryFieldIndex
	{
		///<summary>CategoryId</summary>
		CategoryId,
		///<summary>CategoryName</summary>
		CategoryName,
		///<summary>ProductName</summary>
		ProductName,
		///<summary>ProductSales</summary>
		ProductSales,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>Enum definition for all the entity types defined in this namespace. Used by the entityfields factory.</summary>
	public enum EntityType
	{
		///<summary>Category</summary>
		CategoryEntity,
		///<summary>Customer</summary>
		CustomerEntity,
		///<summary>Employee</summary>
		EmployeeEntity,
		///<summary>Order</summary>
		OrderEntity,
		///<summary>OrderDetails</summary>
		OrderDetailsEntity,
		///<summary>Product</summary>
		ProductEntity
	}

	/// <summary>Enum definition for all the typed view types defined in this namespace. Used by the entityfields factory.</summary>
	public enum TypedViewType
	{
		///<summary>Invoices</summary>
		InvoicesTypedView,
		///<summary>ProductsByCategory</summary>
		ProductsByCategoryTypedView,
		///<summary>SalesByCategory</summary>
		SalesByCategoryTypedView
	}

	#region Custom ConstantsEnums Code
	
	// __LLBLGENPRO_USER_CODE_REGION_START CustomUserConstants
	// __LLBLGENPRO_USER_CODE_REGION_END
	#endregion

	#region Included code

	#endregion
}

