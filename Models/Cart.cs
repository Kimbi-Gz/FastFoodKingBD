using System;
using System.Collections.Generic;

namespace FastFoodKing.Models;

public partial class Cart
{
    public long GraphIdBd3a9fe11ce34830bc5c477e0efc37cb { get; set; }

    public string NodeId0b338c97a1404513b4317e3613ea137d { get; set; } = null!;

    public int Id { get; set; }

    public int IdMenu { get; set; }

    public int IdUsers { get; set; }

    public decimal Count { get; set; }

    public virtual Menu IdMenuNavigation { get; set; } = null!;

    public virtual User IdUsersNavigation { get; set; } = null!;
}
