﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.4.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using AdventureWorks.Dal.Adapter.v54.HelperClasses;
using AdventureWorks.Dal.Adapter.v54.FactoryClasses;
using AdventureWorks.Dal.Adapter.v54.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v54.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'CountryRegion'.<br/><br/></summary>
	[Serializable]
	public partial class CountryRegionEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<CountryRegionCurrencyEntity> _countryRegionCurrencies;
		private EntityCollection<SalesTerritoryEntity> _salesTerritories;
		private EntityCollection<StateProvinceEntity> _stateProvinces;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static CountryRegionEntityStaticMetaData _staticMetaData = new CountryRegionEntityStaticMetaData();
		private static CountryRegionRelations _relationsFactory = new CountryRegionRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name CountryRegionCurrencies</summary>
			public static readonly string CountryRegionCurrencies = "CountryRegionCurrencies";
			/// <summary>Member name SalesTerritories</summary>
			public static readonly string SalesTerritories = "SalesTerritories";
			/// <summary>Member name StateProvinces</summary>
			public static readonly string StateProvinces = "StateProvinces";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class CountryRegionEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public CountryRegionEntityStaticMetaData()
			{
				SetEntityCoreInfo("CountryRegionEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.v54.EntityType.CountryRegionEntity, typeof(CountryRegionEntity), typeof(CountryRegionEntityFactory), false);
				AddNavigatorMetaData<CountryRegionEntity, EntityCollection<CountryRegionCurrencyEntity>>("CountryRegionCurrencies", a => a._countryRegionCurrencies, (a, b) => a._countryRegionCurrencies = b, a => a.CountryRegionCurrencies, () => new CountryRegionRelations().CountryRegionCurrencyEntityUsingCountryRegionCode, typeof(CountryRegionCurrencyEntity), (int)AdventureWorks.Dal.Adapter.v54.EntityType.CountryRegionCurrencyEntity);
				AddNavigatorMetaData<CountryRegionEntity, EntityCollection<SalesTerritoryEntity>>("SalesTerritories", a => a._salesTerritories, (a, b) => a._salesTerritories = b, a => a.SalesTerritories, () => new CountryRegionRelations().SalesTerritoryEntityUsingCountryRegionCode, typeof(SalesTerritoryEntity), (int)AdventureWorks.Dal.Adapter.v54.EntityType.SalesTerritoryEntity);
				AddNavigatorMetaData<CountryRegionEntity, EntityCollection<StateProvinceEntity>>("StateProvinces", a => a._stateProvinces, (a, b) => a._stateProvinces = b, a => a.StateProvinces, () => new CountryRegionRelations().StateProvinceEntityUsingCountryRegionCode, typeof(StateProvinceEntity), (int)AdventureWorks.Dal.Adapter.v54.EntityType.StateProvinceEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static CountryRegionEntity()
		{
		}

		/// <summary> CTor</summary>
		public CountryRegionEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public CountryRegionEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this CountryRegionEntity</param>
		public CountryRegionEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		public CountryRegionEntity(System.String countryRegionCode) : this(countryRegionCode, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		/// <param name="validator">The custom validator object for this CountryRegionEntity</param>
		public CountryRegionEntity(System.String countryRegionCode, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.CountryRegionCode = countryRegionCode;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CountryRegionEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CountryRegionCurrency' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCountryRegionCurrencies() { return CreateRelationInfoForNavigator("CountryRegionCurrencies"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesTerritory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesTerritories() { return CreateRelationInfoForNavigator("SalesTerritories"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'StateProvince' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoStateProvinces() { return CreateRelationInfoForNavigator("StateProvinces"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this CountryRegionEntity</param>
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

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static CountryRegionRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CountryRegionCurrency' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCountryRegionCurrencies	{ get { return _staticMetaData.GetPrefetchPathElement("CountryRegionCurrencies", CommonEntityBase.CreateEntityCollection<CountryRegionCurrencyEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesTerritory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesTerritories	{ get { return _staticMetaData.GetPrefetchPathElement("SalesTerritories", CommonEntityBase.CreateEntityCollection<SalesTerritoryEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'StateProvince' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathStateProvinces	{ get { return _staticMetaData.GetPrefetchPathElement("StateProvinces", CommonEntityBase.CreateEntityCollection<StateProvinceEntity>()); } }

		/// <summary>The CountryRegionCode property of the Entity CountryRegion<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CountryRegion"."CountryRegionCode".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 3.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CountryRegionCode
		{
			get { return (System.String)GetValue((int)CountryRegionFieldIndex.CountryRegionCode, true); }
			set	{ SetValue((int)CountryRegionFieldIndex.CountryRegionCode, value); }
		}

		/// <summary>The ModifiedDate property of the Entity CountryRegion<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CountryRegion"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)CountryRegionFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)CountryRegionFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The Name property of the Entity CountryRegion<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CountryRegion"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)CountryRegionFieldIndex.Name, true); }
			set	{ SetValue((int)CountryRegionFieldIndex.Name, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'CountryRegionCurrencyEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CountryRegionCurrencyEntity))]
		public virtual EntityCollection<CountryRegionCurrencyEntity> CountryRegionCurrencies { get { return GetOrCreateEntityCollection<CountryRegionCurrencyEntity, CountryRegionCurrencyEntityFactory>("CountryRegion", true, false, ref _countryRegionCurrencies); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'SalesTerritoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesTerritoryEntity))]
		public virtual EntityCollection<SalesTerritoryEntity> SalesTerritories { get { return GetOrCreateEntityCollection<SalesTerritoryEntity, SalesTerritoryEntityFactory>("CountryRegion", true, false, ref _salesTerritories); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'StateProvinceEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(StateProvinceEntity))]
		public virtual EntityCollection<StateProvinceEntity> StateProvinces { get { return GetOrCreateEntityCollection<StateProvinceEntity, StateProvinceEntityFactory>("CountryRegion", true, false, ref _stateProvinces); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
	}
}

namespace AdventureWorks.Dal.Adapter.v54
{
	public enum CountryRegionFieldIndex
	{
		///<summary>CountryRegionCode. </summary>
		CountryRegionCode,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.v54.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: CountryRegion. </summary>
	public partial class CountryRegionRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between CountryRegionEntity and CountryRegionCurrencyEntity over the 1:n relation they have, using the relation between the fields: CountryRegion.CountryRegionCode - CountryRegionCurrency.CountryRegionCode</summary>
		public virtual IEntityRelation CountryRegionCurrencyEntityUsingCountryRegionCode
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "CountryRegionCurrencies", true, new[] { CountryRegionFields.CountryRegionCode, CountryRegionCurrencyFields.CountryRegionCode }); }
		}

		/// <summary>Returns a new IEntityRelation object, between CountryRegionEntity and SalesTerritoryEntity over the 1:n relation they have, using the relation between the fields: CountryRegion.CountryRegionCode - SalesTerritory.CountryRegionCode</summary>
		public virtual IEntityRelation SalesTerritoryEntityUsingCountryRegionCode
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "SalesTerritories", true, new[] { CountryRegionFields.CountryRegionCode, SalesTerritoryFields.CountryRegionCode }); }
		}

		/// <summary>Returns a new IEntityRelation object, between CountryRegionEntity and StateProvinceEntity over the 1:n relation they have, using the relation between the fields: CountryRegion.CountryRegionCode - StateProvince.CountryRegionCode</summary>
		public virtual IEntityRelation StateProvinceEntityUsingCountryRegionCode
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "StateProvinces", true, new[] { CountryRegionFields.CountryRegionCode, StateProvinceFields.CountryRegionCode }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticCountryRegionRelations
	{
		internal static readonly IEntityRelation CountryRegionCurrencyEntityUsingCountryRegionCodeStatic = new CountryRegionRelations().CountryRegionCurrencyEntityUsingCountryRegionCode;
		internal static readonly IEntityRelation SalesTerritoryEntityUsingCountryRegionCodeStatic = new CountryRegionRelations().SalesTerritoryEntityUsingCountryRegionCode;
		internal static readonly IEntityRelation StateProvinceEntityUsingCountryRegionCodeStatic = new CountryRegionRelations().StateProvinceEntityUsingCountryRegionCode;

		/// <summary>CTor</summary>
		static StaticCountryRegionRelations() { }
	}
}