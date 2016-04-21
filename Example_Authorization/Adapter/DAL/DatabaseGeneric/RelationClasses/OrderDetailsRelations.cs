///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated on: vrijdag 20 juni 2014 13:07:04
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using SD.LLBLGen.Pro.Examples.Authorization;
using SD.LLBLGen.Pro.Examples.Authorization.FactoryClasses;
using SD.LLBLGen.Pro.Examples.Authorization.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.Authorization.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: OrderDetails. </summary>
	public partial class OrderDetailsRelations
	{
		/// <summary>CTor</summary>
		public OrderDetailsRelations()
		{
		}

		/// <summary>Gets all relations of the OrderDetailsEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.OrdersEntityUsingOrderId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between OrderDetailsEntity and OrdersEntity over the m:1 relation they have, using the relation between the fields:
		/// OrderDetails.OrderId - Orders.OrderId
		/// </summary>
		public virtual IEntityRelation OrdersEntityUsingOrderId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Orders", false);
				relation.AddEntityFieldPair(OrdersFields.OrderId, OrderDetailsFields.OrderId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdersEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrderDetailsEntity", true);
				return relation;
			}
		}
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticOrderDetailsRelations
	{
		internal static readonly IEntityRelation OrdersEntityUsingOrderIdStatic = new OrderDetailsRelations().OrdersEntityUsingOrderId;

		/// <summary>CTor</summary>
		static StaticOrderDetailsRelations()
		{
		}
	}
}
