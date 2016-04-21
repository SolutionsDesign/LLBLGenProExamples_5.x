///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: donderdag 21 april 2016 12:25:27
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.Authorization.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal static class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass( (7 + 0));
			InitCustomersEntityInfos();
			InitEmployeesEntityInfos();
			InitGroupEntityInfos();
			InitOrderDetailsEntityInfos();
			InitOrdersEntityInfos();
			InitUserEntityInfos();
			InitUserGroupEntityInfos();

			this.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits CustomersEntity's FieldInfo objects</summary>
		private void InitCustomersEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CustomersFieldIndex), "CustomersEntity");
			this.AddElementFieldInfo("CustomersEntity", "Address", typeof(System.String), false, false, false, true,  (int)CustomersFieldIndex.Address, 60, 0, 0);
			this.AddElementFieldInfo("CustomersEntity", "City", typeof(System.String), false, false, false, true,  (int)CustomersFieldIndex.City, 15, 0, 0);
			this.AddElementFieldInfo("CustomersEntity", "CompanyName", typeof(System.String), false, false, false, false,  (int)CustomersFieldIndex.CompanyName, 40, 0, 0);
			this.AddElementFieldInfo("CustomersEntity", "ContactName", typeof(System.String), false, false, false, true,  (int)CustomersFieldIndex.ContactName, 30, 0, 0);
			this.AddElementFieldInfo("CustomersEntity", "ContactTitle", typeof(System.String), false, false, false, true,  (int)CustomersFieldIndex.ContactTitle, 30, 0, 0);
			this.AddElementFieldInfo("CustomersEntity", "Country", typeof(System.String), false, false, false, true,  (int)CustomersFieldIndex.Country, 15, 0, 0);
			this.AddElementFieldInfo("CustomersEntity", "CustomerId", typeof(System.String), true, false, false, false,  (int)CustomersFieldIndex.CustomerId, 5, 0, 0);
			this.AddElementFieldInfo("CustomersEntity", "Fax", typeof(System.String), false, false, false, true,  (int)CustomersFieldIndex.Fax, 24, 0, 0);
			this.AddElementFieldInfo("CustomersEntity", "Phone", typeof(System.String), false, false, false, true,  (int)CustomersFieldIndex.Phone, 24, 0, 0);
			this.AddElementFieldInfo("CustomersEntity", "PostalCode", typeof(System.String), false, false, false, true,  (int)CustomersFieldIndex.PostalCode, 10, 0, 0);
			this.AddElementFieldInfo("CustomersEntity", "Region", typeof(System.String), false, false, false, true,  (int)CustomersFieldIndex.Region, 15, 0, 0);
		}
		/// <summary>Inits EmployeesEntity's FieldInfo objects</summary>
		private void InitEmployeesEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(EmployeesFieldIndex), "EmployeesEntity");
			this.AddElementFieldInfo("EmployeesEntity", "Address", typeof(System.String), false, false, false, true,  (int)EmployeesFieldIndex.Address, 60, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "BirthDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)EmployeesFieldIndex.BirthDate, 0, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "City", typeof(System.String), false, false, false, true,  (int)EmployeesFieldIndex.City, 15, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "Country", typeof(System.String), false, false, false, true,  (int)EmployeesFieldIndex.Country, 15, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "EmployeeId", typeof(System.Int32), true, false, true, false,  (int)EmployeesFieldIndex.EmployeeId, 0, 0, 10);
			this.AddElementFieldInfo("EmployeesEntity", "Extension", typeof(System.String), false, false, false, true,  (int)EmployeesFieldIndex.Extension, 4, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "FirstName", typeof(System.String), false, false, false, false,  (int)EmployeesFieldIndex.FirstName, 10, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "HireDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)EmployeesFieldIndex.HireDate, 0, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "HomePhone", typeof(System.String), false, false, false, true,  (int)EmployeesFieldIndex.HomePhone, 24, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "LastName", typeof(System.String), false, false, false, false,  (int)EmployeesFieldIndex.LastName, 20, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "Notes", typeof(System.String), false, false, false, true,  (int)EmployeesFieldIndex.Notes, 1073741823, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "Photo", typeof(System.Byte[]), false, false, false, true,  (int)EmployeesFieldIndex.Photo, 2147483647, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "PhotoPath", typeof(System.String), false, false, false, true,  (int)EmployeesFieldIndex.PhotoPath, 255, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "PostalCode", typeof(System.String), false, false, false, true,  (int)EmployeesFieldIndex.PostalCode, 10, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "Region", typeof(System.String), false, false, false, true,  (int)EmployeesFieldIndex.Region, 15, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "ReportsTo", typeof(Nullable<System.Int32>), false, true, false, true,  (int)EmployeesFieldIndex.ReportsTo, 0, 0, 10);
			this.AddElementFieldInfo("EmployeesEntity", "Title", typeof(System.String), false, false, false, true,  (int)EmployeesFieldIndex.Title, 30, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "TitleOfCourtesy", typeof(System.String), false, false, false, true,  (int)EmployeesFieldIndex.TitleOfCourtesy, 25, 0, 0);
		}
		/// <summary>Inits GroupEntity's FieldInfo objects</summary>
		private void InitGroupEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(GroupFieldIndex), "GroupEntity");
			this.AddElementFieldInfo("GroupEntity", "Id", typeof(System.Int32), true, false, false, false,  (int)GroupFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("GroupEntity", "Name", typeof(System.String), false, false, false, true,  (int)GroupFieldIndex.Name, 50, 0, 0);
		}
		/// <summary>Inits OrderDetailsEntity's FieldInfo objects</summary>
		private void InitOrderDetailsEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(OrderDetailsFieldIndex), "OrderDetailsEntity");
			this.AddElementFieldInfo("OrderDetailsEntity", "Discount", typeof(System.Single), false, false, false, false,  (int)OrderDetailsFieldIndex.Discount, 0, 0, 24);
			this.AddElementFieldInfo("OrderDetailsEntity", "OrderId", typeof(System.Int32), true, true, false, false,  (int)OrderDetailsFieldIndex.OrderId, 0, 0, 10);
			this.AddElementFieldInfo("OrderDetailsEntity", "ProductId", typeof(System.Int32), true, false, false, false,  (int)OrderDetailsFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("OrderDetailsEntity", "Quantity", typeof(System.Int16), false, false, false, false,  (int)OrderDetailsFieldIndex.Quantity, 0, 0, 5);
			this.AddElementFieldInfo("OrderDetailsEntity", "UnitPrice", typeof(System.Decimal), false, false, false, false,  (int)OrderDetailsFieldIndex.UnitPrice, 0, 4, 19);
		}
		/// <summary>Inits OrdersEntity's FieldInfo objects</summary>
		private void InitOrdersEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(OrdersFieldIndex), "OrdersEntity");
			this.AddElementFieldInfo("OrdersEntity", "CustomerId", typeof(System.String), false, true, false, true,  (int)OrdersFieldIndex.CustomerId, 5, 0, 0);
			this.AddElementFieldInfo("OrdersEntity", "EmployeeId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)OrdersFieldIndex.EmployeeId, 0, 0, 10);
			this.AddElementFieldInfo("OrdersEntity", "Freight", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)OrdersFieldIndex.Freight, 0, 4, 19);
			this.AddElementFieldInfo("OrdersEntity", "OrderDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)OrdersFieldIndex.OrderDate, 0, 0, 0);
			this.AddElementFieldInfo("OrdersEntity", "OrderId", typeof(System.Int32), true, false, true, false,  (int)OrdersFieldIndex.OrderId, 0, 0, 10);
			this.AddElementFieldInfo("OrdersEntity", "RequiredDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)OrdersFieldIndex.RequiredDate, 0, 0, 0);
			this.AddElementFieldInfo("OrdersEntity", "ShipAddress", typeof(System.String), false, false, false, true,  (int)OrdersFieldIndex.ShipAddress, 60, 0, 0);
			this.AddElementFieldInfo("OrdersEntity", "ShipCity", typeof(System.String), false, false, false, true,  (int)OrdersFieldIndex.ShipCity, 15, 0, 0);
			this.AddElementFieldInfo("OrdersEntity", "ShipCountry", typeof(System.String), false, false, false, true,  (int)OrdersFieldIndex.ShipCountry, 15, 0, 0);
			this.AddElementFieldInfo("OrdersEntity", "ShipName", typeof(System.String), false, false, false, true,  (int)OrdersFieldIndex.ShipName, 40, 0, 0);
			this.AddElementFieldInfo("OrdersEntity", "ShippedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)OrdersFieldIndex.ShippedDate, 0, 0, 0);
			this.AddElementFieldInfo("OrdersEntity", "ShipPostalCode", typeof(System.String), false, false, false, true,  (int)OrdersFieldIndex.ShipPostalCode, 10, 0, 0);
			this.AddElementFieldInfo("OrdersEntity", "ShipRegion", typeof(System.String), false, false, false, true,  (int)OrdersFieldIndex.ShipRegion, 15, 0, 0);
			this.AddElementFieldInfo("OrdersEntity", "ShipVia", typeof(Nullable<System.Int32>), false, false, false, true,  (int)OrdersFieldIndex.ShipVia, 0, 0, 10);
		}
		/// <summary>Inits UserEntity's FieldInfo objects</summary>
		private void InitUserEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(UserFieldIndex), "UserEntity");
			this.AddElementFieldInfo("UserEntity", "FullName", typeof(System.String), false, false, false, true,  (int)UserFieldIndex.FullName, 150, 0, 0);
			this.AddElementFieldInfo("UserEntity", "Password", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Password, 15, 0, 0);
			this.AddElementFieldInfo("UserEntity", "UserId", typeof(System.String), true, false, false, false,  (int)UserFieldIndex.UserId, 15, 0, 0);
		}
		/// <summary>Inits UserGroupEntity's FieldInfo objects</summary>
		private void InitUserGroupEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(UserGroupFieldIndex), "UserGroupEntity");
			this.AddElementFieldInfo("UserGroupEntity", "GroupId", typeof(System.Int32), true, true, false, false,  (int)UserGroupFieldIndex.GroupId, 0, 0, 10);
			this.AddElementFieldInfo("UserGroupEntity", "UserId", typeof(System.String), true, true, false, false,  (int)UserGroupFieldIndex.UserId, 15, 0, 0);
		}
		
	}
}




