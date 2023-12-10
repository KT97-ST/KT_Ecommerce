using System;
using System.Collections.Generic;

namespace KT_EcommerceMVC.Data;

public partial class Friend
{
    public int FriendId { get; set; }

    public string? CustomerCode { get; set; }

    public int ProductId { get; set; }

    public string? FullName { get; set; }

    public string Email { get; set; } = null!;

    public DateTime SentDate { get; set; }

    public string? Notes { get; set; }
}
