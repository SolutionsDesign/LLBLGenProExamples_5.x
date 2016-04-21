
<%@ Control Language="C#" AutoEventWireup="true" Inherits="Controls_ViewRelatedToCategory" Codebehind="ViewRelatedToCategory.ascx.cs" %>

<%@ Register TagPrefix="dbeditor" TagName="ProductInstances" Src="ListProductInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="SupplierInstances" Src="ListSupplierInstances.ascx"%>
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
			Related Supplier instances (field mapped: SuppliersCollectionViaProducts)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:SupplierInstances ID="laSuppliersCollectionViaProducts" runat="server" ShowHomeButton="false"  ShowAddNewButton="false" />
			<br><br>
		</td>
	</tr>
	