﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.3.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace EFCore20.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'Person.PhoneNumberType'.</summary>
	public partial class PhoneNumberType : CommonEntityBase
	{
		#region Class Extensibility Methods
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();
		#endregion

		/// <summary>Initializes a new instance of the <see cref="PhoneNumberType"/> class.</summary>
		public PhoneNumberType() : base()
		{
			this.PersonPhones = new List<PersonPhone>();
			OnCreated();
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the Name field. </summary>
		public System.String Name { get; set;}
		/// <summary>Gets or sets the PhoneNumberTypeId field. </summary>
		public System.Int32 PhoneNumberTypeId { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Person.PersonPhone.PhoneNumberType - Person.PhoneNumberType.PersonPhones (m:1)'</summary>
		public List<PersonPhone> PersonPhones { get; set;}
	}
}
