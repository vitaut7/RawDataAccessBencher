﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.3.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace EFCore20.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'UnitMeasure'.</summary>
	public partial class UnitMeasure : CommonEntityBase
	{
		#region Class Extensibility Methods
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();
		#endregion

		/// <summary>Initializes a new instance of the <see cref="UnitMeasure"/> class.</summary>
		public UnitMeasure() : base()
		{
			this.BillOfMaterials = new List<BillOfMaterial>();
			this.Products = new List<Product>();
			this.Products_ = new List<Product>();
			this.ProductVendors = new List<ProductVendor>();
			OnCreated();
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the Name field. </summary>
		public System.String Name { get; set;}
		/// <summary>Gets or sets the UnitMeasureCode field. </summary>
		public System.String UnitMeasureCode { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'BillOfMaterial.UnitMeasure - UnitMeasure.BillOfMaterials (m:1)'</summary>
		public List<BillOfMaterial> BillOfMaterials { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Product.UnitMeasure - UnitMeasure.Products (m:1)'</summary>
		public List<Product> Products { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Product.UnitMeasure_ - UnitMeasure.Products_ (m:1)'</summary>
		public List<Product> Products_ { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ProductVendor.UnitMeasure - UnitMeasure.ProductVendors (m:1)'</summary>
		public List<ProductVendor> ProductVendors { get; set;}
	}
}
