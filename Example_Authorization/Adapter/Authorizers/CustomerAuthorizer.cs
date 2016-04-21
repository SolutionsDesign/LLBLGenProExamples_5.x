using System;
using System.Collections.Generic;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.Examples.Authorization.EntityClasses;

namespace SD.LLBLGen.Pro.Examples.Authorization.Authorizers
{
    /// <summary>
    /// This class is intended to be used as the Authorizer of the Customers entities
    /// </summary>
    [DependencyInjectionInfo(typeof(CustomersEntity), "AuthorizerToUse", ContextType = DependencyInjectionContextType.Singleton)]
    public class CustomerAuthorizer : NorthwindAuthorizerBase
    {
        /// <summary>
        /// Determines whether the caller is allowed to load the entity instance specified.
        /// </summary>
        /// <param name="entity">The entity instance to be loaded</param>
        /// <returns>true if the caller is allowed to load the entity specified, and false otherwise.</returns>
        public override bool CanLoadEntity(IEntityCore entity)
        {
            // Check the type of the passed in entity
            if (((EntityType)entity.LLBLGenProEntityTypeValue == EntityType.CustomersEntity))
            {
                // Only members of the following groups are allowed to load the entity.
                if (IsUserInGroup("Customer Relations") || IsUserInGroup("Sales") || IsUserInGroup("Marketing"))
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
            if (((EntityType)entity.LLBLGenProEntityTypeValue == EntityType.CustomersEntity))
            {
                //Only members of the following groups can update the entity
                if (IsUserInGroup("Customer Relations"))
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
            if (((EntityType)entity.LLBLGenProEntityTypeValue == EntityType.CustomersEntity))
            {
                //Only members of the following groups can update the entity
                if (IsUserInGroup("Customer Relations"))
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
            if (((EntityType)entity.LLBLGenProEntityTypeValue == EntityType.CustomersEntity))
            {
                //Only members of the following groups can update the entity
                if (IsUserInGroup("Customer Relations") && IsUserInGroup("Managers"))
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