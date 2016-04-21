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
	/// <summary>Implements the relations factory for the entity: Employees. </summary>
	public partial class EmployeesRelations
	{
		/// <summary>CTor</summary>
		public EmployeesRelations()
		{
		}

		/// <summary>Gets all relations of the EmployeesEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.EmployeesEntityUsingReportsTo);
			toReturn.Add(this.OrdersEntityUsingEmployeeId);
			toReturn.Add(this.EmployeesEntityUsingEmployeeIdReportsTo);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between EmployeesEntity and EmployeesEntity over the 1:n relation they have, using the relation between the fields:
		/// Employees.EmployeeId - Employees.ReportsTo
		/// </summary>
		public virtual IEntityRelation EmployeesEntityUsingReportsTo
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Employees_" , true);
				relation.AddEntityFieldPair(EmployeesFields.EmployeeId, EmployeesFields.ReportsTo);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeesEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeesEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeesEntity and OrdersEntity over the 1:n relation they have, using the relation between the fields:
		/// Employees.EmployeeId - Orders.EmployeeId
		/// </summary>
		public virtual IEntityRelation OrdersEntityUsingEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Orders" , true);
				relation.AddEntityFieldPair(EmployeesFields.EmployeeId, OrdersFields.EmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeesEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("OrdersEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between EmployeesEntity and EmployeesEntity over the m:1 relation they have, using the relation between the fields:
		/// Employees.ReportsTo - Employees.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeesEntityUsingEmployeeIdReportsTo
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employees", false);
				relation.AddEntityFieldPair(EmployeesFields.EmployeeId, EmployeesFields.ReportsTo);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeesEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeesEntity", true);
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
	internal static class StaticEmployeesRelations
	{
		internal static readonly IEntityRelation EmployeesEntityUsingReportsToStatic = new EmployeesRelations().EmployeesEntityUsingReportsTo;
		internal static readonly IEntityRelation OrdersEntityUsingEmployeeIdStatic = new EmployeesRelations().OrdersEntityUsingEmployeeId;
		internal static readonly IEntityRelation EmployeesEntityUsingEmployeeIdReportsToStatic = new EmployeesRelations().EmployeesEntityUsingEmployeeIdReportsTo;

		/// <summary>CTor</summary>
		static StaticEmployeesRelations()
		{
		}
	}
}
