using System;

using System.Configuration;
using System.Collections;
using System.Web;
using System.Text;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.Examples.Auditing;
using SD.LLBLGen.Pro.Examples.Auditing.EntityClasses;
using SD.LLBLGen.Pro.Examples.Auditing.HelperClasses;
using SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific;

public partial class Controls_ListProductInstances : System.Web.UI.UserControl, IListControl
{
	protected void Page_Load(object sender, EventArgs e)
	{
        if (!IsPostBack)
        {
            // prefetch so related entity fields could be populated in gridview
            IPrefetchPath2 path = new PrefetchPath2((int)EntityType.ProductEntity);
            path.Add(ProductEntity.PrefetchPathCategories);
            path.Add(ProductEntity.PrefetchPathSuppliers);

            _ProductDS.PrefetchPathToUse = path;
        }
	}


	/// <summary>
	/// Handles the Click event of the btnHome control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void btnHome_Click(object sender, EventArgs e)
	{
		Response.Redirect("~/default.aspx");
	}
	
	
	/// <summary>
	/// Handles the Click event of the btnAddNew control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void btnAddNew_Click(object sender, EventArgs e)
	{
		object additionalFilters = ViewState["additionalFilters"];
		string additionalFiltersAsString = string.Empty;
		if(additionalFilters != null)
		{
			additionalFiltersAsString = (string)additionalFilters;
		}
		Response.Redirect("~/AddNew.aspx?EntityType=" + (int)EntityType.ProductEntity + additionalFiltersAsString);
	}
	
	
	/// <summary>
	/// Handles the RowCommand event of the theGrid control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.Web.UI.WebControls.GridViewCommandEventArgs"/> instance containing the event data.</param>
	protected void theGrid_RowCommand(object sender, GridViewCommandEventArgs e)
	{
		switch(e.CommandName)
		{
			case "EditExisting":
			case "ViewExisting":
				break;
			default:
				// apparently another command, return
				return;
		}
		int index = Convert.ToInt32(e.CommandArgument);
		ProductEntity selectedEntity = (ProductEntity)_ProductDS.EntityCollection[index];

		StringBuilder pkFieldsAndValues = new StringBuilder();
		pkFieldsAndValues.AppendFormat("&ProductId={0}", selectedEntity.ProductId);
		switch(e.CommandName)
		{
			case "EditExisting":
				Response.Redirect("~/EditExisting.aspx?EntityType=" + (int)EntityType.ProductEntity + pkFieldsAndValues.ToString());
				break;
			case "ViewExisting":
				Response.Redirect("~/ViewExisting.aspx?EntityType=" + (int)EntityType.ProductEntity + pkFieldsAndValues.ToString());
				break;
		}
	}


	/// <summary>
	/// Sets the containing entity for the entities enlisted in this control. When a particular containing entity is set (e.g. 'Customer' for orders), the
	/// set entity is used to obtain the filter for the entities to show, and FilterToUse is then overruled. The entity is also used to produce FK field values
	/// for AddNew, so for example when a list of orders is shown, which are related to customer, the AddNew button should make the order's AddNew form preselect
	/// the Customer.
	/// </summary>
	/// <param name="containingEntity">The containing entity instance</param>
	/// <param name="name">the field name mapped on the relation from the containing entity with this entity</param>
	public void SetContainingEntity(IEntity2 containingEntity, string name)
	{
		switch(containingEntity.LLBLGenProEntityName)
		{
			case "OrderDetailEntity":
				switch(name)
				{
					default:
						break;
				}
				break;
			case "CategoryEntity":
				switch(name)
				{
					case "Products":
						_ProductDS.FilterToUse = ((CategoryEntity)containingEntity).GetRelationInfoProducts();
						ViewState["additionalFilters"] = "&CategoryId=" + 
								((CategoryEntity)containingEntity).CategoryId +
								"&20FkField=CategoryId";
						break;
					default:
						break;
				}
				break;
			case "SupplierEntity":
				switch(name)
				{
					case "Products":
						_ProductDS.FilterToUse = ((SupplierEntity)containingEntity).GetRelationInfoProducts();
						ViewState["additionalFilters"] = "&SupplierId=" + 
								((SupplierEntity)containingEntity).SupplierId +
								"&20FkField=SupplierId";
						break;
					default:
						break;
				}
				break;
			case "OrderEntity":
				switch(name)
				{
					case "ProductsCollectionViaOrderDetails":
						_ProductDS.FilterToUse = ((OrderEntity)containingEntity).GetRelationInfoProductsCollectionViaOrderDetails();
						break;
					default:
						break;
				}
				break;

			default:
				break;
		}
	}


	/// <summary>
	/// Sets the filter to use for the ListControl's datasource control.
	/// </summary>
	public IRelationPredicateBucket FilterToUse 
	{
		set { _ProductDS.FilterToUse = value; }
	}


	/// <summary>
	/// Sets the flag to show the Home button or not. The home button is hidden when the control is shown inside a form with other information.
	/// </summary>
	public bool ShowHomeButton 
	{
		set { phHomeButton.Visible = value; }
	}	


	/// <summary>
	/// Sets the flag to show the AddNew button or not. The AddNew button is hidden when the data in the control is the data of an m:n relation.
	/// </summary>
	public bool ShowAddNewButton 
	{
		set { phAddNewButton.Visible = value; }
	}

    protected void btnDirectUpdate_Click(object sender, EventArgs e)
    {
        /// Set Discontinued=True ALL products of category 'Sea Food' (8)

        // category = seaFood
        IRelationPredicateBucket filter = new RelationPredicateBucket();
        filter.PredicateExpression.Add(ProductFields.CategoryId == 8);

        // set discontinued
        ProductEntity productUpdatedValues = new ProductEntity();
        productUpdatedValues.Discontinued = true;

        // perform update
        using (DataAccessAdapter  adapter = new DataAccessAdapter())
        {
            adapter.UpdateEntitiesDirectly(productUpdatedValues, filter);
        }
    }	
}