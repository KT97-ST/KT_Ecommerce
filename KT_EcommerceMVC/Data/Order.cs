using System;
using System.Collections.Generic;

namespace KT_EcommerceMVC.Data;

public partial class Order
{
    public int OrderId { get; set; }

    public string CustomerCode { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public DateTime? RequiredDate { get; set; }

    public DateTime? ShippedDate { get; set; }

    public string? FullName { get; set; }

    public string Address { get; set; } = null!;

    public string PaymentMethod { get; set; } = null!;

    public string ShippingMethod { get; set; } = null!;

    public double ShippingFee { get; set; }

    public int StatusId { get; set; }

    public string? EmployeeCode { get; set; }

    public string? Notes { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Status Status { get; set; } = null!;
}
