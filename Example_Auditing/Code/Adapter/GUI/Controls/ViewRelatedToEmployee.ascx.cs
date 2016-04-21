
using System;

using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.Examples.Auditing.EntityClasses;
using SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific;
using SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses;

public partial class Controls_ViewRelatedToEmployee : System.Web.UI.UserControl, IViewRelatedControl
{
	private PredicateExpression _filterToUse;

	protected void Page_Load(object sender, EventArgs e)
	{
		if(_filterToUse != null)
		{
			using(DataAccessAdapter adapter = new DataAccessAdapter())
			{
				EmployeeEntity instance = (EmployeeEntity)adapter.FetchNewEntity(new EmployeeEntityFactory(), new RelationPredicateBucket(_filterToUse));
				if(instance != null)
				{
					laEmployees_.SetContainingEntity(instance, "Employees_");
					laEmployeeTerritories.SetContainingEntity(instance, "EmployeeTerritories");
					laOrders.SetContainingEntity(instance, "Orders");
					laTerritoriesCollectionViaEmployeeTerritories.SetContainingEntity(instance, "TerritoriesCollectionViaEmployeeTerritories");
					laCustomersCollectionViaOrders.SetContainingEntity(instance, "CustomersCollectionViaOrders");
					laShippersCollectionViaOrders.SetContainingEntity(instance, "ShippersCollectionViaOrders");

				}
			}
		}
	}


	/// <summary>
	/// Sets the filter to use for the control's entity fetch routine
	/// </summary>
	public PredicateExpression FilterToUse 
	{
		set { _filterToUse = value; }
	}
}
