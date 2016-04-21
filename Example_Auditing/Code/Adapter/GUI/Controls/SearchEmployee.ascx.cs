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
/// Control class to search one or more 'Employee' entity instances
/// </summary>
public partial class Controls_SearchEmployee : System.Web.UI.UserControl, ISearchControl
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
		valueFromQueryString = queryString["EmployeeId"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(EmployeeFields.EmployeeId==(System.Int32)Convert.ChangeType(valueFromQueryString, typeof(System.Int32)));
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
		_filter.AddWithAnd(EmployeeFields.EmployeeId==(System.Int32)Convert.ChangeType(tbxEmployeeId.Text, typeof(System.Int32)));
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
		if(chkEnableEmployeeId.Checked)
		{
			string fromValueAsString = tbxEmployeeIdMiFrom.Text;
			string toValueAsString = tbxEmployeeIdMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(EmployeeFields.EmployeeId, Convert.ToInt32(opEmployeeId.SelectedValue), chkNotEmployeeId.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableLastName.Checked)
		{
			string fromValueAsString = tbxLastNameMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(EmployeeFields.LastName, Convert.ToInt32(opLastName.SelectedValue), chkNotLastName.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableFirstName.Checked)
		{
			string fromValueAsString = tbxFirstNameMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(EmployeeFields.FirstName, Convert.ToInt32(opFirstName.SelectedValue), chkNotFirstName.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableTitle.Checked)
		{
			string fromValueAsString = tbxTitleMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(EmployeeFields.Title, Convert.ToInt32(opTitle.SelectedValue), chkNotTitle.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableTitleOfCourtesy.Checked)
		{
			string fromValueAsString = tbxTitleOfCourtesyMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(EmployeeFields.TitleOfCourtesy, Convert.ToInt32(opTitleOfCourtesy.SelectedValue), chkNotTitleOfCourtesy.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableBirthDate.Checked)
		{
			object fromValue = dtxBirthDateMiFrom.Value;
			object toValue = dtxBirthDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(EmployeeFields.BirthDate, Convert.ToInt32(opBirthDate.SelectedValue), chkNotBirthDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableHireDate.Checked)
		{
			object fromValue = dtxHireDateMiFrom.Value;
			object toValue = dtxHireDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(EmployeeFields.HireDate, Convert.ToInt32(opHireDate.SelectedValue), chkNotHireDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableAddress.Checked)
		{
			string fromValueAsString = tbxAddressMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(EmployeeFields.Address, Convert.ToInt32(opAddress.SelectedValue), chkNotAddress.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableCity.Checked)
		{
			string fromValueAsString = tbxCityMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(EmployeeFields.City, Convert.ToInt32(opCity.SelectedValue), chkNotCity.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableRegion.Checked)
		{
			string fromValueAsString = tbxRegionMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(EmployeeFields.Region, Convert.ToInt32(opRegion.SelectedValue), chkNotRegion.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnablePostalCode.Checked)
		{
			string fromValueAsString = tbxPostalCodeMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(EmployeeFields.PostalCode, Convert.ToInt32(opPostalCode.SelectedValue), chkNotPostalCode.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableCountry.Checked)
		{
			string fromValueAsString = tbxCountryMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(EmployeeFields.Country, Convert.ToInt32(opCountry.SelectedValue), chkNotCountry.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableHomePhone.Checked)
		{
			string fromValueAsString = tbxHomePhoneMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(EmployeeFields.HomePhone, Convert.ToInt32(opHomePhone.SelectedValue), chkNotHomePhone.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableExtension.Checked)
		{
			string fromValueAsString = tbxExtensionMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(EmployeeFields.Extension, Convert.ToInt32(opExtension.SelectedValue), chkNotExtension.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableNotes.Checked)
		{
			string fromValueAsString = tbxNotesMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(EmployeeFields.Notes, Convert.ToInt32(opNotes.SelectedValue), chkNotNotes.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnableReportsTo.Checked)
		{
			string fromValueAsString = tbxReportsToMiFrom.Text;
			string toValueAsString = tbxReportsToMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(EmployeeFields.ReportsTo, Convert.ToInt32(opReportsTo.SelectedValue), chkNotReportsTo.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		if(chkEnablePhotoPath.Checked)
		{
			string fromValueAsString = tbxPhotoPathMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(EmployeeFields.PhotoPath, Convert.ToInt32(opPhotoPath.SelectedValue), chkNotPhotoPath.Checked, 
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
