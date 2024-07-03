﻿using System;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.MidasDTO
{
    public partial class AbpRoleClaim
    {
        public long Id { get; set; }
        public string? ClaimType { get; set; }
        public string? ClaimValue { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public int RoleId { get; set; }
        public int? TenantId { get; set; }

        public virtual AbpRole Role { get; set; } = null!;
    }
}
