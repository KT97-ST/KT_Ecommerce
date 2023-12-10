using System;
using System.Collections.Generic;

namespace KT_EcommerceMVC.Data;

public partial class QnA
{
    public int QnAid { get; set; }

    public string Question { get; set; } = null!;

    public string Reply { get; set; } = null!;

    public DateOnly DateSubmitted { get; set; }

    public string EmployeeCode { get; set; } = null!;
}
