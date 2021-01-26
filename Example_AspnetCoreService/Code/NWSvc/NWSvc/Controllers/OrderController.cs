using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NWService.Dal.DatabaseSpecific;
using NWService.Dal.FactoryClasses;
using NWService.Dal.HelperClasses;
using NWService.Dtos.DtoClasses;
using NWService.Dtos.Persistence;
using SD.LLBLGen.Pro.QuerySpec;
using SD.LLBLGen.Pro.QuerySpec.Adapter;

namespace NWSvc.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class OrderController : ControllerBase
	{
		[HttpGet]
		public async Task<IEnumerable<Order>> GetAsync(string customerId)
		{
			// Use a queryspec query which is directly projected to the DTO class hierarchy
			// at hand and returned in a list. A limit is specified as the OrderBy will end up in 
			// a subquery which requires a limit. 
			var qf = new QueryFactory();
			var q = qf.Order.Where(OrderFields.CustomerId == customerId)
							.Limit(10000)
							.OrderBy(OrderFields.OrderId.Ascending()).ProjectToOrder(qf);
			
			using(var adapter = new DataAccessAdapter())
			{
				// asp.net core doesn't have a synchronization context so we don't need to 
				// call ConfigureAwait(false)
				return await adapter.FetchQueryAsync(q);
			}
		}


		[HttpPut]
		public bool Update(Order newValues)
		{
			using(var adapter = new DataAccessAdapter())
			{
				// First fetch the entity, which we'll then update
				var qf = new QueryFactory();
				var q = qf.Order.Where(OrderFields.OrderId.Equal(newValues.OrderId));
				var orderToUpdate = adapter.FetchFirst(q);
				if(orderToUpdate == null)
				{
					return false;
				}
				// Now update the entity with the values in the DTO. 
				// All values that are different will be updated
				orderToUpdate.UpdateFromOrder(newValues);
				// Entity has been updated, persist it and return the result.
				return adapter.SaveEntity(orderToUpdate);
			}
		}
	}
}