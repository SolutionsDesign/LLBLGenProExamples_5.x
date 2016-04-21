
using System;
using System.Data;
using System.Configuration;

using SD.LLBLGen.Pro.Examples.Auditing.EntityClasses;
using SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses;
using SD.LLBLGen.Pro.Examples.Auditing.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.Auditing
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
            // indicates whether or not the login was successfull
            bool loginSuccessfully = false;

            // load user data
            UserEntity user = new UserEntity(userID);

            // the user must exist and provide valid password
            if (!user.IsNew && user.Password == password)
            {
                _currentUser = user;
                loginSuccessfully = true;
            }

            return loginSuccessfully;
        }

        /// <summary>
        /// Gets a value indicating whether the user is user logged in.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if the user is logged in; otherwise, <c>false</c>.
        /// </value>
        public static bool IsUserLoggedIn
        {
            get
            {
                return (_currentUser != null && !_currentUser.IsNew);
            }
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
  
    }
}