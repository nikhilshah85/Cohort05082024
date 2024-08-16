using System;
using System.Collections.Generic;

namespace P0_nikhil_bankingAPP.Models;

public partial class AccountInfo
{
    public int AccNo { get; set; }

    public string? AccName { get; set; }

    public string? AccType { get; set; }

    public int? AccBalance { get; set; }

    public bool? AccIsActive { get; set; }

    public string? AccCustomer { get; set; }

    public virtual ICollection<NewServiceRequest> NewServiceRequests { get; set; } = new List<NewServiceRequest>();
}
