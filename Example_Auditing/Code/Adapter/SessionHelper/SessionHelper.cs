using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using SD.LLBLGen.Pro.Examples.Auditing.EntityClasses;
using SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific;
using SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses;
using SD.LLBLGen.Pro.Examples.Auditing.HelperClasses;

using System.Collections;
using System.Collections.Generic;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.Auditing
{
    /// <summary>
    /// SessionAdapter is used to access session objects
    /// </summary>
    public static class SessionHelper
    {
        /// <summary>
        /// Cancels the current Session.
        /// </summary>
        public static void Abandon()
        {
            HttpContext.Current.Session.Abandon();
        }


        /// <summary>
        /// Loads the user and his rights and audits to the session object.
        /// </summary>
        /// <param name="user">The user to be added to the session.</param>
        public static void LoadUserSessionData(UserEntity user)
        {
            // Adds the user object to session
            AddUserObject(user);
        }


        #region Managing UserEntity Session object
        /// <summary>
        /// Adds the user object to session.
        /// If the object already exists, it is overwritten with the new value.
        /// </summary>
        /// <param name="user">The user object to be saved</param>
        public static void AddUserObject(UserEntity user)
        {
            //Adds a new item to the session-state collection.
            //If the name parameter refers to an existing session state item, the existing item is overwritten with the specified value.
            HttpContext.Current.Session.Add("user", user);
        }

        /// <summary>
        /// Gets the user object from session.
        /// </summary>
        /// <returns>User Entity object if found, otherwise returns null</returns>
        private static UserEntity GetUserObject()
        {
            if (HttpContext.Current.Session["user"] != null)
            {
                return (UserEntity)HttpContext.Current.Session["user"];
            }

            return null;
        }

        /// <summary>
        /// Gets the user ID from session.
        /// </summary>
        /// <returns>UserID if there is a user object in the session, otherwise returns Zero</returns>
        public static string GetUserID()
        {
            // userID to return
            string toReturn = string.Empty;
            
            // get user from session
            UserEntity user = GetUserObject();
            if (user != null)
            {
                toReturn = user.UserId;
            }

            // return current userID
            return toReturn;
        }
        

        /// <summary>
        /// Gets user full name from the session.
        /// </summary>
        /// <returns>User nick name</returns>
        public static string GetUserFullName()
        {
            // name to return
            string toReturn = string.Empty;

            // get current user from session
            UserEntity user = GetUserObject();
            if (user != null)
            {
                toReturn = user.FullName;
            }

            // return current user fullName
            return toReturn;
        }


        #endregion
    }
}