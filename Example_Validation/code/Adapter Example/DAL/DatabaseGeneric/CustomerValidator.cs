///////////////////////////////////////////////////////////////
// LLBLGen Pro v3.5 - Validation Example
//////////////////////////////////////////////////////////////
// This code uses LLBLGen Pro version: 3.5
// Powered by: Solutions Design.
//////////////////////////////////////////////////////////////


using System;
using System.Text;

using SD.LLBLGen.Pro.Examples;
using SD.LLBLGen.Pro.Examples.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.Examples.RegularExpressionHelper;

namespace SD.LLBLGen.Pro.Examples.Validators
{
    /// <summary>
    /// Validator class intended to demonstrate how to succesfully do a entity-based validation.
    /// This part of the example demonstrates how to create a validator class that is seted overriding 
    /// OnInitializing entity method. Please open CustomerEntityExtended partial class to see the 
    /// initialization. For more information please consult the LLBLGen Pro documentation.
    /// </summary>
    /// <remarks>
    /// This validator is wrote for CustomerEntity instances.
    /// </remarks>
    [Serializable]
    public class CustomerValidator : ValidatorBase
    {
        #region Constants declaration section
        private const string PHONE_INCORRECT_FORMAT_ERROR_MESSAGE = "Phone field is in incorrect format.";
        private const string FAX_INCORRECT_FORMAT_ERROR_MESSAGE = "Fax field is in incorrect format.";
        private const string ADDRESS_INCORRECT_FORMAT_ERROR_MESSAGE = "Address field is in incorrect format.";
        private const string CONTACT_NAME_INCORRECT_FORMAT_ERROR_MESSAGE = "ContactName field is in incorrect format.";
        private const string CONTACT_TITLE_INCORRECT_FORMAT_ERROR_MESSAGE = "ContactTitle field is in incorrect format.";
        private const string COMPANY_NAME_INCORRECT_FORMAT_ERROR_MESSAGE = "CompanyName field is in incorrect format.";
        private const string CITY_INCORRECT_FORMAT_ERROR_MESSAGE = "City field is in incorrect format.";
        private const string POSTAL_CODE_INCORRECT_FORMAT_ERROR_MESSAGE = "PostalCode field is in incorrect format.";
        private const string COUNTRY_INCORRECT_FORMAT_ERROR_MESSAGE = "Country field is in incorrect format.";        
        private const string CUSTOMER_INVALID_DELETE_ERROR_MESSAGE = "Can't delete a Customer with Orders related.";        
        private const string DELIMITER = ";";
        #endregion

