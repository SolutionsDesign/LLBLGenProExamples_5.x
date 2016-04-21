///////////////////////////////////////////////////////////////
// LLBLGen Pro Validation Example
//////////////////////////////////////////////////////////////
// This code uses LLBLGen Pro version: 4.x
// Powered by: Solutions Design.
//////////////////////////////////////////////////////////////

using System;
using System.Text;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.EntityClasses
{
    /// <summary>
    /// Custom code that shows how to implement validation into the entity class at partial class.
    /// You also could use ProductEntity.cs custom code regions if you don't want (or can't if you 
    /// are using .NET 1.1). However is recommended to use partial classes.
    /// For more information please consult the LLBLGen Pro documentation.
    /// </summary>
    public partial class ProductEntity
    {
        #region Constants declaration section
        private const string UNIT_PRICE_ERROR_MESSAGE = "Unit price can't be negative.";
        private const string STOCK_ERROR_MESSAGE = "There's not enough units.";
        private const string DISCONTINUED_PRODUCT_ERROR_MESSAGE = "Can't update a discontinued product.";
        private const string DELIMITER = ";";
        #endregion


        /// <summary>
        /// Method which will validate, using custom code supplied this class, the field with index fieldIndex if it should accept
        /// the specified value. This routine is only called when standard checks already succeeded, so value isn't null, and value does match the
        /// destination column definition of the EntityField related to fieldIndex.
        /// </summary>
        /// <param name="fieldIndex">Index of field to validate</param>
        /// <param name="value">value to validate</param>
        /// <returns>
        /// True if the validation succeeded, false otherwise.
        /// </returns>
        protected override bool OnValidateFieldValue(int fieldIndex, object value)
        {

            // value to return
            bool fieldIsValid = true;

            if (value != null)
            {
                switch ((ProductFieldIndex)fieldIndex)
                {
                    case ProductFieldIndex.UnitPrice:
                        // negative unit prices aren't allowed
                        if (Convert.ToDecimal(value) < 0)
                        {
                            // set error info, so we could check at that outside                        
                            this.SetEntityFieldError(ProductFieldIndex.UnitPrice.ToString(), UNIT_PRICE_ERROR_MESSAGE, false);
                            fieldIsValid = false;
                        }
                        else
                        {
                            // everything seems to be OK with this field so we clean the error info. THis is only necessary if error info is set for this field
							// somewhere in the code. If no validation logic sets the error info for this field, you don't actively have to set the error info
							// to empty string for every field. 
                            this.SetEntityFieldError(ProductFieldIndex.UnitPrice.ToString(), "", false);
                        }
                        break;
                    case ProductFieldIndex.UnitsInStock:
                        // units in stock can't be negative
                        if (Convert.ToInt32(value) < 0)
                        {
                            // set error info, so we could check that outside
                            this.SetEntityFieldError(ProductFieldIndex.UnitsInStock.ToString(), STOCK_ERROR_MESSAGE, false);
                            fieldIsValid = false;
                        }
                        else
                        {
                            // everything seems to be OK with this field so we clean the error info.
                            this.SetEntityFieldError(ProductFieldIndex.UnitsInStock.ToString(), "", false);
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
        protected override void OnValidateEntityBeforeSave()
        {
            // variable to collect errors
            StringBuilder sbExceptionMessage = new StringBuilder();

            // ** can't update a discontinued product. 
            if ((bool)this.Fields["Discontinued"].DbValue == (bool)this.Fields["Discontinued"].CurrentValue
                && this.Discontinued && !this.IsNew)
            {
                // add the error info to the message
                sbExceptionMessage.Append(DISCONTINUED_PRODUCT_ERROR_MESSAGE + DELIMITER);
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

            // if everything is ok, we reach this point, so lets the base do its work
            base.OnValidateEntityBeforeSave();
        }


        /// <summary>
        /// Gets the entity fields errors.
        /// </summary>
        /// <returns>A separater-by-semicolon errors in string representation of the 
        /// error (if exist).
        /// This could be useful if you want to obtain the errors list at some GUI.</returns>
        public string GetEntityFieldsErrors()
        {
            // variables to construct the message
            StringBuilder sbErrors = new StringBuilder();
            string toReturn = string.Empty;

            // iterate over fields and get their errorInfo
            foreach (IEntityField field in this.Fields)
            {
                /// IEntity implements IDataErrorInfo, and it contains a collections of field errors already set. 
                /// For more info read the docs (LLBLGen Pro Help -> Using generated code -> Validation per field or per entity -> IDataErrorInfo implementation).
                if (!string.IsNullOrEmpty(((System.ComponentModel.IDataErrorInfo)this)[field.Name]))
                {
                    sbErrors.Append(((System.ComponentModel.IDataErrorInfo)this)[field.Name] + DELIMITER);                    
                }
            }

            // determine if there was errors and cut off the extra ';'
            if (sbErrors.ToString() != string.Empty)
            {
                toReturn = sbErrors.ToString();
                toReturn = toReturn.Substring(0, toReturn.Length - 2);
            }

            return toReturn;
        }
    }
}
