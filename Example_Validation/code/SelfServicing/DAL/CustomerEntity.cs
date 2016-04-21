///////////////////////////////////////////////////////////////
// LLBLGen Pro Validation Example
//////////////////////////////////////////////////////////////
// This code uses LLBLGen Pro version: 5.x
// Powered by: Solutions Design.
//////////////////////////////////////////////////////////////

using System;
using System.Text;
using SD.LLBLGen.Pro.Examples.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

using SD.LLBLGen.Pro.Examples.Validators;

namespace SD.LLBLGen.Pro.Examples.EntityClasses
{
    /// <summary>
    /// Custom code that shows how to set a validator to Customer instances via overriding
    /// OnInitializing method, so you don't have to set the validator for each Customer entity one by one.
    /// To see the CustomerValilador class go to CustomerValidator.cs file
    /// </summary>
    public partial class CustomerEntity
    {
        /// <summary>
        /// Called at the end of the initialization routine. Raises Initialized event.
        /// </summary>
        protected override void OnInitialized()
        {
            // Set the validator to this customer instance.
            this.Validator = new CustomerValidator();
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
                    sbErrors.Append(((System.ComponentModel.IDataErrorInfo)this)[field.Name] + ";");                    
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


        /// <summary>
        /// Resets the errors.
        /// Used to clean the IDataErrorInfo when GUI cancels an Insert/Update operation.
        /// </summary>
        public void ResetErrors()
        {
            // reset the field errors
            foreach (EntityField field in Fields)
            {
                SetEntityFieldError(field.Name, string.Empty, false);                
            }    

            // reset entity error
            SetEntityError(string.Empty); 
        }

        
        /// <summary>
        /// Called right at the beginning of SetValue(), which is called from an entity field property setter
        /// </summary>
        /// <param name="fieldIndex">Index of the field to set.</param>
        /// <param name="valueToSet">The value to set.</param>
        /// <param name="cancel">if set to true, the setvalue is cancelled and the set action is terminated</param>
        /// <remarks>
        /// This code fixes the flaw of the IDataErrorInfo + Refresh field value in controls.
        /// For more explanation on this issue, please visit this forum's post: http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=12166 
        /// </remarks>
        protected override void OnSetValue(int fieldIndex, object valueToSet, out bool cancel)
        {
            if (Fields[fieldIndex].CurrentValue != null)
            {
                if (Fields[fieldIndex].CurrentValue.Equals(valueToSet)
                    && !string.IsNullOrEmpty(((System.ComponentModel.IDataErrorInfo)this)[Fields[fieldIndex].Name]))
                {
                    SetEntityFieldError(Fields[fieldIndex].Name, string.Empty, false);
                }
            }

            base.OnSetValue(fieldIndex, valueToSet, out cancel);
        }
    }
}
