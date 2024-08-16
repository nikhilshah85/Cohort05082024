using System;
using System.Collections.Generic;

namespace P0_nikhil_bankingAPP.Models;

public partial class CustomerUser
{
    public string UserName { get; set; } = null!;

    public string? Password { get; set; }

    public virtual ICollection<AccountInfo> AccountInfos { get; set; } = new List<AccountInfo>();
}
