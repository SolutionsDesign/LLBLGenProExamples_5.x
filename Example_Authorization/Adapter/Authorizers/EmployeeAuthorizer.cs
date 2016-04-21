using System;
using System.Collections.Generic;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.Examples.Authorization.EntityClasses;

namespace SD.LLBLGen.Pro.Examples.Authorization.Authorizers
{
    /// <summary>
    /// This class is intended to be used as the Authorizer of the Employee entities
    /// </summary>
    [DependencyInjectionInfo(typeof(EmployeesEntity), "AuthorizerToUse", ContextType = DependencyInjectionContextType.Singleton)]
    public class EmployeeAuthorizer : NorthwindAuthorizerBase
    {
        /// <summary>
        /// Determines whether the caller is allowed to load the entity instance specified.
        /// </summary>
        /// <param name="entity">The entity instance to be loaded</param>
        /// <returns>true if the caller is allowed to load the entity specified, and false otherwise.</returns>
        public override bool CanLoadEntity(IEntityCore entity)
        {
            // Check the type of the passed in entity
            if (((EntityType)entity.LLBLGenProEntityTypeValue == EntityType.EmployeesEntity))
            {
                // Human Resources members can view Employees records.
                if (IsUserInGroup("Human Resources"))
                {
                    //Grant
                    return true;
                }
                // Legal members can view Employees records in their country.
                else if (IsUserInGroup("Legal"))
                {
                    if (IsUserInGroup(((EmployeesEntity)entity).Country))
                    {
                        return true;
                    }
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
            if (((EntityType)entity.LLBLGenProEntityTypeValue == EntityType.EmployeesEntity))
            {
                //Only members of the following groups can update the entity
                if (IsUserInGroup("Human Resources"))
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
            if (((EntityType)entity.LLBLGenProEntityTypeValue == EntityType.EmployeesEntity))
            {
                //Only members of the following groups can update the entity
                if (IsUserInGroup("Human Resources"))
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
            if (((EntityType)entity.LLBLGenProEntityTypeValue == EntityType.EmployeesEntity))
            {
                //Only members of the following groups can update the entity
                if (IsUserInGroup("Human Resources") && IsUserInGroup("Managers"))
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
        /// Gets the result hint what to do when authorization fails when fetch a new entity within a collection.
        /// </summary>
        /// <returns>
        /// FetchNewAuthorizationFailureResultHint.ClearData: Clear the data of the entity. The entity is added to the collection, if the fetch was a collection fetch.  
        /// FetchNewAuthorizationFailureResultHint.ThrowAway: The entity is thrown out and not added to a collection, if the fetch was a collection fetch. This is the default. 
        ///</returns>
        public override FetchNewAuthorizationFailureResultHint GetFetchNewAuthorizationFailureResultHint()
        {
            // You are invited to change the returned value and examine the difference in the GUI.
            
            return FetchNewAuthorizationFailureResultHint.ThrowAway;
            //return FetchNewAuthorizationFailureResultHint.ClearData;
        }
    }
}
