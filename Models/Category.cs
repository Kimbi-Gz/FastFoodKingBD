using System;
using System.Collections.Generic;

namespace FastFoodKing.Models;

public partial class Category
{
    public long GraphIdE8413eacd7b54be39f6b78209d3a85d7 { get; set; }

    public string NodeIdE250659f8d484cfd97ada3b7fee6c4c3 { get; set; } = null!;

    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Menu> Menus { get; } = new List<Menu>();
}
