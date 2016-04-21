using System;

using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SD.LLBLGen.Pro.Examples.Auditing;
using SD.LLBLGen.Pro.ORMSupportClasses;

/// <summary>
/// Several utility routines. 
/// </summary>
public static class GeneralUtils
{
	/// <summary>
	/// Converts the passed in enum value to an entity name without the 'Entity' suffix. So EntityType.CustomerEntity will become 'Customer'
	/// </summary>
	/// <param name="typeOfEntity">The type of entity.</param>
	/// <returns>String representation of the passed in entity type without the 'Entity' suffix</returns>
	public static string EntityTypeToEntityName(EntityType typeOfEntity)
	{
		string entityName = typeOfEntity.ToString();
		return entityName.Substring(0, entityName.Length - 6);
	}

	/// <summary>
	/// Creates a predicate from the passed in data. 
	/// </summary>
	/// <param name="field">The field.</param>
	/// <param name="operatorID">The operator ID.</param>
	/// <param name="negate">if set to <c>true</c> [negate].</param>
	/// <param name="fromValueAsString">From value as string.</param>
	/// <param name="toValueAsString">To value as string.</param>
	/// <returns>Predicate object which filters on the field with the specified values, or null if no predicate could be created.</returns>
	public static IPredicate CreatePredicate(EntityField2 field, int operatorID, bool negate, string fromValueAsString, string toValueAsString)
	{
		object fromValue = null;
		object toValue = null;
		if(operatorID != 6)
		{
			// NULL operator doesn't require input values, all other operators do, so test input values when operator isn't the NULL operator
			if(fromValueAsString.Length > 0)
			{
				try
				{
					fromValue = Convert.ChangeType(fromValueAsString, field.DataType);
				}
				catch
				{
					// value isn't valid, 
					return null;
				}
			}
			if(toValueAsString.Length > 0)
			{
				try
				{
					toValue = Convert.ChangeType(toValueAsString, field.DataType);
				}
				catch
				{
					// value specified and not valid. 
					return null;
				}
			}

			if(fromValue == null)
			{
				// invalid value specified
				return null;
			}
		}

		return CreatePredicate(field, operatorID, negate, fromValue, toValue);
	}


	/// <summary>
	/// Creates a predicate from the passed in data. 
	/// </summary>
	/// <param name="field">The field.</param>
	/// <param name="operatorID">The operator ID.</param>
	/// <param name="negate">if set to <c>true</c> [negate].</param>
	/// <param name="fromValue">From value.</param>
	/// <param name="toValue">To value.</param>
	/// <returns>
	/// Predicate object which filters on the field with the specified values, or null if no predicate could be created.
	/// </returns>
	public static IPredicate CreatePredicate(EntityField2 field, int operatorID, bool negate, object fromValue, object toValue)
	{
		IPredicate toReturn = null;

		switch(operatorID)
		{
			case 0:		// equal
				toReturn = new FieldCompareValuePredicate(field, null, ComparisonOperator.Equal, fromValue, negate);
				break;
			case 1:		// greater
				toReturn = new FieldCompareValuePredicate(field, null, ComparisonOperator.GreaterThan, fromValue, negate);
				break;
			case 2:		// greater / equal
				toReturn = new FieldCompareValuePredicate(field, null, ComparisonOperator.GreaterEqual, fromValue, negate);
				break;
			case 3:		// lesser
				toReturn = new FieldCompareValuePredicate(field, null, ComparisonOperator.LesserThan, fromValue, negate);
				break;
			case 4:		// lesser / equal
				toReturn = new FieldCompareValuePredicate(field, null, ComparisonOperator.LessEqual, fromValue, negate);
				break;
			case 5:		// between
				if(toValue == null)
				{
					// invalid
					return null;
				}
				toReturn = new FieldBetweenPredicate(field, null, fromValue, toValue, negate);
				break;
			case 6:		// null
				toReturn = new FieldCompareNullPredicate(field, null, negate);
				break;
			case 7:		// like
				toReturn = new FieldLikePredicate(field, null, (string)fromValue, negate);
				break;
			default:
				// invalid operator
				return null;
		}

		return toReturn;
	}
}
