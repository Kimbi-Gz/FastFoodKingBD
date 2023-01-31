using System;
using System.Collections.Generic;

namespace FastFoodKing.Models;

public partial class OrdenDetail
{
    public long GraphIdB54e542f2309455d9dc23cdfababa628 { get; set; }

    public string NodeId0e3392079dce475dabdee007ef71f07a { get; set; } = null!;

    public int Id { get; set; }

    public int IdMenu { get; set; }

    public decimal Count { get; set; }

    public string Description { get; set; } = null!;

    public decimal Total { get; set; }

    public string UserName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public int Phone { get; set; }

    public virtual Menu IdMenuNavigation { get; set; } = null!;
}
