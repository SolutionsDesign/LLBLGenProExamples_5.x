using System;
using System.Collections.Generic;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.Examples.Authorization.Identity;

namespace SD.LLBLGen.Pro.Examples.Authorization.Authorizers
{
    /// <summary>
    /// A common base class for the Authorizers classes
    /// </summary>
    public class NorthwindAuthorizerBase : AuthorizerBase
    {
        /// <summary>
        /// Checks if the logged in user is a member of a specific group
        /// </summary>
        /// <param name="groupName">Group name to check</param>
        /// <returns>true if the user is a member and false if not</returns>
        protected bool IsUserInGroup(string groupName)
        {
            return LoginHelper.IsUserInGroup(groupName);
        }
    }
}
