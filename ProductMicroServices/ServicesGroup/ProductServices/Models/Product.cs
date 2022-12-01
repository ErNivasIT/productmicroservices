using System;
using System.Collections.Generic;

namespace ProductServices.Models;

public partial class Product
{
    public long Id { get; set; }

    public string ItemName { get; set; } = null!;

    public byte Qty { get; set; }

    public DateTime AddedOn { get; set; }

    public string AddedBy { get; set; } = null!;

    public string AddedByIp { get; set; } = null!;
}
