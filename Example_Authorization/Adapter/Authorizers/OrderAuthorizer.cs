using System;
using System.Collections.Generic;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.Examples.Authorization.EntityClasses;
using SD.LLBLGen.Pro.Examples.Authorization.DatabaseSpecific;
using SD.LLBLGen.Pro.Examples.Authorization.HelperClasses;

namespace SD.LLBLGen.Pro.Examples.Authorization.Authorizers
{
    /// <summary>
    /// This class is intended to be used as the Authorizer of the Orders entities
    /// </summary>
    [DependencyInjectionInfo(typeof(OrdersEntity), "AuthorizerToUse", ContextType = DependencyInjectionContextType.Singleton)]
    public class OrderAuthorizer : NorthwindAuthorizerBase
    {
        /// <summary>
        /// Determines whether the caller is allowed to load the entity instance specified.
        /// </summary>
        /// <param name="entity">The entity instance to be loaded</param>
        /// <returns>true if the caller is allowed to load the entity specified, and false otherwise.</returns>
        public override bool CanLoadEntity(IEntityCore entity)
        {
            // Check the type of the passed in entity
            if (((EntityType)entity.LLBLGenProEntityTypeValue == EntityType.OrdersEntity))
            {
                // The following will execute a query for each Order, which is probably not the most efficient thing to do.
                // This is just used for demo purposes and for authorization proof of concept.
                // You may use prefetchPaths to fetch order details up front with the orders 
                // so the calculations can be done in memory, though this requires that the order detail entities are prefetched always. 
                // Also you can extend the OrderFactory to add a scalar field for the order total.
				// See: http://weblogs.asp.net/fbouma/archive/2006/06/09/LLBLGen-Pro-v2.0-with-ASP.NET-2.0.aspx
				// for details how to do that.
                DataAccessAdapter adapter = new DataAccessAdapter();
                object orderTotalObj = (object)adapter.GetScalar(OrderDetailsFields.OrderId,
                        (OrderDetailsFields.Quantity * OrderDetailsFields.UnitPrice), AggregateFunction.Sum,
                        (OrderDetailsFields.OrderId == ((OrdersEntity)entity).OrderId), new GroupByCollection(OrderDetailsFields.OrderId));

                decimal orderTotal = 0;
                if (orderTotalObj != null)
                {
                    orderTotal = (decimal)orderTotalObj;
                }
                // Only Sales Managers can view Orders with a total sum >= 10,000.
                if (orderTotal >= 10000)
                {
                    if (IsUserInGroup("Sales") && IsUserInGroup("Manager"))
                    {
                        return true;
                    }
                    else 
                    {
                        return false;
                    }
                }
                // Members of the following groups are allowed to load Orders of total sum < 10,000.
                else if (IsUserInGroup("Sales") || IsUserInGroup("Marketing") || IsUserInGroup("Customer Relations"))
                {
                    //Grant
                    return true;
                }

                //Deny
                return false;
            }

            // Throw a Security Exception if a wrong entity type is used.
            throw new ORMSecurityException("This Authorizer can't be used with an entity of type " + entity.LLBLGenProEntityName);
        }

        /// <summary>
        /// Determines whether the caller is allowed to update the entity instance specified.
        /// </summary>
        /// <param name="entity">The entity instance to be updated</param>
        /// <returns>true if the caller has the authority to update the entity</returns>
        public override bool CanSaveExistingEntity(IEntityCore entity)
        {
            // Check the type of the passed in entity
            if (((EntityType)entity.LLBLGenProEntityTypeValue == EntityType.OrdersEntity))
            {
                //Only members of the following groups can update the entity
                if (IsUserInGroup("Sales"))
                {
                    //Grant
                    return true;
                }
                //Deny
                return false;
            }

            // Throw a Security Exception if a wrong entity type is used.
            throw new ORMSecurityException("This Authorizer can't be used with an entity of type " + entity.LLBLGenProEntityName);
        }

        /// <summary>
        /// Determines whether the caller is allowed to insert the entity instance specified.
        /// </summary>
        /// <param name="entity">The entity instance to be inserted</param>
        /// <returns>true if the caller has the authority to insert the entity</returns>
        public override bool CanSaveNewEntity(IEntityCore entity)
        {
            // Check the type of the passed in entity
            if (((EntityType)entity.LLBLGenProEntityTypeValue == EntityType.OrdersEntity))
            {
                //Only members of the following groups can update the entity
                if (IsUserInGroup("Sales"))
                {
                    //Grant
                    return true;
                }
                //Deny
                return false;
            }

            // Throw a Security Exception if a wrong entity type is used.
            throw new ORMSecurityException("This Authorizer can't be used with an entity of type " + entity.LLBLGenProEntityName);
        }

        /// <summary>
        /// Determines whether the caller is allowed to delete the entity instance specified.
        /// </summary>
        /// <param name="entity">The entity instance to be deleted</param>
        /// <returns>true if the caller has the authority to delete the entity</returns>
        public override bool CanDeleteEntity(IEntityCore entity)
        {
            // Check the type of the passed in entity
            if (((EntityType)entity.LLBLGenProEntityTypeValue == EntityType.OrdersEntity))
            {
                //Only members of the following groups can update the entity
                if (IsUserInGroup("Sales") && IsUserInGroup("Managers"))
                {
                    //Grant
                    return true;
                }
                //Deny
                return false;
            }

            // Throw a Security Exception if a wrong entity type is used.
            throw new ORMSecurityException("This Authorizer can't be used with an entity of type " + entity.LLBLGenProEntityName);
        }
    }
}