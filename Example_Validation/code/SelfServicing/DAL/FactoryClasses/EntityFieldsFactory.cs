﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: donderdag 21 april 2016 12:49:00
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Data;
using SD.LLBLGen.Pro.Examples;
using SD.LLBLGen.Pro.Examples.HelperClasses;
using System.Collections.Generic;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.FactoryClasses
{
	/// <summary>Generates IEntityFields instances for different kind of Entities.</summary>
	public static partial  class EntityFieldsFactory
	{
		private static readonly Dictionary<SD.LLBLGen.Pro.Examples.EntityType, string> _entityTypeNamesCache = new Dictionary<SD.LLBLGen.Pro.Examples.EntityType, string>();

		/// <summary>static ctor which initializes the static entity type cache.</summary>
		static EntityFieldsFactory()
		{
			foreach(SD.LLBLGen.Pro.Examples.EntityType value in Enum.GetValues(typeof(SD.LLBLGen.Pro.Examples.EntityType)))
			{
				_entityTypeNamesCache.Add(value, Enum.GetName(typeof(SD.LLBLGen.Pro.Examples.EntityType), value));
			}
		}	
	
		/// <summary>General factory entrance method which will return an EntityFields object with the format generated by the factory specified</summary>
		/// <param name="relatedEntityType">The type of entity the fields are for</param>
		/// <returns>The IEntityFields instance requested</returns>
		public static IEntityFields CreateEntityFieldsObject(SD.LLBLGen.Pro.Examples.EntityType relatedEntityType)
		{
			return FieldInfoProviderSingleton.GetInstance().GetEntityFields(InheritanceInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance(), _entityTypeNamesCache[relatedEntityType]);
		}
		
		/// <summary>General method which will return an array of IEntityFieldCore objects, used by the InheritanceInfoProvider. Only the fields defined in the entity are returned, no inherited fields.</summary>
		/// <param name="entityName">the name of the entity to get the fields for. Example: "CustomerEntity"</param>
		/// <returns>array of IEntityFieldCore fields, defined in the entity with the name specified</returns>
		internal static IEntityFieldCore[] CreateFields(string entityName)
		{
			return FieldInfoProviderSingleton.GetInstance().GetEntityFieldsArray(entityName, PersistenceInfoProviderSingleton.GetInstance());
		}



		#region Included Code

		#endregion
	}
}
