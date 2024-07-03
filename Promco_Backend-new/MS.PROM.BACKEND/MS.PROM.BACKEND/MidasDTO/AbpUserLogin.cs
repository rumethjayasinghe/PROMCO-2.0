using System;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.MidasDTO
{
    public partial class AbpUserLogin
    {
        public long Id { get; set; }
        public string LoginProvider { get; set; } = null!;
        public string ProviderKey { get; set; } = null!;
        public int? TenantId { get; set; }
        public long UserId { get; set; }

        public virtual AbpUser User { get; set; } = null!;
    }
}
