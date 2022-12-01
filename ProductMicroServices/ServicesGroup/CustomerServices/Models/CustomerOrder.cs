using System;
using System.Collections.Generic;

namespace CustomerServices.Models;

public partial class CustomerOrder
{
    public long Id { get; set; }

    public long CustomerId { get; set; }

    public long OrderId { get; set; }

    public DateTime AddedOn { get; set; }

    public string AddedBy { get; set; } = null!;

    public string AddedByIp { get; set; } = null!;
}
