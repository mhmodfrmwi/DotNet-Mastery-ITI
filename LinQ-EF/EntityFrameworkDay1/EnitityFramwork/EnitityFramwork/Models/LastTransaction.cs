using System;
using System.Collections.Generic;

namespace EnitityFramwork.Models;

public partial class LastTransaction
{
    public int UserId { get; set; }

    public int? TransactionAmount { get; set; }
}
