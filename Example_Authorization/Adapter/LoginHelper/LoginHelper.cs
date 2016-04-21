using System;
using System.Data;
using System.Configuration;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.Examples.Authorization.EntityClasses;
using SD.LLBLGen.Pro.Examples.Authorization.HelperClasses;
using System.Collections.Generic;
using SD.LLBLGen.Pro.Examples.Authorization.DatabaseSpecific;

namespace SD.LLBLGen.Pro.Examples.Authorization.Identity
{
    /// <summary>
    /// LoginHelper is used to access user information in a WinForm APP
    /// </summary>
    public static class LoginHelper
    {
        // contain the current logged in user
        private static UserEntity _currentUser;


        /// <summary>
        /// User logged out
        /// </summary>
        public static void Logout()
        {
            _currentUser = null;
        }

        /// <summary>
        /// Logins the specified user ID.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="password">The password.</param>
        /// <returns>A value indicating whether or not the user can access.</returns>
        public static bool Login(string userID, string password)
        {
            // load user data
            UserEntity user = new UserEntity(userID);

            // load groups which the user are member of.
            PrefetchPath2 prefetch = new PrefetchPath2(EntityType.UserEntity);
            prefetch.Add(UserEntity.PrefetchPathGroupCollectionViaUserGroup);

			using(DataAccessAdapter adapter = new DataAccessAdapter())
			{
				if(adapter.FetchEntity(user, prefetch))
				{
					// the user must exist and provide valid password
					if(!user.IsNew && user.Password == password)
					{
						_currentUser = user;
						return true;
					}
				}
			}
            return false;
        }


        /// <summary>
        /// Gets the user ID.
        /// </summary>
        /// <returns>The string userId of the current loggedIn user</returns>
        public static string GetUserID()
        {
            string userID = string.Empty;

            // verify the user is loggedId
            if (IsUserLoggedIn)
            {
                userID = _currentUser.UserId;
            }

            return userID;
        }


        /// <summary>
        /// Checks whether the current logged in User is a member of a specific group
        /// </summary>
        /// <param name="groupName">The group name to be checked</param>
        /// <returns>true if the current logged in User is a member of the passed in group</returns>
        public static bool IsUserInGroup(string groupName)
        {
            if (_currentUser != null && _currentUser.GroupCollectionViaUserGroup.Count > 0)
            {
                List<int> matches = _currentUser.GroupCollectionViaUserGroup.FindMatches(GroupFields.Name == groupName);
                if (matches.Count > 0)
                {
                    return true;
                }
            }
            return false;
        }


		/// <summary>
		/// Gets a value indicating whether the user is logged in.
		/// </summary>
		public static bool IsUserLoggedIn
		{
			get
			{
				return (_currentUser != null && !_currentUser.IsNew);
			}
		} 
    }
}