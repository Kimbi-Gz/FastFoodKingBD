using System;
using System.Collections.Generic;

namespace FastFoodKing.Models;

public partial class Menu
{
    public long GraphIdE0f94030bdef4a499305d6882c0c17f1 { get; set; }

    public string NodeId2330d75fc5db4f23ae1fa6f24ec519be { get; set; } = null!;

    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }

    public int IdCategory { get; set; }

    public virtual ICollection<Cart> Carts { get; } = new List<Cart>();

    public virtual Category IdCategoryNavigation { get; set; } = null!;

    public virtual ICollection<OrdenDetail> OrdenDetails { get; } = new List<OrdenDetail>();
}
