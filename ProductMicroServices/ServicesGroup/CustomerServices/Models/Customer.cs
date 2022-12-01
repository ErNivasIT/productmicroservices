using System;
using System.Collections.Generic;

namespace CustomerServices.Models;

public partial class Customer
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string PinCode { get; set; } = null!;

    public DateTime AddedOn { get; set; }

    public string AddedBy { get; set; } = null!;

    public string AddedByIp { get; set; } = null!;
}