        /// <summary>
        /// Validates the given EntityFieldCore object on the given fieldIndex with the given value.
        /// This routine is called by the Entity's own value validator after the value has passed validation for destination column type and
        /// null values.
        /// </summary>
        /// <param name="involvedEntity">The involved entity.</param>
        /// <param name="fieldIndex">Index of IEntityFieldCore to validate</param>
        /// <param name="value">Value which should be stored in field with index fieldIndex. Will not be null (earlier logic filters out nulls before
        /// a call will be made to this routine).</param>
        /// <returns>
        /// true if the value is valid for the field, false otherwise
        /// </returns>
        /// <remarks>Use the entity.SetEntityFieldError() and entity.SetEntityError() methods if you want to set a IDataErrorInfo error string after the
        /// validation.</remarks>
        public override bool ValidateFieldValue(IEntityCore involvedEntity, int fieldIndex, object value)
        {

            // value to return
            bool fieldIsValid = true;

            if (value != null)
            {
                #region Inspect fieldIndex to determinate if they are in a correct format
                switch ((CustomerFieldIndex)fieldIndex)
                {
                    #region Phone
                    case CustomerFieldIndex.Phone:

                        /// check if phone comes in correct format ofr US-Customers
                        if (((CustomerEntity) involvedEntity).Country == "USA" &&
                            !RegexHelper.IsValidUSPhoneNumber((string)value))
                        {
                            // set error info, so we could check that outside
                            involvedEntity.SetEntityFieldError(CustomerFieldIndex.Phone.ToString(), PHONE_INCORRECT_FORMAT_ERROR_MESSAGE, false);
                            fieldIsValid = false;
                        }
                        else
                        {
                            // everything seems to be OK with this field so we clean the error info.
                            involvedEntity.SetEntityFieldError(CustomerFieldIndex.Phone.ToString(), "", false);
                        }
                        break;
                    #endregion

                    #region Fax
                    case CustomerFieldIndex.Fax:

                        /// check if fax comes in correct format for US-Customers
                        if (((CustomerEntity)involvedEntity).Country == "USA" &&
                            !RegexHelper.IsValidUSPhoneNumber((string)value))
                        {
                            // set error info, so we could check that outside
                            involvedEntity.SetEntityFieldError(CustomerFieldIndex.Fax.ToString(), FAX_INCORRECT_FORMAT_ERROR_MESSAGE, false);
                            fieldIsValid = false;
                        }
                        else
                        {
                            // everything seems to be OK with this field so we clean the error info.
                            involvedEntity.SetEntityFieldError(CustomerFieldIndex.Fax.ToString(), "", false);
                        }
                        break;
                    #endregion

                    #region Address
                    case CustomerFieldIndex.Address:

                        /// check if Address comes in correct format
                        if (!RegexHelper.IsValidStreetAddress((string)value))
                        {
                            // set error info, so we could check that outside
                            involvedEntity.SetEntityFieldError(CustomerFieldIndex.Address.ToString(), ADDRESS_INCORRECT_FORMAT_ERROR_MESSAGE, false);
                            fieldIsValid = false;
                        }
                        else
                        {
                            // everything seems to be OK with this field so we clean the error info.
                            involvedEntity.SetEntityFieldError(CustomerFieldIndex.Address.ToString(), "", false);
                        }
                        break;
                    #endregion

                    #region City
                    case CustomerFieldIndex.City:

                        /// check if City comes in correct format
                        if (!RegexHelper.IsValidName((string)value))
                        {
                            // set error info, so we could check that outside
                            involvedEntity.SetEntityFieldError(CustomerFieldIndex.City.ToString(), CITY_INCORRECT_FORMAT_ERROR_MESSAGE, false);
                            fieldIsValid = false;
                        }
                        else
                        {
                            // everything seems to be OK with this field so we clean the error info.
                            involvedEntity.SetEntityFieldError(CustomerFieldIndex.City.ToString(), "", false);
                        }
                        break;
                    #endregion

                    #region Country
                    case CustomerFieldIndex.Country:

                        /// check if Country comes in correct format
                        if (!RegexHelper.IsValidName((string)value))
                        {
                            // set error info, so we could check that outside
                            involvedEntity.SetEntityFieldError(CustomerFieldIndex.Country.ToString(), COUNTRY_INCORRECT_FORMAT_ERROR_MESSAGE, false);
                            fieldIsValid = false;
                        }
                        else
                        {
                            // everything seems to be OK with this field so we clean the error info.
                            involvedEntity.SetEntityFieldError(CustomerFieldIndex.Country.ToString(), "", false);
                        }
                        break;
                    #endregion

                    #region PostalCode
                    case CustomerFieldIndex.PostalCode:

                        /// check if PostalCode comes in correct format
                        if (!RegexHelper.IsValidZIPCode((string)value))
                        {
                            // set error info, so we could check that outside
                            involvedEntity.SetEntityFieldError(CustomerFieldIndex.PostalCode.ToString(), POSTAL_CODE_INCORRECT_FORMAT_ERROR_MESSAGE, false);
                            fieldIsValid = false;
                        }
                        else
                        {
                            // everything seems to be OK with this field so we clean the error info.
                            involvedEntity.SetEntityFieldError(CustomerFieldIndex.PostalCode.ToString(), "", false);
                        }
                        break;
                    #endregion

                    #region ContactName
                    case CustomerFieldIndex.ContactName:

                        /// check if ContactName comes in correct format
                        if (!RegexHelper.IsValidName((string)value))
                        {
                            // set error info, so we could check that outside
                            involvedEntity.SetEntityFieldError(CustomerFieldIndex.ContactName.ToString(), CONTACT_NAME_INCORRECT_FORMAT_ERROR_MESSAGE, false);
                            fieldIsValid = false;
                        }
                        else
                        {
                            // everything seems to be OK with this field so we clean the error info.
                            involvedEntity.SetEntityFieldError(CustomerFieldIndex.ContactName.ToString(), "", false);
                        }
                        break;
                    #endregion

                    #region CompanyName
                    case CustomerFieldIndex.CompanyName:

                        /// check if CompanyName comes in correct format
                        if (!RegexHelper.IsValidName((string)value))
                        {
                            // set error info, so we could check that outside
                            involvedEntity.SetEntityFieldError(CustomerFieldIndex.CompanyName.ToString(), COMPANY_NAME_INCORRECT_FORMAT_ERROR_MESSAGE, false);
                            fieldIsValid = false;
                        }
                        else
                        {
                            // everything seems to be OK with this field so we clean the error info.
                            involvedEntity.SetEntityFieldError(CustomerFieldIndex.CompanyName.ToString(), "", false);
                        }
                        break;
                    #endregion

                    #region ContactTitle
                    case CustomerFieldIndex.ContactTitle:

                        /// check if ContactTitle comes in correct format
                        if (!RegexHelper.IsValidAlphaText((string)value))
                        {
                            // set error info, so we could check that outside
                            involvedEntity.SetEntityFieldError(CustomerFieldIndex.ContactTitle.ToString(), CONTACT_TITLE_INCORRECT_FORMAT_ERROR_MESSAGE, false);
                            fieldIsValid = false;
                        }
                        else
                        {
                            // everything seems to be OK with this field so we clean the error info.
                            involvedEntity.SetEntityFieldError(CustomerFieldIndex.ContactTitle.ToString(), "", false);
                        }
                        break;
                    #endregion


                    // -- add more fields to be checked --
                    // ...                    
                }
                #endregion
            }
            // return valid field status
            return fieldIsValid;
        }


