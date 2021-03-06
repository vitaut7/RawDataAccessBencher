﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.3.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace EFCore20.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'Person.BusinessEntityContact'.</summary>
	public partial class BusinessEntityContact : CommonEntityBase
	{
		#region Class Extensibility Methods
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();
		#endregion

		/// <summary>Initializes a new instance of the <see cref="BusinessEntityContact"/> class.</summary>
		public BusinessEntityContact() : base()
		{
			OnCreated();
		}

		/// <summary>Gets or sets the BusinessEntityId field. </summary>
		public System.Int32 BusinessEntityId { get; set;}
		/// <summary>Gets or sets the ContactTypeId field. </summary>
		public System.Int32 ContactTypeId { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the PersonId field. </summary>
		public System.Int32 PersonId { get; set;}
		/// <summary>Gets or sets the Rowguid field. </summary>
		public System.Guid Rowguid { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Person.BusinessEntityContact.ContactType - ContactType.BusinessEntityContacts (m:1)'</summary>
		public ContactType ContactType { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Person.BusinessEntityContact.BusinessEntity - Person.BusinessEntity.BusinessEntityContacts (m:1)'</summary>
		public BusinessEntity BusinessEntity { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Person.BusinessEntityContact.Person - Person.Person.BusinessEntityContacts (m:1)'</summary>
		public Person Person { get; set;}
	}
}
