using System;
using System.Collections.Generic;

namespace KT_EcommerceMVC.Data;

public partial class Favorite
{
    public int FavoriteId { get; set; }

    public int? ProductId { get; set; }

    public string? CustomerCode { get; set; }

    public DateTime? ChosenDate { get; set; }

    public string? Description { get; set; }
}
