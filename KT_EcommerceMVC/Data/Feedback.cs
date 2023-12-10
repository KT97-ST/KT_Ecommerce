using System;
using System.Collections.Generic;

namespace KT_EcommerceMVC.Data;

public partial class Feedback
{
    public int FeedbackId { get; set; }

    public string FeedbackCode { get; set; } = null!;

    public int TopicId { get; set; }

    public string Content { get; set; } = null!;

    public DateOnly DateSent { get; set; }

    public string? FullName { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public bool NeedReply { get; set; }

    public string? Reply { get; set; }

    public DateOnly? ReplyDate { get; set; }

    public virtual Topic Topic { get; set; } = null!;
}
