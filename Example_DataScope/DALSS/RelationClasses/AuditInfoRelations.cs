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
	/// <summary>Implements the relations factory for the entity: AuditInfo. </summary>
	public partial class AuditInfoRelations : IRelationFactory
	{
		/// <summary>CTor</summary>
		public AuditInfoRelations()
		{
		}

		/// <summary>Gets all relations of the AuditInfoEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AuditActionTypeEntityUsingAuditActionTypeId);
			toReturn.Add(this.UserEntityUsingUserId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between AuditInfoEntity and AuditActionTypeEntity over the m:1 relation they have, using the relation between the fields:
		/// AuditInfo.AuditActionTypeId - AuditActionType.AuditActionTypeId
		/// </summary>
		public virtual IEntityRelation AuditActionTypeEntityUsingAuditActionTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AuditActionType", false);
				relation.AddEntityFieldPair(AuditActionTypeFields.AuditActionTypeId, AuditInfoFields.AuditActionTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AuditActionTypeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AuditInfoEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between AuditInfoEntity and UserEntity over the m:1 relation they have, using the relation between the fields:
		/// AuditInfo.UserId - User.UserId
		/// </summary>
		public virtual IEntityRelation UserEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "User", false);
				relation.AddEntityFieldPair(UserFields.UserId, AuditInfoFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AuditInfoEntity", true);
				return relation;
			}
		}



		/// <summary>Returns a new IEntityRelation object, between AuditInfoEntity and OrderAuditInfoEntity over the 1:1 relation they have, which is used to build a target per entity hierarchy</summary>		
		internal IEntityRelation RelationToSubTypeOrderAuditInfoEntity
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, true);
				relation.AddEntityFieldPair(AuditInfoFields.AuditInfoId, OrderAuditInfoFields.AuditInfoId);
				relation.IsHierarchyRelation=true;
				return relation;
			}
		}
		
		/// <summary>Returns the relation object the entity, to which this relation factory belongs, has with the subtype with the specified name</summary>
		/// <param name="subTypeEntityName">name of direct subtype which is a subtype of the current entity through the relation to return.</param>
		/// <returns>relation which makes the current entity a supertype of the subtype entity with the name specified, or null if not applicable/found</returns>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName)
		{
			switch(subTypeEntityName)
			{
				case "OrderAuditInfoEntity":
					return this.RelationToSubTypeOrderAuditInfoEntity;
				default:
					return null;
			}
		}
		
		/// <summary>Returns the relation object the entity, to which this relation factory belongs, has with its supertype, if applicable.</summary>
		/// <returns>relation which makes the current entity a subtype of its supertype entity or null if not applicable/found</returns>
		public virtual IEntityRelation GetSuperTypeRelation()
		{
			return null;
		}

		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticAuditInfoRelations
	{
		internal static readonly IEntityRelation AuditActionTypeEntityUsingAuditActionTypeIdStatic = new AuditInfoRelations().AuditActionTypeEntityUsingAuditActionTypeId;
		internal static readonly IEntityRelation UserEntityUsingUserIdStatic = new AuditInfoRelations().UserEntityUsingUserId;

		/// <summary>CTor</summary>
		static StaticAuditInfoRelations()
		{
		}
	}
}
