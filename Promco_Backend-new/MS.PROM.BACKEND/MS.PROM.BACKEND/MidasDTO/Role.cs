using System;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.MidasDTO
{
    public partial class Role
    {
        public int RnRoleId { get; set; }
        public int? WorkflowId { get; set; }
        public string? Role1 { get; set; }
        public int? Weight { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
    }
}
