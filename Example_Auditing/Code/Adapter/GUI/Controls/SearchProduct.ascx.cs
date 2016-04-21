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
/// Control class to search one or more 'Product' entity instances
/// </summary>
public partial class Controls_SearchProduct : System.Web.UI.UserControl, ISearchControl
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
		valueFromQueryString = queryString["ProductId"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(ProductFields.ProductId==(System.Int32)Convert.ChangeType(valueFromQueryString, typeof(System.Int32)));
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
		_filter.AddWithAnd(ProductFields.ProductId==(System.Int32)Convert.ChangeType(tbxProductId.Text, typeof(System.Int32)));
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
		if(chkEnableProductId.Checked)
		{
			string fromValueAsString = tbxProductIdMiFrom.Text;
			string toValueAsString = tbxProductIdMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.ProductId, Convert.ToInt32(opProductId.SelectedValue), chkNotProductId.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableProductName.Checked)
		{
			string fromValueAsString = tbxProductNameMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.ProductName, Convert.ToInt32(opProductName.SelectedValue), chkNotProductName.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableSupplierId.Checked)
		{
			string fromValueAsString = tbxSupplierIdMiFrom.Text;
			string toValueAsString = tbxSupplierIdMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.SupplierId, Convert.ToInt32(opSupplierId.SelectedValue), chkNotSupplierId.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableCategoryId.Checked)
		{
			string fromValueAsString = tbxCategoryIdMiFrom.Text;
			string toValueAsString = tbxCategoryIdMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.CategoryId, Convert.ToInt32(opCategoryId.SelectedValue), chkNotCategoryId.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableQuantityPerUnit.Checked)
		{
			string fromValueAsString = tbxQuantityPerUnitMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.QuantityPerUnit, Convert.ToInt32(opQuantityPerUnit.SelectedValue), chkNotQuantityPerUnit.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableUnitPrice.Checked)
		{
			string fromValueAsString = tbxUnitPriceMiFrom.Text;
			string toValueAsString = tbxUnitPriceMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.UnitPrice, Convert.ToInt32(opUnitPrice.SelectedValue), chkNotUnitPrice.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableUnitsInStock.Checked)
		{
			string fromValueAsString = tbxUnitsInStockMiFrom.Text;
			string toValueAsString = tbxUnitsInStockMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.UnitsInStock, Convert.ToInt32(opUnitsInStock.SelectedValue), chkNotUnitsInStock.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableUnitsOnOrder.Checked)
		{
			string fromValueAsString = tbxUnitsOnOrderMiFrom.Text;
			string toValueAsString = tbxUnitsOnOrderMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.UnitsOnOrder, Convert.ToInt32(opUnitsOnOrder.SelectedValue), chkNotUnitsOnOrder.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableReorderLevel.Checked)
		{
			string fromValueAsString = tbxReorderLevelMiFrom.Text;
			string toValueAsString = tbxReorderLevelMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.ReorderLevel, Convert.ToInt32(opReorderLevel.SelectedValue), chkNotReorderLevel.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableDiscontinued.Checked)
		{
			object fromValue = chkDiscontinuedMiFrom.Checked;
			object toValue = null;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.Discontinued, Convert.ToInt32(opDiscontinued.SelectedValue), chkNotDiscontinued.Checked, 
						fromValue, toValue);
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
