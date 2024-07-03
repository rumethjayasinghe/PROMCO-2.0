using System;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.MidasDTO
{
    public partial class AbpWebhookSubscription
    {
        public Guid Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public int? TenantId { get; set; }
        public string WebhookUri { get; set; } = null!;
        public string Secret { get; set; } = null!;
        public bool IsActive { get; set; }
        public string? Webhooks { get; set; }
        public string? Headers { get; set; }
    }
}
