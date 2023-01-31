using System;
using System.Collections.Generic;

namespace FastFoodKing.Models;

public partial class User
{
    public long GraphId9ed6bb6dd83949949fccb60e13eb412f { get; set; }

    public string NodeId11bc9190857141bf9d9b5b9c57af15e9 { get; set; } = null!;

    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public int? Phone { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Cart> Carts { get; } = new List<Cart>();
}