        /// <summary>
        /// Method to validate the containig entity right beforethe entity's delete action will take place.
        /// </summary>
        /// <param name="involvedEntity">The involved entity.</param>
        public override void ValidateEntityBeforeDelete(IEntityCore involvedEntity)
        {
            // variable to collect errors
            StringBuilder sbExceptionMessage = new StringBuilder();

            // customer to validate. Cast depends upon the entity you are validating.
            CustomerEntity toValidate = (CustomerEntity)involvedEntity;

            #region Check validation rules.
            /// Can't delete a customer that has orders related.
            /// Note: this assumes that the orders have been prefetched with the involvedEntity,
            /// so we can avoid the trip to DB and check this rule before DB throws an error.
            if (toValidate.Orders.Count != 0)
            {
                // add the error info to the message
                sbExceptionMessage.Append(CUSTOMER_INVALID_DELETE_ERROR_MESSAGE + DELIMITER); 
            }

            // -- add more validations --
            // ...
            #endregion

            // get the errors collected
            string strExceptionMessage = sbExceptionMessage.ToString();

            // Do exist any break rule in this entity?
            if (strExceptionMessage != string.Empty)
            {
                // set error info so we can access that outside
                toValidate.SetEntityError(strExceptionMessage);

                // throws an exception with all the breaking rules info
                throw new ORMEntityValidationException(strExceptionMessage, toValidate);
            }

            // if everything is ok, we reach this point, so lets the base class do its work
            base.ValidateEntityBeforeDelete(involvedEntity);
        }
    }    
}
