﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated on: vrijdag 20 juni 2014 12:59:47
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using SD.LLBLGen.Pro.Examples.Auditing.EntityClasses;
using SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses;
using SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses;
using SD.LLBLGen.Pro.Examples.Auditing.HelperClasses;
using SD.LLBLGen.Pro.Examples.Auditing;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.DQE.SqlServer;


namespace SD.LLBLGen.Pro.Examples.Auditing.DaoClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>General DAO class for the Customer Entity. It will perform database oriented actions for a entity of type 'CustomerEntity'.</summary>
	public partial class CustomerDAO : CommonDaoBase
	{
		/// <summary>CTor</summary>
		public CustomerDAO() : base(InheritanceHierarchyType.None, "CustomerEntity", new CustomerEntityFactory())
		{
		}





		/// <summary>Retrieves in the calling CustomerCollection object all CustomerEntity objects which are related via a relation of type 'm:n' with the passed in CustomerDemographyEntity.</summary>
		/// <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or null if not.</param>
		/// <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. When set to 0, no limitations are specified.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="customerDemographyInstance">CustomerDemographyEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiUsingCustomerDemographicsCollectionViaCustomerCustomerDemo(ITransaction containingTransaction, IEntityCollection collectionToFill, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IEntityFactory entityFactoryToUse, IEntity customerDemographyInstance, IPrefetchPath prefetchPathToUse, int pageNumber, int pageSize)
		{
			RelationCollection relations = new RelationCollection();
			relations.Add(CustomerEntity.Relations.CustomerCustomerDemoEntityUsingCustomerId, "CustomerCustomerDemo_");
			relations.Add(CustomerCustomerDemoEntity.Relations.CustomerDemographyEntityUsingCustomerTypeId, "CustomerCustomerDemo_", string.Empty, JoinHint.None);
			IPredicateExpression selectFilter = new PredicateExpression();
			selectFilter.Add(new FieldCompareValuePredicate(customerDemographyInstance.Fields[(int)CustomerDemographyFieldIndex.CustomerTypeId], ComparisonOperator.Equal));
			return this.GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse, pageNumber, pageSize);
		}

		/// <summary>Retrieves in the calling CustomerCollection object all CustomerEntity objects which are related via a relation of type 'm:n' with the passed in EmployeeEntity.</summary>
		/// <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or null if not.</param>
		/// <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. When set to 0, no limitations are specified.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiUsingEmployeesCollectionViaOrders(ITransaction containingTransaction, IEntityCollection collectionToFill, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IEntityFactory entityFactoryToUse, IEntity employeeInstance, IPrefetchPath prefetchPathToUse, int pageNumber, int pageSize)
		{
			RelationCollection relations = new RelationCollection();
			relations.Add(CustomerEntity.Relations.OrderEntityUsingCustomerId, "Order_");
			relations.Add(OrderEntity.Relations.EmployeeEntityUsingEmployeeId, "Order_", string.Empty, JoinHint.None);
			IPredicateExpression selectFilter = new PredicateExpression();
			selectFilter.Add(new FieldCompareValuePredicate(employeeInstance.Fields[(int)EmployeeFieldIndex.EmployeeId], ComparisonOperator.Equal));
			return this.GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse, pageNumber, pageSize);
		}

		/// <summary>Retrieves in the calling CustomerCollection object all CustomerEntity objects which are related via a relation of type 'm:n' with the passed in ShipperEntity.</summary>
		/// <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or null if not.</param>
		/// <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. When set to 0, no limitations are specified.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="shipperInstance">ShipperEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiUsingShippersCollectionViaOrders(ITransaction containingTransaction, IEntityCollection collectionToFill, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IEntityFactory entityFactoryToUse, IEntity shipperInstance, IPrefetchPath prefetchPathToUse, int pageNumber, int pageSize)
		{
			RelationCollection relations = new RelationCollection();
			relations.Add(CustomerEntity.Relations.OrderEntityUsingCustomerId, "Order_");
			relations.Add(OrderEntity.Relations.ShipperEntityUsingShipVia, "Order_", string.Empty, JoinHint.None);
			IPredicateExpression selectFilter = new PredicateExpression();
			selectFilter.Add(new FieldCompareValuePredicate(shipperInstance.Fields[(int)ShipperFieldIndex.ShipperId], ComparisonOperator.Equal));
			return this.GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse, pageNumber, pageSize);
		}



		
		#region Custom DAO code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomDAOCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Included Code

		#endregion
	}
}
