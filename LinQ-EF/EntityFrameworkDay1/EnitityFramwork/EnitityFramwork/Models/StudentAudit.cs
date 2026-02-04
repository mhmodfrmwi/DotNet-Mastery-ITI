using System;
using System.Collections.Generic;

namespace EnitityFramwork.Models;

public partial class StudentAudit
{
    public string ServerUserName { get; set; } = null!;

    public DateTime AuditDate { get; set; }

    public string Note { get; set; } = null!;
}
