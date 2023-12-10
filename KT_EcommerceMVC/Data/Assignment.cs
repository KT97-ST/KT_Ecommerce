using System;
using System.Collections.Generic;

namespace KT_EcommerceMVC.Data;

public partial class Assignment
{
    public int AssignmentId { get; set; }

    public string EmployeeCode { get; set; } = null!;

    public string DepartmentCode { get; set; } = null!;

    public DateTime? AssignmentDate { get; set; }

    public bool? Active { get; set; }
}
