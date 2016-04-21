///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using Northwind.SSDAL;
using Northwind.SSDAL.FactoryClasses;
using Northwind.SSDAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.SSDAL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: OrderAuditInfo. </summary>
	public partial class OrderAuditInfoRelations : AuditInfoRelations
	{
		/// <summary>CTor</summary>
		public OrderAuditInfoRelations()
		{
		}

		/// <summary>Gets all relations of the OrderAuditInfoEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = base.GetAllRelations();
			toReturn.Add(this.OrderEntityUsingOrderId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between OrderAuditInfoEntity and AuditActionTypeEntity over the m:1 relation they have, using the relation between the fields:
		/// OrderAuditInfo.AuditActionTypeId - AuditActionType.AuditActionTypeId
		/// </summary>
		public override IEntityRelation AuditActionTypeEntityUsingAuditActionTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AuditActionType", false);
				relation.AddEntityFieldPair(AuditActionTypeFields.AuditActionTypeId, OrderAuditInfoFields.AuditActionTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AuditActionTypeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrderAuditInfoEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between OrderAuditInfoEntity and OrderEntity over the m:1 relation they have, using the relation between the fields:
		/// OrderAuditInfo.OrderId - Order.OrderId
		/// </summary>
		public virtual IEntityRelation OrderEntityUsingOrderId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Order", false);
				relation.AddEntityFieldPair(OrderFields.OrderId, OrderAuditInfoFields.OrderId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrderEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrderAuditInfoEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between OrderAuditInfoEntity and UserEntity over the m:1 relation they have, using the relation between the fields:
		/// OrderAuditInfo.UserId - User.UserId
		/// </summary>
		public override IEntityRelation UserEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "User", false);
				relation.AddEntityFieldPair(UserFields.UserId, OrderAuditInfoFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrderAuditInfoEntity", true);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between OrderAuditInfoEntity and AuditInfoEntity over the 1:1 relation they have, which is used to build a target per entity hierarchy</summary>
		internal IEntityRelation RelationToSuperTypeAuditInfoEntity
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, false);
				relation.AddEntityFieldPair(AuditInfoFields.AuditInfoId, OrderAuditInfoFields.AuditInfoId);
				relation.IsHierarchyRelation=true;
				return relation;
			}
		}

		
		/// <summary>Returns the relation object the entity, to which this relation factory belongs, has with the subtype with the specified name</summary>
		/// <param name="subTypeEntityName">name of direct subtype which is a subtype of the current entity through the relation to return.</param>
		/// <returns>relation which makes the current entity a supertype of the subtype entity with the name specified, or null if not applicable/found</returns>
		public override IEntityRelation GetSubTypeRelation(string subTypeEntityName)
		{
			return null;
		}
		
		/// <summary>Returns the relation object the entity, to which this relation factory belongs, has with its supertype, if applicable.</summary>
		/// <returns>relation which makes the current entity a subtype of its supertype entity or null if not applicable/found</returns>
		public override IEntityRelation GetSuperTypeRelation()
		{
			return this.RelationToSuperTypeAuditInfoEntity;
		}

		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticOrderAuditInfoRelations
	{
		internal static readonly IEntityRelation AuditActionTypeEntityUsingAuditActionTypeIdStatic = new OrderAuditInfoRelations().AuditActionTypeEntityUsingAuditActionTypeId;
		internal static readonly IEntityRelation OrderEntityUsingOrderIdStatic = new OrderAuditInfoRelations().OrderEntityUsingOrderId;
		internal static readonly IEntityRelation UserEntityUsingUserIdStatic = new OrderAuditInfoRelations().UserEntityUsingUserId;

		/// <summary>CTor</summary>
		static StaticOrderAuditInfoRelations()
		{
		}
	}
}
