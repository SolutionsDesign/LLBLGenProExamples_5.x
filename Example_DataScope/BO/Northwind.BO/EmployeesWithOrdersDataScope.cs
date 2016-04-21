using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Northwind.DAL.HelperClasses;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.FactoryClasses;
using Northwind.DAL.DatabaseSpecific;
using SD.LLBLGen.Pro.QuerySpec;
using SD.LLBLGen.Pro.QuerySpec.Adapter;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.LinqSupportClasses;
using Northwind.DAL;
using Northwind.DAL.Linq;

namespace Northwind.BO
{
	public class EmployeesWithOrdersDataScope : DataScope
	{
		#region Class Member Declarations
		private EntityCollection<EmployeeEntity> _employees;
		#endregion

		public EmployeesWithOrdersDataScope() : base(DataScopeRefetchStrategyType.MarkSavedEntitiesAsFetched)
		{
			_employees = new EntityCollection<EmployeeEntity>();
		}


		public void CommitChanges()
		{
			using(var adapter = new DataAccessAdapter())
			{
				this.CommitChanges(adapter);
			}
		}


		protected override bool FetchDataImpl(params object[] fetchMethodParameters)
		{
			using(var adapter = new DataAccessAdapter())
			{
				// Linq
				var metaData = new LinqMetaData(adapter);
				var q = this.TrackQuery(metaData.Employee.WithPath(p => p.Prefetch(e => e.Orders)));
				_employees = ((ILLBLGenProQuery)q).Execute<EntityCollection<EmployeeEntity>>();

				// Queryspec
				//var qf = new QueryFactory();
				//var q = qf.Employee.WithPath(EmployeeEntity.PrefetchPathOrders);
				//adapter.FetchQuery(this.TrackQuery(q), _employees);
			}
			return _employees.Count > 0;		
		}


		protected override void OnReset()
		{
			base.OnReset();
			if(_employees != null)
			{
				_employees.Clear();
			}
		}


		protected override void OnEntityDelete(IEntityCore toDelete, WorkDataCollector workData)
		{
			base.OnEntityDelete(toDelete, workData);
			switch((EntityType)toDelete.LLBLGenProEntityTypeValue)
			{
				case EntityType.OrderEntity:
					workData.Add(OrderEntity.Relations.OrderAuditInfoEntityUsingOrderId);
					workData.Add(OrderEntity.Relations.OrderDetailEntityUsingOrderId);
					break;
			}
		}

		#region Class Property Declarations
		public EntityCollection<EmployeeEntity> Employees
		{
			get { return _employees; }
		}
		#endregion
	}
}
