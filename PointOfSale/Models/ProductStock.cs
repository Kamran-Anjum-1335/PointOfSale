
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace PointOfSale.Models
{

using System;
    using System.Collections.Generic;
    
public partial class ProductStock
{

    public int ProductQtyId { get; set; }

    public Nullable<int> ProductId { get; set; }

    public Nullable<int> Quantity { get; set; }

    public Nullable<int> BatchId { get; set; }

    public Nullable<decimal> PurchasePrice { get; set; }

    public Nullable<decimal> SalesPrice { get; set; }



    public virtual Batch Batch { get; set; }

    public virtual Product Product { get; set; }

}

}
