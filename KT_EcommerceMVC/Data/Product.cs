using System;
using System.Collections.Generic;

namespace KT_EcommerceMVC.Data;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string? AliasName { get; set; }

    public int CategoryId { get; set; }

    public string? UnitDescription { get; set; }

    public double? UnitPrice { get; set; }

    public string? Image { get; set; }

    public DateTime ProductionDate { get; set; }

    public double Discount { get; set; }

    public int ViewCount { get; set; }

    public string? Description { get; set; }

    public int SupplierId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();

    public virtual ICollection<Friend> Friends { get; set; } = new List<Friend>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Supplier Supplier { get; set; } = null!;
}
