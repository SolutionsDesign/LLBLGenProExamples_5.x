///////////////////////////////////////////////////////////////
// LLBLGen Pro Validation Example
//////////////////////////////////////////////////////////////
// This code uses LLBLGen Pro version: 4.x
// Powered by: Solutions Design.
//////////////////////////////////////////////////////////////

using System;
using System.Text;

using SD.LLBLGen.Pro.Examples;
using SD.LLBLGen.Pro.Examples.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.Validators
{
    /// <summary>
    /// Validator class intended to demonstrate how to successfully implement an entity-based validation.
    /// This class demonstrates how to inject the validator to OrderEntity instances.
    /// For more information please consult the LLBLGen Pro documentation.
    /// </summary>
    /// <remarks>
    /// This validator is injected to OrderEntity instances.
    /// </remarks>
    
    /// Dependency Injection (DI) information. You could control DI behavior at *.config file.
    /// For more information please consult the LLBLGen Pro documentation.
    [DependencyInjectionInfo(typeof(OrderEntity), "Validator")]
    [Serializable]
    public class OrderValidator : ValidatorBase
    {
        #region Constants declaration section
        private const string ORDER_DATE_ERROR_MESSAGE = "OrderDate must be greater than (Today - 1 month).";
        private const string FREIGHT_ERROR_MESSAGE = "Freight must be greater or equal than 0.00.";
        private const string ORDER_DETAILS_ERROR_MESSAGE = "The Order must contain at least one detail item.";
        private const string REQUIRED_DATE_ERROR_MESSAGE = "The RequiredDate must be greater or equal than OrderDate.";
        private const string SHIPPED_DATE_ERROR_MESSAGE = "The ShippedDate must be greater or equal than OrderDate.";
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
                switch ((OrderFieldIndex)fieldIndex)
                {
                    case OrderFieldIndex.OrderDate:
                        // can't insert orders too old!
                        if (((DateTime)value) < DateTime.Now.AddMonths(-1)
                            && involvedEntity.IsNew)
                        {
                            // set error info, so we could check that outside
                            involvedEntity.SetEntityFieldError(OrderFieldIndex.OrderDate.ToString(), ORDER_DATE_ERROR_MESSAGE, false);
                            fieldIsValid = false;
                        }
                        else
                        {
                            // everything seems to be OK with this field so we clean the error info.
                            involvedEntity.SetEntityFieldError(OrderFieldIndex.OrderDate.ToString(), "", false);
                        }
                        break;
                    case OrderFieldIndex.Freight:

                        // freight is valid if the value is >= 0
                        if (!((decimal)value >= Decimal.Zero))
                        {
                            // set error info, so we could check that outside
                            involvedEntity.SetEntityFieldError(OrderFieldIndex.Freight.ToString(), FREIGHT_ERROR_MESSAGE, false);
                            fieldIsValid = false;
                        }
                        else
                        {
                            // everything seems to be OK with this field so we clean the error info.
                            involvedEntity.SetEntityFieldError(OrderFieldIndex.Freight.ToString(), "", false);
                        }
                        break;
                    // -- add more fields to be checked --
                    // ...                    
                }
            }
            // return valid field status
            return fieldIsValid;
        }

        /// <summary>
        /// Method to validate the containing entity right before the save sequence for the entity will start. LLBLGen Pro will call this method right after the
        /// containing entity is selected from the save queue to be saved.
        /// </summary>
        /// <param name="involvedEntity">The involved entity.</param>
        public override void ValidateEntityBeforeSave(IEntityCore involvedEntity)
        {
            // variable to collect errors
            StringBuilder sbExceptionMessage = new StringBuilder();

            // order to validate. Cast depends upon the entity you are validating.
            OrderEntity toValidate = (OrderEntity)involvedEntity;

            // ** shippedDate must be >= than the orderDate
            if (toValidate.ShippedDate != null && toValidate.ShippedDate < toValidate.OrderDate)
            {
                // add the error info to the message
                sbExceptionMessage.Append(SHIPPED_DATE_ERROR_MESSAGE + DELIMITER);
            }

            // ** requiredDate must be >= than the orderDate
            if (toValidate.RequiredDate != null && toValidate.RequiredDate < toValidate.OrderDate)
            {
                // add the error info to the message
                sbExceptionMessage.Append(REQUIRED_DATE_ERROR_MESSAGE + DELIMITER);
            }

             //-- add more validations --
             //...

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
        }
    }
}
