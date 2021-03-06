﻿#pragma warning disable 0649
//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;

namespace L2S.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'Store', mapped on table 'AdventureWorks.Sales.Store'.</summary>
	[Table(Name="[Sales].[Store]")]
	public partial class Store : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.Int32	_businessEntityId;
		private System.String	_demographics;
		private System.DateTime	_modifiedDate;
		private System.String	_name;
		private System.Guid	_rowguid;
		private Nullable<System.Int32>	_salesPersonId;
		private EntityRef <BusinessEntity> _businessEntity;
		private EntitySet <Customer> _customers;
		private EntityRef <SalesPerson> _salesPerson;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnBusinessEntityIdChanging(System.Int32 value);
		partial void OnBusinessEntityIdChanged();
		partial void OnDemographicsChanging(System.String value);
		partial void OnDemographicsChanged();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnNameChanging(System.String value);
		partial void OnNameChanged();
		partial void OnRowguidChanging(System.Guid value);
		partial void OnRowguidChanged();
		partial void OnSalesPersonIdChanging(Nullable<System.Int32> value);
		partial void OnSalesPersonIdChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="Store"/> class.</summary>
		public Store()
		{
			_businessEntity = default(EntityRef<BusinessEntity>);
			_customers = new EntitySet<Customer>(new Action<Customer>(this.Attach_Customers), new Action<Customer>(this.Detach_Customers) );
			_salesPerson = default(EntityRef<SalesPerson>);
			OnCreated();
		}

		/// <summary>Raises the PropertyChanging event</summary>
		/// <param name="propertyName">name of the property which is changing</param>
		protected virtual void SendPropertyChanging(string propertyName)
		{
			if((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>Raises the PropertyChanged event for the property specified</summary>
		/// <param name="propertyName">name of the property which was changed</param>
		protected virtual void SendPropertyChanged(string propertyName)
		{
			if((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_Customers(Customer entity)
		{
			this.SendPropertyChanging("Customers");
			entity.Store = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_Customers(Customer entity)
		{
			this.SendPropertyChanging("Customers");
			entity.Store = null;
		}


		#region Class Property Declarations
		/// <summary>Gets or sets the BusinessEntityId field. Mapped on target field 'BusinessEntityID'. </summary>
		[Column(Name="BusinessEntityID", Storage="_businessEntityId", CanBeNull=false, DbType="int NOT NULL", IsPrimaryKey=true)]
		public System.Int32 BusinessEntityId
		{
			get	{ return _businessEntityId; }
			set
			{
				if((_businessEntityId != value))
				{
					if(_businessEntity.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnBusinessEntityIdChanging(value);
					SendPropertyChanging("BusinessEntityId");
					_businessEntityId = value;
					SendPropertyChanged("BusinessEntityId");
					OnBusinessEntityIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the Demographics field. Mapped on target field 'Demographics'. </summary>
		[Column(Name="Demographics", Storage="_demographics", DbType="xml NULL", UpdateCheck=UpdateCheck.Never)]
		public System.String Demographics
		{
			get	{ return _demographics; }
			set
			{
				if((_demographics != value))
				{
					OnDemographicsChanging(value);
					SendPropertyChanging("Demographics");
					_demographics = value;
					SendPropertyChanged("Demographics");
					OnDemographicsChanged();
				}
			}
		}

		/// <summary>Gets or sets the ModifiedDate field. Mapped on target field 'ModifiedDate'. </summary>
		[Column(Name="ModifiedDate", Storage="_modifiedDate", CanBeNull=false, DbType="datetime NOT NULL")]
		public System.DateTime ModifiedDate
		{
			get	{ return _modifiedDate; }
			set
			{
				if((_modifiedDate != value))
				{
					OnModifiedDateChanging(value);
					SendPropertyChanging("ModifiedDate");
					_modifiedDate = value;
					SendPropertyChanged("ModifiedDate");
					OnModifiedDateChanged();
				}
			}
		}

		/// <summary>Gets or sets the Name field. Mapped on target field 'Name'. </summary>
		[Column(Name="Name", Storage="_name", CanBeNull=false, DbType="nvarchar(50) NOT NULL")]
		public System.String Name
		{
			get	{ return _name; }
			set
			{
				if((_name != value))
				{
					OnNameChanging(value);
					SendPropertyChanging("Name");
					_name = value;
					SendPropertyChanged("Name");
					OnNameChanged();
				}
			}
		}

		/// <summary>Gets or sets the Rowguid field. Mapped on target field 'rowguid'. </summary>
		[Column(Name="rowguid", Storage="_rowguid", AutoSync=AutoSync.OnInsert, CanBeNull=false, DbType="uniqueidentifier NOT NULL", IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public System.Guid Rowguid
		{
			get	{ return _rowguid; }
			set
			{
				if((_rowguid != value))
				{
					OnRowguidChanging(value);
					SendPropertyChanging("Rowguid");
					_rowguid = value;
					SendPropertyChanged("Rowguid");
					OnRowguidChanged();
				}
			}
		}

		/// <summary>Gets or sets the SalesPersonId field. Mapped on target field 'SalesPersonID'. </summary>
		[Column(Name="SalesPersonID", Storage="_salesPersonId", DbType="int NULL")]
		public Nullable<System.Int32> SalesPersonId
		{
			get	{ return _salesPersonId; }
			set
			{
				if((_salesPersonId != value))
				{
					if(_salesPerson.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnSalesPersonIdChanging(value);
					SendPropertyChanging("SalesPersonId");
					_salesPersonId = value;
					SendPropertyChanged("SalesPersonId");
					OnSalesPersonIdChanged();
				}
			}
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Store.BusinessEntity - BusinessEntity.Store (1:1)'</summary>
		[Association(Name="Store_BusinessEntity0e17cf7cab6b453db369e20dfab0ce3f", Storage="_businessEntity", ThisKey="BusinessEntityId", IsForeignKey=true, IsUnique=true)]
		public BusinessEntity BusinessEntity
		{
			get { return _businessEntity.Entity; }
			set
			{
				BusinessEntity previousValue = _businessEntity.Entity;
				if((previousValue != value) || (_businessEntity.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("BusinessEntity");
					if(previousValue != null)
					{
						_businessEntity.Entity = null;
						previousValue.Store=null;
					}
					_businessEntity.Entity = value;
					if(value==null)
					{
						_businessEntityId = default(System.Int32);
					}
					else
					{
						value.Store = this;
						_businessEntityId = value.BusinessEntityId;
					}
					this.SendPropertyChanged("BusinessEntity");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Customer.Store - Store.Customers (m:1)'</summary>
		[Association(Name="Customer_Storef77ea94a5bfa4ec49b0aeee356700508", Storage="_customers", OtherKey="StoreId")]
		public EntitySet<Customer> Customers
		{
			get { return this._customers; }
			set { this._customers.Assign(value); }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Store.SalesPerson - SalesPerson.Stores (m:1)'</summary>
		[Association(Name="Store_SalesPerson9439df74a9fa40858c9bf8a08986fca3", Storage="_salesPerson", ThisKey="SalesPersonId", IsForeignKey=true)] 
		public SalesPerson SalesPerson
		{
			get { return _salesPerson.Entity; }
			set
			{
				SalesPerson previousValue = _salesPerson.Entity;
				if((previousValue != value) || (_salesPerson.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("SalesPerson");
					if(previousValue != null)
					{
						_salesPerson.Entity = null;
						previousValue.Stores.Remove(this);
					}
					_salesPerson.Entity = value;
					if(value == null)
					{
						_salesPersonId = default(Nullable<System.Int32>);
					}
					else
					{
						value.Stores.Add(this);
						_salesPersonId = value.BusinessEntityId;
					}
					this.SendPropertyChanged("SalesPerson");
				}
			}
		}
		
		#endregion
	}
}
#pragma warning restore 0649