using System;
using System.Collections.Generic;

namespace KT_EcommerceMVC.Data;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string? Password { get; set; }

    public string FullName { get; set; } = null!;

    public bool Gender { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public string Email { get; set; } = null!;

    public string? Image { get; set; }

    public bool Active { get; set; }

    public int Role { get; set; }

    public string? RandomKey { get; set; }
}
