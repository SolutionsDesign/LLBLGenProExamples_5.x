///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: donderdag 21 april 2016 11:36:43
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using SD.LLBLGen.Pro.Examples.Auditing;
using SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses;
using SD.LLBLGen.Pro.Examples.Auditing.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.Auditing.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Employee. </summary>
	public partial class EmployeeRelations
	{
		/// <summary>CTor</summary>
		public EmployeeRelations()
		{
		}

		/// <summary>Gets all relations of the EmployeeEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.EmployeeEntityUsingReportsTo);
			toReturn.Add(this.EmployeeTerritoryEntityUsingEmployeeId);
			toReturn.Add(this.OrderEntityUsingEmployeeId);
			toReturn.Add(this.EmployeeEntityUsingEmployeeIdReportsTo);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and EmployeeEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - Employee.ReportsTo
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingReportsTo
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Employees_" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, EmployeeFields.ReportsTo);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and EmployeeTerritoryEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - EmployeeTerritory.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeTerritoryEntityUsingEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "EmployeeTerritories" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, EmployeeTerritoryFields.EmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeTerritoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and OrderEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - Order.EmployeeId
		/// </summary>
		public virtual IEntityRelation OrderEntityUsingEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Orders" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, OrderFields.EmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrderEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// Employee.ReportsTo - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingEmployeeIdReportsTo
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employees", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, EmployeeFields.ReportsTo);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
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
	internal static class StaticEmployeeRelations
	{
		internal static readonly IEntityRelation EmployeeEntityUsingReportsToStatic = new EmployeeRelations().EmployeeEntityUsingReportsTo;
		internal static readonly IEntityRelation EmployeeTerritoryEntityUsingEmployeeIdStatic = new EmployeeRelations().EmployeeTerritoryEntityUsingEmployeeId;
		internal static readonly IEntityRelation OrderEntityUsingEmployeeIdStatic = new EmployeeRelations().OrderEntityUsingEmployeeId;
		internal static readonly IEntityRelation EmployeeEntityUsingEmployeeIdReportsToStatic = new EmployeeRelations().EmployeeEntityUsingEmployeeIdReportsTo;

		/// <summary>CTor</summary>
		static StaticEmployeeRelations()
		{
		}
	}
}
