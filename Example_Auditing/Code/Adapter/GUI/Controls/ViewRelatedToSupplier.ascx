
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_ViewRelatedToSupplier" Codebehind="ViewRelatedToSupplier.ascx.cs" %>

<%@ Register TagPrefix="dbeditor" TagName="ProductInstances" Src="ListProductInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="CategoryInstances" Src="ListCategoryInstances.ascx"%>
	<tr>
		<td class="headers">
			Related Product instances (field mapped: Products)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:ProductInstances ID="laProducts" runat="server" ShowHomeButton="false" />
			<br><br>
		</td>
	</tr>

	<tr>
		<td class="headers">
			Related Category instances (field mapped: CategoriesCollectionViaProducts)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:CategoryInstances ID="laCategoriesCollectionViaProducts" runat="server" ShowHomeButton="false"  ShowAddNewButton="false" />
			<br><br>
		</td>
	</tr>
	