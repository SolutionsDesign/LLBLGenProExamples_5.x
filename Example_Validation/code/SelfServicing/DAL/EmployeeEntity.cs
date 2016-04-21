///////////////////////////////////////////////////////////////
// LLBLGen Pro Validation Example
//////////////////////////////////////////////////////////////
// This code uses LLBLGen Pro version: 4.x
// Powered by: Solutions Design.
//////////////////////////////////////////////////////////////

using System;
using System.Text;

using SD.LLBLGen.Pro.Examples.RegularExpressionHelper;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.EntityClasses
{
    /// <summary>
    /// Custom code that shows how to implement LLBLGen Pro unattended validation into the entity class at partial class.
    /// Here we override ValidateEntity method that isn't used by the LLBLGen Pro framework, but can be used by your own 
    /// code to validate an entity at any given moment.
    /// </summary>
    public partial class EmployeeEntity
    {
        #region Constants declaration section
        // error messages
        private const string HOME_PHONE_ERROR_MESSAGE = "Home phone is in incorrect format.";
        private const string POSTAL_CODE_ERROR_MESSAGE = "Postal code is in incorrect format.";
        private const string BIRTH_DATE_ERROR_MESSAGE = "Birth date is in incorrect format.";
        private const string HIRE_DATE_ERROR_MESSAGE = "Hire date must greater than Birth date.";
        private const string DELIMITER = ";";
        #endregion

        /// <summary>
        /// General validation method which isn't used by the LLBLGen Pro framework, but can be used by your own code to validate an entity at any given moment.
        /// </summary>
        public override void ValidateEntity()
        {
            // variable to collect errors
            StringBuilder sbExceptionMessage = new StringBuilder();

            // ** phone in incorrect format
            /// check if phone comes in correct format for US-Employees
            if (!string.IsNullOrEmpty(HomePhone) &&
                Country == "USA" &&
                !RegexHelper.IsValidUSPhoneNumber(HomePhone))
            {
                // add the error info to the message
                sbExceptionMessage.Append(HOME_PHONE_ERROR_MESSAGE + DELIMITER);                
            }


            // ** PostalCode in incorrect format            
            if (!string.IsNullOrEmpty(PostalCode) &&
                !RegexHelper.IsValidZIPCode(this.PostalCode))
            {
                // add the error info to the message
                sbExceptionMessage.Append(POSTAL_CODE_ERROR_MESSAGE + DELIMITER);
            }


            // ** Birth date must be smaller than today
            // assuming we are able to register babies too :)
            if (BirthDate != null &&
                !(BirthDate < DateTime.Now))
            {
                // add the error info to the message
                sbExceptionMessage.Append(BIRTH_DATE_ERROR_MESSAGE + DELIMITER);
            }


            // ** HireDate must be greater than BirthDate
            // assuming we are able to hire babies too :D
            if (HireDate != null && BirthDate != null &&
                !(HireDate > BirthDate))
            {
                // add the error info to the message
                sbExceptionMessage.Append(HIRE_DATE_ERROR_MESSAGE + DELIMITER);
            }


            // -- add more validations --
            // ...

            // get the errors collected
            string strExceptionMessage = sbExceptionMessage.ToString();

            // Do exist any break rule in this entity?
            if (strExceptionMessage != string.Empty)
            {
                // set error info so we can access that outside
                this.SetEntityError(strExceptionMessage);

                // throws an exception with all the breaking rules info
                throw new ORMEntityValidationException(strExceptionMessage, this);
            }
            
            base.ValidateEntity();
        }
    }
}
