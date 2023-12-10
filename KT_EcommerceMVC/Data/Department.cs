using System;
using System.Collections.Generic;

namespace KT_EcommerceMVC.Data;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string DepartmentCode { get; set; } = null!;

    public string Department1 { get; set; } = null!;

    public string? Information { get; set; }

    public virtual ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
}
