using System;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.MidasDTO
{
    public partial class AbpPermission
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public string Discriminator { get; set; } = null!;
        public bool IsGranted { get; set; }
        public string Name { get; set; } = null!;
        public int? TenantId { get; set; }
        public int? RoleId { get; set; }
        public long? UserId { get; set; }

        public virtual AbpRole? Role { get; set; }
        public virtual AbpUser? User { get; set; }
    }
}
