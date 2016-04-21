using System;
using System.Collections.Generic;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.Examples.Authorization.EntityClasses;

namespace SD.LLBLGen.Pro.Examples.Authorization.Authorizers
{
    /// <summary>
    /// This class is intended to be used as the Authorizer of the OrderDetails entities
    /// </summary>
    [DependencyInjectionInfo(typeof(OrderDetailsEntity), "AuthorizerToUse", ContextType = DependencyInjectionContextType.Singleton)]
    public class OrderDetailAuthorizer : NorthwindAuthorizerBase
    {
        /// <summary>
        /// Determines whether the caller is allowed to load the entity instance specified.
        /// </summary>
        /// <param name="entity">The entity instance to be loaded</param>
        /// <returns>true if the caller is allowed to load the entity specified, and false otherwise.</returns>
        public override bool CanLoadEntity(IEntityCore entity)
        {
            // Check the type of the passed in entity
            if (((EntityType)entity.LLBLGenProEntityTypeValue == EntityType.OrderDetailsEntity))
            {
                // Only members of the following groups are allowed to load the entity.
                if (IsUserInGroup("Sales") || IsUserInGroup("Marketing") || IsUserInGroup("Customer Relations"))
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
            if (((EntityType)entity.LLBLGenProEntityTypeValue == EntityType.OrderDetailsEntity))
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
            if (((EntityType)entity.LLBLGenProEntityTypeValue == EntityType.OrderDetailsEntity))
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
            if (((EntityType)entity.LLBLGenProEntityTypeValue == EntityType.OrderDetailsEntity))
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
        /// Determines whether the caller is authorized to get the specified field's data or not.
        /// </summary>
        /// <param name="entity">The envolved entity</param>
        /// <param name="fieldIndex">The index of the field envolved</param>
        /// <returns>true if the caller is authorized to get the specified field's data, else returns false.</returns>
        public override bool CanGetFieldValue(IEntityCore entity, int fieldIndex)
        {
            // Check the type of the passed in entity
            if (((EntityType)entity.LLBLGenProEntityTypeValue == EntityType.OrderDetailsEntity))
            {
                switch ((OrderDetailsFieldIndex)fieldIndex)
                {
                    // Of those who can load the entity, 
                    // Only members of Sales or Marketing groups can view the data of the Discount field
                    case OrderDetailsFieldIndex.Discount:
                        if (IsUserInGroup("Sales") || IsUserInGroup("Marketing"))
                        {
                            // Grant
                            return true;
                        }
                        else
                        { 
                            // Deny
                            return false;
                        }
                }
                // No restrictions for other fields.
                // Grant
                return true;
            }

            // Throw a Security Exception if a wrong entity type is used.
            throw new ORMSecurityException("This Authorizer can't be used with an entity of type " + entity.LLBLGenProEntityName);
        }

        /// <summary>
        /// Determines whether the caller is authorized to set the specified field's data or not.
        /// </summary>
        /// <param name="entity">The envolved entity</param>
        /// <param name="fieldIndex">The index of the field envolved</param>
        /// <returns>true if the caller is authorized to set the specified field's data, else returns false.</returns>
        public override bool CanSetFieldValue(IEntityCore entity, int fieldIndex)
        {
            // Check the type of the passed in entity
            if (((EntityType)entity.LLBLGenProEntityTypeValue == EntityType.OrderDetailsEntity))
            {
                // Of those who can load the entity, 
                // Only Sales Managers can set the data of the Discount field
                switch ((OrderDetailsFieldIndex)fieldIndex)
                {
                    case OrderDetailsFieldIndex.Discount:
                        if (IsUserInGroup("Sales") && IsUserInGroup("Managers"))
                        {
                            // Grant
                            return true;
                        }
                        else
                        { 
                            // Deny
                            return false;
                        }
                }
                // No restrictions for other fields.
                // Note: Only Sales members can Insert/Update OrderDetails.
                return true;
            }

            // Throw a Security Exception if a wrong entity type is used.
            throw new ORMSecurityException("This Authorizer can't be used with an entity of type " + entity.LLBLGenProEntityName);
        }        
    }
}