﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: donderdag 21 april 2016 11:37:05
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Xml.Serialization;
using SD.LLBLGen.Pro.Examples.Auditing;
using SD.LLBLGen.Pro.Examples.Auditing.HelperClasses;
using SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses;
using SD.LLBLGen.Pro.Examples.Auditing.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.Auditing.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'Employee'.<br/><br/></summary>
	[Serializable]
	public partial class EmployeeEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<EmployeeEntity> _employees_;
		private EntityCollection<EmployeeTerritoryEntity> _employeeTerritories;
		private EntityCollection<OrderEntity> _orders;
		private EntityCollection<CustomerEntity> _customersCollectionViaOrders;
		private EntityCollection<ShipperEntity> _shippersCollectionViaOrders;
		private EntityCollection<TerritoryEntity> _territoriesCollectionViaEmployeeTerritories;
		private EmployeeEntity _employees;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Employees</summary>
			public static readonly string Employees = "Employees";
			/// <summary>Member name Employees_</summary>
			public static readonly string Employees_ = "Employees_";
			/// <summary>Member name EmployeeTerritories</summary>
			public static readonly string EmployeeTerritories = "EmployeeTerritories";
			/// <summary>Member name Orders</summary>
			public static readonly string Orders = "Orders";
			/// <summary>Member name CustomersCollectionViaOrders</summary>
			public static readonly string CustomersCollectionViaOrders = "CustomersCollectionViaOrders";
			/// <summary>Member name ShippersCollectionViaOrders</summary>
			public static readonly string ShippersCollectionViaOrders = "ShippersCollectionViaOrders";
			/// <summary>Member name TerritoriesCollectionViaEmployeeTerritories</summary>
			public static readonly string TerritoriesCollectionViaEmployeeTerritories = "TerritoriesCollectionViaEmployeeTerritories";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static EmployeeEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public EmployeeEntity():base("EmployeeEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public EmployeeEntity(IEntityFields2 fields):base("EmployeeEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this EmployeeEntity</param>
		public EmployeeEntity(IValidator validator):base("EmployeeEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public EmployeeEntity(System.Int32 employeeId):base("EmployeeEntity")
		{
			InitClassEmpty(null, null);
			this.EmployeeId = employeeId;
		}

		/// <summary> CTor</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="validator">The custom validator object for this EmployeeEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public EmployeeEntity(System.Int32 employeeId, IValidator validator):base("EmployeeEntity")
		{
			InitClassEmpty(validator, null);
			this.EmployeeId = employeeId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected EmployeeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_employees_ = (EntityCollection<EmployeeEntity>)info.GetValue("_employees_", typeof(EntityCollection<EmployeeEntity>));
				_employeeTerritories = (EntityCollection<EmployeeTerritoryEntity>)info.GetValue("_employeeTerritories", typeof(EntityCollection<EmployeeTerritoryEntity>));
				_orders = (EntityCollection<OrderEntity>)info.GetValue("_orders", typeof(EntityCollection<OrderEntity>));
				_customersCollectionViaOrders = (EntityCollection<CustomerEntity>)info.GetValue("_customersCollectionViaOrders", typeof(EntityCollection<CustomerEntity>));
				_shippersCollectionViaOrders = (EntityCollection<ShipperEntity>)info.GetValue("_shippersCollectionViaOrders", typeof(EntityCollection<ShipperEntity>));
				_territoriesCollectionViaEmployeeTerritories = (EntityCollection<TerritoryEntity>)info.GetValue("_territoriesCollectionViaEmployeeTerritories", typeof(EntityCollection<TerritoryEntity>));
				_employees = (EmployeeEntity)info.GetValue("_employees", typeof(EmployeeEntity));
				if(_employees!=null)
				{
					_employees.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((EmployeeFieldIndex)fieldIndex)
			{
				case EmployeeFieldIndex.ReportsTo:
					DesetupSyncEmployees(true, false);
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "Employees":
					this.Employees = (EmployeeEntity)entity;
					break;
				case "Employees_":
					this.Employees_.Add((EmployeeEntity)entity);
					break;
				case "EmployeeTerritories":
					this.EmployeeTerritories.Add((EmployeeTerritoryEntity)entity);
					break;
				case "Orders":
					this.Orders.Add((OrderEntity)entity);
					break;
				case "CustomersCollectionViaOrders":
					this.CustomersCollectionViaOrders.IsReadOnly = false;
					this.CustomersCollectionViaOrders.Add((CustomerEntity)entity);
					this.CustomersCollectionViaOrders.IsReadOnly = true;
					break;
				case "ShippersCollectionViaOrders":
					this.ShippersCollectionViaOrders.IsReadOnly = false;
					this.ShippersCollectionViaOrders.Add((ShipperEntity)entity);
					this.ShippersCollectionViaOrders.IsReadOnly = true;
					break;
				case "TerritoriesCollectionViaEmployeeTerritories":
					this.TerritoriesCollectionViaEmployeeTerritories.IsReadOnly = false;
					this.TerritoriesCollectionViaEmployeeTerritories.Add((TerritoryEntity)entity);
					this.TerritoriesCollectionViaEmployeeTerritories.IsReadOnly = true;
					break;
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}
		
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Employees":
					toReturn.Add(Relations.EmployeeEntityUsingEmployeeIdReportsTo);
					break;
				case "Employees_":
					toReturn.Add(Relations.EmployeeEntityUsingReportsTo);
					break;
				case "EmployeeTerritories":
					toReturn.Add(Relations.EmployeeTerritoryEntityUsingEmployeeId);
					break;
				case "Orders":
					toReturn.Add(Relations.OrderEntityUsingEmployeeId);
					break;
				case "CustomersCollectionViaOrders":
					toReturn.Add(Relations.OrderEntityUsingEmployeeId, "EmployeeEntity__", "Order_", JoinHint.None);
					toReturn.Add(OrderEntity.Relations.CustomerEntityUsingCustomerId, "Order_", string.Empty, JoinHint.None);
					break;
				case "ShippersCollectionViaOrders":
					toReturn.Add(Relations.OrderEntityUsingEmployeeId, "EmployeeEntity__", "Order_", JoinHint.None);
					toReturn.Add(OrderEntity.Relations.ShipperEntityUsingShipVia, "Order_", string.Empty, JoinHint.None);
					break;
				case "TerritoriesCollectionViaEmployeeTerritories":
					toReturn.Add(Relations.EmployeeTerritoryEntityUsingEmployeeId, "EmployeeEntity__", "EmployeeTerritory_", JoinHint.None);
					toReturn.Add(EmployeeTerritoryEntity.Relations.TerritoryEntityUsingTerritoryId, "EmployeeTerritory_", string.Empty, JoinHint.None);
					break;
				default:
					break;				
			}
			return toReturn;
		}
#if !CF
		/// <summary>Checks if the relation mapped by the property with the name specified is a one way / single sided relation. If the passed in name is null, it/ will return true if the entity has any single-sided relation</summary>
		/// <param name="propertyName">Name of the property which is mapped onto the relation to check, or null to check if the entity has any relation/ which is single sided</param>
		/// <returns>true if the relation is single sided / one way (so the opposite relation isn't present), false otherwise</returns>
		protected override bool CheckOneWayRelations(string propertyName)
		{
			int numberOfOneWayRelations = 0;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));
				default:
					return base.CheckOneWayRelations(propertyName);
			}
		}
