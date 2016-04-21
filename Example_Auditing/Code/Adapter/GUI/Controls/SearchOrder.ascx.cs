using System;

using System.Configuration;
using System.Collections;
using System.Collections.Specialized;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.Examples.Auditing.HelperClasses;

/// <summary>
/// Control class to search one or more 'Order' entity instances
/// </summary>
public partial class Controls_SearchOrder : System.Web.UI.UserControl, ISearchControl
{
	#region Events
	/// <summary>
	/// Event which is raised when the user clicked a search button. After this event, the 'Filter' property is valid.
	/// </summary>
	public event EventHandler SearchClicked;
	#endregion
	
	#region Class Member Declarations
	private PredicateExpression _filter;
	#endregion
		
	/// <summary>
	/// Handles the Load event of the Page control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void Page_Load(object sender, EventArgs e)
	{
	}
	
	/// <summary>
	/// Creates a predicate expression filter based on the query string passed in. 
	/// </summary>
	/// <param name="queryString">The query string with PK field names and values.</param>
	/// <returns>a predicate expression with a filter on the pk fields and values.</returns>
	public PredicateExpression CreateFilter(NameValueCollection queryString)
	{
		PredicateExpression toReturn = new PredicateExpression();
		string valueFromQueryString = null;
		valueFromQueryString = queryString["OrderId"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(OrderFields.OrderId==(System.Int32)Convert.ChangeType(valueFromQueryString, typeof(System.Int32)));
		}

		return toReturn;
	}
	

	/// <summary>
	/// Handles the Click event of the btnCancel control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void btnCancel_Click(object sender, EventArgs e)
	{
		Response.Redirect("~/default.aspx");
	}


	/// <summary>
	/// Handles the Click event of the btnSearchPK control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void btnSearchPk_Click(object sender, EventArgs e)
	{
		if(!Page.IsValid)
		{
			return;
		}
		_filter = new PredicateExpression();
		_filter.AddWithAnd(OrderFields.OrderId==(System.Int32)Convert.ChangeType(tbxOrderId.Text, typeof(System.Int32)));
		if((SearchClicked!=null) && (_filter.Count>0))
		{
			SearchClicked(this, new EventArgs());
		}
	}



	/// <summary>
	/// Handles the Click event of the btnSearchSubSet control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void btnSearchSubSet_Click(object sender, EventArgs e)
	{
		if(!Page.IsValid)
		{
			return;
		}

		_filter = new PredicateExpression();
		IPredicate toAdd = null;
		if(chkEnableOrderId.Checked)
		{
			string fromValueAsString = tbxOrderIdMiFrom.Text;
			string toValueAsString = tbxOrderIdMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(OrderFields.OrderId, Convert.ToInt32(opOrderId.SelectedValue), chkNotOrderId.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableCustomerId.Checked)
		{
			string fromValueAsString = tbxCustomerIdMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(OrderFields.CustomerId, Convert.ToInt32(opCustomerId.SelectedValue), chkNotCustomerId.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableEmployeeId.Checked)
		{
			string fromValueAsString = tbxEmployeeIdMiFrom.Text;
			string toValueAsString = tbxEmployeeIdMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(OrderFields.EmployeeId, Convert.ToInt32(opEmployeeId.SelectedValue), chkNotEmployeeId.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableOrderDate.Checked)
		{
			object fromValue = dtxOrderDateMiFrom.Value;
			object toValue = dtxOrderDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(OrderFields.OrderDate, Convert.ToInt32(opOrderDate.SelectedValue), chkNotOrderDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableRequiredDate.Checked)
		{
			object fromValue = dtxRequiredDateMiFrom.Value;
			object toValue = dtxRequiredDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(OrderFields.RequiredDate, Convert.ToInt32(opRequiredDate.SelectedValue), chkNotRequiredDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableShippedDate.Checked)
		{
			object fromValue = dtxShippedDateMiFrom.Value;
			object toValue = dtxShippedDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(OrderFields.ShippedDate, Convert.ToInt32(opShippedDate.SelectedValue), chkNotShippedDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableShipVia.Checked)
		{
			string fromValueAsString = tbxShipViaMiFrom.Text;
			string toValueAsString = tbxShipViaMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(OrderFields.ShipVia, Convert.ToInt32(opShipVia.SelectedValue), chkNotShipVia.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableFreight.Checked)
		{
			string fromValueAsString = tbxFreightMiFrom.Text;
			string toValueAsString = tbxFreightMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(OrderFields.Freight, Convert.ToInt32(opFreight.SelectedValue), chkNotFreight.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableShipName.Checked)
		{
			string fromValueAsString = tbxShipNameMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(OrderFields.ShipName, Convert.ToInt32(opShipName.SelectedValue), chkNotShipName.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableShipAddress.Checked)
		{
			string fromValueAsString = tbxShipAddressMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(OrderFields.ShipAddress, Convert.ToInt32(opShipAddress.SelectedValue), chkNotShipAddress.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableShipCity.Checked)
		{
			string fromValueAsString = tbxShipCityMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(OrderFields.ShipCity, Convert.ToInt32(opShipCity.SelectedValue), chkNotShipCity.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableShipRegion.Checked)
		{
			string fromValueAsString = tbxShipRegionMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(OrderFields.ShipRegion, Convert.ToInt32(opShipRegion.SelectedValue), chkNotShipRegion.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableShipPostalCode.Checked)
		{
			string fromValueAsString = tbxShipPostalCodeMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(OrderFields.ShipPostalCode, Convert.ToInt32(opShipPostalCode.SelectedValue), chkNotShipPostalCode.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableShipCountry.Checked)
		{
			string fromValueAsString = tbxShipCountryMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(OrderFields.ShipCountry, Convert.ToInt32(opShipCountry.SelectedValue), chkNotShipCountry.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(SearchClicked != null)
		{
			SearchClicked(this, new EventArgs());
		}
	}
	
	#region Class Property Declarations
	/// <summary>
	/// Gets the filter formulated with the values specified in the search control. Valid after SearchClicked has been raised. 
	/// </summary>
	public PredicateExpression Filter 
	{ 
		get { return _filter;}
	}
	
	/// <summary>
	/// Sets the flag for allowing single entity searches. If set to true, the search control will show PK fields and if applicable, UC fields.
	/// </summary>
	public bool AllowSingleEntitySearches
	{ 
		set
		{
			phSingleInstance.Visible=value;
		}
	}
	
	/// <summary>
	/// Sets the flag for allowing multi entity searches. If set to true, the search control will show fields to formulate a search over all fields, and 
	/// thus a filter which could lead to multiple results.
	/// </summary>
	public bool AllowMultiEntitySearches 
	{ 
		set
		{
			phMultiInstance.Visible=value;
		}
	}
	#endregion
}
