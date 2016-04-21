
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

public partial class Controls_ViewRelatedToShipper : System.Web.UI.UserControl, IViewRelatedControl
{
	private PredicateExpression _filterToUse;

	protected void Page_Load(object sender, EventArgs e)
	{
		if(_filterToUse != null)
		{
			using(DataAccessAdapter adapter = new DataAccessAdapter())
			{
				ShipperEntity instance = (ShipperEntity)adapter.FetchNewEntity(new ShipperEntityFactory(), new RelationPredicateBucket(_filterToUse));
				if(instance != null)
				{
					laOrders.SetContainingEntity(instance, "Orders");
					laCustomersCollectionViaOrders.SetContainingEntity(instance, "CustomersCollectionViaOrders");
					laEmployeesCollectionViaOrders.SetContainingEntity(instance, "EmployeesCollectionViaOrders");

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