#endif
		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "Employees":
					SetupSyncEmployees(relatedEntity);
					break;
				case "Employees_":
					this.Employees_.Add((EmployeeEntity)relatedEntity);
					break;
				case "EmployeeTerritories":
					this.EmployeeTerritories.Add((EmployeeTerritoryEntity)relatedEntity);
					break;
				case "Orders":
					this.Orders.Add((OrderEntity)relatedEntity);
					break;
				default:
					break;
			}
		}

		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "Employees":
					DesetupSyncEmployees(false, true);
					break;
				case "Employees_":
					this.PerformRelatedEntityRemoval(this.Employees_, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "EmployeeTerritories":
					this.PerformRelatedEntityRemoval(this.EmployeeTerritories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Orders":
					this.PerformRelatedEntityRemoval(this.Orders, relatedEntity, signalRelatedEntityManyToOne);
					break;
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependingRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependentRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			if(_employees!=null)
			{
				toReturn.Add(_employees);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.Employees_);
			toReturn.Add(this.EmployeeTerritories);
			toReturn.Add(this.Orders);
			return toReturn;
		}

		/// <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				info.AddValue("_employees_", ((_employees_!=null) && (_employees_.Count>0) && !this.MarkedForDeletion)?_employees_:null);
				info.AddValue("_employeeTerritories", ((_employeeTerritories!=null) && (_employeeTerritories.Count>0) && !this.MarkedForDeletion)?_employeeTerritories:null);
				info.AddValue("_orders", ((_orders!=null) && (_orders.Count>0) && !this.MarkedForDeletion)?_orders:null);
				info.AddValue("_customersCollectionViaOrders", ((_customersCollectionViaOrders!=null) && (_customersCollectionViaOrders.Count>0) && !this.MarkedForDeletion)?_customersCollectionViaOrders:null);
				info.AddValue("_shippersCollectionViaOrders", ((_shippersCollectionViaOrders!=null) && (_shippersCollectionViaOrders.Count>0) && !this.MarkedForDeletion)?_shippersCollectionViaOrders:null);
				info.AddValue("_territoriesCollectionViaEmployeeTerritories", ((_territoriesCollectionViaEmployeeTerritories!=null) && (_territoriesCollectionViaEmployeeTerritories.Count>0) && !this.MarkedForDeletion)?_territoriesCollectionViaEmployeeTerritories:null);
				info.AddValue("_employees", (!this.MarkedForDeletion?_employees:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new EmployeeRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Employee' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployees_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.ReportsTo, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'EmployeeTerritory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeTerritories()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeTerritoryFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Order' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoOrders()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(OrderFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Customer' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCustomersCollectionViaOrders()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CustomersCollectionViaOrders"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Shipper' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoShippersCollectionViaOrders()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ShippersCollectionViaOrders"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Territory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTerritoriesCollectionViaEmployeeTerritories()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("TerritoriesCollectionViaEmployeeTerritories"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Employee' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployees()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.ReportsTo));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._employees_);
			collectionsQueue.Enqueue(this._employeeTerritories);
			collectionsQueue.Enqueue(this._orders);
			collectionsQueue.Enqueue(this._customersCollectionViaOrders);
			collectionsQueue.Enqueue(this._shippersCollectionViaOrders);
			collectionsQueue.Enqueue(this._territoriesCollectionViaEmployeeTerritories);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._employees_ = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeTerritories = (EntityCollection<EmployeeTerritoryEntity>) collectionsQueue.Dequeue();
			this._orders = (EntityCollection<OrderEntity>) collectionsQueue.Dequeue();
			this._customersCollectionViaOrders = (EntityCollection<CustomerEntity>) collectionsQueue.Dequeue();
			this._shippersCollectionViaOrders = (EntityCollection<ShipperEntity>) collectionsQueue.Dequeue();
			this._territoriesCollectionViaEmployeeTerritories = (EntityCollection<TerritoryEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._employees_ != null);
			toReturn |=(this._employeeTerritories != null);
			toReturn |=(this._orders != null);
			toReturn |= (this._customersCollectionViaOrders != null);
			toReturn |= (this._shippersCollectionViaOrders != null);
			toReturn |= (this._territoriesCollectionViaEmployeeTerritories != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeTerritoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeTerritoryEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<OrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(OrderEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CustomerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CustomerEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ShipperEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ShipperEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<TerritoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(TerritoryEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Employees", _employees);
			toReturn.Add("Employees_", _employees_);
			toReturn.Add("EmployeeTerritories", _employeeTerritories);
			toReturn.Add("Orders", _orders);
			toReturn.Add("CustomersCollectionViaOrders", _customersCollectionViaOrders);
			toReturn.Add("ShippersCollectionViaOrders", _shippersCollectionViaOrders);
			toReturn.Add("TerritoriesCollectionViaEmployeeTerritories", _territoriesCollectionViaEmployeeTerritories);
			return toReturn;
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}


		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Address", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BirthDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("City", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Country", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("EmployeeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Extension", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FirstName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("HireDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("HomePhone", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LastName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Notes", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Photo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PhotoPath", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PostalCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Region", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ReportsTo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Title", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TitleOfCourtesy", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _employees</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployees(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _employees, new PropertyChangedEventHandler( OnEmployeesPropertyChanged ), "Employees", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticEmployeeRelations.EmployeeEntityUsingEmployeeIdReportsToStatic, true, signalRelatedEntity, "Employees_", resetFKFields, new int[] { (int)EmployeeFieldIndex.ReportsTo } );
			_employees = null;
		}

		/// <summary> setups the sync logic for member _employees</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployees(IEntityCore relatedEntity)
		{
			if(_employees!=relatedEntity)
			{
				DesetupSyncEmployees(true, true);
				_employees = (EmployeeEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _employees, new PropertyChangedEventHandler( OnEmployeesPropertyChanged ), "Employees", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticEmployeeRelations.EmployeeEntityUsingEmployeeIdReportsToStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEmployeesPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this EmployeeEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();

		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static EmployeeRelations Relations
		{
			get	{ return new EmployeeRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployees_
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), (IEntityRelation)GetRelationsForField("Employees_")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.EmployeeEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.EmployeeEntity, 0, null, null, null, null, "Employees_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'EmployeeTerritory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeTerritories
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<EmployeeTerritoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeTerritoryEntityFactory))), (IEntityRelation)GetRelationsForField("EmployeeTerritories")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.EmployeeEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.EmployeeTerritoryEntity, 0, null, null, null, null, "EmployeeTerritories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Order' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathOrders
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<OrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(OrderEntityFactory))), (IEntityRelation)GetRelationsForField("Orders")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.EmployeeEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.OrderEntity, 0, null, null, null, null, "Orders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Customer' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCustomersCollectionViaOrders
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.OrderEntityUsingEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "Order_");
				return new PrefetchPathElement2(new EntityCollection<CustomerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CustomerEntityFactory))), intermediateRelation,
					(int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.EmployeeEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.CustomerEntity, 0, null, null, GetRelationsForField("CustomersCollectionViaOrders"), null, "CustomersCollectionViaOrders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Shipper' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathShippersCollectionViaOrders
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.OrderEntityUsingEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "Order_");
				return new PrefetchPathElement2(new EntityCollection<ShipperEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ShipperEntityFactory))), intermediateRelation,
					(int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.EmployeeEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.ShipperEntity, 0, null, null, GetRelationsForField("ShippersCollectionViaOrders"), null, "ShippersCollectionViaOrders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Territory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTerritoriesCollectionViaEmployeeTerritories
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.EmployeeTerritoryEntityUsingEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "EmployeeTerritory_");
				return new PrefetchPathElement2(new EntityCollection<TerritoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(TerritoryEntityFactory))), intermediateRelation,
					(int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.EmployeeEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.TerritoryEntity, 0, null, null, GetRelationsForField("TerritoriesCollectionViaEmployeeTerritories"), null, "TerritoriesCollectionViaEmployeeTerritories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployees
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))),	(IEntityRelation)GetRelationsForField("Employees")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.EmployeeEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.EmployeeEntity, 0, null, null, null, null, "Employees", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The Address property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."Address"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Address
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Address, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Address, value); }
		}

		/// <summary> The BirthDate property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."BirthDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> BirthDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)EmployeeFieldIndex.BirthDate, false); }
			set	{ SetValue((int)EmployeeFieldIndex.BirthDate, value); }
		}

		/// <summary> The City property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."City"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String City
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.City, true); }
			set	{ SetValue((int)EmployeeFieldIndex.City, value); }
		}

		/// <summary> The Country property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."Country"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Country
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Country, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Country, value); }
		}

		/// <summary> The EmployeeId property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."EmployeeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 EmployeeId
		{
			get { return (System.Int32)GetValue((int)EmployeeFieldIndex.EmployeeId, true); }
			set	{ SetValue((int)EmployeeFieldIndex.EmployeeId, value); }
		}

		/// <summary> The Extension property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."Extension"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 4<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Extension
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Extension, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Extension, value); }
		}

		/// <summary> The FirstName property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."FirstName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String FirstName
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.FirstName, true); }
			set	{ SetValue((int)EmployeeFieldIndex.FirstName, value); }
		}

		/// <summary> The HireDate property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."HireDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> HireDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)EmployeeFieldIndex.HireDate, false); }
			set	{ SetValue((int)EmployeeFieldIndex.HireDate, value); }
		}

		/// <summary> The HomePhone property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."HomePhone"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 24<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String HomePhone
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.HomePhone, true); }
			set	{ SetValue((int)EmployeeFieldIndex.HomePhone, value); }
		}

		/// <summary> The LastName property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."LastName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String LastName
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.LastName, true); }
			set	{ SetValue((int)EmployeeFieldIndex.LastName, value); }
		}

		/// <summary> The Notes property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."Notes"<br/>
		/// Table field type characteristics (type, precision, scale, length): NText, 0, 0, 1073741823<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Notes
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Notes, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Notes, value); }
		}

		/// <summary> The Photo property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."Photo"<br/>
		/// Table field type characteristics (type, precision, scale, length): Image, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Byte[] Photo
		{
			get { return (System.Byte[])GetValue((int)EmployeeFieldIndex.Photo, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Photo, value); }
		}

		/// <summary> The PhotoPath property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."PhotoPath"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String PhotoPath
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.PhotoPath, true); }
			set	{ SetValue((int)EmployeeFieldIndex.PhotoPath, value); }
		}

		/// <summary> The PostalCode property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."PostalCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String PostalCode
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.PostalCode, true); }
			set	{ SetValue((int)EmployeeFieldIndex.PostalCode, value); }
		}

		/// <summary> The Region property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."Region"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Region
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Region, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Region, value); }
		}

		/// <summary> The ReportsTo property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."ReportsTo"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ReportsTo
		{
			get { return (Nullable<System.Int32>)GetValue((int)EmployeeFieldIndex.ReportsTo, false); }
			set	{ SetValue((int)EmployeeFieldIndex.ReportsTo, value); }
		}

		/// <summary> The Title property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."Title"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 30<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Title, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Title, value); }
		}

		/// <summary> The TitleOfCourtesy property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employees"."TitleOfCourtesy"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String TitleOfCourtesy
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.TitleOfCourtesy, true); }
			set	{ SetValue((int)EmployeeFieldIndex.TitleOfCourtesy, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> Employees_
		{
			get { return GetOrCreateEntityCollection<EmployeeEntity, EmployeeEntityFactory>("Employees", true, false, ref _employees_);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeTerritoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(EmployeeTerritoryEntity))]
		public virtual EntityCollection<EmployeeTerritoryEntity> EmployeeTerritories
		{
			get { return GetOrCreateEntityCollection<EmployeeTerritoryEntity, EmployeeTerritoryEntityFactory>("Employees", true, false, ref _employeeTerritories);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'OrderEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(OrderEntity))]
		public virtual EntityCollection<OrderEntity> Orders
		{
			get { return GetOrCreateEntityCollection<OrderEntity, OrderEntityFactory>("Employees", true, false, ref _orders);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CustomerEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CustomerEntity))]
		public virtual EntityCollection<CustomerEntity> CustomersCollectionViaOrders
		{
			get { return GetOrCreateEntityCollection<CustomerEntity, CustomerEntityFactory>("EmployeesCollectionViaOrders", false, true, ref _customersCollectionViaOrders);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ShipperEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ShipperEntity))]
		public virtual EntityCollection<ShipperEntity> ShippersCollectionViaOrders
		{
			get { return GetOrCreateEntityCollection<ShipperEntity, ShipperEntityFactory>("EmployeesCollectionViaOrders", false, true, ref _shippersCollectionViaOrders);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'TerritoryEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(TerritoryEntity))]
		public virtual EntityCollection<TerritoryEntity> TerritoriesCollectionViaEmployeeTerritories
		{
			get { return GetOrCreateEntityCollection<TerritoryEntity, TerritoryEntityFactory>("EmployeesCollectionViaEmployeeTerritories", false, true, ref _territoriesCollectionViaEmployeeTerritories);	}
		}

		/// <summary> Gets / sets related entity of type 'EmployeeEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(true)]
		public virtual EmployeeEntity Employees
		{
			get	{ return _employees; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncEmployees(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Employees_", "Employees", _employees, true); 
				}
			}
		}
	
		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}
		
		/// <summary>Returns the SD.LLBLGen.Pro.Examples.Auditing.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.EmployeeEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
