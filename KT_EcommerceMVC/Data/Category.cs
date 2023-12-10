﻿using System;
using System.Collections.Generic;

namespace KT_EcommerceMVC.Data;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? CategoryNameAlias { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
