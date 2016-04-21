///////////////////////////////////////////////////////////////
// LLBLGen Pro v5.x - Auditing Example
//////////////////////////////////////////////////////////////
// This code uses LLBLGen Pro version: 5.x
//////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;

using SD.LLBLGen.Pro.Examples.Auditing;
using SD.LLBLGen.Pro.Examples.Auditing.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.Auditing.Auditors
{
    /// <summary>
    /// Auditor class intended to demonstrate how to successfully audit entity information
    /// to the dataBase using LLBLGen Pro v5.x.0 Auditor Dependency Injection.
    /// </summary>
    /// <remarks>
    /// This Auditor is injected to CustomerEntity instances.
    /// </remarks>
    [DependencyInjectionInfo(typeof(CustomerEntity), "AuditorToUse")]
    [Serializable]
    public class DatabaseAuditor : AuditorBase
    {
        #region Class Member Declarations
        /// <summary>
        /// Used to set the audit action type
        /// </summary>
        private enum AuditType
	    {
		    DeleteOfEntity=1,
		    DirectDeleteOfEntities,
		    DirectUpdateOfEntities,
		    DereferenceOfRelatedEntity,
		    ReferenceOfRelatedEntity,
            EntityFieldGet,
		    EntityFieldSet,
		    InsertOfNewEntity,
		    UpdateOfExistingEntity,
            LoadOfExistingEntity
	    }

        // used to collect auditInfo entities
        private List<AuditInfoEntity> _auditInfoEntities;        
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseAuditor"/> class.
        /// </summary>
        public DatabaseAuditor()
	    {
            _auditInfoEntities = new List<AuditInfoEntity>();
        }

        /// <summary>
	    /// Audits the successful delete of an entity from the database
	    /// </summary>
	    /// <param name="entity">The entity which was deleted.</param>
	    /// <remarks>As the entity passed in was deleted succesfully, reading values from the 
	    /// passed in entity is only possible in this routine. After this call, the
	    /// state of the entity will be reset to Deleted again and reading the fields 
	    /// will result in an exception. It's also recommended not to reference
	    /// the passed in entity in any audit entity you might want to persist as the entity doesn't 
	    /// exist anymore in the database.</remarks>
	    public override void AuditDeleteOfEntity(IEntityCore entity)
	    {
			// avoid to audit into AuditInfoEntity (this would create an overflow effect). This is necessary if this auditor is injected into 
			// all entities, thus also in the AuditInfoEntity
			if(entity is AuditInfoEntity)
            {
                return;
            }

            AddAuditEntryToList(
                entity.LLBLGenProEntityName, 
                AuditType.DeleteOfEntity,
                GetPrimaryKeyInfoFromEntity(entity));         
	    }

        /// <summary>
        /// Audits the successful load of an entity from the database
        /// </summary>
        /// <param name="entity">The entity which was loaded.</param>
        public override void AuditLoadOfEntity(IEntityCore entity)
        {
            /// Direct persist audit info to DB, because if the LoadOfEntity doesn't belong to a 
            /// outside persist operation, the auditInfo wont be saved.
            /// Be aware that if an EntityCollection is fetched. This method will create a AuditInfoEntity
            /// for each one of LoadEntity. Recommended to filter this operation as you project nature requieres.
            /// 
            /// This routine is documented for auditInfo table readability. Uncomment below code to test it.

			/*
			// avoid to audit into AuditInfoEntity (this would create an overflow effect). This is necessary if this auditor is injected into 
			// all entities, thus also in the AuditInfoEntity
			if (entity is AuditInfoEntity)
			{
				return;
			}
             
			// construct audit info entity
			AuditInfoEntity auditInfo = ConstructAuditInfo(
				entity.LLBLGenProEntityName,
				AuditType.LoadOfExistingEntity,
				GetPrimaryKeyInfoFromEntity(entity));

			// persist to DB
			DirectPersistAuditInfo(auditInfo);            
			 */
		}

	    /// <summary>
	    /// Audits the successful direct delete of entities in the database
	    /// </summary>
	    /// <param name="typeOfEntity">The type of entity of which entities were deleted.</param>
	    /// <param name="filter">The filter to filter out the entities to delete. Can be null and can 
	    /// be an IPredicateExpression.</param>
	    /// <param name="relations">The relations to use with the filter. Can be null.</param>
	    /// <param name="numberOfEntitiesDeleted">The number of entities deleted.</param>
	    public override void AuditDirectDeleteOfEntities(Type typeOfEntity, IPredicate filter, 
		    IRelationCollection relations, int numberOfEntitiesDeleted)
	    {
			// avoid to audit into AuditInfoEntity (this would create an overflow effect). This is necessary if this auditor is injected into 
			// all entities, thus also in the AuditInfoEntity
			if(typeOfEntity == typeof(AuditInfoEntity))
            {
                return;
            }

            // get filter's queryText
            string queryText = filter.ToQueryText();

            // construct parameters info
            string parametersAsString = string.Empty;
            foreach (IDataParameter param in filter.Parameters)
            {
                parametersAsString += (param.ParameterName + "=" + param.Value.ToString() + ". ");
            }

            // construct audit info entity
            AuditInfoEntity auditInfo = ConstructAuditInfo(
                typeOfEntity.FullName, 
                AuditType.DirectDeleteOfEntities,
                string.Format("deleteFilter: {0}.  filterParameters: {1}", queryText, parametersAsString));

            // add to audit-info-to-save
            AddAuditEntryToList(auditInfo);
	    }

	    /// <summary>
	    /// Audits the successful dereference of related entity from the entity passed in.
	    /// </summary>
	    /// <param name="entity">The entity of which the related entity was dereferenced from.</param>
	    /// <param name="relatedEntity">The related entity which was dereferenced from entity</param>
	    /// <param name="mappedFieldName">Name of the mapped field onto the relation from entity to related 
	    /// entity for which the related entity was dereferenced.</param>
	    public override void AuditDereferenceOfRelatedEntity(IEntityCore entity, IEntityCore relatedEntity, string mappedFieldName)
	    {
			// avoid to audit into AuditInfoEntity (this would create an overflow effect). This is necessary if this auditor is injected into 
			// all entities, thus also in the AuditInfoEntity
			if(entity is AuditInfoEntity)
            {
                return;
            }

            AddAuditEntryToList(
                entity.LLBLGenProEntityName, 
                AuditType.DereferenceOfRelatedEntity, 
                string.Format("{0}. RelatedEntityName: {1}. MappedFieldName: {2}",
                    GetPrimaryKeyInfoFromEntity(entity), relatedEntity.LLBLGenProEntityName, mappedFieldName));
	    }

	    /// <summary>
	    /// Audits the succesful direct update of entities in the database.
	    /// </summary>
	    /// <param name="entity">The entity with the changed values which is used to produce the update 
	    /// query.</param>
	    /// <param name="filter">The filter to filter out the entities to update. Can be null and can be an 
	    /// IPredicateExpression.</param>
	    /// <param name="relations">The relations to use with the filter. Can be null.</param>
	    /// <param name="numberOfEntitiesUpdated">The number of entities updated.</param>
	    public override void AuditDirectUpdateOfEntities(IEntityCore entity, IPredicate filter, 
		    IRelationCollection relations, int numberOfEntitiesUpdated)
	    {
			// avoid to audit into AuditInfoEntity (this would create an overflow effect). This is necessary if this auditor is injected into 
			// all entities, thus also in the AuditInfoEntity
			if(entity is AuditInfoEntity)
            {
                return;
            }

            // get filter's queryText
            string queryText = filter.ToQueryText();

            // construct parameters info
            string parametersAsString = string.Empty;
            foreach (IDataParameter param in filter.Parameters)
            {
                parametersAsString += (param.ParameterName + "=" + param.Value.ToString() + ". ");
            }

            // construct update-new-values info of the direct update
            string updatedFields = string.Empty;
			for(int i = 0; i < entity.Fields.Count; i++)
			{
				if(entity.Fields.GetIsChanged(i))
				{
					object value = entity.Fields.GetCurrentValue(i);
					if(value == null)
					{
						value = "<null>";
					}
					updatedFields += (entity.Fields.GetFieldInfo(i).Name + "=" + value.ToString() + ". ");
				}
			}

            // construc audit info entity
            AuditInfoEntity auditInfo = ConstructAuditInfo(
							entity.LLBLGenProEntityName, 
							AuditType.DirectUpdateOfEntities,
							string.Format("updatedFields: {0}  updateFilter: {1}.  filterParameters: {2}", updatedFields, queryText, parametersAsString));

            // add to audit-info-to-save
            AddAuditEntryToList(auditInfo);
	    }

        /// <summary>
        /// Audits when an entity field is get succesfully.
        /// </summary>
        /// <param name="entity">The entity a field was get.</param>
        /// <param name="fieldIndex">Index of the field which got.</param>
        public override void AuditEntityFieldGet(IEntityCore entity, int fieldIndex)
        {
            /// NOTE: Uncomment this you want to track the got fields by an user. 
            /// This was commented to avoid hundreds of irrelevant audit info.

			/*
            
			// avoid to audit into AuditInfoEntity (this would create an overflow effect). This is necessary if this auditor is injected into 
			// all entities, thus also in the AuditInfoEntity
			if (entity is AuditInfoEntity)
			{
				return;
			}
             
			AddAuditEntryToList(
				entity.LLBLGenProEntityName, 
				AuditType.EntityFieldGet,
				string.Format("{0}. FieldGet: {1}",
					GetPrimaryKeyInfoFromEntity(entity),
					entity.Fields.GetFieldInfo(fieldIndex).Name));
			 * */
		}

	    /// <summary>
	    /// Audits when an entity field is set succesfully to a new value.
	    /// </summary>
	    /// <param name="entity">The entity a field was set to a new value.</param>
	    /// <param name="fieldIndex">Index of the field which got a new value.</param>
	    /// <param name="originalValue">The original value of the field with the index passed in 
	    /// before it received a new value.</param>
	    public override void AuditEntityFieldSet(IEntityCore entity, int fieldIndex, object originalValue)
	    {
			// avoid to audit into AuditInfoEntity (this would create an overflow effect). This is necessary if this auditor is injected into 
			// all entities, thus also in the AuditInfoEntity
			if(entity is AuditInfoEntity)
            {
                return;
            }

            // used to store the change experimented by a field.
			string originalValueAsString = originalValue == null ? "NULL" : originalValue.ToString();
			var currentValue = entity.GetCurrentFieldValue(fieldIndex);
			string currentValueAsString = currentValue == null ? "NULL" : currentValue.ToString();
			
            // post the field change info
            AddAuditEntryToList(entity.LLBLGenProEntityName, AuditType.EntityFieldSet,
										string.Format("{0}. FieldSet: {1}. OriginalValue: {2}. CurrentValue: {3}",
											GetPrimaryKeyInfoFromEntity(entity), entity.Fields.GetFieldInfo(fieldIndex).Name, 
											originalValueAsString, currentValueAsString));            
	    }

	    /// <summary>
	    /// Audits the successful insert of a new entity into the database.
	    /// </summary>
	    /// <param name="entity">The entity saved successfully into the database.</param>
	    public override void AuditInsertOfNewEntity(IEntityCore entity)
	    {
			// avoid to audit into AuditInfoEntity (this would create an overflow effect). This is necessary if this auditor is injected into 
			// all entities, thus also in the AuditInfoEntity
			if(entity is AuditInfoEntity)
            {
                return;
            }
            AddAuditEntryToList(entity.LLBLGenProEntityName, AuditType.InsertOfNewEntity, GetPrimaryKeyInfoFromEntity(entity));            
	    }

	    /// <summary>
	    /// Audits the successful reference of related entity from the entity passed in.
	    /// </summary>
	    /// <param name="entity">The entity of which the related entity was dereferenced from.</param>
	    /// <param name="relatedEntity">The related entity which was dereferenced from entity</param>
	    /// <param name="mappedFieldName">Name of the mapped field onto the relation from entity to related 
	    /// entity for which the related entity was referenced.</param>
	    public override void AuditReferenceOfRelatedEntity(IEntityCore entity, IEntityCore relatedEntity, string mappedFieldName)
	    {
			// avoid to audit into AuditInfoEntity (this would create an overflow effect). This is necessary if this auditor is injected into 
			// all entities, thus also in the AuditInfoEntity
			if(entity is AuditInfoEntity)
            {
                return;
            }

            AddAuditEntryToList(entity.LLBLGenProEntityName, AuditType.InsertOfNewEntity,
								string.Format("{0}. RelatedEntityName: {0}. MappedFieldName: {1}",
									GetPrimaryKeyInfoFromEntity(entity), relatedEntity.LLBLGenProEntityName, mappedFieldName));
	    }

	    /// <summary>
	    /// Audits the successful update of an existing entity in the database
	    /// </summary>
	    /// <param name="entity">The entity updated successfully in the database.</param>
	    public override void AuditUpdateOfExistingEntity(IEntityCore entity)
	    {
			// avoid to audit into AuditInfoEntity (this would create an overflow effect). This is necessary if this auditor is injected into 
			// all entities, thus also in the AuditInfoEntity
			if(entity is AuditInfoEntity)
            {
                return;
            }

            AddAuditEntryToList(entity.LLBLGenProEntityName, AuditType.UpdateOfExistingEntity, GetPrimaryKeyInfoFromEntity(entity));
	    }

	    /// <summary>
	    /// Gets the audit entities to save. Audit entities contain the audit information stored inside this auditor.
	    /// </summary>
	    /// <returns>The list of audit entities to save, or null if there are no audit entities to save</returns>
	    /// <remarks>Do not remove the audit entities and audit information from this auditor when this method is 
	    /// called, as the transaction in which the save takes place can fail and retried which will result in another call 
	    /// to this method</remarks>
	    public override System.Collections.IList GetAuditEntitiesToSave()
	    {
		    return _auditInfoEntities;
	    }

	    /// <summary>
	    /// The transaction with which the audit entities requested from GetAuditEntitiesToSave were saved.
	    /// Use this method to clear any audit data in this auditor as all audit information is persisted successfully.
	    /// </summary>
	    public override void TransactionCommitted()
	    {
            _auditInfoEntities.Clear();
        }

		/// <summary>
		/// Gets the current user ID from Session.
		/// </summary>
		/// <returns>Current logged-in user's ID</returns>
		private string GetCurrentUserID()
		{
			return LoginHelper.GetUserID();
		}

		/// <summary>
		/// Constructs the audit info.
		/// </summary>
		/// <param name="affectedEntityName">Name of the affected entity.</param>
		/// <param name="actionType">Type of the action.</param>
		/// <param name="actionData">The action data.</param>
		/// <returns></returns>
		private AuditInfoEntity ConstructAuditInfo(string affectedEntityName, AuditType actionType, string actionData)
		{
			// create a new audit unit
			AuditInfoEntity auditInfo = new AuditInfoEntity();
			auditInfo.AffectedEntityName = affectedEntityName;
			auditInfo.ActionDateTime = DateTime.Now;
			auditInfo.AuditActionTypeId = (int)actionType;
			auditInfo.UserId = GetCurrentUserID();
			auditInfo.ActionData = actionData;

			return auditInfo;
		}

		/// <summary>
		/// Adds one audit entry to auditInfo entities.
		/// </summary>
		/// <param name="auditInfo">The audit info.</param>
		private void AddAuditEntryToList(AuditInfoEntity auditInfo)
		{
			// adds for further DB persist
			_auditInfoEntities.Add(auditInfo);
		}

		/// <summary>
		/// Adds one audit entry to auditInfo entities.
		/// </summary>
		/// <param name="affectedEntityName">Name of the affected entity.</param>
		/// <param name="actionType">Type of the action.</param>
		/// <param name="actionData">The action data.</param>
		private void AddAuditEntryToList(string affectedEntityName, AuditType actionType, string actionData)
		{
			// create a new audit unit
			AuditInfoEntity auditInfo = ConstructAuditInfo(affectedEntityName, actionType, actionData);

			// adds for further DB persist
			AddAuditEntryToList(auditInfo);
		}

		/// <summary>
		/// Direct persists the audit info. This method is used by methods that don't belong to a transaction
		/// like AuditLoadOfEntity, AuditDirectDeleteOfEntities and AuditDirectUpdateOfEntites
		/// </summary>
		/// <param name="auditInfo">The audit info.</param>
		private void DirectPersistAuditInfo(AuditInfoEntity auditInfo)
		{
			auditInfo.Save();
		}

		/// <summary>
		/// Gets the primary key info from entity.
		/// </summary>
		/// <param name="entity">A valid instance of IEntity object.</param>
		/// <returns>Formatted string contained PK fields of the given entity</returns>
		private string GetPrimaryKeyInfoFromEntity(IEntityCore entity)
		{
			var pkFieldInfos = entity.Fields.PrimaryKeyFieldInfos;

			// collect PK fields if the entity isn't new
			string pkFieldInfo = string.Empty;
			if(!entity.IsNew)
			{
				pkFieldInfo = "PK(" + String.Join(", ",
								pkFieldInfos.Select(fi => string.Format("{0}:{1}", fi.Name, entity.Fields.GetCurrentValue(fi.FieldIndex) ?? "<null>"))
								.ToArray()) + ")";
			}
			return pkFieldInfo;
		}
	}
}
