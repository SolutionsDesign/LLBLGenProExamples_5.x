///////////////////////////////////////////////////////////////
// LLBLGen Pro Validation Example
//////////////////////////////////////////////////////////////
// This code uses LLBLGen Pro version: 4.x
// Powered by: Solutions Design.
//////////////////////////////////////////////////////////////

using System;
using System.Text;
using SD.LLBLGen.Pro.Examples.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

using SD.LLBLGen.Pro.Examples.Validators;

namespace SD.LLBLGen.Pro.Examples.EntityClasses
{    
    public partial class OrderEntity
    {

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
