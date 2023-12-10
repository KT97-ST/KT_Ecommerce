using System;
using System.Collections.Generic;

namespace KT_EcommerceMVC.Data;

public partial class Permission
{
    public int PermissionId { get; set; }

    public int? DepartmentId { get; set; }

    public int? WebPageId { get; set; }

    public bool Add { get; set; }

    public bool Edit { get; set; }

    public bool Delete { get; set; }

    public bool View { get; set; }

    public virtual Department? Department { get; set; }

    public virtual WebPage? WebPage { get; set; }
}
