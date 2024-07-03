using System;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.MidasDTO
{
    public partial class RoleUser
    {
        public int RnRoleUserId { get; set; }
        public int? RoleId { get; set; }
        public int? LbcluserId { get; set; }
        public bool? IsAssignBySystem { get; set; }
    }
}
