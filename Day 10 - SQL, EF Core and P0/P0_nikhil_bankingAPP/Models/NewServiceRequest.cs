using System;
using System.Collections.Generic;

namespace P0_nikhil_bankingAPP.Models;

public partial class NewServiceRequest
{
    public int RequestId { get; set; }

    public int? AccNo { get; set; }

    public string? RequestDescription { get; set; }

    public virtual AccountInfo? AccNoNavigation { get; set; }
}
