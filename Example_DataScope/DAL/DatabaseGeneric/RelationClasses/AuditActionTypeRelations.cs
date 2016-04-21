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
using Northwind.DAL;
using Northwind.DAL.FactoryClasses;
using Northwind.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.DAL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: AuditActionType. </summary>
	public partial class AuditActionTypeRelations
	{
		/// <summary>CTor</summary>
		public AuditActionTypeRelations()
		{
		}

		/// <summary>Gets all relations of the AuditActionTypeEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AuditInfoEntityUsingAuditActionTypeId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between AuditActionTypeEntity and AuditInfoEntity over the 1:n relation they have, using the relation between the fields:
		/// AuditActionType.AuditActionTypeId - AuditInfo.AuditActionTypeId
		/// </summary>
		public virtual IEntityRelation AuditInfoEntityUsingAuditActionTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AuditInfos" , true);
				relation.AddEntityFieldPair(AuditActionTypeFields.AuditActionTypeId, AuditInfoFields.AuditActionTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AuditActionTypeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AuditInfoEntity", false);
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
	internal static class StaticAuditActionTypeRelations
	{
		internal static readonly IEntityRelation AuditInfoEntityUsingAuditActionTypeIdStatic = new AuditActionTypeRelations().AuditInfoEntityUsingAuditActionTypeId;

		/// <summary>CTor</summary>
		static StaticAuditActionTypeRelations()
		{
		}
	}
}
