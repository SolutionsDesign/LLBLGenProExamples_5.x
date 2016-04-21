///////////////////////////////////////////////////////////////
// LLBLGen Pro v5.x - Auditing Example
//////////////////////////////////////////////////////////////
// This code uses LLBLGen Pro version: 4.x
//////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Configuration;
using System.Data;
using System.Linq;

using SD.LLBLGen.Pro.Examples.Auditing.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;


namespace SD.LLBLGen.Pro.Examples.Auditing.Auditors
{
    /// <summary>
	/// Auditor class intended to demonstrate how to successfully audit entity information
	/// to a text file using LLBLGen Pro v5.x Auditor Dependency Injection.
	/// 
	/// This Auditor is injected to ProductEntity instances. If you want to inject to another
	/// entity or interface, change the DependencyInjectionInfo.
	/// 
	/// This Auditor use DependencyInjectionContextType.Singleton context type as is the best
	/// choice for single-file auditing schema in multi-user/multi-threading scenario.
	/// 
	/// Please be aware that there are many ways to implement text-based auditing.
	/// Be aware of the architecture, storage, concurrency and security issues of auditing to a
	/// text file in a web-based scenario. This example isn't a 'this is the only way' approach, just an illustration
	/// how this could work. 
	/// </summary>
	/// <remarks>
	/// Some audit methods has been documented to maintain a readable text-file, however you can
	/// uncomment those to test the functionality.         
    /// </remarks>
    [DependencyInjectionInfo(typeof(ProductEntity), "AuditorToUse", ContextType = DependencyInjectionContextType.Singleton)]
    [Serializable]
    public class SimpleTextFileAuditor : AuditorBase
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
        
        // output file useful variables
        private StringWriter _auditInfoSW; 
        private string _outputAuditFileName;
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="NorthwindSimpleTextFileAuditor"/> class.
        /// </summary>
        public SimpleTextFileAuditor()
	    {
            // clear temporal audit stream            
            _auditInfoSW = new StringWriter();

            // look for SimpleTextAuditorTxtFileName setting at .config file
            AppSettingsReader appConfiguration = new AppSettingsReader();
            try
            {
                _outputAuditFileName = (string) appConfiguration.GetValue("SimpleTextAuditorTxtFileName", typeof(string));
            }

            // SimpleTextAuditorTxtFileName not found! use default filename
            catch (InvalidOperationException)
            {
                _outputAuditFileName = "c:\\noraudit.txt";
            }
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

            // construct audit info record
            StringWriter auditInfo = ConstructAuditRecord(entity.LLBLGenProEntityName, AuditType.LoadOfExistingEntity, GetPrimaryKeyInfoFromEntity(entity));

            // add to later-persist list
            AddAuditRecordStringToBulkStream(auditInfo.GetStringBuilder().ToString());
        }


