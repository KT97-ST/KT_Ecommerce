using System;
using System.Collections.Generic;

namespace KT_EcommerceMVC.Data;

public partial class WebPage
{
    public int WebPageId { get; set; }

    public string TenTrang { get; set; } = null!;

    public string Url { get; set; } = null!;

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
}
