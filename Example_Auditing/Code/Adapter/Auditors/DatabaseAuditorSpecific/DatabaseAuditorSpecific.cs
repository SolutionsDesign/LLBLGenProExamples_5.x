///////////////////////////////////////////////////////////////
// LLBLGen Pro v5.x - Auditing Example
//////////////////////////////////////////////////////////////
// This code uses LLBLGen Pro version: 4.x
//////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Configuration;

using SD.LLBLGen.Pro.Examples.Auditing.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.Auditing.Auditors
{
    /// <summary>
	/// Auditor class intended to demonstrate how to successfully audit specific entity information
	/// to the DataBase. We used OrderAuditInfo which inherits from AuditInfo. OrderAuditInfo references
	/// the given OrderEntity so we can save specific Order audit info. This allows us to reference in
	/// database the audited order object. This tracking doesn't apply for delete action.
	/// This example uses LLBLGen Pro v5.x Auditor Dependency Injection.
    /// </summary>
    /// <remarks>
    /// This Auditor is injected to OrderEntity instances.
    /// </remarks>
    [DependencyInjectionInfo(typeof(OrderEntity), "AuditorToUse")]
    [Serializable]
    public class DatabaseAuditorSpecific : AuditorBase
    {
        #region Class Member Declarations
        /// <summary>
        /// Used to set the audit action type
        /// </summary>
        private enum AuditType
        {
            DeleteOfEntity = 1,
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
        private List<AuditInfoEntity> _orderAuditInfoEntities;
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseAuditor"/> class.
        /// </summary>
        public DatabaseAuditorSpecific()
        {
            _orderAuditInfoEntities = new List<AuditInfoEntity>();
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
            // Create a new audit unit
            // Don't use OrderAuditInfo because the entity will be deleted 
            // so wont be a valid reference to it.
            AuditInfoEntity auditInfo = new AuditInfoEntity();
            auditInfo.AffectedEntityName = entity.LLBLGenProEntityName;
            auditInfo.ActionDateTime = DateTime.Now;
            auditInfo.AuditActionTypeId = (int)AuditType.DeleteOfEntity;
            auditInfo.UserId = GetCurrentUserID();
            auditInfo.ActionData = GetPrimaryKeyValueFromOrderEntity(entity).ToString();

            // adds for further DB persist
            _orderAuditInfoEntities.Add(auditInfo);
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
            // Ignore the fieldSet of a new Order. The first original field values of an order can be reconstructed via the
            // AuditEntityFieldSet/AuditUpdateofExistingEntity history. However you also may colect AuditEntityFieldSet here
            // and then assign the sync those assigning OrderId when AuditInsertOfNewEntity is raised. The approach is up to you.
            if (entity.IsNew)
            {
                return;
            }

            // used to store the change experimented by a field.
			string originalValueAsString = originalValue == null ? "NULL" : originalValue.ToString();
			var currentValue = entity.GetCurrentFieldValue(fieldIndex);
			string currentValueAsString = currentValue == null ? "NULL" : currentValue.ToString();

            // post the field change audit info
            AddOrderAuditEntryToList(
                GetPrimaryKeyValueFromOrderEntity(entity),
                AuditType.EntityFieldSet,
                string.Format("FieldSet: {0}. OriginalValue: {1}. CurrentValue: {2}",
                    entity.Fields.GetFieldInfo(fieldIndex).Name,
					originalValueAsString, currentValueAsString));
        }


        /// <summary>
        /// Audits the successful insert of a new entity into the database.
        /// </summary>
        /// <param name="entity">The entity saved successfully into the database.</param>
        public override void AuditInsertOfNewEntity(IEntityCore entity)
        {
            AddOrderAuditEntryToList(
                GetPrimaryKeyValueFromOrderEntity(entity),
                AuditType.InsertOfNewEntity, string.Empty);
        }

        /// <summary>
        /// Audits the successful update of an existing entity in the database
        /// </summary>
        /// <param name="entity">The entity updated successfully in the database.</param>
        public override void AuditUpdateOfExistingEntity(IEntityCore entity)
        {
            AddOrderAuditEntryToList(
                GetPrimaryKeyValueFromOrderEntity(entity),
                AuditType.UpdateOfExistingEntity, string.Empty);
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
            return _orderAuditInfoEntities;
        }

        /// <summary>
        /// The transaction with which the audit entities requested from GetAuditEntitiesToSave were saved.
        /// Use this method to clear any audit data in this auditor as all audit information is persisted successfully.
        /// </summary>
        public override void TransactionCommitted()
        {
            _orderAuditInfoEntities.Clear();
        }

		/// <summary>
		/// Gets the current user ID from Session.
		/// </summary>
		/// <returns>Current logged-in user's ID</returns>
		private string GetCurrentUserID()
		{
			// obtain user info from Session
			return SessionHelper.GetUserID();
		}

		/// <summary>
		/// Adds one OrderAudit entry to auditInfo entities.
		/// </summary>
		/// <param name="orderId">Id of the order affected.</param>
		/// <param name="actionType">Type of the action.</param>
		/// <param name="actionData">The action data.</param>
		private void AddOrderAuditEntryToList(int orderId, AuditType actionType, string actionData)
		{
			// create a new audit unit
			OrderAuditInfoEntity orderAuditInfo = new OrderAuditInfoEntity();
			orderAuditInfo.AffectedEntityName = EntityType.OrderEntity.ToString();
			orderAuditInfo.ActionDateTime = DateTime.Now;
			orderAuditInfo.AuditActionTypeId = (int)actionType;
			orderAuditInfo.UserId = GetCurrentUserID();
			orderAuditInfo.ActionData = actionData;

			// specific for order entities
			orderAuditInfo.OrderId = orderId;

			// adds for further DB persist
			_orderAuditInfoEntities.Add(orderAuditInfo);
		}

		/// <summary>
		/// Gets the primary key info from an OrderEntity.
		/// </summary>
		/// <param name="entity">A valid instance of OrderEntity object.</param>
		/// <returns>OrderId of the given OrderEntity</returns>
		private int GetPrimaryKeyValueFromOrderEntity(IEntityCore entity)
		{
			return ((OrderEntity)entity).OrderId;
		}
	}
}
