using System;
using System.Collections.Generic;

namespace KT_EcommerceMVC.Data;

public partial class Assignment
{
    public int AssignmentId { get; set; }

    public int EmployeeId { get; set; }

    public int DepartmentId { get; set; }

    public DateTime? AssignmentDate { get; set; }

    public bool? Active { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}