        /// <summary>
        /// Audits the successful load of an entity from the database.
        /// </summary>
        /// <param name="entity">The entity which was loaded.</param>
        public override void AuditLoadOfEntity(IEntityCore entity)
        {
            /// Doesn't use AddAuditRecordToStream method because when a process request an entity (load)
            /// maybe never persits a transaction, however we want to log the load. So we would persist 
            /// right here.
            /// 
            /// Be aware that if you fetch an EntityCollection, this method will be called for each entity
            /// of the collection. So is recommended to filter this action.
            /// Uncomment below code to test such functionallity.

			/*
			// avoid to audit into AuditInfoEntity (this would create an overflow effect). This is necessary if this auditor is injected into 
			// all entities, thus also in the AuditInfoEntity
			if (entity is AuditInfoEntity)
			{
				return;
			}
            
			// construct audit info record
			StringWriter auditInfo = ConstructAuditRecord(entity.LLBLGenProEntityName, AuditType.LoadOfExistingEntity, GetPrimaryKeyInfoFromEntity(entity));
            
			// persit adit info record to file
			PersistAuditInfoThreadSafe(auditInfo);
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
            string strFilter = filter.ToQueryText();

            // construct parameters info
            string strParameters = string.Empty;
            foreach (IDataParameter param in filter.Parameters)
            {
                strParameters += (param.ParameterName + "=" + param.Value.ToString() + ". ");
            }

            // construct audit info record
            StringWriter auditInfo = ConstructAuditRecord(typeOfEntity.ToString(), AuditType.DirectDeleteOfEntities,
														  string.Format("deleteFilter: {0}.  filterParameters: {1}", strFilter, strParameters));

            // save the record info
            PersistAuditInfoThreadSafe(auditInfo);
        }

        /// <summary>
        /// Audits the successful dereference of related entity from the entity passed in.
        /// </summary>
        /// <param name="entity">The entity of which the related entity was dereferenced from.</param>
        /// <param name="relatedEntity">The related entity which was dereferenced from entity</param>
        /// <param name="mappedFieldName">Name of the mapped field onto the relation from entity to related 
        /// entity for which the related entity was dereferenced.</param>
        public override void AuditDereferenceOfRelatedEntity(IEntityCore entity, IEntityCore relatedEntity,
            string mappedFieldName)
        {
			// avoid to audit into AuditInfoEntity (this would create an overflow effect). This is necessary if this auditor is injected into 
			// all entities, thus also in the AuditInfoEntity
			if(entity is AuditInfoEntity)
            {
                return;
            }

            // construct audit info record
            StringWriter auditInfo = ConstructAuditRecord(entity.LLBLGenProEntityName, AuditType.DereferenceOfRelatedEntity, 
											string.Format("{0}. RelatedEntityName: {1}. MappedFieldName: {2}",
														GetPrimaryKeyInfoFromEntity(entity), relatedEntity.LLBLGenProEntityName, mappedFieldName));

            // add to later-persist list
            AddAuditRecordStringToBulkStream(auditInfo.GetStringBuilder().ToString());
            
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

            // construct audit info record
            StringWriter auditInfo = ConstructAuditRecord(entity.LLBLGenProEntityName, AuditType.DirectUpdateOfEntities, 
												string.Format("updatedFields: {0}  updateFilter: {1}.  filterParameters: {2}", 
													updatedFields, queryText, parametersAsString));

			// save the record info
            PersistAuditInfoThreadSafe(auditInfo);
		}

        /// <summary>
        /// Audits when an entity field is get succesfully.
        /// </summary>
        /// <param name="entity">The entity a field was get.</param>
        /// <param name="fieldIndex">Index of the field which got.</param>
        public override void AuditEntityFieldGet(IEntityCore entity, int fieldIndex)
        {
            /// NOTE: Uncomment this if you want to track the got fields by an user. 
            /// This was commented to avoid hundreds of possible irrelevant audit info.

			/*
			// avoid to audit into AuditInfoEntity (this would create an overflow effect). This is necessary if this auditor is injected into 
			// all entities, thus also in the AuditInfoEntity
			if (entity is AuditInfoEntity)
			{
				return;
			}
            
			// construct audit info record
			StringWriter auditInfo = ConstructAuditRecord(entity.LLBLGenProEntityName, AuditType.EntityFieldGet,
											string.Format("{0}. FieldGet: {1}",
												GetPrimaryKeyInfoFromEntity(entity), ((IEntity2)entity).Fields[fieldIndex].Name));

			// add to later-persist list
			AddAuditRecordStringToBulkStream(auditInfo.GetStringBuilder().ToString());            
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
			
			// construct audit info record
            StringWriter auditInfo = ConstructAuditRecord(entity.LLBLGenProEntityName, AuditType.EntityFieldSet,
										string.Format("{0}. FieldSet: {1}. OriginalValue: {2}. CurrentValue: {3}",
											GetPrimaryKeyInfoFromEntity(entity),
											entity.Fields.GetFieldInfo(fieldIndex).Name,
											originalValueAsString, currentValueAsString));

            // add to later-persist list
            AddAuditRecordStringToBulkStream(auditInfo.GetStringBuilder().ToString());            
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

            // construct audit info record
            StringWriter auditInfo = ConstructAuditRecord(entity.LLBLGenProEntityName, AuditType.InsertOfNewEntity, GetPrimaryKeyInfoFromEntity(entity));

            // add to later-persist list
            AddAuditRecordStringToBulkStream(auditInfo.GetStringBuilder().ToString());             
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

            // construct audit info record
            StringWriter auditInfo = ConstructAuditRecord(entity.LLBLGenProEntityName, AuditType.ReferenceOfRelatedEntity,
											string.Format("{0}. RelatedEntityName: {0}. MappedFieldName: {1}",
												GetPrimaryKeyInfoFromEntity(entity), relatedEntity.LLBLGenProEntityName, mappedFieldName));

            // add to later-persist list
            AddAuditRecordStringToBulkStream(auditInfo.GetStringBuilder().ToString());            
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

            // construct audit info record
            StringWriter auditInfo = ConstructAuditRecord(entity.LLBLGenProEntityName, AuditType.UpdateOfExistingEntity, GetPrimaryKeyInfoFromEntity(entity));

            // add to later-persist list
            AddAuditRecordStringToBulkStream(auditInfo.GetStringBuilder().ToString());  
	    }


        /// <summary>
        /// Method which returns true if this auditor expects to have audit entities to persist and therefore needs a transaction.
        /// This method is called in the situation when there's no transaction going on though one should be started right before the single-statement action
        /// in the case if the auditor has entities to save afterwards. It's recommended to return true if the auditor might have audit entities
        /// to persist after an entity save/delete/direct update/direct delete of entities. Default: true
        /// </summary>
        /// <param name="actionToStart">The single statement action which is about to be started.</param>
        /// <returns>
        /// true if a transaction should be started prior to the action to perform (entity save/delete/direct update/direct delete of entities)
        /// false otherwise.
        /// </returns>
        /// <remarks>If false is returned and GetAuditEntitiesToSave returns 1 or more entities, a new transaction is started to save these audit entities
        /// which means that this transaction isn't re-tryable if this transaction might fail.
        /// 
        /// In no entity-based audition (text file for example) where no transaction is required. This method should return false. This avoids the creation
        /// of unnecessary transactions.</remarks>
        public override bool RequiresTransactionForAuditEntities(SingleStatementQueryAction actionToStart)
        {
            return false;
        }

	    /// <summary>
	    /// The transaction with which the audit entities requested from GetAuditEntitiesToSave were saved.
	    /// Use this method to clear any audit data in this auditor as all audit information is persisted successfully.
	    /// </summary>
	    public override void TransactionCommitted()
	    {           
            // persist textFile-based audit information
            PersistAuditInfoThreadSafe(_auditInfoSW);                                    
        }

		/// <summary>
		/// Gets the current user ID from Session.
		/// </summary>
		/// <returns>Current logged-in user's ID</returns>
		private string GetCurrentUserID()
		{
			return SessionHelper.GetUserID();
		}

		/// <summary>
		/// Constructs an audit record string.
		/// </summary>
		/// <param name="affectedEntityName">Name of the affected entity.</param>
		/// <param name="actionType">Type of the action.</param>
		/// <param name="actionData">The action data.</param>
		private StringWriter ConstructAuditRecord(string affectedEntityName, AuditType actionType, string actionData)
		{
			StringWriter tmpAuditOfLoadEntitySW = new StringWriter();
			tmpAuditOfLoadEntitySW.WriteLine("{0} ---------------------------------------------------", DateTime.Now);
			tmpAuditOfLoadEntitySW.WriteLine("USER:   {0}", GetCurrentUserID());
			tmpAuditOfLoadEntitySW.WriteLine("ENTITY: {0}", affectedEntityName);
			tmpAuditOfLoadEntitySW.WriteLine("ACTION: {0}", actionType);
			tmpAuditOfLoadEntitySW.WriteLine("DATA:   {0}", actionData);
			tmpAuditOfLoadEntitySW.WriteLine();

			return tmpAuditOfLoadEntitySW;
		}

		/// <summary>
		/// Adds one audit record to stream.
		/// </summary>
		/// <param name="auditRecordString">Audit record string info to add.</param>
		private void AddAuditRecordStringToBulkStream(string auditRecordString)
		{
			// add for later persist
			_auditInfoSW.WriteLine(auditRecordString);
		}

		/// <summary>
		/// Gets the primary key info from entity. Used for provide audit data.
		/// </summary>
		/// <param name="entity">A valid instance of IEntity2 object.</param>
		/// <returns>Formatted string contained PK fields of the given entity</returns>
		private string GetPrimaryKeyInfoFromEntity(IEntityCore entity)
		{
			// gets primary key fields
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

		/// <summary>
		/// Persists the audit info to a file in thread safe mode.
		/// </summary>
		/// <param name="sw">The stringWriter containing audit info</param>
		private void PersistAuditInfoThreadSafe(StringWriter sw)
		{
			/// Disclaimer: This procedure doesn't intend to show the best approach to use text-based 
			/// auditing concurrency as there are many ways to achieve such a thing. Choose the best
			/// approach that fits your project's architecture and requirements.

			// avoid multiple threads open the file at the same time
			lock(this)
			{
				// creates a thread-safe (synchronized) wrapper around the specified Stream object
				using(TextWriter auditStream = new StreamWriter(_outputAuditFileName, true))
				{
					using(TextWriter auditStreamThreadSafe = StreamWriter.Synchronized(auditStream))
					{

						// write audit info
						auditStreamThreadSafe.Write(sw.GetStringBuilder().ToString());

						// close and clean stuff
						auditStreamThreadSafe.Close();
						auditStream.Close();

						sw.Flush();
					}
				}
			}
		}
    }
}
