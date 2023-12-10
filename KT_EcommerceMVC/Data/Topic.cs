using System;
using System.Collections.Generic;

namespace KT_EcommerceMVC.Data;

public partial class Topic
{
    public int TopicId { get; set; }

    public string? TopicName { get; set; }

    public string? EmployeeCode { get; set; }

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
}
