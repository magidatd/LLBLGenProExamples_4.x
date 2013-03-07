﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.0
// Code is generated on: maandag 2 juli 2012 15:42:08
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.DAL.DatabaseSpecific
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal static class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass((19 + 0));
			InitAuditActionTypeEntityMappings();
			InitAuditInfoEntityMappings();
			InitCategoryEntityMappings();
			InitCustomerEntityMappings();
			InitCustomerCustomerDemoEntityMappings();
			InitCustomerDemographicEntityMappings();
			InitEmployeeEntityMappings();
			InitEmployeeTerritoryEntityMappings();
			InitGroupEntityMappings();
			InitOrderEntityMappings();
			InitOrderAuditInfoEntityMappings();
			InitOrderDetailEntityMappings();
			InitProductEntityMappings();
			InitRegionEntityMappings();
			InitShipperEntityMappings();
			InitSupplierEntityMappings();
			InitTerritoryEntityMappings();
			InitUserEntityMappings();
			InitUserGroupEntityMappings();

		}


		/// <summary>Inits AuditActionTypeEntity's mappings</summary>
		private void InitAuditActionTypeEntityMappings()
		{
			this.AddElementMapping( "AuditActionTypeEntity", @"Northwind", @"dbo", "AuditActionType", 2 );
			this.AddElementFieldMapping( "AuditActionTypeEntity", "AuditActionTypeId", "AuditActionTypeID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "AuditActionTypeEntity", "Name", "Name", false, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits AuditInfoEntity's mappings</summary>
		private void InitAuditInfoEntityMappings()
		{
			this.AddElementMapping( "AuditInfoEntity", @"Northwind", @"dbo", "AuditInfo", 6 );
			this.AddElementFieldMapping( "AuditInfoEntity", "ActionData", "ActionData", true, "VarChar", 250, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "AuditInfoEntity", "ActionDateTime", "ActionDateTime", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			this.AddElementFieldMapping( "AuditInfoEntity", "AffectedEntityName", "AffectedEntityName", false, "VarChar", 100, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "AuditInfoEntity", "AuditActionTypeId", "AuditActionTypeID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			this.AddElementFieldMapping( "AuditInfoEntity", "AuditInfoId", "AuditInfoID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 4 );
			this.AddElementFieldMapping( "AuditInfoEntity", "UserId", "UserID", false, "VarChar", 15, 0, 0, false, "", null, typeof(System.String), 5 );
		}
		/// <summary>Inits CategoryEntity's mappings</summary>
		private void InitCategoryEntityMappings()
		{
			this.AddElementMapping( "CategoryEntity", @"Northwind", @"dbo", "Categories", 4 );
			this.AddElementFieldMapping( "CategoryEntity", "CategoryId", "CategoryID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "CategoryEntity", "CategoryName", "CategoryName", false, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "CategoryEntity", "Description", "Description", true, "NText", 1073741823, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "CategoryEntity", "Picture", "Picture", true, "Image", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 3 );
		}
		/// <summary>Inits CustomerEntity's mappings</summary>
		private void InitCustomerEntityMappings()
		{
			this.AddElementMapping( "CustomerEntity", @"Northwind", @"dbo", "Customers", 11 );
			this.AddElementFieldMapping( "CustomerEntity", "Address", "Address", true, "NVarChar", 60, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "CustomerEntity", "City", "City", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "CustomerEntity", "CompanyName", "CompanyName", false, "NVarChar", 40, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "CustomerEntity", "ContactName", "ContactName", true, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "CustomerEntity", "ContactTitle", "ContactTitle", true, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "CustomerEntity", "Country", "Country", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "CustomerEntity", "CustomerId", "CustomerID", false, "NChar", 5, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "CustomerEntity", "Fax", "Fax", true, "NVarChar", 24, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "CustomerEntity", "Phone", "Phone", true, "NVarChar", 24, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "CustomerEntity", "PostalCode", "PostalCode", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "CustomerEntity", "Region", "Region", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 10 );
		}
		/// <summary>Inits CustomerCustomerDemoEntity's mappings</summary>
		private void InitCustomerCustomerDemoEntityMappings()
		{
			this.AddElementMapping( "CustomerCustomerDemoEntity", @"Northwind", @"dbo", "CustomerCustomerDemo", 2 );
			this.AddElementFieldMapping( "CustomerCustomerDemoEntity", "CustomerId", "CustomerID", false, "NChar", 5, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "CustomerCustomerDemoEntity", "CustomerTypeId", "CustomerTypeID", false, "NChar", 10, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits CustomerDemographicEntity's mappings</summary>
		private void InitCustomerDemographicEntityMappings()
		{
			this.AddElementMapping( "CustomerDemographicEntity", @"Northwind", @"dbo", "CustomerDemographics", 2 );
			this.AddElementFieldMapping( "CustomerDemographicEntity", "CustomerDesc", "CustomerDesc", true, "NText", 1073741823, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "CustomerDemographicEntity", "CustomerTypeId", "CustomerTypeID", false, "NChar", 10, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits EmployeeEntity's mappings</summary>
		private void InitEmployeeEntityMappings()
		{
			this.AddElementMapping( "EmployeeEntity", @"Northwind", @"dbo", "Employees", 19 );
			this.AddElementFieldMapping( "EmployeeEntity", "Address", "Address", true, "NVarChar", 60, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "EmployeeEntity", "BirthDate", "BirthDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			this.AddElementFieldMapping( "EmployeeEntity", "City", "City", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "EmployeeEntity", "Country", "Country", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "EmployeeEntity", "EmployeeId", "EmployeeID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 4 );
			this.AddElementFieldMapping( "EmployeeEntity", "Extension", "Extension", true, "NVarChar", 4, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "EmployeeEntity", "FirstName", "FirstName", false, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "EmployeeEntity", "HireDate", "HireDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			this.AddElementFieldMapping( "EmployeeEntity", "HomePhone", "HomePhone", true, "NVarChar", 24, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "EmployeeEntity", "LastName", "LastName", false, "NVarChar", 20, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "EmployeeEntity", "Notes", "Notes", true, "NText", 1073741823, 0, 0, false, "", null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "EmployeeEntity", "Photo", "Photo", true, "Image", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 11 );
			this.AddElementFieldMapping( "EmployeeEntity", "PhotoPath", "PhotoPath", true, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 12 );
			this.AddElementFieldMapping( "EmployeeEntity", "PostalCode", "PostalCode", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 13 );
			this.AddElementFieldMapping( "EmployeeEntity", "Region", "Region", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 14 );
			this.AddElementFieldMapping( "EmployeeEntity", "RegionId", "RegionID", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 15 );
			this.AddElementFieldMapping( "EmployeeEntity", "ReportsTo", "ReportsTo", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 16 );
			this.AddElementFieldMapping( "EmployeeEntity", "Title", "Title", true, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 17 );
			this.AddElementFieldMapping( "EmployeeEntity", "TitleOfCourtesy", "TitleOfCourtesy", true, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 18 );
		}
		/// <summary>Inits EmployeeTerritoryEntity's mappings</summary>
		private void InitEmployeeTerritoryEntityMappings()
		{
			this.AddElementMapping( "EmployeeTerritoryEntity", @"Northwind", @"dbo", "EmployeeTerritories", 2 );
			this.AddElementFieldMapping( "EmployeeTerritoryEntity", "EmployeeId", "EmployeeID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "EmployeeTerritoryEntity", "TerritoryId", "TerritoryID", false, "NVarChar", 20, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits GroupEntity's mappings</summary>
		private void InitGroupEntityMappings()
		{
			this.AddElementMapping( "GroupEntity", @"Northwind", @"dbo", "Group", 2 );
			this.AddElementFieldMapping( "GroupEntity", "Id", "Id", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "GroupEntity", "Name", "Name", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits OrderEntity's mappings</summary>
		private void InitOrderEntityMappings()
		{
			this.AddElementMapping( "OrderEntity", @"Northwind", @"dbo", "Orders", 14 );
			this.AddElementFieldMapping( "OrderEntity", "CustomerId", "CustomerID", true, "NChar", 5, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "OrderEntity", "EmployeeId", "EmployeeID", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			this.AddElementFieldMapping( "OrderEntity", "Freight", "Freight", true, "Money", 0, 4, 19, false, "", null, typeof(System.Decimal), 2 );
			this.AddElementFieldMapping( "OrderEntity", "OrderDate", "OrderDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "OrderEntity", "OrderId", "OrderID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 4 );
			this.AddElementFieldMapping( "OrderEntity", "RequiredDate", "RequiredDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			this.AddElementFieldMapping( "OrderEntity", "ShipAddress", "ShipAddress", true, "NVarChar", 60, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "OrderEntity", "ShipCity", "ShipCity", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "OrderEntity", "ShipCountry", "ShipCountry", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "OrderEntity", "ShipName", "ShipName", true, "NVarChar", 40, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "OrderEntity", "ShippedDate", "ShippedDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 10 );
			this.AddElementFieldMapping( "OrderEntity", "ShipPostalCode", "ShipPostalCode", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 11 );
			this.AddElementFieldMapping( "OrderEntity", "ShipRegion", "ShipRegion", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 12 );
			this.AddElementFieldMapping( "OrderEntity", "ShipVia", "ShipVia", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 13 );
		}
		/// <summary>Inits OrderAuditInfoEntity's mappings</summary>
		private void InitOrderAuditInfoEntityMappings()
		{
			this.AddElementMapping( "OrderAuditInfoEntity", @"Northwind", @"dbo", "OrderAuditInfo", 2 );
			this.AddElementFieldMapping( "OrderAuditInfoEntity", "AuditInfoId", "AuditInfoID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "OrderAuditInfoEntity", "OrderId", "OrderID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
		}
		/// <summary>Inits OrderDetailEntity's mappings</summary>
		private void InitOrderDetailEntityMappings()
		{
			this.AddElementMapping( "OrderDetailEntity", @"Northwind", @"dbo", "Order Details", 5 );
			this.AddElementFieldMapping( "OrderDetailEntity", "Discount", "Discount", false, "Real", 0, 0, 24, false, "", null, typeof(System.Single), 0 );
			this.AddElementFieldMapping( "OrderDetailEntity", "OrderId", "OrderID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			this.AddElementFieldMapping( "OrderDetailEntity", "ProductId", "ProductID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			this.AddElementFieldMapping( "OrderDetailEntity", "Quantity", "Quantity", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 3 );
			this.AddElementFieldMapping( "OrderDetailEntity", "UnitPrice", "UnitPrice", false, "Money", 0, 4, 19, false, "", null, typeof(System.Decimal), 4 );
		}
		/// <summary>Inits ProductEntity's mappings</summary>
		private void InitProductEntityMappings()
		{
			this.AddElementMapping( "ProductEntity", @"Northwind", @"dbo", "Products", 10 );
			this.AddElementFieldMapping( "ProductEntity", "CategoryId", "CategoryID", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "ProductEntity", "Discontinued", "Discontinued", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "ProductEntity", "ProductId", "ProductID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2 );
			this.AddElementFieldMapping( "ProductEntity", "ProductName", "ProductName", false, "NVarChar", 40, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "ProductEntity", "QuantityPerUnit", "QuantityPerUnit", true, "NVarChar", 20, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "ProductEntity", "ReorderLevel", "ReorderLevel", true, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 5 );
			this.AddElementFieldMapping( "ProductEntity", "SupplierId", "SupplierID", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			this.AddElementFieldMapping( "ProductEntity", "UnitPrice", "UnitPrice", true, "Money", 0, 4, 19, false, "", null, typeof(System.Decimal), 7 );
			this.AddElementFieldMapping( "ProductEntity", "UnitsInStock", "UnitsInStock", true, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 8 );
			this.AddElementFieldMapping( "ProductEntity", "UnitsOnOrder", "UnitsOnOrder", true, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 9 );
		}
		/// <summary>Inits RegionEntity's mappings</summary>
		private void InitRegionEntityMappings()
		{
			this.AddElementMapping( "RegionEntity", @"Northwind", @"dbo", "Region", 2 );
			this.AddElementFieldMapping( "RegionEntity", "RegionDescription", "RegionDescription", false, "NChar", 50, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "RegionEntity", "RegionId", "RegionID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
		}
		/// <summary>Inits ShipperEntity's mappings</summary>
		private void InitShipperEntityMappings()
		{
			this.AddElementMapping( "ShipperEntity", @"Northwind", @"dbo", "Shippers", 3 );
			this.AddElementFieldMapping( "ShipperEntity", "CompanyName", "CompanyName", false, "NVarChar", 40, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "ShipperEntity", "Phone", "Phone", true, "NVarChar", 24, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "ShipperEntity", "ShipperId", "ShipperID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2 );
		}
		/// <summary>Inits SupplierEntity's mappings</summary>
		private void InitSupplierEntityMappings()
		{
			this.AddElementMapping( "SupplierEntity", @"Northwind", @"dbo", "Suppliers", 12 );
			this.AddElementFieldMapping( "SupplierEntity", "Address", "Address", true, "NVarChar", 60, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "SupplierEntity", "City", "City", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "SupplierEntity", "CompanyName", "CompanyName", false, "NVarChar", 40, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "SupplierEntity", "ContactName", "ContactName", true, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "SupplierEntity", "ContactTitle", "ContactTitle", true, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "SupplierEntity", "Country", "Country", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "SupplierEntity", "Fax", "Fax", true, "NVarChar", 24, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "SupplierEntity", "HomePage", "HomePage", true, "NText", 1073741823, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "SupplierEntity", "Phone", "Phone", true, "NVarChar", 24, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "SupplierEntity", "PostalCode", "PostalCode", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "SupplierEntity", "Region", "Region", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "SupplierEntity", "SupplierId", "SupplierID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 11 );
		}
		/// <summary>Inits TerritoryEntity's mappings</summary>
		private void InitTerritoryEntityMappings()
		{
			this.AddElementMapping( "TerritoryEntity", @"Northwind", @"dbo", "Territories", 4 );
			this.AddElementFieldMapping( "TerritoryEntity", "RegionId", "RegionID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "TerritoryEntity", "TerritoryDescription", "TerritoryDescription", false, "NChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "TerritoryEntity", "TerritoryId", "TerritoryID", false, "NVarChar", 20, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "TerritoryEntity", "Test", "test", true, "Binary", 50, 0, 0, false, "", null, typeof(System.Byte[]), 3 );
		}
		/// <summary>Inits UserEntity's mappings</summary>
		private void InitUserEntityMappings()
		{
			this.AddElementMapping( "UserEntity", @"Northwind", @"dbo", "User", 3 );
			this.AddElementFieldMapping( "UserEntity", "FullName", "FullName", true, "VarChar", 150, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "UserEntity", "Password", "Password", false, "VarChar", 15, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "UserEntity", "UserId", "UserID", false, "VarChar", 15, 0, 0, false, "", null, typeof(System.String), 2 );
		}
		/// <summary>Inits UserGroupEntity's mappings</summary>
		private void InitUserGroupEntityMappings()
		{
			this.AddElementMapping( "UserGroupEntity", @"Northwind", @"dbo", "UserGroup", 2 );
			this.AddElementFieldMapping( "UserGroupEntity", "GroupId", "GroupId", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "UserGroupEntity", "UserId", "UserId", false, "VarChar", 15, 0, 0, false, "", null, typeof(System.String), 1 );
		}

	}
}