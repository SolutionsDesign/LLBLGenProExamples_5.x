using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.QuerySpec;
using SD.LLBLGen.Pro.QuerySpec.SelfServicing;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.LinqSupportClasses;
using Northwind.SSDAL.CollectionClasses;
using Northwind.SSDAL.HelperClasses;
using Northwind.SSDAL.Linq;
using Northwind.SSDAL.FactoryClasses;
using Northwind.SSDAL.EntityClasses;
using Northwind.SSDAL;

namespace Northwind.BO
{
	public class SSEmployeesWithOrdersDataScope : DataScope
	{
		#region Class Member Declarations
		private EmployeeCollection _employees;
		#endregion

		public SSEmployeesWithOrdersDataScope()
		{
			_employees = new EmployeeCollection();
		}


		public void CommitChanges()
		{
			using(var trans = new Transaction(System.Data.IsolationLevel.ReadCommitted, "DataScopeTrans"))
			{
				this.CommitChanges(trans);
			}
		}


		protected override bool FetchDataImpl(params object[] fetchMethodParameters)
		{
			// Linq
			//var metaData = new LinqMetaData();
			//var q = this.TrackQuery(metaData.Employee.WithPath(p => p.Prefetch(e => e.Orders)));
			//_employees = ((ILLBLGenProQuery)q).Execute<EmployeeCollection>();

			// Queryspec
			var qf = new QueryFactory();
			var q = qf.Employee.WithPath(EmployeeEntity.PrefetchPathOrders);
			_employees = new EmployeeCollection();
			_employees.GetMulti(this.TrackQuery(q));
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
		public EmployeeCollection Employees
		{
			get { return _employees; }
		}
		#endregion
	}
}
